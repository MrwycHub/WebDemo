using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:CollectServer
	/// </summary>
	public partial class CollectServer
	{
		public CollectServer()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ServerId", "CollectServer"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ServerId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CollectServer");
			strSql.Append(" where ServerId=@ServerId");
			SqlParameter[] parameters = {
					new SqlParameter("@ServerId", SqlDbType.Int,4)
			};
			parameters[0].Value = ServerId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.CollectServer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CollectServer(");
			strSql.Append("ServerName,ServerType,ServerIp,WcfUrl,OperTime,Remark,Port)");
			strSql.Append(" values (");
			strSql.Append("@ServerName,@ServerType,@ServerIp,@WcfUrl,@OperTime,@Remark,@Port)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ServerName", SqlDbType.VarChar,50),
					new SqlParameter("@ServerType", SqlDbType.Int,4),
					new SqlParameter("@ServerIp", SqlDbType.VarChar,50),
					new SqlParameter("@WcfUrl", SqlDbType.VarChar,50),
					new SqlParameter("@OperTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,100),
					new SqlParameter("@Port", SqlDbType.Int,4)};
			parameters[0].Value = model.ServerName;
			parameters[1].Value = model.ServerType;
			parameters[2].Value = model.ServerIp;
			parameters[3].Value = model.WcfUrl;
			parameters[4].Value = model.OperTime;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.Port;

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
		public bool Update(WebDemo.Model.WebDemo.CollectServer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CollectServer set ");
			strSql.Append("ServerName=@ServerName,");
			strSql.Append("ServerType=@ServerType,");
			strSql.Append("ServerIp=@ServerIp,");
			strSql.Append("WcfUrl=@WcfUrl,");
			strSql.Append("OperTime=@OperTime,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Port=@Port");
			strSql.Append(" where ServerId=@ServerId");
			SqlParameter[] parameters = {
					new SqlParameter("@ServerName", SqlDbType.VarChar,50),
					new SqlParameter("@ServerType", SqlDbType.Int,4),
					new SqlParameter("@ServerIp", SqlDbType.VarChar,50),
					new SqlParameter("@WcfUrl", SqlDbType.VarChar,50),
					new SqlParameter("@OperTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,100),
					new SqlParameter("@Port", SqlDbType.Int,4),
					new SqlParameter("@ServerId", SqlDbType.Int,4)};
			parameters[0].Value = model.ServerName;
			parameters[1].Value = model.ServerType;
			parameters[2].Value = model.ServerIp;
			parameters[3].Value = model.WcfUrl;
			parameters[4].Value = model.OperTime;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.Port;
			parameters[7].Value = model.ServerId;

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
		public bool Delete(int ServerId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CollectServer ");
			strSql.Append(" where ServerId=@ServerId");
			SqlParameter[] parameters = {
					new SqlParameter("@ServerId", SqlDbType.Int,4)
			};
			parameters[0].Value = ServerId;

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
		public bool DeleteList(string ServerIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CollectServer ");
			strSql.Append(" where ServerId in ("+ServerIdlist + ")  ");
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
		public WebDemo.Model.WebDemo.CollectServer GetModel(int ServerId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ServerId,ServerName,ServerType,ServerIp,WcfUrl,OperTime,Remark,Port from CollectServer ");
			strSql.Append(" where ServerId=@ServerId");
			SqlParameter[] parameters = {
					new SqlParameter("@ServerId", SqlDbType.Int,4)
			};
			parameters[0].Value = ServerId;

			WebDemo.Model.WebDemo.CollectServer model=new WebDemo.Model.WebDemo.CollectServer();
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
		public WebDemo.Model.WebDemo.CollectServer DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.CollectServer model=new WebDemo.Model.WebDemo.CollectServer();
			if (row != null)
			{
				if(row["ServerId"]!=null && row["ServerId"].ToString()!="")
				{
					model.ServerId=int.Parse(row["ServerId"].ToString());
				}
				if(row["ServerName"]!=null)
				{
					model.ServerName=row["ServerName"].ToString();
				}
				if(row["ServerType"]!=null && row["ServerType"].ToString()!="")
				{
					model.ServerType=int.Parse(row["ServerType"].ToString());
				}
				if(row["ServerIp"]!=null)
				{
					model.ServerIp=row["ServerIp"].ToString();
				}
				if(row["WcfUrl"]!=null)
				{
					model.WcfUrl=row["WcfUrl"].ToString();
				}
				if(row["OperTime"]!=null && row["OperTime"].ToString()!="")
				{
					model.OperTime=DateTime.Parse(row["OperTime"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["Port"]!=null && row["Port"].ToString()!="")
				{
					model.Port=int.Parse(row["Port"].ToString());
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
			strSql.Append("select ServerId,ServerName,ServerType,ServerIp,WcfUrl,OperTime,Remark,Port ");
			strSql.Append(" FROM CollectServer ");
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
			strSql.Append(" ServerId,ServerName,ServerType,ServerIp,WcfUrl,OperTime,Remark,Port ");
			strSql.Append(" FROM CollectServer ");
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
			strSql.Append("select count(1) FROM CollectServer ");
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
				strSql.Append("order by T.ServerId desc");
			}
			strSql.Append(")AS Row, T.*  from CollectServer T ");
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
			parameters[0].Value = "CollectServer";
			parameters[1].Value = "ServerId";
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

