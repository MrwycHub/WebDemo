using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// PaymentList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PaymentList
	{
		public PaymentList()
		{}
		#region Model
		private int _operid;
		private int _usersid=0;
		private int? _meterid;
		private string _invoicenum;
		private decimal? _lastbalance;
		private decimal? _thismoney;
		private decimal? _factmoney;
		private decimal? _thisbalance;
		private DateTime _paydate;
		private int _operatorid;
		private int _paymode=1;
		private int _flag=0;
		private int? _siteid=0;
		private int? _operint;
		private decimal? _price;
		private int? _invoiceid;
		private int? _invoicetype;
		private int _paytype=5;
		private int _payway=1;
		private string _transactionid;
		private string _outtradeno;
		/// <summary>
		/// 业务编号
		/// </summary>
		public int OperID
		{
			set{ _operid=value;}
			get{return _operid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UsersID
		{
			set{ _usersid=value;}
			get{return _usersid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 发票号码
		/// </summary>
		public string InvoiceNum
		{
			set{ _invoicenum=value;}
			get{return _invoicenum;}
		}
		/// <summary>
		/// 上次余额
		/// </summary>
		public decimal? Lastbalance
		{
			set{ _lastbalance=value;}
			get{return _lastbalance;}
		}
		/// <summary>
		/// 本次应交
		/// </summary>
		public decimal? ThisMoney
		{
			set{ _thismoney=value;}
			get{return _thismoney;}
		}
		/// <summary>
		/// 本次实交
		/// </summary>
		public decimal? FactMoney
		{
			set{ _factmoney=value;}
			get{return _factmoney;}
		}
		/// <summary>
		/// 本次余额
		/// </summary>
		public decimal? ThisBalance
		{
			set{ _thisbalance=value;}
			get{return _thisbalance;}
		}
		/// <summary>
		/// 业务日期
		/// </summary>
		public DateTime PayDate
		{
			set{ _paydate=value;}
			get{return _paydate;}
		}
		/// <summary>
		/// 操作员编号
		/// </summary>
		public int OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PayMode
		{
			set{ _paymode=value;}
			get{return _paymode;}
		}
		/// <summary>
		/// 误收费恢复后，置为1
		/// </summary>
		public int Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SiteID
		{
			set{ _siteid=value;}
			get{return _siteid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperInt
		{
			set{ _operint=value;}
			get{return _operint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
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
		public int PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
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
		public string TransactionId
		{
			set{ _transactionid=value;}
			get{return _transactionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OutTradeNo
		{
			set{ _outtradeno=value;}
			get{return _outtradeno;}
		}
		#endregion Model

	}
}

