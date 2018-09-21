using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:InstantTask
	/// </summary>
	public partial class InstantTask
	{
		public InstantTask()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("TaskID", "InstantTask"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TaskID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InstantTask");
			strSql.Append(" where TaskID=@TaskID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TaskID", SqlDbType.Int,4)			};
			parameters[0].Value = TaskID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.InstantTask model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InstantTask(");
			strSql.Append("TaskID,TaskType,CollectorID,MeterType,MeterAddr,HostAddr,MeterStatus,MeterData,PayMoney,TotalPayMoney)");
			strSql.Append(" values (");
			strSql.Append("@TaskID,@TaskType,@CollectorID,@MeterType,@MeterAddr,@HostAddr,@MeterStatus,@MeterData,@PayMoney,@TotalPayMoney)");
			SqlParameter[] parameters = {
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@TaskType", SqlDbType.VarChar,50),
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@MeterType", SqlDbType.Int,4),
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,12),
					new SqlParameter("@HostAddr", SqlDbType.VarChar,12),
					new SqlParameter("@MeterStatus", SqlDbType.Int,4),
					new SqlParameter("@MeterData", SqlDbType.Int,4),
					new SqlParameter("@PayMoney", SqlDbType.VarChar,50),
					new SqlParameter("@TotalPayMoney", SqlDbType.VarChar,50)};
			parameters[0].Value = model.TaskID;
			parameters[1].Value = model.TaskType;
			parameters[2].Value = model.CollectorID;
			parameters[3].Value = model.MeterType;
			parameters[4].Value = model.MeterAddr;
			parameters[5].Value = model.HostAddr;
			parameters[6].Value = model.MeterStatus;
			parameters[7].Value = model.MeterData;
			parameters[8].Value = model.PayMoney;
			parameters[9].Value = model.TotalPayMoney;

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
		public bool Update(WebDemo.Model.WebDemo.InstantTask model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InstantTask set ");
			strSql.Append("TaskType=@TaskType,");
			strSql.Append("CollectorID=@CollectorID,");
			strSql.Append("MeterType=@MeterType,");
			strSql.Append("MeterAddr=@MeterAddr,");
			strSql.Append("HostAddr=@HostAddr,");
			strSql.Append("MeterStatus=@MeterStatus,");
			strSql.Append("MeterData=@MeterData,");
			strSql.Append("PayMoney=@PayMoney,");
			strSql.Append("TotalPayMoney=@TotalPayMoney");
			strSql.Append(" where TaskID=@TaskID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TaskType", SqlDbType.VarChar,50),
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@MeterType", SqlDbType.Int,4),
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,12),
					new SqlParameter("@HostAddr", SqlDbType.VarChar,12),
					new SqlParameter("@MeterStatus", SqlDbType.Int,4),
					new SqlParameter("@MeterData", SqlDbType.Int,4),
					new SqlParameter("@PayMoney", SqlDbType.VarChar,50),
					new SqlParameter("@TotalPayMoney", SqlDbType.VarChar,50),
					new SqlParameter("@TaskID", SqlDbType.Int,4)};
			parameters[0].Value = model.TaskType;
			parameters[1].Value = model.CollectorID;
			parameters[2].Value = model.MeterType;
			parameters[3].Value = model.MeterAddr;
			parameters[4].Value = model.HostAddr;
			parameters[5].Value = model.MeterStatus;
			parameters[6].Value = model.MeterData;
			parameters[7].Value = model.PayMoney;
			parameters[8].Value = model.TotalPayMoney;
			parameters[9].Value = model.TaskID;

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
		public bool Delete(int TaskID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InstantTask ");
			strSql.Append(" where TaskID=@TaskID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TaskID", SqlDbType.Int,4)			};
			parameters[0].Value = TaskID;

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
		public bool DeleteList(string TaskIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InstantTask ");
			strSql.Append(" where TaskID in ("+TaskIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.InstantTask GetModel(int TaskID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TaskID,TaskType,CollectorID,MeterType,MeterAddr,HostAddr,MeterStatus,MeterData,PayMoney,TotalPayMoney from InstantTask ");
			strSql.Append(" where TaskID=@TaskID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TaskID", SqlDbType.Int,4)			};
			parameters[0].Value = TaskID;

			WebDemo.Model.WebDemo.InstantTask model=new WebDemo.Model.WebDemo.InstantTask();
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
		public WebDemo.Model.WebDemo.InstantTask DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.InstantTask model=new WebDemo.Model.WebDemo.InstantTask();
			if (row != null)
			{
				if(row["TaskID"]!=null && row["TaskID"].ToString()!="")
				{
					model.TaskID=int.Parse(row["TaskID"].ToString());
				}
				if(row["TaskType"]!=null)
				{
					model.TaskType=row["TaskType"].ToString();
				}
				if(row["CollectorID"]!=null && row["CollectorID"].ToString()!="")
				{
					model.CollectorID=int.Parse(row["CollectorID"].ToString());
				}
				if(row["MeterType"]!=null && row["MeterType"].ToString()!="")
				{
					model.MeterType=int.Parse(row["MeterType"].ToString());
				}
				if(row["MeterAddr"]!=null)
				{
					model.MeterAddr=row["MeterAddr"].ToString();
				}
				if(row["HostAddr"]!=null)
				{
					model.HostAddr=row["HostAddr"].ToString();
				}
				if(row["MeterStatus"]!=null && row["MeterStatus"].ToString()!="")
				{
					model.MeterStatus=int.Parse(row["MeterStatus"].ToString());
				}
				if(row["MeterData"]!=null && row["MeterData"].ToString()!="")
				{
					model.MeterData=int.Parse(row["MeterData"].ToString());
				}
				if(row["PayMoney"]!=null)
				{
					model.PayMoney=row["PayMoney"].ToString();
				}
				if(row["TotalPayMoney"]!=null)
				{
					model.TotalPayMoney=row["TotalPayMoney"].ToString();
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
			strSql.Append("select TaskID,TaskType,CollectorID,MeterType,MeterAddr,HostAddr,MeterStatus,MeterData,PayMoney,TotalPayMoney ");
			strSql.Append(" FROM InstantTask ");
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
			strSql.Append(" TaskID,TaskType,CollectorID,MeterType,MeterAddr,HostAddr,MeterStatus,MeterData,PayMoney,TotalPayMoney ");
			strSql.Append(" FROM InstantTask ");
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
			strSql.Append("select count(1) FROM InstantTask ");
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
				strSql.Append("order by T.TaskID desc");
			}
			strSql.Append(")AS Row, T.*  from InstantTask T ");
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
			parameters[0].Value = "InstantTask";
			parameters[1].Value = "TaskID";
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

