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
namespace WebDemo.Web.WebDemo.MultiOperation
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
					int OperID=(Convert.ToInt32(strid));
					ShowInfo(OperID);
				}
			}
		}
		
	private void ShowInfo(int OperID)
	{
		WebDemo.BLL.WebDemo.MultiOperation bll=new WebDemo.BLL.WebDemo.MultiOperation();
		WebDemo.Model.WebDemo.MultiOperation model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.lblMultiUserID.Text=model.MultiUserID.ToString();
		this.lblCardID.Text=model.CardID.ToString();
		this.lblCardSector.Text=model.CardSector.ToString();
		this.lblOperMoney.Text=model.OperMoney.ToString();
		this.lblLastBalance.Text=model.LastBalance.ToString();
		this.lblCurrentBalance.Text=model.CurrentBalance.ToString();
		this.lblTotalMoney.Text=model.TotalMoney.ToString();
		this.lblOperType.Text=model.OperType.ToString();
		this.lblInvoiceCode.Text=model.InvoiceCode;
		this.lblOperDate.Text=model.OperDate.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblInvoiceID.Text=model.InvoiceID.ToString();
		this.lblInvoiceType.Text=model.InvoiceType.ToString();

	}


    }
}
