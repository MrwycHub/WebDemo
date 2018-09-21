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
namespace WebDemo.Web.WebDemo.MultiUser
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserCode.Text.Trim().Length==0)
			{
				strErr+="UserCode不能为空！\\n";	
			}
			if(this.txtUserName.Text.Trim().Length==0)
			{
				strErr+="UserName不能为空！\\n";	
			}
			if(this.txtDeptID.Text.Trim().Length==0)
			{
				strErr+="DeptID不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCardId.Text))
			{
				strErr+="CardId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCardSector.Text))
			{
				strErr+="CardSector格式错误！\\n";	
			}
			if(this.txtCardSn.Text.Trim().Length==0)
			{
				strErr+="CardSn不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMark.Text))
			{
				strErr+="Mark格式错误！\\n";	
			}
			if(this.txtSex.Text.Trim().Length==0)
			{
				strErr+="Sex不能为空！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="Phone不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPaperType.Text))
			{
				strErr+="PaperType格式错误！\\n";	
			}
			if(this.txtPaperNo.Text.Trim().Length==0)
			{
				strErr+="PaperNo不能为空！\\n";	
			}
			if(this.txtuAccount.Text.Trim().Length==0)
			{
				strErr+="uAccount不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOpenTime.Text))
			{
				strErr+="OpenTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtValidDate.Text))
			{
				strErr+="ValidDate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLastMoney.Text))
			{
				strErr+="LastMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTotalMoney.Text))
			{
				strErr+="TotalMoney格式错误！\\n";	
			}
			if(this.txtReMark.Text.Trim().Length==0)
			{
				strErr+="ReMark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string UserCode=this.txtUserCode.Text;
			string UserName=this.txtUserName.Text;
			string DeptID=this.txtDeptID.Text;
			int CardId=int.Parse(this.txtCardId.Text);
			int CardSector=int.Parse(this.txtCardSector.Text);
			string CardSn=this.txtCardSn.Text;
			int Mark=int.Parse(this.txtMark.Text);
			string Sex=this.txtSex.Text;
			string Phone=this.txtPhone.Text;
			int PaperType=int.Parse(this.txtPaperType.Text);
			string PaperNo=this.txtPaperNo.Text;
			string uAccount=this.txtuAccount.Text;
			DateTime OpenTime=DateTime.Parse(this.txtOpenTime.Text);
			DateTime ValidDate=DateTime.Parse(this.txtValidDate.Text);
			decimal LastMoney=decimal.Parse(this.txtLastMoney.Text);
			decimal TotalMoney=decimal.Parse(this.txtTotalMoney.Text);
			string ReMark=this.txtReMark.Text;

			WebDemo.Model.WebDemo.MultiUser model=new WebDemo.Model.WebDemo.MultiUser();
			model.UserCode=UserCode;
			model.UserName=UserName;
			model.DeptID=DeptID;
			model.CardId=CardId;
			model.CardSector=CardSector;
			model.CardSn=CardSn;
			model.Mark=Mark;
			model.Sex=Sex;
			model.Phone=Phone;
			model.PaperType=PaperType;
			model.PaperNo=PaperNo;
			model.uAccount=uAccount;
			model.OpenTime=OpenTime;
			model.ValidDate=ValidDate;
			model.LastMoney=LastMoney;
			model.TotalMoney=TotalMoney;
			model.ReMark=ReMark;

			WebDemo.BLL.WebDemo.MultiUser bll=new WebDemo.BLL.WebDemo.MultiUser();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
