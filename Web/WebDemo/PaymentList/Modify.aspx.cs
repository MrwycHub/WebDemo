﻿using System;
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
namespace WebDemo.Web.WebDemo.PaymentList
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
		WebDemo.BLL.WebDemo.PaymentList bll=new WebDemo.BLL.WebDemo.PaymentList();
		WebDemo.Model.WebDemo.PaymentList model=bll.GetModel(OperID);
		this.lblOperID.Text=model.OperID.ToString();
		this.txtUsersID.Text=model.UsersID.ToString();
		this.txtMeterID.Text=model.MeterID.ToString();
		this.txtInvoiceNum.Text=model.InvoiceNum;
		this.txtLastbalance.Text=model.Lastbalance.ToString();
		this.txtThisMoney.Text=model.ThisMoney.ToString();
		this.txtFactMoney.Text=model.FactMoney.ToString();
		this.txtThisBalance.Text=model.ThisBalance.ToString();
		this.txtPayDate.Text=model.PayDate.ToString();
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtPayMode.Text=model.PayMode.ToString();
		this.txtFlag.Text=model.Flag.ToString();
		this.txtSiteID.Text=model.SiteID.ToString();
		this.txtOperInt.Text=model.OperInt.ToString();
		this.txtPrice.Text=model.Price.ToString();
		this.txtInvoiceID.Text=model.InvoiceID.ToString();
		this.txtInvoiceType.Text=model.InvoiceType.ToString();
		this.txtPayType.Text=model.PayType.ToString();
		this.txtPayWay.Text=model.PayWay.ToString();
		this.txtTransactionId.Text=model.TransactionId;
		this.txtOutTradeNo.Text=model.OutTradeNo;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUsersID.Text))
			{
				strErr+="UsersID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}
			if(this.txtInvoiceNum.Text.Trim().Length==0)
			{
				strErr+="发票号码不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLastbalance.Text))
			{
				strErr+="上次余额格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtThisMoney.Text))
			{
				strErr+="本次应交格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFactMoney.Text))
			{
				strErr+="本次实交格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtThisBalance.Text))
			{
				strErr+="本次余额格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtPayDate.Text))
			{
				strErr+="业务日期格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="操作员编号格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayMode.Text))
			{
				strErr+="PayMode格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="误收费恢复后格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="SiteID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperInt.Text))
			{
				strErr+="OperInt格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="Price格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInvoiceID.Text))
			{
				strErr+="InvoiceID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInvoiceType.Text))
			{
				strErr+="InvoiceType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayType.Text))
			{
				strErr+="PayType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayWay.Text))
			{
				strErr+="PayWay格式错误！\\n";	
			}
			if(this.txtTransactionId.Text.Trim().Length==0)
			{
				strErr+="TransactionId不能为空！\\n";	
			}
			if(this.txtOutTradeNo.Text.Trim().Length==0)
			{
				strErr+="OutTradeNo不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperID=int.Parse(this.lblOperID.Text);
			int UsersID=int.Parse(this.txtUsersID.Text);
			int MeterID=int.Parse(this.txtMeterID.Text);
			string InvoiceNum=this.txtInvoiceNum.Text;
			decimal Lastbalance=decimal.Parse(this.txtLastbalance.Text);
			decimal ThisMoney=decimal.Parse(this.txtThisMoney.Text);
			decimal FactMoney=decimal.Parse(this.txtFactMoney.Text);
			decimal ThisBalance=decimal.Parse(this.txtThisBalance.Text);
			DateTime PayDate=DateTime.Parse(this.txtPayDate.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			int PayMode=int.Parse(this.txtPayMode.Text);
			int Flag=int.Parse(this.txtFlag.Text);
			int SiteID=int.Parse(this.txtSiteID.Text);
			int OperInt=int.Parse(this.txtOperInt.Text);
			decimal Price=decimal.Parse(this.txtPrice.Text);
			int InvoiceID=int.Parse(this.txtInvoiceID.Text);
			int InvoiceType=int.Parse(this.txtInvoiceType.Text);
			int PayType=int.Parse(this.txtPayType.Text);
			int PayWay=int.Parse(this.txtPayWay.Text);
			string TransactionId=this.txtTransactionId.Text;
			string OutTradeNo=this.txtOutTradeNo.Text;


			WebDemo.Model.WebDemo.PaymentList model=new WebDemo.Model.WebDemo.PaymentList();
			model.OperID=OperID;
			model.UsersID=UsersID;
			model.MeterID=MeterID;
			model.InvoiceNum=InvoiceNum;
			model.Lastbalance=Lastbalance;
			model.ThisMoney=ThisMoney;
			model.FactMoney=FactMoney;
			model.ThisBalance=ThisBalance;
			model.PayDate=PayDate;
			model.OperatorID=OperatorID;
			model.PayMode=PayMode;
			model.Flag=Flag;
			model.SiteID=SiteID;
			model.OperInt=OperInt;
			model.Price=Price;
			model.InvoiceID=InvoiceID;
			model.InvoiceType=InvoiceType;
			model.PayType=PayType;
			model.PayWay=PayWay;
			model.TransactionId=TransactionId;
			model.OutTradeNo=OutTradeNo;

			WebDemo.BLL.WebDemo.PaymentList bll=new WebDemo.BLL.WebDemo.PaymentList();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
