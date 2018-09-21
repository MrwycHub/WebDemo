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
namespace WebDemo.Web.WebDemo.EInvoices
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtOperID.Text))
			{
				strErr+="OperID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperType.Text))
			{
				strErr+="OperType格式错误！\\n";	
			}
			if(this.txtInvoiceNumber.Text.Trim().Length==0)
			{
				strErr+="InvoiceNumber不能为空！\\n";	
			}
			if(this.txtOrderNo.Text.Trim().Length==0)
			{
				strErr+="OrderNo不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOperMoney.Text))
			{
				strErr+="OperMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFactMoney.Text))
			{
				strErr+="FactMoney格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInvoiceState.Text))
			{
				strErr+="InvoiceState格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="OperDate格式错误！\\n";	
			}
			if(this.txtURL.Text.Trim().Length==0)
			{
				strErr+="URL不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateDate.Text))
			{
				strErr+="CreateDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(this.txtInvoiceCode.Text.Trim().Length==0)
			{
				strErr+="InvoiceCode不能为空！\\n";	
			}
			if(this.txtRtnInvoiceNumber.Text.Trim().Length==0)
			{
				strErr+="RtnInvoiceNumber不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtManualRegist.Text))
			{
				strErr+="ManualRegist格式错误！\\n";	
			}
			if(this.txtRedSaleURL.Text.Trim().Length==0)
			{
				strErr+="RedSaleURL不能为空！\\n";	
			}
			if(this.txtRSInvoiceNumber.Text.Trim().Length==0)
			{
				strErr+="RSInvoiceNumber不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRegistDate.Text))
			{
				strErr+="RegistDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperID=int.Parse(this.txtOperID.Text);
			int OperType=int.Parse(this.txtOperType.Text);
			string InvoiceNumber=this.txtInvoiceNumber.Text;
			string OrderNo=this.txtOrderNo.Text;
			int MeterID=int.Parse(this.txtMeterID.Text);
			decimal OperMoney=decimal.Parse(this.txtOperMoney.Text);
			decimal FactMoney=decimal.Parse(this.txtFactMoney.Text);
			int InvoiceState=int.Parse(this.txtInvoiceState.Text);
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			string URL=this.txtURL.Text;
			DateTime CreateDate=DateTime.Parse(this.txtCreateDate.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			string InvoiceCode=this.txtInvoiceCode.Text;
			string RtnInvoiceNumber=this.txtRtnInvoiceNumber.Text;
			int ManualRegist=int.Parse(this.txtManualRegist.Text);
			string RedSaleURL=this.txtRedSaleURL.Text;
			string RSInvoiceNumber=this.txtRSInvoiceNumber.Text;
			DateTime RegistDate=DateTime.Parse(this.txtRegistDate.Text);

			WebDemo.Model.WebDemo.EInvoices model=new WebDemo.Model.WebDemo.EInvoices();
			model.OperID=OperID;
			model.OperType=OperType;
			model.InvoiceNumber=InvoiceNumber;
			model.OrderNo=OrderNo;
			model.MeterID=MeterID;
			model.OperMoney=OperMoney;
			model.FactMoney=FactMoney;
			model.InvoiceState=InvoiceState;
			model.OperDate=OperDate;
			model.URL=URL;
			model.CreateDate=CreateDate;
			model.OperatorID=OperatorID;
			model.InvoiceCode=InvoiceCode;
			model.RtnInvoiceNumber=RtnInvoiceNumber;
			model.ManualRegist=ManualRegist;
			model.RedSaleURL=RedSaleURL;
			model.RSInvoiceNumber=RSInvoiceNumber;
			model.RegistDate=RegistDate;

			WebDemo.BLL.WebDemo.EInvoices bll=new WebDemo.BLL.WebDemo.EInvoices();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
