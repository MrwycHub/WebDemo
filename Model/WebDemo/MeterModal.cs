using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MeterModal:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MeterModal
	{
		public MeterModal()
		{}
		#region Model
		private int _modalid;
		private string _modalname;
		private string _remark;
		private int? _useprotocol=1;
		private string _factorycode;
		private string _factoryname;
		private int? _maxvalue=9999;
		private int? _maxyear=10;
		private string _caliber= "0";
		private decimal? _maxflow=1M;
		private int? _meterheadertype=0;
		private string _meterstatuscode;
		/// <summary>
		/// 型号编号
		/// </summary>
		public int Modalid
		{
			set{ _modalid=value;}
			get{return _modalid;}
		}
		/// <summary>
		/// 型号名称
		/// </summary>
		public string Modalname
		{
			set{ _modalname=value;}
			get{return _modalname;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UseProtocol
		{
			set{ _useprotocol=value;}
			get{return _useprotocol;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FactoryCode
		{
			set{ _factorycode=value;}
			get{return _factorycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FactoryName
		{
			set{ _factoryname=value;}
			get{return _factoryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MaxValue
		{
			set{ _maxvalue=value;}
			get{return _maxvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MaxYear
		{
			set{ _maxyear=value;}
			get{return _maxyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Caliber
		{
			set{ _caliber=value;}
			get{return _caliber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MaxFlow
		{
			set{ _maxflow=value;}
			get{return _maxflow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MeterHeaderType
		{
			set{ _meterheadertype=value;}
			get{return _meterheadertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MeterStatusCode
		{
			set{ _meterstatuscode=value;}
			get{return _meterstatuscode;}
		}
		#endregion Model

	}
}

