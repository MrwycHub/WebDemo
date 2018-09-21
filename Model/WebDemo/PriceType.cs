using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// PriceType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PriceType
	{
		public PriceType()
		{}
		#region Model
		private int _pricetypeid;
		private string _pricetypename;
		private int _metertypeid;
		private int _priceno=0;
		private decimal _price=0M;
		private decimal _price2=0M;
		private decimal _price3=0M;
		private int _divid1=0;
		private int _divid2=0;
		private string _priceunit;
		private string _remark;
		private decimal _price4=0M;
		private decimal _price5=0M;
		private decimal _price6=0M;
		private int _divid3=0;
		private int _divid4=0;
		private int _divid5=0;
		private DateTime _exedate= DateTime.Now;
		private int? _setno=1;
		private int? _suiteno=1;
		private int? _grouppriceno=1;
		private string _pricetypecode;
		private int? _isstartstar;
		private int? _isstartpeople;
		private int? _peoplecheck;
		private int? _maxpeople;
		private decimal? _addusenumber;
		private int? _starslevel;
		private int? _starsperiod;
		private int? _starscorrected;
		private int? _isstartarea;
		private decimal? _coefficient;
		private int? _calculateday;
		private int? _starsareaway;
		private int? _starsbyuser;
		/// <summary>
		/// 价格编号
		/// </summary>
		public int PriceTypeID
		{
			set{ _pricetypeid=value;}
			get{return _pricetypeid;}
		}
		/// <summary>
		/// 价格名称
		/// </summary>
		public string PriceTypeName
		{
			set{ _pricetypename=value;}
			get{return _pricetypename;}
		}
		/// <summary>
		/// 表类型编号
		/// </summary>
		public int MeterTypeID
		{
			set{ _metertypeid=value;}
			get{return _metertypeid;}
		}
		/// <summary>
		/// 程序控制，最大加一
		/// </summary>
		public int PriceNo
		{
			set{ _priceno=value;}
			get{return _priceno;}
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
		/// 单价2
		/// </summary>
		public decimal Price2
		{
			set{ _price2=value;}
			get{return _price2;}
		}
		/// <summary>
		/// 单价3
		/// </summary>
		public decimal Price3
		{
			set{ _price3=value;}
			get{return _price3;}
		}
		/// <summary>
		/// 分界点1
		/// </summary>
		public int Divid1
		{
			set{ _divid1=value;}
			get{return _divid1;}
		}
		/// <summary>
		/// 分界点2
		/// </summary>
		public int Divid2
		{
			set{ _divid2=value;}
			get{return _divid2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PriceUnit
		{
			set{ _priceunit=value;}
			get{return _priceunit;}
		}
		/// <summary>
		/// 备注信息
		/// </summary>
		public string Remark
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
		public DateTime ExeDate
		{
			set{ _exedate=value;}
			get{return _exedate;}
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
		public int? SuiteNo
		{
			set{ _suiteno=value;}
			get{return _suiteno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GroupPriceNo
		{
			set{ _grouppriceno=value;}
			get{return _grouppriceno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PriceTypeCode
		{
			set{ _pricetypecode=value;}
			get{return _pricetypecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsStartStar
		{
			set{ _isstartstar=value;}
			get{return _isstartstar;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsStartPeople
		{
			set{ _isstartpeople=value;}
			get{return _isstartpeople;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PeopleCheck
		{
			set{ _peoplecheck=value;}
			get{return _peoplecheck;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MaxPeople
		{
			set{ _maxpeople=value;}
			get{return _maxpeople;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AddUseNumber
		{
			set{ _addusenumber=value;}
			get{return _addusenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StarsLevel
		{
			set{ _starslevel=value;}
			get{return _starslevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StarsPeriod
		{
			set{ _starsperiod=value;}
			get{return _starsperiod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StarsCorrected
		{
			set{ _starscorrected=value;}
			get{return _starscorrected;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsStartArea
		{
			set{ _isstartarea=value;}
			get{return _isstartarea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Coefficient
		{
			set{ _coefficient=value;}
			get{return _coefficient;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CalculateDay
		{
			set{ _calculateday=value;}
			get{return _calculateday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StarsAreaWay
		{
			set{ _starsareaway=value;}
			get{return _starsareaway;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? StarsByUser
		{
			set{ _starsbyuser=value;}
			get{return _starsbyuser;}
		}
		#endregion Model

	}
}

