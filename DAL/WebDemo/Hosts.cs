using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Hosts
	/// </summary>
	public partial class Hosts
	{
		public Hosts()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("HostID", "Hosts"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int HostID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Hosts");
			strSql.Append(" where HostID=@HostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@HostID", SqlDbType.Int,4)			};
			parameters[0].Value = HostID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.Hosts model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Hosts(");
			strSql.Append("CollectorID,HostID,HostName,HostAddr,Remark,flag,LimitNum,HostComType,HostType,HostRDate,DownloadFlag,PowerType,HostNo,HostLimitNum,IsRelay,IsDownMeterType)");
			strSql.Append(" values (");
			strSql.Append("@CollectorID,@HostID,@HostName,@HostAddr,@Remark,@flag,@LimitNum,@HostComType,@HostType,@HostRDate,@DownloadFlag,@PowerType,@HostNo,@HostLimitNum,@IsRelay,@IsDownMeterType)");
			SqlParameter[] parameters = {
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@HostID", SqlDbType.Int,4),
					new SqlParameter("@HostName", SqlDbType.VarChar,50),
					new SqlParameter("@HostAddr", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@LimitNum", SqlDbType.Int,4),
					new SqlParameter("@HostComType", SqlDbType.Int,4),
					new SqlParameter("@HostType", SqlDbType.Int,4),
					new SqlParameter("@HostRDate", SqlDbType.VarChar,10),
					new SqlParameter("@DownloadFlag", SqlDbType.Int,4),
					new SqlParameter("@PowerType", SqlDbType.Int,4),
					new SqlParameter("@HostNo", SqlDbType.Int,4),
					new SqlParameter("@HostLimitNum", SqlDbType.Int,4),
					new SqlParameter("@IsRelay", SqlDbType.Int,4),
					new SqlParameter("@IsDownMeterType", SqlDbType.Int,4)};
			parameters[0].Value = model.CollectorID;
			parameters[1].Value = model.HostID;
			parameters[2].Value = model.HostName;
			parameters[3].Value = model.HostAddr;
			parameters[4].Value = model.Remark;
			parameters[5].Value = model.flag;
			parameters[6].Value = model.LimitNum;
			parameters[7].Value = model.HostComType;
			parameters[8].Value = model.HostType;
			parameters[9].Value = model.HostRDate;
			parameters[10].Value = model.DownloadFlag;
			parameters[11].Value = model.PowerType;
			parameters[12].Value = model.HostNo;
			parameters[13].Value = model.HostLimitNum;
			parameters[14].Value = model.IsRelay;
			parameters[15].Value = model.IsDownMeterType;

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
		public bool Update(WebDemo.Model.WebDemo.Hosts model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Hosts set ");
			strSql.Append("CollectorID=@CollectorID,");
			strSql.Append("HostName=@HostName,");
			strSql.Append("HostAddr=@HostAddr,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("flag=@flag,");
			strSql.Append("LimitNum=@LimitNum,");
			strSql.Append("HostComType=@HostComType,");
			strSql.Append("HostType=@HostType,");
			strSql.Append("HostRDate=@HostRDate,");
			strSql.Append("DownloadFlag=@DownloadFlag,");
			strSql.Append("PowerType=@PowerType,");
			strSql.Append("HostNo=@HostNo,");
			strSql.Append("HostLimitNum=@HostLimitNum,");
			strSql.Append("IsRelay=@IsRelay,");
			strSql.Append("IsDownMeterType=@IsDownMeterType");
			strSql.Append(" where HostID=@HostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@HostName", SqlDbType.VarChar,50),
					new SqlParameter("@HostAddr", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@flag", SqlDbType.Int,4),
					new SqlParameter("@LimitNum", SqlDbType.Int,4),
					new SqlParameter("@HostComType", SqlDbType.Int,4),
					new SqlParameter("@HostType", SqlDbType.Int,4),
					new SqlParameter("@HostRDate", SqlDbType.VarChar,10),
					new SqlParameter("@DownloadFlag", SqlDbType.Int,4),
					new SqlParameter("@PowerType", SqlDbType.Int,4),
					new SqlParameter("@HostNo", SqlDbType.Int,4),
					new SqlParameter("@HostLimitNum", SqlDbType.Int,4),
					new SqlParameter("@IsRelay", SqlDbType.Int,4),
					new SqlParameter("@IsDownMeterType", SqlDbType.Int,4),
					new SqlParameter("@HostID", SqlDbType.Int,4)};
			parameters[0].Value = model.CollectorID;
			parameters[1].Value = model.HostName;
			parameters[2].Value = model.HostAddr;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.flag;
			parameters[5].Value = model.LimitNum;
			parameters[6].Value = model.HostComType;
			parameters[7].Value = model.HostType;
			parameters[8].Value = model.HostRDate;
			parameters[9].Value = model.DownloadFlag;
			parameters[10].Value = model.PowerType;
			parameters[11].Value = model.HostNo;
			parameters[12].Value = model.HostLimitNum;
			parameters[13].Value = model.IsRelay;
			parameters[14].Value = model.IsDownMeterType;
			parameters[15].Value = model.HostID;

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
		public bool Delete(int HostID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Hosts ");
			strSql.Append(" where HostID=@HostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@HostID", SqlDbType.Int,4)			};
			parameters[0].Value = HostID;

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
		public bool DeleteList(string HostIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Hosts ");
			strSql.Append(" where HostID in ("+HostIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.Hosts GetModel(int HostID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CollectorID,HostID,HostName,HostAddr,Remark,flag,LimitNum,HostComType,HostType,HostRDate,DownloadFlag,PowerType,HostNo,HostLimitNum,IsRelay,IsDownMeterType from Hosts ");
			strSql.Append(" where HostID=@HostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@HostID", SqlDbType.Int,4)			};
			parameters[0].Value = HostID;

			WebDemo.Model.WebDemo.Hosts model=new WebDemo.Model.WebDemo.Hosts();
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
		public WebDemo.Model.WebDemo.Hosts DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Hosts model=new WebDemo.Model.WebDemo.Hosts();
			if (row != null)
			{
				if(row["CollectorID"]!=null && row["CollectorID"].ToString()!="")
				{
					model.CollectorID=int.Parse(row["CollectorID"].ToString());
				}
				if(row["HostID"]!=null && row["HostID"].ToString()!="")
				{
					model.HostID=int.Parse(row["HostID"].ToString());
				}
				if(row["HostName"]!=null)
				{
					model.HostName=row["HostName"].ToString();
				}
				if(row["HostAddr"]!=null)
				{
					model.HostAddr=row["HostAddr"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["flag"]!=null && row["flag"].ToString()!="")
				{
					model.flag=int.Parse(row["flag"].ToString());
				}
				if(row["LimitNum"]!=null && row["LimitNum"].ToString()!="")
				{
					model.LimitNum=int.Parse(row["LimitNum"].ToString());
				}
				if(row["HostComType"]!=null && row["HostComType"].ToString()!="")
				{
					model.HostComType=int.Parse(row["HostComType"].ToString());
				}
				if(row["HostType"]!=null && row["HostType"].ToString()!="")
				{
					model.HostType=int.Parse(row["HostType"].ToString());
				}
				if(row["HostRDate"]!=null)
				{
					model.HostRDate=row["HostRDate"].ToString();
				}
				if(row["DownloadFlag"]!=null && row["DownloadFlag"].ToString()!="")
				{
					model.DownloadFlag=int.Parse(row["DownloadFlag"].ToString());
				}
				if(row["PowerType"]!=null && row["PowerType"].ToString()!="")
				{
					model.PowerType=int.Parse(row["PowerType"].ToString());
				}
				if(row["HostNo"]!=null && row["HostNo"].ToString()!="")
				{
					model.HostNo=int.Parse(row["HostNo"].ToString());
				}
				if(row["HostLimitNum"]!=null && row["HostLimitNum"].ToString()!="")
				{
					model.HostLimitNum=int.Parse(row["HostLimitNum"].ToString());
				}
				if(row["IsRelay"]!=null && row["IsRelay"].ToString()!="")
				{
					model.IsRelay=int.Parse(row["IsRelay"].ToString());
				}
				if(row["IsDownMeterType"]!=null && row["IsDownMeterType"].ToString()!="")
				{
					model.IsDownMeterType=int.Parse(row["IsDownMeterType"].ToString());
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
			strSql.Append("select CollectorID,HostID,HostName,HostAddr,Remark,flag,LimitNum,HostComType,HostType,HostRDate,DownloadFlag,PowerType,HostNo,HostLimitNum,IsRelay,IsDownMeterType ");
			strSql.Append(" FROM Hosts ");
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
			strSql.Append(" CollectorID,HostID,HostName,HostAddr,Remark,flag,LimitNum,HostComType,HostType,HostRDate,DownloadFlag,PowerType,HostNo,HostLimitNum,IsRelay,IsDownMeterType ");
			strSql.Append(" FROM Hosts ");
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
			strSql.Append("select count(1) FROM Hosts ");
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
				strSql.Append("order by T.HostID desc");
			}
			strSql.Append(")AS Row, T.*  from Hosts T ");
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
			parameters[0].Value = "Hosts";
			parameters[1].Value = "HostID";
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

