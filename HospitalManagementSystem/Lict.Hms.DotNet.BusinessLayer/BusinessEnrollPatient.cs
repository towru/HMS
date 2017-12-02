using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Lict.Hms.DotNet.DataLayer;
using Lict.Hms.DotNet.EntityLayer;
namespace Lict.Hms.DotNet.BusinessLayer
{
    public class BusinessEnrollPatient
    {
        DataEnrollPatient objDataLayer = new DataEnrollPatient();
       // EntityEnrollPatient objEntityLayer = new EntityEnrollPatient();

        DataTable objDataTableOne = new DataTable();
        DataTable objDataTableTwo = new DataTable();
        DataTable objDataTableThree = new DataTable();
        DataTable objDataTableFour = new DataTable();
        DataTable objDataTableFive = new DataTable();
        DataSet objDataTablePhysicanHistory = new DataSet();
        DataTable objDataTablePhysicanId = new DataTable();
        DataTable objDataTableDepartment = new DataTable();
        DataSet objDataSetPhysicanSearch = new DataSet();

        public int businessAddPatient(EntityEnrollPatient objEntityLayer)
        {
            int result=0;
            SqlParameter[] objParameter = new SqlParameter[8];

            objParameter[0] = new SqlParameter("@id", SqlDbType.VarChar, 25);
            objParameter[0].Value = objEntityLayer.Id;

            objParameter[1] = new SqlParameter("@Fname", SqlDbType.VarChar, 25);
            objParameter[1].Value = objEntityLayer.Fname;

            objParameter[2] = new SqlParameter("@Lname", SqlDbType.VarChar, 25);
            objParameter[2].Value = objEntityLayer.Lname;

            objParameter[3] = new SqlParameter("@Dob", SqlDbType.VarChar, 25);
            objParameter[3].Value = objEntityLayer.Dob;

            objParameter[4] = new SqlParameter("@Email", SqlDbType.VarChar, 25);
            objParameter[4].Value = objEntityLayer.Email;

            objParameter[5] = new SqlParameter("@Phone", SqlDbType.VarChar, 25);
            objParameter[5].Value = objEntityLayer.PhoneNumber;

            objParameter[6] = new SqlParameter("@State", SqlDbType.VarChar, 25);
            objParameter[6].Value = objEntityLayer.State;

            objParameter[7] = new SqlParameter("@PlanName", SqlDbType.VarChar, 25);
            objParameter[7].Value = objEntityLayer.Plan;

            //count = objDataLayer.DataCheckFname(objParameter);
            result = objDataLayer.DataAddPatient(objParameter);
            return result;
        }

        public DataTable BusinessFillState()
        {
            objDataTableOne.Clear();
            objDataTableOne = objDataLayer.DataFillState().Tables["tbl_state"];
            return objDataTableOne;
        }
        public DataTable BusinessFillPlan()
        {
            objDataTableTwo.Clear();
            objDataTableTwo = objDataLayer.DataFillPlan().Tables["tbl_plan"];
            return objDataTableTwo;
        }

        public DataTable BusinessFillDepartment()
        {
            objDataTableDepartment.Clear();
            objDataTableDepartment = objDataLayer.DataFillDepart().Tables["tbl_Physician"];
            return objDataTableDepartment;
        }


        public DataTable BusinessGetLastRe()
        {
            objDataTableThree = objDataLayer.DatagetLastRec().Tables["tbl_Patient_Details"];
            return objDataTableThree;
        }

        public DataTable BusinessFillPhysician()
        {
            objDataTableFour.Clear();
            objDataTableFour = objDataLayer.DataFillPhysician().Tables["tbl_Physician"];
            return objDataTableFour;
        }

        public int businessAddPatientDiognasis(EntityPatientDiognasis ObjentityPatient)
        {
            int result = 0;
            SqlParameter[] objParameter = new SqlParameter[8];

            objParameter[0] = new SqlParameter("@Symptoms", SqlDbType.VarChar, 25);
            objParameter[0].Value = ObjentityPatient.Symptoms;

            objParameter[1] = new SqlParameter("@DiagnosisProvided", SqlDbType.VarChar, 25);
            objParameter[1].Value = ObjentityPatient.DiagnosisProvided;

            objParameter[2] = new SqlParameter("@AdministeredBy", SqlDbType.VarChar, 25);
            objParameter[2].Value = ObjentityPatient.AdministeredBy;

            objParameter[3] = new SqlParameter("@DateOfDiagnosis", SqlDbType.VarChar, 25);
            objParameter[3].Value = ObjentityPatient.DateOfDiagnosis;

            objParameter[4] = new SqlParameter("@FollowUpRequireed", SqlDbType.VarChar, 25);
            objParameter[4].Value = ObjentityPatient.FollowUpRequireed;

            objParameter[5] = new SqlParameter("@DateOfFollowUp", SqlDbType.VarChar, 25);
            objParameter[5].Value = ObjentityPatient.DateOfFollowUp;

            objParameter[6] = new SqlParameter("@BillId", SqlDbType.VarChar, 25);
            objParameter[6].Value = ObjentityPatient.BillId;

            objParameter[7] = new SqlParameter("@PatientId", SqlDbType.VarChar, 25);
            objParameter[7].Value = ObjentityPatient.PatientID;

            //count = objDataLayer.DataCheckFname(objParameter);
            result = objDataLayer.DataAddPatientDiagnonis(objParameter);
            return result;
            
        }

