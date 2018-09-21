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
namespace WebDemo.Web.WebDemo.MetersDev
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
					int MeterID=(Convert.ToInt32(strid));
					ShowInfo(MeterID);
				}
			}
		}
		
	private void ShowInfo(int MeterID)
	{
		WebDemo.BLL.WebDemo.MetersDev bll=new WebDemo.BLL.WebDemo.MetersDev();
		WebDemo.Model.WebDemo.MetersDev model=bll.GetModel(MeterID);
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblDisenableDate.Text=model.DisenableDate.ToString();
		this.lblSiteDir.Text=model.SiteDir.ToString();
		this.lblInsureCode.Text=model.InsureCode;
		this.lblInsureDate.Text=model.InsureDate.ToString();
		this.lblInsureEndDate.Text=model.InsureEndDate.ToString();
		this.lblGasDir.Text=model.GasDir.ToString();
		this.lblInstallPos.Text=model.InstallPos.ToString();
		this.lblInstallWorkerID.Text=model.InstallWorkerID.ToString();
		this.lblInstallDate.Text=model.InstallDate.ToString();
		this.lblFireWorkerID.Text=model.FireWorkerID.ToString();
		this.lblFireDate.Text=model.FireDate.ToString();
		this.lblFirstCheckDate.Text=model.FirstCheckDate.ToString();
		this.lblFirstCheckMark.Text=model.FirstCheckMark.ToString();
		this.lblCheckCyc.Text=model.CheckCyc.ToString();
		this.lblBoilerFlag.Text=model.BoilerFlag.ToString();
		this.lblSelfFlag.Text=model.SelfFlag.ToString();
		this.lblBookID.Text=model.BookID.ToString();
		this.lblInstallID.Text=model.InstallID.ToString();
		this.lblFirstCheckInfo.Text=model.FirstCheckInfo;
		this.lblFirstCheckWorkerID.Text=model.FirstCheckWorkerID.ToString();
		this.lblCurrValveState.Text=model.CurrValveState.ToString();

	}


    }
}
