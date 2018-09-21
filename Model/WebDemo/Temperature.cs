using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Temperature:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Temperature
	{
		public Temperature()
		{}
		#region Model
		private decimal _centigrade;
		private decimal _density=0M;
		private decimal _enthalpy=0M;
		/// <summary>
		/// 
		/// </summary>
		public decimal Centigrade
		{
			set{ _centigrade=value;}
			get{return _centigrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Density
		{
			set{ _density=value;}
			get{return _density;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Enthalpy
		{
			set{ _enthalpy=value;}
			get{return _enthalpy;}
		}
		#endregion Model

	}
}

