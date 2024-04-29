using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Todo
{
    public partial class listproject : System.Web.UI.Page
    {
        operation op = new operation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                select();
            }
        }
        public void select()
        {
            DataSet ds = op.selectall("select distinct(Title) from Project");
            ddltype.Items.Clear();
            ddltype.Items.Add("-select-");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ddltype.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
            

           

        }
        

        

        protected void btnadd_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (Panel1.Visible == true)
            {
                op.iud("insert into  Project values('" + txttitle.Text + "','" + txtdate.Text + "','" + txtadd.Text + "')");
            }
           
                string s;
                if (ch1.Checked == true)
                {
                    s = "Completed";
                }
                else
                {
                    s = "Pending";
                }
                op.iud("insert into  Todo values('" + txtdes.Text + "','" + s + "','" + txtdate.Text + "','" + txtupdate.Text + "')");
            
            op.iud("update Project set Title='" + txttitle.Text + "',createddate='" + txtdate.Text + "',Todo='" + txtadd.Text + "' ");
            op.iud("update Todo set description='" + txtdes.Text + "',status='" + s + "',createddate='" + txtdate.Text + "',updateddate='"+txtupdate.Text+"' ");
            Response.Write("<script>alert('Saved Successfully')</script>");
            txttitle.Text = "";
            txtdate.Text = "";
            txtdes.Text = "";
            txtupdate.Text = "";
           
            Panel1.Visible = false;
            
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            txttitle.ReadOnly = false;
            txtdate.ReadOnly = false;
            txtdes.ReadOnly = false;
            txtupdate.ReadOnly = false;

            
        
            Panel1.Visible = false;
        }

        
       

      
        protected void btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");

        }

        protected void ddltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddltype.Text != "select")
            {

                DataSet ds = op.selectall("select * from Project where Title='" + ddltype.Text + "'");
                txttitle.Text = ddltype.Text;
                txtdate.Text = ds.Tables[0].Rows[0][1].ToString();
                ddltodo.Items.Clear();
                ddltodo.Items.Add("-select-");

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ddltodo.Items.Add(ds.Tables[0].Rows[i][2].ToString());
                }
                

                

            }
        }

        protected void ddltodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddltodo.Text != "select")
            {

                DataSet ds1 = op.selectall("select * from Todo join Project on Todo.createddate=Project.createddate where Project.Todo='" + ddltodo.Text + "' ");
                
   
                txtdes.Text = ds1.Tables[0].Rows[0][0].ToString();
                txtupdate.Text = ds1.Tables[0].Rows[0][3].ToString();
            }

        }

       

        

       

       
    }
}