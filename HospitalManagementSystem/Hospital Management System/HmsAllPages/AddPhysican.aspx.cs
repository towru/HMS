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
    public partial class AddPhysican : System.Web.UI.Page
    {
        AddPhysician objentity = new AddPhysician();
        BusinessEnrollPatient objBusinessLayer = new BusinessEnrollPatient();
        DataTable objDataTableOne = new DataTable();
        DataTable objDataTableTwo = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                fillData();
            }

        }


        public void fillData()
        {

            DropDownState.DataTextField = objBusinessLayer.BusinessFillState().Columns[0].ToString();
            objDataTableOne = objBusinessLayer.BusinessFillState();
            DropDownState.DataSource = objDataTableOne;
            DropDownState.DataBind();

            DropDownPlan.DataTextField = objBusinessLayer.BusinessFillPlan().Columns[0].ToString();
            objDataTableTwo = objBusinessLayer.BusinessFillPlan();
            DropDownPlan.DataSource = objDataTableTwo;
            DropDownPlan.DataBind();

            Random rnd = new Random();
            lblPatientID.Text = Convert.ToString(rnd.Next(10000, 99999));

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {

            int result = 0;
            objentity.id = lblPatientID.Text;
            objentity.first_name = txtFirstName.Text;
            objentity.last_name = txtLastName.Text;
            objentity.Deoartment = DropdownlistDepartment.Text;
            objentity.edu_quali = txtEducational.Text;
            objentity.experience = txtYearOfEx.Text;
            objentity.state = DropDownState.Text;
            objentity.plan = DropDownPlan.Text;

            result = objBusinessLayer.businessAddphysician(objentity);
            if (result > 0)
            {
                Response.Redirect("welcome.aspx");
            }
            else
            {
                Response.Write("wrong");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtYearOfEx.Text = "";
            txtEducational.Text = "";
        }
    }
}