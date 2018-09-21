using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// InvoiceLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InvoiceLog
	{
		public InvoiceLog()
		{}
		#region Model
		private int _invoiceid;
		private int? _invoicecode;
		/// <summary>
		/// 
		/// </summary>
		public int InvoiceID
		{
			set{ _invoiceid=value;}
			get{return _invoiceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InvoiceCode
		{
			set{ _invoicecode=value;}
			get{return _invoicecode;}
		}
		#endregion Model

	}
}

