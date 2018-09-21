using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Meters:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Meters
	{
		public Meters()
		{}
		#region Model
		private int _meterid;
		private int _metertypeid=0;
		private string _meteraddr;
		private int? _collectorid;
		private int _hostid=0;
		private int? _usersid=0;
		private int? _cardtype;
		private int? _cardid=0;
		private int? _cardsector=1;
		private decimal? _totalmoney=0M;
		private int? _totalint=0;
		private int? _totalbase=0;
		private decimal? _lastmoney=0M;
		private int? _lastint=0;
		private int? _lastbase=0;
		private int? _mark=1;
		private decimal? _meterbase=0M;
		private decimal? _meterverify=0M;
		private int? _pricetypeid;
		private DateTime? _meterdate;
		private string _meternumber;
		private DateTime? _installdate;
		private string _installaddr;
		private int? _constant=0;
		private decimal? _mutual=1M;
		private decimal? _coefficient=1M;
		private decimal? _lastcalnumber;
		private string _lastcalmonth;
		private decimal? _lastreadnumber;
		private int _paytype=1;
		private int? _modalid;
		private int? _xpower=0;
		private string _remark;
		private int? _workerid;
		private int? _dayusenum;
		private string _mf1sn="";
		private int? _alarmdis=0;
		private int? _alarmshut=0;
		private int? _meterno;
		private int? _relayed;
		private int? _routelen;
		private string _routeinfo;
		private int? _floor;
		private int? _groupid;
		private int? _lastcur=0;
		private int? _invoicetype=0;
		private int? _percent0=100;
		private string _pricetypename1;
		private int? _pricetypeid1;
		private int? _percent1=0;
		private int? _pricetypeid2;
		private string _pricetypename2;
		private int? _percent2=0;
		private int? _pricetypeid3;
		private string _pricetypename3;
		private int? _percent3=0;
		private int? _pricetypeid4;
		private string _pricetypename4;
		private int? _percent4=0;
		private int? _metermc=0;
		private string _uaccount;
		private int? _issend=0;
		private string _hostaddr;
		private string _lastreaddate;
		private int? _overuse;
		private int? _downloadflag=0;
		private int? _totalgroup=0;
		private int? _currentgroup=0;
		private int? _lastrecordno=0;
		private int? _balanced=0;
		private int? _maxfill;
		private int? _minrem;
		private int? _overmoney;
		private int? _freezemode=1;
		private int? _freezeday=28;
		private string _plasticinfo;
		private int? _usemeterdosage=0;
		private int? _shutvalvestaffid;
		private int? _installstaffid;
		private DateTime? _checkdate;
		private string _tagid;
		private int _bookid=0;
		private decimal? _locationx;
		private decimal? _locationy;
		private int? _booknum;
		private DateTime _updatetime= DateTime.Now;
		private string _imagepath;
		private DateTime? _bindtime;
		private int? _cardflag;
		private int? _pricesetno=0;
		private DateTime? _collectorreaddate;
		private int? _buygasnum;
		private string _meterpackagecode;
		private decimal _highwarnmoney=20M;
		private decimal _middlewarnmoney=10M;
		private decimal _lowwarnmoney=5M;
		private decimal? _lowerreserve=20M;
		private int _isinstall=0;
		private int _isopen=0;
		private DateTime _createtime= DateTime.Now;
		private DateTime? _opentime;
		private int _syncflag=0;
		private int _cameracount=1;
		private string _meterphone;
		private string _deveui;
		private string _imei;
		private string _uploadoffsettime;
		private bool _isusealertclose= false;
		private int? _discountsnum;
		private string _meterkey;
		private int? _isblack;
		/// <summary>
		/// 表编号
		/// </summary>
		public int MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 表类型编号(同一表类型下表地址不能重复)
		/// </summary>
		public int MeterTypeID
		{
			set{ _metertypeid=value;}
			get{return _metertypeid;}
		}
		/// <summary>
		/// 表地址(12位数字，不足前面补零)
		/// </summary>
		public string MeterAddr
		{
			set{ _meteraddr=value;}
			get{return _meteraddr;}
		}
		/// <summary>
		/// 集中器编号
		/// </summary>
		public int? CollectorID
		{
			set{ _collectorid=value;}
			get{return _collectorid;}
		}
		/// <summary>
		/// 楼宇主机编号
		/// </summary>
		public int HostID
		{
			set{ _hostid=value;}
			get{return _hostid;}
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int? UsersID
		{
			set{ _usersid=value;}
			get{return _usersid;}
		}
		/// <summary>
		/// 卡类型
		/// </summary>
		public int? CardType
		{
			set{ _cardtype=value;}
			get{return _cardtype;}
		}
		/// <summary>
		/// 一卡通卡号(卡号+卡区号不能重复)
		/// </summary>
		public int? CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 卡区号(一卡通卡区号，1~5)
		/// </summary>
		public int? CardSector
		{
			set{ _cardsector=value;}
			get{return _cardsector;}
		}
		/// <summary>
		/// 总购买金额
		/// </summary>
		public decimal? TotalMoney
		{
			set{ _totalmoney=value;}
			get{return _totalmoney;}
		}
		/// <summary>
		/// 总购买量
		/// </summary>
		public int? TotalInt
		{
			set{ _totalint=value;}
			get{return _totalint;}
		}
		/// <summary>
		/// 总购买字数
		/// </summary>
		public int? TotalBase
		{
			set{ _totalbase=value;}
			get{return _totalbase;}
		}
		/// <summary>
		/// 最后一次购买金额
		/// </summary>
		public decimal? LastMoney
		{
			set{ _lastmoney=value;}
			get{return _lastmoney;}
		}
		/// <summary>
		/// 最后一次购买量
		/// </summary>
		public int? LastInt
		{
			set{ _lastint=value;}
			get{return _lastint;}
		}
		/// <summary>
		/// 最后一次购买字数
		/// </summary>
		public int? LastBase
		{
			set{ _lastbase=value;}
			get{return _lastbase;}
		}
		/// <summary>
		/// 标志(1-建档；2-使用；3-销户；默认1)
		/// </summary>
		public int? Mark
		{
			set{ _mark=value;}
			get{return _mark;}
		}
		/// <summary>
		/// 表底数
		/// </summary>
		public decimal? MeterBase
		{
			set{ _meterbase=value;}
			get{return _meterbase;}
		}
		/// <summary>
		/// 表修正值
		/// </summary>
		public decimal? MeterVerify
		{
			set{ _meterverify=value;}
			get{return _meterverify;}
		}
		/// <summary>
		/// 价格编号
		/// </summary>
		public int? PriceTypeID
		{
			set{ _pricetypeid=value;}
			get{return _pricetypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? MeterDate
		{
			set{ _meterdate=value;}
			get{return _meterdate;}
		}
		/// <summary>
		/// 出厂编号
		/// </summary>
		public string MeterNumber
		{
			set{ _meternumber=value;}
			get{return _meternumber;}
		}
		/// <summary>
		/// 安装日期
		/// </summary>
		public DateTime? InstallDate
		{
			set{ _installdate=value;}
			get{return _installdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InstallAddr
		{
			set{ _installaddr=value;}
			get{return _installaddr;}
		}
		/// <summary>
		/// 电表常数
		/// </summary>
		public int? Constant
		{
			set{ _constant=value;}
			get{return _constant;}
		}
		/// <summary>
		/// 互感变比
		/// </summary>
		public decimal? Mutual
		{
			set{ _mutual=value;}
			get{return _mutual;}
		}
		/// <summary>
		/// 倍率
		/// </summary>
		public decimal? Coefficient
		{
			set{ _coefficient=value;}
			get{return _coefficient;}
		}
		/// <summary>
		/// 最后结算读数,默认等于表底数
		/// </summary>
		public decimal? LastCalNumber
		{
			set{ _lastcalnumber=value;}
			get{return _lastcalnumber;}
		}
		/// <summary>
		/// 最后结算月份(默认等于安装月份)
		/// </summary>
		public string LastCalMonth
		{
			set{ _lastcalmonth=value;}
			get{return _lastcalmonth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LastReadNumber
		{
			set{ _lastreadnumber=value;}
			get{return _lastreadnumber;}
		}
		/// <summary>
		/// 交费类型(1-预付费  2-后付费)
		/// </summary>
		public int PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		/// <summary>
		/// 型号编号
		/// </summary>
		public int? Modalid
		{
			set{ _modalid=value;}
			get{return _modalid;}
		}
		/// <summary>
		/// 限容功率
		/// </summary>
		public int? XPower
		{
			set{ _xpower=value;}
			get{return _xpower;}
		}
		/// <summary>
		/// 备注信息
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WorkerID
		{
			set{ _workerid=value;}
			get{return _workerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DayUseNum
		{
			set{ _dayusenum=value;}
			get{return _dayusenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mf1Sn
		{
			set{ _mf1sn=value;}
			get{return _mf1sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AlarmDis
		{
			set{ _alarmdis=value;}
			get{return _alarmdis;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AlarmShut
		{
			set{ _alarmshut=value;}
			get{return _alarmshut;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MeterNo
		{
			set{ _meterno=value;}
			get{return _meterno;}
		}
		/// <summary>
		/// 是否中继
		/// </summary>
		public int? Relayed
		{
			set{ _relayed=value;}
			get{return _relayed;}
		}
		/// <summary>
		/// 中继深度
		/// </summary>
		public int? RouteLen
		{
			set{ _routelen=value;}
			get{return _routelen;}
		}
		/// <summary>
		/// 中继路径
		/// </summary>
		public string RouteInfo
		{
			set{ _routeinfo=value;}
			get{return _routeinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Floor
		{
			set{ _floor=value;}
			get{return _floor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GroupID
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LastCur
		{
			set{ _lastcur=value;}
			get{return _lastcur;}
		}
		/// <summary>
		/// 发票类型
		/// </summary>
		public int? InvoiceType
		{
			set{ _invoicetype=value;}
			get{return _invoicetype;}
		}
		/// <summary>
		/// 比例
		/// </summary>
		public int? Percent0
		{
			set{ _percent0=value;}
			get{return _percent0;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PriceTypeName1
		{
			set{ _pricetypename1=value;}
			get{return _pricetypename1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PriceTypeID1
		{
			set{ _pricetypeid1=value;}
			get{return _pricetypeid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Percent1
		{
			set{ _percent1=value;}
			get{return _percent1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PriceTypeID2
		{
			set{ _pricetypeid2=value;}
			get{return _pricetypeid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PriceTypeName2
		{
			set{ _pricetypename2=value;}
			get{return _pricetypename2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Percent2
		{
			set{ _percent2=value;}
			get{return _percent2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PriceTypeID3
		{
			set{ _pricetypeid3=value;}
			get{return _pricetypeid3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PriceTypeName3
		{
			set{ _pricetypename3=value;}
			get{return _pricetypename3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Percent3
		{
			set{ _percent3=value;}
			get{return _percent3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PriceTypeID4
		{
			set{ _pricetypeid4=value;}
			get{return _pricetypeid4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PriceTypeName4
		{
			set{ _pricetypename4=value;}
			get{return _pricetypename4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Percent4
		{
			set{ _percent4=value;}
			get{return _percent4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MeterMC
		{
			set{ _metermc=value;}
			get{return _metermc;}
		}
		/// <summary>
		/// 账号
		/// </summary>
		public string uAccount
		{
			set{ _uaccount=value;}
			get{return _uaccount;}
		}
		/// <summary>
		/// 0未发送 其他已发送
		/// </summary>
		public int? IsSend
		{
			set{ _issend=value;}
			get{return _issend;}
		}
		/// <summary>
		/// 所属采集器
		/// </summary>
		public string HostAddr
		{
			set{ _hostaddr=value;}
			get{return _hostaddr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastReadDate
		{
			set{ _lastreaddate=value;}
			get{return _lastreaddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OverUse
		{
			set{ _overuse=value;}
			get{return _overuse;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DownloadFlag
		{
			set{ _downloadflag=value;}
			get{return _downloadflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TotalGroup
		{
			set{ _totalgroup=value;}
			get{return _totalgroup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CurrentGroup
		{
			set{ _currentgroup=value;}
			get{return _currentgroup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LastRecordNo
		{
			set{ _lastrecordno=value;}
			get{return _lastrecordno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Balanced
		{
			set{ _balanced=value;}
			get{return _balanced;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MaxFill
		{
			set{ _maxfill=value;}
			get{return _maxfill;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MinRem
		{
			set{ _minrem=value;}
			get{return _minrem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OverMoney
		{
			set{ _overmoney=value;}
			get{return _overmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FreezeMode
		{
			set{ _freezemode=value;}
			get{return _freezemode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FreezeDay
		{
			set{ _freezeday=value;}
			get{return _freezeday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PlasticInfo
		{
			set{ _plasticinfo=value;}
			get{return _plasticinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UseMeterDosage
		{
			set{ _usemeterdosage=value;}
			get{return _usemeterdosage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ShutValveStaffId
		{
			set{ _shutvalvestaffid=value;}
			get{return _shutvalvestaffid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InstallStaffId
		{
			set{ _installstaffid=value;}
			get{return _installstaffid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CheckDate
		{
			set{ _checkdate=value;}
			get{return _checkdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TagID
		{
			set{ _tagid=value;}
			get{return _tagid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BookID
		{
			set{ _bookid=value;}
			get{return _bookid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LocationX
		{
			set{ _locationx=value;}
			get{return _locationx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LocationY
		{
			set{ _locationy=value;}
			get{return _locationy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BookNum
		{
			set{ _booknum=value;}
			get{return _booknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImagePath
		{
			set{ _imagepath=value;}
			get{return _imagepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BindTime
		{
			set{ _bindtime=value;}
			get{return _bindtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CardFlag
		{
			set{ _cardflag=value;}
			get{return _cardflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PriceSetNo
		{
			set{ _pricesetno=value;}
			get{return _pricesetno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CollectorReadDate
		{
			set{ _collectorreaddate=value;}
			get{return _collectorreaddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BuyGasNum
		{
			set{ _buygasnum=value;}
			get{return _buygasnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MeterPackageCode
		{
			set{ _meterpackagecode=value;}
			get{return _meterpackagecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal HighWarnMoney
		{
			set{ _highwarnmoney=value;}
			get{return _highwarnmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal MiddleWarnMoney
		{
			set{ _middlewarnmoney=value;}
			get{return _middlewarnmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal LowWarnMoney
		{
			set{ _lowwarnmoney=value;}
			get{return _lowwarnmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LowerReserve
		{
			set{ _lowerreserve=value;}
			get{return _lowerreserve;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsInstall
		{
			set{ _isinstall=value;}
			get{return _isinstall;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsOpen
		{
			set{ _isopen=value;}
			get{return _isopen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OpenTime
		{
			set{ _opentime=value;}
			get{return _opentime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SyncFlag
		{
			set{ _syncflag=value;}
			get{return _syncflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CameraCount
		{
			set{ _cameracount=value;}
			get{return _cameracount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MeterPhone
		{
			set{ _meterphone=value;}
			get{return _meterphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DevEUI
		{
			set{ _deveui=value;}
			get{return _deveui;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IMEI
		{
			set{ _imei=value;}
			get{return _imei;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UploadOffsetTime
		{
			set{ _uploadoffsettime=value;}
			get{return _uploadoffsettime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsUseAlertClose
		{
			set{ _isusealertclose=value;}
			get{return _isusealertclose;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DiscountsNum
		{
			set{ _discountsnum=value;}
			get{return _discountsnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MeterKey
		{
			set{ _meterkey=value;}
			get{return _meterkey;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsBlack
		{
			set{ _isblack=value;}
			get{return _isblack;}
		}
		#endregion Model

	}
}

