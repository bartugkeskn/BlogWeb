﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb
{
    public partial class HobiEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblHobiTableAdapter dt = new DataSet1TableAdapters.TblHobiTableAdapter();
            dt.HobiEkle(txtHobi.Text);
            Response.Redirect("HobiListesi.aspx");
        }
    }
}