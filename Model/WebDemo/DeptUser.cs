using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// DeptUser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DeptUser
	{
		public DeptUser()
		{}
		#region Model
		private string _operatorcode;
		private string _deptid;
		/// <summary>
		/// 
		/// </summary>
		public string OperatorCode
		{
			set{ _operatorcode=value;}
			get{return _operatorcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeptID
		{
			set{ _deptid=value;}
			get{return _deptid;}
		}
		#endregion Model

	}
}

