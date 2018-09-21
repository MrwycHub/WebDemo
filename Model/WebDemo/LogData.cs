using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// LogData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LogData
	{
		public LogData()
		{}
		#region Model
		private int _logid;
		private string _logtitle;
		private string _logtype;
		private DateTime? _logdate;
		private string _logmemo;
		private string _logdata;
		private string _logoperator;
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
		public string LogMemo
		{
			set{ _logmemo=value;}
			get{return _logmemo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogData
		{
			set{ _logdata=value;}
			get{return _logdata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogOperator
		{
			set{ _logoperator=value;}
			get{return _logoperator;}
		}
		#endregion Model

	}
}

