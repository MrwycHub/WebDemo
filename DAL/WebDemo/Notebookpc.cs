using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Notebookpc
	/// </summary>
	public partial class Notebookpc
	{
		public Notebookpc()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string NoteBookID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Notebookpc");
			strSql.Append(" where NoteBookID=@NoteBookID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NoteBookID", SqlDbType.VarChar,20)			};
			parameters[0].Value = NoteBookID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.Notebookpc model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Notebookpc(");
			strSql.Append("NoteBookID,NoteBookName,ReMark)");
			strSql.Append(" values (");
			strSql.Append("@NoteBookID,@NoteBookName,@ReMark)");
			SqlParameter[] parameters = {
					new SqlParameter("@NoteBookID", SqlDbType.VarChar,20),
					new SqlParameter("@NoteBookName", SqlDbType.VarChar,50),
					new SqlParameter("@ReMark", SqlDbType.VarChar,200)};
			parameters[0].Value = model.NoteBookID;
			parameters[1].Value = model.NoteBookName;
			parameters[2].Value = model.ReMark;

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
		public bool Update(WebDemo.Model.WebDemo.Notebookpc model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Notebookpc set ");
			strSql.Append("NoteBookName=@NoteBookName,");
			strSql.Append("ReMark=@ReMark");
			strSql.Append(" where NoteBookID=@NoteBookID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NoteBookName", SqlDbType.VarChar,50),
					new SqlParameter("@ReMark", SqlDbType.VarChar,200),
					new SqlParameter("@NoteBookID", SqlDbType.VarChar,20)};
			parameters[0].Value = model.NoteBookName;
			parameters[1].Value = model.ReMark;
			parameters[2].Value = model.NoteBookID;

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
		public bool Delete(string NoteBookID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Notebookpc ");
			strSql.Append(" where NoteBookID=@NoteBookID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NoteBookID", SqlDbType.VarChar,20)			};
			parameters[0].Value = NoteBookID;

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
		public bool DeleteList(string NoteBookIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Notebookpc ");
			strSql.Append(" where NoteBookID in ("+NoteBookIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.Notebookpc GetModel(string NoteBookID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 NoteBookID,NoteBookName,ReMark from Notebookpc ");
			strSql.Append(" where NoteBookID=@NoteBookID ");
			SqlParameter[] parameters = {
					new SqlParameter("@NoteBookID", SqlDbType.VarChar,20)			};
			parameters[0].Value = NoteBookID;

			WebDemo.Model.WebDemo.Notebookpc model=new WebDemo.Model.WebDemo.Notebookpc();
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
		public WebDemo.Model.WebDemo.Notebookpc DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Notebookpc model=new WebDemo.Model.WebDemo.Notebookpc();
			if (row != null)
			{
				if(row["NoteBookID"]!=null)
				{
					model.NoteBookID=row["NoteBookID"].ToString();
				}
				if(row["NoteBookName"]!=null)
				{
					model.NoteBookName=row["NoteBookName"].ToString();
				}
				if(row["ReMark"]!=null)
				{
					model.ReMark=row["ReMark"].ToString();
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
			strSql.Append("select NoteBookID,NoteBookName,ReMark ");
			strSql.Append(" FROM Notebookpc ");
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
			strSql.Append(" NoteBookID,NoteBookName,ReMark ");
			strSql.Append(" FROM Notebookpc ");
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
			strSql.Append("select count(1) FROM Notebookpc ");
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
				strSql.Append("order by T.NoteBookID desc");
			}
			strSql.Append(")AS Row, T.*  from Notebookpc T ");
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
			parameters[0].Value = "Notebookpc";
			parameters[1].Value = "NoteBookID";
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

