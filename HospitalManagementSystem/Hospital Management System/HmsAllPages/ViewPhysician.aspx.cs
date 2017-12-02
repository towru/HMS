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
    public partial class ViewPhysician : System.Web.UI.Page
    {
        physicanId objentity = new physicanId();
        BusinessEnrollPatient objBusinessLayer = new BusinessEnrollPatient();
        DataTable objDataTableOne = new DataTable();
        DataTable objDataTableTwo = new DataTable();
        DataTable objDataTableDepart = new DataTable();
        DataSet objDatasetOne = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
         
               fillData();
                lblShow.Text = "";
            }
            
        }


        public void fillData()
        {

            DropdownlistState.DataTextField = objBusinessLayer.BusinessFillState().Columns[1].ToString();
            objDataTableOne = objBusinessLayer.BusinessFillState();
            DropdownlistState.DataSource = objDataTableOne;
            DropdownlistState.DataBind();

            DropdownlistPlan.DataTextField = objBusinessLayer.BusinessFillPlan().Columns[1].ToString();
            objDataTableTwo = objBusinessLayer.BusinessFillPlan();
            DropdownlistPlan.DataSource = objDataTableTwo;
            DropdownlistPlan.DataBind();


            DropDownDepart.DataTextField = objBusinessLayer.BusinessFillDepartment().Columns[3].ToString();
            objDataTableDepart = objBusinessLayer.BusinessFillDepartment();
            DropDownDepart.DataSource = objDataTableDepart;
            DropDownDepart.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            searchPhysican search = new searchPhysican();
            search.state = DropdownlistState.Text;
            search.plan = DropdownlistPlan.Text;
            search.depatrment = DropDownDepart.Text;

            objDatasetOne = objBusinessLayer.BusinessFillPhysicianDetails(search);
            if (objDatasetOne.Tables[0].Rows.Count == 0)
            {
                lblShow.Text = "Record Not Found";
                RepeaterPhysican.Visible = false;

            }
            else
            {

                RepeaterPhysican.DataSource = objDatasetOne;
                RepeaterPhysican.DataBind();
            }
            
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            RepeaterPhysican.Visible = false;
            lblShow.Text = "";
        }
    }
}