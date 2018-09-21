using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Workers:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Workers
	{
		public Workers()
		{}
		#region Model
		private int _workerid;
		private string _workername;
		private string _workerphone;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int WorkerID
		{
			set{ _workerid=value;}
			get{return _workerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkerName
		{
			set{ _workername=value;}
			get{return _workername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkerPhone
		{
			set{ _workerphone=value;}
			get{return _workerphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

