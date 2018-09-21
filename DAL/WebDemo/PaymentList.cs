using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:PaymentList
	/// </summary>
	public partial class PaymentList
	{
		public PaymentList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("OperID", "PaymentList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OperID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PaymentList");
			strSql.Append(" where OperID=@OperID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4)			};
			parameters[0].Value = OperID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.PaymentList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PaymentList(");
			strSql.Append("OperID,UsersID,MeterID,InvoiceNum,Lastbalance,ThisMoney,FactMoney,ThisBalance,PayDate,OperatorID,PayMode,Flag,SiteID,OperInt,Price,InvoiceID,InvoiceType,PayType,PayWay,TransactionId,OutTradeNo)");
			strSql.Append(" values (");
			strSql.Append("@OperID,@UsersID,@MeterID,@InvoiceNum,@Lastbalance,@ThisMoney,@FactMoney,@ThisBalance,@PayDate,@OperatorID,@PayMode,@Flag,@SiteID,@OperInt,@Price,@InvoiceID,@InvoiceType,@PayType,@PayWay,@TransactionId,@OutTradeNo)");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceNum", SqlDbType.VarChar,50),
					new SqlParameter("@Lastbalance", SqlDbType.Decimal,9),
					new SqlParameter("@ThisMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FactMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ThisBalance", SqlDbType.Decimal,9),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@PayMode", SqlDbType.Int,4),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@OperInt", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@InvoiceID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceType", SqlDbType.Int,4),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@PayWay", SqlDbType.Int,4),
					new SqlParameter("@TransactionId", SqlDbType.VarChar,100),
					new SqlParameter("@OutTradeNo", SqlDbType.VarChar,100)};
			parameters[0].Value = model.OperID;
			parameters[1].Value = model.UsersID;
			parameters[2].Value = model.MeterID;
			parameters[3].Value = model.InvoiceNum;
			parameters[4].Value = model.Lastbalance;
			parameters[5].Value = model.ThisMoney;
			parameters[6].Value = model.FactMoney;
			parameters[7].Value = model.ThisBalance;
			parameters[8].Value = model.PayDate;
			parameters[9].Value = model.OperatorID;
			parameters[10].Value = model.PayMode;
			parameters[11].Value = model.Flag;
			parameters[12].Value = model.SiteID;
			parameters[13].Value = model.OperInt;
			parameters[14].Value = model.Price;
			parameters[15].Value = model.InvoiceID;
			parameters[16].Value = model.InvoiceType;
			parameters[17].Value = model.PayType;
			parameters[18].Value = model.PayWay;
			parameters[19].Value = model.TransactionId;
			parameters[20].Value = model.OutTradeNo;

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
		public bool Update(WebDemo.Model.WebDemo.PaymentList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PaymentList set ");
			strSql.Append("UsersID=@UsersID,");
			strSql.Append("MeterID=@MeterID,");
			strSql.Append("InvoiceNum=@InvoiceNum,");
			strSql.Append("Lastbalance=@Lastbalance,");
			strSql.Append("ThisMoney=@ThisMoney,");
			strSql.Append("FactMoney=@FactMoney,");
			strSql.Append("ThisBalance=@ThisBalance,");
			strSql.Append("PayDate=@PayDate,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("PayMode=@PayMode,");
			strSql.Append("Flag=@Flag,");
			strSql.Append("SiteID=@SiteID,");
			strSql.Append("OperInt=@OperInt,");
			strSql.Append("Price=@Price,");
			strSql.Append("InvoiceID=@InvoiceID,");
			strSql.Append("InvoiceType=@InvoiceType,");
			strSql.Append("PayType=@PayType,");
			strSql.Append("PayWay=@PayWay,");
			strSql.Append("TransactionId=@TransactionId,");
			strSql.Append("OutTradeNo=@OutTradeNo");
			strSql.Append(" where OperID=@OperID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceNum", SqlDbType.VarChar,50),
					new SqlParameter("@Lastbalance", SqlDbType.Decimal,9),
					new SqlParameter("@ThisMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FactMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ThisBalance", SqlDbType.Decimal,9),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@PayMode", SqlDbType.Int,4),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@OperInt", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@InvoiceID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceType", SqlDbType.Int,4),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@PayWay", SqlDbType.Int,4),
					new SqlParameter("@TransactionId", SqlDbType.VarChar,100),
					new SqlParameter("@OutTradeNo", SqlDbType.VarChar,100),
					new SqlParameter("@OperID", SqlDbType.Int,4)};
			parameters[0].Value = model.UsersID;
			parameters[1].Value = model.MeterID;
			parameters[2].Value = model.InvoiceNum;
			parameters[3].Value = model.Lastbalance;
			parameters[4].Value = model.ThisMoney;
			parameters[5].Value = model.FactMoney;
			parameters[6].Value = model.ThisBalance;
			parameters[7].Value = model.PayDate;
			parameters[8].Value = model.OperatorID;
			parameters[9].Value = model.PayMode;
			parameters[10].Value = model.Flag;
			parameters[11].Value = model.SiteID;
			parameters[12].Value = model.OperInt;
			parameters[13].Value = model.Price;
			parameters[14].Value = model.InvoiceID;
			parameters[15].Value = model.InvoiceType;
			parameters[16].Value = model.PayType;
			parameters[17].Value = model.PayWay;
			parameters[18].Value = model.TransactionId;
			parameters[19].Value = model.OutTradeNo;
			parameters[20].Value = model.OperID;

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
			strSql.Append("delete from PaymentList ");
			strSql.Append(" where OperID=@OperID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4)			};
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
			strSql.Append("delete from PaymentList ");
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
		public WebDemo.Model.WebDemo.PaymentList GetModel(int OperID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OperID,UsersID,MeterID,InvoiceNum,Lastbalance,ThisMoney,FactMoney,ThisBalance,PayDate,OperatorID,PayMode,Flag,SiteID,OperInt,Price,InvoiceID,InvoiceType,PayType,PayWay,TransactionId,OutTradeNo from PaymentList ");
			strSql.Append(" where OperID=@OperID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4)			};
			parameters[0].Value = OperID;

			WebDemo.Model.WebDemo.PaymentList model=new WebDemo.Model.WebDemo.PaymentList();
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
		public WebDemo.Model.WebDemo.PaymentList DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.PaymentList model=new WebDemo.Model.WebDemo.PaymentList();
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
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["InvoiceNum"]!=null)
				{
					model.InvoiceNum=row["InvoiceNum"].ToString();
				}
				if(row["Lastbalance"]!=null && row["Lastbalance"].ToString()!="")
				{
					model.Lastbalance=decimal.Parse(row["Lastbalance"].ToString());
				}
				if(row["ThisMoney"]!=null && row["ThisMoney"].ToString()!="")
				{
					model.ThisMoney=decimal.Parse(row["ThisMoney"].ToString());
				}
				if(row["FactMoney"]!=null && row["FactMoney"].ToString()!="")
				{
					model.FactMoney=decimal.Parse(row["FactMoney"].ToString());
				}
				if(row["ThisBalance"]!=null && row["ThisBalance"].ToString()!="")
				{
					model.ThisBalance=decimal.Parse(row["ThisBalance"].ToString());
				}
				if(row["PayDate"]!=null && row["PayDate"].ToString()!="")
				{
					model.PayDate=DateTime.Parse(row["PayDate"].ToString());
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["PayMode"]!=null && row["PayMode"].ToString()!="")
				{
					model.PayMode=int.Parse(row["PayMode"].ToString());
				}
				if(row["Flag"]!=null && row["Flag"].ToString()!="")
				{
					model.Flag=int.Parse(row["Flag"].ToString());
				}
				if(row["SiteID"]!=null && row["SiteID"].ToString()!="")
				{
					model.SiteID=int.Parse(row["SiteID"].ToString());
				}
				if(row["OperInt"]!=null && row["OperInt"].ToString()!="")
				{
					model.OperInt=int.Parse(row["OperInt"].ToString());
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["InvoiceID"]!=null && row["InvoiceID"].ToString()!="")
				{
					model.InvoiceID=int.Parse(row["InvoiceID"].ToString());
				}
				if(row["InvoiceType"]!=null && row["InvoiceType"].ToString()!="")
				{
					model.InvoiceType=int.Parse(row["InvoiceType"].ToString());
				}
				if(row["PayType"]!=null && row["PayType"].ToString()!="")
				{
					model.PayType=int.Parse(row["PayType"].ToString());
				}
				if(row["PayWay"]!=null && row["PayWay"].ToString()!="")
				{
					model.PayWay=int.Parse(row["PayWay"].ToString());
				}
				if(row["TransactionId"]!=null)
				{
					model.TransactionId=row["TransactionId"].ToString();
				}
				if(row["OutTradeNo"]!=null)
				{
					model.OutTradeNo=row["OutTradeNo"].ToString();
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
			strSql.Append("select OperID,UsersID,MeterID,InvoiceNum,Lastbalance,ThisMoney,FactMoney,ThisBalance,PayDate,OperatorID,PayMode,Flag,SiteID,OperInt,Price,InvoiceID,InvoiceType,PayType,PayWay,TransactionId,OutTradeNo ");
			strSql.Append(" FROM PaymentList ");
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
			strSql.Append(" OperID,UsersID,MeterID,InvoiceNum,Lastbalance,ThisMoney,FactMoney,ThisBalance,PayDate,OperatorID,PayMode,Flag,SiteID,OperInt,Price,InvoiceID,InvoiceType,PayType,PayWay,TransactionId,OutTradeNo ");
			strSql.Append(" FROM PaymentList ");
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
			strSql.Append("select count(1) FROM PaymentList ");
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
			strSql.Append(")AS Row, T.*  from PaymentList T ");
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
			parameters[0].Value = "PaymentList";
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