        public int businessAddPatientBill(EntityBillInfo objEntityBill)
        {
            int result = 0;
            SqlParameter[] objParameter = new SqlParameter[4];

            objParameter[0] = new SqlParameter("@BillId", SqlDbType.VarChar, 25);
            objParameter[0].Value = objEntityBill.BillId;

            objParameter[1] = new SqlParameter("@BillAmount", SqlDbType.VarChar, 25);
            objParameter[1].Value = objEntityBill.BillAmount;

            objParameter[2] = new SqlParameter("@ModePayment", SqlDbType.VarChar, 25);
            objParameter[2].Value = objEntityBill.ModePayment;

            objParameter[3] = new SqlParameter("@CardNumber", SqlDbType.VarChar, 25);
            objParameter[3].Value = objEntityBill.CardNumber;

            result = objDataLayer.DataAddPatientBill(objParameter);

            return result;
        }


        public DataSet BusinessFillPhysicianHistory(patientHistory objPatientHistory)
        {
            SqlParameter[] objParameter = new SqlParameter[1];

            objParameter[0] = new SqlParameter("@Patientid", SqlDbType.Int);
            objParameter[0].Value = objPatientHistory.patientId;

            objDataTablePhysicanHistory = objDataLayer.DataFillPhysicanHistory(objParameter);
            return objDataTablePhysicanHistory;
        }

        public DataSet BusinessFillPhysicianHistoryByName(patientHistoryByName objPatient)
        {
            SqlParameter[] objParameter = new SqlParameter[1];

            objParameter[0] = new SqlParameter("@PatientFName", SqlDbType.VarChar,25);
            objParameter[0].Value = objPatient.patientName;
            
            objDataTablePhysicanHistory = objDataLayer.DataFillPhysicanHistoryByName(objParameter);
            return objDataTablePhysicanHistory;
        }


        public int businessAddphysician(AddPhysician objentity)
        {
            int result = 0;
            SqlParameter[] objParameter = new SqlParameter[8];

            objParameter[0] = new SqlParameter("@id", SqlDbType.Int);
            objParameter[0].Value = objentity.id;

            objParameter[1] = new SqlParameter("@fname", SqlDbType.VarChar, 50);
            objParameter[1].Value = objentity.first_name;

            objParameter[2] = new SqlParameter("@lname", SqlDbType.VarChar, 50);
            objParameter[2].Value = objentity.last_name;


            objParameter[3] = new SqlParameter("@dep", SqlDbType.VarChar, 50);
            objParameter[3].Value = objentity.Deoartment;

            objParameter[4] = new SqlParameter("@education", SqlDbType.VarChar, 50);
            objParameter[4].Value = objentity.edu_quali;

            objParameter[5] = new SqlParameter("@yrofex", SqlDbType.Int);
            objParameter[5].Value = objentity.experience;

            objParameter[6] = new SqlParameter("@state", SqlDbType.VarChar, 50);
            objParameter[6].Value = objentity.state;


            objParameter[7] = new SqlParameter("@plan", SqlDbType.VarChar, 50);
            objParameter[7].Value = objentity.plan;

            result = objDataLayer.DataAddhysician(objParameter);
            return result;
        }

        public DataTable BusinessFillPhysicanId()
        {
            objDataTablePhysicanId = objDataLayer.DataFillPhysicanId().Tables["tbl_Physician"];
            return objDataTablePhysicanId;
        }

        public DataSet searchStateByPhysicanId(physicanId objentity)
        {
            SqlParameter[] objParameter = new SqlParameter[1];

            objParameter[0] = new SqlParameter("@id", SqlDbType.VarChar, 25);
            objParameter[0].Value = objentity.id;

            objDataTablePhysicanHistory = objDataLayer.DatasearchPhysicanId(objParameter);
            return objDataTablePhysicanHistory;
        }


        public DataSet BusinessFillPhysicianDetails(searchPhysican objphysicanSearch)
        {
            SqlParameter[] objParameterSearch = new SqlParameter[3];

            objParameterSearch[0] = new SqlParameter("@plan", SqlDbType.VarChar, 25);
            objParameterSearch[0].Value = objphysicanSearch.plan;

            objParameterSearch[1] = new SqlParameter("@state", SqlDbType.VarChar, 25);
            objParameterSearch[1].Value = objphysicanSearch.state;

            objParameterSearch[2] = new SqlParameter("@depart", SqlDbType.VarChar, 25);
            objParameterSearch[2].Value = objphysicanSearch.depatrment;

            objDataSetPhysicanSearch = objDataLayer.DataFillPhysicaSearch(objParameterSearch);
            return objDataSetPhysicanSearch;
        }
    }
}
