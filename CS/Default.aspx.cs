using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            ASPxGridView1.DataBind();
            this.AssignColumnWidths();
        }
    }

    public List<Category> ListOfCategories {
        get {
            if(Session["ListOfCategories"] == null) {
                Session["ListOfCategories"] = new Source().PopulateList();
            }
            return Session["ListOfCategories"] as List<Category>;
        }
    }
    public void AssignColumnWidths() {
        HttpCookie cookie = Request.Cookies["ASPxGridViewColumnWidths"];
        if(cookie != null) {
            string value = Server.UrlDecode(cookie.Value);
            string[] indexWidthPairs = value.Split('|').Where(x => !string.IsNullOrEmpty(x)).ToArray();
            foreach(string s in indexWidthPairs) {
                string[] indexWidth = s.Split('=');
                ASPxGridView1.Columns[int.Parse(indexWidth[0])].Width = int.Parse(indexWidth[1]);
            }
        }
    }


    protected void ASPxGridView1_ClientLayout(object sender, DevExpress.Web.ASPxClientLayoutArgs e) {
        if(e.LayoutMode == DevExpress.Web.ClientLayoutMode.Saving) {
            Session["GridLayout"] = ASPxGridView1.SaveClientLayout();
        } else {
            if(Session["GridLayout"] != null) {
                e.LayoutData = (string)Session["GridLayout"];
                this.AssignColumnWidths();
            }
        }
    }

    protected void ASPxGridView1_DataBinding(object sender, EventArgs e) {
        ASPxGridView1.DataSource = ListOfCategories;
    }
}