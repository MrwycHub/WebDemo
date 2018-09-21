using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Meters
	/// </summary>
	public partial class Meters
	{
		public Meters()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeterID", "Meters"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeterID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Meters");
			strSql.Append(" where MeterID=@MeterID");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4)
			};
			parameters[0].Value = MeterID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.Meters model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Meters(");
			strSql.Append("MeterTypeID,MeterAddr,CollectorID,HostID,UsersID,CardType,CardID,CardSector,TotalMoney,TotalInt,TotalBase,LastMoney,LastInt,LastBase,Mark,MeterBase,MeterVerify,PriceTypeID,MeterDate,MeterNumber,InstallDate,InstallAddr,Constant,Mutual,Coefficient,LastCalNumber,LastCalMonth,LastReadNumber,PayType,Modalid,XPower,Remark,WorkerID,DayUseNum,Mf1Sn,AlarmDis,AlarmShut,MeterNo,Relayed,RouteLen,RouteInfo,Floor,GroupID,LastCur,InvoiceType,Percent0,PriceTypeName1,PriceTypeID1,Percent1,PriceTypeID2,PriceTypeName2,Percent2,PriceTypeID3,PriceTypeName3,Percent3,PriceTypeID4,PriceTypeName4,Percent4,MeterMC,uAccount,IsSend,HostAddr,LastReadDate,OverUse,DownloadFlag,TotalGroup,CurrentGroup,LastRecordNo,Balanced,MaxFill,MinRem,OverMoney,FreezeMode,FreezeDay,PlasticInfo,UseMeterDosage,ShutValveStaffId,InstallStaffId,CheckDate,TagID,BookID,LocationX,LocationY,BookNum,UpdateTime,ImagePath,BindTime,CardFlag,PriceSetNo,CollectorReadDate,BuyGasNum,MeterPackageCode,HighWarnMoney,MiddleWarnMoney,LowWarnMoney,LowerReserve,IsInstall,IsOpen,CreateTime,OpenTime,SyncFlag,CameraCount,MeterPhone,DevEUI,IMEI,UploadOffsetTime,IsUseAlertClose,DiscountsNum,MeterKey,IsBlack)");
			strSql.Append(" values (");
			strSql.Append("@MeterTypeID,@MeterAddr,@CollectorID,@HostID,@UsersID,@CardType,@CardID,@CardSector,@TotalMoney,@TotalInt,@TotalBase,@LastMoney,@LastInt,@LastBase,@Mark,@MeterBase,@MeterVerify,@PriceTypeID,@MeterDate,@MeterNumber,@InstallDate,@InstallAddr,@Constant,@Mutual,@Coefficient,@LastCalNumber,@LastCalMonth,@LastReadNumber,@PayType,@Modalid,@XPower,@Remark,@WorkerID,@DayUseNum,@Mf1Sn,@AlarmDis,@AlarmShut,@MeterNo,@Relayed,@RouteLen,@RouteInfo,@Floor,@GroupID,@LastCur,@InvoiceType,@Percent0,@PriceTypeName1,@PriceTypeID1,@Percent1,@PriceTypeID2,@PriceTypeName2,@Percent2,@PriceTypeID3,@PriceTypeName3,@Percent3,@PriceTypeID4,@PriceTypeName4,@Percent4,@MeterMC,@uAccount,@IsSend,@HostAddr,@LastReadDate,@OverUse,@DownloadFlag,@TotalGroup,@CurrentGroup,@LastRecordNo,@Balanced,@MaxFill,@MinRem,@OverMoney,@FreezeMode,@FreezeDay,@PlasticInfo,@UseMeterDosage,@ShutValveStaffId,@InstallStaffId,@CheckDate,@TagID,@BookID,@LocationX,@LocationY,@BookNum,@UpdateTime,@ImagePath,@BindTime,@CardFlag,@PriceSetNo,@CollectorReadDate,@BuyGasNum,@MeterPackageCode,@HighWarnMoney,@MiddleWarnMoney,@LowWarnMoney,@LowerReserve,@IsInstall,@IsOpen,@CreateTime,@OpenTime,@SyncFlag,@CameraCount,@MeterPhone,@DevEUI,@IMEI,@UploadOffsetTime,@IsUseAlertClose,@DiscountsNum,@MeterKey,@IsBlack)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterTypeID", SqlDbType.Int,4),
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,20),
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@HostID", SqlDbType.Int,4),
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@CardType", SqlDbType.Int,4),
					new SqlParameter("@CardID", SqlDbType.Int,4),
					new SqlParameter("@CardSector", SqlDbType.Int,4),
					new SqlParameter("@TotalMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TotalInt", SqlDbType.Int,4),
					new SqlParameter("@TotalBase", SqlDbType.Int,4),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LastInt", SqlDbType.Int,4),
					new SqlParameter("@LastBase", SqlDbType.Int,4),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@MeterBase", SqlDbType.Decimal,9),
					new SqlParameter("@MeterVerify", SqlDbType.Decimal,9),
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4),
					new SqlParameter("@MeterDate", SqlDbType.DateTime),
					new SqlParameter("@MeterNumber", SqlDbType.VarChar,50),
					new SqlParameter("@InstallDate", SqlDbType.DateTime),
					new SqlParameter("@InstallAddr", SqlDbType.VarChar,200),
					new SqlParameter("@Constant", SqlDbType.Int,4),
					new SqlParameter("@Mutual", SqlDbType.Decimal,9),
					new SqlParameter("@Coefficient", SqlDbType.Decimal,9),
					new SqlParameter("@LastCalNumber", SqlDbType.Decimal,9),
					new SqlParameter("@LastCalMonth", SqlDbType.VarChar,20),
					new SqlParameter("@LastReadNumber", SqlDbType.Decimal,9),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@Modalid", SqlDbType.Int,4),
					new SqlParameter("@XPower", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@WorkerID", SqlDbType.Int,4),
					new SqlParameter("@DayUseNum", SqlDbType.Int,4),
					new SqlParameter("@Mf1Sn", SqlDbType.VarChar,20),
					new SqlParameter("@AlarmDis", SqlDbType.Int,4),
					new SqlParameter("@AlarmShut", SqlDbType.Int,4),
					new SqlParameter("@MeterNo", SqlDbType.Int,4),
					new SqlParameter("@Relayed", SqlDbType.Int,4),
					new SqlParameter("@RouteLen", SqlDbType.Int,4),
					new SqlParameter("@RouteInfo", SqlDbType.VarChar,100),
					new SqlParameter("@Floor", SqlDbType.Int,4),
					new SqlParameter("@GroupID", SqlDbType.Int,4),
					new SqlParameter("@LastCur", SqlDbType.Int,4),
					new SqlParameter("@InvoiceType", SqlDbType.Int,4),
					new SqlParameter("@Percent0", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName1", SqlDbType.VarChar,50),
					new SqlParameter("@PriceTypeID1", SqlDbType.Int,4),
					new SqlParameter("@Percent1", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID2", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName2", SqlDbType.VarChar,50),
					new SqlParameter("@Percent2", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID3", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName3", SqlDbType.VarChar,50),
					new SqlParameter("@Percent3", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID4", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName4", SqlDbType.VarChar,50),
					new SqlParameter("@Percent4", SqlDbType.Int,4),
					new SqlParameter("@MeterMC", SqlDbType.Int,4),
					new SqlParameter("@uAccount", SqlDbType.VarChar,50),
					new SqlParameter("@IsSend", SqlDbType.Int,4),
					new SqlParameter("@HostAddr", SqlDbType.VarChar,20),
					new SqlParameter("@LastReadDate", SqlDbType.VarChar,10),
					new SqlParameter("@OverUse", SqlDbType.Int,4),
					new SqlParameter("@DownloadFlag", SqlDbType.Int,4),
					new SqlParameter("@TotalGroup", SqlDbType.Int,4),
					new SqlParameter("@CurrentGroup", SqlDbType.Int,4),
					new SqlParameter("@LastRecordNo", SqlDbType.Int,4),
					new SqlParameter("@Balanced", SqlDbType.Int,4),
					new SqlParameter("@MaxFill", SqlDbType.Int,4),
					new SqlParameter("@MinRem", SqlDbType.Int,4),
					new SqlParameter("@OverMoney", SqlDbType.Int,4),
					new SqlParameter("@FreezeMode", SqlDbType.Int,4),
					new SqlParameter("@FreezeDay", SqlDbType.Int,4),
					new SqlParameter("@PlasticInfo", SqlDbType.VarChar,50),
					new SqlParameter("@UseMeterDosage", SqlDbType.Int,4),
					new SqlParameter("@ShutValveStaffId", SqlDbType.Int,4),
					new SqlParameter("@InstallStaffId", SqlDbType.Int,4),
					new SqlParameter("@CheckDate", SqlDbType.DateTime),
					new SqlParameter("@TagID", SqlDbType.VarChar,50),
					new SqlParameter("@BookID", SqlDbType.Int,4),
					new SqlParameter("@LocationX", SqlDbType.Decimal,9),
					new SqlParameter("@LocationY", SqlDbType.Decimal,9),
					new SqlParameter("@BookNum", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@ImagePath", SqlDbType.VarChar,500),
					new SqlParameter("@BindTime", SqlDbType.DateTime),
					new SqlParameter("@CardFlag", SqlDbType.Int,4),
					new SqlParameter("@PriceSetNo", SqlDbType.Int,4),
					new SqlParameter("@CollectorReadDate", SqlDbType.DateTime),
					new SqlParameter("@BuyGasNum", SqlDbType.Int,4),
					new SqlParameter("@MeterPackageCode", SqlDbType.VarChar,50),
					new SqlParameter("@HighWarnMoney", SqlDbType.Decimal,9),
					new SqlParameter("@MiddleWarnMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LowWarnMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LowerReserve", SqlDbType.Decimal,9),
					new SqlParameter("@IsInstall", SqlDbType.Int,4),
					new SqlParameter("@IsOpen", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@OpenTime", SqlDbType.DateTime),
					new SqlParameter("@SyncFlag", SqlDbType.Int,4),
					new SqlParameter("@CameraCount", SqlDbType.Int,4),
					new SqlParameter("@MeterPhone", SqlDbType.VarChar,11),
					new SqlParameter("@DevEUI", SqlDbType.VarChar,200),
					new SqlParameter("@IMEI", SqlDbType.VarChar,200),
					new SqlParameter("@UploadOffsetTime", SqlDbType.VarChar,200),
					new SqlParameter("@IsUseAlertClose", SqlDbType.Bit,1),
					new SqlParameter("@DiscountsNum", SqlDbType.Int,4),
					new SqlParameter("@MeterKey", SqlDbType.VarChar,10),
					new SqlParameter("@IsBlack", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterTypeID;
			parameters[1].Value = model.MeterAddr;
			parameters[2].Value = model.CollectorID;
			parameters[3].Value = model.HostID;
			parameters[4].Value = model.UsersID;
			parameters[5].Value = model.CardType;
			parameters[6].Value = model.CardID;
			parameters[7].Value = model.CardSector;
			parameters[8].Value = model.TotalMoney;
			parameters[9].Value = model.TotalInt;
			parameters[10].Value = model.TotalBase;
			parameters[11].Value = model.LastMoney;
			parameters[12].Value = model.LastInt;
			parameters[13].Value = model.LastBase;
			parameters[14].Value = model.Mark;
			parameters[15].Value = model.MeterBase;
			parameters[16].Value = model.MeterVerify;
			parameters[17].Value = model.PriceTypeID;
			parameters[18].Value = model.MeterDate;
			parameters[19].Value = model.MeterNumber;
			parameters[20].Value = model.InstallDate;
			parameters[21].Value = model.InstallAddr;
			parameters[22].Value = model.Constant;
			parameters[23].Value = model.Mutual;
			parameters[24].Value = model.Coefficient;
			parameters[25].Value = model.LastCalNumber;
			parameters[26].Value = model.LastCalMonth;
			parameters[27].Value = model.LastReadNumber;
			parameters[28].Value = model.PayType;
			parameters[29].Value = model.Modalid;
			parameters[30].Value = model.XPower;
			parameters[31].Value = model.Remark;
			parameters[32].Value = model.WorkerID;
			parameters[33].Value = model.DayUseNum;
			parameters[34].Value = model.Mf1Sn;
			parameters[35].Value = model.AlarmDis;
			parameters[36].Value = model.AlarmShut;
			parameters[37].Value = model.MeterNo;
			parameters[38].Value = model.Relayed;
			parameters[39].Value = model.RouteLen;
			parameters[40].Value = model.RouteInfo;
			parameters[41].Value = model.Floor;
			parameters[42].Value = model.GroupID;
			parameters[43].Value = model.LastCur;
			parameters[44].Value = model.InvoiceType;
			parameters[45].Value = model.Percent0;
			parameters[46].Value = model.PriceTypeName1;
			parameters[47].Value = model.PriceTypeID1;
			parameters[48].Value = model.Percent1;
			parameters[49].Value = model.PriceTypeID2;
			parameters[50].Value = model.PriceTypeName2;
			parameters[51].Value = model.Percent2;
			parameters[52].Value = model.PriceTypeID3;
			parameters[53].Value = model.PriceTypeName3;
			parameters[54].Value = model.Percent3;
			parameters[55].Value = model.PriceTypeID4;
			parameters[56].Value = model.PriceTypeName4;
			parameters[57].Value = model.Percent4;
			parameters[58].Value = model.MeterMC;
			parameters[59].Value = model.uAccount;
			parameters[60].Value = model.IsSend;
			parameters[61].Value = model.HostAddr;
			parameters[62].Value = model.LastReadDate;
			parameters[63].Value = model.OverUse;
			parameters[64].Value = model.DownloadFlag;
			parameters[65].Value = model.TotalGroup;
			parameters[66].Value = model.CurrentGroup;
			parameters[67].Value = model.LastRecordNo;
			parameters[68].Value = model.Balanced;
			parameters[69].Value = model.MaxFill;
			parameters[70].Value = model.MinRem;
			parameters[71].Value = model.OverMoney;
			parameters[72].Value = model.FreezeMode;
			parameters[73].Value = model.FreezeDay;
			parameters[74].Value = model.PlasticInfo;
			parameters[75].Value = model.UseMeterDosage;
			parameters[76].Value = model.ShutValveStaffId;
			parameters[77].Value = model.InstallStaffId;
			parameters[78].Value = model.CheckDate;
			parameters[79].Value = model.TagID;
			parameters[80].Value = model.BookID;
			parameters[81].Value = model.LocationX;
			parameters[82].Value = model.LocationY;
			parameters[83].Value = model.BookNum;
			parameters[84].Value = model.UpdateTime;
			parameters[85].Value = model.ImagePath;
			parameters[86].Value = model.BindTime;
			parameters[87].Value = model.CardFlag;
			parameters[88].Value = model.PriceSetNo;
			parameters[89].Value = model.CollectorReadDate;
			parameters[90].Value = model.BuyGasNum;
			parameters[91].Value = model.MeterPackageCode;
			parameters[92].Value = model.HighWarnMoney;
			parameters[93].Value = model.MiddleWarnMoney;
			parameters[94].Value = model.LowWarnMoney;
			parameters[95].Value = model.LowerReserve;
			parameters[96].Value = model.IsInstall;
			parameters[97].Value = model.IsOpen;
			parameters[98].Value = model.CreateTime;
			parameters[99].Value = model.OpenTime;
			parameters[100].Value = model.SyncFlag;
			parameters[101].Value = model.CameraCount;
			parameters[102].Value = model.MeterPhone;
			parameters[103].Value = model.DevEUI;
			parameters[104].Value = model.IMEI;
			parameters[105].Value = model.UploadOffsetTime;
			parameters[106].Value = model.IsUseAlertClose;
			parameters[107].Value = model.DiscountsNum;
			parameters[108].Value = model.MeterKey;
			parameters[109].Value = model.IsBlack;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebDemo.Model.WebDemo.Meters model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Meters set ");
			strSql.Append("MeterTypeID=@MeterTypeID,");
			strSql.Append("MeterAddr=@MeterAddr,");
			strSql.Append("CollectorID=@CollectorID,");
			strSql.Append("HostID=@HostID,");
			strSql.Append("UsersID=@UsersID,");
			strSql.Append("CardType=@CardType,");
			strSql.Append("CardID=@CardID,");
			strSql.Append("CardSector=@CardSector,");
			strSql.Append("TotalMoney=@TotalMoney,");
			strSql.Append("TotalInt=@TotalInt,");
			strSql.Append("TotalBase=@TotalBase,");
			strSql.Append("LastMoney=@LastMoney,");
			strSql.Append("LastInt=@LastInt,");
			strSql.Append("LastBase=@LastBase,");
			strSql.Append("Mark=@Mark,");
			strSql.Append("MeterBase=@MeterBase,");
			strSql.Append("MeterVerify=@MeterVerify,");
			strSql.Append("PriceTypeID=@PriceTypeID,");
			strSql.Append("MeterDate=@MeterDate,");
			strSql.Append("MeterNumber=@MeterNumber,");
			strSql.Append("InstallDate=@InstallDate,");
			strSql.Append("InstallAddr=@InstallAddr,");
			strSql.Append("Constant=@Constant,");
			strSql.Append("Mutual=@Mutual,");
			strSql.Append("Coefficient=@Coefficient,");
			strSql.Append("LastCalNumber=@LastCalNumber,");
			strSql.Append("LastCalMonth=@LastCalMonth,");
			strSql.Append("LastReadNumber=@LastReadNumber,");
			strSql.Append("PayType=@PayType,");
			strSql.Append("Modalid=@Modalid,");
			strSql.Append("XPower=@XPower,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("WorkerID=@WorkerID,");
			strSql.Append("DayUseNum=@DayUseNum,");
			strSql.Append("Mf1Sn=@Mf1Sn,");
			strSql.Append("AlarmDis=@AlarmDis,");
			strSql.Append("AlarmShut=@AlarmShut,");
			strSql.Append("MeterNo=@MeterNo,");
			strSql.Append("Relayed=@Relayed,");
			strSql.Append("RouteLen=@RouteLen,");
			strSql.Append("RouteInfo=@RouteInfo,");
			strSql.Append("Floor=@Floor,");
			strSql.Append("GroupID=@GroupID,");
			strSql.Append("LastCur=@LastCur,");
			strSql.Append("InvoiceType=@InvoiceType,");
			strSql.Append("Percent0=@Percent0,");
			strSql.Append("PriceTypeName1=@PriceTypeName1,");
			strSql.Append("PriceTypeID1=@PriceTypeID1,");
			strSql.Append("Percent1=@Percent1,");
			strSql.Append("PriceTypeID2=@PriceTypeID2,");
			strSql.Append("PriceTypeName2=@PriceTypeName2,");
			strSql.Append("Percent2=@Percent2,");
			strSql.Append("PriceTypeID3=@PriceTypeID3,");
			strSql.Append("PriceTypeName3=@PriceTypeName3,");
			strSql.Append("Percent3=@Percent3,");
			strSql.Append("PriceTypeID4=@PriceTypeID4,");
			strSql.Append("PriceTypeName4=@PriceTypeName4,");
			strSql.Append("Percent4=@Percent4,");
			strSql.Append("MeterMC=@MeterMC,");
			strSql.Append("uAccount=@uAccount,");
			strSql.Append("IsSend=@IsSend,");
			strSql.Append("HostAddr=@HostAddr,");
			strSql.Append("LastReadDate=@LastReadDate,");
			strSql.Append("OverUse=@OverUse,");
			strSql.Append("DownloadFlag=@DownloadFlag,");
			strSql.Append("TotalGroup=@TotalGroup,");
			strSql.Append("CurrentGroup=@CurrentGroup,");
			strSql.Append("LastRecordNo=@LastRecordNo,");
			strSql.Append("Balanced=@Balanced,");
			strSql.Append("MaxFill=@MaxFill,");
			strSql.Append("MinRem=@MinRem,");
			strSql.Append("OverMoney=@OverMoney,");
			strSql.Append("FreezeMode=@FreezeMode,");
			strSql.Append("FreezeDay=@FreezeDay,");
			strSql.Append("PlasticInfo=@PlasticInfo,");
			strSql.Append("UseMeterDosage=@UseMeterDosage,");
			strSql.Append("ShutValveStaffId=@ShutValveStaffId,");
			strSql.Append("InstallStaffId=@InstallStaffId,");
			strSql.Append("CheckDate=@CheckDate,");
			strSql.Append("TagID=@TagID,");
			strSql.Append("BookID=@BookID,");
			strSql.Append("LocationX=@LocationX,");
			strSql.Append("LocationY=@LocationY,");
			strSql.Append("BookNum=@BookNum,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("ImagePath=@ImagePath,");
			strSql.Append("BindTime=@BindTime,");
			strSql.Append("CardFlag=@CardFlag,");
			strSql.Append("PriceSetNo=@PriceSetNo,");
			strSql.Append("CollectorReadDate=@CollectorReadDate,");
			strSql.Append("BuyGasNum=@BuyGasNum,");
			strSql.Append("MeterPackageCode=@MeterPackageCode,");
			strSql.Append("HighWarnMoney=@HighWarnMoney,");
			strSql.Append("MiddleWarnMoney=@MiddleWarnMoney,");
			strSql.Append("LowWarnMoney=@LowWarnMoney,");
			strSql.Append("LowerReserve=@LowerReserve,");
			strSql.Append("IsInstall=@IsInstall,");
			strSql.Append("IsOpen=@IsOpen,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("OpenTime=@OpenTime,");
			strSql.Append("SyncFlag=@SyncFlag,");
			strSql.Append("CameraCount=@CameraCount,");
			strSql.Append("MeterPhone=@MeterPhone,");
			strSql.Append("DevEUI=@DevEUI,");
			strSql.Append("IMEI=@IMEI,");
			strSql.Append("UploadOffsetTime=@UploadOffsetTime,");
			strSql.Append("IsUseAlertClose=@IsUseAlertClose,");
			strSql.Append("DiscountsNum=@DiscountsNum,");
			strSql.Append("MeterKey=@MeterKey,");
			strSql.Append("IsBlack=@IsBlack");
			strSql.Append(" where MeterID=@MeterID");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterTypeID", SqlDbType.Int,4),
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,20),
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@HostID", SqlDbType.Int,4),
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@CardType", SqlDbType.Int,4),
					new SqlParameter("@CardID", SqlDbType.Int,4),
					new SqlParameter("@CardSector", SqlDbType.Int,4),
					new SqlParameter("@TotalMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TotalInt", SqlDbType.Int,4),
					new SqlParameter("@TotalBase", SqlDbType.Int,4),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LastInt", SqlDbType.Int,4),
					new SqlParameter("@LastBase", SqlDbType.Int,4),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@MeterBase", SqlDbType.Decimal,9),
					new SqlParameter("@MeterVerify", SqlDbType.Decimal,9),
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4),
					new SqlParameter("@MeterDate", SqlDbType.DateTime),
					new SqlParameter("@MeterNumber", SqlDbType.VarChar,50),
					new SqlParameter("@InstallDate", SqlDbType.DateTime),
					new SqlParameter("@InstallAddr", SqlDbType.VarChar,200),
					new SqlParameter("@Constant", SqlDbType.Int,4),
					new SqlParameter("@Mutual", SqlDbType.Decimal,9),
					new SqlParameter("@Coefficient", SqlDbType.Decimal,9),
					new SqlParameter("@LastCalNumber", SqlDbType.Decimal,9),
					new SqlParameter("@LastCalMonth", SqlDbType.VarChar,20),
					new SqlParameter("@LastReadNumber", SqlDbType.Decimal,9),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@Modalid", SqlDbType.Int,4),
					new SqlParameter("@XPower", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@WorkerID", SqlDbType.Int,4),
					new SqlParameter("@DayUseNum", SqlDbType.Int,4),
					new SqlParameter("@Mf1Sn", SqlDbType.VarChar,20),
					new SqlParameter("@AlarmDis", SqlDbType.Int,4),
					new SqlParameter("@AlarmShut", SqlDbType.Int,4),
					new SqlParameter("@MeterNo", SqlDbType.Int,4),
					new SqlParameter("@Relayed", SqlDbType.Int,4),
					new SqlParameter("@RouteLen", SqlDbType.Int,4),
					new SqlParameter("@RouteInfo", SqlDbType.VarChar,100),
					new SqlParameter("@Floor", SqlDbType.Int,4),
					new SqlParameter("@GroupID", SqlDbType.Int,4),
					new SqlParameter("@LastCur", SqlDbType.Int,4),
					new SqlParameter("@InvoiceType", SqlDbType.Int,4),
					new SqlParameter("@Percent0", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName1", SqlDbType.VarChar,50),
					new SqlParameter("@PriceTypeID1", SqlDbType.Int,4),
					new SqlParameter("@Percent1", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID2", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName2", SqlDbType.VarChar,50),
					new SqlParameter("@Percent2", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID3", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName3", SqlDbType.VarChar,50),
					new SqlParameter("@Percent3", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID4", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName4", SqlDbType.VarChar,50),
					new SqlParameter("@Percent4", SqlDbType.Int,4),
					new SqlParameter("@MeterMC", SqlDbType.Int,4),
					new SqlParameter("@uAccount", SqlDbType.VarChar,50),
					new SqlParameter("@IsSend", SqlDbType.Int,4),
					new SqlParameter("@HostAddr", SqlDbType.VarChar,20),
					new SqlParameter("@LastReadDate", SqlDbType.VarChar,10),
					new SqlParameter("@OverUse", SqlDbType.Int,4),
					new SqlParameter("@DownloadFlag", SqlDbType.Int,4),
					new SqlParameter("@TotalGroup", SqlDbType.Int,4),
					new SqlParameter("@CurrentGroup", SqlDbType.Int,4),
					new SqlParameter("@LastRecordNo", SqlDbType.Int,4),
					new SqlParameter("@Balanced", SqlDbType.Int,4),
					new SqlParameter("@MaxFill", SqlDbType.Int,4),
					new SqlParameter("@MinRem", SqlDbType.Int,4),
					new SqlParameter("@OverMoney", SqlDbType.Int,4),
					new SqlParameter("@FreezeMode", SqlDbType.Int,4),
					new SqlParameter("@FreezeDay", SqlDbType.Int,4),
					new SqlParameter("@PlasticInfo", SqlDbType.VarChar,50),
					new SqlParameter("@UseMeterDosage", SqlDbType.Int,4),
					new SqlParameter("@ShutValveStaffId", SqlDbType.Int,4),
					new SqlParameter("@InstallStaffId", SqlDbType.Int,4),
					new SqlParameter("@CheckDate", SqlDbType.DateTime),
					new SqlParameter("@TagID", SqlDbType.VarChar,50),
					new SqlParameter("@BookID", SqlDbType.Int,4),
					new SqlParameter("@LocationX", SqlDbType.Decimal,9),
					new SqlParameter("@LocationY", SqlDbType.Decimal,9),
					new SqlParameter("@BookNum", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@ImagePath", SqlDbType.VarChar,500),
					new SqlParameter("@BindTime", SqlDbType.DateTime),
					new SqlParameter("@CardFlag", SqlDbType.Int,4),
					new SqlParameter("@PriceSetNo", SqlDbType.Int,4),
					new SqlParameter("@CollectorReadDate", SqlDbType.DateTime),
					new SqlParameter("@BuyGasNum", SqlDbType.Int,4),
					new SqlParameter("@MeterPackageCode", SqlDbType.VarChar,50),
					new SqlParameter("@HighWarnMoney", SqlDbType.Decimal,9),
					new SqlParameter("@MiddleWarnMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LowWarnMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LowerReserve", SqlDbType.Decimal,9),
					new SqlParameter("@IsInstall", SqlDbType.Int,4),
					new SqlParameter("@IsOpen", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@OpenTime", SqlDbType.DateTime),
					new SqlParameter("@SyncFlag", SqlDbType.Int,4),
					new SqlParameter("@CameraCount", SqlDbType.Int,4),
					new SqlParameter("@MeterPhone", SqlDbType.VarChar,11),
					new SqlParameter("@DevEUI", SqlDbType.VarChar,200),
					new SqlParameter("@IMEI", SqlDbType.VarChar,200),
					new SqlParameter("@UploadOffsetTime", SqlDbType.VarChar,200),
					new SqlParameter("@IsUseAlertClose", SqlDbType.Bit,1),
					new SqlParameter("@DiscountsNum", SqlDbType.Int,4),
					new SqlParameter("@MeterKey", SqlDbType.VarChar,10),
					new SqlParameter("@IsBlack", SqlDbType.Int,4),
					new SqlParameter("@MeterID", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterTypeID;
			parameters[1].Value = model.MeterAddr;
			parameters[2].Value = model.CollectorID;
			parameters[3].Value = model.HostID;
			parameters[4].Value = model.UsersID;
			parameters[5].Value = model.CardType;
			parameters[6].Value = model.CardID;
			parameters[7].Value = model.CardSector;
			parameters[8].Value = model.TotalMoney;
			parameters[9].Value = model.TotalInt;
			parameters[10].Value = model.TotalBase;
			parameters[11].Value = model.LastMoney;
			parameters[12].Value = model.LastInt;
			parameters[13].Value = model.LastBase;
			parameters[14].Value = model.Mark;
			parameters[15].Value = model.MeterBase;
			parameters[16].Value = model.MeterVerify;
			parameters[17].Value = model.PriceTypeID;
			parameters[18].Value = model.MeterDate;
			parameters[19].Value = model.MeterNumber;
			parameters[20].Value = model.InstallDate;
			parameters[21].Value = model.InstallAddr;
			parameters[22].Value = model.Constant;
			parameters[23].Value = model.Mutual;
			parameters[24].Value = model.Coefficient;
			parameters[25].Value = model.LastCalNumber;
			parameters[26].Value = model.LastCalMonth;
			parameters[27].Value = model.LastReadNumber;
			parameters[28].Value = model.PayType;
			parameters[29].Value = model.Modalid;
			parameters[30].Value = model.XPower;
			parameters[31].Value = model.Remark;
			parameters[32].Value = model.WorkerID;
			parameters[33].Value = model.DayUseNum;
			parameters[34].Value = model.Mf1Sn;
			parameters[35].Value = model.AlarmDis;
			parameters[36].Value = model.AlarmShut;
			parameters[37].Value = model.MeterNo;
			parameters[38].Value = model.Relayed;
			parameters[39].Value = model.RouteLen;
			parameters[40].Value = model.RouteInfo;
			parameters[41].Value = model.Floor;
			parameters[42].Value = model.GroupID;
			parameters[43].Value = model.LastCur;
			parameters[44].Value = model.InvoiceType;
			parameters[45].Value = model.Percent0;
			parameters[46].Value = model.PriceTypeName1;
			parameters[47].Value = model.PriceTypeID1;
			parameters[48].Value = model.Percent1;
			parameters[49].Value = model.PriceTypeID2;
			parameters[50].Value = model.PriceTypeName2;
			parameters[51].Value = model.Percent2;
			parameters[52].Value = model.PriceTypeID3;
			parameters[53].Value = model.PriceTypeName3;
			parameters[54].Value = model.Percent3;
			parameters[55].Value = model.PriceTypeID4;
			parameters[56].Value = model.PriceTypeName4;
			parameters[57].Value = model.Percent4;
			parameters[58].Value = model.MeterMC;
			parameters[59].Value = model.uAccount;
			parameters[60].Value = model.IsSend;
			parameters[61].Value = model.HostAddr;
			parameters[62].Value = model.LastReadDate;
			parameters[63].Value = model.OverUse;
			parameters[64].Value = model.DownloadFlag;
			parameters[65].Value = model.TotalGroup;
			parameters[66].Value = model.CurrentGroup;
			parameters[67].Value = model.LastRecordNo;
			parameters[68].Value = model.Balanced;
			parameters[69].Value = model.MaxFill;
			parameters[70].Value = model.MinRem;
			parameters[71].Value = model.OverMoney;
			parameters[72].Value = model.FreezeMode;
			parameters[73].Value = model.FreezeDay;
			parameters[74].Value = model.PlasticInfo;
			parameters[75].Value = model.UseMeterDosage;
			parameters[76].Value = model.ShutValveStaffId;
			parameters[77].Value = model.InstallStaffId;
			parameters[78].Value = model.CheckDate;
			parameters[79].Value = model.TagID;
			parameters[80].Value = model.BookID;
			parameters[81].Value = model.LocationX;
			parameters[82].Value = model.LocationY;
			parameters[83].Value = model.BookNum;
			parameters[84].Value = model.UpdateTime;
			parameters[85].Value = model.ImagePath;
			parameters[86].Value = model.BindTime;
			parameters[87].Value = model.CardFlag;
			parameters[88].Value = model.PriceSetNo;
			parameters[89].Value = model.CollectorReadDate;
			parameters[90].Value = model.BuyGasNum;
			parameters[91].Value = model.MeterPackageCode;
			parameters[92].Value = model.HighWarnMoney;
			parameters[93].Value = model.MiddleWarnMoney;
			parameters[94].Value = model.LowWarnMoney;
			parameters[95].Value = model.LowerReserve;
			parameters[96].Value = model.IsInstall;
			parameters[97].Value = model.IsOpen;
			parameters[98].Value = model.CreateTime;
			parameters[99].Value = model.OpenTime;
			parameters[100].Value = model.SyncFlag;
			parameters[101].Value = model.CameraCount;
			parameters[102].Value = model.MeterPhone;
			parameters[103].Value = model.DevEUI;
			parameters[104].Value = model.IMEI;
			parameters[105].Value = model.UploadOffsetTime;
			parameters[106].Value = model.IsUseAlertClose;
			parameters[107].Value = model.DiscountsNum;
			parameters[108].Value = model.MeterKey;
			parameters[109].Value = model.IsBlack;
			parameters[110].Value = model.MeterID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int MeterID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Meters ");
			strSql.Append(" where MeterID=@MeterID");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4)
			};
			parameters[0].Value = MeterID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string MeterIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Meters ");
			strSql.Append(" where MeterID in ("+MeterIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WebDemo.Model.WebDemo.Meters GetModel(int MeterID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MeterID,MeterTypeID,MeterAddr,CollectorID,HostID,UsersID,CardType,CardID,CardSector,TotalMoney,TotalInt,TotalBase,LastMoney,LastInt,LastBase,Mark,MeterBase,MeterVerify,PriceTypeID,MeterDate,MeterNumber,InstallDate,InstallAddr,Constant,Mutual,Coefficient,LastCalNumber,LastCalMonth,LastReadNumber,PayType,Modalid,XPower,Remark,WorkerID,DayUseNum,Mf1Sn,AlarmDis,AlarmShut,MeterNo,Relayed,RouteLen,RouteInfo,Floor,GroupID,LastCur,InvoiceType,Percent0,PriceTypeName1,PriceTypeID1,Percent1,PriceTypeID2,PriceTypeName2,Percent2,PriceTypeID3,PriceTypeName3,Percent3,PriceTypeID4,PriceTypeName4,Percent4,MeterMC,uAccount,IsSend,HostAddr,LastReadDate,OverUse,DownloadFlag,TotalGroup,CurrentGroup,LastRecordNo,Balanced,MaxFill,MinRem,OverMoney,FreezeMode,FreezeDay,PlasticInfo,UseMeterDosage,ShutValveStaffId,InstallStaffId,CheckDate,TagID,BookID,LocationX,LocationY,BookNum,UpdateTime,ImagePath,BindTime,CardFlag,PriceSetNo,CollectorReadDate,BuyGasNum,MeterPackageCode,HighWarnMoney,MiddleWarnMoney,LowWarnMoney,LowerReserve,IsInstall,IsOpen,CreateTime,OpenTime,SyncFlag,CameraCount,MeterPhone,DevEUI,IMEI,UploadOffsetTime,IsUseAlertClose,DiscountsNum,MeterKey,IsBlack from Meters ");
			strSql.Append(" where MeterID=@MeterID");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4)
			};
			parameters[0].Value = MeterID;

			WebDemo.Model.WebDemo.Meters model=new WebDemo.Model.WebDemo.Meters();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WebDemo.Model.WebDemo.Meters DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Meters model=new WebDemo.Model.WebDemo.Meters();
			if (row != null)
			{
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["MeterTypeID"]!=null && row["MeterTypeID"].ToString()!="")
				{
					model.MeterTypeID=int.Parse(row["MeterTypeID"].ToString());
				}
				if(row["MeterAddr"]!=null)
				{
					model.MeterAddr=row["MeterAddr"].ToString();
				}
				if(row["CollectorID"]!=null && row["CollectorID"].ToString()!="")
				{
					model.CollectorID=int.Parse(row["CollectorID"].ToString());
				}
				if(row["HostID"]!=null && row["HostID"].ToString()!="")
				{
					model.HostID=int.Parse(row["HostID"].ToString());
				}
				if(row["UsersID"]!=null && row["UsersID"].ToString()!="")
				{
					model.UsersID=int.Parse(row["UsersID"].ToString());
				}
				if(row["CardType"]!=null && row["CardType"].ToString()!="")
				{
					model.CardType=int.Parse(row["CardType"].ToString());
				}
				if(row["CardID"]!=null && row["CardID"].ToString()!="")
				{
					model.CardID=int.Parse(row["CardID"].ToString());
				}
				if(row["CardSector"]!=null && row["CardSector"].ToString()!="")
				{
					model.CardSector=int.Parse(row["CardSector"].ToString());
				}
				if(row["TotalMoney"]!=null && row["TotalMoney"].ToString()!="")
				{
					model.TotalMoney=decimal.Parse(row["TotalMoney"].ToString());
				}
				if(row["TotalInt"]!=null && row["TotalInt"].ToString()!="")
				{
					model.TotalInt=int.Parse(row["TotalInt"].ToString());
				}
				if(row["TotalBase"]!=null && row["TotalBase"].ToString()!="")
				{
					model.TotalBase=int.Parse(row["TotalBase"].ToString());
				}
				if(row["LastMoney"]!=null && row["LastMoney"].ToString()!="")
				{
					model.LastMoney=decimal.Parse(row["LastMoney"].ToString());
				}
				if(row["LastInt"]!=null && row["LastInt"].ToString()!="")
				{
					model.LastInt=int.Parse(row["LastInt"].ToString());
				}
				if(row["LastBase"]!=null && row["LastBase"].ToString()!="")
				{
					model.LastBase=int.Parse(row["LastBase"].ToString());
				}
				if(row["Mark"]!=null && row["Mark"].ToString()!="")
				{
					model.Mark=int.Parse(row["Mark"].ToString());
				}
				if(row["MeterBase"]!=null && row["MeterBase"].ToString()!="")
				{
					model.MeterBase=decimal.Parse(row["MeterBase"].ToString());
				}
				if(row["MeterVerify"]!=null && row["MeterVerify"].ToString()!="")
				{
					model.MeterVerify=decimal.Parse(row["MeterVerify"].ToString());
				}
				if(row["PriceTypeID"]!=null && row["PriceTypeID"].ToString()!="")
				{
					model.PriceTypeID=int.Parse(row["PriceTypeID"].ToString());
				}
				if(row["MeterDate"]!=null && row["MeterDate"].ToString()!="")
				{
					model.MeterDate=DateTime.Parse(row["MeterDate"].ToString());
				}
				if(row["MeterNumber"]!=null)
				{
					model.MeterNumber=row["MeterNumber"].ToString();
				}
				if(row["InstallDate"]!=null && row["InstallDate"].ToString()!="")
				{
					model.InstallDate=DateTime.Parse(row["InstallDate"].ToString());
				}
				if(row["InstallAddr"]!=null)
				{
					model.InstallAddr=row["InstallAddr"].ToString();
				}
				if(row["Constant"]!=null && row["Constant"].ToString()!="")
				{
					model.Constant=int.Parse(row["Constant"].ToString());
				}
				if(row["Mutual"]!=null && row["Mutual"].ToString()!="")
				{
					model.Mutual=decimal.Parse(row["Mutual"].ToString());
				}
				if(row["Coefficient"]!=null && row["Coefficient"].ToString()!="")
				{
					model.Coefficient=decimal.Parse(row["Coefficient"].ToString());
				}
				if(row["LastCalNumber"]!=null && row["LastCalNumber"].ToString()!="")
				{
					model.LastCalNumber=decimal.Parse(row["LastCalNumber"].ToString());
				}
				if(row["LastCalMonth"]!=null)
				{
					model.LastCalMonth=row["LastCalMonth"].ToString();
				}
				if(row["LastReadNumber"]!=null && row["LastReadNumber"].ToString()!="")
				{
					model.LastReadNumber=decimal.Parse(row["LastReadNumber"].ToString());
				}
				if(row["PayType"]!=null && row["PayType"].ToString()!="")
				{
					model.PayType=int.Parse(row["PayType"].ToString());
				}
				if(row["Modalid"]!=null && row["Modalid"].ToString()!="")
				{
					model.Modalid=int.Parse(row["Modalid"].ToString());
				}
				if(row["XPower"]!=null && row["XPower"].ToString()!="")
				{
					model.XPower=int.Parse(row["XPower"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["WorkerID"]!=null && row["WorkerID"].ToString()!="")
				{
					model.WorkerID=int.Parse(row["WorkerID"].ToString());
				}
				if(row["DayUseNum"]!=null && row["DayUseNum"].ToString()!="")
				{
					model.DayUseNum=int.Parse(row["DayUseNum"].ToString());
				}
				if(row["Mf1Sn"]!=null)
				{
					model.Mf1Sn=row["Mf1Sn"].ToString();
				}
				if(row["AlarmDis"]!=null && row["AlarmDis"].ToString()!="")
				{
					model.AlarmDis=int.Parse(row["AlarmDis"].ToString());
				}
				if(row["AlarmShut"]!=null && row["AlarmShut"].ToString()!="")
				{
					model.AlarmShut=int.Parse(row["AlarmShut"].ToString());
				}
				if(row["MeterNo"]!=null && row["MeterNo"].ToString()!="")
				{
					model.MeterNo=int.Parse(row["MeterNo"].ToString());
				}
				if(row["Relayed"]!=null && row["Relayed"].ToString()!="")
				{
					model.Relayed=int.Parse(row["Relayed"].ToString());
				}
				if(row["RouteLen"]!=null && row["RouteLen"].ToString()!="")
				{
					model.RouteLen=int.Parse(row["RouteLen"].ToString());
				}
				if(row["RouteInfo"]!=null)
				{
					model.RouteInfo=row["RouteInfo"].ToString();
				}
				if(row["Floor"]!=null && row["Floor"].ToString()!="")
				{
					model.Floor=int.Parse(row["Floor"].ToString());
				}
				if(row["GroupID"]!=null && row["GroupID"].ToString()!="")
				{
					model.GroupID=int.Parse(row["GroupID"].ToString());
				}
				if(row["LastCur"]!=null && row["LastCur"].ToString()!="")
				{
					model.LastCur=int.Parse(row["LastCur"].ToString());
				}
				if(row["InvoiceType"]!=null && row["InvoiceType"].ToString()!="")
				{
					model.InvoiceType=int.Parse(row["InvoiceType"].ToString());
				}
				if(row["Percent0"]!=null && row["Percent0"].ToString()!="")
				{
					model.Percent0=int.Parse(row["Percent0"].ToString());
				}
				if(row["PriceTypeName1"]!=null)
				{
					model.PriceTypeName1=row["PriceTypeName1"].ToString();
				}
				if(row["PriceTypeID1"]!=null && row["PriceTypeID1"].ToString()!="")
				{
					model.PriceTypeID1=int.Parse(row["PriceTypeID1"].ToString());
				}
				if(row["Percent1"]!=null && row["Percent1"].ToString()!="")
				{
					model.Percent1=int.Parse(row["Percent1"].ToString());
				}
				if(row["PriceTypeID2"]!=null && row["PriceTypeID2"].ToString()!="")
				{
					model.PriceTypeID2=int.Parse(row["PriceTypeID2"].ToString());
				}
				if(row["PriceTypeName2"]!=null)
				{
					model.PriceTypeName2=row["PriceTypeName2"].ToString();
				}
				if(row["Percent2"]!=null && row["Percent2"].ToString()!="")
				{
					model.Percent2=int.Parse(row["Percent2"].ToString());
				}
				if(row["PriceTypeID3"]!=null && row["PriceTypeID3"].ToString()!="")
				{
					model.PriceTypeID3=int.Parse(row["PriceTypeID3"].ToString());
				}
				if(row["PriceTypeName3"]!=null)
				{
					model.PriceTypeName3=row["PriceTypeName3"].ToString();
				}
				if(row["Percent3"]!=null && row["Percent3"].ToString()!="")
				{
					model.Percent3=int.Parse(row["Percent3"].ToString());
				}
				if(row["PriceTypeID4"]!=null && row["PriceTypeID4"].ToString()!="")
				{
					model.PriceTypeID4=int.Parse(row["PriceTypeID4"].ToString());
				}
				if(row["PriceTypeName4"]!=null)
				{
					model.PriceTypeName4=row["PriceTypeName4"].ToString();
				}
				if(row["Percent4"]!=null && row["Percent4"].ToString()!="")
				{
					model.Percent4=int.Parse(row["Percent4"].ToString());
				}
				if(row["MeterMC"]!=null && row["MeterMC"].ToString()!="")
				{
					model.MeterMC=int.Parse(row["MeterMC"].ToString());
				}
				if(row["uAccount"]!=null)
				{
					model.uAccount=row["uAccount"].ToString();
				}
				if(row["IsSend"]!=null && row["IsSend"].ToString()!="")
				{
					model.IsSend=int.Parse(row["IsSend"].ToString());
				}
				if(row["HostAddr"]!=null)
				{
					model.HostAddr=row["HostAddr"].ToString();
				}
				if(row["LastReadDate"]!=null)
				{
					model.LastReadDate=row["LastReadDate"].ToString();
				}
				if(row["OverUse"]!=null && row["OverUse"].ToString()!="")
				{
					model.OverUse=int.Parse(row["OverUse"].ToString());
				}
				if(row["DownloadFlag"]!=null && row["DownloadFlag"].ToString()!="")
				{
					model.DownloadFlag=int.Parse(row["DownloadFlag"].ToString());
				}
				if(row["TotalGroup"]!=null && row["TotalGroup"].ToString()!="")
				{
					model.TotalGroup=int.Parse(row["TotalGroup"].ToString());
				}
				if(row["CurrentGroup"]!=null && row["CurrentGroup"].ToString()!="")
				{
					model.CurrentGroup=int.Parse(row["CurrentGroup"].ToString());
				}
				if(row["LastRecordNo"]!=null && row["LastRecordNo"].ToString()!="")
				{
					model.LastRecordNo=int.Parse(row["LastRecordNo"].ToString());
				}
				if(row["Balanced"]!=null && row["Balanced"].ToString()!="")
				{
					model.Balanced=int.Parse(row["Balanced"].ToString());
				}
				if(row["MaxFill"]!=null && row["MaxFill"].ToString()!="")
				{
					model.MaxFill=int.Parse(row["MaxFill"].ToString());
				}
				if(row["MinRem"]!=null && row["MinRem"].ToString()!="")
				{
					model.MinRem=int.Parse(row["MinRem"].ToString());
				}
				if(row["OverMoney"]!=null && row["OverMoney"].ToString()!="")
				{
					model.OverMoney=int.Parse(row["OverMoney"].ToString());
				}
				if(row["FreezeMode"]!=null && row["FreezeMode"].ToString()!="")
				{
					model.FreezeMode=int.Parse(row["FreezeMode"].ToString());
				}
				if(row["FreezeDay"]!=null && row["FreezeDay"].ToString()!="")
				{
					model.FreezeDay=int.Parse(row["FreezeDay"].ToString());
				}
				if(row["PlasticInfo"]!=null)
				{
					model.PlasticInfo=row["PlasticInfo"].ToString();
				}
				if(row["UseMeterDosage"]!=null && row["UseMeterDosage"].ToString()!="")
				{
					model.UseMeterDosage=int.Parse(row["UseMeterDosage"].ToString());
				}
				if(row["ShutValveStaffId"]!=null && row["ShutValveStaffId"].ToString()!="")
				{
					model.ShutValveStaffId=int.Parse(row["ShutValveStaffId"].ToString());
				}
				if(row["InstallStaffId"]!=null && row["InstallStaffId"].ToString()!="")
				{
					model.InstallStaffId=int.Parse(row["InstallStaffId"].ToString());
				}
				if(row["CheckDate"]!=null && row["CheckDate"].ToString()!="")
				{
					model.CheckDate=DateTime.Parse(row["CheckDate"].ToString());
				}
				if(row["TagID"]!=null)
				{
					model.TagID=row["TagID"].ToString();
				}
				if(row["BookID"]!=null && row["BookID"].ToString()!="")
				{
					model.BookID=int.Parse(row["BookID"].ToString());
				}
				if(row["LocationX"]!=null && row["LocationX"].ToString()!="")
				{
					model.LocationX=decimal.Parse(row["LocationX"].ToString());
				}
				if(row["LocationY"]!=null && row["LocationY"].ToString()!="")
				{
					model.LocationY=decimal.Parse(row["LocationY"].ToString());
				}
				if(row["BookNum"]!=null && row["BookNum"].ToString()!="")
				{
					model.BookNum=int.Parse(row["BookNum"].ToString());
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
				}
				if(row["ImagePath"]!=null)
				{
					model.ImagePath=row["ImagePath"].ToString();
				}
				if(row["BindTime"]!=null && row["BindTime"].ToString()!="")
				{
					model.BindTime=DateTime.Parse(row["BindTime"].ToString());
				}
				if(row["CardFlag"]!=null && row["CardFlag"].ToString()!="")
				{
					model.CardFlag=int.Parse(row["CardFlag"].ToString());
				}
				if(row["PriceSetNo"]!=null && row["PriceSetNo"].ToString()!="")
				{
					model.PriceSetNo=int.Parse(row["PriceSetNo"].ToString());
				}
				if(row["CollectorReadDate"]!=null && row["CollectorReadDate"].ToString()!="")
				{
					model.CollectorReadDate=DateTime.Parse(row["CollectorReadDate"].ToString());
				}
				if(row["BuyGasNum"]!=null && row["BuyGasNum"].ToString()!="")
				{
					model.BuyGasNum=int.Parse(row["BuyGasNum"].ToString());
				}
				if(row["MeterPackageCode"]!=null)
				{
					model.MeterPackageCode=row["MeterPackageCode"].ToString();
				}
				if(row["HighWarnMoney"]!=null && row["HighWarnMoney"].ToString()!="")
				{
					model.HighWarnMoney=decimal.Parse(row["HighWarnMoney"].ToString());
				}
				if(row["MiddleWarnMoney"]!=null && row["MiddleWarnMoney"].ToString()!="")
				{
					model.MiddleWarnMoney=decimal.Parse(row["MiddleWarnMoney"].ToString());
				}
				if(row["LowWarnMoney"]!=null && row["LowWarnMoney"].ToString()!="")
				{
					model.LowWarnMoney=decimal.Parse(row["LowWarnMoney"].ToString());
				}
				if(row["LowerReserve"]!=null && row["LowerReserve"].ToString()!="")
				{
					model.LowerReserve=decimal.Parse(row["LowerReserve"].ToString());
				}
				if(row["IsInstall"]!=null && row["IsInstall"].ToString()!="")
				{
					model.IsInstall=int.Parse(row["IsInstall"].ToString());
				}
				if(row["IsOpen"]!=null && row["IsOpen"].ToString()!="")
				{
					model.IsOpen=int.Parse(row["IsOpen"].ToString());
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				}
				if(row["OpenTime"]!=null && row["OpenTime"].ToString()!="")
				{
					model.OpenTime=DateTime.Parse(row["OpenTime"].ToString());
				}
				if(row["SyncFlag"]!=null && row["SyncFlag"].ToString()!="")
				{
					model.SyncFlag=int.Parse(row["SyncFlag"].ToString());
				}
				if(row["CameraCount"]!=null && row["CameraCount"].ToString()!="")
				{
					model.CameraCount=int.Parse(row["CameraCount"].ToString());
				}
				if(row["MeterPhone"]!=null)
				{
					model.MeterPhone=row["MeterPhone"].ToString();
				}
				if(row["DevEUI"]!=null)
				{
					model.DevEUI=row["DevEUI"].ToString();
				}
				if(row["IMEI"]!=null)
				{
					model.IMEI=row["IMEI"].ToString();
				}
				if(row["UploadOffsetTime"]!=null)
				{
					model.UploadOffsetTime=row["UploadOffsetTime"].ToString();
				}
				if(row["IsUseAlertClose"]!=null && row["IsUseAlertClose"].ToString()!="")
				{
					if((row["IsUseAlertClose"].ToString()=="1")||(row["IsUseAlertClose"].ToString().ToLower()=="true"))
					{
						model.IsUseAlertClose=true;
					}
					else
					{
						model.IsUseAlertClose=false;
					}
				}
				if(row["DiscountsNum"]!=null && row["DiscountsNum"].ToString()!="")
				{
					model.DiscountsNum=int.Parse(row["DiscountsNum"].ToString());
				}
				if(row["MeterKey"]!=null)
				{
					model.MeterKey=row["MeterKey"].ToString();
				}
				if(row["IsBlack"]!=null && row["IsBlack"].ToString()!="")
				{
					model.IsBlack=int.Parse(row["IsBlack"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select MeterID,MeterTypeID,MeterAddr,CollectorID,HostID,UsersID,CardType,CardID,CardSector,TotalMoney,TotalInt,TotalBase,LastMoney,LastInt,LastBase,Mark,MeterBase,MeterVerify,PriceTypeID,MeterDate,MeterNumber,InstallDate,InstallAddr,Constant,Mutual,Coefficient,LastCalNumber,LastCalMonth,LastReadNumber,PayType,Modalid,XPower,Remark,WorkerID,DayUseNum,Mf1Sn,AlarmDis,AlarmShut,MeterNo,Relayed,RouteLen,RouteInfo,Floor,GroupID,LastCur,InvoiceType,Percent0,PriceTypeName1,PriceTypeID1,Percent1,PriceTypeID2,PriceTypeName2,Percent2,PriceTypeID3,PriceTypeName3,Percent3,PriceTypeID4,PriceTypeName4,Percent4,MeterMC,uAccount,IsSend,HostAddr,LastReadDate,OverUse,DownloadFlag,TotalGroup,CurrentGroup,LastRecordNo,Balanced,MaxFill,MinRem,OverMoney,FreezeMode,FreezeDay,PlasticInfo,UseMeterDosage,ShutValveStaffId,InstallStaffId,CheckDate,TagID,BookID,LocationX,LocationY,BookNum,UpdateTime,ImagePath,BindTime,CardFlag,PriceSetNo,CollectorReadDate,BuyGasNum,MeterPackageCode,HighWarnMoney,MiddleWarnMoney,LowWarnMoney,LowerReserve,IsInstall,IsOpen,CreateTime,OpenTime,SyncFlag,CameraCount,MeterPhone,DevEUI,IMEI,UploadOffsetTime,IsUseAlertClose,DiscountsNum,MeterKey,IsBlack ");
			strSql.Append(" FROM Meters ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" MeterID,MeterTypeID,MeterAddr,CollectorID,HostID,UsersID,CardType,CardID,CardSector,TotalMoney,TotalInt,TotalBase,LastMoney,LastInt,LastBase,Mark,MeterBase,MeterVerify,PriceTypeID,MeterDate,MeterNumber,InstallDate,InstallAddr,Constant,Mutual,Coefficient,LastCalNumber,LastCalMonth,LastReadNumber,PayType,Modalid,XPower,Remark,WorkerID,DayUseNum,Mf1Sn,AlarmDis,AlarmShut,MeterNo,Relayed,RouteLen,RouteInfo,Floor,GroupID,LastCur,InvoiceType,Percent0,PriceTypeName1,PriceTypeID1,Percent1,PriceTypeID2,PriceTypeName2,Percent2,PriceTypeID3,PriceTypeName3,Percent3,PriceTypeID4,PriceTypeName4,Percent4,MeterMC,uAccount,IsSend,HostAddr,LastReadDate,OverUse,DownloadFlag,TotalGroup,CurrentGroup,LastRecordNo,Balanced,MaxFill,MinRem,OverMoney,FreezeMode,FreezeDay,PlasticInfo,UseMeterDosage,ShutValveStaffId,InstallStaffId,CheckDate,TagID,BookID,LocationX,LocationY,BookNum,UpdateTime,ImagePath,BindTime,CardFlag,PriceSetNo,CollectorReadDate,BuyGasNum,MeterPackageCode,HighWarnMoney,MiddleWarnMoney,LowWarnMoney,LowerReserve,IsInstall,IsOpen,CreateTime,OpenTime,SyncFlag,CameraCount,MeterPhone,DevEUI,IMEI,UploadOffsetTime,IsUseAlertClose,DiscountsNum,MeterKey,IsBlack ");
			strSql.Append(" FROM Meters ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Meters ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.MeterID desc");
			}
			strSql.Append(")AS Row, T.*  from Meters T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Meters";
			parameters[1].Value = "MeterID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

