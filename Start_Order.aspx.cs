﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Start_Order : Page
    {

        public Ingredient ingredient { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            this.ingredient = new Ingredient();
        }

        protected void SubmitOrderButton(object sender, EventArgs e)
        {

            string _params = string.Format("Price={0}&Size={1}", this.ingredient.Total_Price, this.ingredient.Size);
            Response.Redirect(string.Format("Cart.aspx?{0}", _params));
        }
    }
}