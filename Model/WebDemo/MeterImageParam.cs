using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MeterImageParam:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MeterImageParam
	{
		public MeterImageParam()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private int _camerano;
		private int _numbercount;
		private int _capturestartpixs;
		private int _upclippixs;
		private int _downclippixs;
		private int _leftclippixs;
		private int _rightclippixs;
		private int _circumgyratedegree;
		private int _inclinedegree;
		private int _modelheight;
		private int _modelwidth;
		private int _modelonewidth;
		private int _numberspace;
		private int _bitvaluelimen;
		private int _bitvalueradius;
		private int _bitvalueblackproportion;
		private int _morphologicfilterparam;
		private int _searchlimitparam;
		private int _windowheight;
		private DateTime _lastoperdate= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MeterId
		{
			set{ _meterid=value;}
			get{return _meterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CameraNo
		{
			set{ _camerano=value;}
			get{return _camerano;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NumberCount
		{
			set{ _numbercount=value;}
			get{return _numbercount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CaptureStartPixs
		{
			set{ _capturestartpixs=value;}
			get{return _capturestartpixs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UpClipPixs
		{
			set{ _upclippixs=value;}
			get{return _upclippixs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DownClipPixs
		{
			set{ _downclippixs=value;}
			get{return _downclippixs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int LeftClipPixs
		{
			set{ _leftclippixs=value;}
			get{return _leftclippixs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RightClipPixs
		{
			set{ _rightclippixs=value;}
			get{return _rightclippixs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CircumgyrateDegree
		{
			set{ _circumgyratedegree=value;}
			get{return _circumgyratedegree;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int InclineDegree
		{
			set{ _inclinedegree=value;}
			get{return _inclinedegree;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ModelHeight
		{
			set{ _modelheight=value;}
			get{return _modelheight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ModelWidth
		{
			set{ _modelwidth=value;}
			get{return _modelwidth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ModelOneWidth
		{
			set{ _modelonewidth=value;}
			get{return _modelonewidth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NumberSpace
		{
			set{ _numberspace=value;}
			get{return _numberspace;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BitValueLimen
		{
			set{ _bitvaluelimen=value;}
			get{return _bitvaluelimen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BitValueRadius
		{
			set{ _bitvalueradius=value;}
			get{return _bitvalueradius;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int BitValueBlackProportion
		{
			set{ _bitvalueblackproportion=value;}
			get{return _bitvalueblackproportion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MorphologicFilterParam
		{
			set{ _morphologicfilterparam=value;}
			get{return _morphologicfilterparam;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SearchlimitParam
		{
			set{ _searchlimitparam=value;}
			get{return _searchlimitparam;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WindowHeight
		{
			set{ _windowheight=value;}
			get{return _windowheight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LastOperDate
		{
			set{ _lastoperdate=value;}
			get{return _lastoperdate;}
		}
		#endregion Model

	}
}

