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
namespace WebDemo.Web.WebDemo.Meters
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
		WebDemo.BLL.WebDemo.Meters bll=new WebDemo.BLL.WebDemo.Meters();
		WebDemo.Model.WebDemo.Meters model=bll.GetModel(MeterID);
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblMeterTypeID.Text=model.MeterTypeID.ToString();
		this.lblMeterAddr.Text=model.MeterAddr;
		this.lblCollectorID.Text=model.CollectorID.ToString();
		this.lblHostID.Text=model.HostID.ToString();
		this.lblUsersID.Text=model.UsersID.ToString();
		this.lblCardType.Text=model.CardType.ToString();
		this.lblCardID.Text=model.CardID.ToString();
		this.lblCardSector.Text=model.CardSector.ToString();
		this.lblTotalMoney.Text=model.TotalMoney.ToString();
		this.lblTotalInt.Text=model.TotalInt.ToString();
		this.lblTotalBase.Text=model.TotalBase.ToString();
		this.lblLastMoney.Text=model.LastMoney.ToString();
		this.lblLastInt.Text=model.LastInt.ToString();
		this.lblLastBase.Text=model.LastBase.ToString();
		this.lblMark.Text=model.Mark.ToString();
		this.lblMeterBase.Text=model.MeterBase.ToString();
		this.lblMeterVerify.Text=model.MeterVerify.ToString();
		this.lblPriceTypeID.Text=model.PriceTypeID.ToString();
		this.lblMeterDate.Text=model.MeterDate.ToString();
		this.lblMeterNumber.Text=model.MeterNumber;
		this.lblInstallDate.Text=model.InstallDate.ToString();
		this.lblInstallAddr.Text=model.InstallAddr;
		this.lblConstant.Text=model.Constant.ToString();
		this.lblMutual.Text=model.Mutual.ToString();
		this.lblCoefficient.Text=model.Coefficient.ToString();
		this.lblLastCalNumber.Text=model.LastCalNumber.ToString();
		this.lblLastCalMonth.Text=model.LastCalMonth;
		this.lblLastReadNumber.Text=model.LastReadNumber.ToString();
		this.lblPayType.Text=model.PayType.ToString();
		this.lblModalid.Text=model.Modalid.ToString();
		this.lblXPower.Text=model.XPower.ToString();
		this.lblRemark.Text=model.Remark;
		this.lblWorkerID.Text=model.WorkerID.ToString();
		this.lblDayUseNum.Text=model.DayUseNum.ToString();
		this.lblMf1Sn.Text=model.Mf1Sn;
		this.lblAlarmDis.Text=model.AlarmDis.ToString();
		this.lblAlarmShut.Text=model.AlarmShut.ToString();
		this.lblMeterNo.Text=model.MeterNo.ToString();
		this.lblRelayed.Text=model.Relayed.ToString();
		this.lblRouteLen.Text=model.RouteLen.ToString();
		this.lblRouteInfo.Text=model.RouteInfo;
		this.lblFloor.Text=model.Floor.ToString();
		this.lblGroupID.Text=model.GroupID.ToString();
		this.lblLastCur.Text=model.LastCur.ToString();
		this.lblInvoiceType.Text=model.InvoiceType.ToString();
		this.lblPercent0.Text=model.Percent0.ToString();
		this.lblPriceTypeName1.Text=model.PriceTypeName1;
		this.lblPriceTypeID1.Text=model.PriceTypeID1.ToString();
		this.lblPercent1.Text=model.Percent1.ToString();
		this.lblPriceTypeID2.Text=model.PriceTypeID2.ToString();
		this.lblPriceTypeName2.Text=model.PriceTypeName2;
		this.lblPercent2.Text=model.Percent2.ToString();
		this.lblPriceTypeID3.Text=model.PriceTypeID3.ToString();
		this.lblPriceTypeName3.Text=model.PriceTypeName3;
		this.lblPercent3.Text=model.Percent3.ToString();
		this.lblPriceTypeID4.Text=model.PriceTypeID4.ToString();
		this.lblPriceTypeName4.Text=model.PriceTypeName4;
		this.lblPercent4.Text=model.Percent4.ToString();
		this.lblMeterMC.Text=model.MeterMC.ToString();
		this.lbluAccount.Text=model.uAccount;
		this.lblIsSend.Text=model.IsSend.ToString();
		this.lblHostAddr.Text=model.HostAddr;
		this.lblLastReadDate.Text=model.LastReadDate;
		this.lblOverUse.Text=model.OverUse.ToString();
		this.lblDownloadFlag.Text=model.DownloadFlag.ToString();
		this.lblTotalGroup.Text=model.TotalGroup.ToString();
		this.lblCurrentGroup.Text=model.CurrentGroup.ToString();
		this.lblLastRecordNo.Text=model.LastRecordNo.ToString();
		this.lblBalanced.Text=model.Balanced.ToString();
		this.lblMaxFill.Text=model.MaxFill.ToString();
		this.lblMinRem.Text=model.MinRem.ToString();
		this.lblOverMoney.Text=model.OverMoney.ToString();
		this.lblFreezeMode.Text=model.FreezeMode.ToString();
		this.lblFreezeDay.Text=model.FreezeDay.ToString();
		this.lblPlasticInfo.Text=model.PlasticInfo;
		this.lblUseMeterDosage.Text=model.UseMeterDosage.ToString();
		this.lblShutValveStaffId.Text=model.ShutValveStaffId.ToString();
		this.lblInstallStaffId.Text=model.InstallStaffId.ToString();
		this.lblCheckDate.Text=model.CheckDate.ToString();
		this.lblTagID.Text=model.TagID;
		this.lblBookID.Text=model.BookID.ToString();
		this.lblLocationX.Text=model.LocationX.ToString();
		this.lblLocationY.Text=model.LocationY.ToString();
		this.lblBookNum.Text=model.BookNum.ToString();
		this.lblUpdateTime.Text=model.UpdateTime.ToString();
		this.lblImagePath.Text=model.ImagePath;
		this.lblBindTime.Text=model.BindTime.ToString();
		this.lblCardFlag.Text=model.CardFlag.ToString();
		this.lblPriceSetNo.Text=model.PriceSetNo.ToString();
		this.lblCollectorReadDate.Text=model.CollectorReadDate.ToString();
		this.lblBuyGasNum.Text=model.BuyGasNum.ToString();
		this.lblMeterPackageCode.Text=model.MeterPackageCode;
		this.lblHighWarnMoney.Text=model.HighWarnMoney.ToString();
		this.lblMiddleWarnMoney.Text=model.MiddleWarnMoney.ToString();
		this.lblLowWarnMoney.Text=model.LowWarnMoney.ToString();
		this.lblLowerReserve.Text=model.LowerReserve.ToString();
		this.lblIsInstall.Text=model.IsInstall.ToString();
		this.lblIsOpen.Text=model.IsOpen.ToString();
		this.lblCreateTime.Text=model.CreateTime.ToString();
		this.lblOpenTime.Text=model.OpenTime.ToString();
		this.lblSyncFlag.Text=model.SyncFlag.ToString();
		this.lblCameraCount.Text=model.CameraCount.ToString();
		this.lblMeterPhone.Text=model.MeterPhone;
		this.lblDevEUI.Text=model.DevEUI;
		this.lblIMEI.Text=model.IMEI;
		this.lblUploadOffsetTime.Text=model.UploadOffsetTime;
		this.lblIsUseAlertClose.Text=model.IsUseAlertClose?"是":"否";
		this.lblDiscountsNum.Text=model.DiscountsNum.ToString();
		this.lblMeterKey.Text=model.MeterKey;
		this.lblIsBlack.Text=model.IsBlack.ToString();

	}


    }
}
