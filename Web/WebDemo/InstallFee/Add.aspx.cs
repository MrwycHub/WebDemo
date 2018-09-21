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
namespace WebDemo.Web.WebDemo.InstallFee
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserNum.Text))
			{
				strErr+="UserNum格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSingleFee.Text))
			{
				strErr+="SingleFee格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSumFee.Text))
			{
				strErr+="SumFee格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="OperDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="SiteID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMark.Text))
			{
				strErr+="Mark格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInstallMark.Text))
			{
				strErr+="InstallMark格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UserNum=int.Parse(this.txtUserNum.Text);
			decimal SingleFee=decimal.Parse(this.txtSingleFee.Text);
			decimal SumFee=decimal.Parse(this.txtSumFee.Text);
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			int SiteID=int.Parse(this.txtSiteID.Text);
			int Mark=int.Parse(this.txtMark.Text);
			int InstallMark=int.Parse(this.txtInstallMark.Text);

			WebDemo.Model.WebDemo.InstallFee model=new WebDemo.Model.WebDemo.InstallFee();
			model.UserNum=UserNum;
			model.SingleFee=SingleFee;
			model.SumFee=SumFee;
			model.OperDate=OperDate;
			model.OperatorID=OperatorID;
			model.SiteID=SiteID;
			model.Mark=Mark;
			model.InstallMark=InstallMark;

			WebDemo.BLL.WebDemo.InstallFee bll=new WebDemo.BLL.WebDemo.InstallFee();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
