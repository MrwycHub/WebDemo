using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:BookInfo
	/// </summary>
	public partial class BookInfo
	{
		public BookInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("BookID", "BookInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int BookID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BookInfo");
			strSql.Append(" where BookID=@BookID");
			SqlParameter[] parameters = {
					new SqlParameter("@BookID", SqlDbType.Int,4)
			};
			parameters[0].Value = BookID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.BookInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BookInfo(");
			strSql.Append("DeptIDs,BookName,WorkerID,Remark,BookCode,Routes,ReadDay,ReadType,UserNum,UpdateTime,AutoReadBeginDate,AutoReadEndDate)");
			strSql.Append(" values (");
			strSql.Append("@DeptIDs,@BookName,@WorkerID,@Remark,@BookCode,@Routes,@ReadDay,@ReadType,@UserNum,@UpdateTime,@AutoReadBeginDate,@AutoReadEndDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptIDs", SqlDbType.VarChar,500),
					new SqlParameter("@BookName", SqlDbType.VarChar,50),
					new SqlParameter("@WorkerID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@BookCode", SqlDbType.VarChar,50),
					new SqlParameter("@Routes", SqlDbType.VarChar,500),
					new SqlParameter("@ReadDay", SqlDbType.Int,4),
					new SqlParameter("@ReadType", SqlDbType.Int,4),
					new SqlParameter("@UserNum", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@AutoReadBeginDate", SqlDbType.VarChar,10),
					new SqlParameter("@AutoReadEndDate", SqlDbType.VarChar,10)};
			parameters[0].Value = model.DeptIDs;
			parameters[1].Value = model.BookName;
			parameters[2].Value = model.WorkerID;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.BookCode;
			parameters[5].Value = model.Routes;
			parameters[6].Value = model.ReadDay;
			parameters[7].Value = model.ReadType;
			parameters[8].Value = model.UserNum;
			parameters[9].Value = model.UpdateTime;
			parameters[10].Value = model.AutoReadBeginDate;
			parameters[11].Value = model.AutoReadEndDate;

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
		public bool Update(WebDemo.Model.WebDemo.BookInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BookInfo set ");
			strSql.Append("DeptIDs=@DeptIDs,");
			strSql.Append("BookName=@BookName,");
			strSql.Append("WorkerID=@WorkerID,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("BookCode=@BookCode,");
			strSql.Append("Routes=@Routes,");
			strSql.Append("ReadDay=@ReadDay,");
			strSql.Append("ReadType=@ReadType,");
			strSql.Append("UserNum=@UserNum,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("AutoReadBeginDate=@AutoReadBeginDate,");
			strSql.Append("AutoReadEndDate=@AutoReadEndDate");
			strSql.Append(" where BookID=@BookID");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptIDs", SqlDbType.VarChar,500),
					new SqlParameter("@BookName", SqlDbType.VarChar,50),
					new SqlParameter("@WorkerID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@BookCode", SqlDbType.VarChar,50),
					new SqlParameter("@Routes", SqlDbType.VarChar,500),
					new SqlParameter("@ReadDay", SqlDbType.Int,4),
					new SqlParameter("@ReadType", SqlDbType.Int,4),
					new SqlParameter("@UserNum", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@AutoReadBeginDate", SqlDbType.VarChar,10),
					new SqlParameter("@AutoReadEndDate", SqlDbType.VarChar,10),
					new SqlParameter("@BookID", SqlDbType.Int,4)};
			parameters[0].Value = model.DeptIDs;
			parameters[1].Value = model.BookName;
			parameters[2].Value = model.WorkerID;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.BookCode;
			parameters[5].Value = model.Routes;
			parameters[6].Value = model.ReadDay;
			parameters[7].Value = model.ReadType;
			parameters[8].Value = model.UserNum;
			parameters[9].Value = model.UpdateTime;
			parameters[10].Value = model.AutoReadBeginDate;
			parameters[11].Value = model.AutoReadEndDate;
			parameters[12].Value = model.BookID;

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
		public bool Delete(int BookID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BookInfo ");
			strSql.Append(" where BookID=@BookID");
			SqlParameter[] parameters = {
					new SqlParameter("@BookID", SqlDbType.Int,4)
			};
			parameters[0].Value = BookID;

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
		public bool DeleteList(string BookIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BookInfo ");
			strSql.Append(" where BookID in ("+BookIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.BookInfo GetModel(int BookID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BookID,DeptIDs,BookName,WorkerID,Remark,BookCode,Routes,ReadDay,ReadType,UserNum,UpdateTime,AutoReadBeginDate,AutoReadEndDate from BookInfo ");
			strSql.Append(" where BookID=@BookID");
			SqlParameter[] parameters = {
					new SqlParameter("@BookID", SqlDbType.Int,4)
			};
			parameters[0].Value = BookID;

			WebDemo.Model.WebDemo.BookInfo model=new WebDemo.Model.WebDemo.BookInfo();
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
		public WebDemo.Model.WebDemo.BookInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.BookInfo model=new WebDemo.Model.WebDemo.BookInfo();
			if (row != null)
			{
				if(row["BookID"]!=null && row["BookID"].ToString()!="")
				{
					model.BookID=int.Parse(row["BookID"].ToString());
				}
				if(row["DeptIDs"]!=null)
				{
					model.DeptIDs=row["DeptIDs"].ToString();
				}
				if(row["BookName"]!=null)
				{
					model.BookName=row["BookName"].ToString();
				}
				if(row["WorkerID"]!=null && row["WorkerID"].ToString()!="")
				{
					model.WorkerID=int.Parse(row["WorkerID"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["BookCode"]!=null)
				{
					model.BookCode=row["BookCode"].ToString();
				}
				if(row["Routes"]!=null)
				{
					model.Routes=row["Routes"].ToString();
				}
				if(row["ReadDay"]!=null && row["ReadDay"].ToString()!="")
				{
					model.ReadDay=int.Parse(row["ReadDay"].ToString());
				}
				if(row["ReadType"]!=null && row["ReadType"].ToString()!="")
				{
					model.ReadType=int.Parse(row["ReadType"].ToString());
				}
				if(row["UserNum"]!=null && row["UserNum"].ToString()!="")
				{
					model.UserNum=int.Parse(row["UserNum"].ToString());
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
				}
				if(row["AutoReadBeginDate"]!=null)
				{
					model.AutoReadBeginDate=row["AutoReadBeginDate"].ToString();
				}
				if(row["AutoReadEndDate"]!=null)
				{
					model.AutoReadEndDate=row["AutoReadEndDate"].ToString();
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
			strSql.Append("select BookID,DeptIDs,BookName,WorkerID,Remark,BookCode,Routes,ReadDay,ReadType,UserNum,UpdateTime,AutoReadBeginDate,AutoReadEndDate ");
			strSql.Append(" FROM BookInfo ");
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
			strSql.Append(" BookID,DeptIDs,BookName,WorkerID,Remark,BookCode,Routes,ReadDay,ReadType,UserNum,UpdateTime,AutoReadBeginDate,AutoReadEndDate ");
			strSql.Append(" FROM BookInfo ");
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
			strSql.Append("select count(1) FROM BookInfo ");
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
				strSql.Append("order by T.BookID desc");
			}
			strSql.Append(")AS Row, T.*  from BookInfo T ");
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
			parameters[0].Value = "BookInfo";
			parameters[1].Value = "BookID";
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

