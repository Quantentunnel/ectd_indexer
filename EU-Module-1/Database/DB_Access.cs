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

        /// <summary>
        /// Get the file id without creating a new one if it does not exist
        /// </summary>
        /// <param name="lifedata"></param>
        /// <returns></returns>
        public String GetFileID(LifecycleData lifedata)
        {
            return this.GetFileID(lifedata, false);
        }

        /// <summary>
        /// Get the file id. If it does not exist, you can choose if a new ID should be generated or not.
        /// If a new ID should be generated, the dossier ID and sequence number is needed.
        /// </summary>
        /// <param name="lifedata"></param>
        /// <param name="CreateNewId"></param>
        /// <returns></returns>
        public String GetFileID(LifecycleData lifedata, bool CreateNewId)
        {
            // Check if the metadata of the file is stored in the DB
            DataTable dtInterimResult = this.ExecuteSelectSQLCommand("Select *", "files", "Where path='" + lifedata.Path + "' AND filename ='" + lifedata.Filename + "'");
            this.Connection.Close();
            if (dtInterimResult.Rows.Count == 1)
            {
                return dtInterimResult.Rows[0][1].ToString();
            }
            else if (dtInterimResult.Rows.Count == 0 && !CreateNewId)
            {
                return "Not yet assigned";
            }
            else if (dtInterimResult.Rows.Count == 0 && CreateNewId)
            {
                // The the next ID
                lifedata.ID= this.GetSequenceCounter(lifedata);

                // We need these information to get a new ID and store it regarding the DossierID and Seq-Number in the database
                if(lifedata.ID != "-1" && lifedata.DID != "-1" && lifedata.Seq != "-1")
                {
                    // Save it to the database
                    this.setLifecycleStatus(lifedata);

                    // Add counter +1
                    this.setSequenceCounter(lifedata);

                    // Return the ID
                    return lifedata.ID;
                }
                else
                {
                    return "N/A";
                }
            }
            else
            {
                return "N/A";
            }
        }

        /// <summary>
        /// Get the current count from the current sequence
        /// </summary>
        /// <param name="lifedata"></param>
        /// <returns></returns>
        public String GetSequenceCounter(LifecycleData lifedata)
        {
            if (lifedata != null)
            {
                String SQLCommand = "Select * from counters Where Seq ='" + lifedata.Seq + "'";
                DataSet dsIntern = new DataSet("internalcountertable");
                SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(SQLCommand, this.Connection);
                DataSet dstmp = new DataSet();
                dataadapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                dataadapter.Fill(dstmp, "countertable");
                if (dstmp.Tables[0].Rows.Count == 1)
                {
                    return dstmp.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    // If there is no sequence counter yet, then it has to be generated
                    using (SQLiteCommand comm = new SQLiteCommand())
                    {
                        comm.Connection = this.Connection;
                        comm.CommandText = "INSERT INTO counters (DID,Seq,Count) VALUES (@DID,  @seq, @count)";

                        try
                        {
                            this.Connection.Open();

                            comm.Parameters.AddWithValue("@DID", MainWindow.me.DossierID);
                            comm.Parameters.AddWithValue("@seq", lifedata.Seq);
                            comm.Parameters.AddWithValue("@count", 1);

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
                        return "1";
                    }
                }
            } else
            { return "-1"; }
        }

        /// <summary>
        /// Add counters by plus 1
        /// </summary>
        /// <param name="lifedata"></param>
        public void setSequenceCounter(LifecycleData lifedata)
        {
            // Add ID which is stored in the database by 1
            String IDinDB = this.GetSequenceCounter(lifedata);
            int ID = Convert.ToInt32(IDinDB);
            ID++;

            // Store it in the Database
            using (SQLiteCommand comm = new SQLiteCommand())
            {
                try
                {
                    this.Connection.Open();
                    comm.Connection = this.Connection;

                    // Create the SQLCommand by using a StringBuilder to get more performane rather than using a String-Object
                    StringBuilder SQLCommand = new StringBuilder("UPDATE ");
                    SQLCommand.Append("counters");
                    SQLCommand.Append(" SET ");
                    SQLCommand.Append("count");
                    SQLCommand.Append("=\'");
                    SQLCommand.Append(ID.ToString());
                    SQLCommand.Append("\'");
                    SQLCommand.Append(" WHERE DID='" + lifedata.DID + "' AND Seq ='" + lifedata.Seq + "'");
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
            DID = "-1";
            ID = "-1";
            Path = "-1";
            Filename = "-1";
            SHA256 = "-1";
            MD5 = "-1";
            LifecycleAction = "New";
            Seq = "-1";
            Corresponding_prev_ID = "-1";
            Corresponding_next_ID = "-1";
            IsCorrespondingVirtual = false;
        }

        // Internal variables
        private String iid;

        // For the database operations
        public String DID { get; set; }
        public String ID {
            get {
                if (this.iid != null)
                {
                    if (this.iid.Length == 1 )
                    {
                        return "0000" + this.iid; ;
                    }
                    else if (this.iid.Length == 2)
                    {
                        return "000" + this.iid; ;
                    } else if (this.iid.Length == 3)
                    {
                        return "00" + this.iid; ;
                    }
                    else if (this.iid.Length == 4)
                    {
                        return "00" + this.iid; ;
                    }
                    else
                    { return this.iid; }
                }
                return null;
            }
            set {
                this.iid = value;
            }
        }

        public String Path { get; set; }
        public String Filename { get; set; }
        public String SHA256 { get; set; }
        public String LifecycleAction { get; set; }
        public String Seq { get; set; }
        public String Corresponding_prev_ID { get; set; }
        public String Corresponding_next_ID { get; set; }
        public bool IsCorrespondingVirtual { get; set; }

        // For the xml creation operations
        public String Fullname { get; set; }
        public String Shortname { get; set; }
        public String MD5 { get; set; }
        public String ModifiedTag { get; set; }
    }
}
