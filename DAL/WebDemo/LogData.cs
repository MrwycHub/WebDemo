using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:LogData
	/// </summary>
	public partial class LogData
	{
		public LogData()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("LogID", "LogData"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int LogID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LogData");
			strSql.Append(" where LogID=@LogID");
			SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.Int,4)
			};
			parameters[0].Value = LogID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.LogData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LogData(");
			strSql.Append("LogTitle,LogType,LogDate,LogMemo,LogData,LogOperator)");
			strSql.Append(" values (");
			strSql.Append("@LogTitle,@LogType,@LogDate,@LogMemo,@LogData,@LogOperator)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@LogTitle", SqlDbType.VarChar,200),
					new SqlParameter("@LogType", SqlDbType.VarChar,50),
					new SqlParameter("@LogDate", SqlDbType.DateTime),
					new SqlParameter("@LogMemo", SqlDbType.VarChar,5000),
					new SqlParameter("@LogData", SqlDbType.VarChar,5000),
					new SqlParameter("@LogOperator", SqlDbType.VarChar,100)};
			parameters[0].Value = model.LogTitle;
			parameters[1].Value = model.LogType;
			parameters[2].Value = model.LogDate;
			parameters[3].Value = model.LogMemo;
			parameters[4].Value = model.LogData;
			parameters[5].Value = model.LogOperator;

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
		public bool Update(WebDemo.Model.WebDemo.LogData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LogData set ");
			strSql.Append("LogTitle=@LogTitle,");
			strSql.Append("LogType=@LogType,");
			strSql.Append("LogDate=@LogDate,");
			strSql.Append("LogMemo=@LogMemo,");
			strSql.Append("LogData=@LogData,");
			strSql.Append("LogOperator=@LogOperator");
			strSql.Append(" where LogID=@LogID");
			SqlParameter[] parameters = {
					new SqlParameter("@LogTitle", SqlDbType.VarChar,200),
					new SqlParameter("@LogType", SqlDbType.VarChar,50),
					new SqlParameter("@LogDate", SqlDbType.DateTime),
					new SqlParameter("@LogMemo", SqlDbType.VarChar,5000),
					new SqlParameter("@LogData", SqlDbType.VarChar,5000),
					new SqlParameter("@LogOperator", SqlDbType.VarChar,100),
					new SqlParameter("@LogID", SqlDbType.Int,4)};
			parameters[0].Value = model.LogTitle;
			parameters[1].Value = model.LogType;
			parameters[2].Value = model.LogDate;
			parameters[3].Value = model.LogMemo;
			parameters[4].Value = model.LogData;
			parameters[5].Value = model.LogOperator;
			parameters[6].Value = model.LogID;

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
		public bool Delete(int LogID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LogData ");
			strSql.Append(" where LogID=@LogID");
			SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.Int,4)
			};
			parameters[0].Value = LogID;

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
		public bool DeleteList(string LogIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LogData ");
			strSql.Append(" where LogID in ("+LogIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.LogData GetModel(int LogID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 LogID,LogTitle,LogType,LogDate,LogMemo,LogData,LogOperator from LogData ");
			strSql.Append(" where LogID=@LogID");
			SqlParameter[] parameters = {
					new SqlParameter("@LogID", SqlDbType.Int,4)
			};
			parameters[0].Value = LogID;

			WebDemo.Model.WebDemo.LogData model=new WebDemo.Model.WebDemo.LogData();
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
		public WebDemo.Model.WebDemo.LogData DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.LogData model=new WebDemo.Model.WebDemo.LogData();
			if (row != null)
			{
				if(row["LogID"]!=null && row["LogID"].ToString()!="")
				{
					model.LogID=int.Parse(row["LogID"].ToString());
				}
				if(row["LogTitle"]!=null)
				{
					model.LogTitle=row["LogTitle"].ToString();
				}
				if(row["LogType"]!=null)
				{
					model.LogType=row["LogType"].ToString();
				}
				if(row["LogDate"]!=null && row["LogDate"].ToString()!="")
				{
					model.LogDate=DateTime.Parse(row["LogDate"].ToString());
				}
				if(row["LogMemo"]!=null)
				{
					model.LogMemo=row["LogMemo"].ToString();
				}
				if(row["LogData"]!=null)
				{
					model.LogData=row["LogData"].ToString();
				}
				if(row["LogOperator"]!=null)
				{
					model.LogOperator=row["LogOperator"].ToString();
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
			strSql.Append("select LogID,LogTitle,LogType,LogDate,LogMemo,LogData,LogOperator ");
			strSql.Append(" FROM LogData ");
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
			strSql.Append(" LogID,LogTitle,LogType,LogDate,LogMemo,LogData,LogOperator ");
			strSql.Append(" FROM LogData ");
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
			strSql.Append("select count(1) FROM LogData ");
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
				strSql.Append("order by T.LogID desc");
			}
			strSql.Append(")AS Row, T.*  from LogData T ");
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
			parameters[0].Value = "LogData";
			parameters[1].Value = "LogID";
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

