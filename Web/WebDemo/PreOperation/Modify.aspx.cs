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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace WebDemo.Web.WebDemo.PreOperation
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int OperID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(OperID);
				}
			}
		}
			
	private void ShowInfo(int OperID)
	{
		WebDemo.BLL.WebDemo.PreOperation bll=new WebDemo.BLL.WebDemo.PreOperation();
		WebDemo.Model.WebDemo.PreOperation model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.txtCardID.Text=model.CardID.ToString();
		this.txtCardSector.Text=model.CardSector.ToString();
		this.txtPriceTypeID.Text=model.PriceTypeID.ToString();
		this.txtPriceTypeName.Text=model.PriceTypeName;
		this.txtPrice.Text=model.Price.ToString();
		this.txtOperMoney.Text=model.OperMoney.ToString();
		this.txtOperInt.Text=model.OperInt.ToString();
		this.txtOperZS.Text=model.OperZS.ToString();
		this.txtFactMoney.Text=model.FactMoney.ToString();
		this.txtLastBalance.Text=model.LastBalance.ToString();
		this.txtCurrentBalance.Text=model.CurrentBalance.ToString();
		this.txtTotalMoney.Text=model.TotalMoney.ToString();
		this.txtTotalInt.Text=model.TotalInt.ToString();
		this.txtTotalBase.Text=model.TotalBase.ToString();
		this.txtOperType.Text=model.OperType.ToString();
		this.txtPayType.Text=model.PayType.ToString();
		this.txtInvoiceCode.Text=model.InvoiceCode;
		this.lblOperDate.Text=model.OperDate.ToString();
		this.txtMeterID.Text=model.MeterID.ToString();
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtSiteID.Text=model.SiteID.ToString();
		this.txtFactoryNum.Text=model.FactoryNum.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtRedOperId.Text=model.RedOperId.ToString();
		this.txtOperNum.Text=model.OperNum.ToString();
		this.txtPrice2.Text=model.Price2.ToString();
		this.txtPrice3.Text=model.Price3.ToString();
		this.txtDivid1.Text=model.Divid1.ToString();
		this.txtDivid2.Text=model.Divid2.ToString();
		this.txtUseNumber1.Text=model.UseNumber1.ToString();
		this.txtUseNumber2.Text=model.UseNumber2.ToString();
		this.txtUseNumber3.Text=model.UseNumber3.ToString();
		this.txtCurTotalBuyNumber.Text=model.CurTotalBuyNumber.ToString();
		this.txtInvoiceID.Text=model.InvoiceID.ToString();
		this.txtInvoiceType.Text=model.InvoiceType.ToString();
		this.txtWriteCardFlag.Text=model.WriteCardFlag.ToString();
		this.txtTransactionId.Text=model.TransactionId;
		this.txtPayWay.Text=model.PayWay.ToString();
		this.txtOutTradeNo.Text=model.OutTradeNo;
		this.txtDepositDate.Text=model.DepositDate.ToString();
		this.txtDiscountsNum.Text=model.DiscountsNum.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtCardID.Text))
			{
				strErr+="一卡通卡号(卡号+卡区号不能重格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCardSector.Text))
			{
				strErr+="卡区号(一卡通卡区号格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceTypeID.Text))
			{
				strErr+="PriceTypeID格式错误！\\n";	
			}
			if(this.txtPriceTypeName.Text.Trim().Length==0)
			{
				strErr+="价格名称不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="单价格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOperMoney.Text))
			{
				strErr+="业务金额格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperInt.Text))
			{
				strErr+="业务量格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperZS.Text))
			{
				strErr+="业务字数格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFactMoney.Text))
			{
				strErr+="实收金额格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLastBalance.Text))
			{
				strErr+="上次余额格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtCurrentBalance.Text))
			{
				strErr+="本次余额格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTotalMoney.Text))
			{
				strErr+="总购买金额格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTotalInt.Text))
			{
				strErr+="总购买量格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTotalBase.Text))
			{
				strErr+="总购买字数格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperType.Text))
			{
				strErr+="业务类型(1-开户；2-充值；格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayType.Text))
			{
				strErr+="充值类型(1-远程充值；2-写格式错误！\\n";	
			}
			if(this.txtInvoiceCode.Text.Trim().Length==0)
			{
				strErr+="发票号码不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="业务日期格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="表编号格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="操作员格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="SiteID格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFactoryNum.Text))
			{
				strErr+="FactoryNum格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtRedOperId.Text))
			{
				strErr+="RedOperId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperNum.Text))
			{
				strErr+="OperNum格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice2.Text))
			{
				strErr+="Price2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice3.Text))
			{
				strErr+="Price3格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDivid1.Text))
			{
				strErr+="Divid1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDivid2.Text))
			{
				strErr+="Divid2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseNumber1.Text))
			{
				strErr+="UseNumber1格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseNumber2.Text))
			{
				strErr+="UseNumber2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseNumber3.Text))
			{
				strErr+="UseNumber3格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtCurTotalBuyNumber.Text))
			{
				strErr+="CurTotalBuyNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInvoiceID.Text))
			{
				strErr+="InvoiceID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInvoiceType.Text))
			{
				strErr+="InvoiceType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtWriteCardFlag.Text))
			{
				strErr+="WriteCardFlag格式错误！\\n";	
			}
			if(this.txtTransactionId.Text.Trim().Length==0)
			{
				strErr+="TransactionId不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayWay.Text))
			{
				strErr+="PayWay格式错误！\\n";	
			}
			if(this.txtOutTradeNo.Text.Trim().Length==0)
			{
				strErr+="OutTradeNo不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDepositDate.Text))
			{
				strErr+="DepositDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDiscountsNum.Text))
			{
				strErr+="DiscountsNum格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperID=int.Parse(this.lblOperID.Text);
			int CardID=int.Parse(this.txtCardID.Text);
			int CardSector=int.Parse(this.txtCardSector.Text);
			int PriceTypeID=int.Parse(this.txtPriceTypeID.Text);
			string PriceTypeName=this.txtPriceTypeName.Text;
			decimal Price=decimal.Parse(this.txtPrice.Text);
			decimal OperMoney=decimal.Parse(this.txtOperMoney.Text);
			int OperInt=int.Parse(this.txtOperInt.Text);
			int OperZS=int.Parse(this.txtOperZS.Text);
			decimal FactMoney=decimal.Parse(this.txtFactMoney.Text);
			decimal LastBalance=decimal.Parse(this.txtLastBalance.Text);
			decimal CurrentBalance=decimal.Parse(this.txtCurrentBalance.Text);
			decimal TotalMoney=decimal.Parse(this.txtTotalMoney.Text);
			int TotalInt=int.Parse(this.txtTotalInt.Text);
			int TotalBase=int.Parse(this.txtTotalBase.Text);
			int OperType=int.Parse(this.txtOperType.Text);
			int PayType=int.Parse(this.txtPayType.Text);
			string InvoiceCode=this.txtInvoiceCode.Text;
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			int MeterID=int.Parse(this.txtMeterID.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			int SiteID=int.Parse(this.txtSiteID.Text);
			decimal FactoryNum=decimal.Parse(this.txtFactoryNum.Text);
			string Remark=this.txtRemark.Text;
			int RedOperId=int.Parse(this.txtRedOperId.Text);
			int OperNum=int.Parse(this.txtOperNum.Text);
			decimal Price2=decimal.Parse(this.txtPrice2.Text);
			decimal Price3=decimal.Parse(this.txtPrice3.Text);
			int Divid1=int.Parse(this.txtDivid1.Text);
			int Divid2=int.Parse(this.txtDivid2.Text);
			decimal UseNumber1=decimal.Parse(this.txtUseNumber1.Text);
			decimal UseNumber2=decimal.Parse(this.txtUseNumber2.Text);
			decimal UseNumber3=decimal.Parse(this.txtUseNumber3.Text);
			decimal CurTotalBuyNumber=decimal.Parse(this.txtCurTotalBuyNumber.Text);
			int InvoiceID=int.Parse(this.txtInvoiceID.Text);
			int InvoiceType=int.Parse(this.txtInvoiceType.Text);
			int WriteCardFlag=int.Parse(this.txtWriteCardFlag.Text);
			string TransactionId=this.txtTransactionId.Text;
			int PayWay=int.Parse(this.txtPayWay.Text);
			string OutTradeNo=this.txtOutTradeNo.Text;
			DateTime DepositDate=DateTime.Parse(this.txtDepositDate.Text);
			int DiscountsNum=int.Parse(this.txtDiscountsNum.Text);


			WebDemo.Model.WebDemo.PreOperation model=new WebDemo.Model.WebDemo.PreOperation();
			model.OperID=OperID;
			model.CardID=CardID;
			model.CardSector=CardSector;
			model.PriceTypeID=PriceTypeID;
			model.PriceTypeName=PriceTypeName;
			model.Price=Price;
			model.OperMoney=OperMoney;
			model.OperInt=OperInt;
			model.OperZS=OperZS;
			model.FactMoney=FactMoney;
			model.LastBalance=LastBalance;
			model.CurrentBalance=CurrentBalance;
			model.TotalMoney=TotalMoney;
			model.TotalInt=TotalInt;
			model.TotalBase=TotalBase;
			model.OperType=OperType;
			model.PayType=PayType;
			model.InvoiceCode=InvoiceCode;
			model.OperDate=OperDate;
			model.MeterID=MeterID;
			model.OperatorID=OperatorID;
			model.SiteID=SiteID;
			model.FactoryNum=FactoryNum;
			model.Remark=Remark;
			model.RedOperId=RedOperId;
			model.OperNum=OperNum;
			model.Price2=Price2;
			model.Price3=Price3;
			model.Divid1=Divid1;
			model.Divid2=Divid2;
			model.UseNumber1=UseNumber1;
			model.UseNumber2=UseNumber2;
			model.UseNumber3=UseNumber3;
			model.CurTotalBuyNumber=CurTotalBuyNumber;
			model.InvoiceID=InvoiceID;
			model.InvoiceType=InvoiceType;
			model.WriteCardFlag=WriteCardFlag;
			model.TransactionId=TransactionId;
			model.PayWay=PayWay;
			model.OutTradeNo=OutTradeNo;
			model.DepositDate=DepositDate;
			model.DiscountsNum=DiscountsNum;

			WebDemo.BLL.WebDemo.PreOperation bll=new WebDemo.BLL.WebDemo.PreOperation();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
