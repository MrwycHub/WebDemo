using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:FreezeDayDosage
	/// </summary>
	public partial class FreezeDayDosage
	{
		public FreezeDayDosage()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "FreezeDayDosage"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FreezeDayDosage");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.FreezeDayDosage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FreezeDayDosage(");
			strSql.Append("MeterID,FreezeDate,UseNumber,DosageType,InsertDate,BeginDate,BeginNumber,EndNumber)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@FreezeDate,@UseNumber,@DosageType,@InsertDate,@BeginDate,@BeginNumber,@EndNumber)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FreezeDate", SqlDbType.VarChar,10),
					new SqlParameter("@UseNumber", SqlDbType.Decimal,9),
					new SqlParameter("@DosageType", SqlDbType.Int,4),
					new SqlParameter("@InsertDate", SqlDbType.DateTime),
					new SqlParameter("@BeginDate", SqlDbType.VarChar,10),
					new SqlParameter("@BeginNumber", SqlDbType.Decimal,9),
					new SqlParameter("@EndNumber", SqlDbType.Decimal,9)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.FreezeDate;
			parameters[2].Value = model.UseNumber;
			parameters[3].Value = model.DosageType;
			parameters[4].Value = model.InsertDate;
			parameters[5].Value = model.BeginDate;
			parameters[6].Value = model.BeginNumber;
			parameters[7].Value = model.EndNumber;

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
		public bool Update(WebDemo.Model.WebDemo.FreezeDayDosage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FreezeDayDosage set ");
			strSql.Append("MeterID=@MeterID,");
			strSql.Append("FreezeDate=@FreezeDate,");
			strSql.Append("UseNumber=@UseNumber,");
			strSql.Append("DosageType=@DosageType,");
			strSql.Append("InsertDate=@InsertDate,");
			strSql.Append("BeginDate=@BeginDate,");
			strSql.Append("BeginNumber=@BeginNumber,");
			strSql.Append("EndNumber=@EndNumber");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FreezeDate", SqlDbType.VarChar,10),
					new SqlParameter("@UseNumber", SqlDbType.Decimal,9),
					new SqlParameter("@DosageType", SqlDbType.Int,4),
					new SqlParameter("@InsertDate", SqlDbType.DateTime),
					new SqlParameter("@BeginDate", SqlDbType.VarChar,10),
					new SqlParameter("@BeginNumber", SqlDbType.Decimal,9),
					new SqlParameter("@EndNumber", SqlDbType.Decimal,9),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.FreezeDate;
			parameters[2].Value = model.UseNumber;
			parameters[3].Value = model.DosageType;
			parameters[4].Value = model.InsertDate;
			parameters[5].Value = model.BeginDate;
			parameters[6].Value = model.BeginNumber;
			parameters[7].Value = model.EndNumber;
			parameters[8].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FreezeDayDosage ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FreezeDayDosage ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public WebDemo.Model.WebDemo.FreezeDayDosage GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,MeterID,FreezeDate,UseNumber,DosageType,InsertDate,BeginDate,BeginNumber,EndNumber from FreezeDayDosage ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			WebDemo.Model.WebDemo.FreezeDayDosage model=new WebDemo.Model.WebDemo.FreezeDayDosage();
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
		public WebDemo.Model.WebDemo.FreezeDayDosage DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.FreezeDayDosage model=new WebDemo.Model.WebDemo.FreezeDayDosage();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["FreezeDate"]!=null)
				{
					model.FreezeDate=row["FreezeDate"].ToString();
				}
				if(row["UseNumber"]!=null && row["UseNumber"].ToString()!="")
				{
					model.UseNumber=decimal.Parse(row["UseNumber"].ToString());
				}
				if(row["DosageType"]!=null && row["DosageType"].ToString()!="")
				{
					model.DosageType=int.Parse(row["DosageType"].ToString());
				}
				if(row["InsertDate"]!=null && row["InsertDate"].ToString()!="")
				{
					model.InsertDate=DateTime.Parse(row["InsertDate"].ToString());
				}
				if(row["BeginDate"]!=null)
				{
					model.BeginDate=row["BeginDate"].ToString();
				}
				if(row["BeginNumber"]!=null && row["BeginNumber"].ToString()!="")
				{
					model.BeginNumber=decimal.Parse(row["BeginNumber"].ToString());
				}
				if(row["EndNumber"]!=null && row["EndNumber"].ToString()!="")
				{
					model.EndNumber=decimal.Parse(row["EndNumber"].ToString());
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
			strSql.Append("select id,MeterID,FreezeDate,UseNumber,DosageType,InsertDate,BeginDate,BeginNumber,EndNumber ");
			strSql.Append(" FROM FreezeDayDosage ");
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
			strSql.Append(" id,MeterID,FreezeDate,UseNumber,DosageType,InsertDate,BeginDate,BeginNumber,EndNumber ");
			strSql.Append(" FROM FreezeDayDosage ");
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
			strSql.Append("select count(1) FROM FreezeDayDosage ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from FreezeDayDosage T ");
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
			parameters[0].Value = "FreezeDayDosage";
			parameters[1].Value = "id";
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

