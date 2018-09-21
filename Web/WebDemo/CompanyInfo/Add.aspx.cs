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
namespace WebDemo.Web.WebDemo.CompanyInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCompanyName.Text.Trim().Length==0)
			{
				strErr+="CompanyName不能为空！\\n";	
			}
			if(this.txtCompanyNo.Text.Trim().Length==0)
			{
				strErr+="CompanyNo不能为空！\\n";	
			}
			if(this.txtPwd.Text.Trim().Length==0)
			{
				strErr+="Pwd不能为空！\\n";	
			}
			if(this.txtAuthorizationCode.Text.Trim().Length==0)
			{
				strErr+="AuthorizationCode不能为空！\\n";	
			}
			if(this.txtIDCode.Text.Trim().Length==0)
			{
				strErr+="IDCode不能为空！\\n";	
			}
			if(this.txtEFileCode.Text.Trim().Length==0)
			{
				strErr+="EFileCode不能为空！\\n";	
			}
			if(this.txtTaxAgencyCode.Text.Trim().Length==0)
			{
				strErr+="TaxAgencyCode不能为空！\\n";	
			}
			if(this.txtAgentMark.Text.Trim().Length==0)
			{
				strErr+="AgentMark不能为空！\\n";	
			}
			if(this.txtProjectName.Text.Trim().Length==0)
			{
				strErr+="ProjectName不能为空！\\n";	
			}
			if(this.txtProjectCode.Text.Trim().Length==0)
			{
				strErr+="ProjectCode不能为空！\\n";	
			}
			if(this.txtAccountBank.Text.Trim().Length==0)
			{
				strErr+="AccountBank不能为空！\\n";	
			}
			if(this.txtAccountNumber.Text.Trim().Length==0)
			{
				strErr+="AccountNumber不能为空！\\n";	
			}
			if(this.txtCompanyAddress.Text.Trim().Length==0)
			{
				strErr+="CompanyAddress不能为空！\\n";	
			}
			if(this.txtCompanyPhone.Text.Trim().Length==0)
			{
				strErr+="CompanyPhone不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSleepTime.Text))
			{
				strErr+="SleepTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="UpdateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CompanyName=this.txtCompanyName.Text;
			string CompanyNo=this.txtCompanyNo.Text;
			string Pwd=this.txtPwd.Text;
			string AuthorizationCode=this.txtAuthorizationCode.Text;
			string IDCode=this.txtIDCode.Text;
			string EFileCode=this.txtEFileCode.Text;
			string TaxAgencyCode=this.txtTaxAgencyCode.Text;
			string AgentMark=this.txtAgentMark.Text;
			string ProjectName=this.txtProjectName.Text;
			string ProjectCode=this.txtProjectCode.Text;
			string AccountBank=this.txtAccountBank.Text;
			string AccountNumber=this.txtAccountNumber.Text;
			string CompanyAddress=this.txtCompanyAddress.Text;
			string CompanyPhone=this.txtCompanyPhone.Text;
			int SleepTime=int.Parse(this.txtSleepTime.Text);
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);

			WebDemo.Model.WebDemo.CompanyInfo model=new WebDemo.Model.WebDemo.CompanyInfo();
			model.CompanyName=CompanyName;
			model.CompanyNo=CompanyNo;
			model.Pwd=Pwd;
			model.AuthorizationCode=AuthorizationCode;
			model.IDCode=IDCode;
			model.EFileCode=EFileCode;
			model.TaxAgencyCode=TaxAgencyCode;
			model.AgentMark=AgentMark;
			model.ProjectName=ProjectName;
			model.ProjectCode=ProjectCode;
			model.AccountBank=AccountBank;
			model.AccountNumber=AccountNumber;
			model.CompanyAddress=CompanyAddress;
			model.CompanyPhone=CompanyPhone;
			model.SleepTime=SleepTime;
			model.UpdateTime=UpdateTime;

			WebDemo.BLL.WebDemo.CompanyInfo bll=new WebDemo.BLL.WebDemo.CompanyInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
