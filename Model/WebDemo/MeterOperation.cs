using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MeterOperation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MeterOperation
	{
		public MeterOperation()
		{}
		#region Model
		private int _operid;
		private string _opertype;
		private DateTime _operdate;
		private int _meteridold;
		private int _meteridnew;
		private decimal? _usenumberold;
		private int? _statflag=0;
		/// <summary>
		/// 业务编号
		/// </summary>
		public int OperID
		{
			set{ _operid=value;}
			get{return _operid;}
		}
		/// <summary>
		/// 业务类型
		/// </summary>
		public string OperType
		{
			set{ _opertype=value;}
			get{return _opertype;}
		}
		/// <summary>
		/// 业务日期
		/// </summary>
		public DateTime OperDate
		{
			set{ _operdate=value;}
			get{return _operdate;}
		}
		/// <summary>
		/// 老表ID
		/// </summary>
		public int MeterIDOld
		{
			set{ _meteridold=value;}
			get{return _meteridold;}
		}
		/// <summary>
		/// 新表ID
		/// </summary>
		public int MeterIDNew
		{
			set{ _meteridnew=value;}
			get{return _meteridnew;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? UseNumberOld
		{
			set{ _usenumberold=value;}
			get{return _usenumberold;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StatFlag
		{
			set{ _statflag=value;}
			get{return _statflag;}
		}
		#endregion Model

	}
}

