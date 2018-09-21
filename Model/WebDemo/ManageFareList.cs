using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ManageFareList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ManageFareList
	{
		public ManageFareList()
		{}
		#region Model
		private int? _usersid;
		private int? _managefareid;
		private string _lastmonth;
		private string _thismonth;
		private decimal? _managefareprice;
		private decimal? _opermoney;
		private int? _operatorid;
		private DateTime? _operdate;
		private string _remark;
		private int? _operid;
		private int _opertype=0;
		private int? _rcvfarenum=1;
		/// <summary>
		/// 
		/// </summary>
		public int? UsersID
		{
			set{ _usersid=value;}
			get{return _usersid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ManageFareID
		{
			set{ _managefareid=value;}
			get{return _managefareid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastMonth
		{
			set{ _lastmonth=value;}
			get{return _lastmonth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ThisMonth
		{
			set{ _thismonth=value;}
			get{return _thismonth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ManageFarePrice
		{
			set{ _managefareprice=value;}
			get{return _managefareprice;}
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
		public int? OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
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
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperID
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
		public int? RcvFareNum
		{
			set{ _rcvfarenum=value;}
			get{return _rcvfarenum;}
		}
		#endregion Model

	}
}

