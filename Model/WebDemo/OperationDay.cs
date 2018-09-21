using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// OperationDay:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OperationDay
	{
		public OperationDay()
		{}
		#region Model
		private int _operid;
		private int _meterid;
		private string _beginmonth;
		private decimal _beginnumber;
		private string _endmonth;
		private decimal _endnumber;
		private decimal _usenumber;
		private int? _pricetypeid;
		private string _pricetypename;
		private decimal _price;
		private decimal? _price2=0M;
		private decimal? _price3=0M;
		private decimal? _faremoney;
		private int _paymark=0;
		private int _opertype;
		private DateTime _operdate= DateTime.Now;
		private int? _operatorid;
		private string _opermonth;
		private decimal? _meternumber;
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
		public decimal BeginNumber
		{
			set{ _beginnumber=value;}
			get{return _beginnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndMonth
		{
			set{ _endmonth=value;}
			get{return _endmonth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal EndNumber
		{
			set{ _endnumber=value;}
			get{return _endnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal UseNumber
		{
			set{ _usenumber=value;}
			get{return _usenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PriceTypeID
		{
			set{ _pricetypeid=value;}
			get{return _pricetypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PriceTypeName
		{
			set{ _pricetypename=value;}
			get{return _pricetypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price2
		{
			set{ _price2=value;}
			get{return _price2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price3
		{
			set{ _price3=value;}
			get{return _price3;}
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
		public int PayMark
		{
			set{ _paymark=value;}
			get{return _paymark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OperType
		{
			set{ _opertype=value;}
			get{return _opertype;}
		}
		/// <summary>
		/// 业务时间
		/// </summary>
		public DateTime OperDate
		{
			set{ _operdate=value;}
			get{return _operdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opermonth
		{
			set{ _opermonth=value;}
			get{return _opermonth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MeterNumber
		{
			set{ _meternumber=value;}
			get{return _meternumber;}
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

