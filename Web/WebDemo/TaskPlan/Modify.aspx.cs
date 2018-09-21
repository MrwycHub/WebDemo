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
namespace WebDemo.Web.WebDemo.TaskPlan
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.TaskPlan bll=new WebDemo.BLL.WebDemo.TaskPlan();
		WebDemo.Model.WebDemo.TaskPlan model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtTaskID.Text=model.TaskID.ToString();
		this.txtCollectorID.Text=model.CollectorID.ToString();
		this.txtTaskName.Text=model.TaskName;
		this.txtCommandID.Text=model.CommandID.ToString();
		this.txtCommandInfo.Text=model.CommandInfo;
		this.txtMeterAddr.Text=model.MeterAddr;
		this.txtMeterType.Text=model.MeterType.ToString();
		this.txtMeterItem.Text=model.MeterItem.ToString();
		this.txtFreezeDate.Text=model.FreezeDate;
		this.txtTaskMonth.Text=model.TaskMonth.ToString();
		this.txtTaskDay.Text=model.TaskDay.ToString();
		this.txtTaskHour.Text=model.TaskHour.ToString();
		this.txtTaskMinute.Text=model.TaskMinute.ToString();
		this.txtExeMark.Text=model.ExeMark.ToString();
		this.txtExeDate.Text=model.ExeDate.ToString();
		this.txtExeError.Text=model.ExeError.ToString();
		this.txtTaskMark.Text=model.TaskMark.ToString();
		this.txtTaskType.Text=model.TaskType.ToString();
		this.txtTaskError.Text=model.TaskError.ToString();
		this.txtTryNum.Text=model.TryNum.ToString();
		this.txtHostAddr.Text=model.HostAddr;
		this.txtInsDate.Text=model.InsDate.ToString();
		this.txtMeterID.Text=model.MeterID.ToString();
		this.txtTaskFrequency.Text=model.TaskFrequency.ToString();
		this.txtExeInfo.Text=model.ExeInfo;
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtDeptID.Text=model.DeptID;
		this.txtTaskWeek.Text=model.TaskWeek.ToString();
		this.txtPriceTypeID.Text=model.PriceTypeID.ToString();
		this.txtServerId.Text=model.ServerId.ToString();
		this.txtExeType.Text=model.ExeType.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtTaskID.Text))
			{
				strErr+="任务编号格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCollectorID.Text))
			{
				strErr+="集中器编号格式错误！\\n";	
			}
			if(this.txtTaskName.Text.Trim().Length==0)
			{
				strErr+="任务名称不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCommandID.Text))
			{
				strErr+="指令编号格式错误！\\n";	
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
				strErr+="抄表数据项格式错误！\\n";	
			}
			if(this.txtFreezeDate.Text.Trim().Length==0)
			{
				strErr+="冻结日不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskMonth.Text))
			{
				strErr+="执行月份(0表示每个月)格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskDay.Text))
			{
				strErr+="执行日期(0表示每天)格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskHour.Text))
			{
				strErr+="执行时格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskMinute.Text))
			{
				strErr+="执行分格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtExeMark.Text))
			{
				strErr+="执行标志(1-未执行；2-已执格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtExeDate.Text))
			{
				strErr+="执行时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtExeError.Text))
			{
				strErr+="重试次数格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskMark.Text))
			{
				strErr+="启动任务(1-启动 2 不启动格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskType.Text))
			{
				strErr+="任务类型格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTaskError.Text))
			{
				strErr+="TaskError格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTryNum.Text))
			{
				strErr+="重试次数格式错误！\\n";	
			}
			if(this.txtHostAddr.Text.Trim().Length==0)
			{
				strErr+="采集器地址不能为空！\\n";	
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
				strErr+="任务类型格式错误！\\n";	
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
			if(!PageValidate.IsNumber(txtPriceTypeID.Text))
			{
				strErr+="PriceTypeID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtServerId.Text))
			{
				strErr+="ServerId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtExeType.Text))
			{
				strErr+="ExeType格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
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
			int PriceTypeID=int.Parse(this.txtPriceTypeID.Text);
			int ServerId=int.Parse(this.txtServerId.Text);
			int ExeType=int.Parse(this.txtExeType.Text);


			WebDemo.Model.WebDemo.TaskPlan model=new WebDemo.Model.WebDemo.TaskPlan();
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
			model.PriceTypeID=PriceTypeID;
			model.ServerId=ServerId;
			model.ExeType=ExeType;

			WebDemo.BLL.WebDemo.TaskPlan bll=new WebDemo.BLL.WebDemo.TaskPlan();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
