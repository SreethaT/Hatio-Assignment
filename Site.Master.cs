using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Todo
{
   
     
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
       
        //SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=gstportal;Integrated Security=True;Pooling=False");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
     
        public string typ { get; set; }
    }

       
    }



   
    