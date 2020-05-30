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

            if (reader.IsColoumnExist("MiddleName"))
                user.MiddleName = DataReader.GetNullableString(reader, "MiddleName");

            if (reader.IsColoumnExist("LastName"))
                user.LastName = DataReader.GetNullableString(reader, "LastName");

            if (reader.IsColoumnExist("Email"))
                user.Email = DataReader.GetNullableString(reader, "Email");

            if (reader.IsColoumnExist("UserName"))
                user.UserName = DataReader.GetNullableString(reader, "UserName");

            if (reader.IsColoumnExist("Password"))
                user.Password = DataReader.GetNullableString(reader, "Password");

            if (reader.IsColoumnExist("Phone"))
                user.Phone = DataReader.GetNullableString(reader, "Phone");

            if (reader.IsColoumnExist("DOB"))
                user.DOB = DataReader.GetNullableString(reader, "DOB");

            if (reader.IsColoumnExist("DobInText"))
                user.DobInText = DataReader.GetNullableString(reader, "DobInText");

            if (reader.IsColoumnExist("Gender"))
                user.Gender = DataReader.GetNullableString(reader, "Gender");

            if (reader.IsColoumnExist("Photo"))
                user.Photo = DataReader.GetNullableString(reader, "Photo");

            if (reader.IsColoumnExist("HandiCapped"))
                user.HandiCapped = DataReader.GetNullableString(reader, "HandiCapped");

            if (reader.IsColoumnExist("BloodGroup"))
                user.BloodGroup = DataReader.GetNullableString(reader, "BloodGroup");

            if (reader.IsColoumnExist("Regigion"))
                user.Regigion = DataReader.GetNullableString(reader, "Regigion");

            if (reader.IsColoumnExist("Category"))
                user.Category = DataReader.GetNullableString(reader, "Category");

            if (reader.IsColoumnExist("AadharNo"))
                user.AadharNo = DataReader.GetNullableString(reader, "AadharNo");

            if (reader.IsColoumnExist("BankAccountNumber"))
                user.BankAccountNumber = DataReader.GetNullableString(reader, "BankAccountNumber");

            if (reader.IsColoumnExist("BankName"))
                user.BankName = DataReader.GetNullableString(reader, "BankName");

            if (reader.IsColoumnExist("BankIFSCCode"))
                user.BankIFSCCode = DataReader.GetNullableString(reader, "BankIFSCCode");

            if (reader.IsColoumnExist("FatherFirstName"))
                user.FatherFirstName = DataReader.GetNullableString(reader, "FatherFirstName");

            if (reader.IsColoumnExist("FatherMiddleName"))
                user.FatherMiddleName = DataReader.GetNullableString(reader, "FatherMiddleName");

            if (reader.IsColoumnExist("FatheLastName"))
                user.FatheLastName = DataReader.GetNullableString(reader, "FatheLastName");

            if (reader.IsColoumnExist("MotherFirstName"))
                user.MotherFirstName = DataReader.GetNullableString(reader, "MotherFirstName");

            if (reader.IsColoumnExist("MotherMiddleName"))
                user.MotherMiddleName = DataReader.GetNullableString(reader, "MotherMiddleName");

            if (reader.IsColoumnExist("MotherLastName"))
                user.MotherLastName = DataReader.GetNullableString(reader, "MotherLastName");

            if (reader.IsColoumnExist("AddressOne"))
                user.AddressOne = DataReader.GetNullableString(reader, "AddressOne");

            if (reader.IsColoumnExist("AddressTwo"))
                user.AddressTwo = DataReader.GetNullableString(reader, "AddressTwo");

            if (reader.IsColoumnExist("Block"))
                user.Block = DataReader.GetNullableString(reader, "Block");

            if (reader.IsColoumnExist("PinCode"))
                user.PinCode = DataReader.GetNullableString(reader, "PinCode");

            if (reader.IsColoumnExist("City"))
                user.City = DataReader.GetNullableString(reader, "City");

            if (reader.IsColoumnExist("State"))
                user.State = DataReader.GetNullableString(reader, "State");

            if (reader.IsColoumnExist("Country"))
                user.Country = DataReader.GetNullableString(reader, "Country");

            if (reader.IsColoumnExist("LandMark"))
                user.LandMark = DataReader.GetNullableString(reader, "LandMark");

            if (reader.IsColoumnExist("PermAddressOne"))
                user.PermAddressOne = DataReader.GetNullableString(reader, "PermAddressOne");

            if (reader.IsColoumnExist("PermAddressTwo"))
                user.PermAddressTwo = DataReader.GetNullableString(reader, "PermAddressTwo");

            if (reader.IsColoumnExist("PermBlock"))
                user.PermBlock = DataReader.GetNullableString(reader, "PermBlock");

            if (reader.IsColoumnExist("PermPinCode"))
                user.PermPinCode = DataReader.GetNullableString(reader, "PermPinCode");

            if (reader.IsColoumnExist("PermCity"))
                user.PermCity = DataReader.GetNullableString(reader, "PermCity");

            if (reader.IsColoumnExist("PermState"))
                user.PermState = DataReader.GetNullableString(reader, "PermState");

            if (reader.IsColoumnExist("PermCountry"))
                user.PermCountry = DataReader.GetNullableString(reader, "PermCountry");

            if (reader.IsColoumnExist("PermLandMark"))
                user.PermLandMark = DataReader.GetNullableString(reader, "PermLandMark");

            if (reader.IsColoumnExist("IsActive"))
                user.IsActive = DataReader.GetNullableInt32(reader, "IsActive");

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
