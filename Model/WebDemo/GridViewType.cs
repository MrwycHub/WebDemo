using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// GridViewType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GridViewType
	{
		public GridViewType()
		{}
		#region Model
		private int _gridviewtypeid;
		private string _gridviewtypename;
		private bool _isedit= true;
		private bool _isshow= true;
		private int _ordernum;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int GridViewTypeID
		{
			set{ _gridviewtypeid=value;}
			get{return _gridviewtypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GridViewTypeName
		{
			set{ _gridviewtypename=value;}
			get{return _gridviewtypename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsEdit
		{
			set{ _isedit=value;}
			get{return _isedit;}
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
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

