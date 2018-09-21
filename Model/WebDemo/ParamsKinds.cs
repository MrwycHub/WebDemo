using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// ParamsKinds:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ParamsKinds
	{
		public ParamsKinds()
		{}
		#region Model
		private int _pid;
		private string _paramname;
		private string _ptypenum;
		private string _pdisplayvalue;
		private string _remark;
		private int? _flag=1;
		private string _ptypevalue;
		/// <summary>
		/// 
		/// </summary>
		public int Pid
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// 参数名称
		/// </summary>
		public string ParamName
		{
			set{ _paramname=value;}
			get{return _paramname;}
		}
		/// <summary>
		/// 参数编号
		/// </summary>
		public string PTypeNum
		{
			set{ _ptypenum=value;}
			get{return _ptypenum;}
		}
		/// <summary>
		/// 显示值
		/// </summary>
		public string PDisplayValue
		{
			set{ _pdisplayvalue=value;}
			get{return _pdisplayvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PTypeValue
		{
			set{ _ptypevalue=value;}
			get{return _ptypevalue;}
		}
		#endregion Model

	}
}

