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
using System.Text;
namespace WebDemo.Web.WebDemo.InvoiceLog
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int InvoiceID=(Convert.ToInt32(strid));
					ShowInfo(InvoiceID);
				}
			}
		}
		
	private void ShowInfo(int InvoiceID)
	{
		WebDemo.BLL.WebDemo.InvoiceLog bll=new WebDemo.BLL.WebDemo.InvoiceLog();
		WebDemo.Model.WebDemo.InvoiceLog model=bll.GetModel(InvoiceID);
		this.lblInvoiceID.Text=model.InvoiceID.ToString();
		this.lblInvoiceCode.Text=model.InvoiceCode.ToString();

	}


    }
}
