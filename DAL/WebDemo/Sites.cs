using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Sites
	/// </summary>
	public partial class Sites
	{
		public Sites()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("SiteID", "Sites"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SiteID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sites");
			strSql.Append(" where SiteID=@SiteID");
			SqlParameter[] parameters = {
					new SqlParameter("@SiteID", SqlDbType.Int,4)
			};
			parameters[0].Value = SiteID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.Sites model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Sites(");
			strSql.Append("SiteName,SiteAddr,Remark)");
			strSql.Append(" values (");
			strSql.Append("@SiteName,@SiteAddr,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SiteName", SqlDbType.VarChar,100),
					new SqlParameter("@SiteAddr", SqlDbType.VarChar,200),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
			parameters[0].Value = model.SiteName;
			parameters[1].Value = model.SiteAddr;
			parameters[2].Value = model.Remark;

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
		public bool Update(WebDemo.Model.WebDemo.Sites model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Sites set ");
			strSql.Append("SiteName=@SiteName,");
			strSql.Append("SiteAddr=@SiteAddr,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where SiteID=@SiteID");
			SqlParameter[] parameters = {
					new SqlParameter("@SiteName", SqlDbType.VarChar,100),
					new SqlParameter("@SiteAddr", SqlDbType.VarChar,200),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@SiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.SiteName;
			parameters[1].Value = model.SiteAddr;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.SiteID;

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
		public bool Delete(int SiteID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sites ");
			strSql.Append(" where SiteID=@SiteID");
			SqlParameter[] parameters = {
					new SqlParameter("@SiteID", SqlDbType.Int,4)
			};
			parameters[0].Value = SiteID;

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
		public bool DeleteList(string SiteIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Sites ");
			strSql.Append(" where SiteID in ("+SiteIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.Sites GetModel(int SiteID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SiteID,SiteName,SiteAddr,Remark from Sites ");
			strSql.Append(" where SiteID=@SiteID");
			SqlParameter[] parameters = {
					new SqlParameter("@SiteID", SqlDbType.Int,4)
			};
			parameters[0].Value = SiteID;

			WebDemo.Model.WebDemo.Sites model=new WebDemo.Model.WebDemo.Sites();
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
		public WebDemo.Model.WebDemo.Sites DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Sites model=new WebDemo.Model.WebDemo.Sites();
			if (row != null)
			{
				if(row["SiteID"]!=null && row["SiteID"].ToString()!="")
				{
					model.SiteID=int.Parse(row["SiteID"].ToString());
				}
				if(row["SiteName"]!=null)
				{
					model.SiteName=row["SiteName"].ToString();
				}
				if(row["SiteAddr"]!=null)
				{
					model.SiteAddr=row["SiteAddr"].ToString();
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
			strSql.Append("select SiteID,SiteName,SiteAddr,Remark ");
			strSql.Append(" FROM Sites ");
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
			strSql.Append(" SiteID,SiteName,SiteAddr,Remark ");
			strSql.Append(" FROM Sites ");
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
			strSql.Append("select count(1) FROM Sites ");
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
				strSql.Append("order by T.SiteID desc");
			}
			strSql.Append(")AS Row, T.*  from Sites T ");
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
			parameters[0].Value = "Sites";
			parameters[1].Value = "SiteID";
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

