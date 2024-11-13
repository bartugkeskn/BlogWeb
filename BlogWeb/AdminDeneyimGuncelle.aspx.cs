using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]); // Burada diğer formdan gelen id'yi alıyoruz.

            TxtId.Text = id.ToString();
            TxtId.Enabled = false; // id'nin textbox'ta manuel değiştirilmesini inaktif yapıyoruz.

            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TblDeneyimTableAdapter dt = new DataSet1TableAdapters.TblDeneyimTableAdapter();
                TxtBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].BASLIK;
                TxtAltBaslik.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].ALTBASLIK;
                TxtAciklama.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].ACIKLAMA;
                TxtTarih.Text = dt.DeneyimGetir(Convert.ToInt16(id))[0].TARIH;
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblDeneyimTableAdapter dt = new DataSet1TableAdapters.TblDeneyimTableAdapter();
            dt.DeneyimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}