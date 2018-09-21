using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// TaskPlanHistory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TaskPlanHistory
	{
		public TaskPlanHistory()
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
		private int? _meteritem;
		private string _freezedate;
		private int? _taskmonth;
		private int _taskday;
		private int _taskhour;
		private int _taskminute;
		private int _exemark;
		private DateTime? _exedate;
		private int _exeerror;
		private int _taskmark;
		private int _tasktype;
		private int? _taskerror;
		private int _trynum;
		private string _hostaddr;
		private DateTime? _insdate;
		private int? _meterid;
		private int _taskfrequency;
		private string _exeinfo;
		private int? _operatorid;
		private string _deptid;
		private int? _taskweek;
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
		public int TaskID
		{
			set{ _taskid=value;}
			get{return _taskid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CollectorID
		{
			set{ _collectorid=value;}
			get{return _collectorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TaskName
		{
			set{ _taskname=value;}
			get{return _taskname;}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public int? MeterItem
		{
			set{ _meteritem=value;}
			get{return _meteritem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FreezeDate
		{
			set{ _freezedate=value;}
			get{return _freezedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TaskMonth
		{
			set{ _taskmonth=value;}
			get{return _taskmonth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TaskDay
		{
			set{ _taskday=value;}
			get{return _taskday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TaskHour
		{
			set{ _taskhour=value;}
			get{return _taskhour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TaskMinute
		{
			set{ _taskminute=value;}
			get{return _taskminute;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ExeMark
		{
			set{ _exemark=value;}
			get{return _exemark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ExeDate
		{
			set{ _exedate=value;}
			get{return _exedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ExeError
		{
			set{ _exeerror=value;}
			get{return _exeerror;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TaskMark
		{
			set{ _taskmark=value;}
			get{return _taskmark;}
		}
		/// <summary>
		/// 
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
		/// 
		/// </summary>
		public int TryNum
		{
			set{ _trynum=value;}
			get{return _trynum;}
		}
		/// <summary>
		/// 
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
		/// 
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
		#endregion Model

	}
}

