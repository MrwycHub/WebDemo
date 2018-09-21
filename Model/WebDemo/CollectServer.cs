using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// CollectServer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CollectServer
	{
		public CollectServer()
		{}
		#region Model
		private int _serverid;
		private string _servername;
		private int _servertype;
		private string _serverip;
		private string _wcfurl;
		private DateTime _opertime;
		private string _remark;
		private int? _port;
		/// <summary>
		/// 
		/// </summary>
		public int ServerId
		{
			set{ _serverid=value;}
			get{return _serverid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ServerName
		{
			set{ _servername=value;}
			get{return _servername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ServerType
		{
			set{ _servertype=value;}
			get{return _servertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ServerIp
		{
			set{ _serverip=value;}
			get{return _serverip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WcfUrl
		{
			set{ _wcfurl=value;}
			get{return _wcfurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperTime
		{
			set{ _opertime=value;}
			get{return _opertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Port
		{
			set{ _port=value;}
			get{return _port;}
		}
		#endregion Model

	}
}

