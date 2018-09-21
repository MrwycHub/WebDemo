using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:CollFindWork
	/// </summary>
	public partial class CollFindWork
	{
		public CollFindWork()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CollectorID", "CollFindWork"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CollectorID,int WorkID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CollFindWork");
			strSql.Append(" where CollectorID=@CollectorID and WorkID=@WorkID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@WorkID", SqlDbType.Int,4)			};
			parameters[0].Value = CollectorID;
			parameters[1].Value = WorkID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.CollFindWork model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CollFindWork(");
			strSql.Append("CollectorID,WorkID,WorkTime)");
			strSql.Append(" values (");
			strSql.Append("@CollectorID,@WorkID,@WorkTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@WorkID", SqlDbType.Int,4),
					new SqlParameter("@WorkTime", SqlDbType.Int,4)};
			parameters[0].Value = model.CollectorID;
			parameters[1].Value = model.WorkID;
			parameters[2].Value = model.WorkTime;

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
		public bool Update(WebDemo.Model.WebDemo.CollFindWork model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CollFindWork set ");
			strSql.Append("WorkTime=@WorkTime");
			strSql.Append(" where CollectorID=@CollectorID and WorkID=@WorkID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkTime", SqlDbType.Int,4),
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@WorkID", SqlDbType.Int,4)};
			parameters[0].Value = model.WorkTime;
			parameters[1].Value = model.CollectorID;
			parameters[2].Value = model.WorkID;

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
		public bool Delete(int CollectorID,int WorkID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CollFindWork ");
			strSql.Append(" where CollectorID=@CollectorID and WorkID=@WorkID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@WorkID", SqlDbType.Int,4)			};
			parameters[0].Value = CollectorID;
			parameters[1].Value = WorkID;

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
		/// 得到一个对象实体
		/// </summary>
		public WebDemo.Model.WebDemo.CollFindWork GetModel(int CollectorID,int WorkID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CollectorID,WorkID,WorkTime from CollFindWork ");
			strSql.Append(" where CollectorID=@CollectorID and WorkID=@WorkID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@WorkID", SqlDbType.Int,4)			};
			parameters[0].Value = CollectorID;
			parameters[1].Value = WorkID;

			WebDemo.Model.WebDemo.CollFindWork model=new WebDemo.Model.WebDemo.CollFindWork();
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
		public WebDemo.Model.WebDemo.CollFindWork DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.CollFindWork model=new WebDemo.Model.WebDemo.CollFindWork();
			if (row != null)
			{
				if(row["CollectorID"]!=null && row["CollectorID"].ToString()!="")
				{
					model.CollectorID=int.Parse(row["CollectorID"].ToString());
				}
				if(row["WorkID"]!=null && row["WorkID"].ToString()!="")
				{
					model.WorkID=int.Parse(row["WorkID"].ToString());
				}
				if(row["WorkTime"]!=null && row["WorkTime"].ToString()!="")
				{
					model.WorkTime=int.Parse(row["WorkTime"].ToString());
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
			strSql.Append("select CollectorID,WorkID,WorkTime ");
			strSql.Append(" FROM CollFindWork ");
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
			strSql.Append(" CollectorID,WorkID,WorkTime ");
			strSql.Append(" FROM CollFindWork ");
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
			strSql.Append("select count(1) FROM CollFindWork ");
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
				strSql.Append("order by T.WorkID desc");
			}
			strSql.Append(")AS Row, T.*  from CollFindWork T ");
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
			parameters[0].Value = "CollFindWork";
			parameters[1].Value = "WorkID";
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

