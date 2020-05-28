using MODEL.User;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserHelper
{
    public static class UserTranslator
    {
        public static User TranslateAsUser(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;

                reader.Read();
            }

            User user = new User();

            if (reader.IsColoumnExist("UserId"))
                user.UserId = DataReader.GetNullableInt32(reader, "UserId");

            if (reader.IsColoumnExist("FirstName"))
                user.FirstName = DataReader.GetNullableString(reader, "FirstName");

            if (reader.IsColoumnExist("LastName"))
                user.LastName = DataReader.GetNullableString(reader, "LastName");

            if (reader.IsColoumnExist("Email"))
                user.Email = DataReader.GetNullableString(reader, "Email");

            return user;
        }

        public static List<User> TranslateAsUserList(this SqlDataReader reader)
        {
            List<User> userList = new List<User>();

            while (reader.Read())
            {
                userList.Add(TranslateAsUser(reader, true));
            }

            return userList;
        }

        public static User TranslateAsUserById(this SqlDataReader reader)
        {
            return TranslateAsUser(reader);
        }
    }
}
