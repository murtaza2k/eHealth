using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using eHealth.Model;
namespace eHealth.BusinessLogic
{

    public class ClsUserMaintaince : clsUsers
    {
        #region "Private Variables ....."
        private SqlConnection con = null;
        private SqlCommand com = null;
        private SqlTransaction trn = null;
        private bool result = false;
        private string sSQLConnection;
        #endregion

        public ClsUserMaintaince()
        {
            try
            {
                //if (HRSystem.Properties.Settings.Default.LiveDB == "Yes")
                //    ///sSQLConnection = HRSystem.Properties.Settings.Default.SQLConnection.ToString();
                //else
                //   /// sSQLConnection = HRSystem.Properties.Settings.Default.SQLConnectionTest.ToString();
            }
            catch (Exception ex)
            {
                sSQLConnection = "";
            }
        }
        public override string UserID
        {
            get
            {
                return _userid;
            }
            set
            {
                _userid = value;
            }
        }
        public override string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public override string PassWord
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public override bool Never
        {
            get
            {
                return _never;
            }
            set
            {
                _never = value;
            }
        }
        public override DateTime TodayDate
        {
            get
            {
                return _todate;
            }
            set
            {
                _todate = value;
            }
        }
        public override DateTime CreateDate
        {
            get
            {
                return _create;
            }
            set
            {
                _create = value;
            }
        }
        public override short ValidDays
        {
            get
            {
                return _validDays;
            }
            set
            {
                _validDays = value;
            }
        }
        public override DateTime ExpireDate
        {
            get
            {
                return _expired;
            }
            set
            {
                _expired = value;
            }
        }

        public override string UserRole
        {
            get
            {
                return _Role;
            }
            set
            {
                _Role = value;
            }
        }

        

        public bool IsValidUser(string UserID)
        {
            try
            {
                result = false;

                con = new SqlConnection("");
                con.Open();

                com = new SqlCommand();
                com.Connection = con;
                com.CommandType = CommandType.Text;

                com.CommandText = "SELECT UserID FROM Users WHERE (UserID = @UserID)";
                com.Parameters.Add("@UserID", SqlDbType.NVarChar, 30).Value = UserID.ToString();
                object getvalue = null;
                getvalue = com.ExecuteScalar();

                if (getvalue == null || getvalue == DBNull.Value)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

                com.Parameters.Clear();
            }
            catch (Exception ex)
            {
                result = false;
                throw ex;
            }
            finally
            {
                if (com != null)
                    com.Dispose();

                if (con != null)
                    con.Dispose();

                com = null;
                con = null;
            }
            return result;
        }
        //public bool CreateUser()
        //{
        //    bool isintran = false;
        //    try
        //    {
        //        result = false;
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();

        //        trn = con.BeginTransaction(IsolationLevel.ReadCommitted);
        //        isintran = true;
        //        com = new SqlCommand();

        //        com.Connection = con;
        //        com.CommandType = CommandType.Text;

        //        com.CommandText = "INSERT INTO Users " +
        //                                      "(UserID, UserName, UserPassWord, IsNever, CreateDate, ValidDays, ExpireDate,RoleID) " +
        //                          "VALUES " +
        //                                      "(@UserID, @UserName, @UserPassWord, @IsNever, @CreateDate, @ValidDays, @ExpireDate,@RoleID)";
        //        com.Parameters.Add("@UserID", SqlDbType.NVarChar, 30).Value = _userid.ToString();
        //        com.Parameters.Add("@UserName", SqlDbType.NVarChar, 255).Value = _username.ToString();
        //        com.Parameters.Add("@UserPassWord", SqlDbType.NVarChar, 60).Value = _password.ToString();
        //        com.Parameters.Add("@RoleID", SqlDbType.VarChar, 30).Value = _Role.ToString();
        //        if (_never == true)
        //        {
        //            com.Parameters.Add("@IsNever", SqlDbType.Bit).Value = true;
        //            com.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = DateTime.Today.ToString("dd/MMM/yyyy");
        //            com.Parameters.Add("@ValidDays", SqlDbType.Int).Value = 0;
        //            com.Parameters.Add("@ExpireDate", SqlDbType.DateTime).Value = DateTime.Today.ToString("dd/MMM/yyyy");
        //        }
        //        else
        //        {
        //            com.Parameters.Add("@IsNever", SqlDbType.Bit).Value = false;
        //            com.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = _create.ToString("dd/MMM/yyyy");
        //            com.Parameters.Add("@ValidDays", SqlDbType.Int).Value = (int)_validDays;
        //            com.Parameters.Add("@ExpireDate", SqlDbType.DateTime).Value = _expired.ToString("dd/MMM/yyyy");

