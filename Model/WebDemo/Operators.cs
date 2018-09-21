using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Operators:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Operators
	{
		public Operators()
		{}
		#region Model
		private int _operatorid;
		private string _operatorcode;
		private string _operatorname;
		private int? _roleid;
		private string _operpassword;
		private int? _siteid=0;
		private int _flag=1;
		private DateTime _createdate= DateTime.Now;
		private DateTime? _lastlogindate;
		private int _pagerowcounts=10;
		private string _operlevel;
		private int _templateid=1;
		private int? _paymenttemplateid;
		private int? _ictemplateid;
		private string _phone;
		private string _selfsetting;
		private int? _autoread=0;
		private string _phoneserialnumber;
		private int _isbinding=0;
		private int _rolelevel=1;
		private DateTime _expirydate= Convert.ToDateTime(dateaddyear,1,getdate);
		private string _skin;
		/// <summary>
		/// 
		/// </summary>
		public int OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperatorCode
		{
			set{ _operatorcode=value;}
			get{return _operatorcode;}
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
		public int? RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperPassword
		{
			set{ _operpassword=value;}
			get{return _operpassword;}
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
		/// 1-正常 2锁定
		/// </summary>
		public int Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LastLoginDate
		{
			set{ _lastlogindate=value;}
			get{return _lastlogindate;}
		}
		/// <summary>
		/// 每页显示行数
		/// </summary>
		public int PageRowCounts
		{
			set{ _pagerowcounts=value;}
			get{return _pagerowcounts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperLevel
		{
			set{ _operlevel=value;}
			get{return _operlevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TemplateID
		{
			set{ _templateid=value;}
			get{return _templateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PaymentTemplateID
		{
			set{ _paymenttemplateid=value;}
			get{return _paymenttemplateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ICTemplateID
		{
			set{ _ictemplateid=value;}
			get{return _ictemplateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SelfSetting
		{
			set{ _selfsetting=value;}
			get{return _selfsetting;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AutoRead
		{
			set{ _autoread=value;}
			get{return _autoread;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PhoneSerialNumber
		{
			set{ _phoneserialnumber=value;}
			get{return _phoneserialnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsBinding
		{
			set{ _isbinding=value;}
			get{return _isbinding;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RoleLevel
		{
			set{ _rolelevel=value;}
			get{return _rolelevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ExpiryDate
		{
			set{ _expirydate=value;}
			get{return _expirydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Skin
		{
			set{ _skin=value;}
			get{return _skin;}
		}
		#endregion Model

	}
}

