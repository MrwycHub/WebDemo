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
namespace WebDemo.Web.WebDemo.Hosts
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
					int HostID=(Convert.ToInt32(strid));
					ShowInfo(HostID);
				}
			}
		}
		
	private void ShowInfo(int HostID)
	{
		WebDemo.BLL.WebDemo.Hosts bll=new WebDemo.BLL.WebDemo.Hosts();
		WebDemo.Model.WebDemo.Hosts model=bll.GetModel(HostID);
		this.lblCollectorID.Text=model.CollectorID.ToString();
		this.lblHostID.Text=model.HostID.ToString();
		this.lblHostName.Text=model.HostName;
		this.lblHostAddr.Text=model.HostAddr;
		this.lblRemark.Text=model.Remark;
		this.lblflag.Text=model.flag.ToString();
		this.lblLimitNum.Text=model.LimitNum.ToString();
		this.lblHostComType.Text=model.HostComType.ToString();
		this.lblHostType.Text=model.HostType.ToString();
		this.lblHostRDate.Text=model.HostRDate;
		this.lblDownloadFlag.Text=model.DownloadFlag.ToString();
		this.lblPowerType.Text=model.PowerType.ToString();
		this.lblHostNo.Text=model.HostNo.ToString();
		this.lblHostLimitNum.Text=model.HostLimitNum.ToString();
		this.lblIsRelay.Text=model.IsRelay.ToString();
		this.lblIsDownMeterType.Text=model.IsDownMeterType.ToString();

	}


    }
}
