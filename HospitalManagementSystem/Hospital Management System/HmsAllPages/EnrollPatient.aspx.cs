using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Lict.Hms.DotNet.BusinessLayer;
using Lict.Hms.DotNet.EntityLayer;

namespace Hospital_Management_System.HmsAllPages
{
    public partial class EnrollPatient : System.Web.UI.Page
    {
        EntityEnrollPatient objEntityLayer = new EntityEnrollPatient();
        BusinessEnrollPatient objBusinessLayer = new BusinessEnrollPatient();
        DataTable objDataTableState = new DataTable();
        DataTable objDataTablePlan = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            
                fillData();            
            }
           

        }
       
        public void fillData()
        {
            
           DropDownListState.DataTextField = objBusinessLayer.BusinessFillState().Columns[0].ToString();
           objDataTableState = objBusinessLayer.BusinessFillState();
           DropDownListState.DataSource = objDataTableState;
           DropDownListState.DataBind();

            DropDownListPlan.DataTextField = objBusinessLayer.BusinessFillPlan().Columns[0].ToString();
            objDataTablePlan = objBusinessLayer.BusinessFillPlan();
            DropDownListPlan.DataSource = objDataTablePlan;
            DropDownListPlan.DataBind();

            string lid = objBusinessLayer.BusinessGetLastRe().Rows[0]["PatientId"].ToString();
            long id =Convert.ToInt64(lid)+ 1;
            lblPatientID.Text =Convert.ToString(id);

        }
      

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            int result =0;
            Session["PatientId"] =lblPatientID.Text;
            objEntityLayer.Id = lblPatientID.Text;
            objEntityLayer.Fname = txtFname.Text;
            objEntityLayer.Lname = txtLname.Text;

            Control ctday = calenderControl.FindControl("DropDownListDay");
            Control ctmonth = calenderControl.FindControl("DropDownListMonth");
            Control ctyear = calenderControl.FindControl("DropDownListYear");
            DropDownList dlday = (DropDownList)ctday;
            DropDownList dlmonth = (DropDownList)ctmonth;
            DropDownList dlyear = (DropDownList)ctyear;
            
            objEntityLayer.Dob = dlday.SelectedValue.ToString() +"/ " + dlmonth.SelectedValue.ToString() +"/" + dlyear.SelectedValue.ToString();
            objEntityLayer.Email = txtEmail.Text;
            objEntityLayer.PhoneNumber = txtPhone.Text;
            objEntityLayer.State = DropDownListState.Text;
            objEntityLayer.Plan = DropDownListPlan.Text;

                result = objBusinessLayer.businessAddPatient(objEntityLayer);
                if (result > 0)
                {
                    Response.Redirect("PatientDiagnosisDetailScreen.aspx");
                }
                else
                {
                    Response.Write("wrong");
                }
            
            
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            Control ctday = calenderControl.FindControl("DropDownListDay");
            Control ctmonth = calenderControl.FindControl("DropDownListMonth");
            Control ctyear = calenderControl.FindControl("DropDownListYear");
            DropDownList dlday = (DropDownList)ctday;
            DropDownList dlmonth = (DropDownList)ctmonth;
            DropDownList dlyear = (DropDownList)ctyear;
            dlday.SelectedValue="Day";
            dlmonth.SelectedValue = "Month";
            dlyear.SelectedValue = "Year";
            DropDownListState.Text = "AL";
            DropDownListPlan.Text = "P001";
        }
    }
}