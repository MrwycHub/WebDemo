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
namespace WebDemo.Web.WebDemo.Collectors
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
					int CollectorID=(Convert.ToInt32(strid));
					ShowInfo(CollectorID);
				}
			}
		}
		
	private void ShowInfo(int CollectorID)
	{
		WebDemo.BLL.WebDemo.Collectors bll=new WebDemo.BLL.WebDemo.Collectors();
		WebDemo.Model.WebDemo.Collectors model=bll.GetModel(CollectorID);
		this.lblCollectorID.Text=model.CollectorID.ToString();
		this.lblCollectorName.Text=model.CollectorName;
		this.lblCollectorAddr.Text=model.CollectorAddr;
		this.lblCollectorType.Text=model.CollectorType.ToString();
		this.lblDeptID.Text=model.DeptID;
		this.lblPhoneNumber.Text=model.PhoneNumber;
		this.lblCollOverTime.Text=model.CollOverTime.ToString();
		this.lblIPNumber.Text=model.IPNumber;
		this.lblPortNumber.Text=model.PortNumber.ToString();
		this.lblGprsCycle.Text=model.GprsCycle.ToString();
		this.lblFreezeDay.Text=model.FreezeDay.ToString();
		this.lblFreezeHour.Text=model.FreezeHour.ToString();
		this.lblReadDay.Text=model.ReadDay;
		this.lblLoginDate.Text=model.LoginDate.ToString();
		this.lblUpdateDate.Text=model.UpdateDate.ToString();
		this.lblLoginIP.Text=model.LoginIP;
		this.lblLoginPort.Text=model.LoginPort.ToString();
		this.lblMark.Text=model.Mark.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblCollectorVer.Text=model.CollectorVer;
		this.lblCollectorModel.Text=model.CollectorModel;
		this.lblCollectorAPN.Text=model.CollectorAPN;
		this.lblIsServerMode.Text=model.IsServerMode.ToString();
		this.lblWorkTime.Text=model.WorkTime;
		this.lblNetWorkTime.Text=model.NetWorkTime;
		this.lblFactoryCode.Text=model.FactoryCode;
		this.lblFramesType.Text=model.FramesType.ToString();
		this.lblMeterAddrFormat.Text=model.MeterAddrFormat.ToString();
		this.lblGprsPhone.Text=model.GprsPhone;
		this.lblExpireTime.Text=model.ExpireTime;
		this.lblWorkMode.Text=model.WorkMode.ToString();
		this.lblLng.Text=model.Lng.ToString();
		this.lblLat.Text=model.Lat.ToString();

	}


    }
}
