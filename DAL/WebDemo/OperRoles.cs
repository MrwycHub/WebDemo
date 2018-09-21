using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:OperRoles
	/// </summary>
	public partial class OperRoles
	{
		public OperRoles()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MenuID", "OperRoles"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MenuID,int RoleID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OperRoles");
			strSql.Append(" where MenuID=@MenuID and RoleID=@RoleID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.Int,4),
					new SqlParameter("@RoleID", SqlDbType.Int,4)			};
			parameters[0].Value = MenuID;
			parameters[1].Value = RoleID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.OperRoles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OperRoles(");
			strSql.Append("MenuID,RoleID)");
			strSql.Append(" values (");
			strSql.Append("@MenuID,@RoleID)");
			SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.Int,4),
					new SqlParameter("@RoleID", SqlDbType.Int,4)};
			parameters[0].Value = model.MenuID;
			parameters[1].Value = model.RoleID;

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
		public bool Update(WebDemo.Model.WebDemo.OperRoles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OperRoles set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！ 
			strSql.Append("MenuID=@MenuID,");
			strSql.Append("RoleID=@RoleID");
			strSql.Append(" where MenuID=@MenuID and RoleID=@RoleID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.Int,4),
					new SqlParameter("@RoleID", SqlDbType.Int,4)};
			parameters[0].Value = model.MenuID;
			parameters[1].Value = model.RoleID;

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
		public bool Delete(int MenuID,int RoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OperRoles ");
			strSql.Append(" where MenuID=@MenuID and RoleID=@RoleID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.Int,4),
					new SqlParameter("@RoleID", SqlDbType.Int,4)			};
			parameters[0].Value = MenuID;
			parameters[1].Value = RoleID;

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
		public WebDemo.Model.WebDemo.OperRoles GetModel(int MenuID,int RoleID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MenuID,RoleID from OperRoles ");
			strSql.Append(" where MenuID=@MenuID and RoleID=@RoleID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.Int,4),
					new SqlParameter("@RoleID", SqlDbType.Int,4)			};
			parameters[0].Value = MenuID;
			parameters[1].Value = RoleID;

			WebDemo.Model.WebDemo.OperRoles model=new WebDemo.Model.WebDemo.OperRoles();
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
		public WebDemo.Model.WebDemo.OperRoles DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.OperRoles model=new WebDemo.Model.WebDemo.OperRoles();
			if (row != null)
			{
				if(row["MenuID"]!=null && row["MenuID"].ToString()!="")
				{
					model.MenuID=int.Parse(row["MenuID"].ToString());
				}
				if(row["RoleID"]!=null && row["RoleID"].ToString()!="")
				{
					model.RoleID=int.Parse(row["RoleID"].ToString());
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
			strSql.Append("select MenuID,RoleID ");
			strSql.Append(" FROM OperRoles ");
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
			strSql.Append(" MenuID,RoleID ");
			strSql.Append(" FROM OperRoles ");
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
			strSql.Append("select count(1) FROM OperRoles ");
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
				strSql.Append("order by T.RoleID desc");
			}
			strSql.Append(")AS Row, T.*  from OperRoles T ");
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
			parameters[0].Value = "OperRoles";
			parameters[1].Value = "RoleID";
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

