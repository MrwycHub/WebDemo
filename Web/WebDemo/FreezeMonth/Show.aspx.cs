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
namespace WebDemo.Web.WebDemo.FreezeMonth
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
		WebDemo.BLL.WebDemo.FreezeMonth bll=new WebDemo.BLL.WebDemo.FreezeMonth();
		WebDemo.Model.WebDemo.FreezeMonth model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblFreezeMonth.Text=model.FreezeMonth;
		this.lblFreezeNumber.Text=model.FreezeNumber.ToString();
		this.lblReadDate.Text=model.ReadDate.ToString();
		this.lblCalMark.Text=model.CalMark?"是":"否";
		this.lblInstantNumber.Text=model.InstantNumber.ToString();
		this.lblPileNumber.Text=model.PileNumber.ToString();
		this.lblWatertemp.Text=model.Watertemp.ToString();
		this.lblBackWatertemp.Text=model.BackWatertemp.ToString();
		this.lblWorkDate.Text=model.WorkDate.ToString();
		this.lblFactDate.Text=model.FactDate;
		this.lblBatteryState.Text=model.BatteryState.ToString();
		this.lblWarning.Text=model.Warning.ToString();
		this.lblReadType.Text=model.ReadType.ToString();
		this.lblOldFreezeNumber.Text=model.OldFreezeNumber.ToString();
		this.lblMegabit.Text=model.Megabit.ToString();
		this.lblAdditionNum.Text=model.AdditionNum.ToString();
		this.lblSmallImagePath.Text=model.SmallImagePath;
		this.lblBigImagePath.Text=model.BigImagePath;
		this.lblLocationX.Text=model.LocationX.ToString();
		this.lblLocationY.Text=model.LocationY.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblTakePhotoDate.Text=model.TakePhotoDate.ToString();
		this.lblSyncFlag.Text=model.SyncFlag.ToString();
		this.lblPriceSetNo.Text=model.PriceSetNo.ToString();
		this.lblCollectorReadDate.Text=model.CollectorReadDate.ToString();
		this.lblActiveSharp.Text=model.ActiveSharp.ToString();
		this.lblActivePeak.Text=model.ActivePeak.ToString();
		this.lblActiveShoulder.Text=model.ActiveShoulder.ToString();
		this.lblActiveOffPeak.Text=model.ActiveOffPeak.ToString();
		this.lblMeterStatusString.Text=model.MeterStatusString;
		this.lblVerifyValue.Text=model.VerifyValue.ToString();
		this.lblRemnant.Text=model.Remnant.ToString();
		this.lblValveState.Text=model.ValveState.ToString();

	}


    }
}
