﻿using System;
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
        }
    }
}