using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:TaskPlanHistory
	/// </summary>
	public partial class TaskPlanHistory
	{
		public TaskPlanHistory()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.TaskPlanHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TaskPlanHistory(");
			strSql.Append("ID,TaskID,CollectorID,TaskName,CommandID,CommandInfo,MeterAddr,MeterType,MeterItem,FreezeDate,TaskMonth,TaskDay,TaskHour,TaskMinute,ExeMark,ExeDate,ExeError,TaskMark,TaskType,TaskError,TryNum,HostAddr,InsDate,MeterID,TaskFrequency,ExeInfo,OperatorID,DeptID,TaskWeek)");
			strSql.Append(" values (");
			strSql.Append("@ID,@TaskID,@CollectorID,@TaskName,@CommandID,@CommandInfo,@MeterAddr,@MeterType,@MeterItem,@FreezeDate,@TaskMonth,@TaskDay,@TaskHour,@TaskMinute,@ExeMark,@ExeDate,@ExeError,@TaskMark,@TaskType,@TaskError,@TryNum,@HostAddr,@InsDate,@MeterID,@TaskFrequency,@ExeInfo,@OperatorID,@DeptID,@TaskWeek)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@TaskName", SqlDbType.VarChar,100),
					new SqlParameter("@CommandID", SqlDbType.Int,4),
					new SqlParameter("@CommandInfo", SqlDbType.VarChar,500),
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,50),
					new SqlParameter("@MeterType", SqlDbType.Int,4),
					new SqlParameter("@MeterItem", SqlDbType.Int,4),
					new SqlParameter("@FreezeDate", SqlDbType.VarChar,10),
					new SqlParameter("@TaskMonth", SqlDbType.Int,4),
					new SqlParameter("@TaskDay", SqlDbType.Int,4),
					new SqlParameter("@TaskHour", SqlDbType.Int,4),
					new SqlParameter("@TaskMinute", SqlDbType.Int,4),
					new SqlParameter("@ExeMark", SqlDbType.Int,4),
					new SqlParameter("@ExeDate", SqlDbType.DateTime),
					new SqlParameter("@ExeError", SqlDbType.Int,4),
					new SqlParameter("@TaskMark", SqlDbType.Int,4),
					new SqlParameter("@TaskType", SqlDbType.Int,4),
					new SqlParameter("@TaskError", SqlDbType.Int,4),
					new SqlParameter("@TryNum", SqlDbType.Int,4),
					new SqlParameter("@HostAddr", SqlDbType.VarChar,50),
					new SqlParameter("@InsDate", SqlDbType.DateTime),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@TaskFrequency", SqlDbType.Int,4),
					new SqlParameter("@ExeInfo", SqlDbType.VarChar,200),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@DeptID", SqlDbType.VarChar,60),
					new SqlParameter("@TaskWeek", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.TaskID;
			parameters[2].Value = model.CollectorID;
			parameters[3].Value = model.TaskName;
			parameters[4].Value = model.CommandID;
			parameters[5].Value = model.CommandInfo;
			parameters[6].Value = model.MeterAddr;
			parameters[7].Value = model.MeterType;
			parameters[8].Value = model.MeterItem;
			parameters[9].Value = model.FreezeDate;
			parameters[10].Value = model.TaskMonth;
			parameters[11].Value = model.TaskDay;
			parameters[12].Value = model.TaskHour;
			parameters[13].Value = model.TaskMinute;
			parameters[14].Value = model.ExeMark;
			parameters[15].Value = model.ExeDate;
			parameters[16].Value = model.ExeError;
			parameters[17].Value = model.TaskMark;
			parameters[18].Value = model.TaskType;
			parameters[19].Value = model.TaskError;
			parameters[20].Value = model.TryNum;
			parameters[21].Value = model.HostAddr;
			parameters[22].Value = model.InsDate;
			parameters[23].Value = model.MeterID;
			parameters[24].Value = model.TaskFrequency;
			parameters[25].Value = model.ExeInfo;
			parameters[26].Value = model.OperatorID;
			parameters[27].Value = model.DeptID;
			parameters[28].Value = model.TaskWeek;

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
		public bool Update(WebDemo.Model.WebDemo.TaskPlanHistory model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TaskPlanHistory set ");
			strSql.Append("ID=@ID,");
			strSql.Append("TaskID=@TaskID,");
			strSql.Append("CollectorID=@CollectorID,");
			strSql.Append("TaskName=@TaskName,");
			strSql.Append("CommandID=@CommandID,");
			strSql.Append("CommandInfo=@CommandInfo,");
			strSql.Append("MeterAddr=@MeterAddr,");
			strSql.Append("MeterType=@MeterType,");
			strSql.Append("MeterItem=@MeterItem,");
			strSql.Append("FreezeDate=@FreezeDate,");
			strSql.Append("TaskMonth=@TaskMonth,");
			strSql.Append("TaskDay=@TaskDay,");
			strSql.Append("TaskHour=@TaskHour,");
			strSql.Append("TaskMinute=@TaskMinute,");
			strSql.Append("ExeMark=@ExeMark,");
			strSql.Append("ExeDate=@ExeDate,");
			strSql.Append("ExeError=@ExeError,");
			strSql.Append("TaskMark=@TaskMark,");
			strSql.Append("TaskType=@TaskType,");
			strSql.Append("TaskError=@TaskError,");
			strSql.Append("TryNum=@TryNum,");
			strSql.Append("HostAddr=@HostAddr,");
			strSql.Append("InsDate=@InsDate,");
			strSql.Append("MeterID=@MeterID,");
			strSql.Append("TaskFrequency=@TaskFrequency,");
			strSql.Append("ExeInfo=@ExeInfo,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("DeptID=@DeptID,");
			strSql.Append("TaskWeek=@TaskWeek");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@TaskName", SqlDbType.VarChar,100),
					new SqlParameter("@CommandID", SqlDbType.Int,4),
					new SqlParameter("@CommandInfo", SqlDbType.VarChar,500),
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,50),
					new SqlParameter("@MeterType", SqlDbType.Int,4),
					new SqlParameter("@MeterItem", SqlDbType.Int,4),
					new SqlParameter("@FreezeDate", SqlDbType.VarChar,10),
					new SqlParameter("@TaskMonth", SqlDbType.Int,4),
					new SqlParameter("@TaskDay", SqlDbType.Int,4),
					new SqlParameter("@TaskHour", SqlDbType.Int,4),
					new SqlParameter("@TaskMinute", SqlDbType.Int,4),
					new SqlParameter("@ExeMark", SqlDbType.Int,4),
					new SqlParameter("@ExeDate", SqlDbType.DateTime),
					new SqlParameter("@ExeError", SqlDbType.Int,4),
					new SqlParameter("@TaskMark", SqlDbType.Int,4),
					new SqlParameter("@TaskType", SqlDbType.Int,4),
					new SqlParameter("@TaskError", SqlDbType.Int,4),
					new SqlParameter("@TryNum", SqlDbType.Int,4),
					new SqlParameter("@HostAddr", SqlDbType.VarChar,50),
					new SqlParameter("@InsDate", SqlDbType.DateTime),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@TaskFrequency", SqlDbType.Int,4),
					new SqlParameter("@ExeInfo", SqlDbType.VarChar,200),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@DeptID", SqlDbType.VarChar,60),
					new SqlParameter("@TaskWeek", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.TaskID;
			parameters[2].Value = model.CollectorID;
			parameters[3].Value = model.TaskName;
			parameters[4].Value = model.CommandID;
			parameters[5].Value = model.CommandInfo;
			parameters[6].Value = model.MeterAddr;
			parameters[7].Value = model.MeterType;
			parameters[8].Value = model.MeterItem;
			parameters[9].Value = model.FreezeDate;
			parameters[10].Value = model.TaskMonth;
			parameters[11].Value = model.TaskDay;
			parameters[12].Value = model.TaskHour;
			parameters[13].Value = model.TaskMinute;
			parameters[14].Value = model.ExeMark;
			parameters[15].Value = model.ExeDate;
			parameters[16].Value = model.ExeError;
			parameters[17].Value = model.TaskMark;
			parameters[18].Value = model.TaskType;
			parameters[19].Value = model.TaskError;
			parameters[20].Value = model.TryNum;
			parameters[21].Value = model.HostAddr;
			parameters[22].Value = model.InsDate;
			parameters[23].Value = model.MeterID;
			parameters[24].Value = model.TaskFrequency;
			parameters[25].Value = model.ExeInfo;
			parameters[26].Value = model.OperatorID;
			parameters[27].Value = model.DeptID;
			parameters[28].Value = model.TaskWeek;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TaskPlanHistory ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		public WebDemo.Model.WebDemo.TaskPlanHistory GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,TaskID,CollectorID,TaskName,CommandID,CommandInfo,MeterAddr,MeterType,MeterItem,FreezeDate,TaskMonth,TaskDay,TaskHour,TaskMinute,ExeMark,ExeDate,ExeError,TaskMark,TaskType,TaskError,TryNum,HostAddr,InsDate,MeterID,TaskFrequency,ExeInfo,OperatorID,DeptID,TaskWeek from TaskPlanHistory ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			WebDemo.Model.WebDemo.TaskPlanHistory model=new WebDemo.Model.WebDemo.TaskPlanHistory();
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
		public WebDemo.Model.WebDemo.TaskPlanHistory DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.TaskPlanHistory model=new WebDemo.Model.WebDemo.TaskPlanHistory();
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
				if(row["TaskName"]!=null)
				{
					model.TaskName=row["TaskName"].ToString();
				}
				if(row["CommandID"]!=null && row["CommandID"].ToString()!="")
				{
					model.CommandID=int.Parse(row["CommandID"].ToString());
				}
				if(row["CommandInfo"]!=null)
				{
					model.CommandInfo=row["CommandInfo"].ToString();
				}
				if(row["MeterAddr"]!=null)
				{
					model.MeterAddr=row["MeterAddr"].ToString();
				}
				if(row["MeterType"]!=null && row["MeterType"].ToString()!="")
				{
					model.MeterType=int.Parse(row["MeterType"].ToString());
				}
				if(row["MeterItem"]!=null && row["MeterItem"].ToString()!="")
				{
					model.MeterItem=int.Parse(row["MeterItem"].ToString());
				}
				if(row["FreezeDate"]!=null)
				{
					model.FreezeDate=row["FreezeDate"].ToString();
				}
				if(row["TaskMonth"]!=null && row["TaskMonth"].ToString()!="")
				{
					model.TaskMonth=int.Parse(row["TaskMonth"].ToString());
				}
				if(row["TaskDay"]!=null && row["TaskDay"].ToString()!="")
				{
					model.TaskDay=int.Parse(row["TaskDay"].ToString());
				}
				if(row["TaskHour"]!=null && row["TaskHour"].ToString()!="")
				{
					model.TaskHour=int.Parse(row["TaskHour"].ToString());
				}
				if(row["TaskMinute"]!=null && row["TaskMinute"].ToString()!="")
				{
					model.TaskMinute=int.Parse(row["TaskMinute"].ToString());
				}
				if(row["ExeMark"]!=null && row["ExeMark"].ToString()!="")
				{
					model.ExeMark=int.Parse(row["ExeMark"].ToString());
				}
				if(row["ExeDate"]!=null && row["ExeDate"].ToString()!="")
				{
					model.ExeDate=DateTime.Parse(row["ExeDate"].ToString());
				}
				if(row["ExeError"]!=null && row["ExeError"].ToString()!="")
				{
					model.ExeError=int.Parse(row["ExeError"].ToString());
				}
				if(row["TaskMark"]!=null && row["TaskMark"].ToString()!="")
				{
					model.TaskMark=int.Parse(row["TaskMark"].ToString());
				}
				if(row["TaskType"]!=null && row["TaskType"].ToString()!="")
				{
					model.TaskType=int.Parse(row["TaskType"].ToString());
				}
				if(row["TaskError"]!=null && row["TaskError"].ToString()!="")
				{
					model.TaskError=int.Parse(row["TaskError"].ToString());
				}
				if(row["TryNum"]!=null && row["TryNum"].ToString()!="")
				{
					model.TryNum=int.Parse(row["TryNum"].ToString());
				}
				if(row["HostAddr"]!=null)
				{
					model.HostAddr=row["HostAddr"].ToString();
				}
				if(row["InsDate"]!=null && row["InsDate"].ToString()!="")
				{
					model.InsDate=DateTime.Parse(row["InsDate"].ToString());
				}
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["TaskFrequency"]!=null && row["TaskFrequency"].ToString()!="")
				{
					model.TaskFrequency=int.Parse(row["TaskFrequency"].ToString());
				}
				if(row["ExeInfo"]!=null)
				{
					model.ExeInfo=row["ExeInfo"].ToString();
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["DeptID"]!=null)
				{
					model.DeptID=row["DeptID"].ToString();
				}
				if(row["TaskWeek"]!=null && row["TaskWeek"].ToString()!="")
				{
					model.TaskWeek=int.Parse(row["TaskWeek"].ToString());
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
			strSql.Append("select ID,TaskID,CollectorID,TaskName,CommandID,CommandInfo,MeterAddr,MeterType,MeterItem,FreezeDate,TaskMonth,TaskDay,TaskHour,TaskMinute,ExeMark,ExeDate,ExeError,TaskMark,TaskType,TaskError,TryNum,HostAddr,InsDate,MeterID,TaskFrequency,ExeInfo,OperatorID,DeptID,TaskWeek ");
			strSql.Append(" FROM TaskPlanHistory ");
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
			strSql.Append(" ID,TaskID,CollectorID,TaskName,CommandID,CommandInfo,MeterAddr,MeterType,MeterItem,FreezeDate,TaskMonth,TaskDay,TaskHour,TaskMinute,ExeMark,ExeDate,ExeError,TaskMark,TaskType,TaskError,TryNum,HostAddr,InsDate,MeterID,TaskFrequency,ExeInfo,OperatorID,DeptID,TaskWeek ");
			strSql.Append(" FROM TaskPlanHistory ");
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
			strSql.Append("select count(1) FROM TaskPlanHistory ");
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
			strSql.Append(")AS Row, T.*  from TaskPlanHistory T ");
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
			parameters[0].Value = "TaskPlanHistory";
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

