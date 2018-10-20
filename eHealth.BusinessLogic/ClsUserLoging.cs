using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using eHealth.Model;

namespace eHealth.BusinessLogic
{
    public class ClsUserLoging : clsUsers
    {

        #region "Private Variables ....."
        private SqlConnection con = null;
        private SqlCommand com = null;
        private SqlDataReader reader = null;

        private ClsUserLoging objClsUsers = null;
        private clsRole objUserRoles = null;
        #endregion

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
        //public ClsUserLoging IsValidLog(string UserID, string PassWord)
        //{
        //    try
        //    {
        //        objClsUsers = null;
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();

        //        com = new SqlCommand();
        //        com.Connection = con;
        //        com.CommandType = CommandType.Text;

        //        com.CommandText = "SELECT UserName, IsNever, CreateDate, ValidDays, ExpireDate,RoleID FROM Users WHERE (UserID = @UserID) AND (UserPassWord = @UserPassWord)";
        //        com.Parameters.Add("@UserID", SqlDbType.NVarChar, 30).Value = UserID.ToString().Trim();
        //        com.Parameters.Add("@UserPassWord", SqlDbType.NVarChar, 60).Value = PassWord.ToString().Trim();
        //        reader = com.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            objClsUsers = new ClsUserLoging();
        //            objClsUsers.UserName = clsMisc.SafeGetString(reader, 0);
        //            objClsUsers.Never = reader.GetBoolean(1);
        //            objClsUsers.CreateDate = clsMisc.SafeGetDatetime(reader, 2);
        //            objClsUsers.ValidDays = (short)reader.GetInt32(3);
        //            objClsUsers.ExpireDate = clsMisc.SafeGetDatetime(reader, 4);
        //            objClsUsers._Role = reader.GetString(5);
        //        }

        //        reader.Close();

        //        com.Parameters.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        objClsUsers = null;
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
        //    return objClsUsers;
        //}

        //public clsRole GetUserAccess(string UserRole, string Right)
        //{
        //    try
        //    {
        //        objUserRoles = null;
        //        con = new SqlConnection(clsMisc.getSQLConnection());
        //        con.Open();

        //        com = new SqlCommand();
        //        com.Connection = con;
        //        com.CommandType = CommandType.Text;

        //        com.CommandText = "SELECT [RoleID],[Right],[Add],[Edit],[Delete],[Approval],DocumentAdd,  DocumentEdit,  DocumentDelete " +
        //                            " FROM [Role_Master] Where RoleID = @RoleID And [Right]=@Right";
        //        com.Parameters.Add("@RoleID", SqlDbType.VarChar, 30).Value = UserRole.ToString().Trim();
        //        com.Parameters.Add("@Right", SqlDbType.VarChar, 30).Value = Right.ToString().Trim();
        //        reader = com.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            objUserRoles = new clsRole();
        //            objUserRoles.RoleId = reader.GetString(0);
        //            objUserRoles.Right = reader.GetString(1);
        //            objUserRoles.Add = reader.GetBoolean(2);
        //            objUserRoles.Edit = reader.GetBoolean(3);
        //            objUserRoles.Delete = reader.GetBoolean(4);
        //            objUserRoles.Approval = reader.GetBoolean(5);
        //            objUserRoles.DocumentAdd = reader.GetBoolean(6);
        //            objUserRoles.DocumentEdit = reader.GetBoolean(7);
        //            objUserRoles.DocumentDelete = reader.GetBoolean(8);


        //        }

        //        reader.Close();

        //        com.Parameters.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        objUserRoles = null;
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
        //    return objUserRoles;
        //}
    }
}
