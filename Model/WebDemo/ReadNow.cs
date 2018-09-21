using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ReadNow:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ReadNow
	{
		public ReadNow()
		{}
		#region Model
		private int _id;
		private int? _meterid;
		private decimal? _readnumber;
		private int? _valvestate;
		private int? _attackstate;
		private decimal? _voltage;
		private DateTime _readdate;
		private decimal? _instantnumber;
		private decimal? _pilenumber;
		private decimal? _watertemp;
		private decimal? _backwatertemp;
		private int? _workdate;
		private string _factdate;
		private int? _batterystate;
		private int? _warning;
		private decimal? _oldfreezenumber;
		private int? _megabit;
		private int? _usestate;
		private int? _pricesetno=0;
		private DateTime? _collectorreaddate= DateTime.Now;
		private string _meterstatusstring;
		private decimal _remnant=0M;
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
		public int? MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 当前读数
		/// </summary>
		public decimal? ReadNumber
		{
			set{ _readnumber=value;}
			get{return _readnumber;}
		}
		/// <summary>
		/// 阀门状态(1-开阀；2-关阀；3-异常)
		/// </summary>
		public int? ValveState
		{
			set{ _valvestate=value;}
			get{return _valvestate;}
		}
		/// <summary>
		/// 攻击状态(1-正常；2-被攻击；3-异常)
		/// </summary>
		public int? AttackState
		{
			set{ _attackstate=value;}
			get{return _attackstate;}
		}
		/// <summary>
		/// 电压
		/// </summary>
		public decimal? Voltage
		{
			set{ _voltage=value;}
			get{return _voltage;}
		}
		/// <summary>
		/// 抄表时间
		/// </summary>
		public DateTime ReadDate
		{
			set{ _readdate=value;}
			get{return _readdate;}
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
		public int? UseState
		{
			set{ _usestate=value;}
			get{return _usestate;}
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
		public string MeterStatusString
		{
			set{ _meterstatusstring=value;}
			get{return _meterstatusstring;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Remnant
		{
			set{ _remnant=value;}
			get{return _remnant;}
		}
		#endregion Model

	}
}

