using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// FreezeMonthls:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FreezeMonthls
	{
		public FreezeMonthls()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private string _freezemonth;
		private decimal? _freezenumber;
		private DateTime? _readdate;
		private bool _calmark= false;
		private decimal? _instantnumber;
		private decimal? _pilenumber;
		private decimal? _watertemp;
		private decimal? _backwatertemp;
		private int? _workdate;
		private string _factdate;
		private int? _batterystate;
		private int? _warning;
		private int? _readtype;
		private decimal? _oldfreezenumber;
		private int? _megabit;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FreezeMonth
		{
			set{ _freezemonth=value;}
			get{return _freezemonth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FreezeNumber
		{
			set{ _freezenumber=value;}
			get{return _freezenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ReadDate
		{
			set{ _readdate=value;}
			get{return _readdate;}
		}
		/// <summary>
		/// 
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
		/// 
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
		#endregion Model

	}
}