        //        }
        //        com.Transaction = trn;
        //        com.ExecuteNonQuery();

        //        trn.Commit();
        //        result = true;

        //        com.Parameters.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        if (isintran == true)
        //            trn.Rollback();

        //        result = false;
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (com != null)
        //            com.Dispose();

        //        if (con != null)
        //            con.Dispose();

        //        com = null;
        //        con = null;
        //    }
        //    return result;
        //}
        //public bool ChangePassword()
        //{
        //    bool isintran = false;
        //    try
        //    {
        //        result = false;
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();

        //        trn = con.BeginTransaction(IsolationLevel.ReadCommitted);
        //        isintran = true;
        //        com = new SqlCommand();

        //        com = new SqlCommand();
        //        com.Connection = con;
        //        com.CommandType = CommandType.Text;

        //        com.CommandText = "UPDATE Users " +
        //                                 "SET UserName = @UserName, " +
        //                                     "UserPassWord = @UserPassWord, " +
        //                                     "IsNever = @IsNever, " +
        //                                     "CreateDate = @CreateDate, " +
        //                                     "ValidDays = @ValidDays, " +
        //                                     "ExpireDate = @ExpireDate, " +
        //                                     "RoleID = @RoleID " +
        //                         "WHERE " +
        //                                 "UserID = @UserID";
        //        com.Parameters.Add("@UserName", SqlDbType.NVarChar, 255).Value = _username.ToString();
        //        com.Parameters.Add("@UserPassWord", SqlDbType.NVarChar, 60).Value = _password.ToString();
        //        com.Parameters.Add("@RoleID", SqlDbType.VarChar, 30).Value = _Role.ToString();
        //        if (_never == true)
        //        {
        //            com.Parameters.Add("@IsNever", SqlDbType.Bit).Value = true;
        //            com.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = DateTime.Today.ToString("dd/MMM/yyyy");
        //            com.Parameters.Add("@ValidDays", SqlDbType.Int).Value = 0;
        //            com.Parameters.Add("@ExpireDate", SqlDbType.DateTime).Value = DateTime.Today.ToString("dd/MMM/yyyy");
        //        }
        //        else
        //        {
        //            com.Parameters.Add("@IsNever", SqlDbType.Bit).Value = false;
        //            com.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = _create.ToString("dd/MMM/yyyy");
        //            com.Parameters.Add("@ValidDays", SqlDbType.Int).Value = (int)_validDays;
        //            com.Parameters.Add("@ExpireDate", SqlDbType.DateTime).Value = _expired.ToString("dd/MMM/yyyy");
        //        }
        //        com.Parameters.Add("@UserID", SqlDbType.NVarChar, 30).Value = _userid.ToString();
        //        com.Transaction = trn;
        //        com.ExecuteNonQuery();

        //        trn.Commit();
        //        result = true;

        //        com.Parameters.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        if (isintran == true)
        //            trn.Rollback();

        //        result = false;
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (com != null)
        //            com.Dispose();

        //        if (con != null)
        //            con.Dispose();

        //        com = null;
        //        con = null;
        //    }
        //    return result;
        //}
        //public bool ChangeUserName()
        //{
        //    bool isintran = false;
        //    try
        //    {
        //        result = false;
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();

        //        trn = con.BeginTransaction(IsolationLevel.ReadCommitted);
        //        isintran = true;
        //        com = new SqlCommand();

