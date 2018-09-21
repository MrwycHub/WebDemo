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
namespace WebDemo.Web.WebDemo.TaskPlanLog
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtTaskID.Text))
			{
				strErr+="TaskID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCollectorID.Text))
			{
				strErr+="CollectorID格式错误！\\n";	
			}
			if(this.txtMeterAddr.Text.Trim().Length==0)
			{
				strErr+="MeterAddr不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterType.Text))
			{
				strErr+="MeterType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtExeMark.Text))
			{
				strErr+="ExeMark格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtExeDate.Text))
			{
				strErr+="ExeDate格式错误！\\n";	
			}
			if(this.txtExeInfo.Text.Trim().Length==0)
			{
				strErr+="ExeInfo不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInsDate.Text))
			{
				strErr+="InsDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int TaskID=int.Parse(this.txtTaskID.Text);
			int CollectorID=int.Parse(this.txtCollectorID.Text);
			string MeterAddr=this.txtMeterAddr.Text;
			int MeterType=int.Parse(this.txtMeterType.Text);
			int ExeMark=int.Parse(this.txtExeMark.Text);
			DateTime ExeDate=DateTime.Parse(this.txtExeDate.Text);
			string ExeInfo=this.txtExeInfo.Text;
			DateTime InsDate=DateTime.Parse(this.txtInsDate.Text);

			WebDemo.Model.WebDemo.TaskPlanLog model=new WebDemo.Model.WebDemo.TaskPlanLog();
			model.TaskID=TaskID;
			model.CollectorID=CollectorID;
			model.MeterAddr=MeterAddr;
			model.MeterType=MeterType;
			model.ExeMark=ExeMark;
			model.ExeDate=ExeDate;
			model.ExeInfo=ExeInfo;
			model.InsDate=InsDate;

			WebDemo.BLL.WebDemo.TaskPlanLog bll=new WebDemo.BLL.WebDemo.TaskPlanLog();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
