using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblHakkımdaTableAdapter dt = new DataSet1TableAdapters.TblHakkımdaTableAdapter();
            Repeater1.DataSource = dt.HakkımdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.TblDeneyimTableAdapter dt2 = new DataSet1TableAdapters.TblDeneyimTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListele();
            Repeater2.DataBind();

            DataSet1TableAdapters.TblEgitimTableAdapter dt3 = new DataSet1TableAdapters.TblEgitimTableAdapter();
            Repeater3.DataSource = dt3.EgitimListele();
            Repeater3.DataBind();

            DataSet1TableAdapters.TblHobiTableAdapter dt4 = new DataSet1TableAdapters.TblHobiTableAdapter();
            Repeater4.DataSource = dt4.HobiListele();
            Repeater4.DataBind();

            DataSet1TableAdapters.TblSertifikaTableAdapter dt5 = new DataSet1TableAdapters.TblSertifikaTableAdapter();
            Repeater5.DataSource = dt5.SertifikaListele();
            Repeater5.DataBind();

            DataSet1TableAdapters.TblYetenekTableAdapter dt6 = new DataSet1TableAdapters.TblYetenekTableAdapter();
            Repeater6.DataSource = dt6.YetenekListele();
            Repeater6.DataBind();

            DataSet1TableAdapters.TblHakkımdaTableAdapter dt7 = new DataSet1TableAdapters.TblHakkımdaTableAdapter();
            Repeater7.DataSource = dt7.HakkımdaListele();
            Repeater7.DataBind();
        }
    }
}