using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// InvoiceDistributeLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InvoiceDistributeLog
	{
		public InvoiceDistributeLog()
		{}
		#region Model
		private int _disid;
		private int? _batchid;
		private string _incode;
		private string _startnum;
		private string _endnum;
		private int? _operatorid;
		private DateTime? _assigndate;
		private string _assignoperator;
		private int? _state;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int DisId
		{
			set{ _disid=value;}
			get{return _disid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BatchId
		{
			set{ _batchid=value;}
			get{return _batchid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InCode
		{
			set{ _incode=value;}
			get{return _incode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartNum
		{
			set{ _startnum=value;}
			get{return _startnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndNum
		{
			set{ _endnum=value;}
			get{return _endnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AssignDate
		{
			set{ _assigndate=value;}
			get{return _assigndate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AssignOperator
		{
			set{ _assignoperator=value;}
			get{return _assignoperator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? State
		{
			set{ _state=value;}
			get{return _state;}
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

