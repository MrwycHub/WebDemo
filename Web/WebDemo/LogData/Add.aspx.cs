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
namespace WebDemo.Web.WebDemo.LogData
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtLogTitle.Text.Trim().Length==0)
			{
				strErr+="LogTitle不能为空！\\n";	
			}
			if(this.txtLogType.Text.Trim().Length==0)
			{
				strErr+="LogType不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLogDate.Text))
			{
				strErr+="LogDate格式错误！\\n";	
			}
			if(this.txtLogMemo.Text.Trim().Length==0)
			{
				strErr+="LogMemo不能为空！\\n";	
			}
			if(this.txtLogData.Text.Trim().Length==0)
			{
				strErr+="LogData不能为空！\\n";	
			}
			if(this.txtLogOperator.Text.Trim().Length==0)
			{
				strErr+="LogOperator不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string LogTitle=this.txtLogTitle.Text;
			string LogType=this.txtLogType.Text;
			DateTime LogDate=DateTime.Parse(this.txtLogDate.Text);
			string LogMemo=this.txtLogMemo.Text;
			string LogData=this.txtLogData.Text;
			string LogOperator=this.txtLogOperator.Text;

			WebDemo.Model.WebDemo.LogData model=new WebDemo.Model.WebDemo.LogData();
			model.LogTitle=LogTitle;
			model.LogType=LogType;
			model.LogDate=LogDate;
			model.LogMemo=LogMemo;
			model.LogData=LogData;
			model.LogOperator=LogOperator;

			WebDemo.BLL.WebDemo.LogData bll=new WebDemo.BLL.WebDemo.LogData();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
