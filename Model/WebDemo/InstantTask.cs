using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// InstantTask:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InstantTask
	{
		public InstantTask()
		{}
		#region Model
		private int _taskid;
		private string _tasktype;
		private int? _collectorid;
		private int? _metertype;
		private string _meteraddr;
		private string _hostaddr;
		private int? _meterstatus;
		private int? _meterdata;
		private string _paymoney;
		private string _totalpaymoney;
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
		public string TaskType
		{
			set{ _tasktype=value;}
			get{return _tasktype;}
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
		public int? MeterType
		{
			set{ _metertype=value;}
			get{return _metertype;}
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
		public string HostAddr
		{
			set{ _hostaddr=value;}
			get{return _hostaddr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MeterStatus
		{
			set{ _meterstatus=value;}
			get{return _meterstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MeterData
		{
			set{ _meterdata=value;}
			get{return _meterdata;}
		}
		/// <summary>
		/// 本次购买量
		/// </summary>
		public string PayMoney
		{
			set{ _paymoney=value;}
			get{return _paymoney;}
		}
		/// <summary>
		/// 总量
		/// </summary>
		public string TotalPayMoney
		{
			set{ _totalpaymoney=value;}
			get{return _totalpaymoney;}
		}
		#endregion Model

	}
}

