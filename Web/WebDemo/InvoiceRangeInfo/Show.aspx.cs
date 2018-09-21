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
namespace WebDemo.Web.WebDemo.InvoiceRangeInfo
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
					int BatchId=(Convert.ToInt32(strid));
					ShowInfo(BatchId);
				}
			}
		}
		
	private void ShowInfo(int BatchId)
	{
		WebDemo.BLL.WebDemo.InvoiceRangeInfo bll=new WebDemo.BLL.WebDemo.InvoiceRangeInfo();
		WebDemo.Model.WebDemo.InvoiceRangeInfo model=bll.GetModel(BatchId);
		this.lblBatchId.Text=model.BatchId.ToString();
		this.lblInCode.Text=model.InCode;
		this.lblStartNum.Text=model.StartNum;
		this.lblEndNum.Text=model.EndNum;
		this.lblOperatorName.Text=model.OperatorName;
		this.lblGetDateTime.Text=model.GetDateTime.ToString();
		this.lblInDate.Text=model.InDate.ToString();
		this.lblSiteID.Text=model.SiteID.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}
