using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// OrderMessage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderMessage
	{
		public OrderMessage()
		{}
		#region Model
		private int _id;
		private string _out_trade_no;
		private string _transactionid;
		private decimal? _total_amount;
		private int _status=1;
		private DateTime _createdate= DateTime.Now;
		private DateTime? _finishdate;
		private int? _payway;
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
		public string out_trade_no
		{
			set{ _out_trade_no=value;}
			get{return _out_trade_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TransactionId
		{
			set{ _transactionid=value;}
			get{return _transactionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? total_amount
		{
			set{ _total_amount=value;}
			get{return _total_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? FinishDate
		{
			set{ _finishdate=value;}
			get{return _finishdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PayWay
		{
			set{ _payway=value;}
			get{return _payway;}
		}
		#endregion Model

	}
}

