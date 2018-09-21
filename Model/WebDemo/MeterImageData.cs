using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MeterImageData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MeterImageData
	{
		public MeterImageData()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private DateTime _readtime;
		private decimal _voltage;
		private int _valvestate;
		private bool _lowvoltage;
		private bool _magneticdisturb;
		private int _imagequality;
		private bool _enableupload;
		private byte[] _meterimage;
		private DateTime _insertdate;
		private decimal? _freezenumber;
		private byte[] _leftmeterimage;
		private byte[] _rightmeterimage;
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
		public int MeterID
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ReadTime
		{
			set{ _readtime=value;}
			get{return _readtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Voltage
		{
			set{ _voltage=value;}
			get{return _voltage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ValveState
		{
			set{ _valvestate=value;}
			get{return _valvestate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool LowVoltage
		{
			set{ _lowvoltage=value;}
			get{return _lowvoltage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool MagneticDisturb
		{
			set{ _magneticdisturb=value;}
			get{return _magneticdisturb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ImageQuality
		{
			set{ _imagequality=value;}
			get{return _imagequality;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool EnableUpload
		{
			set{ _enableupload=value;}
			get{return _enableupload;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] MeterImage
		{
			set{ _meterimage=value;}
			get{return _meterimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime InsertDate
		{
			set{ _insertdate=value;}
			get{return _insertdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FreezeNumber
		{
			set{ _freezenumber=value;}
			get{return _freezenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] LeftMeterImage
		{
			set{ _leftmeterimage=value;}
			get{return _leftmeterimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] RightMeterImage
		{
			set{ _rightmeterimage=value;}
			get{return _rightmeterimage;}
		}
		#endregion Model

	}
}

