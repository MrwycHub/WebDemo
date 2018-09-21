using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:PreOperationFare
	/// </summary>
	public partial class PreOperationFare
	{
		public PreOperationFare()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("OperID", "PreOperationFare"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OperID,string FareTypeName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PreOperationFare");
			strSql.Append(" where OperID=@OperID and FareTypeName=@FareTypeName ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,50)			};
			parameters[0].Value = OperID;
			parameters[1].Value = FareTypeName;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.PreOperationFare model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PreOperationFare(");
			strSql.Append("OperID,FareID,FareTypeName,FarePrice,FareMoney,FareMoney1,FarePrice2,FareMoney2,FarePrice3,FareMoney3,TaxRate)");
			strSql.Append(" values (");
			strSql.Append("@OperID,@FareID,@FareTypeName,@FarePrice,@FareMoney,@FareMoney1,@FarePrice2,@FareMoney2,@FarePrice3,@FareMoney3,@TaxRate)");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@FareID", SqlDbType.Int,4),
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@FarePrice", SqlDbType.Decimal,9),
					new SqlParameter("@FareMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FareMoney1", SqlDbType.Decimal,9),
					new SqlParameter("@FarePrice2", SqlDbType.Decimal,9),
					new SqlParameter("@FareMoney2", SqlDbType.Decimal,9),
					new SqlParameter("@FarePrice3", SqlDbType.Decimal,9),
					new SqlParameter("@FareMoney3", SqlDbType.Decimal,9),
					new SqlParameter("@TaxRate", SqlDbType.Decimal,9)};
			parameters[0].Value = model.OperID;
			parameters[1].Value = model.FareID;
			parameters[2].Value = model.FareTypeName;
			parameters[3].Value = model.FarePrice;
			parameters[4].Value = model.FareMoney;
			parameters[5].Value = model.FareMoney1;
			parameters[6].Value = model.FarePrice2;
			parameters[7].Value = model.FareMoney2;
			parameters[8].Value = model.FarePrice3;
			parameters[9].Value = model.FareMoney3;
			parameters[10].Value = model.TaxRate;

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
		public bool Update(WebDemo.Model.WebDemo.PreOperationFare model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PreOperationFare set ");
			strSql.Append("FareID=@FareID,");
			strSql.Append("FarePrice=@FarePrice,");
			strSql.Append("FareMoney=@FareMoney,");
			strSql.Append("FareMoney1=@FareMoney1,");
			strSql.Append("FarePrice2=@FarePrice2,");
			strSql.Append("FareMoney2=@FareMoney2,");
			strSql.Append("FarePrice3=@FarePrice3,");
			strSql.Append("FareMoney3=@FareMoney3,");
			strSql.Append("TaxRate=@TaxRate");
			strSql.Append(" where OperID=@OperID and FareTypeName=@FareTypeName ");
			SqlParameter[] parameters = {
					new SqlParameter("@FareID", SqlDbType.Int,4),
					new SqlParameter("@FarePrice", SqlDbType.Decimal,9),
					new SqlParameter("@FareMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FareMoney1", SqlDbType.Decimal,9),
					new SqlParameter("@FarePrice2", SqlDbType.Decimal,9),
					new SqlParameter("@FareMoney2", SqlDbType.Decimal,9),
					new SqlParameter("@FarePrice3", SqlDbType.Decimal,9),
					new SqlParameter("@FareMoney3", SqlDbType.Decimal,9),
					new SqlParameter("@TaxRate", SqlDbType.Decimal,9),
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.FareID;
			parameters[1].Value = model.FarePrice;
			parameters[2].Value = model.FareMoney;
			parameters[3].Value = model.FareMoney1;
			parameters[4].Value = model.FarePrice2;
			parameters[5].Value = model.FareMoney2;
			parameters[6].Value = model.FarePrice3;
			parameters[7].Value = model.FareMoney3;
			parameters[8].Value = model.TaxRate;
			parameters[9].Value = model.OperID;
			parameters[10].Value = model.FareTypeName;

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
		public bool Delete(int OperID,string FareTypeName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PreOperationFare ");
			strSql.Append(" where OperID=@OperID and FareTypeName=@FareTypeName ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,50)			};
			parameters[0].Value = OperID;
			parameters[1].Value = FareTypeName;

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
		public WebDemo.Model.WebDemo.PreOperationFare GetModel(int OperID,string FareTypeName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OperID,FareID,FareTypeName,FarePrice,FareMoney,FareMoney1,FarePrice2,FareMoney2,FarePrice3,FareMoney3,TaxRate from PreOperationFare ");
			strSql.Append(" where OperID=@OperID and FareTypeName=@FareTypeName ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,50)			};
			parameters[0].Value = OperID;
			parameters[1].Value = FareTypeName;

			WebDemo.Model.WebDemo.PreOperationFare model=new WebDemo.Model.WebDemo.PreOperationFare();
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
		public WebDemo.Model.WebDemo.PreOperationFare DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.PreOperationFare model=new WebDemo.Model.WebDemo.PreOperationFare();
			if (row != null)
			{
				if(row["OperID"]!=null && row["OperID"].ToString()!="")
				{
					model.OperID=int.Parse(row["OperID"].ToString());
				}
				if(row["FareID"]!=null && row["FareID"].ToString()!="")
				{
					model.FareID=int.Parse(row["FareID"].ToString());
				}
				if(row["FareTypeName"]!=null)
				{
					model.FareTypeName=row["FareTypeName"].ToString();
				}
				if(row["FarePrice"]!=null && row["FarePrice"].ToString()!="")
				{
					model.FarePrice=decimal.Parse(row["FarePrice"].ToString());
				}
				if(row["FareMoney"]!=null && row["FareMoney"].ToString()!="")
				{
					model.FareMoney=decimal.Parse(row["FareMoney"].ToString());
				}
				if(row["FareMoney1"]!=null && row["FareMoney1"].ToString()!="")
				{
					model.FareMoney1=decimal.Parse(row["FareMoney1"].ToString());
				}
				if(row["FarePrice2"]!=null && row["FarePrice2"].ToString()!="")
				{
					model.FarePrice2=decimal.Parse(row["FarePrice2"].ToString());
				}
				if(row["FareMoney2"]!=null && row["FareMoney2"].ToString()!="")
				{
					model.FareMoney2=decimal.Parse(row["FareMoney2"].ToString());
				}
				if(row["FarePrice3"]!=null && row["FarePrice3"].ToString()!="")
				{
					model.FarePrice3=decimal.Parse(row["FarePrice3"].ToString());
				}
				if(row["FareMoney3"]!=null && row["FareMoney3"].ToString()!="")
				{
					model.FareMoney3=decimal.Parse(row["FareMoney3"].ToString());
				}
				if(row["TaxRate"]!=null && row["TaxRate"].ToString()!="")
				{
					model.TaxRate=decimal.Parse(row["TaxRate"].ToString());
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
			strSql.Append("select OperID,FareID,FareTypeName,FarePrice,FareMoney,FareMoney1,FarePrice2,FareMoney2,FarePrice3,FareMoney3,TaxRate ");
			strSql.Append(" FROM PreOperationFare ");
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
			strSql.Append(" OperID,FareID,FareTypeName,FarePrice,FareMoney,FareMoney1,FarePrice2,FareMoney2,FarePrice3,FareMoney3,TaxRate ");
			strSql.Append(" FROM PreOperationFare ");
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
			strSql.Append("select count(1) FROM PreOperationFare ");
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
				strSql.Append("order by T.FareTypeName desc");
			}
			strSql.Append(")AS Row, T.*  from PreOperationFare T ");
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
			parameters[0].Value = "PreOperationFare";
			parameters[1].Value = "FareTypeName";
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

