using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:InvoiceGet
	/// </summary>
	public partial class InvoiceGet
	{
		public InvoiceGet()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("InID", "InvoiceGet"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int InID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InvoiceGet");
			strSql.Append(" where InID=@InID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InID", SqlDbType.Int,4)			};
			parameters[0].Value = InID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.InvoiceGet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InvoiceGet(");
			strSql.Append("InID,InCode,StartNum,EndNum,OperatorName,InDate,SiteID)");
			strSql.Append(" values (");
			strSql.Append("@InID,@InCode,@StartNum,@EndNum,@OperatorName,@InDate,@SiteID)");
			SqlParameter[] parameters = {
					new SqlParameter("@InID", SqlDbType.Int,4),
					new SqlParameter("@InCode", SqlDbType.VarChar,20),
					new SqlParameter("@StartNum", SqlDbType.Int,4),
					new SqlParameter("@EndNum", SqlDbType.Int,4),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@InDate", SqlDbType.DateTime),
					new SqlParameter("@SiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.InID;
			parameters[1].Value = model.InCode;
			parameters[2].Value = model.StartNum;
			parameters[3].Value = model.EndNum;
			parameters[4].Value = model.OperatorName;
			parameters[5].Value = model.InDate;
			parameters[6].Value = model.SiteID;

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
		public bool Update(WebDemo.Model.WebDemo.InvoiceGet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InvoiceGet set ");
			strSql.Append("InCode=@InCode,");
			strSql.Append("StartNum=@StartNum,");
			strSql.Append("EndNum=@EndNum,");
			strSql.Append("OperatorName=@OperatorName,");
			strSql.Append("InDate=@InDate,");
			strSql.Append("SiteID=@SiteID");
			strSql.Append(" where InID=@InID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InCode", SqlDbType.VarChar,20),
					new SqlParameter("@StartNum", SqlDbType.Int,4),
					new SqlParameter("@EndNum", SqlDbType.Int,4),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@InDate", SqlDbType.DateTime),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@InID", SqlDbType.Int,4)};
			parameters[0].Value = model.InCode;
			parameters[1].Value = model.StartNum;
			parameters[2].Value = model.EndNum;
			parameters[3].Value = model.OperatorName;
			parameters[4].Value = model.InDate;
			parameters[5].Value = model.SiteID;
			parameters[6].Value = model.InID;

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
		public bool Delete(int InID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InvoiceGet ");
			strSql.Append(" where InID=@InID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InID", SqlDbType.Int,4)			};
			parameters[0].Value = InID;

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
		public bool DeleteList(string InIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InvoiceGet ");
			strSql.Append(" where InID in ("+InIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.InvoiceGet GetModel(int InID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 InID,InCode,StartNum,EndNum,OperatorName,InDate,SiteID from InvoiceGet ");
			strSql.Append(" where InID=@InID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InID", SqlDbType.Int,4)			};
			parameters[0].Value = InID;

			WebDemo.Model.WebDemo.InvoiceGet model=new WebDemo.Model.WebDemo.InvoiceGet();
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
		public WebDemo.Model.WebDemo.InvoiceGet DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.InvoiceGet model=new WebDemo.Model.WebDemo.InvoiceGet();
			if (row != null)
			{
				if(row["InID"]!=null && row["InID"].ToString()!="")
				{
					model.InID=int.Parse(row["InID"].ToString());
				}
				if(row["InCode"]!=null)
				{
					model.InCode=row["InCode"].ToString();
				}
				if(row["StartNum"]!=null && row["StartNum"].ToString()!="")
				{
					model.StartNum=int.Parse(row["StartNum"].ToString());
				}
				if(row["EndNum"]!=null && row["EndNum"].ToString()!="")
				{
					model.EndNum=int.Parse(row["EndNum"].ToString());
				}
				if(row["OperatorName"]!=null)
				{
					model.OperatorName=row["OperatorName"].ToString();
				}
				if(row["InDate"]!=null && row["InDate"].ToString()!="")
				{
					model.InDate=DateTime.Parse(row["InDate"].ToString());
				}
				if(row["SiteID"]!=null && row["SiteID"].ToString()!="")
				{
					model.SiteID=int.Parse(row["SiteID"].ToString());
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
			strSql.Append("select InID,InCode,StartNum,EndNum,OperatorName,InDate,SiteID ");
			strSql.Append(" FROM InvoiceGet ");
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
			strSql.Append(" InID,InCode,StartNum,EndNum,OperatorName,InDate,SiteID ");
			strSql.Append(" FROM InvoiceGet ");
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
			strSql.Append("select count(1) FROM InvoiceGet ");
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
				strSql.Append("order by T.InID desc");
			}
			strSql.Append(")AS Row, T.*  from InvoiceGet T ");
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
			parameters[0].Value = "InvoiceGet";
			parameters[1].Value = "InID";
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

