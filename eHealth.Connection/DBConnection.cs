//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;
//using System.Data.OleDb;
//using System.Data.Odbc;
//using System.Data.ProviderBase;
//using System.Data.Common;


//namespace eHealth.Connection
//{
//    public enum DataProviderType
//    {
//        Oracle, SqlServer, OleDb, Odbc
//    }

//    //public class clsDBConnection
//    //{

//    //}

//    internal class DBFactory
//    {
//        private static DbProviderFactory objFactory = null;

//        public static DbProviderFactory GetDataProvider(DataProviderType provider)
//        {
//            switch (provider)
//            {
//                case DataProviderType.SqlServer:
//                    objFactory = SqlClientFactory.Instance;
//                    break;
//                case DataProviderType.OleDb:
//                    objFactory = OleDbFactory.Instance;
//                    break;
//                //case DataProviderType.Oracle:
//                //    objFactory = OracleClientFactory.Instance;
//                //    break;
//                case DataProviderType.Odbc:
//                    objFactory = OdbcFactory.Instance;
//                    break;
//            }
//            return objFactory;
//        }

//        public static DbConnection GetConnection(DataProviderType providerType)
//        {
//            switch (providerType)
//            {
//                case DataProviderType.SqlServer:
//                    return new SqlConnection();
//                case DataProviderType.OleDb:
//                    return new OleDbConnection();
//                case DataProviderType.Odbc:
//                    return new OdbcConnection();
//                //case ProviderType.Oracle:
//                //    return new OracleConnection();
//                default:
//                    return null;
//            }
//        }

//        public static DbCommand GetCommand(DataProviderType providerType)
//        {
//            switch (providerType)
//            {
//                case DataProviderType.SqlServer:
//                    return new SqlCommand();
//                case DataProviderType.OleDb:
//                    return new OleDbCommand();
//                case DataProviderType.Odbc:
//                    return new OdbcCommand();
//                //case DataProviderType.Oracle:
//                //    return new OracleCommand();
//                default:
//                    return null;
//            }
//        }

//        public static DbDataAdapter GetDataAdapter(DataProviderType providerType)
//        {
//            switch (providerType)
//            {
//                case DataProviderType.SqlServer:
//                    return new SqlDataAdapter();
//                case DataProviderType.OleDb:
//                    return new OleDbDataAdapter();
//                case DataProviderType.Odbc:
//                    return new OdbcDataAdapter();
//                //case DataProviderType.Oracle:
//                //    return new OracleDataAdapter();
//                default:
//                    return null;
//            }
//        }
//    }

//    public sealed class DataManager
//    {
//        private DbConnection dbConnection;
//        private String strConnectionString;
//        private DataProviderType dataProviderType;

//        public void DBManager(DataProviderType providerType, string
//         connectionString)
//        {
//            this.strConnectionString = connectionString;
//            this.dataProviderType = providerType;
//            dbConnection = DBFactory.GetConnection(providerType);
//            dbConnection.ConnectionString = connectionString;
//        }

//        public void Open()
//        {
//            if (dbConnection.State != ConnectionState.Open)
//                dbConnection.Open();
//        }

//        public void Close()
//        {
//            if (dbConnection.State != ConnectionState.Closed)
//                dbConnection.Close();
//        }


//        public DbConnection Connection
//        {
//            get
//            {
//                return dbConnection;
//            }
//        }
//        public String ConnectionString
//        {
//            get
//            {
//                return strConnectionString;
//            }
//        }
//        public DataProviderType DBProvider
//        {
//            get
//            {
//                return dataProviderType;
//            }
//        }
//        public DataSet getDataSet(String sqlString, DbParameterCollection dbParams)
//        {
//            using (DbDataAdapter dbDataAdapter = DBFactory.GetDataAdapter(this.DBProvider))
//            {
//                try
//                {

//                    dbDataAdapter.SelectCommand = DBFactory.GetCommand(this.DBProvider);
//                    dbDataAdapter.SelectCommand.CommandText = sqlString;
//                    Open();
//                    dbDataAdapter.SelectCommand.Connection = this.Connection;

