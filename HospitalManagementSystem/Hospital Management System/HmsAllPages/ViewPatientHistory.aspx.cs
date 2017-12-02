using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Lict.Hms.DotNet.BusinessLayer;
using Lict.Hms.DotNet.EntityLayer;
namespace Hospital_Management_System.HmsAllPages
{
    public partial class ViewPatientHistory : System.Web.UI.Page
    {
        
        BusinessEnrollPatient objBusinessLayer = new BusinessEnrollPatient();
        DataSet objDataSetOne = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblShow.Text ="";
            }
           
            
        }

        protected void btnId_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
            repeterShowPatient.Visible = true;
            if (txtId.Text =="" && txtName.Text =="")
            {
                lblShow.Text = "Please Enter Patient Id or Name";
            }

            else if (txtId.Text =="" && txtName.Text != "")
            {
                lblShow.Text = "";
                patienHistoryName();

            }
            else if (txtId.Text !="" && txtName.Text == "")
            {
                lblShow.Text = "";
                patienHistoryId();
            }
            else if (txtId.Text !="" && txtName.Text !="")
            {
                lblShow.Text = "Data Show By ID";
                patienHistoryId();
            }
        }


        public void patienHistoryId()
        {
            try
            {
                patientHistory objPatientHistory = new patientHistory();
                objPatientHistory.patientId = Convert.ToInt32(txtId.Text);
                objDataSetOne = objBusinessLayer.BusinessFillPhysicianHistory(objPatientHistory);
                if (objDataSetOne.Tables[0].Rows.Count == 0)
                {
                    lblShow.Text = "Record Not Found";
                    repeterShowPatient.Visible = false;
                }
                else
                {

                    repeterShowPatient.DataSource = objDataSetOne;
                    repeterShowPatient.DataBind();
                }
            }
            catch (Exception ex)
            {

                lblShow.Text = ex.Message;
            }
           
        }

        public void patienHistoryName()
        { 
            try
            {
                patientHistoryByName objPatient = new patientHistoryByName();
                objPatient.patientName = txtName.Text;
                objDataSetOne = objBusinessLayer.BusinessFillPhysicianHistoryByName(objPatient);
                if (objDataSetOne.Tables[0].Rows.Count == 0)
                {
                    lblShow.Text = "Record Not Found";
                    repeterShowPatient.Visible = false;
                }
                else
                {

                    repeterShowPatient.DataSource = objDataSetOne;
                    repeterShowPatient.DataBind();
                }
            }
            catch (Exception e)
            {

                lblShow.Text = e.Message;
            }
           
           
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            repeterShowPatient.Visible = false;
            txtName.Text = "";
            txtId.Text = "";
            lblShow.Text = "";
        }
    }
}