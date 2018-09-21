using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// AdjustPriceLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AdjustPriceLog
	{
		public AdjustPriceLog()
		{}
		#region Model
		private int _id;
		private int _pricetypeid;
		private DateTime _exedate;
		private int _mark=0;
		private int _divid1=0;
		private int _divid2=0;
		private int _divid3=0;
		private int _divid4=0;
		private int _divid5=0;
		private int _fareid;
		private string _faretypename;
		private decimal? _price;
		private decimal? _price2;
		private decimal? _price3;
		private decimal? _price4;
		private decimal? _price5;
		private decimal? _price6;
		private int? _fareno;
		private string _remark;
		private string _prefaretypename;
		private decimal? _preprice;
		private decimal? _preprice2;
		private decimal? _preprice3;
		private decimal? _preprice4;
		private decimal? _preprice5;
		private decimal? _preprice6;
		private int? _prefareno;
		private string _preremark;
		private int? _setno=1;
		private int? _freezeday=28;
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
		public int PriceTypeID
		{
			set{ _pricetypeid=value;}
			get{return _pricetypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ExeDate
		{
			set{ _exedate=value;}
			get{return _exedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Mark
		{
			set{ _mark=value;}
			get{return _mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Divid1
		{
			set{ _divid1=value;}
			get{return _divid1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Divid2
		{
			set{ _divid2=value;}
			get{return _divid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Divid3
		{
			set{ _divid3=value;}
			get{return _divid3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Divid4
		{
			set{ _divid4=value;}
			get{return _divid4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Divid5
		{
			set{ _divid5=value;}
			get{return _divid5;}
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
		/// 
		/// </summary>
		public string FareTypeName
		{
			set{ _faretypename=value;}
			get{return _faretypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price2
		{
			set{ _price2=value;}
			get{return _price2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price3
		{
			set{ _price3=value;}
			get{return _price3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price4
		{
			set{ _price4=value;}
			get{return _price4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price5
		{
			set{ _price5=value;}
			get{return _price5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price6
		{
			set{ _price6=value;}
			get{return _price6;}
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
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PreFareTypeName
		{
			set{ _prefaretypename=value;}
			get{return _prefaretypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PrePrice
		{
			set{ _preprice=value;}
			get{return _preprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PrePrice2
		{
			set{ _preprice2=value;}
			get{return _preprice2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PrePrice3
		{
			set{ _preprice3=value;}
			get{return _preprice3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PrePrice4
		{
			set{ _preprice4=value;}
			get{return _preprice4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PrePrice5
		{
			set{ _preprice5=value;}
			get{return _preprice5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PrePrice6
		{
			set{ _preprice6=value;}
			get{return _preprice6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PreFareNo
		{
			set{ _prefareno=value;}
			get{return _prefareno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PreRemark
		{
			set{ _preremark=value;}
			get{return _preremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SetNo
		{
			set{ _setno=value;}
			get{return _setno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FreezeDay
		{
			set{ _freezeday=value;}
			get{return _freezeday;}
		}
		#endregion Model

	}
}

