using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MetersDev:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MetersDev
	{
		public MetersDev()
		{}
		#region Model
		private int _meterid;
		private DateTime? _disenabledate;
		private int? _sitedir=1;
		private string _insurecode;
		private DateTime? _insuredate;
		private DateTime? _insureenddate;
		private int? _gasdir;
		private int? _installpos;
		private int? _installworkerid;
		private DateTime? _installdate;
		private int? _fireworkerid;
		private DateTime? _firedate;
		private DateTime? _firstcheckdate;
		private int? _firstcheckmark=0;
		private int? _checkcyc=24;
		private int? _boilerflag=0;
		private int? _selfflag=0;
		private int? _bookid;
		private int? _installid;
		private string _firstcheckinfo;
		private int? _firstcheckworkerid;
		private int? _currvalvestate=0;
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
		public DateTime? DisenableDate
		{
			set{ _disenabledate=value;}
			get{return _disenabledate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SiteDir
		{
			set{ _sitedir=value;}
			get{return _sitedir;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InsureCode
		{
			set{ _insurecode=value;}
			get{return _insurecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InsureDate
		{
			set{ _insuredate=value;}
			get{return _insuredate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InsureEndDate
		{
			set{ _insureenddate=value;}
			get{return _insureenddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GasDir
		{
			set{ _gasdir=value;}
			get{return _gasdir;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InstallPos
		{
			set{ _installpos=value;}
			get{return _installpos;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InstallWorkerID
		{
			set{ _installworkerid=value;}
			get{return _installworkerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InstallDate
		{
			set{ _installdate=value;}
			get{return _installdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FireWorkerID
		{
			set{ _fireworkerid=value;}
			get{return _fireworkerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? FireDate
		{
			set{ _firedate=value;}
			get{return _firedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? FirstCheckDate
		{
			set{ _firstcheckdate=value;}
			get{return _firstcheckdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FirstCheckMark
		{
			set{ _firstcheckmark=value;}
			get{return _firstcheckmark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CheckCyc
		{
			set{ _checkcyc=value;}
			get{return _checkcyc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BoilerFlag
		{
			set{ _boilerflag=value;}
			get{return _boilerflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SelfFlag
		{
			set{ _selfflag=value;}
			get{return _selfflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BookID
		{
			set{ _bookid=value;}
			get{return _bookid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InstallID
		{
			set{ _installid=value;}
			get{return _installid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FirstCheckInfo
		{
			set{ _firstcheckinfo=value;}
			get{return _firstcheckinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FirstCheckWorkerID
		{
			set{ _firstcheckworkerid=value;}
			get{return _firstcheckworkerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CurrValveState
		{
			set{ _currvalvestate=value;}
			get{return _currvalvestate;}
		}
		#endregion Model

	}
}

