using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Todo
{
    public partial class viewproject : System.Web.UI.Page
    {
        operation op = new operation();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = op.selectall("select count(status) as status from Todo where status='Completed' ");
            lbltodo.Text = ds.Tables[0].Rows[0]["status"].ToString();
            DataSet ds1 = op.selectall("select count(status) as status from Todo ");
            lbltotal.Text = ds1.Tables[0].Rows[0]["status"].ToString();
            check.Items.Clear();
            DataSet ds2 = op.selectall("select distinct Project.Todo from Project join Todo on Project.createddate = Todo.createddate where Todo.status='Pending' ");

          
            DataSet ds3 = op.selectall("select distinct Project.Todo  from Project join Todo on Project.createddate = Todo.createddate where Todo.status='Completed' ");

            check.DataSource = ds2.Tables[0];
            check.DataTextField = "Todo";
            check.DataValueField = "Todo";
            check.DataBind();
            check1.DataSource = ds3.Tables[0];
            check1.DataTextField = "Todo";
            check1.DataValueField = "Todo";
            check1.DataBind();
            for (int i = 0; i < check1.Items.Count; i++)
            {
                check1.Items[i].Selected = true; 

            }

                

        }
    }
}