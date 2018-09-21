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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int LogID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(LogID);
				}
			}
		}
			
	private void ShowInfo(int LogID)
	{
		WebDemo.BLL.WebDemo.LogData bll=new WebDemo.BLL.WebDemo.LogData();
		WebDemo.Model.WebDemo.LogData model=bll.GetModel(LogID);
		this.lblLogID.Text=model.LogID.ToString();
		this.txtLogTitle.Text=model.LogTitle;
		this.txtLogType.Text=model.LogType;
		this.txtLogDate.Text=model.LogDate.ToString();
		this.txtLogMemo.Text=model.LogMemo;
		this.txtLogData.Text=model.LogData;
		this.txtLogOperator.Text=model.LogOperator;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int LogID=int.Parse(this.lblLogID.Text);
			string LogTitle=this.txtLogTitle.Text;
			string LogType=this.txtLogType.Text;
			DateTime LogDate=DateTime.Parse(this.txtLogDate.Text);
			string LogMemo=this.txtLogMemo.Text;
			string LogData=this.txtLogData.Text;
			string LogOperator=this.txtLogOperator.Text;


			WebDemo.Model.WebDemo.LogData model=new WebDemo.Model.WebDemo.LogData();
			model.LogID=LogID;
			model.LogTitle=LogTitle;
			model.LogType=LogType;
			model.LogDate=LogDate;
			model.LogMemo=LogMemo;
			model.LogData=LogData;
			model.LogOperator=LogOperator;

			WebDemo.BLL.WebDemo.LogData bll=new WebDemo.BLL.WebDemo.LogData();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
