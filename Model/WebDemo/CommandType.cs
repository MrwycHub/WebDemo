using System;
namespace WebDemo.Model.WebDemo
{
	/// <summary>
	/// CommandType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CommandType
	{
		public CommandType()
		{}
		#region Model
		private int _commandid;
		private string _commandname;
		private int? _flag=0;
		/// <summary>
		/// 指令编号
		/// </summary>
		public int CommandID
		{
			set{ _commandid=value;}
			get{return _commandid;}
		}
		/// <summary>
		/// 指令名称
		/// </summary>
		public string CommandName
		{
			set{ _commandname=value;}
			get{return _commandname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		#endregion Model

	}
}

