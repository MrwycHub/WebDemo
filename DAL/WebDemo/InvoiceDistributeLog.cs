using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:InvoiceDistributeLog
	/// </summary>
	public partial class InvoiceDistributeLog
	{
		public InvoiceDistributeLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DisId", "InvoiceDistributeLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DisId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InvoiceDistributeLog");
			strSql.Append(" where DisId=@DisId");
			SqlParameter[] parameters = {
					new SqlParameter("@DisId", SqlDbType.Int,4)
			};
			parameters[0].Value = DisId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.InvoiceDistributeLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InvoiceDistributeLog(");
			strSql.Append("BatchId,InCode,StartNum,EndNum,OperatorID,AssignDate,AssignOperator,State,Remark)");
			strSql.Append(" values (");
			strSql.Append("@BatchId,@InCode,@StartNum,@EndNum,@OperatorID,@AssignDate,@AssignOperator,@State,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@BatchId", SqlDbType.Int,4),
					new SqlParameter("@InCode", SqlDbType.VarChar,50),
					new SqlParameter("@StartNum", SqlDbType.VarChar,50),
					new SqlParameter("@EndNum", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@AssignDate", SqlDbType.DateTime),
					new SqlParameter("@AssignOperator", SqlDbType.VarChar,50),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
			parameters[0].Value = model.BatchId;
			parameters[1].Value = model.InCode;
			parameters[2].Value = model.StartNum;
			parameters[3].Value = model.EndNum;
			parameters[4].Value = model.OperatorID;
			parameters[5].Value = model.AssignDate;
			parameters[6].Value = model.AssignOperator;
			parameters[7].Value = model.State;
			parameters[8].Value = model.Remark;

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
		public bool Update(WebDemo.Model.WebDemo.InvoiceDistributeLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InvoiceDistributeLog set ");
			strSql.Append("BatchId=@BatchId,");
			strSql.Append("InCode=@InCode,");
			strSql.Append("StartNum=@StartNum,");
			strSql.Append("EndNum=@EndNum,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("AssignDate=@AssignDate,");
			strSql.Append("AssignOperator=@AssignOperator,");
			strSql.Append("State=@State,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where DisId=@DisId");
			SqlParameter[] parameters = {
					new SqlParameter("@BatchId", SqlDbType.Int,4),
					new SqlParameter("@InCode", SqlDbType.VarChar,50),
					new SqlParameter("@StartNum", SqlDbType.VarChar,50),
					new SqlParameter("@EndNum", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@AssignDate", SqlDbType.DateTime),
					new SqlParameter("@AssignOperator", SqlDbType.VarChar,50),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@DisId", SqlDbType.Int,4)};
			parameters[0].Value = model.BatchId;
			parameters[1].Value = model.InCode;
			parameters[2].Value = model.StartNum;
			parameters[3].Value = model.EndNum;
			parameters[4].Value = model.OperatorID;
			parameters[5].Value = model.AssignDate;
			parameters[6].Value = model.AssignOperator;
			parameters[7].Value = model.State;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.DisId;

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
		public bool Delete(int DisId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InvoiceDistributeLog ");
			strSql.Append(" where DisId=@DisId");
			SqlParameter[] parameters = {
					new SqlParameter("@DisId", SqlDbType.Int,4)
			};
			parameters[0].Value = DisId;

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
		public bool DeleteList(string DisIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InvoiceDistributeLog ");
			strSql.Append(" where DisId in ("+DisIdlist + ")  ");
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
		public WebDemo.Model.WebDemo.InvoiceDistributeLog GetModel(int DisId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DisId,BatchId,InCode,StartNum,EndNum,OperatorID,AssignDate,AssignOperator,State,Remark from InvoiceDistributeLog ");
			strSql.Append(" where DisId=@DisId");
			SqlParameter[] parameters = {
					new SqlParameter("@DisId", SqlDbType.Int,4)
			};
			parameters[0].Value = DisId;

			WebDemo.Model.WebDemo.InvoiceDistributeLog model=new WebDemo.Model.WebDemo.InvoiceDistributeLog();
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
		public WebDemo.Model.WebDemo.InvoiceDistributeLog DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.InvoiceDistributeLog model=new WebDemo.Model.WebDemo.InvoiceDistributeLog();
			if (row != null)
			{
				if(row["DisId"]!=null && row["DisId"].ToString()!="")
				{
					model.DisId=int.Parse(row["DisId"].ToString());
				}
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
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["AssignDate"]!=null && row["AssignDate"].ToString()!="")
				{
					model.AssignDate=DateTime.Parse(row["AssignDate"].ToString());
				}
				if(row["AssignOperator"]!=null)
				{
					model.AssignOperator=row["AssignOperator"].ToString();
				}
				if(row["State"]!=null && row["State"].ToString()!="")
				{
					model.State=int.Parse(row["State"].ToString());
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
			strSql.Append("select DisId,BatchId,InCode,StartNum,EndNum,OperatorID,AssignDate,AssignOperator,State,Remark ");
			strSql.Append(" FROM InvoiceDistributeLog ");
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
			strSql.Append(" DisId,BatchId,InCode,StartNum,EndNum,OperatorID,AssignDate,AssignOperator,State,Remark ");
			strSql.Append(" FROM InvoiceDistributeLog ");
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
			strSql.Append("select count(1) FROM InvoiceDistributeLog ");
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
				strSql.Append("order by T.DisId desc");
			}
			strSql.Append(")AS Row, T.*  from InvoiceDistributeLog T ");
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
			parameters[0].Value = "InvoiceDistributeLog";
			parameters[1].Value = "DisId";
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

