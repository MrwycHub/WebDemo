using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// PriceFare:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PriceFare
	{
		public PriceFare()
		{}
		#region Model
		private int _fareid;
		private int _pricetypeid;
		private string _faretypename;
		private decimal _price=0M;
		private decimal _price2=0M;
		private decimal _price3=0M;
		private int? _fareno;
		private string _remark;
		private decimal _price4=0M;
		private decimal _price5=0M;
		private decimal _price6=0M;
		private decimal _taxrate=0M;
		private string _projectname;
		/// <summary>
		/// 
		/// </summary>
		public int FareID
		{
			set{ _fareid=value;}
			get{return _fareid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PriceTypeID
		{
			set{ _pricetypeid=value;}
			get{return _pricetypeid;}
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
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price2
		{
			set{ _price2=value;}
			get{return _price2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price3
		{
			set{ _price3=value;}
			get{return _price3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FareNo
		{
			set{ _fareno=value;}
			get{return _fareno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReMark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price4
		{
			set{ _price4=value;}
			get{return _price4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price5
		{
			set{ _price5=value;}
			get{return _price5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Price6
		{
			set{ _price6=value;}
			get{return _price6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal TaxRate
		{
			set{ _taxrate=value;}
			get{return _taxrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProjectName
		{
			set{ _projectname=value;}
			get{return _projectname;}
		}
		#endregion Model

	}
}

