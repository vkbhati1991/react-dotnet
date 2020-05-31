using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.UserField;

namespace MODEL.Student
{
    public class Student : UserField.UserField
    {
        public int StudentId { get; set; }
        public int IsSms { get; set; }
        public int IsSpecialNeed { get; set; }
        public string RegistrationNo { get; set; }
        public string EnrollmentNo { get; set; }
        public string AnnualIncome { get; set; }
        public string CastCertificateNo {get; set;}
        public string AddmissionType { get; set; }
        public string AddmissionScheme { get; set; }
        public string OldOrNew { get; set; }
        public string PrevClass { get; set; }
        public string AddmissionClass { get; set; }
        public string Section { get; set; }
        public string Stream { get; set; }
        public string Session { get; set; }
        public string PrevSchoolTcNo { get; set; }
        public string PrevSchoolTcDate { get; set; }
        public string SchoolerNo { get; set; }
        public string DateOfAddmission { get; set; }
        public string Conveyance { get; set; }
        public string StudentDocument { get; set; }
        public string FatherPhone { get; set; }
        public string FatherEmail { get; set; }
        public string FatherQualification { get; set; }
        public string FatherAadharNo { get; set; }
        public string FatherPanNo { get; set; }
        public string FatherPhoto { get; set; }
        public string FatherDocument { get; set; }
        public string MotherPhone { get; set; }
        public string MotherEmail { get; set; }
        public string MotherQualification { get; set; }
        public string MotherAadharNo { get; set; }
        public string MotherPanNo { get; set; }
        public string MotherPhoto { get; set; }
        public string MotherDocument { get; set; }
        public string RemarkOne { get; set; }
        public string RemarkTwo { get; set; }
        public int IsTransport { get; set; }
        public string TransportCategory { get; set; }
        public string TransportRoute { get; set; }
        public string TransportFee { get; set; }
        public int IsHostal { get; set; }
        public int IsBoarding { get; set; }
        public int IsLibrary { get; set; }

    }
}
