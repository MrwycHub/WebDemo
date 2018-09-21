using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// LocationInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LocationInfo
	{
		public LocationInfo()
		{}
		#region Model
		private int _id;
		private int _operatorid;
		private DateTime _datetime= DateTime.Now;
		private decimal _locationx;
		private decimal _locationy;
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
		public int OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime DateTime
		{
			set{ _datetime=value;}
			get{return _datetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal LocationX
		{
			set{ _locationx=value;}
			get{return _locationx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal LocationY
		{
			set{ _locationy=value;}
			get{return _locationy;}
		}
		#endregion Model

	}
}

