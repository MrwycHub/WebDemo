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
namespace WebDemo.Web.WebDemo.Operators
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(this.txtOperatorCode.Text.Trim().Length==0)
			{
				strErr+="OperatorCode不能为空！\\n";	
			}
			if(this.txtOperatorName.Text.Trim().Length==0)
			{
				strErr+="OperatorName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtRoleID.Text))
			{
				strErr+="RoleID格式错误！\\n";	
			}
			if(this.txtOperPassword.Text.Trim().Length==0)
			{
				strErr+="OperPassword不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="SiteID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="1-正常 2锁定格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateDate.Text))
			{
				strErr+="CreateDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLastLoginDate.Text))
			{
				strErr+="LastLoginDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPageRowCounts.Text))
			{
				strErr+="每页显示行数格式错误！\\n";	
			}
			if(this.txtOperLevel.Text.Trim().Length==0)
			{
				strErr+="OperLevel不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtTemplateID.Text))
			{
				strErr+="TemplateID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPaymentTemplateID.Text))
			{
				strErr+="PaymentTemplateID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtICTemplateID.Text))
			{
				strErr+="ICTemplateID格式错误！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="Phone不能为空！\\n";	
			}
			if(this.txtSelfSetting.Text.Trim().Length==0)
			{
				strErr+="SelfSetting不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtAutoRead.Text))
			{
				strErr+="AutoRead格式错误！\\n";	
			}
			if(this.txtPhoneSerialNumber.Text.Trim().Length==0)
			{
				strErr+="PhoneSerialNumber不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtIsBinding.Text))
			{
				strErr+="IsBinding格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRoleLevel.Text))
			{
				strErr+="RoleLevel格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtExpiryDate.Text))
			{
				strErr+="ExpiryDate格式错误！\\n";	
			}
			if(this.txtSkin.Text.Trim().Length==0)
			{
				strErr+="Skin不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			string OperatorCode=this.txtOperatorCode.Text;
			string OperatorName=this.txtOperatorName.Text;
			int RoleID=int.Parse(this.txtRoleID.Text);
			string OperPassword=this.txtOperPassword.Text;
			int SiteID=int.Parse(this.txtSiteID.Text);
			int Flag=int.Parse(this.txtFlag.Text);
			DateTime CreateDate=DateTime.Parse(this.txtCreateDate.Text);
			DateTime LastLoginDate=DateTime.Parse(this.txtLastLoginDate.Text);
			int PageRowCounts=int.Parse(this.txtPageRowCounts.Text);
			string OperLevel=this.txtOperLevel.Text;
			int TemplateID=int.Parse(this.txtTemplateID.Text);
			int PaymentTemplateID=int.Parse(this.txtPaymentTemplateID.Text);
			int ICTemplateID=int.Parse(this.txtICTemplateID.Text);
			string Phone=this.txtPhone.Text;
			string SelfSetting=this.txtSelfSetting.Text;
			int AutoRead=int.Parse(this.txtAutoRead.Text);
			string PhoneSerialNumber=this.txtPhoneSerialNumber.Text;
			int IsBinding=int.Parse(this.txtIsBinding.Text);
			int RoleLevel=int.Parse(this.txtRoleLevel.Text);
			DateTime ExpiryDate=DateTime.Parse(this.txtExpiryDate.Text);
			string Skin=this.txtSkin.Text;

			WebDemo.Model.WebDemo.Operators model=new WebDemo.Model.WebDemo.Operators();
			model.OperatorID=OperatorID;
			model.OperatorCode=OperatorCode;
			model.OperatorName=OperatorName;
			model.RoleID=RoleID;
			model.OperPassword=OperPassword;
			model.SiteID=SiteID;
			model.Flag=Flag;
			model.CreateDate=CreateDate;
			model.LastLoginDate=LastLoginDate;
			model.PageRowCounts=PageRowCounts;
			model.OperLevel=OperLevel;
			model.TemplateID=TemplateID;
			model.PaymentTemplateID=PaymentTemplateID;
			model.ICTemplateID=ICTemplateID;
			model.Phone=Phone;
			model.SelfSetting=SelfSetting;
			model.AutoRead=AutoRead;
			model.PhoneSerialNumber=PhoneSerialNumber;
			model.IsBinding=IsBinding;
			model.RoleLevel=RoleLevel;
			model.ExpiryDate=ExpiryDate;
			model.Skin=Skin;

			WebDemo.BLL.WebDemo.Operators bll=new WebDemo.BLL.WebDemo.Operators();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
