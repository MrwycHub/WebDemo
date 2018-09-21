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
namespace WebDemo.Web.WebDemo.PaymentList
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
		WebDemo.BLL.WebDemo.PaymentList bll=new WebDemo.BLL.WebDemo.PaymentList();
		WebDemo.Model.WebDemo.PaymentList model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.lblUsersID.Text=model.UsersID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblInvoiceNum.Text=model.InvoiceNum;
		this.lblLastbalance.Text=model.Lastbalance.ToString();
		this.lblThisMoney.Text=model.ThisMoney.ToString();
		this.lblFactMoney.Text=model.FactMoney.ToString();
		this.lblThisBalance.Text=model.ThisBalance.ToString();
		this.lblPayDate.Text=model.PayDate.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblPayMode.Text=model.PayMode.ToString();
		this.lblFlag.Text=model.Flag.ToString();
		this.lblSiteID.Text=model.SiteID.ToString();
		this.lblOperInt.Text=model.OperInt.ToString();
		this.lblPrice.Text=model.Price.ToString();
		this.lblInvoiceID.Text=model.InvoiceID.ToString();
		this.lblInvoiceType.Text=model.InvoiceType.ToString();
		this.lblPayType.Text=model.PayType.ToString();
		this.lblPayWay.Text=model.PayWay.ToString();
		this.lblTransactionId.Text=model.TransactionId;
		this.lblOutTradeNo.Text=model.OutTradeNo;

	}


    }
}
