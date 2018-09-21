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
namespace WebDemo.Web.WebDemo.UserRegist
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtRegistPhone.Text.Trim().Length==0)
			{
				strErr+="RegistPhone不能为空！\\n";	
			}
			if(this.txtPassWord.Text.Trim().Length==0)
			{
				strErr+="PassWord不能为空！\\n";	
			}
			if(this.txtIdentityCard.Text.Trim().Length==0)
			{
				strErr+="IdentityCard不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}
			if(this.txtRegistName.Text.Trim().Length==0)
			{
				strErr+="RegistName不能为空！\\n";	
			}
			if(this.txtHeadImgPath.Text.Trim().Length==0)
			{
				strErr+="HeadImgPath不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="UpdateTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSecurityId.Text))
			{
				strErr+="SecurityId格式错误！\\n";	
			}
			if(this.txtSecurityAnswer.Text.Trim().Length==0)
			{
				strErr+="SecurityAnswer不能为空！\\n";	
			}
			if(this.txtRandomStr.Text.Trim().Length==0)
			{
				strErr+="RandomStr不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtAppType.Text))
			{
				strErr+="AppType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayIntegration.Text))
			{
				strErr+="PayIntegration格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTotalMoney.Text))
			{
				strErr+="TotalMoney格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string RegistPhone=this.txtRegistPhone.Text;
			string PassWord=this.txtPassWord.Text;
			string IdentityCard=this.txtIdentityCard.Text;
			int Flag=int.Parse(this.txtFlag.Text);
			string RegistName=this.txtRegistName.Text;
			string HeadImgPath=this.txtHeadImgPath.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			int SecurityId=int.Parse(this.txtSecurityId.Text);
			string SecurityAnswer=this.txtSecurityAnswer.Text;
			string RandomStr=this.txtRandomStr.Text;
			int AppType=int.Parse(this.txtAppType.Text);
			int PayIntegration=int.Parse(this.txtPayIntegration.Text);
			decimal TotalMoney=decimal.Parse(this.txtTotalMoney.Text);

			WebDemo.Model.WebDemo.UserRegist model=new WebDemo.Model.WebDemo.UserRegist();
			model.RegistPhone=RegistPhone;
			model.PassWord=PassWord;
			model.IdentityCard=IdentityCard;
			model.Flag=Flag;
			model.RegistName=RegistName;
			model.HeadImgPath=HeadImgPath;
			model.UpdateTime=UpdateTime;
			model.SecurityId=SecurityId;
			model.SecurityAnswer=SecurityAnswer;
			model.RandomStr=RandomStr;
			model.AppType=AppType;
			model.PayIntegration=PayIntegration;
			model.TotalMoney=TotalMoney;

			WebDemo.BLL.WebDemo.UserRegist bll=new WebDemo.BLL.WebDemo.UserRegist();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
