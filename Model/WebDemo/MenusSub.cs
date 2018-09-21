using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MenusSub:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MenusSub
	{
		public MenusSub()
		{}
		#region Model
		private int _menuid;
		private int? _upperid;
		private string _menuname;
		private string _urladdr;
		private string _urltarget;
		private string _imageurl;
		private int _flag=1;
		private int _ordernum=0;
		private int _systemnum;
		/// <summary>
		/// 
		/// </summary>
		public int MenuID
		{
			set{ _menuid=value;}
			get{return _menuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UpperID
		{
			set{ _upperid=value;}
			get{return _upperid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuName
		{
			set{ _menuname=value;}
			get{return _menuname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UrlAddr
		{
			set{ _urladdr=value;}
			get{return _urladdr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UrlTarget
		{
			set{ _urltarget=value;}
			get{return _urltarget;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImageUrl
		{
			set{ _imageurl=value;}
			get{return _imageurl;}
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
		public int Ordernum
		{
			set{ _ordernum=value;}
			get{return _ordernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SystemNum
		{
			set{ _systemnum=value;}
			get{return _systemnum;}
		}
		#endregion Model

	}
}

