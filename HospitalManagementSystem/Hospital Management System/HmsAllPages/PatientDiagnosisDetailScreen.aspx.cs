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
    public partial class PatientDiagnosisDetailScreen : System.Web.UI.Page
    {
        EntityPatientDiognasis ObjentityPatient = new EntityPatientDiognasis();
        BusinessEnrollPatient objBusinessLayer = new BusinessEnrollPatient();
        DataTable objDataTableOne = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataPhysican();                
                randomBillId();
                visibleControl();
            }
           
           
        }

        public void visibleControl()
        {
            billInfo.Visible = false;
            calenderControlDateFollow.Visible = false;
            lblFollow.Visible = false;
            lblCard.Visible = false;
            txtCardNumber.Visible = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int result = 0;
            ObjentityPatient.PatientID = Session["PatientId"].ToString();
            ObjentityPatient.Symptoms = txtSymptome.Text;
            ObjentityPatient.DiagnosisProvided = txtDiagnosis.Text;
            ObjentityPatient.AdministeredBy = DropDownListPhysican.Text;

            Control ctday = calenderControDateDiagnosis.FindControl("DropDownListDay");
            Control ctmonth = calenderControDateDiagnosis.FindControl("DropDownListMonth");
            Control ctyear = calenderControDateDiagnosis.FindControl("DropDownListYear");
            DropDownList dlday = (DropDownList)ctday;
            DropDownList dlmonth = (DropDownList)ctmonth;
            DropDownList dlyear = (DropDownList)ctyear;
            ObjentityPatient.DateOfDiagnosis = dlday.SelectedValue.ToString()+"/"+dlmonth.SelectedValue.ToString()+"/" + dlyear.SelectedValue.ToString();

            

            if (CheckBoxFollow.Checked == true)
            {
                ObjentityPatient.FollowUpRequireed = "Y";
                Control ctdayF = calenderControlDateFollow.FindControl("DropDownListDay");
                Control ctmonthF = calenderControlDateFollow.FindControl("DropDownListMonth");
                Control ctyearF = calenderControlDateFollow.FindControl("DropDownListYear");
                DropDownList dldayF = (DropDownList)ctdayF;
                DropDownList dlmonthF = (DropDownList)ctmonthF;
                DropDownList dlyearF = (DropDownList)ctyearF;
                ObjentityPatient.DateOfFollowUp = dldayF.SelectedValue.ToString() + "/" + dlmonthF.SelectedValue.ToString() + "/" + dlyearF.SelectedValue.ToString();


            }
            else if (CheckBoxFollow.Checked == false)
            {
                ObjentityPatient.FollowUpRequireed = "N";
                ObjentityPatient.DateOfFollowUp = " ";

            }
            
            ObjentityPatient.BillId = LblBillId.Text;

            result = objBusinessLayer.businessAddPatientDiognasis(ObjentityPatient);
            if (result > 0)
            {
                billInfo.Visible = true;
                PatienDeatils.Visible = false;
            }
            else
            {
                Response.Write("wrong");
            }
           
        }

       public void DataPhysican()
        {
            
            DropDownListPhysican.DataTextField = objBusinessLayer.BusinessFillPhysician().Columns[0].ToString();
            objDataTableOne = objBusinessLayer.BusinessFillPhysician();
            DropDownListPhysican.DataSource = objDataTableOne;
            DropDownListPhysican.DataBind();
        }

        public void randomBillId()
        {
            Random rnd = new Random();
            LblBillId.Text =Convert.ToString( rnd.Next(100000, 999999));
        }

        protected void CheckBoxFollow_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxFollow.Checked==true)
            { 
            calenderControlDateFollow.Visible = true;
            lblFollow.Visible = true;
            }
            else if(CheckBoxFollow.Checked == false){
                calenderControlDateFollow.Visible = false;
                lblFollow.Visible = false;
            }
        }

        protected void DropDownListModeOfPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListModeOfPayment.Text == "Card")
            {
                lblCard.Visible = true;
                txtCardNumber.Visible = true;
            }
            else if (DropDownListModeOfPayment.Text == "Cash")
            {
                lblCard.Visible = false;
                txtCardNumber.Visible = false;
            }
        }

        protected void btnSubmitBill_Click(object sender, EventArgs e)
        {
            int result = 0;
            EntityBillInfo objEntityBill = new EntityBillInfo();
            objEntityBill.BillId =LblBillId.Text;
            objEntityBill.BillAmount = txtBillAmount.Text;

            if (DropDownListModeOfPayment.Text == "Card")
            {
                objEntityBill.ModePayment = DropDownListModeOfPayment.Text;
                objEntityBill.CardNumber = txtCardNumber.Text;
            }
            else if (DropDownListModeOfPayment.Text == "Cash")
            {
                objEntityBill.ModePayment = DropDownListModeOfPayment.Text;
                objEntityBill.CardNumber = " ";
            }

            result = objBusinessLayer.businessAddPatientBill(objEntityBill);
            if (result > 0)
            {
                Response.Redirect("ViewPatientHistory.aspx");
            }
            else
            {
                Response.Write("wrong");
            }
        }
    }
}