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
namespace WebDemo.Web.WebDemo.TaskPlanHistory
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtID.Text))
			{
				strErr+="ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskID.Text))
			{
				strErr+="TaskID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCollectorID.Text))
			{
				strErr+="CollectorID格式错误！\\n";	
			}
			if(this.txtTaskName.Text.Trim().Length==0)
			{
				strErr+="TaskName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCommandID.Text))
			{
				strErr+="CommandID格式错误！\\n";	
			}
			if(this.txtCommandInfo.Text.Trim().Length==0)
			{
				strErr+="CommandInfo不能为空！\\n";	
			}
			if(this.txtMeterAddr.Text.Trim().Length==0)
			{
				strErr+="MeterAddr不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterType.Text))
			{
				strErr+="MeterType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterItem.Text))
			{
				strErr+="MeterItem格式错误！\\n";	
			}
			if(this.txtFreezeDate.Text.Trim().Length==0)
			{
				strErr+="FreezeDate不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskMonth.Text))
			{
				strErr+="TaskMonth格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskDay.Text))
			{
				strErr+="TaskDay格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskHour.Text))
			{
				strErr+="TaskHour格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskMinute.Text))
			{
				strErr+="TaskMinute格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtExeMark.Text))
			{
				strErr+="ExeMark格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtExeDate.Text))
			{
				strErr+="ExeDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtExeError.Text))
			{
				strErr+="ExeError格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskMark.Text))
			{
				strErr+="TaskMark格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskType.Text))
			{
				strErr+="TaskType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskError.Text))
			{
				strErr+="TaskError格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTryNum.Text))
			{
				strErr+="TryNum格式错误！\\n";	
			}
			if(this.txtHostAddr.Text.Trim().Length==0)
			{
				strErr+="HostAddr不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInsDate.Text))
			{
				strErr+="InsDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskFrequency.Text))
			{
				strErr+="TaskFrequency格式错误！\\n";	
			}
			if(this.txtExeInfo.Text.Trim().Length==0)
			{
				strErr+="ExeInfo不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(this.txtDeptID.Text.Trim().Length==0)
			{
				strErr+="DeptID不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskWeek.Text))
			{
				strErr+="TaskWeek格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.txtID.Text);
			int TaskID=int.Parse(this.txtTaskID.Text);
			int CollectorID=int.Parse(this.txtCollectorID.Text);
			string TaskName=this.txtTaskName.Text;
			int CommandID=int.Parse(this.txtCommandID.Text);
			string CommandInfo=this.txtCommandInfo.Text;
			string MeterAddr=this.txtMeterAddr.Text;
			int MeterType=int.Parse(this.txtMeterType.Text);
			int MeterItem=int.Parse(this.txtMeterItem.Text);
			string FreezeDate=this.txtFreezeDate.Text;
			int TaskMonth=int.Parse(this.txtTaskMonth.Text);
			int TaskDay=int.Parse(this.txtTaskDay.Text);
			int TaskHour=int.Parse(this.txtTaskHour.Text);
			int TaskMinute=int.Parse(this.txtTaskMinute.Text);
			int ExeMark=int.Parse(this.txtExeMark.Text);
			DateTime ExeDate=DateTime.Parse(this.txtExeDate.Text);
			int ExeError=int.Parse(this.txtExeError.Text);
			int TaskMark=int.Parse(this.txtTaskMark.Text);
			int TaskType=int.Parse(this.txtTaskType.Text);
			int TaskError=int.Parse(this.txtTaskError.Text);
			int TryNum=int.Parse(this.txtTryNum.Text);
			string HostAddr=this.txtHostAddr.Text;
			DateTime InsDate=DateTime.Parse(this.txtInsDate.Text);
			int MeterID=int.Parse(this.txtMeterID.Text);
			int TaskFrequency=int.Parse(this.txtTaskFrequency.Text);
			string ExeInfo=this.txtExeInfo.Text;
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			string DeptID=this.txtDeptID.Text;
			int TaskWeek=int.Parse(this.txtTaskWeek.Text);

			WebDemo.Model.WebDemo.TaskPlanHistory model=new WebDemo.Model.WebDemo.TaskPlanHistory();
			model.ID=ID;
			model.TaskID=TaskID;
			model.CollectorID=CollectorID;
			model.TaskName=TaskName;
			model.CommandID=CommandID;
			model.CommandInfo=CommandInfo;
			model.MeterAddr=MeterAddr;
			model.MeterType=MeterType;
			model.MeterItem=MeterItem;
			model.FreezeDate=FreezeDate;
			model.TaskMonth=TaskMonth;
			model.TaskDay=TaskDay;
			model.TaskHour=TaskHour;
			model.TaskMinute=TaskMinute;
			model.ExeMark=ExeMark;
			model.ExeDate=ExeDate;
			model.ExeError=ExeError;
			model.TaskMark=TaskMark;
			model.TaskType=TaskType;
			model.TaskError=TaskError;
			model.TryNum=TryNum;
			model.HostAddr=HostAddr;
			model.InsDate=InsDate;
			model.MeterID=MeterID;
			model.TaskFrequency=TaskFrequency;
			model.ExeInfo=ExeInfo;
			model.OperatorID=OperatorID;
			model.DeptID=DeptID;
			model.TaskWeek=TaskWeek;

			WebDemo.BLL.WebDemo.TaskPlanHistory bll=new WebDemo.BLL.WebDemo.TaskPlanHistory();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
