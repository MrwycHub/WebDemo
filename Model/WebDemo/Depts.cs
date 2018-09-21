using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// Depts:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Depts
	{
		public Depts()
		{}
		#region Model
		private string _deptid;
		private string _deptname;
		private string _upperdept;
		private string _address;
		private int? _imgindex=0;
		private int? _selectimgindex=0;
		private string _remark;
		private string _customcode;
		private int? _depttype;
		private decimal? _locationx;
		private decimal? _locationy;
		private DateTime _updatetime= DateTime.Now;
		private int _ordernum=0;
		/// <summary>
		/// 部门编号(编码由数字组成，每3位代表一级部门，可以扩展)
		/// </summary>
		public string DeptID
		{
			set{ _deptid=value;}
			get{return _deptid;}
		}
		/// <summary>
		/// 部门名称
		/// </summary>
		public string DeptName
		{
			set{ _deptname=value;}
			get{return _deptname;}
		}
		/// <summary>
		/// 上级部门代码(为空说明为第一级部门)
		/// </summary>
		public string UpperDept
		{
			set{ _upperdept=value;}
			get{return _upperdept;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? imgIndex
		{
			set{ _imgindex=value;}
			get{return _imgindex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SelectimgIndex
		{
			set{ _selectimgindex=value;}
			get{return _selectimgindex;}
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
		public string CustomCode
		{
			set{ _customcode=value;}
			get{return _customcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DeptType
		{
			set{ _depttype=value;}
			get{return _depttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LocationX
		{
			set{ _locationx=value;}
			get{return _locationx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LocationY
		{
			set{ _locationy=value;}
			get{return _locationy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OrderNum
		{
			set{ _ordernum=value;}
			get{return _ordernum;}
		}
		#endregion Model

	}
}

