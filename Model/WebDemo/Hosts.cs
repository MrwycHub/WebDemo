using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Hosts:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Hosts
	{
		public Hosts()
		{}
		#region Model
		private int _collectorid;
		private int _hostid;
		private string _hostname;
		private string _hostaddr;
		private string _remark;
		private int? _flag;
		private int _limitnum=10;
		private int _hostcomtype=2;
		private int? _hosttype;
		private string _hostrdate;
		private int? _downloadflag=0;
		private int? _powertype=1;
		private int? _hostno;
		private int? _hostlimitnum=10;
		private int? _isrelay=0;
		private int? _isdownmetertype;
		/// <summary>
		/// 集中器编号
		/// </summary>
		public int CollectorID
		{
			set{ _collectorid=value;}
			get{return _collectorid;}
		}
		/// <summary>
		/// 楼宇主机编号
		/// </summary>
		public int HostID
		{
			set{ _hostid=value;}
			get{return _hostid;}
		}
		/// <summary>
		/// 楼宇主机名称
		/// </summary>
		public string HostName
		{
			set{ _hostname=value;}
			get{return _hostname;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string HostAddr
		{
			set{ _hostaddr=value;}
			get{return _hostaddr;}
		}
		/// <summary>
		/// 备注信息
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LimitNum
		{
			set{ _limitnum=value;}
			get{return _limitnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int HostComType
		{
			set{ _hostcomtype=value;}
			get{return _hostcomtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HostType
		{
			set{ _hosttype=value;}
			get{return _hosttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HostRDate
		{
			set{ _hostrdate=value;}
			get{return _hostrdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DownloadFlag
		{
			set{ _downloadflag=value;}
			get{return _downloadflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PowerType
		{
			set{ _powertype=value;}
			get{return _powertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HostNo
		{
			set{ _hostno=value;}
			get{return _hostno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? HostLimitNum
		{
			set{ _hostlimitnum=value;}
			get{return _hostlimitnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsRelay
		{
			set{ _isrelay=value;}
			get{return _isrelay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsDownMeterType
		{
			set{ _isdownmetertype=value;}
			get{return _isdownmetertype;}
		}
		#endregion Model

	}
}