//                    if (dbParams != null)
//                    {
//                        dbDataAdapter.SelectCommand.Parameters.Add(dbParams);
//                    }
//                    DataSet dataSet = new DataSet();
//                    DataTable dataTable = new DataTable();
//                    dataTable.BeginLoadData();
//                    dbDataAdapter.Fill(dataTable);
//                    dataTable.EndLoadData();
//                    dataSet.EnforceConstraints = false;
//                    dataSet.Tables.Add(dataTable);
//                    return dataSet;
//                }

//                catch (Exception ex)
//                {
//                    Close();
//                    return null;

//                }
//                finally
//                {

//                    Close();
//                }
//            }
//        }
//        public DataSet getDataSet(String sqlString)
//        {
//            using (DbDataAdapter dbDataAdapter = DBFactory.GetDataAdapter(this.DBProvider))
//            {
//                try
//                {

//                    dbDataAdapter.SelectCommand = DBFactory.GetCommand(this.DBProvider);
//                    dbDataAdapter.SelectCommand.CommandText = sqlString;
//                    Open();
//                    dbDataAdapter.SelectCommand.Connection = this.Connection;

                   
//                    DataSet dataSet = new DataSet();
//                    DataTable dataTable = new DataTable();
//                    dataTable.BeginLoadData();
//                    dbDataAdapter.Fill(dataTable);
//                    dataTable.EndLoadData();
//                    dataSet.EnforceConstraints = false;
//                    dataSet.Tables.Add(dataTable);
//                    return dataSet;
//                }

//                catch (Exception ex)
//                {
//                    Close();
//                    return null;

//                }
//                finally
//                {

//                    Close();
//                }
//            }
//        }
//        public DbDataReader getDataReader(String sqlString, DbParameterCollection dbParams)
//        {
//            DbDataReader dReader = null;
//            using (DbCommand dbCommand = DBFactory.GetCommand(this.DBProvider))
//            {
//                try
//                {
//                    dbCommand.CommandText = sqlString;
//                    Open();
//                    dbCommand.Connection = this.Connection;

//                    if (dbParams != null)
//                    {
//                        dbCommand.Parameters.Add(dbParams);
                        
//                    }
//                    dReader =    dbCommand.ExecuteReader();
//                    return dReader;
//                }

//                catch (Exception ex)
//                {
//                    Close();
//                    return null;

//                }
//                finally
//                {

//                  //  Close();
//                }
//            }
//        }
//        public DbDataReader getDataReader(String sqlString)
//        {
//            DbDataReader dReader = null;
//            using (DbCommand dbCommand = DBFactory.GetCommand(this.DBProvider))
//            {
//                try
//                {
//                    dbCommand.CommandText = sqlString;
//                    Open();
//                    dbCommand.Connection = this.Connection;

                    
//                    dReader = dbCommand.ExecuteReader();
//                    return dReader;
//                }

//                catch (Exception ex)
//                {
//                    Close();
//                    return null;

//                }
//                finally
//                {

//                    //  Close();
//                }
//            }
//        }
//        public Boolean executeSQLCommand(string sqlString, CommandType dbCommandType, DbParameterCollection dbParams)
//        {
//            DbTransaction trans = null;
//            Boolean result = false;
//            try
//            {
//                using (DbCommand dbCommand = DBFactory.GetCommand(this.DBProvider))
//                {
//                    Open();
//                    trans = this.Connection.BeginTransaction();
//                    dbCommand.CommandText = sqlString;
//                    dbCommand.Connection = this.Connection;
//                    dbCommand.CommandType = dbCommandType;
//                    dbCommand.Transaction = trans;
//                    if (dbParams != null)
//                    {
//                        dbCommand.Parameters.Add(dbParams);
//                    }
//                    dbCommand.ExecuteNonQuery();
//                    trans.Commit();
//                    result = true;
//                    dbCommand.Dispose();
//                }

//            }
//            catch (Exception ex)
//            {
//                if (trans != null)
//                {
//                    trans.Rollback();
//                }
//                result = false;
//            }
//            finally
//            {
//                Close();
//            }
//            return result;
//        }

//    }

//    public class DBContextInfo
//    {
        
//        public string DefaultConnection { get; set; }
//    }
//}
