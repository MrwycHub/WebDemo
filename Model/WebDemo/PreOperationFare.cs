using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// PreOperationFare:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PreOperationFare
	{
		public PreOperationFare()
		{}
		#region Model
		private int _operid;
		private int _fareid;
		private string _faretypename;
		private decimal _fareprice;
		private decimal? _faremoney;
		private decimal? _faremoney1;
		private decimal? _fareprice2;
		private decimal? _faremoney2;
		private decimal? _fareprice3;
		private decimal? _faremoney3;
		private decimal _taxrate=0M;
		/// <summary>
		/// 业务编号
		/// </summary>
		public int OperID
		{
			set{ _operid=value;}
			get{return _operid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FareID
		{
			set{ _fareid=value;}
			get{return _fareid;}
		}
		/// <summary>
		/// 费用名称
		/// </summary>
		public string FareTypeName
		{
			set{ _faretypename=value;}
			get{return _faretypename;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal FarePrice
		{
			set{ _fareprice=value;}
			get{return _fareprice;}
		}
		/// <summary>
		/// 金额
		/// </summary>
		public decimal? FareMoney
		{
			set{ _faremoney=value;}
			get{return _faremoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FareMoney1
		{
			set{ _faremoney1=value;}
			get{return _faremoney1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FarePrice2
		{
			set{ _fareprice2=value;}
			get{return _fareprice2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FareMoney2
		{
			set{ _faremoney2=value;}
			get{return _faremoney2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FarePrice3
		{
			set{ _fareprice3=value;}
			get{return _fareprice3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FareMoney3
		{
			set{ _faremoney3=value;}
			get{return _faremoney3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal TaxRate
		{
			set{ _taxrate=value;}
			get{return _taxrate;}
		}
		#endregion Model

	}
}

