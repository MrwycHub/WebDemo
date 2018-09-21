using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:ReportFiles
	/// </summary>
	public partial class ReportFiles
	{
		public ReportFiles()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ReportName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ReportFiles");
			strSql.Append(" where ReportName=@ReportName ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReportName", SqlDbType.VarChar,50)			};
			parameters[0].Value = ReportName;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.ReportFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ReportFiles(");
			strSql.Append("ReportID,ReportName,ReportType,ReportFileName,ReportDbType,ReportSql,ReportServiceUrl,ReportRole,OperatorID,InsDate,Remark)");
			strSql.Append(" values (");
			strSql.Append("@ReportID,@ReportName,@ReportType,@ReportFileName,@ReportDbType,@ReportSql,@ReportServiceUrl,@ReportRole,@OperatorID,@InsDate,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ReportID", SqlDbType.VarChar,50),
					new SqlParameter("@ReportName", SqlDbType.VarChar,50),
					new SqlParameter("@ReportType", SqlDbType.VarChar,10),
					new SqlParameter("@ReportFileName", SqlDbType.VarChar,50),
					new SqlParameter("@ReportDbType", SqlDbType.Int,4),
					new SqlParameter("@ReportSql", SqlDbType.VarChar,1000),
					new SqlParameter("@ReportServiceUrl", SqlDbType.VarChar,500),
					new SqlParameter("@ReportRole", SqlDbType.Int,4),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@InsDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,100)};
			parameters[0].Value = model.ReportID;
			parameters[1].Value = model.ReportName;
			parameters[2].Value = model.ReportType;
			parameters[3].Value = model.ReportFileName;
			parameters[4].Value = model.ReportDbType;
			parameters[5].Value = model.ReportSql;
			parameters[6].Value = model.ReportServiceUrl;
			parameters[7].Value = model.ReportRole;
			parameters[8].Value = model.OperatorID;
			parameters[9].Value = model.InsDate;
			parameters[10].Value = model.Remark;

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
		public bool Update(WebDemo.Model.WebDemo.ReportFiles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ReportFiles set ");
			strSql.Append("ReportID=@ReportID,");
			strSql.Append("ReportType=@ReportType,");
			strSql.Append("ReportFileName=@ReportFileName,");
			strSql.Append("ReportDbType=@ReportDbType,");
			strSql.Append("ReportSql=@ReportSql,");
			strSql.Append("ReportServiceUrl=@ReportServiceUrl,");
			strSql.Append("ReportRole=@ReportRole,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("InsDate=@InsDate,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ReportID", SqlDbType.VarChar,50),
					new SqlParameter("@ReportType", SqlDbType.VarChar,10),
					new SqlParameter("@ReportFileName", SqlDbType.VarChar,50),
					new SqlParameter("@ReportDbType", SqlDbType.Int,4),
					new SqlParameter("@ReportSql", SqlDbType.VarChar,1000),
					new SqlParameter("@ReportServiceUrl", SqlDbType.VarChar,500),
					new SqlParameter("@ReportRole", SqlDbType.Int,4),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@InsDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,100),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ReportName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ReportID;
			parameters[1].Value = model.ReportType;
			parameters[2].Value = model.ReportFileName;
			parameters[3].Value = model.ReportDbType;
			parameters[4].Value = model.ReportSql;
			parameters[5].Value = model.ReportServiceUrl;
			parameters[6].Value = model.ReportRole;
			parameters[7].Value = model.OperatorID;
			parameters[8].Value = model.InsDate;
			parameters[9].Value = model.Remark;
			parameters[10].Value = model.ID;
			parameters[11].Value = model.ReportName;

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
			strSql.Append("delete from ReportFiles ");
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ReportName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ReportFiles ");
			strSql.Append(" where ReportName=@ReportName ");
			SqlParameter[] parameters = {
					new SqlParameter("@ReportName", SqlDbType.VarChar,50)			};
			parameters[0].Value = ReportName;

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
			strSql.Append("delete from ReportFiles ");
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
		public WebDemo.Model.WebDemo.ReportFiles GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ReportID,ReportName,ReportType,ReportFileName,ReportDbType,ReportSql,ReportServiceUrl,ReportRole,OperatorID,InsDate,Remark from ReportFiles ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.ReportFiles model=new WebDemo.Model.WebDemo.ReportFiles();
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
		public WebDemo.Model.WebDemo.ReportFiles DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.ReportFiles model=new WebDemo.Model.WebDemo.ReportFiles();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["ReportID"]!=null)
				{
					model.ReportID=row["ReportID"].ToString();
				}
				if(row["ReportName"]!=null)
				{
					model.ReportName=row["ReportName"].ToString();
				}
				if(row["ReportType"]!=null)
				{
					model.ReportType=row["ReportType"].ToString();
				}
				if(row["ReportFileName"]!=null)
				{
					model.ReportFileName=row["ReportFileName"].ToString();
				}
				if(row["ReportDbType"]!=null && row["ReportDbType"].ToString()!="")
				{
					model.ReportDbType=int.Parse(row["ReportDbType"].ToString());
				}
				if(row["ReportSql"]!=null)
				{
					model.ReportSql=row["ReportSql"].ToString();
				}
				if(row["ReportServiceUrl"]!=null)
				{
					model.ReportServiceUrl=row["ReportServiceUrl"].ToString();
				}
				if(row["ReportRole"]!=null && row["ReportRole"].ToString()!="")
				{
					model.ReportRole=int.Parse(row["ReportRole"].ToString());
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["InsDate"]!=null && row["InsDate"].ToString()!="")
				{
					model.InsDate=DateTime.Parse(row["InsDate"].ToString());
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
			strSql.Append("select ID,ReportID,ReportName,ReportType,ReportFileName,ReportDbType,ReportSql,ReportServiceUrl,ReportRole,OperatorID,InsDate,Remark ");
			strSql.Append(" FROM ReportFiles ");
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
			strSql.Append(" ID,ReportID,ReportName,ReportType,ReportFileName,ReportDbType,ReportSql,ReportServiceUrl,ReportRole,OperatorID,InsDate,Remark ");
			strSql.Append(" FROM ReportFiles ");
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
			strSql.Append("select count(1) FROM ReportFiles ");
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
			strSql.Append(")AS Row, T.*  from ReportFiles T ");
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
			parameters[0].Value = "ReportFiles";
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

