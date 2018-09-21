using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// LogList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LogList
	{
		public LogList()
		{}
		#region Model
		private int _logid;
		private string _logtitle;
		private string _logtype;
		private DateTime? _logdate= DateTime.Now;
		private string _logdata;
		/// <summary>
		/// 
		/// </summary>
		public int LogID
		{
			set{ _logid=value;}
			get{return _logid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogTitle
		{
			set{ _logtitle=value;}
			get{return _logtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogType
		{
			set{ _logtype=value;}
			get{return _logtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LogDate
		{
			set{ _logdate=value;}
			get{return _logdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string logData
		{
			set{ _logdata=value;}
			get{return _logdata;}
		}
		#endregion Model

	}
}

