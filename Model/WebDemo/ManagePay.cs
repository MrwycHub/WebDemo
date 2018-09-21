using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ManagePay:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ManagePay
	{
		public ManagePay()
		{}
		#region Model
		private int _operid;
		private int? _usersid;
		private decimal? _opermoney;
		private int? _operatorid;
		private DateTime? _operdate;
		private int _paytype=1;
		private int _flag=0;
		private decimal? _thisreserve;
		private decimal? _lastreserve;
		private int? _redoperid;
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
		public int? UsersID
		{
			set{ _usersid=value;}
			get{return _usersid;}
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
		public int PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
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
		public decimal? ThisReserve
		{
			set{ _thisreserve=value;}
			get{return _thisreserve;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LastReserve
		{
			set{ _lastreserve=value;}
			get{return _lastreserve;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RedOperId
		{
			set{ _redoperid=value;}
			get{return _redoperid;}
		}
		#endregion Model

	}
}

