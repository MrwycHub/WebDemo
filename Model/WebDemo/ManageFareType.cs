using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ManageFareType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ManageFareType
	{
		public ManageFareType()
		{}
		#region Model
		private int? _managefaretypeid;
		private string _managefaretypename;
		/// <summary>
		/// 
		/// </summary>
		public int? ManageFareTypeID
		{
			set{ _managefaretypeid=value;}
			get{return _managefaretypeid;}
		}
		/// <summary>
		/// 1按月2按面积3按人口4手工输入
		/// </summary>
		public string ManageFareTypeName
		{
			set{ _managefaretypename=value;}
			get{return _managefaretypename;}
		}
		#endregion Model

	}
}

