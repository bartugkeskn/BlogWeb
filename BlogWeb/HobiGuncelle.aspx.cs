using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class HobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);

            txtId.Text = id.ToString();
            txtId.Enabled = false;

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TblHobiTableAdapter dt = new DataSet1TableAdapters.TblHobiTableAdapter();
                txtHobi.Text = dt.HobiGetir(Convert.ToInt16(id))[0].HOBI;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblHobiTableAdapter dt = new DataSet1TableAdapters.TblHobiTableAdapter();
            dt.HobiGuncelle(txtHobi.Text, Convert.ToInt16(txtId.Text));
            Response.Redirect("HobiListesi.aspx");
        }
    }
}