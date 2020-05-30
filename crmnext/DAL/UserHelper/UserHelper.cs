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
                new SqlParameter("@MiddleName", DataReader.GetStringValue(user.MiddleName)),
                new SqlParameter("@LastName", DataReader.GetStringValue(user.LastName)),
                new SqlParameter("@Email", DataReader.GetStringValue(user.Email)),
                new SqlParameter("@Password", DataReader.GetStringValue(user.Password)),
                new SqlParameter("@Phone", DataReader.GetStringValue(user.Phone)),
                new SqlParameter("@DOB", DataReader.GetStringValue(user.DOB)),
                new SqlParameter("@DobInText", DataReader.GetStringValue(user.DobInText)),
                new SqlParameter("@Gender", DataReader.GetStringValue(user.Gender)),
                new SqlParameter("@Photo", DataReader.GetStringValue(user.Photo)),
                new SqlParameter("@HandiCapped", DataReader.GetStringValue(user.HandiCapped)),
                new SqlParameter("@BloodGroup", DataReader.GetStringValue(user.BloodGroup)),
                new SqlParameter("@Regigion", DataReader.GetStringValue(user.Regigion)),
                new SqlParameter("@AadharNo", DataReader.GetStringValue(user.AadharNo)),
                new SqlParameter("@BankAccountNumber", DataReader.GetStringValue(user.BankAccountNumber)),
                new SqlParameter("@BankName", DataReader.GetStringValue(user.BankName)),
                new SqlParameter("@BankIFSCCode", DataReader.GetStringValue(user.BankIFSCCode)),
                new SqlParameter("@FatherFirstName", DataReader.GetStringValue(user.FatherFirstName)),
                new SqlParameter("@FatherMiddleName", DataReader.GetStringValue(user.FatherMiddleName)),
                new SqlParameter("@FatheLastName", DataReader.GetStringValue(user.FatheLastName)),
                new SqlParameter("@MotherFirstName", DataReader.GetStringValue(user.MotherFirstName)),
                new SqlParameter("@MotherMiddleName", DataReader.GetStringValue(user.MotherMiddleName)),
                new SqlParameter("@MotherLastName", DataReader.GetStringValue(user.MotherLastName)),
                new SqlParameter("@AddressOne", DataReader.GetStringValue(user.AddressOne)),
                new SqlParameter("@AddressTwo", DataReader.GetStringValue(user.AddressTwo)),
                new SqlParameter("@Block", DataReader.GetStringValue(user.Block)),
                new SqlParameter("@PinCode", DataReader.GetStringValue(user.PinCode)),
                new SqlParameter("@City", DataReader.GetStringValue(user.City)),
                new SqlParameter("@State", DataReader.GetStringValue(user.State)),
                new SqlParameter("@Country", DataReader.GetStringValue(user.Country)),
                new SqlParameter("@LandMark", DataReader.GetStringValue(user.LandMark)),
                new SqlParameter("@PermAddressOne", DataReader.GetStringValue(user.PermAddressOne)),
                new SqlParameter("@PermAddressTwo", DataReader.GetStringValue(user.PermAddressTwo)),
                new SqlParameter("@PermBlock", DataReader.GetStringValue(user.PermBlock)),
                new SqlParameter("@PermPinCode", DataReader.GetStringValue(user.PermPinCode)),
                new SqlParameter("@PermCity", DataReader.GetStringValue(user.PermCity)),
                new SqlParameter("@PermState", DataReader.GetStringValue(user.PermState)),
                new SqlParameter("@PermCountry", DataReader.GetStringValue(user.PermCountry)),
                new SqlParameter("@PermLandMark", DataReader.GetStringValue(user.PermLandMark)),
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
