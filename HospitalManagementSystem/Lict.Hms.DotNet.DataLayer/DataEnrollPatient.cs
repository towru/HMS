using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Lict.Hms.DotNet.DataLayer
{
    public class DataEnrollPatient
    {
       static public string getConnection()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
            return connectionString;
        }
        SqlConnection ObjConnection = new SqlConnection(getConnection());
        SqlCommand ObjCommand = null;
        SqlDataAdapter ObjAdapter = null;
        DataSet ObjDataSet = new DataSet();

        public int DataAddPatient(SqlParameter[] objParameter)
        {
            int result = 0;
            ObjCommand = new SqlCommand("SpAddPatient", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            result = ObjCommand.ExecuteNonQuery();
            ObjConnection.Close();
            return result;
        }
        public DataSet DataFillState()
        {
            
            ObjCommand = new SqlCommand("SpState", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet,"tbl_state");
            ObjConnection.Close();
            return ObjDataSet;
          
        }

        public DataSet DataFillPlan()
        {
            ObjCommand = new SqlCommand("SpPlan", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet, "tbl_plan");
            ObjConnection.Close();
            return ObjDataSet;
        }

        public DataSet DataFillDepart()
        {
            ObjCommand = new SqlCommand("spDepartment", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet, "tbl_Physician");
            ObjConnection.Close();
            return ObjDataSet;
        }

        public DataSet DatagetLastRec()
        {
            ObjCommand = new SqlCommand("lastValue", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet, "tbl_Patient_Details");
            ObjConnection.Close();
            return ObjDataSet;
        }

        public DataSet DataFillPhysician()
        {
            ObjCommand = new SqlCommand("SpPhysician", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet, "tbl_Physician");
            ObjConnection.Close();
            return ObjDataSet;
        }

        //public int DataCheckFname(SqlParameter[] objParameter)
        //{
        //    int count = 0;
        //    ObjCommand = new SqlCommand("SpCheckDuplicate", ObjConnection);
        //    ObjCommand.CommandType = CommandType.StoredProcedure;
        //    ObjCommand.Parameters.AddRange(objParameter);
        //    ObjConnection.Open();
        //    count =Convert.ToInt32(ObjCommand.ExecuteScalar());
        //    ObjConnection.Close();
        //    return count;
        //}

        public int DataAddPatientDiagnonis(SqlParameter[] objParameter)
        {
            int result = 0;
            ObjCommand = new SqlCommand("SpAddPatientDiagnosis", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            result = ObjCommand.ExecuteNonQuery();
            ObjConnection.Close();
            return result;
        }

        public int DataAddPatientBill(SqlParameter[] objParameter)
        {
            int result = 0;
            ObjCommand = new SqlCommand("AddPatientBillInfo", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            result = ObjCommand.ExecuteNonQuery();
            ObjConnection.Close();
            return result;
        }

        public DataSet DataFillPhysicanHistory(SqlParameter[] objParameter)
        {
            ObjCommand = new SqlCommand("SpViewPatientHistory", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet);
            ObjConnection.Close();
            return ObjDataSet;
        }

        public DataSet DataFillPhysicanHistoryByName(SqlParameter[] objParameter)
        {
            ObjCommand = new SqlCommand("spViewPatientHistoryByName", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet);
            ObjConnection.Close();
            return ObjDataSet;
        }


        public int DataAddhysician(SqlParameter[] objParameter)
        {
            int result = 0;
            ObjCommand = new SqlCommand("SpAddPhysician", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            result = ObjCommand.ExecuteNonQuery();
            ObjConnection.Close();
            return result;
        }

        public DataSet DataFillPhysicanId()
        {
            DataSet objPhyId = new DataSet();

            ObjCommand = new SqlCommand("spPhysian", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(objPhyId, "tbl_Physician");
            ObjConnection.Close();
            return objPhyId;

        }

        public DataSet DatasearchPhysicanId(SqlParameter[] objParameter)
        {
            ObjCommand = new SqlCommand("SpViewPhysicanState", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet);
            ObjConnection.Close();
            return ObjDataSet;
        }

        public DataSet DataFillPhysicaSearch(SqlParameter[] objParameter)
        {
            ObjCommand = new SqlCommand("searcPhysicanDetails", ObjConnection);
            ObjCommand.CommandType = CommandType.StoredProcedure;
            ObjCommand.Parameters.AddRange(objParameter);
            ObjConnection.Open();
            ObjAdapter = new SqlDataAdapter(ObjCommand);
            ObjAdapter.Fill(ObjDataSet);
            ObjConnection.Close();
            return ObjDataSet;
        }
    }
}
