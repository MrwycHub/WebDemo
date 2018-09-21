using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// TaskPlanLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TaskPlanLog
	{
		public TaskPlanLog()
		{}
		#region Model
		private int _id;
		private int? _taskid;
		private int? _collectorid;
		private string _meteraddr;
		private int? _metertype;
		private int? _exemark;
		private DateTime? _exedate;
		private string _exeinfo;
		private DateTime _insdate= DateTime.Now;
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
		public int? TaskID
		{
			set{ _taskid=value;}
			get{return _taskid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CollectorID
		{
			set{ _collectorid=value;}
			get{return _collectorid;}
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
		public int? ExeMark
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
		public string ExeInfo
		{
			set{ _exeinfo=value;}
			get{return _exeinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime InsDate
		{
			set{ _insdate=value;}
			get{return _insdate;}
		}
		#endregion Model

	}
}

