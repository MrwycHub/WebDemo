using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ManageFare:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ManageFare
	{
		public ManageFare()
		{}
		#region Model
		private int _managefareid;
		private string _managefarename;
		private decimal _managefareprice;
		private int _managefaretypeid;
		private string _remark;
		private int? _systemnum=0;
		/// <summary>
		/// 
		/// </summary>
		public int ManageFareID
		{
			set{ _managefareid=value;}
			get{return _managefareid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ManageFareName
		{
			set{ _managefarename=value;}
			get{return _managefarename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal ManageFarePrice
		{
			set{ _managefareprice=value;}
			get{return _managefareprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ManageFareTypeID
		{
			set{ _managefaretypeid=value;}
			get{return _managefaretypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReMark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SystemNum
		{
			set{ _systemnum=value;}
			get{return _systemnum;}
		}
		#endregion Model

	}
}

