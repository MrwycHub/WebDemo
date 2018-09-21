using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// UserFeedBack:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserFeedBack
	{
		public UserFeedBack()
		{}
		#region Model
		private int _id;
		private string _usercode;
		private string _contactway;
		private string _phone;
		private string _content;
		private DateTime _publishdate= DateTime.Now;
		private string _replyman;
		private string _replycontent;
		private DateTime _replydate= DateTime.Now;
		private int _flag=0;
		private int _typeid=1;
		private string _contact;
		private int _replyflag=0;
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
		public string UserCode
		{
			set{ _usercode=value;}
			get{return _usercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ContactWay
		{
			set{ _contactway=value;}
			get{return _contactway;}
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
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PublishDate
		{
			set{ _publishdate=value;}
			get{return _publishdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReplyMan
		{
			set{ _replyman=value;}
			get{return _replyman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReplyContent
		{
			set{ _replycontent=value;}
			get{return _replycontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ReplyDate
		{
			set{ _replydate=value;}
			get{return _replydate;}
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
		public int TypeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Contact
		{
			set{ _contact=value;}
			get{return _contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ReplyFlag
		{
			set{ _replyflag=value;}
			get{return _replyflag;}
		}
		#endregion Model

	}
}

