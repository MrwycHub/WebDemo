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
namespace WebDemo.Web.WebDemo.ClientEnvironmentInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDanWeiName.Text.Trim().Length==0)
			{
				strErr+="DanWeiName不能为空！\\n";	
			}
			if(this.txtJiQiMa.Text.Trim().Length==0)
			{
				strErr+="JiQiMa不能为空！\\n";	
			}
			if(this.txtOperatorCode.Text.Trim().Length==0)
			{
				strErr+="OperatorCode不能为空！\\n";	
			}
			if(this.txtIP.Text.Trim().Length==0)
			{
				strErr+="IP不能为空！\\n";	
			}
			if(this.txtBrowserName.Text.Trim().Length==0)
			{
				strErr+="BrowserName不能为空！\\n";	
			}
			if(this.txtBrowerVersion.Text.Trim().Length==0)
			{
				strErr+="BrowerVersion不能为空！\\n";	
			}
			if(this.txtOSName.Text.Trim().Length==0)
			{
				strErr+="OSName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateTime.Text))
			{
				strErr+="CreateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string DanWeiName=this.txtDanWeiName.Text;
			string JiQiMa=this.txtJiQiMa.Text;
			string OperatorCode=this.txtOperatorCode.Text;
			string IP=this.txtIP.Text;
			string BrowserName=this.txtBrowserName.Text;
			string BrowerVersion=this.txtBrowerVersion.Text;
			string OSName=this.txtOSName.Text;
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);

			WebDemo.Model.WebDemo.ClientEnvironmentInfo model=new WebDemo.Model.WebDemo.ClientEnvironmentInfo();
			model.DanWeiName=DanWeiName;
			model.JiQiMa=JiQiMa;
			model.OperatorCode=OperatorCode;
			model.IP=IP;
			model.BrowserName=BrowserName;
			model.BrowerVersion=BrowerVersion;
			model.OSName=OSName;
			model.CreateTime=CreateTime;

			WebDemo.BLL.WebDemo.ClientEnvironmentInfo bll=new WebDemo.BLL.WebDemo.ClientEnvironmentInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
