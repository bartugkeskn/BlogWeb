using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]); // Burada diğer formdan gelen id'yi alıyoruz.

            txtId.Text = id.ToString();
            txtId.Enabled = false; // id'nin textbox'ta manuel değiştirilmesini inaktif yapıyoruz.

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TblEgitimTableAdapter dt = new DataSet1TableAdapters.TblEgitimTableAdapter();
                txtBaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].BASLIK;
                txtAltBaslik.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].ALTBASLIK;
                txtAciklama.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].ACIKLAMA;
                txtGenelNot.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].GNOT;
                txtTarih.Text = dt.EgitimGetir(Convert.ToInt16(id))[0].TARIH;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblEgitimTableAdapter dt = new DataSet1TableAdapters.TblEgitimTableAdapter();
            dt.EgitimGuncelle(txtBaslik.Text, txtAltBaslik.Text, txtAciklama.Text, txtGenelNot.Text, txtTarih.Text, Convert.ToInt16(txtId.Text));
            Response.Redirect("AdminEgitimler.Aspx");
        }
    }
}