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
namespace WebDemo.Web.WebDemo.InstantTask
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
					int TaskID=(Convert.ToInt32(strid));
					ShowInfo(TaskID);
				}
			}
		}
		
	private void ShowInfo(int TaskID)
	{
		WebDemo.BLL.WebDemo.InstantTask bll=new WebDemo.BLL.WebDemo.InstantTask();
		WebDemo.Model.WebDemo.InstantTask model=bll.GetModel(TaskID);
		this.lblTaskID.Text=model.TaskID.ToString();
		this.lblTaskType.Text=model.TaskType;
		this.lblCollectorID.Text=model.CollectorID.ToString();
		this.lblMeterType.Text=model.MeterType.ToString();
		this.lblMeterAddr.Text=model.MeterAddr;
		this.lblHostAddr.Text=model.HostAddr;
		this.lblMeterStatus.Text=model.MeterStatus.ToString();
		this.lblMeterData.Text=model.MeterData.ToString();
		this.lblPayMoney.Text=model.PayMoney;
		this.lblTotalPayMoney.Text=model.TotalPayMoney;

	}


    }
}
