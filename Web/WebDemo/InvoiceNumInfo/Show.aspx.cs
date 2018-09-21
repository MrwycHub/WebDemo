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
namespace WebDemo.Web.WebDemo.InvoiceNumInfo
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
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.InvoiceNumInfo bll=new WebDemo.BLL.WebDemo.InvoiceNumInfo();
		WebDemo.Model.WebDemo.InvoiceNumInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblDisId.Text=model.DisId.ToString();
		this.lblBatchId.Text=model.BatchId.ToString();
		this.lblInCode.Text=model.InCode;
		this.lblInvoiceNum.Text=model.InvoiceNum;
		this.lblOrderNum.Text=model.OrderNum;
		this.lblMark.Text=model.Mark.ToString();
		this.lblSubFlag.Text=model.SubFlag.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblAssignOperator.Text=model.AssignOperator;
		this.lblAssignDate.Text=model.AssignDate.ToString();
		this.lblOperDate.Text=model.OperDate.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}
