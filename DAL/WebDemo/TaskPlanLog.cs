using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:TaskPlanLog
	/// </summary>
	public partial class TaskPlanLog
	{
		public TaskPlanLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "TaskPlanLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TaskPlanLog");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.TaskPlanLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TaskPlanLog(");
			strSql.Append("TaskID,CollectorID,MeterAddr,MeterType,ExeMark,ExeDate,ExeInfo,InsDate)");
			strSql.Append(" values (");
			strSql.Append("@TaskID,@CollectorID,@MeterAddr,@MeterType,@ExeMark,@ExeDate,@ExeInfo,@InsDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,50),
					new SqlParameter("@MeterType", SqlDbType.Int,4),
					new SqlParameter("@ExeMark", SqlDbType.Int,4),
					new SqlParameter("@ExeDate", SqlDbType.DateTime),
					new SqlParameter("@ExeInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@InsDate", SqlDbType.DateTime)};
			parameters[0].Value = model.TaskID;
			parameters[1].Value = model.CollectorID;
			parameters[2].Value = model.MeterAddr;
			parameters[3].Value = model.MeterType;
			parameters[4].Value = model.ExeMark;
			parameters[5].Value = model.ExeDate;
			parameters[6].Value = model.ExeInfo;
			parameters[7].Value = model.InsDate;

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
		public bool Update(WebDemo.Model.WebDemo.TaskPlanLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TaskPlanLog set ");
			strSql.Append("TaskID=@TaskID,");
			strSql.Append("CollectorID=@CollectorID,");
			strSql.Append("MeterAddr=@MeterAddr,");
			strSql.Append("MeterType=@MeterType,");
			strSql.Append("ExeMark=@ExeMark,");
			strSql.Append("ExeDate=@ExeDate,");
			strSql.Append("ExeInfo=@ExeInfo,");
			strSql.Append("InsDate=@InsDate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,50),
					new SqlParameter("@MeterType", SqlDbType.Int,4),
					new SqlParameter("@ExeMark", SqlDbType.Int,4),
					new SqlParameter("@ExeDate", SqlDbType.DateTime),
					new SqlParameter("@ExeInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@InsDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.TaskID;
			parameters[1].Value = model.CollectorID;
			parameters[2].Value = model.MeterAddr;
			parameters[3].Value = model.MeterType;
			parameters[4].Value = model.ExeMark;
			parameters[5].Value = model.ExeDate;
			parameters[6].Value = model.ExeInfo;
			parameters[7].Value = model.InsDate;
			parameters[8].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TaskPlanLog ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TaskPlanLog ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public WebDemo.Model.WebDemo.TaskPlanLog GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,TaskID,CollectorID,MeterAddr,MeterType,ExeMark,ExeDate,ExeInfo,InsDate from TaskPlanLog ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.TaskPlanLog model=new WebDemo.Model.WebDemo.TaskPlanLog();
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
		public WebDemo.Model.WebDemo.TaskPlanLog DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.TaskPlanLog model=new WebDemo.Model.WebDemo.TaskPlanLog();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["TaskID"]!=null && row["TaskID"].ToString()!="")
				{
					model.TaskID=int.Parse(row["TaskID"].ToString());
				}
				if(row["CollectorID"]!=null && row["CollectorID"].ToString()!="")
				{
					model.CollectorID=int.Parse(row["CollectorID"].ToString());
				}
				if(row["MeterAddr"]!=null)
				{
					model.MeterAddr=row["MeterAddr"].ToString();
				}
				if(row["MeterType"]!=null && row["MeterType"].ToString()!="")
				{
					model.MeterType=int.Parse(row["MeterType"].ToString());
				}
				if(row["ExeMark"]!=null && row["ExeMark"].ToString()!="")
				{
					model.ExeMark=int.Parse(row["ExeMark"].ToString());
				}
				if(row["ExeDate"]!=null && row["ExeDate"].ToString()!="")
				{
					model.ExeDate=DateTime.Parse(row["ExeDate"].ToString());
				}
				if(row["ExeInfo"]!=null)
				{
					model.ExeInfo=row["ExeInfo"].ToString();
				}
				if(row["InsDate"]!=null && row["InsDate"].ToString()!="")
				{
					model.InsDate=DateTime.Parse(row["InsDate"].ToString());
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
			strSql.Append("select ID,TaskID,CollectorID,MeterAddr,MeterType,ExeMark,ExeDate,ExeInfo,InsDate ");
			strSql.Append(" FROM TaskPlanLog ");
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
			strSql.Append(" ID,TaskID,CollectorID,MeterAddr,MeterType,ExeMark,ExeDate,ExeInfo,InsDate ");
			strSql.Append(" FROM TaskPlanLog ");
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
			strSql.Append("select count(1) FROM TaskPlanLog ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from TaskPlanLog T ");
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
			parameters[0].Value = "TaskPlanLog";
			parameters[1].Value = "ID";
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

