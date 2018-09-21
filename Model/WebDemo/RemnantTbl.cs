using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// RemnantTbl:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RemnantTbl
	{
		public RemnantTbl()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private decimal _remnant;
		private DateTime _readdate;
		private DateTime? _collectorreaddate= DateTime.Now;
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
		public decimal Remnant
		{
			set{ _remnant=value;}
			get{return _remnant;}
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
		/// 
		/// </summary>
		public DateTime? CollectorReadDate
		{
			set{ _collectorreaddate=value;}
			get{return _collectorreaddate;}
		}
		#endregion Model

	}
}

