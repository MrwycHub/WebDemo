using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:LostInfo
	/// </summary>
	public partial class LostInfo
	{
		public LostInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("LostID", "LostInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int LostID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LostInfo");
			strSql.Append(" where LostID=@LostID");
			SqlParameter[] parameters = {
					new SqlParameter("@LostID", SqlDbType.Int,4)
			};
			parameters[0].Value = LostID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.LostInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LostInfo(");
			strSql.Append("MultiUserID,CardID,LostDate,DownloadDate,SuccessMeterID,SuccessDate)");
			strSql.Append(" values (");
			strSql.Append("@MultiUserID,@CardID,@LostDate,@DownloadDate,@SuccessMeterID,@SuccessDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MultiUserID", SqlDbType.Int,4),
					new SqlParameter("@CardID", SqlDbType.Int,4),
					new SqlParameter("@LostDate", SqlDbType.DateTime),
					new SqlParameter("@DownloadDate", SqlDbType.DateTime),
					new SqlParameter("@SuccessMeterID", SqlDbType.Int,4),
					new SqlParameter("@SuccessDate", SqlDbType.DateTime)};
			parameters[0].Value = model.MultiUserID;
			parameters[1].Value = model.CardID;
			parameters[2].Value = model.LostDate;
			parameters[3].Value = model.DownloadDate;
			parameters[4].Value = model.SuccessMeterID;
			parameters[5].Value = model.SuccessDate;

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
		public bool Update(WebDemo.Model.WebDemo.LostInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LostInfo set ");
			strSql.Append("MultiUserID=@MultiUserID,");
			strSql.Append("CardID=@CardID,");
			strSql.Append("LostDate=@LostDate,");
			strSql.Append("DownloadDate=@DownloadDate,");
			strSql.Append("SuccessMeterID=@SuccessMeterID,");
			strSql.Append("SuccessDate=@SuccessDate");
			strSql.Append(" where LostID=@LostID");
			SqlParameter[] parameters = {
					new SqlParameter("@MultiUserID", SqlDbType.Int,4),
					new SqlParameter("@CardID", SqlDbType.Int,4),
					new SqlParameter("@LostDate", SqlDbType.DateTime),
					new SqlParameter("@DownloadDate", SqlDbType.DateTime),
					new SqlParameter("@SuccessMeterID", SqlDbType.Int,4),
					new SqlParameter("@SuccessDate", SqlDbType.DateTime),
					new SqlParameter("@LostID", SqlDbType.Int,4)};
			parameters[0].Value = model.MultiUserID;
			parameters[1].Value = model.CardID;
			parameters[2].Value = model.LostDate;
			parameters[3].Value = model.DownloadDate;
			parameters[4].Value = model.SuccessMeterID;
			parameters[5].Value = model.SuccessDate;
			parameters[6].Value = model.LostID;

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
		public bool Delete(int LostID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LostInfo ");
			strSql.Append(" where LostID=@LostID");
			SqlParameter[] parameters = {
					new SqlParameter("@LostID", SqlDbType.Int,4)
			};
			parameters[0].Value = LostID;

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
		public bool DeleteList(string LostIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LostInfo ");
			strSql.Append(" where LostID in ("+LostIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.LostInfo GetModel(int LostID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 LostID,MultiUserID,CardID,LostDate,DownloadDate,SuccessMeterID,SuccessDate from LostInfo ");
			strSql.Append(" where LostID=@LostID");
			SqlParameter[] parameters = {
					new SqlParameter("@LostID", SqlDbType.Int,4)
			};
			parameters[0].Value = LostID;

			WebDemo.Model.WebDemo.LostInfo model=new WebDemo.Model.WebDemo.LostInfo();
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
		public WebDemo.Model.WebDemo.LostInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.LostInfo model=new WebDemo.Model.WebDemo.LostInfo();
			if (row != null)
			{
				if(row["LostID"]!=null && row["LostID"].ToString()!="")
				{
					model.LostID=int.Parse(row["LostID"].ToString());
				}
				if(row["MultiUserID"]!=null && row["MultiUserID"].ToString()!="")
				{
					model.MultiUserID=int.Parse(row["MultiUserID"].ToString());
				}
				if(row["CardID"]!=null && row["CardID"].ToString()!="")
				{
					model.CardID=int.Parse(row["CardID"].ToString());
				}
				if(row["LostDate"]!=null && row["LostDate"].ToString()!="")
				{
					model.LostDate=DateTime.Parse(row["LostDate"].ToString());
				}
				if(row["DownloadDate"]!=null && row["DownloadDate"].ToString()!="")
				{
					model.DownloadDate=DateTime.Parse(row["DownloadDate"].ToString());
				}
				if(row["SuccessMeterID"]!=null && row["SuccessMeterID"].ToString()!="")
				{
					model.SuccessMeterID=int.Parse(row["SuccessMeterID"].ToString());
				}
				if(row["SuccessDate"]!=null && row["SuccessDate"].ToString()!="")
				{
					model.SuccessDate=DateTime.Parse(row["SuccessDate"].ToString());
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
			strSql.Append("select LostID,MultiUserID,CardID,LostDate,DownloadDate,SuccessMeterID,SuccessDate ");
			strSql.Append(" FROM LostInfo ");
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
			strSql.Append(" LostID,MultiUserID,CardID,LostDate,DownloadDate,SuccessMeterID,SuccessDate ");
			strSql.Append(" FROM LostInfo ");
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
			strSql.Append("select count(1) FROM LostInfo ");
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
				strSql.Append("order by T.LostID desc");
			}
			strSql.Append(")AS Row, T.*  from LostInfo T ");
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
			parameters[0].Value = "LostInfo";
			parameters[1].Value = "LostID";
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

