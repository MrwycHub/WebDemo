using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Params:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Params
	{
		public Params()
		{}
		#region Model
		private int _paramid;
		private string _paramname;
		private string _paramvalue;
		private string _remark;
		private bool _isshow= true;
		private bool _isedit= true;
		/// <summary>
		/// 
		/// </summary>
		public int ParamID
		{
			set{ _paramid=value;}
			get{return _paramid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ParamName
		{
			set{ _paramname=value;}
			get{return _paramname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ParamValue
		{
			set{ _paramvalue=value;}
			get{return _paramvalue;}
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
		public bool IsShow
		{
			set{ _isshow=value;}
			get{return _isshow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsEdit
		{
			set{ _isedit=value;}
			get{return _isedit;}
		}
		#endregion Model

	}
}

