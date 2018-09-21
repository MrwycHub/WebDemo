using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// BlockUpInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BlockUpInfo
	{
		public BlockUpInfo()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private int _stopyear;
		private DateTime? _operdate;
		private string _stopreason;
		private int _operatorid;
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
		public int MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int StopYear
		{
			set{ _stopyear=value;}
			get{return _stopyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OperDate
		{
			set{ _operdate=value;}
			get{return _operdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StopReason
		{
			set{ _stopreason=value;}
			get{return _stopreason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		#endregion Model

	}
}

