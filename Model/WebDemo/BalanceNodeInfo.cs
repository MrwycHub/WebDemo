using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// BalanceNodeInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BalanceNodeInfo
	{
		public BalanceNodeInfo()
		{}
		#region Model
		private int _id;
		private int _operatorid;
		private DateTime _begindate;
		private DateTime _enddate;
		private decimal? _factmoney;
		private int? _paycount;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OperatorId
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
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
		public DateTime EndDate
		{
			set{ _enddate=value;}
			get{return _enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FactMoney
		{
			set{ _factmoney=value;}
			get{return _factmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PayCount
		{
			set{ _paycount=value;}
			get{return _paycount;}
		}
		#endregion Model

	}
}

