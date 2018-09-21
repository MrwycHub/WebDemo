using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// RateTimeZone:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RateTimeZone
	{
		public RateTimeZone()
		{}
		#region Model
		private int _suiteno;
		private int _timezoneno;
		private DateTime _begindate;
		private int _groupperiodno=1;
		/// <summary>
		/// 
		/// </summary>
		public int SuiteNo
		{
			set{ _suiteno=value;}
			get{return _suiteno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TimeZoneNo
		{
			set{ _timezoneno=value;}
			get{return _timezoneno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BeginDate
		{
			set{ _begindate=value;}
			get{return _begindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int GroupPeriodNo
		{
			set{ _groupperiodno=value;}
			get{return _groupperiodno;}
		}
		#endregion Model

	}
}

