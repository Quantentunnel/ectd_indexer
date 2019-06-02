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
            this.ConnectionString = "Data Source=" + Path2Metadata + "\\metadata.db";

            // Load the connection string
            // see also https://stackoverflow.com/questions/10875612/sqlite-c-unable-to-open-the-database-file
            Connection = new SQLiteConnection(this.ConnectionString, true);
        }

        public void setLifecycleStatus(LifecycleData lifedata)
        {
            using (SQLiteCommand comm = new SQLiteCommand())
            {
                // Check if the file really exist
                if (File.Exists(lifedata.Path + @"\" + lifedata.Filename))
                {
                    // Check if the metadata of the file is stored in the DB
                    DataTable dtInterimResult = this.ExecuteSelectSQLCommand("Select *", "files", "Where path='" + lifedata.Path + "' AND filename ='" + lifedata.Filename + "'");

                    // If yes, then update 
                    if (dtInterimResult.Rows.Count == 1)
                    {
                        try
                        {
                            this.Connection.Open();
                            comm.Connection = this.Connection;

                            // Create the SQLCommand by using a StringBuilder to get more performane rather than using a String-Object
                            StringBuilder SQLCommand = new StringBuilder("UPDATE ");
                            SQLCommand.Append("files");
                            SQLCommand.Append(" SET ");
                            SQLCommand.Append("lifecycle");
                            SQLCommand.Append("=\'");
                            SQLCommand.Append(lifedata.LifecycleAction);
                            SQLCommand.Append("\' , sha256 =\'");
                            SQLCommand.Append(lifedata.SHA256);
                            SQLCommand.Append("\'");
                            SQLCommand.Append(" WHERE path='" + lifedata.Path + "' AND filename ='" + lifedata.Filename + "'");
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
                    else if (dtInterimResult.Rows.Count == 0)
                    {
                        comm.Connection = this.Connection;
                        comm.CommandText = "INSERT INTO files (DID,FID,path,filename,sha256,lifecycle,seq,corresponding_prev_ID,corresponding_next_ID,virtual) VALUES (@DID, @FID, @path, @filename, @sha256, @lifecycle, @seq, @corresponding_prev_ID, @corresponding_next_ID, @virtual)";

                        try
                        {
                            this.Connection.Open();

                            comm.Parameters.AddWithValue("@DID", MainWindow.me.DossierID);
                            comm.Parameters.AddWithValue("@FID", lifedata.ID);
                            comm.Parameters.AddWithValue("@path", lifedata.Path);
                            comm.Parameters.AddWithValue("@filename", lifedata.Filename);
                            comm.Parameters.AddWithValue("@sha256", lifedata.SHA256);
                            comm.Parameters.AddWithValue("@lifecycle", lifedata.LifecycleAction);
                            comm.Parameters.AddWithValue("@seq", lifedata.Seq);
                            comm.Parameters.AddWithValue("@corresponding_prev_ID", lifedata.Corresponding_prev_ID);
                            comm.Parameters.AddWithValue("@corresponding_next_ID", lifedata.Corresponding_next_ID);
                            comm.Parameters.AddWithValue("@virtual", Convert.ToInt32(lifedata.IsCorrespondingVirtual));

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

        public LifecycleData getLifecycleStatus(String ID)
        {
            // Check if the metadata of the file is stored in the DB
            DataTable dtInterimResult = this.ExecuteSelectSQLCommand("Select *", "files", "Where FID='" + ID + "'");
            this.Connection.Close();

            if (dtInterimResult.Rows.Count == 1)
            {
                LifecycleData lifecycle = new LifecycleData();


                return lifecycle;
            }
            else
            {
                return null;
            }
            
        }

        public String getFileStatus(String path, String file)
        {
            // Check if the metadata of the file is stored in the DB
            DataTable dtInterimResult = this.ExecuteSelectSQLCommand("Select *", "files", "Where path='" + path + "' AND filename ='" + file + "'");
            this.Connection.Close();
            if (dtInterimResult.Rows.Count == 1)
            {
                return dtInterimResult.Rows[0][5].ToString();
            }
            else if (dtInterimResult.Rows.Count == 0)
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

    public class LifecycleData
    {
        public LifecycleData()
        {
            ID = "-1";
            Path = "-1";
            Filename = "-1";
            SHA256 = "-1";
            LifecycleAction = "New";
            Seq = "-1";
            Corresponding_prev_ID = "-1";
            Corresponding_next_ID = "-1";
            IsCorrespondingVirtual = false;
        }

        public String ID { get; set; }
        public String Path { get; set; }
        public String Filename { get; set; }
        public String SHA256 { get; set; }
        public String LifecycleAction { get; set; }
        public String Seq { get; set; }
        public String Corresponding_prev_ID { get; set; }
        public String Corresponding_next_ID { get; set; }
        public bool IsCorrespondingVirtual { get; set; }
    
    }
}
