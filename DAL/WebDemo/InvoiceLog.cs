using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:InvoiceLog
	/// </summary>
	public partial class InvoiceLog
	{
		public InvoiceLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("InvoiceID", "InvoiceLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int InvoiceID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InvoiceLog");
			strSql.Append(" where InvoiceID=@InvoiceID");
			SqlParameter[] parameters = {
					new SqlParameter("@InvoiceID", SqlDbType.Int,4)
			};
			parameters[0].Value = InvoiceID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.InvoiceLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InvoiceLog(");
			strSql.Append("InvoiceCode)");
			strSql.Append(" values (");
			strSql.Append("@InvoiceCode)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@InvoiceCode", SqlDbType.Int,4)};
			parameters[0].Value = model.InvoiceCode;

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
		public bool Update(WebDemo.Model.WebDemo.InvoiceLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InvoiceLog set ");
			strSql.Append("InvoiceCode=@InvoiceCode");
			strSql.Append(" where InvoiceID=@InvoiceID");
			SqlParameter[] parameters = {
					new SqlParameter("@InvoiceCode", SqlDbType.Int,4),
					new SqlParameter("@InvoiceID", SqlDbType.Int,4)};
			parameters[0].Value = model.InvoiceCode;
			parameters[1].Value = model.InvoiceID;

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
		public bool Delete(int InvoiceID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InvoiceLog ");
			strSql.Append(" where InvoiceID=@InvoiceID");
			SqlParameter[] parameters = {
					new SqlParameter("@InvoiceID", SqlDbType.Int,4)
			};
			parameters[0].Value = InvoiceID;

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
		public bool DeleteList(string InvoiceIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InvoiceLog ");
			strSql.Append(" where InvoiceID in ("+InvoiceIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.InvoiceLog GetModel(int InvoiceID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 InvoiceID,InvoiceCode from InvoiceLog ");
			strSql.Append(" where InvoiceID=@InvoiceID");
			SqlParameter[] parameters = {
					new SqlParameter("@InvoiceID", SqlDbType.Int,4)
			};
			parameters[0].Value = InvoiceID;

			WebDemo.Model.WebDemo.InvoiceLog model=new WebDemo.Model.WebDemo.InvoiceLog();
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
		public WebDemo.Model.WebDemo.InvoiceLog DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.InvoiceLog model=new WebDemo.Model.WebDemo.InvoiceLog();
			if (row != null)
			{
				if(row["InvoiceID"]!=null && row["InvoiceID"].ToString()!="")
				{
					model.InvoiceID=int.Parse(row["InvoiceID"].ToString());
				}
				if(row["InvoiceCode"]!=null && row["InvoiceCode"].ToString()!="")
				{
					model.InvoiceCode=int.Parse(row["InvoiceCode"].ToString());
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
			strSql.Append("select InvoiceID,InvoiceCode ");
			strSql.Append(" FROM InvoiceLog ");
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
			strSql.Append(" InvoiceID,InvoiceCode ");
			strSql.Append(" FROM InvoiceLog ");
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
			strSql.Append("select count(1) FROM InvoiceLog ");
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
				strSql.Append("order by T.InvoiceID desc");
			}
			strSql.Append(")AS Row, T.*  from InvoiceLog T ");
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
			parameters[0].Value = "InvoiceLog";
			parameters[1].Value = "InvoiceID";
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

