using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:DeptUser
	/// </summary>
	public partial class DeptUser
	{
		public DeptUser()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string OperatorCode,string DeptID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DeptUser");
			strSql.Append(" where OperatorCode=@OperatorCode and DeptID=@DeptID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorCode", SqlDbType.VarChar,50),
					new SqlParameter("@DeptID", SqlDbType.VarChar,60)			};
			parameters[0].Value = OperatorCode;
			parameters[1].Value = DeptID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.DeptUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DeptUser(");
			strSql.Append("OperatorCode,DeptID)");
			strSql.Append(" values (");
			strSql.Append("@OperatorCode,@DeptID)");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorCode", SqlDbType.VarChar,50),
					new SqlParameter("@DeptID", SqlDbType.VarChar,60)};
			parameters[0].Value = model.OperatorCode;
			parameters[1].Value = model.DeptID;

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
		public bool Update(WebDemo.Model.WebDemo.DeptUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DeptUser set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！ 
			strSql.Append("OperatorCode=@OperatorCode,");
			strSql.Append("DeptID=@DeptID");
			strSql.Append(" where OperatorCode=@OperatorCode and DeptID=@DeptID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorCode", SqlDbType.VarChar,50),
					new SqlParameter("@DeptID", SqlDbType.VarChar,60)};
			parameters[0].Value = model.OperatorCode;
			parameters[1].Value = model.DeptID;

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
		public bool Delete(string OperatorCode,string DeptID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DeptUser ");
			strSql.Append(" where OperatorCode=@OperatorCode and DeptID=@DeptID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorCode", SqlDbType.VarChar,50),
					new SqlParameter("@DeptID", SqlDbType.VarChar,60)			};
			parameters[0].Value = OperatorCode;
			parameters[1].Value = DeptID;

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
		public WebDemo.Model.WebDemo.DeptUser GetModel(string OperatorCode,string DeptID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OperatorCode,DeptID from DeptUser ");
			strSql.Append(" where OperatorCode=@OperatorCode and DeptID=@DeptID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorCode", SqlDbType.VarChar,50),
					new SqlParameter("@DeptID", SqlDbType.VarChar,60)			};
			parameters[0].Value = OperatorCode;
			parameters[1].Value = DeptID;

			WebDemo.Model.WebDemo.DeptUser model=new WebDemo.Model.WebDemo.DeptUser();
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
		public WebDemo.Model.WebDemo.DeptUser DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.DeptUser model=new WebDemo.Model.WebDemo.DeptUser();
			if (row != null)
			{
				if(row["OperatorCode"]!=null)
				{
					model.OperatorCode=row["OperatorCode"].ToString();
				}
				if(row["DeptID"]!=null)
				{
					model.DeptID=row["DeptID"].ToString();
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
			strSql.Append("select OperatorCode,DeptID ");
			strSql.Append(" FROM DeptUser ");
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
			strSql.Append(" OperatorCode,DeptID ");
			strSql.Append(" FROM DeptUser ");
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
			strSql.Append("select count(1) FROM DeptUser ");
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
				strSql.Append("order by T.DeptID desc");
			}
			strSql.Append(")AS Row, T.*  from DeptUser T ");
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
			parameters[0].Value = "DeptUser";
			parameters[1].Value = "DeptID";
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

