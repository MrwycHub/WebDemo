using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// InvoiceChangeLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InvoiceChangeLog
	{
		public InvoiceChangeLog()
		{}
		#region Model
		private int _id;
		private string _invoicenum;
		private string _oldoperator;
		private string _newoperator;
		private DateTime _changedate;
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
		public string InvoiceNum
		{
			set{ _invoicenum=value;}
			get{return _invoicenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OldOperator
		{
			set{ _oldoperator=value;}
			get{return _oldoperator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewOperator
		{
			set{ _newoperator=value;}
			get{return _newoperator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ChangeDate
		{
			set{ _changedate=value;}
			get{return _changedate;}
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

