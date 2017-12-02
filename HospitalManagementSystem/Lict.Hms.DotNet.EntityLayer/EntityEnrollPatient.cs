using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lict.Hms.DotNet.EntityLayer
{
    public class EntityEnrollPatient
    {
        public String Id { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public String Dob { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public String State { get; set; }
        public String Plan { get; set; }
    }

    public class EntityPatientDiognasis
    {
        public String Symptoms { get; set; }
        public String DiagnosisProvided { get; set; }
        public String AdministeredBy { get; set; }
        public String DateOfDiagnosis { get; set; }
        public String FollowUpRequireed { get; set; }
        public String DateOfFollowUp { get; set; }
        public String BillId { get; set; }
        public String PatientID { get; set; }
    }

    public class EntityBillInfo
    {
        public String BillId { get; set; }
        public String BillAmount { get; set; }
        public String ModePayment { get; set; }
        public string CardNumber { get; set; }
    }

    public class patientHistory
    {
        public int patientId { get; set; }
    }

    public class patientHistoryByName
    {
        public string patientName { get; set; }
    }

    public class AddPhysician
    {
        public String id { get; set; }
        public String first_name { get; set; }
        public String last_name { get; set; }
        public String Deoartment { get; set; }
        public String edu_quali { get; set; }
        public string experience { get; set; }
        public string state { get; set; }
        public String plan { get; set; }

    }

    public class physicanId
    {
        public String id { get; set; }
    }

    public class searchPhysican
    {
        public string plan { get; set; }
        public string state { get; set; }
        public string depatrment { get; set; }
    }
}
