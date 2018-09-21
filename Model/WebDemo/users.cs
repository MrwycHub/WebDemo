using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class users
	{
		public users()
		{}
		#region Model
		private int _usersid;
		private string _usercode;
		private string _username;
		private string _doorplate;
		private string _papertype;
		private string _paperno;
		private string _address;
		private string _phone;
		private string _tel;
		private decimal _acreage=1M;
		private decimal _chargeacreage;
		private decimal _reserve=0M;
		private string _sex;
		private int _populace;
		private string _remark;
		private int _mark=1;
		private string _deptid;
		private string _userfloor;
		private string _housedir;
		private string _usertype;
		private string _clientid;
		private decimal? _remnant;
		private decimal? _remnant2;
		private decimal? _remnant3;
		private DateTime _updatetime= DateTime.Now;
		private string _registphone;
		private int _einvoicetype=0;
		/// <summary>
		/// 
		/// </summary>
		public int UsersID
		{
			set{ _usersid=value;}
			get{return _usersid;}
		}
		/// <summary>
		/// 用户编号,不能重复
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
		public string Doorplate
		{
			set{ _doorplate=value;}
			get{return _doorplate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PaperType
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
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
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
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 住房面积
		/// </summary>
		public decimal Acreage
		{
			set{ _acreage=value;}
			get{return _acreage;}
		}
		/// <summary>
		/// 收费面积
		/// </summary>
		public decimal ChargeAcreage
		{
			set{ _chargeacreage=value;}
			get{return _chargeacreage;}
		}
		/// <summary>
		/// 余额
		/// </summary>
		public decimal Reserve
		{
			set{ _reserve=value;}
			get{return _reserve;}
		}
		/// <summary>
		/// 性别
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 人口
		/// </summary>
		public int Populace
		{
			set{ _populace=value;}
			get{return _populace;}
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
		/// 状态 1正常 2销户
		/// </summary>
		public int Mark
		{
			set{ _mark=value;}
			get{return _mark;}
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
		public string UserFloor
		{
			set{ _userfloor=value;}
			get{return _userfloor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HouseDir
		{
			set{ _housedir=value;}
			get{return _housedir;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserType
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientId
		{
			set{ _clientid=value;}
			get{return _clientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Remnant
		{
			set{ _remnant=value;}
			get{return _remnant;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Remnant2
		{
			set{ _remnant2=value;}
			get{return _remnant2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Remnant3
		{
			set{ _remnant3=value;}
			get{return _remnant3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegistPhone
		{
			set{ _registphone=value;}
			get{return _registphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EInvoiceType
		{
			set{ _einvoicetype=value;}
			get{return _einvoicetype;}
		}
		#endregion Model

	}
}

