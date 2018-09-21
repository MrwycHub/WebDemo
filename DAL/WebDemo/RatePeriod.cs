using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:RatePeriod
	/// </summary>
	public partial class RatePeriod
	{
		public RatePeriod()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("SuiteNo", "RatePeriod"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SuiteNo,int GroupPeriodNo,int PeriodNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from RatePeriod");
			strSql.Append(" where SuiteNo=@SuiteNo and GroupPeriodNo=@GroupPeriodNo and PeriodNo=@PeriodNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@SuiteNo", SqlDbType.Int,4),
					new SqlParameter("@GroupPeriodNo", SqlDbType.Int,4),
					new SqlParameter("@PeriodNo", SqlDbType.Int,4)			};
			parameters[0].Value = SuiteNo;
			parameters[1].Value = GroupPeriodNo;
			parameters[2].Value = PeriodNo;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.RatePeriod model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into RatePeriod(");
			strSql.Append("SuiteNo,GroupPeriodNo,PeriodNo,BeginTime,FareRateNo)");
			strSql.Append(" values (");
			strSql.Append("@SuiteNo,@GroupPeriodNo,@PeriodNo,@BeginTime,@FareRateNo)");
			SqlParameter[] parameters = {
					new SqlParameter("@SuiteNo", SqlDbType.Int,4),
					new SqlParameter("@GroupPeriodNo", SqlDbType.Int,4),
					new SqlParameter("@PeriodNo", SqlDbType.Int,4),
					new SqlParameter("@BeginTime", SqlDbType.DateTime),
					new SqlParameter("@FareRateNo", SqlDbType.Int,4)};
			parameters[0].Value = model.SuiteNo;
			parameters[1].Value = model.GroupPeriodNo;
			parameters[2].Value = model.PeriodNo;
			parameters[3].Value = model.BeginTime;
			parameters[4].Value = model.FareRateNo;

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
		public bool Update(WebDemo.Model.WebDemo.RatePeriod model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update RatePeriod set ");
			strSql.Append("BeginTime=@BeginTime,");
			strSql.Append("FareRateNo=@FareRateNo");
			strSql.Append(" where SuiteNo=@SuiteNo and GroupPeriodNo=@GroupPeriodNo and PeriodNo=@PeriodNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@BeginTime", SqlDbType.DateTime),
					new SqlParameter("@FareRateNo", SqlDbType.Int,4),
					new SqlParameter("@SuiteNo", SqlDbType.Int,4),
					new SqlParameter("@GroupPeriodNo", SqlDbType.Int,4),
					new SqlParameter("@PeriodNo", SqlDbType.Int,4)};
			parameters[0].Value = model.BeginTime;
			parameters[1].Value = model.FareRateNo;
			parameters[2].Value = model.SuiteNo;
			parameters[3].Value = model.GroupPeriodNo;
			parameters[4].Value = model.PeriodNo;

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
		public bool Delete(int SuiteNo,int GroupPeriodNo,int PeriodNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RatePeriod ");
			strSql.Append(" where SuiteNo=@SuiteNo and GroupPeriodNo=@GroupPeriodNo and PeriodNo=@PeriodNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@SuiteNo", SqlDbType.Int,4),
					new SqlParameter("@GroupPeriodNo", SqlDbType.Int,4),
					new SqlParameter("@PeriodNo", SqlDbType.Int,4)			};
			parameters[0].Value = SuiteNo;
			parameters[1].Value = GroupPeriodNo;
			parameters[2].Value = PeriodNo;

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
		public WebDemo.Model.WebDemo.RatePeriod GetModel(int SuiteNo,int GroupPeriodNo,int PeriodNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SuiteNo,GroupPeriodNo,PeriodNo,BeginTime,FareRateNo from RatePeriod ");
			strSql.Append(" where SuiteNo=@SuiteNo and GroupPeriodNo=@GroupPeriodNo and PeriodNo=@PeriodNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@SuiteNo", SqlDbType.Int,4),
					new SqlParameter("@GroupPeriodNo", SqlDbType.Int,4),
					new SqlParameter("@PeriodNo", SqlDbType.Int,4)			};
			parameters[0].Value = SuiteNo;
			parameters[1].Value = GroupPeriodNo;
			parameters[2].Value = PeriodNo;

			WebDemo.Model.WebDemo.RatePeriod model=new WebDemo.Model.WebDemo.RatePeriod();
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
		public WebDemo.Model.WebDemo.RatePeriod DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.RatePeriod model=new WebDemo.Model.WebDemo.RatePeriod();
			if (row != null)
			{
				if(row["SuiteNo"]!=null && row["SuiteNo"].ToString()!="")
				{
					model.SuiteNo=int.Parse(row["SuiteNo"].ToString());
				}
				if(row["GroupPeriodNo"]!=null && row["GroupPeriodNo"].ToString()!="")
				{
					model.GroupPeriodNo=int.Parse(row["GroupPeriodNo"].ToString());
				}
				if(row["PeriodNo"]!=null && row["PeriodNo"].ToString()!="")
				{
					model.PeriodNo=int.Parse(row["PeriodNo"].ToString());
				}
				if(row["BeginTime"]!=null && row["BeginTime"].ToString()!="")
				{
					model.BeginTime=DateTime.Parse(row["BeginTime"].ToString());
				}
				if(row["FareRateNo"]!=null && row["FareRateNo"].ToString()!="")
				{
					model.FareRateNo=int.Parse(row["FareRateNo"].ToString());
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
			strSql.Append("select SuiteNo,GroupPeriodNo,PeriodNo,BeginTime,FareRateNo ");
			strSql.Append(" FROM RatePeriod ");
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
			strSql.Append(" SuiteNo,GroupPeriodNo,PeriodNo,BeginTime,FareRateNo ");
			strSql.Append(" FROM RatePeriod ");
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
			strSql.Append("select count(1) FROM RatePeriod ");
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
				strSql.Append("order by T.PeriodNo desc");
			}
			strSql.Append(")AS Row, T.*  from RatePeriod T ");
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
			parameters[0].Value = "RatePeriod";
			parameters[1].Value = "PeriodNo";
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

