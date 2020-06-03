using IDAL.IUser;
using MODEL.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserHelper
{
    public class UserHelper : IUser
    {
        string connectionstring = ConnectionString.CName;

        public string CreateUser(User user)
        {
            var outParam = new SqlParameter("@ReturnCode", SqlDbType.NVarChar, 20)
            {
                Direction = ParameterDirection.Output
            };

            SqlParameter[] param = {
                new SqlParameter("@UserId", user.UserId),
                new SqlParameter("@FirstName", DataReader.GetStringValue(user.FirstName)),
                new SqlParameter("@LastName", DataReader.GetStringValue(user.LastName)),
                new SqlParameter("@Email", DataReader.GetStringValue(user.Email)),
                new SqlParameter("@Password", DataReader.GetStringValue(user.Password)),
                new SqlParameter("@IsActive", DataReader.GetIntValue(user.IsActive)),
                outParam
            };

            DALBase.ExecuteProcedureReturnString(connectionstring, "spAddUser", param);

            return (string)outParam.Value;
        }

        public string DeleteUser(User user)
        {
            var outParam = new SqlParameter("@ReturnCode", SqlDbType.NVarChar, 20)
            {
                Direction = ParameterDirection.Output
            };

            SqlParameter[] parms = {
                new SqlParameter("@UserId", user.UserId),
                outParam
            };

            DALBase.ExecuteProcedureReturnString(connectionstring, "spDeleteUser", parms);

            return (string)outParam.Value;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = DALBase.ExtecuteProcedureReturnData(connectionstring, "spGetAllUsers", r => r.TranslateAsUserList());
            return users;
        }

        public User GetUserById(int UserId)
        {
            SqlParameter[] parms = { new SqlParameter("@UserId", UserId) };
            return DALBase.ExtecuteProcedureReturnData(connectionstring, "spGetUserById", r => r.TranslateAsUserById(), parms);
        }
    }
}
