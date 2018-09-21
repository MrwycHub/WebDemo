using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:InvoiceHand
	/// </summary>
	public partial class InvoiceHand
	{
		public InvoiceHand()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("OperID", "InvoiceHand"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OperID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InvoiceHand");
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
		public int Add(WebDemo.Model.WebDemo.InvoiceHand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InvoiceHand(");
			strSql.Append("spName,spUnit,spNum,spPrice,spMoney,Remark,InID)");
			strSql.Append(" values (");
			strSql.Append("@spName,@spUnit,@spNum,@spPrice,@spMoney,@Remark,@InID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@spName", SqlDbType.VarChar,60),
					new SqlParameter("@spUnit", SqlDbType.VarChar,20),
					new SqlParameter("@spNum", SqlDbType.Decimal,9),
					new SqlParameter("@spPrice", SqlDbType.Decimal,9),
					new SqlParameter("@spMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@InID", SqlDbType.Int,4)};
			parameters[0].Value = model.spName;
			parameters[1].Value = model.spUnit;
			parameters[2].Value = model.spNum;
			parameters[3].Value = model.spPrice;
			parameters[4].Value = model.spMoney;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.InID;

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
		public bool Update(WebDemo.Model.WebDemo.InvoiceHand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InvoiceHand set ");
			strSql.Append("spName=@spName,");
			strSql.Append("spUnit=@spUnit,");
			strSql.Append("spNum=@spNum,");
			strSql.Append("spPrice=@spPrice,");
			strSql.Append("spMoney=@spMoney,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("InID=@InID");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@spName", SqlDbType.VarChar,60),
					new SqlParameter("@spUnit", SqlDbType.VarChar,20),
					new SqlParameter("@spNum", SqlDbType.Decimal,9),
					new SqlParameter("@spPrice", SqlDbType.Decimal,9),
					new SqlParameter("@spMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@InID", SqlDbType.Int,4),
					new SqlParameter("@OperID", SqlDbType.Int,4)};
			parameters[0].Value = model.spName;
			parameters[1].Value = model.spUnit;
			parameters[2].Value = model.spNum;
			parameters[3].Value = model.spPrice;
			parameters[4].Value = model.spMoney;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.InID;
			parameters[7].Value = model.OperID;

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
			strSql.Append("delete from InvoiceHand ");
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
			strSql.Append("delete from InvoiceHand ");
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
		public WebDemo.Model.WebDemo.InvoiceHand GetModel(int OperID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OperID,spName,spUnit,spNum,spPrice,spMoney,Remark,InID from InvoiceHand ");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4)
			};
			parameters[0].Value = OperID;

			WebDemo.Model.WebDemo.InvoiceHand model=new WebDemo.Model.WebDemo.InvoiceHand();
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
		public WebDemo.Model.WebDemo.InvoiceHand DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.InvoiceHand model=new WebDemo.Model.WebDemo.InvoiceHand();
			if (row != null)
			{
				if(row["OperID"]!=null && row["OperID"].ToString()!="")
				{
					model.OperID=int.Parse(row["OperID"].ToString());
				}
				if(row["spName"]!=null)
				{
					model.spName=row["spName"].ToString();
				}
				if(row["spUnit"]!=null)
				{
					model.spUnit=row["spUnit"].ToString();
				}
				if(row["spNum"]!=null && row["spNum"].ToString()!="")
				{
					model.spNum=decimal.Parse(row["spNum"].ToString());
				}
				if(row["spPrice"]!=null && row["spPrice"].ToString()!="")
				{
					model.spPrice=decimal.Parse(row["spPrice"].ToString());
				}
				if(row["spMoney"]!=null && row["spMoney"].ToString()!="")
				{
					model.spMoney=decimal.Parse(row["spMoney"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["InID"]!=null && row["InID"].ToString()!="")
				{
					model.InID=int.Parse(row["InID"].ToString());
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
			strSql.Append("select OperID,spName,spUnit,spNum,spPrice,spMoney,Remark,InID ");
			strSql.Append(" FROM InvoiceHand ");
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
			strSql.Append(" OperID,spName,spUnit,spNum,spPrice,spMoney,Remark,InID ");
			strSql.Append(" FROM InvoiceHand ");
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
			strSql.Append("select count(1) FROM InvoiceHand ");
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
			strSql.Append(")AS Row, T.*  from InvoiceHand T ");
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
			parameters[0].Value = "InvoiceHand";
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

