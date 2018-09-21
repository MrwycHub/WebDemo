using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MeterImageCutArea:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MeterImageCutArea
	{
		public MeterImageCutArea()
		{}
		#region Model
		private int _id;
		private int _meterid;
		private int _camerano;
		private int _cutlocationx;
		private int _cutlocationy;
		private int _cutwidth;
		private int _cutheight;
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
		public int CutLocationX
		{
			set{ _cutlocationx=value;}
			get{return _cutlocationx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CutLocationY
		{
			set{ _cutlocationy=value;}
			get{return _cutlocationy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CutWidth
		{
			set{ _cutwidth=value;}
			get{return _cutwidth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CutHeight
		{
			set{ _cutheight=value;}
			get{return _cutheight;}
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

