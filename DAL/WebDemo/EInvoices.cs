using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:EInvoices
	/// </summary>
	public partial class EInvoices
	{
		public EInvoices()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "EInvoices"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EInvoices");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.EInvoices model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EInvoices(");
			strSql.Append("OperID,OperType,InvoiceNumber,OrderNo,MeterID,OperMoney,FactMoney,InvoiceState,OperDate,URL,CreateDate,OperatorID,InvoiceCode,RtnInvoiceNumber,ManualRegist,RedSaleURL,RSInvoiceNumber,RegistDate)");
			strSql.Append(" values (");
			strSql.Append("@OperID,@OperType,@InvoiceNumber,@OrderNo,@MeterID,@OperMoney,@FactMoney,@InvoiceState,@OperDate,@URL,@CreateDate,@OperatorID,@InvoiceCode,@RtnInvoiceNumber,@ManualRegist,@RedSaleURL,@RSInvoiceNumber,@RegistDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@OperType", SqlDbType.Int,4),
					new SqlParameter("@InvoiceNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.NVarChar,20),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@OperMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FactMoney", SqlDbType.Decimal,9),
					new SqlParameter("@InvoiceState", SqlDbType.Int,4),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@URL", SqlDbType.NVarChar,100),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceCode", SqlDbType.VarChar,12),
					new SqlParameter("@RtnInvoiceNumber", SqlDbType.VarChar,12),
					new SqlParameter("@ManualRegist", SqlDbType.Int,4),
					new SqlParameter("@RedSaleURL", SqlDbType.NVarChar,100),
					new SqlParameter("@RSInvoiceNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@RegistDate", SqlDbType.DateTime)};
			parameters[0].Value = model.OperID;
			parameters[1].Value = model.OperType;
			parameters[2].Value = model.InvoiceNumber;
			parameters[3].Value = model.OrderNo;
			parameters[4].Value = model.MeterID;
			parameters[5].Value = model.OperMoney;
			parameters[6].Value = model.FactMoney;
			parameters[7].Value = model.InvoiceState;
			parameters[8].Value = model.OperDate;
			parameters[9].Value = model.URL;
			parameters[10].Value = model.CreateDate;
			parameters[11].Value = model.OperatorID;
			parameters[12].Value = model.InvoiceCode;
			parameters[13].Value = model.RtnInvoiceNumber;
			parameters[14].Value = model.ManualRegist;
			parameters[15].Value = model.RedSaleURL;
			parameters[16].Value = model.RSInvoiceNumber;
			parameters[17].Value = model.RegistDate;

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
		public bool Update(WebDemo.Model.WebDemo.EInvoices model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EInvoices set ");
			strSql.Append("OperID=@OperID,");
			strSql.Append("OperType=@OperType,");
			strSql.Append("InvoiceNumber=@InvoiceNumber,");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("MeterID=@MeterID,");
			strSql.Append("OperMoney=@OperMoney,");
			strSql.Append("FactMoney=@FactMoney,");
			strSql.Append("InvoiceState=@InvoiceState,");
			strSql.Append("OperDate=@OperDate,");
			strSql.Append("URL=@URL,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("InvoiceCode=@InvoiceCode,");
			strSql.Append("RtnInvoiceNumber=@RtnInvoiceNumber,");
			strSql.Append("ManualRegist=@ManualRegist,");
			strSql.Append("RedSaleURL=@RedSaleURL,");
			strSql.Append("RSInvoiceNumber=@RSInvoiceNumber,");
			strSql.Append("RegistDate=@RegistDate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@OperType", SqlDbType.Int,4),
					new SqlParameter("@InvoiceNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@OrderNo", SqlDbType.NVarChar,20),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@OperMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FactMoney", SqlDbType.Decimal,9),
					new SqlParameter("@InvoiceState", SqlDbType.Int,4),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@URL", SqlDbType.NVarChar,100),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceCode", SqlDbType.VarChar,12),
					new SqlParameter("@RtnInvoiceNumber", SqlDbType.VarChar,12),
					new SqlParameter("@ManualRegist", SqlDbType.Int,4),
					new SqlParameter("@RedSaleURL", SqlDbType.NVarChar,100),
					new SqlParameter("@RSInvoiceNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@RegistDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.OperID;
			parameters[1].Value = model.OperType;
			parameters[2].Value = model.InvoiceNumber;
			parameters[3].Value = model.OrderNo;
			parameters[4].Value = model.MeterID;
			parameters[5].Value = model.OperMoney;
			parameters[6].Value = model.FactMoney;
			parameters[7].Value = model.InvoiceState;
			parameters[8].Value = model.OperDate;
			parameters[9].Value = model.URL;
			parameters[10].Value = model.CreateDate;
			parameters[11].Value = model.OperatorID;
			parameters[12].Value = model.InvoiceCode;
			parameters[13].Value = model.RtnInvoiceNumber;
			parameters[14].Value = model.ManualRegist;
			parameters[15].Value = model.RedSaleURL;
			parameters[16].Value = model.RSInvoiceNumber;
			parameters[17].Value = model.RegistDate;
			parameters[18].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EInvoices ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from EInvoices ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public WebDemo.Model.WebDemo.EInvoices GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,OperID,OperType,InvoiceNumber,OrderNo,MeterID,OperMoney,FactMoney,InvoiceState,OperDate,URL,CreateDate,OperatorID,InvoiceCode,RtnInvoiceNumber,ManualRegist,RedSaleURL,RSInvoiceNumber,RegistDate from EInvoices ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.EInvoices model=new WebDemo.Model.WebDemo.EInvoices();
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
		public WebDemo.Model.WebDemo.EInvoices DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.EInvoices model=new WebDemo.Model.WebDemo.EInvoices();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["OperID"]!=null && row["OperID"].ToString()!="")
				{
					model.OperID=int.Parse(row["OperID"].ToString());
				}
				if(row["OperType"]!=null && row["OperType"].ToString()!="")
				{
					model.OperType=int.Parse(row["OperType"].ToString());
				}
				if(row["InvoiceNumber"]!=null)
				{
					model.InvoiceNumber=row["InvoiceNumber"].ToString();
				}
				if(row["OrderNo"]!=null)
				{
					model.OrderNo=row["OrderNo"].ToString();
				}
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["OperMoney"]!=null && row["OperMoney"].ToString()!="")
				{
					model.OperMoney=decimal.Parse(row["OperMoney"].ToString());
				}
				if(row["FactMoney"]!=null && row["FactMoney"].ToString()!="")
				{
					model.FactMoney=decimal.Parse(row["FactMoney"].ToString());
				}
				if(row["InvoiceState"]!=null && row["InvoiceState"].ToString()!="")
				{
					model.InvoiceState=int.Parse(row["InvoiceState"].ToString());
				}
				if(row["OperDate"]!=null && row["OperDate"].ToString()!="")
				{
					model.OperDate=DateTime.Parse(row["OperDate"].ToString());
				}
				if(row["URL"]!=null)
				{
					model.URL=row["URL"].ToString();
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["InvoiceCode"]!=null)
				{
					model.InvoiceCode=row["InvoiceCode"].ToString();
				}
				if(row["RtnInvoiceNumber"]!=null)
				{
					model.RtnInvoiceNumber=row["RtnInvoiceNumber"].ToString();
				}
				if(row["ManualRegist"]!=null && row["ManualRegist"].ToString()!="")
				{
					model.ManualRegist=int.Parse(row["ManualRegist"].ToString());
				}
				if(row["RedSaleURL"]!=null)
				{
					model.RedSaleURL=row["RedSaleURL"].ToString();
				}
				if(row["RSInvoiceNumber"]!=null)
				{
					model.RSInvoiceNumber=row["RSInvoiceNumber"].ToString();
				}
				if(row["RegistDate"]!=null && row["RegistDate"].ToString()!="")
				{
					model.RegistDate=DateTime.Parse(row["RegistDate"].ToString());
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
			strSql.Append("select ID,OperID,OperType,InvoiceNumber,OrderNo,MeterID,OperMoney,FactMoney,InvoiceState,OperDate,URL,CreateDate,OperatorID,InvoiceCode,RtnInvoiceNumber,ManualRegist,RedSaleURL,RSInvoiceNumber,RegistDate ");
			strSql.Append(" FROM EInvoices ");
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
			strSql.Append(" ID,OperID,OperType,InvoiceNumber,OrderNo,MeterID,OperMoney,FactMoney,InvoiceState,OperDate,URL,CreateDate,OperatorID,InvoiceCode,RtnInvoiceNumber,ManualRegist,RedSaleURL,RSInvoiceNumber,RegistDate ");
			strSql.Append(" FROM EInvoices ");
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
			strSql.Append("select count(1) FROM EInvoices ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from EInvoices T ");
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
			parameters[0].Value = "EInvoices";
			parameters[1].Value = "ID";
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

