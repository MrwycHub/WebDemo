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
namespace WebDemo.Web.WebDemo.TaskPlanHistory
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		WebDemo.BLL.WebDemo.TaskPlanHistory bll=new WebDemo.BLL.WebDemo.TaskPlanHistory();
		WebDemo.Model.WebDemo.TaskPlanHistory model=bll.GetModel();
		this.lblID.Text=model.ID.ToString();
		this.lblTaskID.Text=model.TaskID.ToString();
		this.lblCollectorID.Text=model.CollectorID.ToString();
		this.lblTaskName.Text=model.TaskName;
		this.lblCommandID.Text=model.CommandID.ToString();
		this.lblCommandInfo.Text=model.CommandInfo;
		this.lblMeterAddr.Text=model.MeterAddr;
		this.lblMeterType.Text=model.MeterType.ToString();
		this.lblMeterItem.Text=model.MeterItem.ToString();
		this.lblFreezeDate.Text=model.FreezeDate;
		this.lblTaskMonth.Text=model.TaskMonth.ToString();
		this.lblTaskDay.Text=model.TaskDay.ToString();
		this.lblTaskHour.Text=model.TaskHour.ToString();
		this.lblTaskMinute.Text=model.TaskMinute.ToString();
		this.lblExeMark.Text=model.ExeMark.ToString();
		this.lblExeDate.Text=model.ExeDate.ToString();
		this.lblExeError.Text=model.ExeError.ToString();
		this.lblTaskMark.Text=model.TaskMark.ToString();
		this.lblTaskType.Text=model.TaskType.ToString();
		this.lblTaskError.Text=model.TaskError.ToString();
		this.lblTryNum.Text=model.TryNum.ToString();
		this.lblHostAddr.Text=model.HostAddr;
		this.lblInsDate.Text=model.InsDate.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblTaskFrequency.Text=model.TaskFrequency.ToString();
		this.lblExeInfo.Text=model.ExeInfo;
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblDeptID.Text=model.DeptID;
		this.lblTaskWeek.Text=model.TaskWeek.ToString();

	}


    }
}
