using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MultiOperation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MultiOperation
	{
		public MultiOperation()
		{}
		#region Model
		private int _operid;
		private int? _multiuserid;
		private int? _cardid;
		private int? _cardsector;
		private decimal? _opermoney;
		private decimal? _lastbalance;
		private decimal? _currentbalance;
		private decimal? _totalmoney;
		private int? _opertype;
		private string _invoicecode;
		private DateTime? _operdate;
		private int? _operatorid;
		private string _remark;
		private int? _invoiceid;
		private int? _invoicetype;
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
		public int? MultiUserID
		{
			set{ _multiuserid=value;}
			get{return _multiuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CardID
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CardSector
		{
			set{ _cardsector=value;}
			get{return _cardsector;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OperMoney
		{
			set{ _opermoney=value;}
			get{return _opermoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LastBalance
		{
			set{ _lastbalance=value;}
			get{return _lastbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CurrentBalance
		{
			set{ _currentbalance=value;}
			get{return _currentbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalMoney
		{
			set{ _totalmoney=value;}
			get{return _totalmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperType
		{
			set{ _opertype=value;}
			get{return _opertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvoiceCode
		{
			set{ _invoicecode=value;}
			get{return _invoicecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OperDate
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
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
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
		#endregion Model

	}
}

