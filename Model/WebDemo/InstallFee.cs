using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// InstallFee:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InstallFee
	{
		public InstallFee()
		{}
		#region Model
		private int _installid;
		private int? _usernum=1;
		private decimal? _singlefee;
		private decimal? _sumfee;
		private DateTime? _operdate;
		private int? _operatorid;
		private int? _siteid;
		private int? _mark=0;
		private int? _installmark;
		/// <summary>
		/// 
		/// </summary>
		public int InstallID
		{
			set{ _installid=value;}
			get{return _installid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserNum
		{
			set{ _usernum=value;}
			get{return _usernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SingleFee
		{
			set{ _singlefee=value;}
			get{return _singlefee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SumFee
		{
			set{ _sumfee=value;}
			get{return _sumfee;}
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
		/// <summary>
		/// 
		/// </summary>
		public int? Mark
		{
			set{ _mark=value;}
			get{return _mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InstallMark
		{
			set{ _installmark=value;}
			get{return _installmark;}
		}
		#endregion Model

	}
}

