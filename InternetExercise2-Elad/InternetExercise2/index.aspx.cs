using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InternetExercise2
{
    public partial class index_ : PageBase
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnUsingQueryString_OnClick(object sender, EventArgs e)
        {
            Server.Transfer("DataPage.aspx?" + "item1=" + HttpContext.Current.Server.UrlEncode(txtItem1.Text)
                + "&item2=" + HttpContext.Current.Server.UrlEncode(txtItem2.Text)
                + "&item3=" + HttpContext.Current.Server.UrlEncode(txtItem3.Text)
                + "&item4=" + HttpContext.Current.Server.UrlEncode(txtItem4.Text)
                + "&item5=" + HttpContext.Current.Server.UrlEncode(txtItem5.Text));
        }

        protected void btnUsingSessionState_OnClick(object sender, EventArgs e)
        {
            Session["mySession"] = GetTextBoxItem();
            Response.Redirect("DataPage.aspx");
        }

        protected void btnUsingPreviousPage_OnClick(object sender, EventArgs e)
        {
            Server.Transfer("DataPage.aspx", true);
        }

        protected void btnUsingCookie_OnClick(object sender, EventArgs e)
        {
            HttpCookie aCookie = new HttpCookie("myCookie");
            aCookie.Values["item1"] = txtItem1.Text;
            aCookie.Values["item2"] = txtItem2.Text;
            aCookie.Values["item3"] = txtItem3.Text;
            aCookie.Values["item4"] = txtItem4.Text;
            aCookie.Values["item5"] = txtItem5.Text;
            aCookie.Expires = DateTime.Now.AddSeconds(10);

            Response.Cookies.Add(aCookie);
            Response.Redirect("DataPage.aspx");
        }

        protected void btnUsingViewState_OnClick(object sender, EventArgs e)
        {
            ViewState["MainViewState"] = GetTextBoxItem();
            Server.Transfer("DataPage.aspx", true);
        }

        public ListItem[] GetTextBoxItem()
        {
           return new ListItem[] {
                new ListItem(txtItem1.Text),
                new ListItem(txtItem2.Text),
                new ListItem(txtItem3.Text),
                new ListItem(txtItem4.Text),
                new ListItem(txtItem5.Text)
            };
        }
    }
}