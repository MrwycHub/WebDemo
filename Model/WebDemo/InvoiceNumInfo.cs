using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// InvoiceNumInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InvoiceNumInfo
	{
		public InvoiceNumInfo()
		{}
		#region Model
		private int _id;
		private int? _disid;
		private int? _batchid;
		private string _incode;
		private string _invoicenum;
		private string _ordernum;
		private int? _mark;
		private int? _subflag=0;
		private int? _operatorid;
		private string _assignoperator;
		private DateTime? _assigndate= DateTime.Now;
		private DateTime? _operdate;
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
		public int? DisId
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
		public string InvoiceNum
		{
			set{ _invoicenum=value;}
			get{return _invoicenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderNum
		{
			set{ _ordernum=value;}
			get{return _ordernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Mark
		{
			set{ _mark=value;}
			get{return _mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SubFlag
		{
			set{ _subflag=value;}
			get{return _subflag;}
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
		public string AssignOperator
		{
			set{ _assignoperator=value;}
			get{return _assignoperator;}
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
		public DateTime? OperDate
		{
			set{ _operdate=value;}
			get{return _operdate;}
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