        //        com = new SqlCommand();
        //        com.Connection = con;
        //        com.CommandType = CommandType.Text;

        //        com.CommandText = "UPDATE Users " +
        //                                 "SET UserName = @UserName " +
        //                         "WHERE " +
        //                                 "UserID = @UserID";
        //        com.Parameters.Add("@UserName", SqlDbType.NVarChar, 255).Value = _username.ToString();
        //        com.Parameters.Add("@UserID", SqlDbType.NVarChar, 30).Value = _userid.ToString();
        //        com.Transaction = trn;
        //        com.ExecuteNonQuery();

        //        trn.Commit();
        //        result = true;

        //        com.Parameters.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        if (isintran == true)
        //            trn.Rollback();

        //        result = false;
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (com != null)
        //            com.Dispose();

        //        if (con != null)
        //            con.Dispose();

        //        com = null;
        //        con = null;
        //    }
        //    return result;
        //}


        //public List<clsRole> GetRoles()
        //{

        //    clsRole _role;
        //    List<clsRole> _listrole;
        //    SqlDataReader reader;
        //    try
        //    {
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();

        //        com = new SqlCommand();
        //        com.CommandType = CommandType.Text;

        //        com.CommandText = " SELECT Distinct RoleId From Role_Master";


        //        //  com.CommandText = "SELECT CustID, Name,IsNull(Address,''),IsNull(Telno,'') ,IsNull(EmailID,'') ,IsNull(POBox,''),IsNull(ERP_Code,'') ,IsNull(Cust_Type,'') ,IsNull(ContactPerson,''),IsNull(Fax,''),Isnull(City,'') ,IsNull(Country,'') , IsNull(NatureOfBuisness,'None')   FROM Customer ";
        //        com.Connection = con;
        //        reader = com.ExecuteReader();

        //        _listrole = new List<clsRole>();
        //        _listrole.Clear();


        //        while (reader.Read())
        //        {
        //            _role = new clsRole();

        //            _role.RoleId = clsMisc.SafeGetString(reader, 0);

        //            _listrole.Add(_role);
        //            _role = null;
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        _listrole = null;
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (com != null)
        //            com.Dispose();

        //        if (con != null)
        //            con.Dispose();

        //        com = null;
        //        con = null;
        //    }
        //    return _listrole;
        //}

        //public List<ClsUserMaintaince> getUserLists()
        //{

        //    ClsUserMaintaince _users;
        //    List<ClsUserMaintaince> _listusers;
        //    SqlDataReader reader;
        //    try
        //    {
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();

        //        com = new SqlCommand();
        //        com.CommandType = CommandType.Text;

        //        com.CommandText = " SELECT DISTINCT UPPER(UserName) , UPPER(UserId) , RoleId  From Users Where RoleId ='Insurance Admin'";


        //        //  com.CommandText = "SELECT CustID, Name,IsNull(Address,''),IsNull(Telno,'') ,IsNull(EmailID,'') ,IsNull(POBox,''),IsNull(ERP_Code,'') ,IsNull(Cust_Type,'') ,IsNull(ContactPerson,''),IsNull(Fax,''),Isnull(City,'') ,IsNull(Country,'') , IsNull(NatureOfBuisness,'None')   FROM Customer ";
        //        com.Connection = con;
        //        reader = com.ExecuteReader();

        //        _listusers = new List<ClsUserMaintaince>();
        //        _listusers.Clear();


        //        while (reader.Read())
        //        {
        //            _users = new ClsUserMaintaince();

        //            _users.UserName = clsMisc.SafeGetString(reader, 0).Trim();
        //            _users.UserID = clsMisc.SafeGetString(reader, 1).Trim();
        //            _users.UserRole = clsMisc.SafeGetString(reader, 2);

        //            _listusers.Add(_users);
        //            _users = null;


        //        }
        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        _listusers = null;
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (com != null)
        //            com.Dispose();

        //        if (con != null)
        //            con.Dispose();

        //        com = null;
        //        con = null;
        //    }
        //    return _listusers;

        //}

    }
}