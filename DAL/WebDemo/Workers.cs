﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Workers
	/// </summary>
	public partial class Workers
	{
		public Workers()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("WorkerID", "Workers"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int WorkerID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Workers");
			strSql.Append(" where WorkerID=@WorkerID");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkerID", SqlDbType.Int,4)
			};
			parameters[0].Value = WorkerID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.Workers model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Workers(");
			strSql.Append("WorkerName,WorkerPhone,Remark)");
			strSql.Append(" values (");
			strSql.Append("@WorkerName,@WorkerPhone,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkerName", SqlDbType.VarChar,50),
					new SqlParameter("@WorkerPhone", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
			parameters[0].Value = model.WorkerName;
			parameters[1].Value = model.WorkerPhone;
			parameters[2].Value = model.Remark;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(WebDemo.Model.WebDemo.Workers model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Workers set ");
			strSql.Append("WorkerName=@WorkerName,");
			strSql.Append("WorkerPhone=@WorkerPhone,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where WorkerID=@WorkerID");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkerName", SqlDbType.VarChar,50),
					new SqlParameter("@WorkerPhone", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@WorkerID", SqlDbType.Int,4)};
			parameters[0].Value = model.WorkerName;
			parameters[1].Value = model.WorkerPhone;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.WorkerID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int WorkerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Workers ");
			strSql.Append(" where WorkerID=@WorkerID");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkerID", SqlDbType.Int,4)
			};
			parameters[0].Value = WorkerID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string WorkerIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Workers ");
			strSql.Append(" where WorkerID in ("+WorkerIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WebDemo.Model.WebDemo.Workers GetModel(int WorkerID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 WorkerID,WorkerName,WorkerPhone,Remark from Workers ");
			strSql.Append(" where WorkerID=@WorkerID");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkerID", SqlDbType.Int,4)
			};
			parameters[0].Value = WorkerID;

			WebDemo.Model.WebDemo.Workers model=new WebDemo.Model.WebDemo.Workers();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public WebDemo.Model.WebDemo.Workers DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Workers model=new WebDemo.Model.WebDemo.Workers();
			if (row != null)
			{
				if(row["WorkerID"]!=null && row["WorkerID"].ToString()!="")
				{
					model.WorkerID=int.Parse(row["WorkerID"].ToString());
				}
				if(row["WorkerName"]!=null)
				{
					model.WorkerName=row["WorkerName"].ToString();
				}
				if(row["WorkerPhone"]!=null)
				{
					model.WorkerPhone=row["WorkerPhone"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select WorkerID,WorkerName,WorkerPhone,Remark ");
			strSql.Append(" FROM Workers ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" WorkerID,WorkerName,WorkerPhone,Remark ");
			strSql.Append(" FROM Workers ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Workers ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.WorkerID desc");
			}
			strSql.Append(")AS Row, T.*  from Workers T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Workers";
			parameters[1].Value = "WorkerID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

