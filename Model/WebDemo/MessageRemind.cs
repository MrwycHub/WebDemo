using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MessageRemind:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MessageRemind
	{
		public MessageRemind()
		{}
		#region Model
		private int _id;
		private int _remindtype=1;
		private string _remindcontent;
		private string _operatoridstr;
		private string _readedstr;
		private DateTime _updatetime= DateTime.Now;
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
		public int RemindType
		{
			set{ _remindtype=value;}
			get{return _remindtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RemindContent
		{
			set{ _remindcontent=value;}
			get{return _remindcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperatorIDStr
		{
			set{ _operatoridstr=value;}
			get{return _operatoridstr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReadedStr
		{
			set{ _readedstr=value;}
			get{return _readedstr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		#endregion Model

	}
}

