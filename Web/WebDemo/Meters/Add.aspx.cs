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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace WebDemo.Web.WebDemo.Meters
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterTypeID.Text))
			{
				strErr+="表类型编号(同一表类型下表地址格式错误！\\n";	
			}
			if(this.txtMeterAddr.Text.Trim().Length==0)
			{
				strErr+="表地址(12位数字不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCollectorID.Text))
			{
				strErr+="集中器编号格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtHostID.Text))
			{
				strErr+="楼宇主机编号格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUsersID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCardType.Text))
			{
				strErr+="卡类型格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCardID.Text))
			{
				strErr+="一卡通卡号(卡号+卡区号不能重格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCardSector.Text))
			{
				strErr+="卡区号(一卡通卡区号格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTotalMoney.Text))
			{
				strErr+="总购买金额格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTotalInt.Text))
			{
				strErr+="总购买量格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTotalBase.Text))
			{
				strErr+="总购买字数格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLastMoney.Text))
			{
				strErr+="最后一次购买金额格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtLastInt.Text))
			{
				strErr+="最后一次购买量格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtLastBase.Text))
			{
				strErr+="最后一次购买字数格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMark.Text))
			{
				strErr+="标志(1-建档；2-使用；3-格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMeterBase.Text))
			{
				strErr+="表底数格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMeterVerify.Text))
			{
				strErr+="表修正值格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceTypeID.Text))
			{
				strErr+="价格编号格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtMeterDate.Text))
			{
				strErr+="MeterDate格式错误！\\n";	
			}
			if(this.txtMeterNumber.Text.Trim().Length==0)
			{
				strErr+="出厂编号不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInstallDate.Text))
			{
				strErr+="安装日期格式错误！\\n";	
			}
			if(this.txtInstallAddr.Text.Trim().Length==0)
			{
				strErr+="InstallAddr不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtConstant.Text))
			{
				strErr+="电表常数格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMutual.Text))
			{
				strErr+="互感变比格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtCoefficient.Text))
			{
				strErr+="倍率格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLastCalNumber.Text))
			{
				strErr+="最后结算读数,默认等于表底数格式错误！\\n";	
			}
			if(this.txtLastCalMonth.Text.Trim().Length==0)
			{
				strErr+="最后结算月份(默认等于安装月份不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLastReadNumber.Text))
			{
				strErr+="LastReadNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayType.Text))
			{
				strErr+="交费类型(1-预付费  2-后格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtModalid.Text))
			{
				strErr+="型号编号格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtXPower.Text))
			{
				strErr+="限容功率格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注信息不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtWorkerID.Text))
			{
				strErr+="WorkerID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDayUseNum.Text))
			{
				strErr+="DayUseNum格式错误！\\n";	
			}
			if(this.txtMf1Sn.Text.Trim().Length==0)
			{
				strErr+="Mf1Sn不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtAlarmDis.Text))
			{
				strErr+="AlarmDis格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtAlarmShut.Text))
			{
				strErr+="AlarmShut格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterNo.Text))
			{
				strErr+="MeterNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRelayed.Text))
			{
				strErr+="是否中继格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRouteLen.Text))
			{
				strErr+="中继深度格式错误！\\n";	
			}
			if(this.txtRouteInfo.Text.Trim().Length==0)
			{
				strErr+="中继路径不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFloor.Text))
			{
				strErr+="Floor格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtGroupID.Text))
			{
				strErr+="GroupID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtLastCur.Text))
			{
				strErr+="LastCur格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInvoiceType.Text))
			{
				strErr+="发票类型格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPercent0.Text))
			{
				strErr+="比例格式错误！\\n";	
			}
			if(this.txtPriceTypeName1.Text.Trim().Length==0)
			{
				strErr+="PriceTypeName1不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceTypeID1.Text))
			{
				strErr+="PriceTypeID1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPercent1.Text))
			{
				strErr+="Percent1格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceTypeID2.Text))
			{
				strErr+="PriceTypeID2格式错误！\\n";	
			}
			if(this.txtPriceTypeName2.Text.Trim().Length==0)
			{
				strErr+="PriceTypeName2不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPercent2.Text))
			{
				strErr+="Percent2格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceTypeID3.Text))
			{
				strErr+="PriceTypeID3格式错误！\\n";	
			}
			if(this.txtPriceTypeName3.Text.Trim().Length==0)
			{
				strErr+="PriceTypeName3不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPercent3.Text))
			{
				strErr+="Percent3格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceTypeID4.Text))
			{
				strErr+="PriceTypeID4格式错误！\\n";	
			}
			if(this.txtPriceTypeName4.Text.Trim().Length==0)
			{
				strErr+="PriceTypeName4不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPercent4.Text))
			{
				strErr+="Percent4格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterMC.Text))
			{
				strErr+="MeterMC格式错误！\\n";	
			}
			if(this.txtuAccount.Text.Trim().Length==0)
			{
				strErr+="账号不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtIsSend.Text))
			{
				strErr+="0未发送 其他已发送格式错误！\\n";	
			}
			if(this.txtHostAddr.Text.Trim().Length==0)
			{
				strErr+="所属采集器不能为空！\\n";	
			}
			if(this.txtLastReadDate.Text.Trim().Length==0)
			{
				strErr+="LastReadDate不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOverUse.Text))
			{
				strErr+="OverUse格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDownloadFlag.Text))
			{
				strErr+="DownloadFlag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTotalGroup.Text))
			{
				strErr+="TotalGroup格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCurrentGroup.Text))
			{
				strErr+="CurrentGroup格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtLastRecordNo.Text))
			{
				strErr+="LastRecordNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBalanced.Text))
			{
				strErr+="Balanced格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMaxFill.Text))
			{
				strErr+="MaxFill格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMinRem.Text))
			{
				strErr+="MinRem格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOverMoney.Text))
			{
				strErr+="OverMoney格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFreezeMode.Text))
			{
				strErr+="FreezeMode格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFreezeDay.Text))
			{
				strErr+="FreezeDay格式错误！\\n";	
			}
			if(this.txtPlasticInfo.Text.Trim().Length==0)
			{
				strErr+="PlasticInfo不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtUseMeterDosage.Text))
			{
				strErr+="UseMeterDosage格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtShutValveStaffId.Text))
			{
				strErr+="ShutValveStaffId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtInstallStaffId.Text))
			{
				strErr+="InstallStaffId格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCheckDate.Text))
			{
				strErr+="CheckDate格式错误！\\n";	
			}
			if(this.txtTagID.Text.Trim().Length==0)
			{
				strErr+="TagID不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtBookID.Text))
			{
				strErr+="BookID格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLocationX.Text))
			{
				strErr+="LocationX格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLocationY.Text))
			{
				strErr+="LocationY格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBookNum.Text))
			{
				strErr+="BookNum格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="UpdateTime格式错误！\\n";	
			}
			if(this.txtImagePath.Text.Trim().Length==0)
			{
				strErr+="ImagePath不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBindTime.Text))
			{
				strErr+="BindTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCardFlag.Text))
			{
				strErr+="CardFlag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceSetNo.Text))
			{
				strErr+="PriceSetNo格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCollectorReadDate.Text))
			{
				strErr+="CollectorReadDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtBuyGasNum.Text))
			{
				strErr+="BuyGasNum格式错误！\\n";	
			}
			if(this.txtMeterPackageCode.Text.Trim().Length==0)
			{
				strErr+="MeterPackageCode不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtHighWarnMoney.Text))
			{
				strErr+="HighWarnMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtMiddleWarnMoney.Text))
			{
				strErr+="MiddleWarnMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLowWarnMoney.Text))
			{
				strErr+="LowWarnMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLowerReserve.Text))
			{
				strErr+="LowerReserve格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtIsInstall.Text))
			{
				strErr+="IsInstall格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtIsOpen.Text))
			{
				strErr+="IsOpen格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateTime.Text))
			{
				strErr+="CreateTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOpenTime.Text))
			{
				strErr+="OpenTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSyncFlag.Text))
			{
				strErr+="SyncFlag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCameraCount.Text))
			{
				strErr+="CameraCount格式错误！\\n";	
			}
			if(this.txtMeterPhone.Text.Trim().Length==0)
			{
				strErr+="MeterPhone不能为空！\\n";	
			}
			if(this.txtDevEUI.Text.Trim().Length==0)
			{
				strErr+="DevEUI不能为空！\\n";	
			}
			if(this.txtIMEI.Text.Trim().Length==0)
			{
				strErr+="IMEI不能为空！\\n";	
			}
			if(this.txtUploadOffsetTime.Text.Trim().Length==0)
			{
				strErr+="UploadOffsetTime不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDiscountsNum.Text))
			{
				strErr+="DiscountsNum格式错误！\\n";	
			}
			if(this.txtMeterKey.Text.Trim().Length==0)
			{
				strErr+="MeterKey不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtIsBlack.Text))
			{
				strErr+="IsBlack格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterTypeID=int.Parse(this.txtMeterTypeID.Text);
			string MeterAddr=this.txtMeterAddr.Text;
			int CollectorID=int.Parse(this.txtCollectorID.Text);
			int HostID=int.Parse(this.txtHostID.Text);
			int UsersID=int.Parse(this.txtUsersID.Text);
			int CardType=int.Parse(this.txtCardType.Text);
			int CardID=int.Parse(this.txtCardID.Text);
			int CardSector=int.Parse(this.txtCardSector.Text);
			decimal TotalMoney=decimal.Parse(this.txtTotalMoney.Text);
			int TotalInt=int.Parse(this.txtTotalInt.Text);
			int TotalBase=int.Parse(this.txtTotalBase.Text);
			decimal LastMoney=decimal.Parse(this.txtLastMoney.Text);
			int LastInt=int.Parse(this.txtLastInt.Text);
			int LastBase=int.Parse(this.txtLastBase.Text);
			int Mark=int.Parse(this.txtMark.Text);
			decimal MeterBase=decimal.Parse(this.txtMeterBase.Text);
			decimal MeterVerify=decimal.Parse(this.txtMeterVerify.Text);
			int PriceTypeID=int.Parse(this.txtPriceTypeID.Text);
			DateTime MeterDate=DateTime.Parse(this.txtMeterDate.Text);
			string MeterNumber=this.txtMeterNumber.Text;
			DateTime InstallDate=DateTime.Parse(this.txtInstallDate.Text);
			string InstallAddr=this.txtInstallAddr.Text;
			int Constant=int.Parse(this.txtConstant.Text);
			decimal Mutual=decimal.Parse(this.txtMutual.Text);
			decimal Coefficient=decimal.Parse(this.txtCoefficient.Text);
			decimal LastCalNumber=decimal.Parse(this.txtLastCalNumber.Text);
			string LastCalMonth=this.txtLastCalMonth.Text;
			decimal LastReadNumber=decimal.Parse(this.txtLastReadNumber.Text);
			int PayType=int.Parse(this.txtPayType.Text);
			int Modalid=int.Parse(this.txtModalid.Text);
			int XPower=int.Parse(this.txtXPower.Text);
			string Remark=this.txtRemark.Text;
			int WorkerID=int.Parse(this.txtWorkerID.Text);
			int DayUseNum=int.Parse(this.txtDayUseNum.Text);
			string Mf1Sn=this.txtMf1Sn.Text;
			int AlarmDis=int.Parse(this.txtAlarmDis.Text);
			int AlarmShut=int.Parse(this.txtAlarmShut.Text);
			int MeterNo=int.Parse(this.txtMeterNo.Text);
			int Relayed=int.Parse(this.txtRelayed.Text);
			int RouteLen=int.Parse(this.txtRouteLen.Text);
			string RouteInfo=this.txtRouteInfo.Text;
			int Floor=int.Parse(this.txtFloor.Text);
			int GroupID=int.Parse(this.txtGroupID.Text);
			int LastCur=int.Parse(this.txtLastCur.Text);
			int InvoiceType=int.Parse(this.txtInvoiceType.Text);
			int Percent0=int.Parse(this.txtPercent0.Text);
			string PriceTypeName1=this.txtPriceTypeName1.Text;
			int PriceTypeID1=int.Parse(this.txtPriceTypeID1.Text);
			int Percent1=int.Parse(this.txtPercent1.Text);
			int PriceTypeID2=int.Parse(this.txtPriceTypeID2.Text);
			string PriceTypeName2=this.txtPriceTypeName2.Text;
			int Percent2=int.Parse(this.txtPercent2.Text);
			int PriceTypeID3=int.Parse(this.txtPriceTypeID3.Text);
			string PriceTypeName3=this.txtPriceTypeName3.Text;
			int Percent3=int.Parse(this.txtPercent3.Text);
			int PriceTypeID4=int.Parse(this.txtPriceTypeID4.Text);
			string PriceTypeName4=this.txtPriceTypeName4.Text;
			int Percent4=int.Parse(this.txtPercent4.Text);
			int MeterMC=int.Parse(this.txtMeterMC.Text);
			string uAccount=this.txtuAccount.Text;
			int IsSend=int.Parse(this.txtIsSend.Text);
			string HostAddr=this.txtHostAddr.Text;
			string LastReadDate=this.txtLastReadDate.Text;
			int OverUse=int.Parse(this.txtOverUse.Text);
			int DownloadFlag=int.Parse(this.txtDownloadFlag.Text);
			int TotalGroup=int.Parse(this.txtTotalGroup.Text);
			int CurrentGroup=int.Parse(this.txtCurrentGroup.Text);
			int LastRecordNo=int.Parse(this.txtLastRecordNo.Text);
			int Balanced=int.Parse(this.txtBalanced.Text);
			int MaxFill=int.Parse(this.txtMaxFill.Text);
			int MinRem=int.Parse(this.txtMinRem.Text);
			int OverMoney=int.Parse(this.txtOverMoney.Text);
			int FreezeMode=int.Parse(this.txtFreezeMode.Text);
			int FreezeDay=int.Parse(this.txtFreezeDay.Text);
			string PlasticInfo=this.txtPlasticInfo.Text;
			int UseMeterDosage=int.Parse(this.txtUseMeterDosage.Text);
			int ShutValveStaffId=int.Parse(this.txtShutValveStaffId.Text);
			int InstallStaffId=int.Parse(this.txtInstallStaffId.Text);
			DateTime CheckDate=DateTime.Parse(this.txtCheckDate.Text);
			string TagID=this.txtTagID.Text;
			int BookID=int.Parse(this.txtBookID.Text);
			decimal LocationX=decimal.Parse(this.txtLocationX.Text);
			decimal LocationY=decimal.Parse(this.txtLocationY.Text);
			int BookNum=int.Parse(this.txtBookNum.Text);
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			string ImagePath=this.txtImagePath.Text;
			DateTime BindTime=DateTime.Parse(this.txtBindTime.Text);
			int CardFlag=int.Parse(this.txtCardFlag.Text);
			int PriceSetNo=int.Parse(this.txtPriceSetNo.Text);
			DateTime CollectorReadDate=DateTime.Parse(this.txtCollectorReadDate.Text);
			int BuyGasNum=int.Parse(this.txtBuyGasNum.Text);
			string MeterPackageCode=this.txtMeterPackageCode.Text;
			decimal HighWarnMoney=decimal.Parse(this.txtHighWarnMoney.Text);
			decimal MiddleWarnMoney=decimal.Parse(this.txtMiddleWarnMoney.Text);
			decimal LowWarnMoney=decimal.Parse(this.txtLowWarnMoney.Text);
			decimal LowerReserve=decimal.Parse(this.txtLowerReserve.Text);
			int IsInstall=int.Parse(this.txtIsInstall.Text);
			int IsOpen=int.Parse(this.txtIsOpen.Text);
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);
			DateTime OpenTime=DateTime.Parse(this.txtOpenTime.Text);
			int SyncFlag=int.Parse(this.txtSyncFlag.Text);
			int CameraCount=int.Parse(this.txtCameraCount.Text);
			string MeterPhone=this.txtMeterPhone.Text;
			string DevEUI=this.txtDevEUI.Text;
			string IMEI=this.txtIMEI.Text;
			string UploadOffsetTime=this.txtUploadOffsetTime.Text;
			bool IsUseAlertClose=this.chkIsUseAlertClose.Checked;
			int DiscountsNum=int.Parse(this.txtDiscountsNum.Text);
			string MeterKey=this.txtMeterKey.Text;
			int IsBlack=int.Parse(this.txtIsBlack.Text);

			WebDemo.Model.WebDemo.Meters model=new WebDemo.Model.WebDemo.Meters();
			model.MeterTypeID=MeterTypeID;
			model.MeterAddr=MeterAddr;
			model.CollectorID=CollectorID;
			model.HostID=HostID;
			model.UsersID=UsersID;
			model.CardType=CardType;
			model.CardID=CardID;
			model.CardSector=CardSector;
			model.TotalMoney=TotalMoney;
			model.TotalInt=TotalInt;
			model.TotalBase=TotalBase;
			model.LastMoney=LastMoney;
			model.LastInt=LastInt;
			model.LastBase=LastBase;
			model.Mark=Mark;
			model.MeterBase=MeterBase;
			model.MeterVerify=MeterVerify;
			model.PriceTypeID=PriceTypeID;
			model.MeterDate=MeterDate;
			model.MeterNumber=MeterNumber;
			model.InstallDate=InstallDate;
			model.InstallAddr=InstallAddr;
			model.Constant=Constant;
			model.Mutual=Mutual;
			model.Coefficient=Coefficient;
			model.LastCalNumber=LastCalNumber;
			model.LastCalMonth=LastCalMonth;
			model.LastReadNumber=LastReadNumber;
			model.PayType=PayType;
			model.Modalid=Modalid;
			model.XPower=XPower;
			model.Remark=Remark;
			model.WorkerID=WorkerID;
			model.DayUseNum=DayUseNum;
			model.Mf1Sn=Mf1Sn;
			model.AlarmDis=AlarmDis;
			model.AlarmShut=AlarmShut;
			model.MeterNo=MeterNo;
			model.Relayed=Relayed;
			model.RouteLen=RouteLen;
			model.RouteInfo=RouteInfo;
			model.Floor=Floor;
			model.GroupID=GroupID;
			model.LastCur=LastCur;
			model.InvoiceType=InvoiceType;
			model.Percent0=Percent0;
			model.PriceTypeName1=PriceTypeName1;
			model.PriceTypeID1=PriceTypeID1;
			model.Percent1=Percent1;
			model.PriceTypeID2=PriceTypeID2;
			model.PriceTypeName2=PriceTypeName2;
			model.Percent2=Percent2;
			model.PriceTypeID3=PriceTypeID3;
			model.PriceTypeName3=PriceTypeName3;
			model.Percent3=Percent3;
			model.PriceTypeID4=PriceTypeID4;
			model.PriceTypeName4=PriceTypeName4;
			model.Percent4=Percent4;
			model.MeterMC=MeterMC;
			model.uAccount=uAccount;
			model.IsSend=IsSend;
			model.HostAddr=HostAddr;
			model.LastReadDate=LastReadDate;
			model.OverUse=OverUse;
			model.DownloadFlag=DownloadFlag;
			model.TotalGroup=TotalGroup;
			model.CurrentGroup=CurrentGroup;
			model.LastRecordNo=LastRecordNo;
			model.Balanced=Balanced;
			model.MaxFill=MaxFill;
			model.MinRem=MinRem;
			model.OverMoney=OverMoney;
			model.FreezeMode=FreezeMode;
			model.FreezeDay=FreezeDay;
			model.PlasticInfo=PlasticInfo;
			model.UseMeterDosage=UseMeterDosage;
			model.ShutValveStaffId=ShutValveStaffId;
			model.InstallStaffId=InstallStaffId;
			model.CheckDate=CheckDate;
			model.TagID=TagID;
			model.BookID=BookID;
			model.LocationX=LocationX;
			model.LocationY=LocationY;
			model.BookNum=BookNum;
			model.UpdateTime=UpdateTime;
			model.ImagePath=ImagePath;
			model.BindTime=BindTime;
			model.CardFlag=CardFlag;
			model.PriceSetNo=PriceSetNo;
			model.CollectorReadDate=CollectorReadDate;
			model.BuyGasNum=BuyGasNum;
			model.MeterPackageCode=MeterPackageCode;
			model.HighWarnMoney=HighWarnMoney;
			model.MiddleWarnMoney=MiddleWarnMoney;
			model.LowWarnMoney=LowWarnMoney;
			model.LowerReserve=LowerReserve;
			model.IsInstall=IsInstall;
			model.IsOpen=IsOpen;
			model.CreateTime=CreateTime;
			model.OpenTime=OpenTime;
			model.SyncFlag=SyncFlag;
			model.CameraCount=CameraCount;
			model.MeterPhone=MeterPhone;
			model.DevEUI=DevEUI;
			model.IMEI=IMEI;
			model.UploadOffsetTime=UploadOffsetTime;
			model.IsUseAlertClose=IsUseAlertClose;
			model.DiscountsNum=DiscountsNum;
			model.MeterKey=MeterKey;
			model.IsBlack=IsBlack;

			WebDemo.BLL.WebDemo.Meters bll=new WebDemo.BLL.WebDemo.Meters();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
