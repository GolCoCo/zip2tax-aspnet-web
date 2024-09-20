using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zip2TaxWebApp.Models;
using WebApplication4.Controller;
using System.Web.DynamicData;

namespace Zip2TaxWebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DateTime cdt = DateTime.Now;
                tbxFromDate.Text = cdt.ToString("yyyy-MM-dd");
                tbxToDate.Text = cdt.ToString("yyyy-MM-dd");
                ManagerMSSQLServer managerMSSQLServer = new ManagerMSSQLServer();
                managerMSSQLServer.ConnectMSSQLServer();
                //DataTable dt = managerMSSQLServer.GetAllZip2TaxDataTable(cdt, cdt);
                DataTable dt = managerMSSQLServer.GetAllZip2TaxDataTable(10);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                managerMSSQLServer.CloseMSSQLServer();
            }

        }

        protected void tbxFromDate_TextChanged(object sender, EventArgs e)
        {
            ManagerMSSQLServer managerMSSQLServer = new ManagerMSSQLServer();
            managerMSSQLServer.ConnectMSSQLServer();
            DataTable dt = managerMSSQLServer.GetAllZip2TaxDataTable(3);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            managerMSSQLServer.CloseMSSQLServer();

            //String strFromDt = tbxFromDate.Text;
            //String strToDt = tbxToDate.Text;
            //DateTime fromDt = DateTime.Parse($"{strFromDt} 12:00:00");
            //DateTime toDt = DateTime.Parse($"{strToDt} 12:00:00");
            //ManagerMSSQLServer managerMSSQLServer = new ManagerMSSQLServer();
            //managerMSSQLServer.ConnectMSSQLServer();
            //DataTable dt = managerMSSQLServer.GetAllZip2TaxDataTable(fromDt,toDt);
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
            //managerMSSQLServer.CloseMSSQLServer();
        }

        protected void tbxToDate_TextChanged(object sender, EventArgs e)
        {
            ManagerMSSQLServer managerMSSQLServer = new ManagerMSSQLServer();
            managerMSSQLServer.ConnectMSSQLServer();
            DataTable dt = managerMSSQLServer.GetAllZip2TaxDataTable(3);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            managerMSSQLServer.CloseMSSQLServer();

            //String strFromDt = tbxFromDate.Text;
            //String strToDt = tbxToDate.Text;
            //DateTime fromDt = DateTime.Parse($"{strFromDt} 12:00:00");
            //DateTime toDt = DateTime.Parse($"{strToDt} 12:00:00");
            //ManagerMSSQLServer managerMSSQLServer = new ManagerMSSQLServer();
            //managerMSSQLServer.ConnectMSSQLServer();
            //DataTable dt = managerMSSQLServer.GetAllZip2TaxDataTable(fromDt, toDt);
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
            //managerMSSQLServer.CloseMSSQLServer();

        }
    }
}