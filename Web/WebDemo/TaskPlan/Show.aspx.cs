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
namespace WebDemo.Web.WebDemo.TaskPlan
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.TaskPlan bll=new WebDemo.BLL.WebDemo.TaskPlan();
		WebDemo.Model.WebDemo.TaskPlan model=bll.GetModel(ID);
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
		this.lblPriceTypeID.Text=model.PriceTypeID.ToString();
		this.lblServerId.Text=model.ServerId.ToString();
		this.lblExeType.Text=model.ExeType.ToString();

	}


    }
}
