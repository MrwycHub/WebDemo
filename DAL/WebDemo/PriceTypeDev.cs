using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:PriceTypeDev
	/// </summary>
	public partial class PriceTypeDev
	{
		public PriceTypeDev()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("PriceTypeID", "PriceTypeDev"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PriceTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PriceTypeDev");
			strSql.Append(" where PriceTypeID=@PriceTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = PriceTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.PriceTypeDev model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PriceTypeDev(");
			strSql.Append("PriceTypeID,LateFeeRate,LateFeeDate,LateFeeBase,ICMonth,ICMaxBuy,ICAmount,ICMonthBuy,ICDayAvg)");
			strSql.Append(" values (");
			strSql.Append("@PriceTypeID,@LateFeeRate,@LateFeeDate,@LateFeeBase,@ICMonth,@ICMaxBuy,@ICAmount,@ICMonthBuy,@ICDayAvg)");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4),
					new SqlParameter("@LateFeeRate", SqlDbType.Decimal,9),
					new SqlParameter("@LateFeeDate", SqlDbType.Int,4),
					new SqlParameter("@LateFeeBase", SqlDbType.Decimal,9),
					new SqlParameter("@ICMonth", SqlDbType.Int,4),
					new SqlParameter("@ICMaxBuy", SqlDbType.Int,4),
					new SqlParameter("@ICAmount", SqlDbType.Int,4),
					new SqlParameter("@ICMonthBuy", SqlDbType.Int,4),
					new SqlParameter("@ICDayAvg", SqlDbType.Int,4)};
			parameters[0].Value = model.PriceTypeID;
			parameters[1].Value = model.LateFeeRate;
			parameters[2].Value = model.LateFeeDate;
			parameters[3].Value = model.LateFeeBase;
			parameters[4].Value = model.ICMonth;
			parameters[5].Value = model.ICMaxBuy;
			parameters[6].Value = model.ICAmount;
			parameters[7].Value = model.ICMonthBuy;
			parameters[8].Value = model.ICDayAvg;

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
		public bool Update(WebDemo.Model.WebDemo.PriceTypeDev model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PriceTypeDev set ");
			strSql.Append("LateFeeRate=@LateFeeRate,");
			strSql.Append("LateFeeDate=@LateFeeDate,");
			strSql.Append("LateFeeBase=@LateFeeBase,");
			strSql.Append("ICMonth=@ICMonth,");
			strSql.Append("ICMaxBuy=@ICMaxBuy,");
			strSql.Append("ICAmount=@ICAmount,");
			strSql.Append("ICMonthBuy=@ICMonthBuy,");
			strSql.Append("ICDayAvg=@ICDayAvg");
			strSql.Append(" where PriceTypeID=@PriceTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@LateFeeRate", SqlDbType.Decimal,9),
					new SqlParameter("@LateFeeDate", SqlDbType.Int,4),
					new SqlParameter("@LateFeeBase", SqlDbType.Decimal,9),
					new SqlParameter("@ICMonth", SqlDbType.Int,4),
					new SqlParameter("@ICMaxBuy", SqlDbType.Int,4),
					new SqlParameter("@ICAmount", SqlDbType.Int,4),
					new SqlParameter("@ICMonthBuy", SqlDbType.Int,4),
					new SqlParameter("@ICDayAvg", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4)};
			parameters[0].Value = model.LateFeeRate;
			parameters[1].Value = model.LateFeeDate;
			parameters[2].Value = model.LateFeeBase;
			parameters[3].Value = model.ICMonth;
			parameters[4].Value = model.ICMaxBuy;
			parameters[5].Value = model.ICAmount;
			parameters[6].Value = model.ICMonthBuy;
			parameters[7].Value = model.ICDayAvg;
			parameters[8].Value = model.PriceTypeID;

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
		public bool Delete(int PriceTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PriceTypeDev ");
			strSql.Append(" where PriceTypeID=@PriceTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = PriceTypeID;

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
		public bool DeleteList(string PriceTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PriceTypeDev ");
			strSql.Append(" where PriceTypeID in ("+PriceTypeIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.PriceTypeDev GetModel(int PriceTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PriceTypeID,LateFeeRate,LateFeeDate,LateFeeBase,ICMonth,ICMaxBuy,ICAmount,ICMonthBuy,ICDayAvg from PriceTypeDev ");
			strSql.Append(" where PriceTypeID=@PriceTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = PriceTypeID;

			WebDemo.Model.WebDemo.PriceTypeDev model=new WebDemo.Model.WebDemo.PriceTypeDev();
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
		public WebDemo.Model.WebDemo.PriceTypeDev DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.PriceTypeDev model=new WebDemo.Model.WebDemo.PriceTypeDev();
			if (row != null)
			{
				if(row["PriceTypeID"]!=null && row["PriceTypeID"].ToString()!="")
				{
					model.PriceTypeID=int.Parse(row["PriceTypeID"].ToString());
				}
				if(row["LateFeeRate"]!=null && row["LateFeeRate"].ToString()!="")
				{
					model.LateFeeRate=decimal.Parse(row["LateFeeRate"].ToString());
				}
				if(row["LateFeeDate"]!=null && row["LateFeeDate"].ToString()!="")
				{
					model.LateFeeDate=int.Parse(row["LateFeeDate"].ToString());
				}
				if(row["LateFeeBase"]!=null && row["LateFeeBase"].ToString()!="")
				{
					model.LateFeeBase=decimal.Parse(row["LateFeeBase"].ToString());
				}
				if(row["ICMonth"]!=null && row["ICMonth"].ToString()!="")
				{
					model.ICMonth=int.Parse(row["ICMonth"].ToString());
				}
				if(row["ICMaxBuy"]!=null && row["ICMaxBuy"].ToString()!="")
				{
					model.ICMaxBuy=int.Parse(row["ICMaxBuy"].ToString());
				}
				if(row["ICAmount"]!=null && row["ICAmount"].ToString()!="")
				{
					model.ICAmount=int.Parse(row["ICAmount"].ToString());
				}
				if(row["ICMonthBuy"]!=null && row["ICMonthBuy"].ToString()!="")
				{
					model.ICMonthBuy=int.Parse(row["ICMonthBuy"].ToString());
				}
				if(row["ICDayAvg"]!=null && row["ICDayAvg"].ToString()!="")
				{
					model.ICDayAvg=int.Parse(row["ICDayAvg"].ToString());
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
			strSql.Append("select PriceTypeID,LateFeeRate,LateFeeDate,LateFeeBase,ICMonth,ICMaxBuy,ICAmount,ICMonthBuy,ICDayAvg ");
			strSql.Append(" FROM PriceTypeDev ");
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
			strSql.Append(" PriceTypeID,LateFeeRate,LateFeeDate,LateFeeBase,ICMonth,ICMaxBuy,ICAmount,ICMonthBuy,ICDayAvg ");
			strSql.Append(" FROM PriceTypeDev ");
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
			strSql.Append("select count(1) FROM PriceTypeDev ");
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
				strSql.Append("order by T.PriceTypeID desc");
			}
			strSql.Append(")AS Row, T.*  from PriceTypeDev T ");
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
			parameters[0].Value = "PriceTypeDev";
			parameters[1].Value = "PriceTypeID";
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

