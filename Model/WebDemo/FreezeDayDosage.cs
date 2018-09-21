using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// FreezeDayDosage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FreezeDayDosage
	{
		public FreezeDayDosage()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private string _freezedate;
		private decimal? _usenumber;
		private int? _dosagetype;
		private DateTime? _insertdate;
		private string _begindate;
		private decimal? _beginnumber;
		private decimal? _endnumber;
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
		public string FreezeDate
		{
			set{ _freezedate=value;}
			get{return _freezedate;}
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
		public int? DosageType
		{
			set{ _dosagetype=value;}
			get{return _dosagetype;}
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
		public string BeginDate
		{
			set{ _begindate=value;}
			get{return _begindate;}
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
		public decimal? EndNumber
		{
			set{ _endnumber=value;}
			get{return _endnumber;}
		}
		#endregion Model

	}
}

