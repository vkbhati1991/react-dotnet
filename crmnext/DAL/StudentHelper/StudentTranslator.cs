using MODEL.Student;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.StudentHelper
{
    public static class StudentTranslator
    {
        public static Student TranslateAsStudent(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;

                reader.Read();
            }


        Student student = new Student();

            if (reader.IsColoumnExist("StudentId"))
                student.StudentId = DataReader.GetNullableInt32(reader, "StudentId");

            if (reader.IsColoumnExist("FirstName"))
                student.FirstName = DataReader.GetNullableString(reader, "FirstName");

            if (reader.IsColoumnExist("MiddleName"))
                student.MiddleName = DataReader.GetNullableString(reader, "MiddleName");

            if (reader.IsColoumnExist("LastName"))
                student.LastName = DataReader.GetNullableString(reader, "LastName");

            if (reader.IsColoumnExist("Email"))
                student.Email = DataReader.GetNullableString(reader, "Email");

            if (reader.IsColoumnExist("UserName"))
                student.UserName = DataReader.GetNullableString(reader, "UserName");

            if (reader.IsColoumnExist("Password"))
                student.Password = DataReader.GetNullableString(reader, "Password");

            if (reader.IsColoumnExist("Phone"))
                student.Phone = DataReader.GetNullableString(reader, "Phone");

            if (reader.IsColoumnExist("DOB"))
                student.DOB = DataReader.GetNullableString(reader, "DOB");

            if (reader.IsColoumnExist("DobInText"))
                student.DobInText = DataReader.GetNullableString(reader, "DobInText");

            if (reader.IsColoumnExist("Gender"))
                student.Gender = DataReader.GetNullableString(reader, "Gender");

            if (reader.IsColoumnExist("Photo"))
                student.Photo = DataReader.GetNullableString(reader, "Photo");

            if (reader.IsColoumnExist("HandiCapped"))
                student.HandiCapped = DataReader.GetNullableString(reader, "HandiCapped");

            if (reader.IsColoumnExist("BloodGroup"))
                student.BloodGroup = DataReader.GetNullableString(reader, "BloodGroup");

            if (reader.IsColoumnExist("Regigion"))
                student.Regigion = DataReader.GetNullableString(reader, "Regigion");

            if (reader.IsColoumnExist("Category"))
                student.Category = DataReader.GetNullableString(reader, "Category");

            if (reader.IsColoumnExist("AadharNo"))
                student.AadharNo = DataReader.GetNullableString(reader, "AadharNo");

            if (reader.IsColoumnExist("BankAccountNumber"))
                student.BankAccountNumber = DataReader.GetNullableString(reader, "BankAccountNumber");

            if (reader.IsColoumnExist("BankName"))
                student.BankName = DataReader.GetNullableString(reader, "BankName");

            if (reader.IsColoumnExist("BankIFSCCode"))
                student.BankIFSCCode = DataReader.GetNullableString(reader, "BankIFSCCode");

            if (reader.IsColoumnExist("FatherFirstName"))
                student.FatherFirstName = DataReader.GetNullableString(reader, "FatherFirstName");

            if (reader.IsColoumnExist("FatherMiddleName"))
                student.FatherMiddleName = DataReader.GetNullableString(reader, "FatherMiddleName");

            if (reader.IsColoumnExist("FatheLastName"))
                student.FatheLastName = DataReader.GetNullableString(reader, "FatheLastName");

            if (reader.IsColoumnExist("MotherFirstName"))
                student.MotherFirstName = DataReader.GetNullableString(reader, "MotherFirstName");

            if (reader.IsColoumnExist("MotherMiddleName"))
                student.MotherMiddleName = DataReader.GetNullableString(reader, "MotherMiddleName");

            if (reader.IsColoumnExist("MotherLastName"))
                student.MotherLastName = DataReader.GetNullableString(reader, "MotherLastName");

            if (reader.IsColoumnExist("AddressOne"))
                student.AddressOne = DataReader.GetNullableString(reader, "AddressOne");

            if (reader.IsColoumnExist("AddressTwo"))
                student.AddressTwo = DataReader.GetNullableString(reader, "AddressTwo");

            if (reader.IsColoumnExist("Block"))
                student.Block = DataReader.GetNullableString(reader, "Block");

            if (reader.IsColoumnExist("PinCode"))
                student.PinCode = DataReader.GetNullableString(reader, "PinCode");

            if (reader.IsColoumnExist("City"))
                student.City = DataReader.GetNullableString(reader, "City");

            if (reader.IsColoumnExist("State"))
                student.State = DataReader.GetNullableString(reader, "State");

            if (reader.IsColoumnExist("Country"))
                student.Country = DataReader.GetNullableString(reader, "Country");

            if (reader.IsColoumnExist("LandMark"))
                student.LandMark = DataReader.GetNullableString(reader, "LandMark");

            if (reader.IsColoumnExist("PermAddressOne"))
                student.PermAddressOne = DataReader.GetNullableString(reader, "PermAddressOne");

            if (reader.IsColoumnExist("PermAddressTwo"))
                student.PermAddressTwo = DataReader.GetNullableString(reader, "PermAddressTwo");

            if (reader.IsColoumnExist("PermBlock"))
                student.PermBlock = DataReader.GetNullableString(reader, "PermBlock");

            if (reader.IsColoumnExist("PermPinCode"))
                student.PermPinCode = DataReader.GetNullableString(reader, "PermPinCode");

            if (reader.IsColoumnExist("PermCity"))
                student.PermCity = DataReader.GetNullableString(reader, "PermCity");

            if (reader.IsColoumnExist("PermState"))
                student.PermState = DataReader.GetNullableString(reader, "PermState");

            if (reader.IsColoumnExist("PermCountry"))
                student.PermCountry = DataReader.GetNullableString(reader, "PermCountry");

            if (reader.IsColoumnExist("PermLandMark"))
                student.PermLandMark = DataReader.GetNullableString(reader, "PermLandMark");

            if (reader.IsColoumnExist("CreatedOn"))
                student.CreatedOn = DataReader.GetNullableString(reader, "CreatedOn");

            if (reader.IsColoumnExist("IsActive"))
                student.IsActive = DataReader.GetNullableInt32(reader, "IsActive");

            if (reader.IsColoumnExist("Role"))
                student.Role = DataReader.GetNullableString(reader, "Role");

            if (reader.IsColoumnExist("IsSms"))
                student.IsSms = DataReader.GetNullableInt32(reader, "IsSms");

            if (reader.IsColoumnExist("IsSpecialNeed"))
                student.IsSpecialNeed = DataReader.GetNullableInt32(reader, "IsSpecialNeed");

            if (reader.IsColoumnExist("RegistrationNo"))
                student.RegistrationNo = DataReader.GetNullableString(reader, "RegistrationNo");

            if (reader.IsColoumnExist("EnrollmentNo"))
                student.EnrollmentNo = DataReader.GetNullableString(reader, "EnrollmentNo");

            if (reader.IsColoumnExist("AnnualIncome"))
                student.AnnualIncome = DataReader.GetNullableString(reader, "AnnualIncome");

            if (reader.IsColoumnExist("CastCertificateNo"))
                student.CastCertificateNo = DataReader.GetNullableString(reader, "CastCertificateNo");

            if (reader.IsColoumnExist("AddmissionType"))
                student.AddmissionType = DataReader.GetNullableString(reader, "AddmissionType");

            if (reader.IsColoumnExist("AddmissionScheme"))
                student.AddmissionScheme = DataReader.GetNullableString(reader, "AddmissionScheme");

            if (reader.IsColoumnExist("OldOrNew"))
                student.OldOrNew = DataReader.GetNullableString(reader, "OldOrNew");

            if (reader.IsColoumnExist("PrevClass"))
                student.PrevClass = DataReader.GetNullableString(reader, "PrevClass");

            if (reader.IsColoumnExist("AddmissionClass"))
                student.AddmissionClass = DataReader.GetNullableString(reader, "AddmissionClass");

            if (reader.IsColoumnExist("Section"))
                student.Section = DataReader.GetNullableString(reader, "Section");

            if (reader.IsColoumnExist("Stream"))
                student.Stream = DataReader.GetNullableString(reader, "Stream");

            if (reader.IsColoumnExist("Session"))
                student.Session = DataReader.GetNullableString(reader, "Session");

            if (reader.IsColoumnExist("PrevSchoolTcNo"))
                student.PrevSchoolTcNo = DataReader.GetNullableString(reader, "PrevSchoolTcNo");

            if (reader.IsColoumnExist("PrevSchoolTcDate"))
                student.PrevSchoolTcDate = DataReader.GetNullableString(reader, "PrevSchoolTcDate");

            if (reader.IsColoumnExist("SchoolerNo"))
                student.SchoolerNo = DataReader.GetNullableString(reader, "SchoolerNo");

            if (reader.IsColoumnExist("DateOfAddmission"))
                student.DateOfAddmission = DataReader.GetNullableString(reader, "DateOfAddmission");

            if (reader.IsColoumnExist("Conveyance"))
                student.Conveyance = DataReader.GetNullableString(reader, "Conveyance");

            if (reader.IsColoumnExist("StudentDocument"))
                student.StudentDocument = DataReader.GetNullableString(reader, "StudentDocument");

            if (reader.IsColoumnExist("FatherPhone"))
                student.FatherPhone = DataReader.GetNullableString(reader, "FatherPhone");

            if (reader.IsColoumnExist("FatherEmail"))
                student.FatherEmail = DataReader.GetNullableString(reader, "FatherEmail");

            if (reader.IsColoumnExist("FatherQualification"))
                student.FatherQualification = DataReader.GetNullableString(reader, "FatherQualification");

            if (reader.IsColoumnExist("FatherAadharNo"))
                student.FatherAadharNo = DataReader.GetNullableString(reader, "FatherAadharNo");

            if (reader.IsColoumnExist("FatherPanNo"))
                student.FatherPanNo = DataReader.GetNullableString(reader, "FatherPanNo");

            if (reader.IsColoumnExist("FatherPhoto"))
                student.FatherPhoto = DataReader.GetNullableString(reader, "FatherPhoto");

            if (reader.IsColoumnExist("FatherDocument"))
                student.FatherDocument = DataReader.GetNullableString(reader, "FatherDocument");

            if (reader.IsColoumnExist("MotherPhone"))
                student.MotherPhone = DataReader.GetNullableString(reader, "MotherPhone");

            if (reader.IsColoumnExist("MotherEmail"))
                student.MotherEmail = DataReader.GetNullableString(reader, "MotherEmail");

            if (reader.IsColoumnExist("MotherQualification"))
                student.MotherQualification = DataReader.GetNullableString(reader, "MotherQualification");

            if (reader.IsColoumnExist("MotherAadharNo"))
                student.MotherAadharNo = DataReader.GetNullableString(reader, "MotherAadharNo");

            if (reader.IsColoumnExist("MotherPanNo"))
                student.MotherPanNo = DataReader.GetNullableString(reader, "MotherPanNo");

            if (reader.IsColoumnExist("MotherPhoto"))
                student.MotherPhoto = DataReader.GetNullableString(reader, "MotherPhoto");

            if (reader.IsColoumnExist("MotherDocument"))
                student.MotherDocument = DataReader.GetNullableString(reader, "MotherDocument");

            if (reader.IsColoumnExist("RemarkOne"))
                student.RemarkOne = DataReader.GetNullableString(reader, "RemarkOne");

            if (reader.IsColoumnExist("RemarkTwo"))
                student.RemarkTwo = DataReader.GetNullableString(reader, "RemarkTwo");

            if (reader.IsColoumnExist("IsTransport"))
                student.IsTransport = DataReader.GetNullableInt32(reader, "IsTransport");

            if (reader.IsColoumnExist("TransportCategory"))
                student.TransportCategory = DataReader.GetNullableString(reader, "TransportCategory");

            if (reader.IsColoumnExist("TransportRoute"))
                student.TransportRoute = DataReader.GetNullableString(reader, "TransportRoute");

            if (reader.IsColoumnExist("TransportFee"))
                student.TransportFee = DataReader.GetNullableString(reader, "TransportFee");

            if (reader.IsColoumnExist("IsHostal"))
                student.IsHostal = DataReader.GetNullableInt32(reader, "IsHostal");

            if (reader.IsColoumnExist("IsBoarding"))
                student.IsBoarding = DataReader.GetNullableInt32(reader, "IsBoarding");

            if (reader.IsColoumnExist("IsLibrary"))
                student.IsLibrary = DataReader.GetNullableInt32(reader, "IsLibrary");

            return student;
        }

        public static List<Student> TranslateAsStudentList(this SqlDataReader reader)
        {
            List<Student> studentList = new List<Student>();

            while (reader.Read())
            {
                studentList.Add(TranslateAsStudent(reader, true));
            }

            return studentList;
        }

        public static Student TranslateAStudentById(this SqlDataReader reader)
        {
            return TranslateAsStudent(reader);
        }
    }
}
