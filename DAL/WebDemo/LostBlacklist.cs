using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:LostBlacklist
	/// </summary>
	public partial class LostBlacklist
	{
		public LostBlacklist()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("SaveNo", "LostBlacklist"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SaveNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LostBlacklist");
			strSql.Append(" where SaveNo=@SaveNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@SaveNo", SqlDbType.Int,4)			};
			parameters[0].Value = SaveNo;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.LostBlacklist model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LostBlacklist(");
			strSql.Append("SaveNo,CardID,LostDate)");
			strSql.Append(" values (");
			strSql.Append("@SaveNo,@CardID,@LostDate)");
			SqlParameter[] parameters = {
					new SqlParameter("@SaveNo", SqlDbType.Int,4),
					new SqlParameter("@CardID", SqlDbType.Int,4),
					new SqlParameter("@LostDate", SqlDbType.DateTime)};
			parameters[0].Value = model.SaveNo;
			parameters[1].Value = model.CardID;
			parameters[2].Value = model.LostDate;

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
		public bool Update(WebDemo.Model.WebDemo.LostBlacklist model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LostBlacklist set ");
			strSql.Append("CardID=@CardID,");
			strSql.Append("LostDate=@LostDate");
			strSql.Append(" where SaveNo=@SaveNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.Int,4),
					new SqlParameter("@LostDate", SqlDbType.DateTime),
					new SqlParameter("@SaveNo", SqlDbType.Int,4)};
			parameters[0].Value = model.CardID;
			parameters[1].Value = model.LostDate;
			parameters[2].Value = model.SaveNo;

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
		public bool Delete(int SaveNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LostBlacklist ");
			strSql.Append(" where SaveNo=@SaveNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@SaveNo", SqlDbType.Int,4)			};
			parameters[0].Value = SaveNo;

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
		public bool DeleteList(string SaveNolist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LostBlacklist ");
			strSql.Append(" where SaveNo in ("+SaveNolist + ")  ");
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
		public WebDemo.Model.WebDemo.LostBlacklist GetModel(int SaveNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SaveNo,CardID,LostDate from LostBlacklist ");
			strSql.Append(" where SaveNo=@SaveNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@SaveNo", SqlDbType.Int,4)			};
			parameters[0].Value = SaveNo;

			WebDemo.Model.WebDemo.LostBlacklist model=new WebDemo.Model.WebDemo.LostBlacklist();
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
		public WebDemo.Model.WebDemo.LostBlacklist DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.LostBlacklist model=new WebDemo.Model.WebDemo.LostBlacklist();
			if (row != null)
			{
				if(row["SaveNo"]!=null && row["SaveNo"].ToString()!="")
				{
					model.SaveNo=int.Parse(row["SaveNo"].ToString());
				}
				if(row["CardID"]!=null && row["CardID"].ToString()!="")
				{
					model.CardID=int.Parse(row["CardID"].ToString());
				}
				if(row["LostDate"]!=null && row["LostDate"].ToString()!="")
				{
					model.LostDate=DateTime.Parse(row["LostDate"].ToString());
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
			strSql.Append("select SaveNo,CardID,LostDate ");
			strSql.Append(" FROM LostBlacklist ");
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
			strSql.Append(" SaveNo,CardID,LostDate ");
			strSql.Append(" FROM LostBlacklist ");
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
			strSql.Append("select count(1) FROM LostBlacklist ");
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
				strSql.Append("order by T.SaveNo desc");
			}
			strSql.Append(")AS Row, T.*  from LostBlacklist T ");
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
			parameters[0].Value = "LostBlacklist";
			parameters[1].Value = "SaveNo";
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

