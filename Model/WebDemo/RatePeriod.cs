using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// RatePeriod:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RatePeriod
	{
		public RatePeriod()
		{}
		#region Model
		private int _suiteno;
		private int _groupperiodno;
		private int _periodno;
		private DateTime _begintime;
		private int _farerateno=1;
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
		public int GroupPeriodNo
		{
			set{ _groupperiodno=value;}
			get{return _groupperiodno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PeriodNo
		{
			set{ _periodno=value;}
			get{return _periodno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime BeginTime
		{
			set{ _begintime=value;}
			get{return _begintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FareRateNo
		{
			set{ _farerateno=value;}
			get{return _farerateno;}
		}
		#endregion Model

	}
}

