using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ParentMeter:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ParentMeter
	{
		public ParentMeter()
		{}
		#region Model
		private int _meterid;
		private int _parentid;
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
		public int ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		#endregion Model

	}
}

