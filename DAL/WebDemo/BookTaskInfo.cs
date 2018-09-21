using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:BookTaskInfo
	/// </summary>
	public partial class BookTaskInfo
	{
		public BookTaskInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "BookTaskInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BookTaskInfo");
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
		public int Add(WebDemo.Model.WebDemo.BookTaskInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BookTaskInfo(");
			strSql.Append("BookID,ReadDate,BookCode,BookName,OperatorID,Remark,Routes,UserNum,FactNum,UpdateTime)");
			strSql.Append(" values (");
			strSql.Append("@BookID,@ReadDate,@BookCode,@BookName,@OperatorID,@Remark,@Routes,@UserNum,@FactNum,@UpdateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@BookID", SqlDbType.Int,4),
					new SqlParameter("@ReadDate", SqlDbType.VarChar,50),
					new SqlParameter("@BookCode", SqlDbType.VarChar,50),
					new SqlParameter("@BookName", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,100),
					new SqlParameter("@Routes", SqlDbType.VarChar,500),
					new SqlParameter("@UserNum", SqlDbType.Int,4),
					new SqlParameter("@FactNum", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.BookID;
			parameters[1].Value = model.ReadDate;
			parameters[2].Value = model.BookCode;
			parameters[3].Value = model.BookName;
			parameters[4].Value = model.OperatorID;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.Routes;
			parameters[7].Value = model.UserNum;
			parameters[8].Value = model.FactNum;
			parameters[9].Value = model.UpdateTime;

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
		public bool Update(WebDemo.Model.WebDemo.BookTaskInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BookTaskInfo set ");
			strSql.Append("BookID=@BookID,");
			strSql.Append("ReadDate=@ReadDate,");
			strSql.Append("BookCode=@BookCode,");
			strSql.Append("BookName=@BookName,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Routes=@Routes,");
			strSql.Append("UserNum=@UserNum,");
			strSql.Append("FactNum=@FactNum,");
			strSql.Append("UpdateTime=@UpdateTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@BookID", SqlDbType.Int,4),
					new SqlParameter("@ReadDate", SqlDbType.VarChar,50),
					new SqlParameter("@BookCode", SqlDbType.VarChar,50),
					new SqlParameter("@BookName", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,100),
					new SqlParameter("@Routes", SqlDbType.VarChar,500),
					new SqlParameter("@UserNum", SqlDbType.Int,4),
					new SqlParameter("@FactNum", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.BookID;
			parameters[1].Value = model.ReadDate;
			parameters[2].Value = model.BookCode;
			parameters[3].Value = model.BookName;
			parameters[4].Value = model.OperatorID;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.Routes;
			parameters[7].Value = model.UserNum;
			parameters[8].Value = model.FactNum;
			parameters[9].Value = model.UpdateTime;
			parameters[10].Value = model.ID;

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
			strSql.Append("delete from BookTaskInfo ");
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
			strSql.Append("delete from BookTaskInfo ");
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
		public WebDemo.Model.WebDemo.BookTaskInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,BookID,ReadDate,BookCode,BookName,OperatorID,Remark,Routes,UserNum,FactNum,UpdateTime from BookTaskInfo ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.BookTaskInfo model=new WebDemo.Model.WebDemo.BookTaskInfo();
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
		public WebDemo.Model.WebDemo.BookTaskInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.BookTaskInfo model=new WebDemo.Model.WebDemo.BookTaskInfo();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["BookID"]!=null && row["BookID"].ToString()!="")
				{
					model.BookID=int.Parse(row["BookID"].ToString());
				}
				if(row["ReadDate"]!=null)
				{
					model.ReadDate=row["ReadDate"].ToString();
				}
				if(row["BookCode"]!=null)
				{
					model.BookCode=row["BookCode"].ToString();
				}
				if(row["BookName"]!=null)
				{
					model.BookName=row["BookName"].ToString();
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["Routes"]!=null)
				{
					model.Routes=row["Routes"].ToString();
				}
				if(row["UserNum"]!=null && row["UserNum"].ToString()!="")
				{
					model.UserNum=int.Parse(row["UserNum"].ToString());
				}
				if(row["FactNum"]!=null && row["FactNum"].ToString()!="")
				{
					model.FactNum=int.Parse(row["FactNum"].ToString());
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
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
			strSql.Append("select ID,BookID,ReadDate,BookCode,BookName,OperatorID,Remark,Routes,UserNum,FactNum,UpdateTime ");
			strSql.Append(" FROM BookTaskInfo ");
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
			strSql.Append(" ID,BookID,ReadDate,BookCode,BookName,OperatorID,Remark,Routes,UserNum,FactNum,UpdateTime ");
			strSql.Append(" FROM BookTaskInfo ");
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
			strSql.Append("select count(1) FROM BookTaskInfo ");
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
			strSql.Append(")AS Row, T.*  from BookTaskInfo T ");
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
			parameters[0].Value = "BookTaskInfo";
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

