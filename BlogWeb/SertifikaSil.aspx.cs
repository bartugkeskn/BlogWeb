using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class SertifikaSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.TblSertifikaTableAdapter dt = new DataSet1TableAdapters.TblSertifikaTableAdapter();
            dt.SertifikaSil(Convert.ToInt16(x));
            Response.Redirect("SertifikaListesi.aspx");
        }
    }
}