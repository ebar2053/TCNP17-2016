using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InternetExercise2
{

    public partial class DataPage : PageBase
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            index_ index = PreviousPage as index_;
            if (index?.ReturnViewState?["MainViewState"] as ListItem[] != null)
            {
                BulletedList.Items.AddRange((ListItem[])index.ReturnViewState["MainViewState"]);
            }
            else if (PreviousPage?.Request.QueryString["item1"] != null)
            {
                foreach (string item in PreviousPage.Request.QueryString.Keys)
                {
                    BulletedList.Items.Add(HttpContext.Current.Server.UrlDecode(PreviousPage.Request.QueryString[item]));
                }              
            }
            else if (Request.Cookies["myCookie"] != null)
            {
                HttpCookie aCookie = Request.Cookies["myCookie"];
                foreach (var item in aCookie.Values.AllKeys)
                {
                    BulletedList.Items.Add(Request.Cookies["myCookie"][item]);
                }
            }
            else if (Session["mySession"] != null)
            {
                BulletedList.Items.AddRange((ListItem[]) Session["mySession"]);
                Session["mySession"] = null;
            }
            else if (index?.ReturnViewState != null && index?.ReturnViewState["MainViewState"] == null)
            {
                BulletedList.Items.Add((index.FindControl("txtItem1") as TextBox).Text);
                BulletedList.Items.Add((index.FindControl("txtItem2") as TextBox).Text);
                BulletedList.Items.Add((index.FindControl("txtItem3") as TextBox).Text);
                BulletedList.Items.Add((index.FindControl("txtItem4") as TextBox).Text);
                BulletedList.Items.Add((index.FindControl("txtItem5") as TextBox).Text);
            }

        }
    }
} 