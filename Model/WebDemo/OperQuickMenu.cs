using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// OperQuickMenu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OperQuickMenu
	{
		public OperQuickMenu()
		{}
		#region Model
		private int _operatorid;
		private int _menuid;
		private int _orderno;
		private int? _quickmenunum=1;
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
		public int MenuID
		{
			set{ _menuid=value;}
			get{return _menuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OrderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? QuickMenuNum
		{
			set{ _quickmenunum=value;}
			get{return _quickmenunum;}
		}
		#endregion Model

	}
}

