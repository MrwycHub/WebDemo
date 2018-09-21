using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:InvoiceRangeInfo
	/// </summary>
	public partial class InvoiceRangeInfo
	{
		public InvoiceRangeInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("BatchId", "InvoiceRangeInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int BatchId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InvoiceRangeInfo");
			strSql.Append(" where BatchId=@BatchId");
			SqlParameter[] parameters = {
					new SqlParameter("@BatchId", SqlDbType.Int,4)
			};
			parameters[0].Value = BatchId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.InvoiceRangeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InvoiceRangeInfo(");
			strSql.Append("InCode,StartNum,EndNum,OperatorName,GetDateTime,InDate,SiteID,Remark)");
			strSql.Append(" values (");
			strSql.Append("@InCode,@StartNum,@EndNum,@OperatorName,@GetDateTime,@InDate,@SiteID,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@InCode", SqlDbType.VarChar,50),
					new SqlParameter("@StartNum", SqlDbType.VarChar,50),
					new SqlParameter("@EndNum", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@GetDateTime", SqlDbType.DateTime),
					new SqlParameter("@InDate", SqlDbType.DateTime),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
			parameters[0].Value = model.InCode;
			parameters[1].Value = model.StartNum;
			parameters[2].Value = model.EndNum;
			parameters[3].Value = model.OperatorName;
			parameters[4].Value = model.GetDateTime;
			parameters[5].Value = model.InDate;
			parameters[6].Value = model.SiteID;
			parameters[7].Value = model.Remark;

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
		public bool Update(WebDemo.Model.WebDemo.InvoiceRangeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InvoiceRangeInfo set ");
			strSql.Append("InCode=@InCode,");
			strSql.Append("StartNum=@StartNum,");
			strSql.Append("EndNum=@EndNum,");
			strSql.Append("OperatorName=@OperatorName,");
			strSql.Append("GetDateTime=@GetDateTime,");
			strSql.Append("InDate=@InDate,");
			strSql.Append("SiteID=@SiteID,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where BatchId=@BatchId");
			SqlParameter[] parameters = {
					new SqlParameter("@InCode", SqlDbType.VarChar,50),
					new SqlParameter("@StartNum", SqlDbType.VarChar,50),
					new SqlParameter("@EndNum", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@GetDateTime", SqlDbType.DateTime),
					new SqlParameter("@InDate", SqlDbType.DateTime),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@BatchId", SqlDbType.Int,4)};
			parameters[0].Value = model.InCode;
			parameters[1].Value = model.StartNum;
			parameters[2].Value = model.EndNum;
			parameters[3].Value = model.OperatorName;
			parameters[4].Value = model.GetDateTime;
			parameters[5].Value = model.InDate;
			parameters[6].Value = model.SiteID;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.BatchId;

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
		public bool Delete(int BatchId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InvoiceRangeInfo ");
			strSql.Append(" where BatchId=@BatchId");
			SqlParameter[] parameters = {
					new SqlParameter("@BatchId", SqlDbType.Int,4)
			};
			parameters[0].Value = BatchId;

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
		public bool DeleteList(string BatchIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InvoiceRangeInfo ");
			strSql.Append(" where BatchId in ("+BatchIdlist + ")  ");
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
		public WebDemo.Model.WebDemo.InvoiceRangeInfo GetModel(int BatchId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BatchId,InCode,StartNum,EndNum,OperatorName,GetDateTime,InDate,SiteID,Remark from InvoiceRangeInfo ");
			strSql.Append(" where BatchId=@BatchId");
			SqlParameter[] parameters = {
					new SqlParameter("@BatchId", SqlDbType.Int,4)
			};
			parameters[0].Value = BatchId;

			WebDemo.Model.WebDemo.InvoiceRangeInfo model=new WebDemo.Model.WebDemo.InvoiceRangeInfo();
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
		public WebDemo.Model.WebDemo.InvoiceRangeInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.InvoiceRangeInfo model=new WebDemo.Model.WebDemo.InvoiceRangeInfo();
			if (row != null)
			{
				if(row["BatchId"]!=null && row["BatchId"].ToString()!="")
				{
					model.BatchId=int.Parse(row["BatchId"].ToString());
				}
				if(row["InCode"]!=null)
				{
					model.InCode=row["InCode"].ToString();
				}
				if(row["StartNum"]!=null)
				{
					model.StartNum=row["StartNum"].ToString();
				}
				if(row["EndNum"]!=null)
				{
					model.EndNum=row["EndNum"].ToString();
				}
				if(row["OperatorName"]!=null)
				{
					model.OperatorName=row["OperatorName"].ToString();
				}
				if(row["GetDateTime"]!=null && row["GetDateTime"].ToString()!="")
				{
					model.GetDateTime=DateTime.Parse(row["GetDateTime"].ToString());
				}
				if(row["InDate"]!=null && row["InDate"].ToString()!="")
				{
					model.InDate=DateTime.Parse(row["InDate"].ToString());
				}
				if(row["SiteID"]!=null && row["SiteID"].ToString()!="")
				{
					model.SiteID=int.Parse(row["SiteID"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select BatchId,InCode,StartNum,EndNum,OperatorName,GetDateTime,InDate,SiteID,Remark ");
			strSql.Append(" FROM InvoiceRangeInfo ");
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
			strSql.Append(" BatchId,InCode,StartNum,EndNum,OperatorName,GetDateTime,InDate,SiteID,Remark ");
			strSql.Append(" FROM InvoiceRangeInfo ");
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
			strSql.Append("select count(1) FROM InvoiceRangeInfo ");
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
				strSql.Append("order by T.BatchId desc");
			}
			strSql.Append(")AS Row, T.*  from InvoiceRangeInfo T ");
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
			parameters[0].Value = "InvoiceRangeInfo";
			parameters[1].Value = "BatchId";
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

