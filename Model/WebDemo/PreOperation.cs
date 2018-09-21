using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// PreOperation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PreOperation
	{
		public PreOperation()
		{}
		#region Model
		private int _operid;
		private int? _cardid;
		private int? _cardsector;
		private int _pricetypeid;
		private string _pricetypename;
		private decimal _price;
		private decimal? _opermoney;
		private int _operint;
		private int _operzs;
		private decimal? _factmoney;
		private decimal? _lastbalance;
		private decimal? _currentbalance;
		private decimal? _totalmoney;
		private int _totalint;
		private int _totalbase;
		private int _opertype;
		private int _paytype;
		private string _invoicecode;
		private DateTime _operdate;
		private int _meterid;
		private int _operatorid;
		private int _siteid=0;
		private decimal? _factorynum;
		private string _remark;
		private int? _redoperid;
		private int? _opernum;
		private decimal? _price2;
		private decimal? _price3;
		private int? _divid1;
		private int? _divid2;
		private decimal? _usenumber1;
		private decimal? _usenumber2;
		private decimal? _usenumber3;
		private decimal? _curtotalbuynumber;
		private int? _invoiceid;
		private int? _invoicetype;
		private int _writecardflag=0;
		private string _transactionid;
		private int _payway=1;
		private string _outtradeno;
		private DateTime? _depositdate;
		private int? _discountsnum;
		/// <summary>
		/// 业务编号
		/// </summary>
		public int OperID
		{
			set{ _operid=value;}
			get{return _operid;}
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
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 业务金额
		/// </summary>
		public decimal? OperMoney
		{
			set{ _opermoney=value;}
			get{return _opermoney;}
		}
		/// <summary>
		/// 业务量
		/// </summary>
		public int OperInt
		{
			set{ _operint=value;}
			get{return _operint;}
		}
		/// <summary>
		/// 业务字数
		/// </summary>
		public int OperZS
		{
			set{ _operzs=value;}
			get{return _operzs;}
		}
		/// <summary>
		/// 实收金额
		/// </summary>
		public decimal? FactMoney
		{
			set{ _factmoney=value;}
			get{return _factmoney;}
		}
		/// <summary>
		/// 上次余额
		/// </summary>
		public decimal? LastBalance
		{
			set{ _lastbalance=value;}
			get{return _lastbalance;}
		}
		/// <summary>
		/// 本次余额
		/// </summary>
		public decimal? CurrentBalance
		{
			set{ _currentbalance=value;}
			get{return _currentbalance;}
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
		public int TotalInt
		{
			set{ _totalint=value;}
			get{return _totalint;}
		}
		/// <summary>
		/// 总购买字数
		/// </summary>
		public int TotalBase
		{
			set{ _totalbase=value;}
			get{return _totalbase;}
		}
		/// <summary>
		/// 业务类型(1-开户；2-充值；3-补卡；4-销户；5-换表)
		/// </summary>
		public int OperType
		{
			set{ _opertype=value;}
			get{return _opertype;}
		}
		/// <summary>
		/// 充值类型(1-远程充值；2-写卡机充值)
		/// </summary>
		public int PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		/// <summary>
		/// 发票号码
		/// </summary>
		public string InvoiceCode
		{
			set{ _invoicecode=value;}
			get{return _invoicecode;}
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
		/// 表编号
		/// </summary>
		public int MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 操作员
		/// </summary>
		public int OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SiteID
		{
			set{ _siteid=value;}
			get{return _siteid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FactoryNum
		{
			set{ _factorynum=value;}
			get{return _factorynum;}
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
		public int? RedOperId
		{
			set{ _redoperid=value;}
			get{return _redoperid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperNum
		{
			set{ _opernum=value;}
			get{return _opernum;}
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
		public decimal? CurTotalBuyNumber
		{
			set{ _curtotalbuynumber=value;}
			get{return _curtotalbuynumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InvoiceID
		{
			set{ _invoiceid=value;}
			get{return _invoiceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InvoiceType
		{
			set{ _invoicetype=value;}
			get{return _invoicetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WriteCardFlag
		{
			set{ _writecardflag=value;}
			get{return _writecardflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TransactionId
		{
			set{ _transactionid=value;}
			get{return _transactionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PayWay
		{
			set{ _payway=value;}
			get{return _payway;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OutTradeNo
		{
			set{ _outtradeno=value;}
			get{return _outtradeno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DepositDate
		{
			set{ _depositdate=value;}
			get{return _depositdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DiscountsNum
		{
			set{ _discountsnum=value;}
			get{return _discountsnum;}
		}
		#endregion Model

	}
}

