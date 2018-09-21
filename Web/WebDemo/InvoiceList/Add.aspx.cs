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
namespace WebDemo.Web.WebDemo.InvoiceList
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtInID.Text))
			{
				strErr+="InID格式错误！\\n";	
			}
			if(this.txtInCode.Text.Trim().Length==0)
			{
				strErr+="InCode不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtInNumber.Text))
			{
				strErr+="InNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="SiteID格式错误！\\n";	
			}
			if(this.txtOperatorName.Text.Trim().Length==0)
			{
				strErr+="OperatorName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtGetDate.Text))
			{
				strErr+="GetDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayID.Text))
			{
				strErr+="PayID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtPrintDate.Text))
			{
				strErr+="PrintDate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtInMoney.Text))
			{
				strErr+="InMoney格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInMark.Text))
			{
				strErr+="InMark格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSendMark.Text))
			{
				strErr+="SendMark格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSendDate.Text))
			{
				strErr+="SendDate格式错误！\\n";	
			}
			if(this.txtprintMan.Text.Trim().Length==0)
			{
				strErr+="printMan不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtzfDate.Text))
			{
				strErr+="zfDate格式错误！\\n";	
			}
			if(this.txtzfInCode.Text.Trim().Length==0)
			{
				strErr+="zfInCode不能为空！\\n";	
			}
			if(this.txtzfInNumber.Text.Trim().Length==0)
			{
				strErr+="zfInNumber不能为空！\\n";	
			}
			if(this.txtUName.Text.Trim().Length==0)
			{
				strErr+="UName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int InID=int.Parse(this.txtInID.Text);
			string InCode=this.txtInCode.Text;
			int InNumber=int.Parse(this.txtInNumber.Text);
			int SiteID=int.Parse(this.txtSiteID.Text);
			string OperatorName=this.txtOperatorName.Text;
			DateTime GetDate=DateTime.Parse(this.txtGetDate.Text);
			int PayID=int.Parse(this.txtPayID.Text);
			DateTime PrintDate=DateTime.Parse(this.txtPrintDate.Text);
			decimal InMoney=decimal.Parse(this.txtInMoney.Text);
			int InMark=int.Parse(this.txtInMark.Text);
			int SendMark=int.Parse(this.txtSendMark.Text);
			DateTime SendDate=DateTime.Parse(this.txtSendDate.Text);
			string printMan=this.txtprintMan.Text;
			DateTime zfDate=DateTime.Parse(this.txtzfDate.Text);
			string zfInCode=this.txtzfInCode.Text;
			string zfInNumber=this.txtzfInNumber.Text;
			string UName=this.txtUName.Text;

			WebDemo.Model.WebDemo.InvoiceList model=new WebDemo.Model.WebDemo.InvoiceList();
			model.InID=InID;
			model.InCode=InCode;
			model.InNumber=InNumber;
			model.SiteID=SiteID;
			model.OperatorName=OperatorName;
			model.GetDate=GetDate;
			model.PayID=PayID;
			model.PrintDate=PrintDate;
			model.InMoney=InMoney;
			model.InMark=InMark;
			model.SendMark=SendMark;
			model.SendDate=SendDate;
			model.printMan=printMan;
			model.zfDate=zfDate;
			model.zfInCode=zfInCode;
			model.zfInNumber=zfInNumber;
			model.UName=UName;

			WebDemo.BLL.WebDemo.InvoiceList bll=new WebDemo.BLL.WebDemo.InvoiceList();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
