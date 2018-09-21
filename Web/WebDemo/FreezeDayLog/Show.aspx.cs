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
namespace WebDemo.Web.WebDemo.FreezeDayLog
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
		WebDemo.BLL.WebDemo.FreezeDayLog bll=new WebDemo.BLL.WebDemo.FreezeDayLog();
		WebDemo.Model.WebDemo.FreezeDayLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblFreezeDate.Text=model.FreezeDate;
		this.lblFreezeNumber.Text=model.FreezeNumber.ToString();
		this.lblReadDate.Text=model.ReadDate.ToString();
		this.lblInstantNumber.Text=model.InstantNumber.ToString();
		this.lblPileNumber.Text=model.PileNumber.ToString();
		this.lblWatertemp.Text=model.Watertemp.ToString();
		this.lblBackWatertemp.Text=model.BackWatertemp.ToString();
		this.lblWorkDate.Text=model.WorkDate.ToString();
		this.lblFactDate.Text=model.FactDate;
		this.lblBatteryState.Text=model.BatteryState.ToString();
		this.lblWarning.Text=model.Warning.ToString();
		this.lblValveState.Text=model.ValveState.ToString();
		this.lblOldFreezeNumber.Text=model.OldFreezeNumber.ToString();
		this.lblMegabit.Text=model.Megabit.ToString();
		this.lblPriceSetNo.Text=model.PriceSetNo.ToString();
		this.lblCollectorReadDate.Text=model.CollectorReadDate.ToString();
		this.lblRemnant.Text=model.Remnant.ToString();

	}


    }
}
