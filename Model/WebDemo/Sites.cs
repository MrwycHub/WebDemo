using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Sites:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sites
	{
		public Sites()
		{}
		#region Model
		private int _siteid;
		private string _sitename;
		private string _siteaddr;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int SiteID
		{
			set{ _siteid=value;}
			get{return _siteid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SiteName
		{
			set{ _sitename=value;}
			get{return _sitename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SiteAddr
		{
			set{ _siteaddr=value;}
			get{return _siteaddr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

