using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TestWebService
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           //WebService1 WS1=new WebService1();
           //Label1.Text = WS1.HelloWorld();

           //SaleService ss = new SaleService();
           //DataSet ds1 = new DataSet();
           //ds1 = ss.SelectCustomer(TextBox1.Text, int.Parse(TextBox2.Text), TextBox3.Text);

           //if (ds1 != null)
           //{
           //    Label2.Text = Convert.ToString(ds1.Tables[0].Rows.Count);
         
           //}
           //else
           //    Label2.Text = "You are not allowd";
            SaleService ss = new SaleService();
            DataSet ds1 = ss.PrintPishFactor("admin", 489752, 9732).Copy();
            if (ds1 != null)
            {
                GridView1.DataSource = ds1.Tables[0];
                GridView1.DataBind();
            }
            //ss.InternetPayment("admin", 489752, 10,"10","10",null,null,null);
        }
    }
}