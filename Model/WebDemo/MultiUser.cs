using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MultiUser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MultiUser
	{
		public MultiUser()
		{}
		#region Model
		private int _multiuserid;
		private string _usercode;
		private string _username;
		private string _deptid;
		private int _cardid;
		private int _cardsector;
		private string _cardsn;
		private int _mark=1;
		private string _sex="男";
		private string _phone;
		private int? _papertype;
		private string _paperno;
		private string _uaccount;
		private DateTime? _opentime= DateTime.Now;
		private DateTime? _validdate;
		private decimal? _lastmoney=0M;
		private decimal? _totalmoney=0M;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int MultiUserID
		{
			set{ _multiuserid=value;}
			get{return _multiuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserCode
		{
			set{ _usercode=value;}
			get{return _usercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptID
		{
			set{ _deptid=value;}
			get{return _deptid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CardId
		{
			set{ _cardid=value;}
			get{return _cardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CardSector
		{
			set{ _cardsector=value;}
			get{return _cardsector;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CardSn
		{
			set{ _cardsn=value;}
			get{return _cardsn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Mark
		{
			set{ _mark=value;}
			get{return _mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
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
		public int? PaperType
		{
			set{ _papertype=value;}
			get{return _papertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PaperNo
		{
			set{ _paperno=value;}
			get{return _paperno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uAccount
		{
			set{ _uaccount=value;}
			get{return _uaccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OpenTime
		{
			set{ _opentime=value;}
			get{return _opentime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ValidDate
		{
			set{ _validdate=value;}
			get{return _validdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LastMoney
		{
			set{ _lastmoney=value;}
			get{return _lastmoney;}
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
		public string ReMark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

