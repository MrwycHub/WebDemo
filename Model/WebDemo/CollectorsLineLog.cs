using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// CollectorsLineLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CollectorsLineLog
	{
		public CollectorsLineLog()
		{}
		#region Model
		private int _id;
		private int _collectorid;
		private int _linetype;
		private DateTime _opertime= DateTime.Now;
		private string _remark;
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
		public int CollectorID
		{
			set{ _collectorid=value;}
			get{return _collectorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LineType
		{
			set{ _linetype=value;}
			get{return _linetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OperTime
		{
			set{ _opertime=value;}
			get{return _opertime;}
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

