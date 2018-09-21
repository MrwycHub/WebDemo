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
namespace WebDemo.Web.WebDemo.InvoiceGet
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
					int InID=(Convert.ToInt32(strid));
					ShowInfo(InID);
				}
			}
		}
		
	private void ShowInfo(int InID)
	{
		WebDemo.BLL.WebDemo.InvoiceGet bll=new WebDemo.BLL.WebDemo.InvoiceGet();
		WebDemo.Model.WebDemo.InvoiceGet model=bll.GetModel(InID);
		this.lblInID.Text=model.InID.ToString();
		this.lblInCode.Text=model.InCode;
		this.lblStartNum.Text=model.StartNum.ToString();
		this.lblEndNum.Text=model.EndNum.ToString();
		this.lblOperatorName.Text=model.OperatorName;
		this.lblInDate.Text=model.InDate.ToString();
		this.lblSiteID.Text=model.SiteID.ToString();

	}


    }
}
