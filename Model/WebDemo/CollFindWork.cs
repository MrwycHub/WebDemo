using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// CollFindWork:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CollFindWork
	{
		public CollFindWork()
		{}
		#region Model
		private int _collectorid;
		private int _workid;
		private int? _worktime;
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
		public int WorkID
		{
			set{ _workid=value;}
			get{return _workid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WorkTime
		{
			set{ _worktime=value;}
			get{return _worktime;}
		}
		#endregion Model

	}
}

