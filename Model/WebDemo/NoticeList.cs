using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// NoticeList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NoticeList
	{
		public NoticeList()
		{}
		#region Model
		private int _id;
		private string _noticetitle;
		private string _noticeinfo;
		private DateTime _noticedate= DateTime.Now;
		private string _author;
		private int _showtype=0;
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
		public string NoticeTitle
		{
			set{ _noticetitle=value;}
			get{return _noticetitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NoticeInfo
		{
			set{ _noticeinfo=value;}
			get{return _noticeinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime NoticeDate
		{
			set{ _noticedate=value;}
			get{return _noticedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Author
		{
			set{ _author=value;}
			get{return _author;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ShowType
		{
			set{ _showtype=value;}
			get{return _showtype;}
		}
		#endregion Model

	}
}

