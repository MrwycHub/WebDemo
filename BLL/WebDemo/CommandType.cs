﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using WebDemo.Model.WebDemo;
namespace WebDemo.BLL.WebDemo
{
	/// <summary>
	/// CommandType
	/// </summary>
	public partial class CommandType
	{
		private readonly WebDemo.DAL.WebDemo.CommandType dal=new WebDemo.DAL.WebDemo.CommandType();
		public CommandType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CommandID)
		{
			return dal.Exists(CommandID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.CommandType model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebDemo.Model.WebDemo.CommandType model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int CommandID)
		{
			
			return dal.Delete(CommandID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string CommandIDlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(CommandIDlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WebDemo.Model.WebDemo.CommandType GetModel(int CommandID)
		{
			
			return dal.GetModel(CommandID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public WebDemo.Model.WebDemo.CommandType GetModelByCache(int CommandID)
		{
			
			string CacheKey = "CommandTypeModel-" + CommandID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(CommandID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WebDemo.Model.WebDemo.CommandType)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WebDemo.Model.WebDemo.CommandType> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<WebDemo.Model.WebDemo.CommandType> DataTableToList(DataTable dt)
		{
			List<WebDemo.Model.WebDemo.CommandType> modelList = new List<WebDemo.Model.WebDemo.CommandType>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				WebDemo.Model.WebDemo.CommandType model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

