﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Params
	/// </summary>
	public partial class Params
	{
		public Params()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ParamID", "Params"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ParamID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Params");
			strSql.Append(" where ParamID=@ParamID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ParamID", SqlDbType.Int,4)			};
			parameters[0].Value = ParamID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.Params model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Params(");
			strSql.Append("ParamID,ParamName,ParamValue,Remark,IsShow,IsEdit)");
			strSql.Append(" values (");
			strSql.Append("@ParamID,@ParamName,@ParamValue,@Remark,@IsShow,@IsEdit)");
			SqlParameter[] parameters = {
					new SqlParameter("@ParamID", SqlDbType.Int,4),
					new SqlParameter("@ParamName", SqlDbType.VarChar,50),
					new SqlParameter("@ParamValue", SqlDbType.VarChar,500),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@IsShow", SqlDbType.Bit,1),
					new SqlParameter("@IsEdit", SqlDbType.Bit,1)};
			parameters[0].Value = model.ParamID;
			parameters[1].Value = model.ParamName;
			parameters[2].Value = model.ParamValue;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.IsShow;
			parameters[5].Value = model.IsEdit;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(WebDemo.Model.WebDemo.Params model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Params set ");
			strSql.Append("ParamName=@ParamName,");
			strSql.Append("ParamValue=@ParamValue,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("IsShow=@IsShow,");
			strSql.Append("IsEdit=@IsEdit");
			strSql.Append(" where ParamID=@ParamID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ParamName", SqlDbType.VarChar,50),
					new SqlParameter("@ParamValue", SqlDbType.VarChar,500),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@IsShow", SqlDbType.Bit,1),
					new SqlParameter("@IsEdit", SqlDbType.Bit,1),
					new SqlParameter("@ParamID", SqlDbType.Int,4)};
			parameters[0].Value = model.ParamName;
			parameters[1].Value = model.ParamValue;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.IsShow;
			parameters[4].Value = model.IsEdit;
			parameters[5].Value = model.ParamID;

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
		public bool Delete(int ParamID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Params ");
			strSql.Append(" where ParamID=@ParamID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ParamID", SqlDbType.Int,4)			};
			parameters[0].Value = ParamID;

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
		public bool DeleteList(string ParamIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Params ");
			strSql.Append(" where ParamID in ("+ParamIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.Params GetModel(int ParamID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ParamID,ParamName,ParamValue,Remark,IsShow,IsEdit from Params ");
			strSql.Append(" where ParamID=@ParamID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ParamID", SqlDbType.Int,4)			};
			parameters[0].Value = ParamID;

			WebDemo.Model.WebDemo.Params model=new WebDemo.Model.WebDemo.Params();
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
		public WebDemo.Model.WebDemo.Params DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Params model=new WebDemo.Model.WebDemo.Params();
			if (row != null)
			{
				if(row["ParamID"]!=null && row["ParamID"].ToString()!="")
				{
					model.ParamID=int.Parse(row["ParamID"].ToString());
				}
				if(row["ParamName"]!=null)
				{
					model.ParamName=row["ParamName"].ToString();
				}
				if(row["ParamValue"]!=null)
				{
					model.ParamValue=row["ParamValue"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["IsShow"]!=null && row["IsShow"].ToString()!="")
				{
					if((row["IsShow"].ToString()=="1")||(row["IsShow"].ToString().ToLower()=="true"))
					{
						model.IsShow=true;
					}
					else
					{
						model.IsShow=false;
					}
				}
				if(row["IsEdit"]!=null && row["IsEdit"].ToString()!="")
				{
					if((row["IsEdit"].ToString()=="1")||(row["IsEdit"].ToString().ToLower()=="true"))
					{
						model.IsEdit=true;
					}
					else
					{
						model.IsEdit=false;
					}
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
			strSql.Append("select ParamID,ParamName,ParamValue,Remark,IsShow,IsEdit ");
			strSql.Append(" FROM Params ");
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
			strSql.Append(" ParamID,ParamName,ParamValue,Remark,IsShow,IsEdit ");
			strSql.Append(" FROM Params ");
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
			strSql.Append("select count(1) FROM Params ");
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
				strSql.Append("order by T.ParamID desc");
			}
			strSql.Append(")AS Row, T.*  from Params T ");
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
			parameters[0].Value = "Params";
			parameters[1].Value = "ParamID";
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

