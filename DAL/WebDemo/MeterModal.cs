using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MeterModal
	/// </summary>
	public partial class MeterModal
	{
		public MeterModal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Modalid", "MeterModal"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Modalid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MeterModal");
			strSql.Append(" where Modalid=@Modalid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Modalid", SqlDbType.Int,4)			};
			parameters[0].Value = Modalid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.MeterModal model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MeterModal(");
			strSql.Append("Modalid,Modalname,Remark,UseProtocol,FactoryCode,FactoryName,MaxValue,MaxYear,Caliber,MaxFlow,MeterHeaderType,MeterStatusCode)");
			strSql.Append(" values (");
			strSql.Append("@Modalid,@Modalname,@Remark,@UseProtocol,@FactoryCode,@FactoryName,@MaxValue,@MaxYear,@Caliber,@MaxFlow,@MeterHeaderType,@MeterStatusCode)");
			SqlParameter[] parameters = {
					new SqlParameter("@Modalid", SqlDbType.Int,4),
					new SqlParameter("@Modalname", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@UseProtocol", SqlDbType.Int,4),
					new SqlParameter("@FactoryCode", SqlDbType.VarChar,50),
					new SqlParameter("@FactoryName", SqlDbType.VarChar,50),
					new SqlParameter("@MaxValue", SqlDbType.Int,4),
					new SqlParameter("@MaxYear", SqlDbType.Int,4),
					new SqlParameter("@Caliber", SqlDbType.VarChar,50),
					new SqlParameter("@MaxFlow", SqlDbType.Decimal,9),
					new SqlParameter("@MeterHeaderType", SqlDbType.Int,4),
					new SqlParameter("@MeterStatusCode", SqlDbType.VarChar,4)};
			parameters[0].Value = model.Modalid;
			parameters[1].Value = model.Modalname;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.UseProtocol;
			parameters[4].Value = model.FactoryCode;
			parameters[5].Value = model.FactoryName;
			parameters[6].Value = model.MaxValue;
			parameters[7].Value = model.MaxYear;
			parameters[8].Value = model.Caliber;
			parameters[9].Value = model.MaxFlow;
			parameters[10].Value = model.MeterHeaderType;
			parameters[11].Value = model.MeterStatusCode;

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
		public bool Update(WebDemo.Model.WebDemo.MeterModal model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MeterModal set ");
			strSql.Append("Modalname=@Modalname,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("UseProtocol=@UseProtocol,");
			strSql.Append("FactoryCode=@FactoryCode,");
			strSql.Append("FactoryName=@FactoryName,");
			strSql.Append("MaxValue=@MaxValue,");
			strSql.Append("MaxYear=@MaxYear,");
			strSql.Append("Caliber=@Caliber,");
			strSql.Append("MaxFlow=@MaxFlow,");
			strSql.Append("MeterHeaderType=@MeterHeaderType,");
			strSql.Append("MeterStatusCode=@MeterStatusCode");
			strSql.Append(" where Modalid=@Modalid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Modalname", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@UseProtocol", SqlDbType.Int,4),
					new SqlParameter("@FactoryCode", SqlDbType.VarChar,50),
					new SqlParameter("@FactoryName", SqlDbType.VarChar,50),
					new SqlParameter("@MaxValue", SqlDbType.Int,4),
					new SqlParameter("@MaxYear", SqlDbType.Int,4),
					new SqlParameter("@Caliber", SqlDbType.VarChar,50),
					new SqlParameter("@MaxFlow", SqlDbType.Decimal,9),
					new SqlParameter("@MeterHeaderType", SqlDbType.Int,4),
					new SqlParameter("@MeterStatusCode", SqlDbType.VarChar,4),
					new SqlParameter("@Modalid", SqlDbType.Int,4)};
			parameters[0].Value = model.Modalname;
			parameters[1].Value = model.Remark;
			parameters[2].Value = model.UseProtocol;
			parameters[3].Value = model.FactoryCode;
			parameters[4].Value = model.FactoryName;
			parameters[5].Value = model.MaxValue;
			parameters[6].Value = model.MaxYear;
			parameters[7].Value = model.Caliber;
			parameters[8].Value = model.MaxFlow;
			parameters[9].Value = model.MeterHeaderType;
			parameters[10].Value = model.MeterStatusCode;
			parameters[11].Value = model.Modalid;

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
		public bool Delete(int Modalid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeterModal ");
			strSql.Append(" where Modalid=@Modalid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Modalid", SqlDbType.Int,4)			};
			parameters[0].Value = Modalid;

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
		public bool DeleteList(string Modalidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeterModal ");
			strSql.Append(" where Modalid in ("+Modalidlist + ")  ");
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
		public WebDemo.Model.WebDemo.MeterModal GetModel(int Modalid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Modalid,Modalname,Remark,UseProtocol,FactoryCode,FactoryName,MaxValue,MaxYear,Caliber,MaxFlow,MeterHeaderType,MeterStatusCode from MeterModal ");
			strSql.Append(" where Modalid=@Modalid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Modalid", SqlDbType.Int,4)			};
			parameters[0].Value = Modalid;

			WebDemo.Model.WebDemo.MeterModal model=new WebDemo.Model.WebDemo.MeterModal();
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
		public WebDemo.Model.WebDemo.MeterModal DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MeterModal model=new WebDemo.Model.WebDemo.MeterModal();
			if (row != null)
			{
				if(row["Modalid"]!=null && row["Modalid"].ToString()!="")
				{
					model.Modalid=int.Parse(row["Modalid"].ToString());
				}
				if(row["Modalname"]!=null)
				{
					model.Modalname=row["Modalname"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["UseProtocol"]!=null && row["UseProtocol"].ToString()!="")
				{
					model.UseProtocol=int.Parse(row["UseProtocol"].ToString());
				}
				if(row["FactoryCode"]!=null)
				{
					model.FactoryCode=row["FactoryCode"].ToString();
				}
				if(row["FactoryName"]!=null)
				{
					model.FactoryName=row["FactoryName"].ToString();
				}
				if(row["MaxValue"]!=null && row["MaxValue"].ToString()!="")
				{
					model.MaxValue=int.Parse(row["MaxValue"].ToString());
				}
				if(row["MaxYear"]!=null && row["MaxYear"].ToString()!="")
				{
					model.MaxYear=int.Parse(row["MaxYear"].ToString());
				}
				if(row["Caliber"]!=null)
				{
					model.Caliber=row["Caliber"].ToString();
				}
				if(row["MaxFlow"]!=null && row["MaxFlow"].ToString()!="")
				{
					model.MaxFlow=decimal.Parse(row["MaxFlow"].ToString());
				}
				if(row["MeterHeaderType"]!=null && row["MeterHeaderType"].ToString()!="")
				{
					model.MeterHeaderType=int.Parse(row["MeterHeaderType"].ToString());
				}
				if(row["MeterStatusCode"]!=null)
				{
					model.MeterStatusCode=row["MeterStatusCode"].ToString();
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
			strSql.Append("select Modalid,Modalname,Remark,UseProtocol,FactoryCode,FactoryName,MaxValue,MaxYear,Caliber,MaxFlow,MeterHeaderType,MeterStatusCode ");
			strSql.Append(" FROM MeterModal ");
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
			strSql.Append(" Modalid,Modalname,Remark,UseProtocol,FactoryCode,FactoryName,MaxValue,MaxYear,Caliber,MaxFlow,MeterHeaderType,MeterStatusCode ");
			strSql.Append(" FROM MeterModal ");
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
			strSql.Append("select count(1) FROM MeterModal ");
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
				strSql.Append("order by T.Modalid desc");
			}
			strSql.Append(")AS Row, T.*  from MeterModal T ");
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
			parameters[0].Value = "MeterModal";
			parameters[1].Value = "Modalid";
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

