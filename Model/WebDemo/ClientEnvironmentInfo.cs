using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ClientEnvironmentInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ClientEnvironmentInfo
	{
		public ClientEnvironmentInfo()
		{}
		#region Model
		private long _id;
		private string _danweiname;
		private string _jiqima;
		private string _operatorcode;
		private string _ip;
		private string _browsername;
		private string _browerversion;
		private string _osname;
		private DateTime _createtime= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public long Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DanWeiName
		{
			set{ _danweiname=value;}
			get{return _danweiname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JiQiMa
		{
			set{ _jiqima=value;}
			get{return _jiqima;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperatorCode
		{
			set{ _operatorcode=value;}
			get{return _operatorcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BrowserName
		{
			set{ _browsername=value;}
			get{return _browsername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BrowerVersion
		{
			set{ _browerversion=value;}
			get{return _browerversion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OSName
		{
			set{ _osname=value;}
			get{return _osname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

