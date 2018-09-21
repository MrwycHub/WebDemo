using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// OperationFareDay:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OperationFareDay
	{
		public OperationFareDay()
		{}
		#region Model
		private int _operid;
		private int _fareid;
		private string _faretypename;
		private decimal _fareprice;
		private decimal? _faremoney;
		private decimal? _fareprice2;
		private decimal? _fareprice3;
		private int? _divid1;
		private int? _divid2;
		private decimal? _usenumber1;
		private decimal? _usenumber2;
		private decimal? _usenumber3;
		private string _extdata1;
		private string _extdata2;
		/// <summary>
		/// 
		/// </summary>
		public int OperID
		{
			set{ _operid=value;}
			get{return _operid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FareID
		{
			set{ _fareid=value;}
			get{return _fareid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FareTypeName
		{
			set{ _faretypename=value;}
			get{return _faretypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal FarePrice
		{
			set{ _fareprice=value;}
			get{return _fareprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FareMoney
		{
			set{ _faremoney=value;}
			get{return _faremoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FarePrice2
		{
			set{ _fareprice2=value;}
			get{return _fareprice2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FarePrice3
		{
			set{ _fareprice3=value;}
			get{return _fareprice3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Divid1
		{
			set{ _divid1=value;}
			get{return _divid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Divid2
		{
			set{ _divid2=value;}
			get{return _divid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UseNumber1
		{
			set{ _usenumber1=value;}
			get{return _usenumber1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UseNumber2
		{
			set{ _usenumber2=value;}
			get{return _usenumber2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UseNumber3
		{
			set{ _usenumber3=value;}
			get{return _usenumber3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExtData1
		{
			set{ _extdata1=value;}
			get{return _extdata1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExtData2
		{
			set{ _extdata2=value;}
			get{return _extdata2;}
		}
		#endregion Model

	}
}

