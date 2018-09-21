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
namespace WebDemo.Web.WebDemo.PreOperation
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
		WebDemo.BLL.WebDemo.PreOperation bll=new WebDemo.BLL.WebDemo.PreOperation();
		WebDemo.Model.WebDemo.PreOperation model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.lblCardID.Text=model.CardID.ToString();
		this.lblCardSector.Text=model.CardSector.ToString();
		this.lblPriceTypeID.Text=model.PriceTypeID.ToString();
		this.lblPriceTypeName.Text=model.PriceTypeName;
		this.lblPrice.Text=model.Price.ToString();
		this.lblOperMoney.Text=model.OperMoney.ToString();
		this.lblOperInt.Text=model.OperInt.ToString();
		this.lblOperZS.Text=model.OperZS.ToString();
		this.lblFactMoney.Text=model.FactMoney.ToString();
		this.lblLastBalance.Text=model.LastBalance.ToString();
		this.lblCurrentBalance.Text=model.CurrentBalance.ToString();
		this.lblTotalMoney.Text=model.TotalMoney.ToString();
		this.lblTotalInt.Text=model.TotalInt.ToString();
		this.lblTotalBase.Text=model.TotalBase.ToString();
		this.lblOperType.Text=model.OperType.ToString();
		this.lblPayType.Text=model.PayType.ToString();
		this.lblInvoiceCode.Text=model.InvoiceCode;
		this.lblOperDate.Text=model.OperDate.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblSiteID.Text=model.SiteID.ToString();
		this.lblFactoryNum.Text=model.FactoryNum.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblRedOperId.Text=model.RedOperId.ToString();
		this.lblOperNum.Text=model.OperNum.ToString();
		this.lblPrice2.Text=model.Price2.ToString();
		this.lblPrice3.Text=model.Price3.ToString();
		this.lblDivid1.Text=model.Divid1.ToString();
		this.lblDivid2.Text=model.Divid2.ToString();
		this.lblUseNumber1.Text=model.UseNumber1.ToString();
		this.lblUseNumber2.Text=model.UseNumber2.ToString();
		this.lblUseNumber3.Text=model.UseNumber3.ToString();
		this.lblCurTotalBuyNumber.Text=model.CurTotalBuyNumber.ToString();
		this.lblInvoiceID.Text=model.InvoiceID.ToString();
		this.lblInvoiceType.Text=model.InvoiceType.ToString();
		this.lblWriteCardFlag.Text=model.WriteCardFlag.ToString();
		this.lblTransactionId.Text=model.TransactionId;
		this.lblPayWay.Text=model.PayWay.ToString();
		this.lblOutTradeNo.Text=model.OutTradeNo;
		this.lblDepositDate.Text=model.DepositDate.ToString();
		this.lblDiscountsNum.Text=model.DiscountsNum.ToString();

	}


    }
}
