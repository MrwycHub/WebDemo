using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:RatePrice
	/// </summary>
	public partial class RatePrice
	{
		public RatePrice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("GroupPriceNo", "RatePrice"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int GroupPriceNo,int FareRateNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from RatePrice");
			strSql.Append(" where GroupPriceNo=@GroupPriceNo and FareRateNo=@FareRateNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupPriceNo", SqlDbType.Int,4),
					new SqlParameter("@FareRateNo", SqlDbType.Int,4)			};
			parameters[0].Value = GroupPriceNo;
			parameters[1].Value = FareRateNo;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.RatePrice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into RatePrice(");
			strSql.Append("GroupPriceNo,FareRateNo,FareName,Price)");
			strSql.Append(" values (");
			strSql.Append("@GroupPriceNo,@FareRateNo,@FareName,@Price)");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupPriceNo", SqlDbType.Int,4),
					new SqlParameter("@FareRateNo", SqlDbType.Int,4),
					new SqlParameter("@FareName", SqlDbType.NVarChar,10),
					new SqlParameter("@Price", SqlDbType.Decimal,9)};
			parameters[0].Value = model.GroupPriceNo;
			parameters[1].Value = model.FareRateNo;
			parameters[2].Value = model.FareName;
			parameters[3].Value = model.Price;

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
		public bool Update(WebDemo.Model.WebDemo.RatePrice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update RatePrice set ");
			strSql.Append("FareName=@FareName,");
			strSql.Append("Price=@Price");
			strSql.Append(" where GroupPriceNo=@GroupPriceNo and FareRateNo=@FareRateNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@FareName", SqlDbType.NVarChar,10),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@GroupPriceNo", SqlDbType.Int,4),
					new SqlParameter("@FareRateNo", SqlDbType.Int,4)};
			parameters[0].Value = model.FareName;
			parameters[1].Value = model.Price;
			parameters[2].Value = model.GroupPriceNo;
			parameters[3].Value = model.FareRateNo;

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
		public bool Delete(int GroupPriceNo,int FareRateNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RatePrice ");
			strSql.Append(" where GroupPriceNo=@GroupPriceNo and FareRateNo=@FareRateNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupPriceNo", SqlDbType.Int,4),
					new SqlParameter("@FareRateNo", SqlDbType.Int,4)			};
			parameters[0].Value = GroupPriceNo;
			parameters[1].Value = FareRateNo;

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
		public WebDemo.Model.WebDemo.RatePrice GetModel(int GroupPriceNo,int FareRateNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 GroupPriceNo,FareRateNo,FareName,Price from RatePrice ");
			strSql.Append(" where GroupPriceNo=@GroupPriceNo and FareRateNo=@FareRateNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@GroupPriceNo", SqlDbType.Int,4),
					new SqlParameter("@FareRateNo", SqlDbType.Int,4)			};
			parameters[0].Value = GroupPriceNo;
			parameters[1].Value = FareRateNo;

			WebDemo.Model.WebDemo.RatePrice model=new WebDemo.Model.WebDemo.RatePrice();
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
		public WebDemo.Model.WebDemo.RatePrice DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.RatePrice model=new WebDemo.Model.WebDemo.RatePrice();
			if (row != null)
			{
				if(row["GroupPriceNo"]!=null && row["GroupPriceNo"].ToString()!="")
				{
					model.GroupPriceNo=int.Parse(row["GroupPriceNo"].ToString());
				}
				if(row["FareRateNo"]!=null && row["FareRateNo"].ToString()!="")
				{
					model.FareRateNo=int.Parse(row["FareRateNo"].ToString());
				}
				if(row["FareName"]!=null)
				{
					model.FareName=row["FareName"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
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
			strSql.Append("select GroupPriceNo,FareRateNo,FareName,Price ");
			strSql.Append(" FROM RatePrice ");
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
			strSql.Append(" GroupPriceNo,FareRateNo,FareName,Price ");
			strSql.Append(" FROM RatePrice ");
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
			strSql.Append("select count(1) FROM RatePrice ");
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
				strSql.Append("order by T.FareRateNo desc");
			}
			strSql.Append(")AS Row, T.*  from RatePrice T ");
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
			parameters[0].Value = "RatePrice";
			parameters[1].Value = "FareRateNo";
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

