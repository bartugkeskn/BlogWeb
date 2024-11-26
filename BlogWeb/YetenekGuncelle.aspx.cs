using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int x = Convert.ToInt16(Request.QueryString["ID"]);
            txtId.Text = x.ToString();
            txtId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TblYetenekTableAdapter dt = new DataSet1TableAdapters.TblYetenekTableAdapter();
                txtYetenek.Text = dt.YetenekGetir(Convert.ToInt16(x))[0].YETENEK;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblYetenekTableAdapter dt = new DataSet1TableAdapters.TblYetenekTableAdapter();
            dt.YetenekGuncelle(txtYetenek.Text, Convert.ToInt16(txtId.Text));
            Response.Redirect("YetenekListesi.Aspx");
        }
    }
}