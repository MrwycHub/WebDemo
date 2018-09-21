using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// InvoiceList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InvoiceList
	{
		public InvoiceList()
		{}
		#region Model
		private int _inid;
		private string _incode;
		private int? _innumber;
		private int? _siteid;
		private string _operatorname;
		private DateTime? _getdate;
		private int? _payid;
		private DateTime? _printdate;
		private decimal? _inmoney;
		private int? _inmark;
		private int? _sendmark;
		private DateTime? _senddate;
		private string _printman;
		private DateTime? _zfdate;
		private string _zfincode;
		private string _zfinnumber;
		private string _uname;
		/// <summary>
		/// 
		/// </summary>
		public int InID
		{
			set{ _inid=value;}
			get{return _inid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InCode
		{
			set{ _incode=value;}
			get{return _incode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InNumber
		{
			set{ _innumber=value;}
			get{return _innumber;}
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
		public string OperatorName
		{
			set{ _operatorname=value;}
			get{return _operatorname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? GetDate
		{
			set{ _getdate=value;}
			get{return _getdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PayID
		{
			set{ _payid=value;}
			get{return _payid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PrintDate
		{
			set{ _printdate=value;}
			get{return _printdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? InMoney
		{
			set{ _inmoney=value;}
			get{return _inmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InMark
		{
			set{ _inmark=value;}
			get{return _inmark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SendMark
		{
			set{ _sendmark=value;}
			get{return _sendmark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SendDate
		{
			set{ _senddate=value;}
			get{return _senddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string printMan
		{
			set{ _printman=value;}
			get{return _printman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? zfDate
		{
			set{ _zfdate=value;}
			get{return _zfdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zfInCode
		{
			set{ _zfincode=value;}
			get{return _zfincode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zfInNumber
		{
			set{ _zfinnumber=value;}
			get{return _zfinnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UName
		{
			set{ _uname=value;}
			get{return _uname;}
		}
		#endregion Model

	}
}

