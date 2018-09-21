using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// MeterStateDictionary:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MeterStateDictionary
	{
		public MeterStateDictionary()
		{}
		#region Model
		private int _statecode;
		private string _statename;
		private bool _enable;
		private bool _isshow;
		private int _ordernum;
		private string _reasion;
		private string _operation;
		/// <summary>
		/// 
		/// </summary>
		public int StateCode
		{
			set{ _statecode=value;}
			get{return _statecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StateName
		{
			set{ _statename=value;}
			get{return _statename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Enable
		{
			set{ _enable=value;}
			get{return _enable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsShow
		{
			set{ _isshow=value;}
			get{return _isshow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OrderNum
		{
			set{ _ordernum=value;}
			get{return _ordernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reasion
		{
			set{ _reasion=value;}
			get{return _reasion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Operation
		{
			set{ _operation=value;}
			get{return _operation;}
		}
		#endregion Model

	}
}

