using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// InvoiceHand:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InvoiceHand
	{
		public InvoiceHand()
		{}
		#region Model
		private int _operid;
		private string _spname;
		private string _spunit;
		private decimal? _spnum;
		private decimal? _spprice;
		private decimal? _spmoney;
		private string _remark;
		private int? _inid;
		/// <summary>
		/// 
		/// </summary>
		public int OperID
		{
			set{ _operid=value;}
			get{return _operid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string spName
		{
			set{ _spname=value;}
			get{return _spname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string spUnit
		{
			set{ _spunit=value;}
			get{return _spunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? spNum
		{
			set{ _spnum=value;}
			get{return _spnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? spPrice
		{
			set{ _spprice=value;}
			get{return _spprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? spMoney
		{
			set{ _spmoney=value;}
			get{return _spmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InID
		{
			set{ _inid=value;}
			get{return _inid;}
		}
		#endregion Model

	}
}

