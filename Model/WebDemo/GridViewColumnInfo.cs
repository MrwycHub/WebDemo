using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// GridViewColumnInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GridViewColumnInfo
	{
		public GridViewColumnInfo()
		{}
		#region Model
		private int _id;
		private int _gridviewtypeid;
		private int _columnid;
		private string _datafield;
		private string _headertext;
		private string _dataformat;
		private string _sortexpression;
		private bool _isedit= true;
		private bool _isshow= true;
		private int _ordernum;
		private int _operatorid;
		private string _remark;
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
		public int GridViewTypeID
		{
			set{ _gridviewtypeid=value;}
			get{return _gridviewtypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ColumnID
		{
			set{ _columnid=value;}
			get{return _columnid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DataField
		{
			set{ _datafield=value;}
			get{return _datafield;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeaderText
		{
			set{ _headertext=value;}
			get{return _headertext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DataFormat
		{
			set{ _dataformat=value;}
			get{return _dataformat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SortExpression
		{
			set{ _sortexpression=value;}
			get{return _sortexpression;}
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
		public int OperatorID
		{
			set{ _operatorid=value;}
			get{return _operatorid;}
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

