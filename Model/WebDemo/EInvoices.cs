using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// EInvoices:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EInvoices
	{
		public EInvoices()
		{}
		#region Model
		private int _id;
		private int _operid;
		private int _opertype;
		private string _invoicenumber;
		private string _orderno;
		private int _meterid;
		private decimal _opermoney=0M;
		private decimal _factmoney=0M;
		private int _invoicestate=0;
		private DateTime _operdate;
		private string _url;
		private DateTime? _createdate;
		private int? _operatorid;
		private string _invoicecode;
		private string _rtninvoicenumber;
		private int? _manualregist=0;
		private string _redsaleurl;
		private string _rsinvoicenumber;
		private DateTime? _registdate;
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
		public int OperID
		{
			set{ _operid=value;}
			get{return _operid;}
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
		/// 
		/// </summary>
		public string InvoiceNumber
		{
			set{ _invoicenumber=value;}
			get{return _invoicenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
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
		public decimal OperMoney
		{
			set{ _opermoney=value;}
			get{return _opermoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal FactMoney
		{
			set{ _factmoney=value;}
			get{return _factmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int InvoiceState
		{
			set{ _invoicestate=value;}
			get{return _invoicestate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperDate
		{
			set{ _operdate=value;}
			get{return _operdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string URL
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
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
		public string InvoiceCode
		{
			set{ _invoicecode=value;}
			get{return _invoicecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RtnInvoiceNumber
		{
			set{ _rtninvoicenumber=value;}
			get{return _rtninvoicenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ManualRegist
		{
			set{ _manualregist=value;}
			get{return _manualregist;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RedSaleURL
		{
			set{ _redsaleurl=value;}
			get{return _redsaleurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RSInvoiceNumber
		{
			set{ _rsinvoicenumber=value;}
			get{return _rsinvoicenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RegistDate
		{
			set{ _registdate=value;}
			get{return _registdate;}
		}
		#endregion Model

	}
}

