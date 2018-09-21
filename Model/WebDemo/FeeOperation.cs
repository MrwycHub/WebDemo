using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// FeeOperation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FeeOperation
	{
		public FeeOperation()
		{}
		#region Model
		private int _fid;
		private int? _usersid;
		private int? _fareid;
		private decimal? _fee;
		private decimal? _factfee;
		private DateTime? _operdate;
		private int? _operatorid;
		private int? _siteid;
		/// <summary>
		/// 
		/// </summary>
		public int FID
		{
			set{ _fid=value;}
			get{return _fid;}
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
		public int? FareID
		{
			set{ _fareid=value;}
			get{return _fareid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Fee
		{
			set{ _fee=value;}
			get{return _fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FactFee
		{
			set{ _factfee=value;}
			get{return _factfee;}
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
		public int? SiteID
		{
			set{ _siteid=value;}
			get{return _siteid;}
		}
		#endregion Model

	}
}

