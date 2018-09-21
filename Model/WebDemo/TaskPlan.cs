using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// TaskPlan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TaskPlan
	{
		public TaskPlan()
		{}
		#region Model
		private int _id;
		private int _taskid;
		private int _collectorid;
		private string _taskname;
		private int _commandid;
		private string _commandinfo;
		private string _meteraddr;
		private int? _metertype;
		private int? _meteritem=1;
		private string _freezedate;
		private int? _taskmonth;
		private int _taskday;
		private int _taskhour;
		private int _taskminute;
		private int _exemark;
		private DateTime? _exedate;
		private int _exeerror=0;
		private int _taskmark=1;
		private int _tasktype=2;
		private int? _taskerror=0;
		private int _trynum=3;
		private string _hostaddr;
		private DateTime? _insdate;
		private int? _meterid;
		private int _taskfrequency=0;
		private string _exeinfo;
		private int? _operatorid=0;
		private string _deptid;
		private int? _taskweek;
		private int? _pricetypeid=0;
		private int _serverid=1;
		private int _exetype=1;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 任务编号
		/// </summary>
		public int TaskID
		{
			set{ _taskid=value;}
			get{return _taskid;}
		}
		/// <summary>
		/// 集中器编号
		/// </summary>
		public int CollectorID
		{
			set{ _collectorid=value;}
			get{return _collectorid;}
		}
		/// <summary>
		/// 任务名称
		/// </summary>
		public string TaskName
		{
			set{ _taskname=value;}
			get{return _taskname;}
		}
		/// <summary>
		/// 指令编号
		/// </summary>
		public int CommandID
		{
			set{ _commandid=value;}
			get{return _commandid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommandInfo
		{
			set{ _commandinfo=value;}
			get{return _commandinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MeterAddr
		{
			set{ _meteraddr=value;}
			get{return _meteraddr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MeterType
		{
			set{ _metertype=value;}
			get{return _metertype;}
		}
		/// <summary>
		/// 抄表数据项
		/// </summary>
		public int? MeterItem
		{
			set{ _meteritem=value;}
			get{return _meteritem;}
		}
		/// <summary>
		/// 冻结日
		/// </summary>
		public string FreezeDate
		{
			set{ _freezedate=value;}
			get{return _freezedate;}
		}
		/// <summary>
		/// 执行月份(0表示每个月)
		/// </summary>
		public int? TaskMonth
		{
			set{ _taskmonth=value;}
			get{return _taskmonth;}
		}
		/// <summary>
		/// 执行日期(0表示每天)
		/// </summary>
		public int TaskDay
		{
			set{ _taskday=value;}
			get{return _taskday;}
		}
		/// <summary>
		/// 执行时
		/// </summary>
		public int TaskHour
		{
			set{ _taskhour=value;}
			get{return _taskhour;}
		}
		/// <summary>
		/// 执行分
		/// </summary>
		public int TaskMinute
		{
			set{ _taskminute=value;}
			get{return _taskminute;}
		}
		/// <summary>
		/// 执行标志(1-未执行；2-已执行；3-执行失败)
		/// </summary>
		public int ExeMark
		{
			set{ _exemark=value;}
			get{return _exemark;}
		}
		/// <summary>
		/// 执行时间
		/// </summary>
		public DateTime? ExeDate
		{
			set{ _exedate=value;}
			get{return _exedate;}
		}
		/// <summary>
		/// 重试次数
		/// </summary>
		public int ExeError
		{
			set{ _exeerror=value;}
			get{return _exeerror;}
		}
		/// <summary>
		/// 启动任务(1-启动 2 不启动)
		/// </summary>
		public int TaskMark
		{
			set{ _taskmark=value;}
			get{return _taskmark;}
		}
		/// <summary>
		/// 任务类型
		/// </summary>
		public int TaskType
		{
			set{ _tasktype=value;}
			get{return _tasktype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TaskError
		{
			set{ _taskerror=value;}
			get{return _taskerror;}
		}
		/// <summary>
		/// 重试次数
		/// </summary>
		public int TryNum
		{
			set{ _trynum=value;}
			get{return _trynum;}
		}
		/// <summary>
		/// 采集器地址
		/// </summary>
		public string HostAddr
		{
			set{ _hostaddr=value;}
			get{return _hostaddr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InsDate
		{
			set{ _insdate=value;}
			get{return _insdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 任务类型
		/// </summary>
		public int TaskFrequency
		{
			set{ _taskfrequency=value;}
			get{return _taskfrequency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExeInfo
		{
			set{ _exeinfo=value;}
			get{return _exeinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptID
		{
			set{ _deptid=value;}
			get{return _deptid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TaskWeek
		{
			set{ _taskweek=value;}
			get{return _taskweek;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PriceTypeID
		{
			set{ _pricetypeid=value;}
			get{return _pricetypeid;}
		}
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
		public int ExeType
		{
			set{ _exetype=value;}
			get{return _exetype;}
		}
		#endregion Model

	}
}

