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
namespace WebDemo.Web.WebDemo.InvoiceDistributeLog
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
					int DisId=(Convert.ToInt32(strid));
					ShowInfo(DisId);
				}
			}
		}
		
	private void ShowInfo(int DisId)
	{
		WebDemo.BLL.WebDemo.InvoiceDistributeLog bll=new WebDemo.BLL.WebDemo.InvoiceDistributeLog();
		WebDemo.Model.WebDemo.InvoiceDistributeLog model=bll.GetModel(DisId);
		this.lblDisId.Text=model.DisId.ToString();
		this.lblBatchId.Text=model.BatchId.ToString();
		this.lblInCode.Text=model.InCode;
		this.lblStartNum.Text=model.StartNum;
		this.lblEndNum.Text=model.EndNum;
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblAssignDate.Text=model.AssignDate.ToString();
		this.lblAssignOperator.Text=model.AssignOperator;
		this.lblState.Text=model.State.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}
