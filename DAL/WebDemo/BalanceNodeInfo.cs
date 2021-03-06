﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:BalanceNodeInfo
	/// </summary>
	public partial class BalanceNodeInfo
	{
		public BalanceNodeInfo()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.BalanceNodeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BalanceNodeInfo(");
			strSql.Append("OperatorId,BeginDate,EndDate,FactMoney,PayCount)");
			strSql.Append(" values (");
			strSql.Append("@OperatorId,@BeginDate,@EndDate,@FactMoney,@PayCount)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorId", SqlDbType.Int,4),
					new SqlParameter("@BeginDate", SqlDbType.DateTime),
					new SqlParameter("@EndDate", SqlDbType.DateTime),
					new SqlParameter("@FactMoney", SqlDbType.Decimal,9),
					new SqlParameter("@PayCount", SqlDbType.Int,4)};
			parameters[0].Value = model.OperatorId;
			parameters[1].Value = model.BeginDate;
			parameters[2].Value = model.EndDate;
			parameters[3].Value = model.FactMoney;
			parameters[4].Value = model.PayCount;

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
		public bool Update(WebDemo.Model.WebDemo.BalanceNodeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BalanceNodeInfo set ");
			strSql.Append("OperatorId=@OperatorId,");
			strSql.Append("BeginDate=@BeginDate,");
			strSql.Append("EndDate=@EndDate,");
			strSql.Append("FactMoney=@FactMoney,");
			strSql.Append("PayCount=@PayCount");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorId", SqlDbType.Int,4),
					new SqlParameter("@BeginDate", SqlDbType.DateTime),
					new SqlParameter("@EndDate", SqlDbType.DateTime),
					new SqlParameter("@FactMoney", SqlDbType.Decimal,9),
					new SqlParameter("@PayCount", SqlDbType.Int,4),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.OperatorId;
			parameters[1].Value = model.BeginDate;
			parameters[2].Value = model.EndDate;
			parameters[3].Value = model.FactMoney;
			parameters[4].Value = model.PayCount;
			parameters[5].Value = model.Id;

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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BalanceNodeInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BalanceNodeInfo ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
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
		public WebDemo.Model.WebDemo.BalanceNodeInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,OperatorId,BeginDate,EndDate,FactMoney,PayCount from BalanceNodeInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			WebDemo.Model.WebDemo.BalanceNodeInfo model=new WebDemo.Model.WebDemo.BalanceNodeInfo();
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
		public WebDemo.Model.WebDemo.BalanceNodeInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.BalanceNodeInfo model=new WebDemo.Model.WebDemo.BalanceNodeInfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["OperatorId"]!=null && row["OperatorId"].ToString()!="")
				{
					model.OperatorId=int.Parse(row["OperatorId"].ToString());
				}
				if(row["BeginDate"]!=null && row["BeginDate"].ToString()!="")
				{
					model.BeginDate=DateTime.Parse(row["BeginDate"].ToString());
				}
				if(row["EndDate"]!=null && row["EndDate"].ToString()!="")
				{
					model.EndDate=DateTime.Parse(row["EndDate"].ToString());
				}
				if(row["FactMoney"]!=null && row["FactMoney"].ToString()!="")
				{
					model.FactMoney=decimal.Parse(row["FactMoney"].ToString());
				}
				if(row["PayCount"]!=null && row["PayCount"].ToString()!="")
				{
					model.PayCount=int.Parse(row["PayCount"].ToString());
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
			strSql.Append("select Id,OperatorId,BeginDate,EndDate,FactMoney,PayCount ");
			strSql.Append(" FROM BalanceNodeInfo ");
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
			strSql.Append(" Id,OperatorId,BeginDate,EndDate,FactMoney,PayCount ");
			strSql.Append(" FROM BalanceNodeInfo ");
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
			strSql.Append("select count(1) FROM BalanceNodeInfo ");
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from BalanceNodeInfo T ");
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
			parameters[0].Value = "BalanceNodeInfo";
			parameters[1].Value = "Id";
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

