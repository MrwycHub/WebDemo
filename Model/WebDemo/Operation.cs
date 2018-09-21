using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Operation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Operation
	{
		public Operation()
		{}
		#region Model
		private int _operid;
		private int _meterid;
		private int? _payid;
		private string _beginmonth;
		private int _beginnumber;
		private string _endmonth;
		private int _endnumber;
		private int _usenumber;
		private int _pricetypeid;
		private string _pricetypename;
		private decimal? _price=0M;
		private decimal? _price2=0M;
		private decimal? _price3=0M;
		private decimal? _faremoney;
		private int? _paymark=0;
		private int? _opertype;
		private DateTime _operdate;
		private int? _operatorid;
		private string _opermonth;
		private int _tid;
		private string _priceunit;
		private int? _derateid=0;
		private string _farename;
		private string _operationname="0";
		private int? _divid1;
		private int? _divid2;
		private decimal? _usenumber1;
		private decimal? _usenumber2;
		private decimal? _usenumber3;
		private string _deratereason;
		private decimal? _additionnum;
		private int? _fareid;
		/// <summary>
		/// 业务编号
		/// </summary>
		public int OperID
		{
			set{ _operid=value;}
			get{return _operid;}
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
		/// 缴费ID
		/// </summary>
		public int? PayID
		{
			set{ _payid=value;}
			get{return _payid;}
		}
		/// <summary>
		/// 起始月份
		/// </summary>
		public string BeginMonth
		{
			set{ _beginmonth=value;}
			get{return _beginmonth;}
		}
		/// <summary>
		/// 起始读数
		/// </summary>
		public int BeginNumber
		{
			set{ _beginnumber=value;}
			get{return _beginnumber;}
		}
		/// <summary>
		/// 终止月份
		/// </summary>
		public string EndMonth
		{
			set{ _endmonth=value;}
			get{return _endmonth;}
		}
		/// <summary>
		/// 终止读数
		/// </summary>
		public int EndNumber
		{
			set{ _endnumber=value;}
			get{return _endnumber;}
		}
		/// <summary>
		/// 周期用量
		/// </summary>
		public int UseNumber
		{
			set{ _usenumber=value;}
			get{return _usenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PriceTypeID
		{
			set{ _pricetypeid=value;}
			get{return _pricetypeid;}
		}
		/// <summary>
		/// 价格名称
		/// </summary>
		public string PriceTypeName
		{
			set{ _pricetypename=value;}
			get{return _pricetypename;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal? Price2
		{
			set{ _price2=value;}
			get{return _price2;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal? Price3
		{
			set{ _price3=value;}
			get{return _price3;}
		}
		/// <summary>
		/// 费用
		/// </summary>
		public decimal? FareMoney
		{
			set{ _faremoney=value;}
			get{return _faremoney;}
		}
		/// <summary>
		/// 缴费标志
		/// </summary>
		public int? PayMark
		{
			set{ _paymark=value;}
			get{return _paymark;}
		}
		/// <summary>
		/// 业务类型(1-抄表结算；2-换表结算;3、销户结算)
		/// </summary>
		public int? OperType
		{
			set{ _opertype=value;}
			get{return _opertype;}
		}
		/// <summary>
		/// 业务日期
		/// </summary>
		public DateTime OperDate
		{
			set{ _operdate=value;}
			get{return _operdate;}
		}
		/// <summary>
		/// 操作员
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
		public int TID
		{
			set{ _tid=value;}
			get{return _tid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PriceUnit
		{
			set{ _priceunit=value;}
			get{return _priceunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Derateid
		{
			set{ _derateid=value;}
			get{return _derateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FareName
		{
			set{ _farename=value;}
			get{return _farename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperationName
		{
			set{ _operationname=value;}
			get{return _operationname;}
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
		public string DerateReason
		{
			set{ _deratereason=value;}
			get{return _deratereason;}
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
		public int? FareID
		{
			set{ _fareid=value;}
			get{return _fareid;}
		}
		#endregion Model

	}
}

