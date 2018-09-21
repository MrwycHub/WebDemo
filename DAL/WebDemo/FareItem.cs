using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:FareItem
	/// </summary>
	public partial class FareItem
	{
		public FareItem()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FareID", "FareItem"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FareID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FareItem");
			strSql.Append(" where FareID=@FareID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FareID", SqlDbType.Int,4)			};
			parameters[0].Value = FareID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.FareItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FareItem(");
			strSql.Append("FareID,CycNumber,FareName,FareMoney,FareMemo,FareMark,PriceUnit)");
			strSql.Append(" values (");
			strSql.Append("@FareID,@CycNumber,@FareName,@FareMoney,@FareMemo,@FareMark,@PriceUnit)");
			SqlParameter[] parameters = {
					new SqlParameter("@FareID", SqlDbType.Int,4),
					new SqlParameter("@CycNumber", SqlDbType.Int,4),
					new SqlParameter("@FareName", SqlDbType.VarChar,100),
					new SqlParameter("@FareMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FareMemo", SqlDbType.VarChar,200),
					new SqlParameter("@FareMark", SqlDbType.Int,4),
					new SqlParameter("@PriceUnit", SqlDbType.VarChar,20)};
			parameters[0].Value = model.FareID;
			parameters[1].Value = model.CycNumber;
			parameters[2].Value = model.FareName;
			parameters[3].Value = model.FareMoney;
			parameters[4].Value = model.FareMemo;
			parameters[5].Value = model.FareMark;
			parameters[6].Value = model.PriceUnit;

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
		public bool Update(WebDemo.Model.WebDemo.FareItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FareItem set ");
			strSql.Append("CycNumber=@CycNumber,");
			strSql.Append("FareName=@FareName,");
			strSql.Append("FareMoney=@FareMoney,");
			strSql.Append("FareMemo=@FareMemo,");
			strSql.Append("FareMark=@FareMark,");
			strSql.Append("PriceUnit=@PriceUnit");
			strSql.Append(" where FareID=@FareID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CycNumber", SqlDbType.Int,4),
					new SqlParameter("@FareName", SqlDbType.VarChar,100),
					new SqlParameter("@FareMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FareMemo", SqlDbType.VarChar,200),
					new SqlParameter("@FareMark", SqlDbType.Int,4),
					new SqlParameter("@PriceUnit", SqlDbType.VarChar,20),
					new SqlParameter("@FareID", SqlDbType.Int,4)};
			parameters[0].Value = model.CycNumber;
			parameters[1].Value = model.FareName;
			parameters[2].Value = model.FareMoney;
			parameters[3].Value = model.FareMemo;
			parameters[4].Value = model.FareMark;
			parameters[5].Value = model.PriceUnit;
			parameters[6].Value = model.FareID;

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
			strSql.Append("delete from FareItem ");
			strSql.Append(" where FareID=@FareID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FareID", SqlDbType.Int,4)			};
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
			strSql.Append("delete from FareItem ");
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
		public WebDemo.Model.WebDemo.FareItem GetModel(int FareID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FareID,CycNumber,FareName,FareMoney,FareMemo,FareMark,PriceUnit from FareItem ");
			strSql.Append(" where FareID=@FareID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FareID", SqlDbType.Int,4)			};
			parameters[0].Value = FareID;

			WebDemo.Model.WebDemo.FareItem model=new WebDemo.Model.WebDemo.FareItem();
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
		public WebDemo.Model.WebDemo.FareItem DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.FareItem model=new WebDemo.Model.WebDemo.FareItem();
			if (row != null)
			{
				if(row["FareID"]!=null && row["FareID"].ToString()!="")
				{
					model.FareID=int.Parse(row["FareID"].ToString());
				}
				if(row["CycNumber"]!=null && row["CycNumber"].ToString()!="")
				{
					model.CycNumber=int.Parse(row["CycNumber"].ToString());
				}
				if(row["FareName"]!=null)
				{
					model.FareName=row["FareName"].ToString();
				}
				if(row["FareMoney"]!=null && row["FareMoney"].ToString()!="")
				{
					model.FareMoney=decimal.Parse(row["FareMoney"].ToString());
				}
				if(row["FareMemo"]!=null)
				{
					model.FareMemo=row["FareMemo"].ToString();
				}
				if(row["FareMark"]!=null && row["FareMark"].ToString()!="")
				{
					model.FareMark=int.Parse(row["FareMark"].ToString());
				}
				if(row["PriceUnit"]!=null)
				{
					model.PriceUnit=row["PriceUnit"].ToString();
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
			strSql.Append("select FareID,CycNumber,FareName,FareMoney,FareMemo,FareMark,PriceUnit ");
			strSql.Append(" FROM FareItem ");
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
			strSql.Append(" FareID,CycNumber,FareName,FareMoney,FareMemo,FareMark,PriceUnit ");
			strSql.Append(" FROM FareItem ");
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
			strSql.Append("select count(1) FROM FareItem ");
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
			strSql.Append(")AS Row, T.*  from FareItem T ");
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
			parameters[0].Value = "FareItem";
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

