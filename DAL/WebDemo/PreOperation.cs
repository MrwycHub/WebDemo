using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:PreOperation
	/// </summary>
	public partial class PreOperation
	{
		public PreOperation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("OperID", "PreOperation"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(DateTime OperDate,int OperID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PreOperation");
			strSql.Append(" where OperDate=@OperDate and OperID=@OperID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperID", SqlDbType.Int,4)			};
			parameters[0].Value = OperDate;
			parameters[1].Value = OperID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.PreOperation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PreOperation(");
			strSql.Append("CardID,CardSector,PriceTypeID,PriceTypeName,Price,OperMoney,OperInt,OperZS,FactMoney,LastBalance,CurrentBalance,TotalMoney,TotalInt,TotalBase,OperType,PayType,InvoiceCode,OperDate,MeterID,OperatorID,SiteID,FactoryNum,Remark,RedOperId,OperNum,Price2,Price3,Divid1,Divid2,UseNumber1,UseNumber2,UseNumber3,CurTotalBuyNumber,InvoiceID,InvoiceType,WriteCardFlag,TransactionId,PayWay,OutTradeNo,DepositDate,DiscountsNum)");
			strSql.Append(" values (");
			strSql.Append("@CardID,@CardSector,@PriceTypeID,@PriceTypeName,@Price,@OperMoney,@OperInt,@OperZS,@FactMoney,@LastBalance,@CurrentBalance,@TotalMoney,@TotalInt,@TotalBase,@OperType,@PayType,@InvoiceCode,@OperDate,@MeterID,@OperatorID,@SiteID,@FactoryNum,@Remark,@RedOperId,@OperNum,@Price2,@Price3,@Divid1,@Divid2,@UseNumber1,@UseNumber2,@UseNumber3,@CurTotalBuyNumber,@InvoiceID,@InvoiceType,@WriteCardFlag,@TransactionId,@PayWay,@OutTradeNo,@DepositDate,@DiscountsNum)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.Int,4),
					new SqlParameter("@CardSector", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@OperMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OperInt", SqlDbType.Int,4),
					new SqlParameter("@OperZS", SqlDbType.Int,4),
					new SqlParameter("@FactMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LastBalance", SqlDbType.Decimal,9),
					new SqlParameter("@CurrentBalance", SqlDbType.Decimal,9),
					new SqlParameter("@TotalMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TotalInt", SqlDbType.Int,4),
					new SqlParameter("@TotalBase", SqlDbType.Int,4),
					new SqlParameter("@OperType", SqlDbType.Int,4),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@InvoiceCode", SqlDbType.VarChar,50),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@FactoryNum", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@RedOperId", SqlDbType.Int,4),
					new SqlParameter("@OperNum", SqlDbType.Int,4),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@Divid1", SqlDbType.Int,4),
					new SqlParameter("@Divid2", SqlDbType.Int,4),
					new SqlParameter("@UseNumber1", SqlDbType.Decimal,9),
					new SqlParameter("@UseNumber2", SqlDbType.Decimal,9),
					new SqlParameter("@UseNumber3", SqlDbType.Decimal,9),
					new SqlParameter("@CurTotalBuyNumber", SqlDbType.Decimal,9),
					new SqlParameter("@InvoiceID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceType", SqlDbType.Int,4),
					new SqlParameter("@WriteCardFlag", SqlDbType.Int,4),
					new SqlParameter("@TransactionId", SqlDbType.VarChar,100),
					new SqlParameter("@PayWay", SqlDbType.Int,4),
					new SqlParameter("@OutTradeNo", SqlDbType.VarChar,100),
					new SqlParameter("@DepositDate", SqlDbType.DateTime),
					new SqlParameter("@DiscountsNum", SqlDbType.Int,4)};
			parameters[0].Value = model.CardID;
			parameters[1].Value = model.CardSector;
			parameters[2].Value = model.PriceTypeID;
			parameters[3].Value = model.PriceTypeName;
			parameters[4].Value = model.Price;
			parameters[5].Value = model.OperMoney;
			parameters[6].Value = model.OperInt;
			parameters[7].Value = model.OperZS;
			parameters[8].Value = model.FactMoney;
			parameters[9].Value = model.LastBalance;
			parameters[10].Value = model.CurrentBalance;
			parameters[11].Value = model.TotalMoney;
			parameters[12].Value = model.TotalInt;
			parameters[13].Value = model.TotalBase;
			parameters[14].Value = model.OperType;
			parameters[15].Value = model.PayType;
			parameters[16].Value = model.InvoiceCode;
			parameters[17].Value = model.OperDate;
			parameters[18].Value = model.MeterID;
			parameters[19].Value = model.OperatorID;
			parameters[20].Value = model.SiteID;
			parameters[21].Value = model.FactoryNum;
			parameters[22].Value = model.Remark;
			parameters[23].Value = model.RedOperId;
			parameters[24].Value = model.OperNum;
			parameters[25].Value = model.Price2;
			parameters[26].Value = model.Price3;
			parameters[27].Value = model.Divid1;
			parameters[28].Value = model.Divid2;
			parameters[29].Value = model.UseNumber1;
			parameters[30].Value = model.UseNumber2;
			parameters[31].Value = model.UseNumber3;
			parameters[32].Value = model.CurTotalBuyNumber;
			parameters[33].Value = model.InvoiceID;
			parameters[34].Value = model.InvoiceType;
			parameters[35].Value = model.WriteCardFlag;
			parameters[36].Value = model.TransactionId;
			parameters[37].Value = model.PayWay;
			parameters[38].Value = model.OutTradeNo;
			parameters[39].Value = model.DepositDate;
			parameters[40].Value = model.DiscountsNum;

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
		public bool Update(WebDemo.Model.WebDemo.PreOperation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PreOperation set ");
			strSql.Append("CardID=@CardID,");
			strSql.Append("CardSector=@CardSector,");
			strSql.Append("PriceTypeID=@PriceTypeID,");
			strSql.Append("PriceTypeName=@PriceTypeName,");
			strSql.Append("Price=@Price,");
			strSql.Append("OperMoney=@OperMoney,");
			strSql.Append("OperInt=@OperInt,");
			strSql.Append("OperZS=@OperZS,");
			strSql.Append("FactMoney=@FactMoney,");
			strSql.Append("LastBalance=@LastBalance,");
			strSql.Append("CurrentBalance=@CurrentBalance,");
			strSql.Append("TotalMoney=@TotalMoney,");
			strSql.Append("TotalInt=@TotalInt,");
			strSql.Append("TotalBase=@TotalBase,");
			strSql.Append("OperType=@OperType,");
			strSql.Append("PayType=@PayType,");
			strSql.Append("InvoiceCode=@InvoiceCode,");
			strSql.Append("MeterID=@MeterID,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("SiteID=@SiteID,");
			strSql.Append("FactoryNum=@FactoryNum,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("RedOperId=@RedOperId,");
			strSql.Append("OperNum=@OperNum,");
			strSql.Append("Price2=@Price2,");
			strSql.Append("Price3=@Price3,");
			strSql.Append("Divid1=@Divid1,");
			strSql.Append("Divid2=@Divid2,");
			strSql.Append("UseNumber1=@UseNumber1,");
			strSql.Append("UseNumber2=@UseNumber2,");
			strSql.Append("UseNumber3=@UseNumber3,");
			strSql.Append("CurTotalBuyNumber=@CurTotalBuyNumber,");
			strSql.Append("InvoiceID=@InvoiceID,");
			strSql.Append("InvoiceType=@InvoiceType,");
			strSql.Append("WriteCardFlag=@WriteCardFlag,");
			strSql.Append("TransactionId=@TransactionId,");
			strSql.Append("PayWay=@PayWay,");
			strSql.Append("OutTradeNo=@OutTradeNo,");
			strSql.Append("DepositDate=@DepositDate,");
			strSql.Append("DiscountsNum=@DiscountsNum");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@CardID", SqlDbType.Int,4),
					new SqlParameter("@CardSector", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@OperMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OperInt", SqlDbType.Int,4),
					new SqlParameter("@OperZS", SqlDbType.Int,4),
					new SqlParameter("@FactMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LastBalance", SqlDbType.Decimal,9),
					new SqlParameter("@CurrentBalance", SqlDbType.Decimal,9),
					new SqlParameter("@TotalMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TotalInt", SqlDbType.Int,4),
					new SqlParameter("@TotalBase", SqlDbType.Int,4),
					new SqlParameter("@OperType", SqlDbType.Int,4),
					new SqlParameter("@PayType", SqlDbType.Int,4),
					new SqlParameter("@InvoiceCode", SqlDbType.VarChar,50),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@FactoryNum", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@RedOperId", SqlDbType.Int,4),
					new SqlParameter("@OperNum", SqlDbType.Int,4),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@Divid1", SqlDbType.Int,4),
					new SqlParameter("@Divid2", SqlDbType.Int,4),
					new SqlParameter("@UseNumber1", SqlDbType.Decimal,9),
					new SqlParameter("@UseNumber2", SqlDbType.Decimal,9),
					new SqlParameter("@UseNumber3", SqlDbType.Decimal,9),
					new SqlParameter("@CurTotalBuyNumber", SqlDbType.Decimal,9),
					new SqlParameter("@InvoiceID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceType", SqlDbType.Int,4),
					new SqlParameter("@WriteCardFlag", SqlDbType.Int,4),
					new SqlParameter("@TransactionId", SqlDbType.VarChar,100),
					new SqlParameter("@PayWay", SqlDbType.Int,4),
					new SqlParameter("@OutTradeNo", SqlDbType.VarChar,100),
					new SqlParameter("@DepositDate", SqlDbType.DateTime),
					new SqlParameter("@DiscountsNum", SqlDbType.Int,4),
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@OperDate", SqlDbType.DateTime)};
			parameters[0].Value = model.CardID;
			parameters[1].Value = model.CardSector;
			parameters[2].Value = model.PriceTypeID;
			parameters[3].Value = model.PriceTypeName;
			parameters[4].Value = model.Price;
			parameters[5].Value = model.OperMoney;
			parameters[6].Value = model.OperInt;
			parameters[7].Value = model.OperZS;
			parameters[8].Value = model.FactMoney;
			parameters[9].Value = model.LastBalance;
			parameters[10].Value = model.CurrentBalance;
			parameters[11].Value = model.TotalMoney;
			parameters[12].Value = model.TotalInt;
			parameters[13].Value = model.TotalBase;
			parameters[14].Value = model.OperType;
			parameters[15].Value = model.PayType;
			parameters[16].Value = model.InvoiceCode;
			parameters[17].Value = model.MeterID;
			parameters[18].Value = model.OperatorID;
			parameters[19].Value = model.SiteID;
			parameters[20].Value = model.FactoryNum;
			parameters[21].Value = model.Remark;
			parameters[22].Value = model.RedOperId;
			parameters[23].Value = model.OperNum;
			parameters[24].Value = model.Price2;
			parameters[25].Value = model.Price3;
			parameters[26].Value = model.Divid1;
			parameters[27].Value = model.Divid2;
			parameters[28].Value = model.UseNumber1;
			parameters[29].Value = model.UseNumber2;
			parameters[30].Value = model.UseNumber3;
			parameters[31].Value = model.CurTotalBuyNumber;
			parameters[32].Value = model.InvoiceID;
			parameters[33].Value = model.InvoiceType;
			parameters[34].Value = model.WriteCardFlag;
			parameters[35].Value = model.TransactionId;
			parameters[36].Value = model.PayWay;
			parameters[37].Value = model.OutTradeNo;
			parameters[38].Value = model.DepositDate;
			parameters[39].Value = model.DiscountsNum;
			parameters[40].Value = model.OperID;
			parameters[41].Value = model.OperDate;

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
			strSql.Append("delete from PreOperation ");
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(DateTime OperDate,int OperID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PreOperation ");
			strSql.Append(" where OperDate=@OperDate and OperID=@OperID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperID", SqlDbType.Int,4)			};
			parameters[0].Value = OperDate;
			parameters[1].Value = OperID;

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
			strSql.Append("delete from PreOperation ");
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
		public WebDemo.Model.WebDemo.PreOperation GetModel(int OperID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OperID,CardID,CardSector,PriceTypeID,PriceTypeName,Price,OperMoney,OperInt,OperZS,FactMoney,LastBalance,CurrentBalance,TotalMoney,TotalInt,TotalBase,OperType,PayType,InvoiceCode,OperDate,MeterID,OperatorID,SiteID,FactoryNum,Remark,RedOperId,OperNum,Price2,Price3,Divid1,Divid2,UseNumber1,UseNumber2,UseNumber3,CurTotalBuyNumber,InvoiceID,InvoiceType,WriteCardFlag,TransactionId,PayWay,OutTradeNo,DepositDate,DiscountsNum from PreOperation ");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4)
			};
			parameters[0].Value = OperID;

			WebDemo.Model.WebDemo.PreOperation model=new WebDemo.Model.WebDemo.PreOperation();
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
		public WebDemo.Model.WebDemo.PreOperation DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.PreOperation model=new WebDemo.Model.WebDemo.PreOperation();
			if (row != null)
			{
				if(row["OperID"]!=null && row["OperID"].ToString()!="")
				{
					model.OperID=int.Parse(row["OperID"].ToString());
				}
				if(row["CardID"]!=null && row["CardID"].ToString()!="")
				{
					model.CardID=int.Parse(row["CardID"].ToString());
				}
				if(row["CardSector"]!=null && row["CardSector"].ToString()!="")
				{
					model.CardSector=int.Parse(row["CardSector"].ToString());
				}
				if(row["PriceTypeID"]!=null && row["PriceTypeID"].ToString()!="")
				{
					model.PriceTypeID=int.Parse(row["PriceTypeID"].ToString());
				}
				if(row["PriceTypeName"]!=null)
				{
					model.PriceTypeName=row["PriceTypeName"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["OperMoney"]!=null && row["OperMoney"].ToString()!="")
				{
					model.OperMoney=decimal.Parse(row["OperMoney"].ToString());
				}
				if(row["OperInt"]!=null && row["OperInt"].ToString()!="")
				{
					model.OperInt=int.Parse(row["OperInt"].ToString());
				}
				if(row["OperZS"]!=null && row["OperZS"].ToString()!="")
				{
					model.OperZS=int.Parse(row["OperZS"].ToString());
				}
				if(row["FactMoney"]!=null && row["FactMoney"].ToString()!="")
				{
					model.FactMoney=decimal.Parse(row["FactMoney"].ToString());
				}
				if(row["LastBalance"]!=null && row["LastBalance"].ToString()!="")
				{
					model.LastBalance=decimal.Parse(row["LastBalance"].ToString());
				}
				if(row["CurrentBalance"]!=null && row["CurrentBalance"].ToString()!="")
				{
					model.CurrentBalance=decimal.Parse(row["CurrentBalance"].ToString());
				}
				if(row["TotalMoney"]!=null && row["TotalMoney"].ToString()!="")
				{
					model.TotalMoney=decimal.Parse(row["TotalMoney"].ToString());
				}
				if(row["TotalInt"]!=null && row["TotalInt"].ToString()!="")
				{
					model.TotalInt=int.Parse(row["TotalInt"].ToString());
				}
				if(row["TotalBase"]!=null && row["TotalBase"].ToString()!="")
				{
					model.TotalBase=int.Parse(row["TotalBase"].ToString());
				}
				if(row["OperType"]!=null && row["OperType"].ToString()!="")
				{
					model.OperType=int.Parse(row["OperType"].ToString());
				}
				if(row["PayType"]!=null && row["PayType"].ToString()!="")
				{
					model.PayType=int.Parse(row["PayType"].ToString());
				}
				if(row["InvoiceCode"]!=null)
				{
					model.InvoiceCode=row["InvoiceCode"].ToString();
				}
				if(row["OperDate"]!=null && row["OperDate"].ToString()!="")
				{
					model.OperDate=DateTime.Parse(row["OperDate"].ToString());
				}
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["SiteID"]!=null && row["SiteID"].ToString()!="")
				{
					model.SiteID=int.Parse(row["SiteID"].ToString());
				}
				if(row["FactoryNum"]!=null && row["FactoryNum"].ToString()!="")
				{
					model.FactoryNum=decimal.Parse(row["FactoryNum"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["RedOperId"]!=null && row["RedOperId"].ToString()!="")
				{
					model.RedOperId=int.Parse(row["RedOperId"].ToString());
				}
				if(row["OperNum"]!=null && row["OperNum"].ToString()!="")
				{
					model.OperNum=int.Parse(row["OperNum"].ToString());
				}
				if(row["Price2"]!=null && row["Price2"].ToString()!="")
				{
					model.Price2=decimal.Parse(row["Price2"].ToString());
				}
				if(row["Price3"]!=null && row["Price3"].ToString()!="")
				{
					model.Price3=decimal.Parse(row["Price3"].ToString());
				}
				if(row["Divid1"]!=null && row["Divid1"].ToString()!="")
				{
					model.Divid1=int.Parse(row["Divid1"].ToString());
				}
				if(row["Divid2"]!=null && row["Divid2"].ToString()!="")
				{
					model.Divid2=int.Parse(row["Divid2"].ToString());
				}
				if(row["UseNumber1"]!=null && row["UseNumber1"].ToString()!="")
				{
					model.UseNumber1=decimal.Parse(row["UseNumber1"].ToString());
				}
				if(row["UseNumber2"]!=null && row["UseNumber2"].ToString()!="")
				{
					model.UseNumber2=decimal.Parse(row["UseNumber2"].ToString());
				}
				if(row["UseNumber3"]!=null && row["UseNumber3"].ToString()!="")
				{
					model.UseNumber3=decimal.Parse(row["UseNumber3"].ToString());
				}
				if(row["CurTotalBuyNumber"]!=null && row["CurTotalBuyNumber"].ToString()!="")
				{
					model.CurTotalBuyNumber=decimal.Parse(row["CurTotalBuyNumber"].ToString());
				}
				if(row["InvoiceID"]!=null && row["InvoiceID"].ToString()!="")
				{
					model.InvoiceID=int.Parse(row["InvoiceID"].ToString());
				}
				if(row["InvoiceType"]!=null && row["InvoiceType"].ToString()!="")
				{
					model.InvoiceType=int.Parse(row["InvoiceType"].ToString());
				}
				if(row["WriteCardFlag"]!=null && row["WriteCardFlag"].ToString()!="")
				{
					model.WriteCardFlag=int.Parse(row["WriteCardFlag"].ToString());
				}
				if(row["TransactionId"]!=null)
				{
					model.TransactionId=row["TransactionId"].ToString();
				}
				if(row["PayWay"]!=null && row["PayWay"].ToString()!="")
				{
					model.PayWay=int.Parse(row["PayWay"].ToString());
				}
				if(row["OutTradeNo"]!=null)
				{
					model.OutTradeNo=row["OutTradeNo"].ToString();
				}
				if(row["DepositDate"]!=null && row["DepositDate"].ToString()!="")
				{
					model.DepositDate=DateTime.Parse(row["DepositDate"].ToString());
				}
				if(row["DiscountsNum"]!=null && row["DiscountsNum"].ToString()!="")
				{
					model.DiscountsNum=int.Parse(row["DiscountsNum"].ToString());
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
			strSql.Append("select OperID,CardID,CardSector,PriceTypeID,PriceTypeName,Price,OperMoney,OperInt,OperZS,FactMoney,LastBalance,CurrentBalance,TotalMoney,TotalInt,TotalBase,OperType,PayType,InvoiceCode,OperDate,MeterID,OperatorID,SiteID,FactoryNum,Remark,RedOperId,OperNum,Price2,Price3,Divid1,Divid2,UseNumber1,UseNumber2,UseNumber3,CurTotalBuyNumber,InvoiceID,InvoiceType,WriteCardFlag,TransactionId,PayWay,OutTradeNo,DepositDate,DiscountsNum ");
			strSql.Append(" FROM PreOperation ");
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
			strSql.Append(" OperID,CardID,CardSector,PriceTypeID,PriceTypeName,Price,OperMoney,OperInt,OperZS,FactMoney,LastBalance,CurrentBalance,TotalMoney,TotalInt,TotalBase,OperType,PayType,InvoiceCode,OperDate,MeterID,OperatorID,SiteID,FactoryNum,Remark,RedOperId,OperNum,Price2,Price3,Divid1,Divid2,UseNumber1,UseNumber2,UseNumber3,CurTotalBuyNumber,InvoiceID,InvoiceType,WriteCardFlag,TransactionId,PayWay,OutTradeNo,DepositDate,DiscountsNum ");
			strSql.Append(" FROM PreOperation ");
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
			strSql.Append("select count(1) FROM PreOperation ");
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
			strSql.Append(")AS Row, T.*  from PreOperation T ");
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
			parameters[0].Value = "PreOperation";
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

