using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// UserRegist:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserRegist
	{
		public UserRegist()
		{}
		#region Model
		private int _id;
		private string _registphone;
		private string _password;
		private string _identitycard;
		private int _flag=1;
		private string _registname;
		private string _headimgpath;
		private DateTime _updatetime= DateTime.Now;
		private int? _securityid;
		private string _securityanswer;
		private string _randomstr;
		private int _apptype=1;
		private int _payintegration=0;
		private decimal _totalmoney=0M;
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
		public string RegistPhone
		{
			set{ _registphone=value;}
			get{return _registphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PassWord
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IdentityCard
		{
			set{ _identitycard=value;}
			get{return _identitycard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RegistName
		{
			set{ _registname=value;}
			get{return _registname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeadImgPath
		{
			set{ _headimgpath=value;}
			get{return _headimgpath;}
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
		public int? SecurityId
		{
			set{ _securityid=value;}
			get{return _securityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SecurityAnswer
		{
			set{ _securityanswer=value;}
			get{return _securityanswer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RandomStr
		{
			set{ _randomstr=value;}
			get{return _randomstr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AppType
		{
			set{ _apptype=value;}
			get{return _apptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PayIntegration
		{
			set{ _payintegration=value;}
			get{return _payintegration;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal TotalMoney
		{
			set{ _totalmoney=value;}
			get{return _totalmoney;}
		}
		#endregion Model

	}
}

