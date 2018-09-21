using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MultiOperation
	/// </summary>
	public partial class MultiOperation
	{
		public MultiOperation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("OperID", "MultiOperation"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OperID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MultiOperation");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4)
			};
			parameters[0].Value = OperID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.MultiOperation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MultiOperation(");
			strSql.Append("MultiUserID,CardID,CardSector,OperMoney,LastBalance,CurrentBalance,TotalMoney,OperType,InvoiceCode,OperDate,OperatorID,Remark,InvoiceID,InvoiceType)");
			strSql.Append(" values (");
			strSql.Append("@MultiUserID,@CardID,@CardSector,@OperMoney,@LastBalance,@CurrentBalance,@TotalMoney,@OperType,@InvoiceCode,@OperDate,@OperatorID,@Remark,@InvoiceID,@InvoiceType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MultiUserID", SqlDbType.Int,4),
					new SqlParameter("@CardID", SqlDbType.Int,4),
					new SqlParameter("@CardSector", SqlDbType.Int,4),
					new SqlParameter("@OperMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LastBalance", SqlDbType.Decimal,9),
					new SqlParameter("@CurrentBalance", SqlDbType.Decimal,9),
					new SqlParameter("@TotalMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OperType", SqlDbType.Int,4),
					new SqlParameter("@InvoiceCode", SqlDbType.VarChar,50),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@InvoiceID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceType", SqlDbType.Int,4)};
			parameters[0].Value = model.MultiUserID;
			parameters[1].Value = model.CardID;
			parameters[2].Value = model.CardSector;
			parameters[3].Value = model.OperMoney;
			parameters[4].Value = model.LastBalance;
			parameters[5].Value = model.CurrentBalance;
			parameters[6].Value = model.TotalMoney;
			parameters[7].Value = model.OperType;
			parameters[8].Value = model.InvoiceCode;
			parameters[9].Value = model.OperDate;
			parameters[10].Value = model.OperatorID;
			parameters[11].Value = model.Remark;
			parameters[12].Value = model.InvoiceID;
			parameters[13].Value = model.InvoiceType;

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
		public bool Update(WebDemo.Model.WebDemo.MultiOperation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MultiOperation set ");
			strSql.Append("MultiUserID=@MultiUserID,");
			strSql.Append("CardID=@CardID,");
			strSql.Append("CardSector=@CardSector,");
			strSql.Append("OperMoney=@OperMoney,");
			strSql.Append("LastBalance=@LastBalance,");
			strSql.Append("CurrentBalance=@CurrentBalance,");
			strSql.Append("TotalMoney=@TotalMoney,");
			strSql.Append("OperType=@OperType,");
			strSql.Append("InvoiceCode=@InvoiceCode,");
			strSql.Append("OperDate=@OperDate,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("InvoiceID=@InvoiceID,");
			strSql.Append("InvoiceType=@InvoiceType");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@MultiUserID", SqlDbType.Int,4),
					new SqlParameter("@CardID", SqlDbType.Int,4),
					new SqlParameter("@CardSector", SqlDbType.Int,4),
					new SqlParameter("@OperMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LastBalance", SqlDbType.Decimal,9),
					new SqlParameter("@CurrentBalance", SqlDbType.Decimal,9),
					new SqlParameter("@TotalMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OperType", SqlDbType.Int,4),
					new SqlParameter("@InvoiceCode", SqlDbType.VarChar,50),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@InvoiceID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceType", SqlDbType.Int,4),
					new SqlParameter("@OperID", SqlDbType.Int,4)};
			parameters[0].Value = model.MultiUserID;
			parameters[1].Value = model.CardID;
			parameters[2].Value = model.CardSector;
			parameters[3].Value = model.OperMoney;
			parameters[4].Value = model.LastBalance;
			parameters[5].Value = model.CurrentBalance;
			parameters[6].Value = model.TotalMoney;
			parameters[7].Value = model.OperType;
			parameters[8].Value = model.InvoiceCode;
			parameters[9].Value = model.OperDate;
			parameters[10].Value = model.OperatorID;
			parameters[11].Value = model.Remark;
			parameters[12].Value = model.InvoiceID;
			parameters[13].Value = model.InvoiceType;
			parameters[14].Value = model.OperID;

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
			strSql.Append("delete from MultiOperation ");
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
			strSql.Append("delete from MultiOperation ");
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
		public WebDemo.Model.WebDemo.MultiOperation GetModel(int OperID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OperID,MultiUserID,CardID,CardSector,OperMoney,LastBalance,CurrentBalance,TotalMoney,OperType,InvoiceCode,OperDate,OperatorID,Remark,InvoiceID,InvoiceType from MultiOperation ");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4)
			};
			parameters[0].Value = OperID;

			WebDemo.Model.WebDemo.MultiOperation model=new WebDemo.Model.WebDemo.MultiOperation();
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
		public WebDemo.Model.WebDemo.MultiOperation DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MultiOperation model=new WebDemo.Model.WebDemo.MultiOperation();
			if (row != null)
			{
				if(row["OperID"]!=null && row["OperID"].ToString()!="")
				{
					model.OperID=int.Parse(row["OperID"].ToString());
				}
				if(row["MultiUserID"]!=null && row["MultiUserID"].ToString()!="")
				{
					model.MultiUserID=int.Parse(row["MultiUserID"].ToString());
				}
				if(row["CardID"]!=null && row["CardID"].ToString()!="")
				{
					model.CardID=int.Parse(row["CardID"].ToString());
				}
				if(row["CardSector"]!=null && row["CardSector"].ToString()!="")
				{
					model.CardSector=int.Parse(row["CardSector"].ToString());
				}
				if(row["OperMoney"]!=null && row["OperMoney"].ToString()!="")
				{
					model.OperMoney=decimal.Parse(row["OperMoney"].ToString());
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
				if(row["OperType"]!=null && row["OperType"].ToString()!="")
				{
					model.OperType=int.Parse(row["OperType"].ToString());
				}
				if(row["InvoiceCode"]!=null)
				{
					model.InvoiceCode=row["InvoiceCode"].ToString();
				}
				if(row["OperDate"]!=null && row["OperDate"].ToString()!="")
				{
					model.OperDate=DateTime.Parse(row["OperDate"].ToString());
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["InvoiceID"]!=null && row["InvoiceID"].ToString()!="")
				{
					model.InvoiceID=int.Parse(row["InvoiceID"].ToString());
				}
				if(row["InvoiceType"]!=null && row["InvoiceType"].ToString()!="")
				{
					model.InvoiceType=int.Parse(row["InvoiceType"].ToString());
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
			strSql.Append("select OperID,MultiUserID,CardID,CardSector,OperMoney,LastBalance,CurrentBalance,TotalMoney,OperType,InvoiceCode,OperDate,OperatorID,Remark,InvoiceID,InvoiceType ");
			strSql.Append(" FROM MultiOperation ");
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
			strSql.Append(" OperID,MultiUserID,CardID,CardSector,OperMoney,LastBalance,CurrentBalance,TotalMoney,OperType,InvoiceCode,OperDate,OperatorID,Remark,InvoiceID,InvoiceType ");
			strSql.Append(" FROM MultiOperation ");
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
			strSql.Append("select count(1) FROM MultiOperation ");
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
			strSql.Append(")AS Row, T.*  from MultiOperation T ");
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
			parameters[0].Value = "MultiOperation";
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

