using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// CollectorWork:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CollectorWork
	{
		public CollectorWork()
		{}
		#region Model
		private int _collectorid;
		private int _workid;
		private int? _worktime=0;
		/// <summary>
		/// 集中器ID
		/// </summary>
		public int CollectorID
		{
			set{ _collectorid=value;}
			get{return _collectorid;}
		}
		/// <summary>
		/// 工作时段
		/// </summary>
		public int WorkID
		{
			set{ _workid=value;}
			get{return _workid;}
		}
		/// <summary>
		/// 时段区间
		/// </summary>
		public int? WorkTime
		{
			set{ _worktime=value;}
			get{return _worktime;}
		}
		#endregion Model

	}
}

