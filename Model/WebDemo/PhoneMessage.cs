using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// PhoneMessage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PhoneMessage
	{
		public PhoneMessage()
		{}
		#region Model
		private int _id;
		private string _softname;
		private string _brands;
		private string _model;
		private string _version;
		private string _bluetoothver;
		private string _sdkver;
		private string _imei;
		private string _cpu;
		private string _memory;
		private string _resolution;
		private DateTime _firstlogindate= DateTime.Now;
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
		public string SoftName
		{
			set{ _softname=value;}
			get{return _softname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Brands
		{
			set{ _brands=value;}
			get{return _brands;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Version
		{
			set{ _version=value;}
			get{return _version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BlueToothVer
		{
			set{ _bluetoothver=value;}
			get{return _bluetoothver;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SDKVer
		{
			set{ _sdkver=value;}
			get{return _sdkver;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IMEI
		{
			set{ _imei=value;}
			get{return _imei;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CPU
		{
			set{ _cpu=value;}
			get{return _cpu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Memory
		{
			set{ _memory=value;}
			get{return _memory;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Resolution
		{
			set{ _resolution=value;}
			get{return _resolution;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime FirstLoginDate
		{
			set{ _firstlogindate=value;}
			get{return _firstlogindate;}
		}
		#endregion Model

	}
}

