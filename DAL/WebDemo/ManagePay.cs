using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:ManagePay
	/// </summary>
	public partial class ManagePay
	{
		public ManagePay()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.ManagePay model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ManagePay(");
			strSql.Append("UsersID,OperMoney,OperatorID,OperDate,PayType,Flag,ThisReserve,LastReserve,RedOperId)");
			strSql.Append(" values (");
			strSql.Append("@UsersID,@OperMoney,@OperatorID,@OperDate,@PayType,@Flag,@ThisReserve,@LastReserve,@RedOperId)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@OperMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@ThisReserve", SqlDbType.Decimal,9),
					new SqlParameter("@LastReserve", SqlDbType.Decimal,9),
					new SqlParameter("@RedOperId", SqlDbType.Int,4)};
			parameters[0].Value = model.UsersID;
			parameters[1].Value = model.OperMoney;
			parameters[2].Value = model.OperatorID;
			parameters[3].Value = model.OperDate;
			parameters[4].Value = model.PayType;
			parameters[5].Value = model.Flag;
			parameters[6].Value = model.ThisReserve;
			parameters[7].Value = model.LastReserve;
			parameters[8].Value = model.RedOperId;

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
		public bool Update(WebDemo.Model.WebDemo.ManagePay model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ManagePay set ");
			strSql.Append("UsersID=@UsersID,");
			strSql.Append("OperMoney=@OperMoney,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("OperDate=@OperDate,");
			strSql.Append("PayType=@PayType,");
			strSql.Append("Flag=@Flag,");
			strSql.Append("ThisReserve=@ThisReserve,");
			strSql.Append("LastReserve=@LastReserve,");
			strSql.Append("RedOperId=@RedOperId");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@OperMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@ThisReserve", SqlDbType.Decimal,9),
					new SqlParameter("@LastReserve", SqlDbType.Decimal,9),
					new SqlParameter("@RedOperId", SqlDbType.Int,4),
					new SqlParameter("@OperID", SqlDbType.Int,4)};
			parameters[0].Value = model.UsersID;
			parameters[1].Value = model.OperMoney;
			parameters[2].Value = model.OperatorID;
			parameters[3].Value = model.OperDate;
			parameters[4].Value = model.PayType;
			parameters[5].Value = model.Flag;
			parameters[6].Value = model.ThisReserve;
			parameters[7].Value = model.LastReserve;
			parameters[8].Value = model.RedOperId;
			parameters[9].Value = model.OperID;

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
		public bool Delete(int OperID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ManagePay ");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4)
			};
			parameters[0].Value = OperID;

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
		public bool DeleteList(string OperIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ManagePay ");
			strSql.Append(" where OperID in ("+OperIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.ManagePay GetModel(int OperID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OperID,UsersID,OperMoney,OperatorID,OperDate,PayType,Flag,ThisReserve,LastReserve,RedOperId from ManagePay ");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4)
			};
			parameters[0].Value = OperID;

			WebDemo.Model.WebDemo.ManagePay model=new WebDemo.Model.WebDemo.ManagePay();
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
		public WebDemo.Model.WebDemo.ManagePay DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.ManagePay model=new WebDemo.Model.WebDemo.ManagePay();
			if (row != null)
			{
				if(row["OperID"]!=null && row["OperID"].ToString()!="")
				{
					model.OperID=int.Parse(row["OperID"].ToString());
				}
				if(row["UsersID"]!=null && row["UsersID"].ToString()!="")
				{
					model.UsersID=int.Parse(row["UsersID"].ToString());
				}
				if(row["OperMoney"]!=null && row["OperMoney"].ToString()!="")
				{
					model.OperMoney=decimal.Parse(row["OperMoney"].ToString());
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["OperDate"]!=null && row["OperDate"].ToString()!="")
				{
					model.OperDate=DateTime.Parse(row["OperDate"].ToString());
				}
				if(row["PayType"]!=null && row["PayType"].ToString()!="")
				{
					model.PayType=int.Parse(row["PayType"].ToString());
				}
				if(row["Flag"]!=null && row["Flag"].ToString()!="")
				{
					model.Flag=int.Parse(row["Flag"].ToString());
				}
				if(row["ThisReserve"]!=null && row["ThisReserve"].ToString()!="")
				{
					model.ThisReserve=decimal.Parse(row["ThisReserve"].ToString());
				}
				if(row["LastReserve"]!=null && row["LastReserve"].ToString()!="")
				{
					model.LastReserve=decimal.Parse(row["LastReserve"].ToString());
				}
				if(row["RedOperId"]!=null && row["RedOperId"].ToString()!="")
				{
					model.RedOperId=int.Parse(row["RedOperId"].ToString());
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
			strSql.Append("select OperID,UsersID,OperMoney,OperatorID,OperDate,PayType,Flag,ThisReserve,LastReserve,RedOperId ");
			strSql.Append(" FROM ManagePay ");
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
			strSql.Append(" OperID,UsersID,OperMoney,OperatorID,OperDate,PayType,Flag,ThisReserve,LastReserve,RedOperId ");
			strSql.Append(" FROM ManagePay ");
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
			strSql.Append("select count(1) FROM ManagePay ");
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
				strSql.Append("order by T.OperID desc");
			}
			strSql.Append(")AS Row, T.*  from ManagePay T ");
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
			parameters[0].Value = "ManagePay";
			parameters[1].Value = "OperID";
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

