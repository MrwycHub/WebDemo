using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// OperRoles:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OperRoles
	{
		public OperRoles()
		{}
		#region Model
		private int _menuid;
		private int _roleid;
		/// <summary>
		/// 
		/// </summary>
		public int MenuID
		{
			set{ _menuid=value;}
			get{return _menuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		#endregion Model

	}
}

