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
namespace WebDemo.Web.WebDemo.MessageRemind
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtRemindType.Text))
			{
				strErr+="RemindType格式错误！\\n";	
			}
			if(this.txtRemindContent.Text.Trim().Length==0)
			{
				strErr+="RemindContent不能为空！\\n";	
			}
			if(this.txtOperatorIDStr.Text.Trim().Length==0)
			{
				strErr+="OperatorIDStr不能为空！\\n";	
			}
			if(this.txtReadedStr.Text.Trim().Length==0)
			{
				strErr+="ReadedStr不能为空！\\n";	
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
			int RemindType=int.Parse(this.txtRemindType.Text);
			string RemindContent=this.txtRemindContent.Text;
			string OperatorIDStr=this.txtOperatorIDStr.Text;
			string ReadedStr=this.txtReadedStr.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);

			WebDemo.Model.WebDemo.MessageRemind model=new WebDemo.Model.WebDemo.MessageRemind();
			model.RemindType=RemindType;
			model.RemindContent=RemindContent;
			model.OperatorIDStr=OperatorIDStr;
			model.ReadedStr=ReadedStr;
			model.UpdateTime=UpdateTime;

			WebDemo.BLL.WebDemo.MessageRemind bll=new WebDemo.BLL.WebDemo.MessageRemind();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
