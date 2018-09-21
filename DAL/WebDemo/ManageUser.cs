using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:ManageUser
	/// </summary>
	public partial class ManageUser
	{
		public ManageUser()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UsersID", "ManageUser"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UsersID,string ManageFareID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ManageUser");
			strSql.Append(" where UsersID=@UsersID and ManageFareID=@ManageFareID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@ManageFareID", SqlDbType.VarChar,200)			};
			parameters[0].Value = UsersID;
			parameters[1].Value = ManageFareID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.ManageUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ManageUser(");
			strSql.Append("UsersID,ManageFareID,ChargeDate,LastDate,ReMark,Status)");
			strSql.Append(" values (");
			strSql.Append("@UsersID,@ManageFareID,@ChargeDate,@LastDate,@ReMark,@Status)");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@ManageFareID", SqlDbType.VarChar,200),
					new SqlParameter("@ChargeDate", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@ReMark", SqlDbType.VarChar,200),
					new SqlParameter("@Status", SqlDbType.Int,4)};
			parameters[0].Value = model.UsersID;
			parameters[1].Value = model.ManageFareID;
			parameters[2].Value = model.ChargeDate;
			parameters[3].Value = model.LastDate;
			parameters[4].Value = model.ReMark;
			parameters[5].Value = model.Status;

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
		public bool Update(WebDemo.Model.WebDemo.ManageUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ManageUser set ");
			strSql.Append("ChargeDate=@ChargeDate,");
			strSql.Append("LastDate=@LastDate,");
			strSql.Append("ReMark=@ReMark,");
			strSql.Append("Status=@Status");
			strSql.Append(" where UsersID=@UsersID and ManageFareID=@ManageFareID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ChargeDate", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@ReMark", SqlDbType.VarChar,200),
					new SqlParameter("@Status", SqlDbType.Int,4),
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@ManageFareID", SqlDbType.VarChar,200)};
			parameters[0].Value = model.ChargeDate;
			parameters[1].Value = model.LastDate;
			parameters[2].Value = model.ReMark;
			parameters[3].Value = model.Status;
			parameters[4].Value = model.UsersID;
			parameters[5].Value = model.ManageFareID;

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
		public bool Delete(int UsersID,string ManageFareID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ManageUser ");
			strSql.Append(" where UsersID=@UsersID and ManageFareID=@ManageFareID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@ManageFareID", SqlDbType.VarChar,200)			};
			parameters[0].Value = UsersID;
			parameters[1].Value = ManageFareID;

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
		public WebDemo.Model.WebDemo.ManageUser GetModel(int UsersID,string ManageFareID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UsersID,ManageFareID,ChargeDate,LastDate,ReMark,Status from ManageUser ");
			strSql.Append(" where UsersID=@UsersID and ManageFareID=@ManageFareID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@ManageFareID", SqlDbType.VarChar,200)			};
			parameters[0].Value = UsersID;
			parameters[1].Value = ManageFareID;

			WebDemo.Model.WebDemo.ManageUser model=new WebDemo.Model.WebDemo.ManageUser();
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
		public WebDemo.Model.WebDemo.ManageUser DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.ManageUser model=new WebDemo.Model.WebDemo.ManageUser();
			if (row != null)
			{
				if(row["UsersID"]!=null && row["UsersID"].ToString()!="")
				{
					model.UsersID=int.Parse(row["UsersID"].ToString());
				}
				if(row["ManageFareID"]!=null)
				{
					model.ManageFareID=row["ManageFareID"].ToString();
				}
				if(row["ChargeDate"]!=null && row["ChargeDate"].ToString()!="")
				{
					model.ChargeDate=DateTime.Parse(row["ChargeDate"].ToString());
				}
				if(row["LastDate"]!=null && row["LastDate"].ToString()!="")
				{
					model.LastDate=DateTime.Parse(row["LastDate"].ToString());
				}
				if(row["ReMark"]!=null)
				{
					model.ReMark=row["ReMark"].ToString();
				}
				if(row["Status"]!=null && row["Status"].ToString()!="")
				{
					model.Status=int.Parse(row["Status"].ToString());
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
			strSql.Append("select UsersID,ManageFareID,ChargeDate,LastDate,ReMark,Status ");
			strSql.Append(" FROM ManageUser ");
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
			strSql.Append(" UsersID,ManageFareID,ChargeDate,LastDate,ReMark,Status ");
			strSql.Append(" FROM ManageUser ");
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
			strSql.Append("select count(1) FROM ManageUser ");
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
				strSql.Append("order by T.ManageFareID desc");
			}
			strSql.Append(")AS Row, T.*  from ManageUser T ");
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
			parameters[0].Value = "ManageUser";
			parameters[1].Value = "ManageFareID";
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

