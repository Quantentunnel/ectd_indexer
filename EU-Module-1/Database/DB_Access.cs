using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace eCTD_indexer.Database
{
    public class DB_Access
    {
        public DB_Access(String Path2Metadata)
        {
            // Store the connection string internally.
            this.ConnectionString = "Data Source="+ Path2Metadata + "\\metadata.db";

            // Load the connection string
            // see also https://stackoverflow.com/questions/10875612/sqlite-c-unable-to-open-the-database-file
            Connection = new SQLiteConnection(this.ConnectionString, true);
        }

        public void setLifecycleStatus(String path, String file, String status)
        {
            using (SQLiteCommand comm = new SQLiteCommand())
            {
                // Check if the file really exist
                if (File.Exists(path + @"\" + file))
                {
                    // Calculate the SHA-256 Hash value
                    String sha256 = XML.SHA256.GetChecksum(path + @"\" + file);

                    // Check if the metadata of the file is stored in the DB
                    DataTable dtInterimResult = this.ExecuteSelectSQLCommand("Select *", "files", "Where path='" + path + "' AND filename ='" + file + "'");

                    // If yes, then update 
                    if(dtInterimResult.Rows.Count == 1)
                    {
                        try
                        {
                            this.Connection.Open();
                            comm.Connection = this.Connection;
                            StringBuilder SQLCommand = new StringBuilder("UPDATE ");
                            SQLCommand.Append("files");
                            SQLCommand.Append(" SET ");
                            SQLCommand.Append("lifecycle");
                            SQLCommand.Append("=\'");
                            SQLCommand.Append(status);
                            SQLCommand.Append("\' ");
                            SQLCommand.Append("WHERE path='" + path + "' AND filename ='" + file + "'");
                            comm.CommandText = SQLCommand.ToString();
                            comm.ExecuteNonQuery();
                        }
                        catch (SQLiteException)
                        {

                        }
                        finally
                        {
                            this.Connection.Close();
                        }
                    }

                    // If not, then insert the information into the database
                    else if(dtInterimResult.Rows.Count == 0)
                    {
                        comm.Connection = this.Connection;
                        comm.CommandText = "INSERT INTO files (path,filename,sha256,lifecycle) VALUES (@path, @filename,@sha256,@lifecycle)";

                        try
                        {
                            this.Connection.Open();

                            comm.Parameters.AddWithValue("@path", path);
                            comm.Parameters.AddWithValue("@filename", file);
                            comm.Parameters.AddWithValue("@sha256", sha256);
                            comm.Parameters.AddWithValue("@lifecycle", status);

                            comm.ExecuteNonQuery();
                            comm.Parameters.Clear();
                        }
                        catch (SQLiteException)
                        {
                            
                        }
                        finally
                        {
                            this.Connection.Close();
                        }

                    }

                    // If more than one result is found, then something went wrong.
                    else
                    {
                        throw new Exception();
                    }

                    
                }
                // if the file not exist
                else
                {

                }
            }
        }

        public String getFileStatus(String path, String file)
        {
            // Check if the metadata of the file is stored in the DB
            DataTable dtInterimResult = this.ExecuteSelectSQLCommand("Select *", "files", "Where path='" + path + "' AND filename ='" + file + "'");
            this.Connection.Close();
            if (dtInterimResult.Rows.Count== 1)
            {
                return dtInterimResult.Rows[0][3].ToString();
            }
            else if(dtInterimResult.Rows.Count == 0)
            {
                return "Not yet defined";
            }
            else
            {
                return "N/A";
            }
            
        }

        private DataTable ExecuteSelectSQLCommand(String Select, String Table, String Where)
        {
            String SQLCommand = Select + " from " + Table + " " + Where;
            DataSet dsIntern = new DataSet("internal");
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(SQLCommand, this.Connection);
            DataSet dstmp = new DataSet();
            dataadapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            dataadapter.Fill(dstmp, Table);
            return dstmp.Tables[0];
        }

        private void ExecuteUpdateSQLCommand(String Table, String SetColumn, String SetValue, String Where)
        {
            StringBuilder SQLCommand = new StringBuilder("Update ");
            SQLCommand.Append(Table);
            SQLCommand.Append(" Set ");
            SQLCommand.Append(SetColumn);
            SQLCommand.Append("=\'");
            SQLCommand.Append(SetValue);
            SQLCommand.Append("\' ");
            SQLCommand.Append(Where);
        }

        /*
        * Variables
        */
            // DB Access
        internal SQLiteConnection Connection;
        private String ConnectionString;

        // DataSet, DataAdapter and CommandBuilder
        // private DataSet ds;
        private List<SQLiteDataAdapter> daList = new List<SQLiteDataAdapter>();
        private List<SQLiteCommandBuilder> cbList = new List<SQLiteCommandBuilder>();

        // List of Tables
        private List<String> ListOfTables = new List<String>();
    }
}
