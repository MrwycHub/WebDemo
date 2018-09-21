using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// FreezeMonthDosage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FreezeMonthDosage
	{
		public FreezeMonthDosage()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private string _beginmonth;
		private decimal? _beginnumber;
		private string _freezemonth;
		private decimal? _endnumber;
		private decimal? _usenumber;
		private DateTime? _insertdate= DateTime.Now;
		private decimal? _useactivesharp;
		private decimal? _useactivepeak;
		private decimal? _useactiveshoulder;
		private decimal? _useactiveoffpeak;
		private int _syncflag=0;
		/// <summary>
		/// 
		/// </summary>
		public int id
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
		public string BeginMonth
		{
			set{ _beginmonth=value;}
			get{return _beginmonth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BeginNumber
		{
			set{ _beginnumber=value;}
			get{return _beginnumber;}
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
		public decimal? EndNumber
		{
			set{ _endnumber=value;}
			get{return _endnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UseNumber
		{
			set{ _usenumber=value;}
			get{return _usenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InsertDate
		{
			set{ _insertdate=value;}
			get{return _insertdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UseActiveSharp
		{
			set{ _useactivesharp=value;}
			get{return _useactivesharp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UseActivePeak
		{
			set{ _useactivepeak=value;}
			get{return _useactivepeak;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UseActiveShoulder
		{
			set{ _useactiveshoulder=value;}
			get{return _useactiveshoulder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UseActiveOffPeak
		{
			set{ _useactiveoffpeak=value;}
			get{return _useactiveoffpeak;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SyncFlag
		{
			set{ _syncflag=value;}
			get{return _syncflag;}
		}
		#endregion Model

	}
}

