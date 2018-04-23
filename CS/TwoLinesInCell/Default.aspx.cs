using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace TwoLinesInCell {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            ASPxGridView1.DataSource = GetDataTable();
            ASPxGridView1.DataBind();
        }

        private object GetDataTable() {
            DataTable table = new DataTable();
            table.Columns.Add("Subject");
            table.Columns.Add("From");
            table.Rows.Add("Your order", "John Doe");
            table.Rows.Add("Canadian pharmacy", "Miss Piggy");
            return table;
        }

        protected void Page_Load(object sender, EventArgs e) {

        }
    }
}
