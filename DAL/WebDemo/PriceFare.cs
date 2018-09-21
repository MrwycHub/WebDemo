using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:PriceFare
	/// </summary>
	public partial class PriceFare
	{
		public PriceFare()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.PriceFare model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PriceFare(");
			strSql.Append("PriceTypeID,FareTypeName,Price,Price2,Price3,FareNo,ReMark,Price4,Price5,Price6,TaxRate,ProjectName)");
			strSql.Append(" values (");
			strSql.Append("@PriceTypeID,@FareTypeName,@Price,@Price2,@Price3,@FareNo,@ReMark,@Price4,@Price5,@Price6,@TaxRate,@ProjectName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4),
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@FareNo", SqlDbType.Int,4),
					new SqlParameter("@ReMark", SqlDbType.VarChar,200),
					new SqlParameter("@Price4", SqlDbType.Decimal,9),
					new SqlParameter("@Price5", SqlDbType.Decimal,9),
					new SqlParameter("@Price6", SqlDbType.Decimal,9),
					new SqlParameter("@TaxRate", SqlDbType.Decimal,9),
					new SqlParameter("@ProjectName", SqlDbType.NVarChar,90)};
			parameters[0].Value = model.PriceTypeID;
			parameters[1].Value = model.FareTypeName;
			parameters[2].Value = model.Price;
			parameters[3].Value = model.Price2;
			parameters[4].Value = model.Price3;
			parameters[5].Value = model.FareNo;
			parameters[6].Value = model.ReMark;
			parameters[7].Value = model.Price4;
			parameters[8].Value = model.Price5;
			parameters[9].Value = model.Price6;
			parameters[10].Value = model.TaxRate;
			parameters[11].Value = model.ProjectName;

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
		public bool Update(WebDemo.Model.WebDemo.PriceFare model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PriceFare set ");
			strSql.Append("PriceTypeID=@PriceTypeID,");
			strSql.Append("FareTypeName=@FareTypeName,");
			strSql.Append("Price=@Price,");
			strSql.Append("Price2=@Price2,");
			strSql.Append("Price3=@Price3,");
			strSql.Append("FareNo=@FareNo,");
			strSql.Append("ReMark=@ReMark,");
			strSql.Append("Price4=@Price4,");
			strSql.Append("Price5=@Price5,");
			strSql.Append("Price6=@Price6,");
			strSql.Append("TaxRate=@TaxRate,");
			strSql.Append("ProjectName=@ProjectName");
			strSql.Append(" where FareID=@FareID");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4),
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@FareNo", SqlDbType.Int,4),
					new SqlParameter("@ReMark", SqlDbType.VarChar,200),
					new SqlParameter("@Price4", SqlDbType.Decimal,9),
					new SqlParameter("@Price5", SqlDbType.Decimal,9),
					new SqlParameter("@Price6", SqlDbType.Decimal,9),
					new SqlParameter("@TaxRate", SqlDbType.Decimal,9),
					new SqlParameter("@ProjectName", SqlDbType.NVarChar,90),
					new SqlParameter("@FareID", SqlDbType.Int,4)};
			parameters[0].Value = model.PriceTypeID;
			parameters[1].Value = model.FareTypeName;
			parameters[2].Value = model.Price;
			parameters[3].Value = model.Price2;
			parameters[4].Value = model.Price3;
			parameters[5].Value = model.FareNo;
			parameters[6].Value = model.ReMark;
			parameters[7].Value = model.Price4;
			parameters[8].Value = model.Price5;
			parameters[9].Value = model.Price6;
			parameters[10].Value = model.TaxRate;
			parameters[11].Value = model.ProjectName;
			parameters[12].Value = model.FareID;

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
		public bool Delete(int FareID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PriceFare ");
			strSql.Append(" where FareID=@FareID");
			SqlParameter[] parameters = {
					new SqlParameter("@FareID", SqlDbType.Int,4)
			};
			parameters[0].Value = FareID;

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
		public bool DeleteList(string FareIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PriceFare ");
			strSql.Append(" where FareID in ("+FareIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.PriceFare GetModel(int FareID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FareID,PriceTypeID,FareTypeName,Price,Price2,Price3,FareNo,ReMark,Price4,Price5,Price6,TaxRate,ProjectName from PriceFare ");
			strSql.Append(" where FareID=@FareID");
			SqlParameter[] parameters = {
					new SqlParameter("@FareID", SqlDbType.Int,4)
			};
			parameters[0].Value = FareID;

			WebDemo.Model.WebDemo.PriceFare model=new WebDemo.Model.WebDemo.PriceFare();
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
		public WebDemo.Model.WebDemo.PriceFare DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.PriceFare model=new WebDemo.Model.WebDemo.PriceFare();
			if (row != null)
			{
				if(row["FareID"]!=null && row["FareID"].ToString()!="")
				{
					model.FareID=int.Parse(row["FareID"].ToString());
				}
				if(row["PriceTypeID"]!=null && row["PriceTypeID"].ToString()!="")
				{
					model.PriceTypeID=int.Parse(row["PriceTypeID"].ToString());
				}
				if(row["FareTypeName"]!=null)
				{
					model.FareTypeName=row["FareTypeName"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["Price2"]!=null && row["Price2"].ToString()!="")
				{
					model.Price2=decimal.Parse(row["Price2"].ToString());
				}
				if(row["Price3"]!=null && row["Price3"].ToString()!="")
				{
					model.Price3=decimal.Parse(row["Price3"].ToString());
				}
				if(row["FareNo"]!=null && row["FareNo"].ToString()!="")
				{
					model.FareNo=int.Parse(row["FareNo"].ToString());
				}
				if(row["ReMark"]!=null)
				{
					model.ReMark=row["ReMark"].ToString();
				}
				if(row["Price4"]!=null && row["Price4"].ToString()!="")
				{
					model.Price4=decimal.Parse(row["Price4"].ToString());
				}
				if(row["Price5"]!=null && row["Price5"].ToString()!="")
				{
					model.Price5=decimal.Parse(row["Price5"].ToString());
				}
				if(row["Price6"]!=null && row["Price6"].ToString()!="")
				{
					model.Price6=decimal.Parse(row["Price6"].ToString());
				}
				if(row["TaxRate"]!=null && row["TaxRate"].ToString()!="")
				{
					model.TaxRate=decimal.Parse(row["TaxRate"].ToString());
				}
				if(row["ProjectName"]!=null)
				{
					model.ProjectName=row["ProjectName"].ToString();
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
			strSql.Append("select FareID,PriceTypeID,FareTypeName,Price,Price2,Price3,FareNo,ReMark,Price4,Price5,Price6,TaxRate,ProjectName ");
			strSql.Append(" FROM PriceFare ");
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
			strSql.Append(" FareID,PriceTypeID,FareTypeName,Price,Price2,Price3,FareNo,ReMark,Price4,Price5,Price6,TaxRate,ProjectName ");
			strSql.Append(" FROM PriceFare ");
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
			strSql.Append("select count(1) FROM PriceFare ");
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
				strSql.Append("order by T.FareID desc");
			}
			strSql.Append(")AS Row, T.*  from PriceFare T ");
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
			parameters[0].Value = "PriceFare";
			parameters[1].Value = "FareID";
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

