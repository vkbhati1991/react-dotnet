using IDAL.IStudent;
using MODEL.Student;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.StudentHelper
{
    public class StudentHelper : IStudent
    {
        string connectionstring = ConnectionString.CName;
        public string CreateStudent(Student student)
        {
            var outParam = new SqlParameter("@ReturnCode", SqlDbType.NVarChar, 20)
            {
                Direction = ParameterDirection.Output
            };

            SqlParameter[] param = {
                new SqlParameter("@StudentId", student.StudentId),
                new SqlParameter("@FirstName", DataReader.GetStringValue(student.FirstName)),
                new SqlParameter("@MiddleName", DataReader.GetStringValue(student.MiddleName)),
                new SqlParameter("@LastName", DataReader.GetStringValue(student.LastName)),
                new SqlParameter("@Email", DataReader.GetStringValue(student.Email)),
                new SqlParameter("@UserName", DataReader.GetStringValue(student.Email)),
                new SqlParameter("@Phone", DataReader.GetStringValue(student.Phone)),
                new SqlParameter("@DOB", DataReader.GetStringValue(student.DOB)),
                new SqlParameter("@DobInText", DataReader.GetStringValue(student.DobInText)),
                new SqlParameter("@Gender", DataReader.GetStringValue(student.Gender)),
                new SqlParameter("@Photo", DataReader.GetStringValue(student.Photo)),
                new SqlParameter("@HandiCapped", DataReader.GetStringValue(student.HandiCapped)),
                new SqlParameter("@BloodGroup", DataReader.GetStringValue(student.BloodGroup)),
                new SqlParameter("@Regigion", DataReader.GetStringValue(student.Regigion)),
                new SqlParameter("@Category", DataReader.GetStringValue(student.Category)),
                new SqlParameter("@AadharNo", DataReader.GetStringValue(student.AadharNo)),
                new SqlParameter("@BankAccountNumber", DataReader.GetStringValue(student.BankAccountNumber)),
                new SqlParameter("@BankName", DataReader.GetStringValue(student.BankName)),
                new SqlParameter("@BankIFSCCode", DataReader.GetStringValue(student.BankIFSCCode)),
                new SqlParameter("@FatherFirstName", DataReader.GetStringValue(student.FatherFirstName)),
                new SqlParameter("@FatherMiddleName", DataReader.GetStringValue(student.FatherMiddleName)),
                new SqlParameter("@FatheLastName", DataReader.GetStringValue(student.FatheLastName)),
                new SqlParameter("@MotherFirstName", DataReader.GetStringValue(student.MotherFirstName)),
                new SqlParameter("@MotherMiddleName", DataReader.GetStringValue(student.MotherMiddleName)),
                new SqlParameter("@MotherLastName", DataReader.GetStringValue(student.MotherLastName)),
                new SqlParameter("@AddressOne", DataReader.GetStringValue(student.AddressOne)),
                new SqlParameter("@AddressTwo", DataReader.GetStringValue(student.AddressTwo)),
                new SqlParameter("@Block", DataReader.GetStringValue(student.Block)),
                new SqlParameter("@PinCode", DataReader.GetStringValue(student.PinCode)),
                new SqlParameter("@City", DataReader.GetStringValue(student.City)),
                new SqlParameter("@State", DataReader.GetStringValue(student.State)),
                new SqlParameter("@Country", DataReader.GetStringValue(student.Country)),
                new SqlParameter("@LandMark", DataReader.GetStringValue(student.LandMark)),
                new SqlParameter("@PermAddressOne", DataReader.GetStringValue(student.PermAddressOne)),
                new SqlParameter("@PermAddressTwo", DataReader.GetStringValue(student.PermAddressTwo)),
                new SqlParameter("@PermBlock", DataReader.GetStringValue(student.PermBlock)),
                new SqlParameter("@PermPinCode", DataReader.GetStringValue(student.PermPinCode)),
                new SqlParameter("@PermCity", DataReader.GetStringValue(student.PermCity)),
                new SqlParameter("@PermState", DataReader.GetStringValue(student.PermState)),
                new SqlParameter("@PermCountry", DataReader.GetStringValue(student.PermCountry)),
                new SqlParameter("@PermLandMark", DataReader.GetStringValue(student.PermLandMark)),
                new SqlParameter("@CreatedOn", DataReader.GetStringValue(student.CreatedOn)),
                new SqlParameter("@OldOrNew", DataReader.GetStringValue(student.OldOrNew)),
                new SqlParameter("@PrevClass", DataReader.GetStringValue(student.PrevClass)),
                new SqlParameter("@IsActive", DataReader.GetIntValue(student.IsActive)),
                new SqlParameter("@Role", DataReader.GetIntValue(student.Role)),
                new SqlParameter("@IsSms", DataReader.GetIntValue(student.IsSms)),
                new SqlParameter("@IsSpecialNeed", DataReader.GetIntValue(student.IsSpecialNeed)),
                new SqlParameter("@RegistrationNo", DataReader.GetStringValue(student.RegistrationNo)),
                new SqlParameter("@EnrollmentNo", DataReader.GetStringValue(student.EnrollmentNo)),
                new SqlParameter("@AnnualIncome", DataReader.GetStringValue(student.AnnualIncome)),
                new SqlParameter("@CastCertificateNo", DataReader.GetStringValue(student.CastCertificateNo)),
                new SqlParameter("@AddmissionType", DataReader.GetStringValue(student.AddmissionType)),
                new SqlParameter("@AddmissionScheme", DataReader.GetStringValue(student.AddmissionScheme)),
                new SqlParameter("@AddmissionClass", DataReader.GetStringValue(student.AddmissionClass)),
                new SqlParameter("@Section", DataReader.GetStringValue(student.Section)),
                new SqlParameter("@Stream", DataReader.GetStringValue(student.Stream)),
                new SqlParameter("@Session", DataReader.GetStringValue(student.Session)),
                new SqlParameter("@PrevSchoolTcNo", DataReader.GetStringValue(student.PrevSchoolTcNo)),
                new SqlParameter("@PrevSchoolTcDate", DataReader.GetStringValue(student.PrevSchoolTcDate)),
                new SqlParameter("@SchoolerNo", DataReader.GetStringValue(student.SchoolerNo)),
                new SqlParameter("@DateOfAddmission", DataReader.GetStringValue(student.DateOfAddmission)),
                new SqlParameter("@Conveyance", DataReader.GetStringValue(student.Conveyance)),
                new SqlParameter("@StudentDocument", DataReader.GetStringValue(student.StudentDocument)),
                new SqlParameter("@FatherPhone", DataReader.GetStringValue(student.FatherPhone)),
                new SqlParameter("@FatherEmail", DataReader.GetStringValue(student.FatherEmail)),
                new SqlParameter("@FatherQualification", DataReader.GetStringValue(student.FatherQualification)),
                new SqlParameter("@FatherAadharNo", DataReader.GetStringValue(student.FatherAadharNo)),
                new SqlParameter("@FatherPanNo", DataReader.GetStringValue(student.FatherPanNo)),
                new SqlParameter("@FatherPhoto", DataReader.GetStringValue(student.FatherPhoto)),
                new SqlParameter("@FatherDocument", DataReader.GetStringValue(student.FatherDocument)),
                new SqlParameter("@MotherPhone", DataReader.GetStringValue(student.MotherPhone)),
                new SqlParameter("@MotherEmail", DataReader.GetStringValue(student.MotherEmail)),
                new SqlParameter("@MotherQualification", DataReader.GetStringValue(student.MotherQualification)),
                new SqlParameter("@MotherAadharNo", DataReader.GetStringValue(student.MotherAadharNo)),
                new SqlParameter("@MotherPanNo", DataReader.GetStringValue(student.MotherPanNo)),
                new SqlParameter("@MotherPhoto", DataReader.GetStringValue(student.MotherPhoto)),
                new SqlParameter("@MotherDocument", DataReader.GetStringValue(student.MotherDocument)),
                new SqlParameter("@RemarkOne", DataReader.GetStringValue(student.RemarkOne)),
                new SqlParameter("@RemarkTwo", DataReader.GetStringValue(student.RemarkTwo)),
                new SqlParameter("@IsTransport", DataReader.GetStringValue(student.IsTransport)),
                new SqlParameter("@TransportCategory", DataReader.GetStringValue(student.TransportCategory)),
                new SqlParameter("@TransportRoute", DataReader.GetStringValue(student.TransportRoute)),
                new SqlParameter("@TransportFee", DataReader.GetStringValue(student.TransportFee)),
                new SqlParameter("@IsHostal", DataReader.GetStringValue(student.IsHostal)),
                new SqlParameter("@IsBoarding", DataReader.GetStringValue(student.IsBoarding)),
                 new SqlParameter("@IsLibrary", DataReader.GetStringValue(student.IsLibrary)),

                outParam
            };


            DALBase.ExecuteProcedureReturnString(connectionstring, "spAddStudent", param);

            return (string)outParam.Value;
        }

        public string DeleteStudent(Student student)
        {
            var outParam = new SqlParameter("@ReturnCode", SqlDbType.NVarChar, 20)
            {
                Direction = ParameterDirection.Output
            };

            SqlParameter[] parms = {
                new SqlParameter("@StudentId", student.StudentId),
                outParam
            };

            DALBase.ExecuteProcedureReturnString(connectionstring, "spDeleteStudent", parms);

            return (string)outParam.Value;
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = DALBase.ExtecuteProcedureReturnData(connectionstring, "spGetAllStudents", r => r.TranslateAsStudentList());
            return students;
        }

        public Student GetStudentById(int StudentId)
        {
            SqlParameter[] parms = { new SqlParameter("@StudentId", StudentId) };
            return DALBase.ExtecuteProcedureReturnData(connectionstring, "spGetStudentById", r => r.TranslateAsStudent(), parms);
        }
    }
}
