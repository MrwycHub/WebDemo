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
namespace WebDemo.Web.WebDemo.TaskPlanLog
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
		WebDemo.BLL.WebDemo.TaskPlanLog bll=new WebDemo.BLL.WebDemo.TaskPlanLog();
		WebDemo.Model.WebDemo.TaskPlanLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblTaskID.Text=model.TaskID.ToString();
		this.lblCollectorID.Text=model.CollectorID.ToString();
		this.lblMeterAddr.Text=model.MeterAddr;
		this.lblMeterType.Text=model.MeterType.ToString();
		this.lblExeMark.Text=model.ExeMark.ToString();
		this.lblExeDate.Text=model.ExeDate.ToString();
		this.lblExeInfo.Text=model.ExeInfo;
		this.lblInsDate.Text=model.InsDate.ToString();

	}


    }
}
