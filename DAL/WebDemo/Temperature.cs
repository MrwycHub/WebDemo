using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Temperature
	/// </summary>
	public partial class Temperature
	{
		public Temperature()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal Centigrade)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Temperature");
			strSql.Append(" where Centigrade=@Centigrade ");
			SqlParameter[] parameters = {
					new SqlParameter("@Centigrade", SqlDbType.Decimal,9)			};
			parameters[0].Value = Centigrade;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.Temperature model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Temperature(");
			strSql.Append("Centigrade,Density,Enthalpy)");
			strSql.Append(" values (");
			strSql.Append("@Centigrade,@Density,@Enthalpy)");
			SqlParameter[] parameters = {
					new SqlParameter("@Centigrade", SqlDbType.Decimal,9),
					new SqlParameter("@Density", SqlDbType.Decimal,9),
					new SqlParameter("@Enthalpy", SqlDbType.Decimal,9)};
			parameters[0].Value = model.Centigrade;
			parameters[1].Value = model.Density;
			parameters[2].Value = model.Enthalpy;

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
		public bool Update(WebDemo.Model.WebDemo.Temperature model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Temperature set ");
			strSql.Append("Density=@Density,");
			strSql.Append("Enthalpy=@Enthalpy");
			strSql.Append(" where Centigrade=@Centigrade ");
			SqlParameter[] parameters = {
					new SqlParameter("@Density", SqlDbType.Decimal,9),
					new SqlParameter("@Enthalpy", SqlDbType.Decimal,9),
					new SqlParameter("@Centigrade", SqlDbType.Decimal,9)};
			parameters[0].Value = model.Density;
			parameters[1].Value = model.Enthalpy;
			parameters[2].Value = model.Centigrade;

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
		public bool Delete(decimal Centigrade)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Temperature ");
			strSql.Append(" where Centigrade=@Centigrade ");
			SqlParameter[] parameters = {
					new SqlParameter("@Centigrade", SqlDbType.Decimal,9)			};
			parameters[0].Value = Centigrade;

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
		public bool DeleteList(string Centigradelist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Temperature ");
			strSql.Append(" where Centigrade in ("+Centigradelist + ")  ");
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
		public WebDemo.Model.WebDemo.Temperature GetModel(decimal Centigrade)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Centigrade,Density,Enthalpy from Temperature ");
			strSql.Append(" where Centigrade=@Centigrade ");
			SqlParameter[] parameters = {
					new SqlParameter("@Centigrade", SqlDbType.Decimal,9)			};
			parameters[0].Value = Centigrade;

			WebDemo.Model.WebDemo.Temperature model=new WebDemo.Model.WebDemo.Temperature();
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
		public WebDemo.Model.WebDemo.Temperature DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Temperature model=new WebDemo.Model.WebDemo.Temperature();
			if (row != null)
			{
				if(row["Centigrade"]!=null && row["Centigrade"].ToString()!="")
				{
					model.Centigrade=decimal.Parse(row["Centigrade"].ToString());
				}
				if(row["Density"]!=null && row["Density"].ToString()!="")
				{
					model.Density=decimal.Parse(row["Density"].ToString());
				}
				if(row["Enthalpy"]!=null && row["Enthalpy"].ToString()!="")
				{
					model.Enthalpy=decimal.Parse(row["Enthalpy"].ToString());
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
			strSql.Append("select Centigrade,Density,Enthalpy ");
			strSql.Append(" FROM Temperature ");
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
			strSql.Append(" Centigrade,Density,Enthalpy ");
			strSql.Append(" FROM Temperature ");
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
			strSql.Append("select count(1) FROM Temperature ");
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
				strSql.Append("order by T.Centigrade desc");
			}
			strSql.Append(")AS Row, T.*  from Temperature T ");
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
			parameters[0].Value = "Temperature";
			parameters[1].Value = "Centigrade";
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

