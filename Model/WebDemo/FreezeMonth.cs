using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// FreezeMonth:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FreezeMonth
	{
		public FreezeMonth()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private string _freezemonth;
		private decimal? _freezenumber;
		private DateTime _readdate;
		private bool _calmark= false;
		private decimal? _instantnumber;
		private decimal? _pilenumber;
		private decimal? _watertemp;
		private decimal? _backwatertemp;
		private int? _workdate;
		private string _factdate;
		private int? _batterystate;
		private int? _warning;
		private int? _readtype=1;
		private decimal? _oldfreezenumber;
		private int? _megabit;
		private decimal? _additionnum;
		private string _smallimagepath;
		private string _bigimagepath;
		private decimal? _locationx;
		private decimal? _locationy;
		private string _remark;
		private DateTime? _takephotodate= DateTime.Now;
		private int _syncflag=0;
		private int? _pricesetno=0;
		private DateTime? _collectorreaddate= DateTime.Now;
		private decimal? _activesharp;
		private decimal? _activepeak;
		private decimal? _activeshoulder;
		private decimal? _activeoffpeak;
		private string _meterstatusstring;
		private int _verifyvalue=1;
		private decimal _remnant=0M;
		private int? _valvestate;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 表编号
		/// </summary>
		public int MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 冻结月
		/// </summary>
		public string FreezeMonth
		{
			set{ _freezemonth=value;}
			get{return _freezemonth;}
		}
		/// <summary>
		/// 日冻结读数
		/// </summary>
		public decimal? FreezeNumber
		{
			set{ _freezenumber=value;}
			get{return _freezenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ReadDate
		{
			set{ _readdate=value;}
			get{return _readdate;}
		}
		/// <summary>
		/// 结算标志
		/// </summary>
		public bool CalMark
		{
			set{ _calmark=value;}
			get{return _calmark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? InstantNumber
		{
			set{ _instantnumber=value;}
			get{return _instantnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PileNumber
		{
			set{ _pilenumber=value;}
			get{return _pilenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Watertemp
		{
			set{ _watertemp=value;}
			get{return _watertemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BackWatertemp
		{
			set{ _backwatertemp=value;}
			get{return _backwatertemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WorkDate
		{
			set{ _workdate=value;}
			get{return _workdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FactDate
		{
			set{ _factdate=value;}
			get{return _factdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BatteryState
		{
			set{ _batterystate=value;}
			get{return _batterystate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Warning
		{
			set{ _warning=value;}
			get{return _warning;}
		}
		/// <summary>
		/// 抄表方式 1 自动抄表 2 手持机抄表 3 手工抄表
		/// </summary>
		public int? ReadType
		{
			set{ _readtype=value;}
			get{return _readtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OldFreezeNumber
		{
			set{ _oldfreezenumber=value;}
			get{return _oldfreezenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Megabit
		{
			set{ _megabit=value;}
			get{return _megabit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AdditionNum
		{
			set{ _additionnum=value;}
			get{return _additionnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SmallImagePath
		{
			set{ _smallimagepath=value;}
			get{return _smallimagepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BigImagePath
		{
			set{ _bigimagepath=value;}
			get{return _bigimagepath;}
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
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TakePhotoDate
		{
			set{ _takephotodate=value;}
			get{return _takephotodate;}
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
		public decimal? ActiveSharp
		{
			set{ _activesharp=value;}
			get{return _activesharp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ActivePeak
		{
			set{ _activepeak=value;}
			get{return _activepeak;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ActiveShoulder
		{
			set{ _activeshoulder=value;}
			get{return _activeshoulder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ActiveOffPeak
		{
			set{ _activeoffpeak=value;}
			get{return _activeoffpeak;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MeterStatusString
		{
			set{ _meterstatusstring=value;}
			get{return _meterstatusstring;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int VerifyValue
		{
			set{ _verifyvalue=value;}
			get{return _verifyvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Remnant
		{
			set{ _remnant=value;}
			get{return _remnant;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ValveState
		{
			set{ _valvestate=value;}
			get{return _valvestate;}
		}
		#endregion Model

	}
}

