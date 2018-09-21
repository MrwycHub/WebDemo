using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Collectors:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Collectors
	{
		public Collectors()
		{}
		#region Model
		private int _collectorid;
		private string _collectorname;
		private string _collectoraddr;
		private int? _collectortype;
		private string _deptid;
		private string _phonenumber;
		private int? _collovertime=30000;
		private string _ipnumber;
		private int? _portnumber=1001;
		private int? _gprscycle=0;
		private int? _freezeday=28;
		private int? _freezehour;
		private string _readday;
		private DateTime? _logindate;
		private DateTime? _updatedate;
		private string _loginip;
		private int? _loginport;
		private int? _mark;
		private string _remark;
		private string _collectorver;
		private string _collectormodel;
		private string _collectorapn;
		private int? _isservermode=1;
		private string _worktime;
		private string _networktime;
		private string _factorycode;
		private int? _framestype;
		private int? _meteraddrformat=1;
		private string _gprsphone;
		private string _expiretime;
		private int _workmode=0;
		private decimal? _lng;
		private decimal? _lat;
		/// <summary>
		/// 集中器编号
		/// </summary>
		public int CollectorID
		{
			set{ _collectorid=value;}
			get{return _collectorid;}
		}
		/// <summary>
		/// 集中器名称
		/// </summary>
		public string CollectorName
		{
			set{ _collectorname=value;}
			get{return _collectorname;}
		}
		/// <summary>
		/// 集中器地址
		/// </summary>
		public string CollectorAddr
		{
			set{ _collectoraddr=value;}
			get{return _collectoraddr;}
		}
		/// <summary>
		/// 集中器类型(1-电话线方式；2-以太网方式；3-232方式；4-GPRS方式)
		/// </summary>
		public int? CollectorType
		{
			set{ _collectortype=value;}
			get{return _collectortype;}
		}
		/// <summary>
		/// 部门编号
		/// </summary>
		public string DeptID
		{
			set{ _deptid=value;}
			get{return _deptid;}
		}
		/// <summary>
		/// 电话号码(电话线方式时使用)
		/// </summary>
		public string PhoneNumber
		{
			set{ _phonenumber=value;}
			get{return _phonenumber;}
		}
		/// <summary>
		/// 超时时间
		/// </summary>
		public int? CollOverTime
		{
			set{ _collovertime=value;}
			get{return _collovertime;}
		}
		/// <summary>
		/// IP地址(以太网方式时使用)
		/// </summary>
		public string IPNumber
		{
			set{ _ipnumber=value;}
			get{return _ipnumber;}
		}
		/// <summary>
		/// 端口号(以太网方式时使用)
		/// </summary>
		public int? PortNumber
		{
			set{ _portnumber=value;}
			get{return _portnumber;}
		}
		/// <summary>
		/// Gprs心跳周期
		/// </summary>
		public int? GprsCycle
		{
			set{ _gprscycle=value;}
			get{return _gprscycle;}
		}
		/// <summary>
		/// 冻结日
		/// </summary>
		public int? FreezeDay
		{
			set{ _freezeday=value;}
			get{return _freezeday;}
		}
		/// <summary>
		/// 冻结时
		/// </summary>
		public int? FreezeHour
		{
			set{ _freezehour=value;}
			get{return _freezehour;}
		}
		/// <summary>
		/// 抄表日
		/// </summary>
		public string ReadDay
		{
			set{ _readday=value;}
			get{return _readday;}
		}
		/// <summary>
		/// 登录时间
		/// </summary>
		public DateTime? LoginDate
		{
			set{ _logindate=value;}
			get{return _logindate;}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime? UpdateDate
		{
			set{ _updatedate=value;}
			get{return _updatedate;}
		}
		/// <summary>
		/// 登录IP
		/// </summary>
		public string LoginIP
		{
			set{ _loginip=value;}
			get{return _loginip;}
		}
		/// <summary>
		/// 登录端口
		/// </summary>
		public int? LoginPort
		{
			set{ _loginport=value;}
			get{return _loginport;}
		}
		/// <summary>
		/// 终端状态(0-离线；1-在线)
		/// </summary>
		public int? Mark
		{
			set{ _mark=value;}
			get{return _mark;}
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
		/// 集中器版本
		/// </summary>
		public string CollectorVer
		{
			set{ _collectorver=value;}
			get{return _collectorver;}
		}
		/// <summary>
		/// 集中器型号
		/// </summary>
		public string CollectorModel
		{
			set{ _collectormodel=value;}
			get{return _collectormodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CollectorAPN
		{
			set{ _collectorapn=value;}
			get{return _collectorapn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsServerMode
		{
			set{ _isservermode=value;}
			get{return _isservermode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkTime
		{
			set{ _worktime=value;}
			get{return _worktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NetWorkTime
		{
			set{ _networktime=value;}
			get{return _networktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FactoryCode
		{
			set{ _factorycode=value;}
			get{return _factorycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FramesType
		{
			set{ _framestype=value;}
			get{return _framestype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MeterAddrFormat
		{
			set{ _meteraddrformat=value;}
			get{return _meteraddrformat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GprsPhone
		{
			set{ _gprsphone=value;}
			get{return _gprsphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExpireTime
		{
			set{ _expiretime=value;}
			get{return _expiretime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WorkMode
		{
			set{ _workmode=value;}
			get{return _workmode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Lng
		{
			set{ _lng=value;}
			get{return _lng;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Lat
		{
			set{ _lat=value;}
			get{return _lat;}
		}
		#endregion Model

	}
}

