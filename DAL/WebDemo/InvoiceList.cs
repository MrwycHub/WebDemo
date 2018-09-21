using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:InvoiceList
	/// </summary>
	public partial class InvoiceList
	{
		public InvoiceList()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("InID", "InvoiceList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int InID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InvoiceList");
			strSql.Append(" where InID=@InID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InID", SqlDbType.Int,4)			};
			parameters[0].Value = InID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.InvoiceList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InvoiceList(");
			strSql.Append("InID,InCode,InNumber,SiteID,OperatorName,GetDate,PayID,PrintDate,InMoney,InMark,SendMark,SendDate,printMan,zfDate,zfInCode,zfInNumber,UName)");
			strSql.Append(" values (");
			strSql.Append("@InID,@InCode,@InNumber,@SiteID,@OperatorName,@GetDate,@PayID,@PrintDate,@InMoney,@InMark,@SendMark,@SendDate,@printMan,@zfDate,@zfInCode,@zfInNumber,@UName)");
			SqlParameter[] parameters = {
					new SqlParameter("@InID", SqlDbType.Int,4),
					new SqlParameter("@InCode", SqlDbType.VarChar,20),
					new SqlParameter("@InNumber", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@GetDate", SqlDbType.DateTime),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PrintDate", SqlDbType.DateTime),
					new SqlParameter("@InMoney", SqlDbType.Decimal,9),
					new SqlParameter("@InMark", SqlDbType.Int,4),
					new SqlParameter("@SendMark", SqlDbType.Int,4),
					new SqlParameter("@SendDate", SqlDbType.DateTime),
					new SqlParameter("@printMan", SqlDbType.VarChar,50),
					new SqlParameter("@zfDate", SqlDbType.DateTime),
					new SqlParameter("@zfInCode", SqlDbType.VarChar,20),
					new SqlParameter("@zfInNumber", SqlDbType.VarChar,20),
					new SqlParameter("@UName", SqlDbType.VarChar,60)};
			parameters[0].Value = model.InID;
			parameters[1].Value = model.InCode;
			parameters[2].Value = model.InNumber;
			parameters[3].Value = model.SiteID;
			parameters[4].Value = model.OperatorName;
			parameters[5].Value = model.GetDate;
			parameters[6].Value = model.PayID;
			parameters[7].Value = model.PrintDate;
			parameters[8].Value = model.InMoney;
			parameters[9].Value = model.InMark;
			parameters[10].Value = model.SendMark;
			parameters[11].Value = model.SendDate;
			parameters[12].Value = model.printMan;
			parameters[13].Value = model.zfDate;
			parameters[14].Value = model.zfInCode;
			parameters[15].Value = model.zfInNumber;
			parameters[16].Value = model.UName;

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
		public bool Update(WebDemo.Model.WebDemo.InvoiceList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InvoiceList set ");
			strSql.Append("InCode=@InCode,");
			strSql.Append("InNumber=@InNumber,");
			strSql.Append("SiteID=@SiteID,");
			strSql.Append("OperatorName=@OperatorName,");
			strSql.Append("GetDate=@GetDate,");
			strSql.Append("PayID=@PayID,");
			strSql.Append("PrintDate=@PrintDate,");
			strSql.Append("InMoney=@InMoney,");
			strSql.Append("InMark=@InMark,");
			strSql.Append("SendMark=@SendMark,");
			strSql.Append("SendDate=@SendDate,");
			strSql.Append("printMan=@printMan,");
			strSql.Append("zfDate=@zfDate,");
			strSql.Append("zfInCode=@zfInCode,");
			strSql.Append("zfInNumber=@zfInNumber,");
			strSql.Append("UName=@UName");
			strSql.Append(" where InID=@InID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InCode", SqlDbType.VarChar,20),
					new SqlParameter("@InNumber", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@GetDate", SqlDbType.DateTime),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@PrintDate", SqlDbType.DateTime),
					new SqlParameter("@InMoney", SqlDbType.Decimal,9),
					new SqlParameter("@InMark", SqlDbType.Int,4),
					new SqlParameter("@SendMark", SqlDbType.Int,4),
					new SqlParameter("@SendDate", SqlDbType.DateTime),
					new SqlParameter("@printMan", SqlDbType.VarChar,50),
					new SqlParameter("@zfDate", SqlDbType.DateTime),
					new SqlParameter("@zfInCode", SqlDbType.VarChar,20),
					new SqlParameter("@zfInNumber", SqlDbType.VarChar,20),
					new SqlParameter("@UName", SqlDbType.VarChar,60),
					new SqlParameter("@InID", SqlDbType.Int,4)};
			parameters[0].Value = model.InCode;
			parameters[1].Value = model.InNumber;
			parameters[2].Value = model.SiteID;
			parameters[3].Value = model.OperatorName;
			parameters[4].Value = model.GetDate;
			parameters[5].Value = model.PayID;
			parameters[6].Value = model.PrintDate;
			parameters[7].Value = model.InMoney;
			parameters[8].Value = model.InMark;
			parameters[9].Value = model.SendMark;
			parameters[10].Value = model.SendDate;
			parameters[11].Value = model.printMan;
			parameters[12].Value = model.zfDate;
			parameters[13].Value = model.zfInCode;
			parameters[14].Value = model.zfInNumber;
			parameters[15].Value = model.UName;
			parameters[16].Value = model.InID;

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
			strSql.Append("delete from InvoiceList ");
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
			strSql.Append("delete from InvoiceList ");
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
		public WebDemo.Model.WebDemo.InvoiceList GetModel(int InID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 InID,InCode,InNumber,SiteID,OperatorName,GetDate,PayID,PrintDate,InMoney,InMark,SendMark,SendDate,printMan,zfDate,zfInCode,zfInNumber,UName from InvoiceList ");
			strSql.Append(" where InID=@InID ");
			SqlParameter[] parameters = {
					new SqlParameter("@InID", SqlDbType.Int,4)			};
			parameters[0].Value = InID;

			WebDemo.Model.WebDemo.InvoiceList model=new WebDemo.Model.WebDemo.InvoiceList();
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
		public WebDemo.Model.WebDemo.InvoiceList DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.InvoiceList model=new WebDemo.Model.WebDemo.InvoiceList();
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
				if(row["InNumber"]!=null && row["InNumber"].ToString()!="")
				{
					model.InNumber=int.Parse(row["InNumber"].ToString());
				}
				if(row["SiteID"]!=null && row["SiteID"].ToString()!="")
				{
					model.SiteID=int.Parse(row["SiteID"].ToString());
				}
				if(row["OperatorName"]!=null)
				{
					model.OperatorName=row["OperatorName"].ToString();
				}
				if(row["GetDate"]!=null && row["GetDate"].ToString()!="")
				{
					model.GetDate=DateTime.Parse(row["GetDate"].ToString());
				}
				if(row["PayID"]!=null && row["PayID"].ToString()!="")
				{
					model.PayID=int.Parse(row["PayID"].ToString());
				}
				if(row["PrintDate"]!=null && row["PrintDate"].ToString()!="")
				{
					model.PrintDate=DateTime.Parse(row["PrintDate"].ToString());
				}
				if(row["InMoney"]!=null && row["InMoney"].ToString()!="")
				{
					model.InMoney=decimal.Parse(row["InMoney"].ToString());
				}
				if(row["InMark"]!=null && row["InMark"].ToString()!="")
				{
					model.InMark=int.Parse(row["InMark"].ToString());
				}
				if(row["SendMark"]!=null && row["SendMark"].ToString()!="")
				{
					model.SendMark=int.Parse(row["SendMark"].ToString());
				}
				if(row["SendDate"]!=null && row["SendDate"].ToString()!="")
				{
					model.SendDate=DateTime.Parse(row["SendDate"].ToString());
				}
				if(row["printMan"]!=null)
				{
					model.printMan=row["printMan"].ToString();
				}
				if(row["zfDate"]!=null && row["zfDate"].ToString()!="")
				{
					model.zfDate=DateTime.Parse(row["zfDate"].ToString());
				}
				if(row["zfInCode"]!=null)
				{
					model.zfInCode=row["zfInCode"].ToString();
				}
				if(row["zfInNumber"]!=null)
				{
					model.zfInNumber=row["zfInNumber"].ToString();
				}
				if(row["UName"]!=null)
				{
					model.UName=row["UName"].ToString();
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
			strSql.Append("select InID,InCode,InNumber,SiteID,OperatorName,GetDate,PayID,PrintDate,InMoney,InMark,SendMark,SendDate,printMan,zfDate,zfInCode,zfInNumber,UName ");
			strSql.Append(" FROM InvoiceList ");
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
			strSql.Append(" InID,InCode,InNumber,SiteID,OperatorName,GetDate,PayID,PrintDate,InMoney,InMark,SendMark,SendDate,printMan,zfDate,zfInCode,zfInNumber,UName ");
			strSql.Append(" FROM InvoiceList ");
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
			strSql.Append("select count(1) FROM InvoiceList ");
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
			strSql.Append(")AS Row, T.*  from InvoiceList T ");
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
			parameters[0].Value = "InvoiceList";
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

