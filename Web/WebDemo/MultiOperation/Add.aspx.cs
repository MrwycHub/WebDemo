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
namespace WebDemo.Web.WebDemo.MultiOperation
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMultiUserID.Text))
			{
				strErr+="MultiUserID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCardID.Text))
			{
				strErr+="CardID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCardSector.Text))
			{
				strErr+="CardSector格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOperMoney.Text))
			{
				strErr+="OperMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLastBalance.Text))
			{
				strErr+="LastBalance格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtCurrentBalance.Text))
			{
				strErr+="CurrentBalance格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTotalMoney.Text))
			{
				strErr+="TotalMoney格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperType.Text))
			{
				strErr+="OperType格式错误！\\n";	
			}
			if(this.txtInvoiceCode.Text.Trim().Length==0)
			{
				strErr+="InvoiceCode不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="OperDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtInvoiceID.Text))
			{
				strErr+="InvoiceID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInvoiceType.Text))
			{
				strErr+="InvoiceType格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MultiUserID=int.Parse(this.txtMultiUserID.Text);
			int CardID=int.Parse(this.txtCardID.Text);
			int CardSector=int.Parse(this.txtCardSector.Text);
			decimal OperMoney=decimal.Parse(this.txtOperMoney.Text);
			decimal LastBalance=decimal.Parse(this.txtLastBalance.Text);
			decimal CurrentBalance=decimal.Parse(this.txtCurrentBalance.Text);
			decimal TotalMoney=decimal.Parse(this.txtTotalMoney.Text);
			int OperType=int.Parse(this.txtOperType.Text);
			string InvoiceCode=this.txtInvoiceCode.Text;
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			string Remark=this.txtRemark.Text;
			int InvoiceID=int.Parse(this.txtInvoiceID.Text);
			int InvoiceType=int.Parse(this.txtInvoiceType.Text);

			WebDemo.Model.WebDemo.MultiOperation model=new WebDemo.Model.WebDemo.MultiOperation();
			model.MultiUserID=MultiUserID;
			model.CardID=CardID;
			model.CardSector=CardSector;
			model.OperMoney=OperMoney;
			model.LastBalance=LastBalance;
			model.CurrentBalance=CurrentBalance;
			model.TotalMoney=TotalMoney;
			model.OperType=OperType;
			model.InvoiceCode=InvoiceCode;
			model.OperDate=OperDate;
			model.OperatorID=OperatorID;
			model.Remark=Remark;
			model.InvoiceID=InvoiceID;
			model.InvoiceType=InvoiceType;

			WebDemo.BLL.WebDemo.MultiOperation bll=new WebDemo.BLL.WebDemo.MultiOperation();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
