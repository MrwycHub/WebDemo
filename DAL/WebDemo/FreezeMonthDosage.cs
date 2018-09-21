using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:FreezeMonthDosage
	/// </summary>
	public partial class FreezeMonthDosage
	{
		public FreezeMonthDosage()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeterID", "FreezeMonthDosage"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeterID,string FreezeMonth)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FreezeMonthDosage");
			strSql.Append(" where MeterID=@MeterID and FreezeMonth=@FreezeMonth ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FreezeMonth", SqlDbType.VarChar,7)			};
			parameters[0].Value = MeterID;
			parameters[1].Value = FreezeMonth;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.FreezeMonthDosage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FreezeMonthDosage(");
			strSql.Append("MeterID,BeginMonth,BeginNumber,FreezeMonth,EndNumber,UseNumber,InsertDate,UseActiveSharp,UseActivePeak,UseActiveShoulder,UseActiveOffPeak,SyncFlag)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@BeginMonth,@BeginNumber,@FreezeMonth,@EndNumber,@UseNumber,@InsertDate,@UseActiveSharp,@UseActivePeak,@UseActiveShoulder,@UseActiveOffPeak,@SyncFlag)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@BeginMonth", SqlDbType.VarChar,7),
					new SqlParameter("@BeginNumber", SqlDbType.Decimal,9),
					new SqlParameter("@FreezeMonth", SqlDbType.VarChar,7),
					new SqlParameter("@EndNumber", SqlDbType.Decimal,9),
					new SqlParameter("@UseNumber", SqlDbType.Decimal,9),
					new SqlParameter("@InsertDate", SqlDbType.DateTime),
					new SqlParameter("@UseActiveSharp", SqlDbType.Decimal,9),
					new SqlParameter("@UseActivePeak", SqlDbType.Decimal,9),
					new SqlParameter("@UseActiveShoulder", SqlDbType.Decimal,9),
					new SqlParameter("@UseActiveOffPeak", SqlDbType.Decimal,9),
					new SqlParameter("@SyncFlag", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.BeginMonth;
			parameters[2].Value = model.BeginNumber;
			parameters[3].Value = model.FreezeMonth;
			parameters[4].Value = model.EndNumber;
			parameters[5].Value = model.UseNumber;
			parameters[6].Value = model.InsertDate;
			parameters[7].Value = model.UseActiveSharp;
			parameters[8].Value = model.UseActivePeak;
			parameters[9].Value = model.UseActiveShoulder;
			parameters[10].Value = model.UseActiveOffPeak;
			parameters[11].Value = model.SyncFlag;

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
		public bool Update(WebDemo.Model.WebDemo.FreezeMonthDosage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FreezeMonthDosage set ");
			strSql.Append("BeginMonth=@BeginMonth,");
			strSql.Append("BeginNumber=@BeginNumber,");
			strSql.Append("EndNumber=@EndNumber,");
			strSql.Append("UseNumber=@UseNumber,");
			strSql.Append("InsertDate=@InsertDate,");
			strSql.Append("UseActiveSharp=@UseActiveSharp,");
			strSql.Append("UseActivePeak=@UseActivePeak,");
			strSql.Append("UseActiveShoulder=@UseActiveShoulder,");
			strSql.Append("UseActiveOffPeak=@UseActiveOffPeak,");
			strSql.Append("SyncFlag=@SyncFlag");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@BeginMonth", SqlDbType.VarChar,7),
					new SqlParameter("@BeginNumber", SqlDbType.Decimal,9),
					new SqlParameter("@EndNumber", SqlDbType.Decimal,9),
					new SqlParameter("@UseNumber", SqlDbType.Decimal,9),
					new SqlParameter("@InsertDate", SqlDbType.DateTime),
					new SqlParameter("@UseActiveSharp", SqlDbType.Decimal,9),
					new SqlParameter("@UseActivePeak", SqlDbType.Decimal,9),
					new SqlParameter("@UseActiveShoulder", SqlDbType.Decimal,9),
					new SqlParameter("@UseActiveOffPeak", SqlDbType.Decimal,9),
					new SqlParameter("@SyncFlag", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FreezeMonth", SqlDbType.VarChar,7)};
			parameters[0].Value = model.BeginMonth;
			parameters[1].Value = model.BeginNumber;
			parameters[2].Value = model.EndNumber;
			parameters[3].Value = model.UseNumber;
			parameters[4].Value = model.InsertDate;
			parameters[5].Value = model.UseActiveSharp;
			parameters[6].Value = model.UseActivePeak;
			parameters[7].Value = model.UseActiveShoulder;
			parameters[8].Value = model.UseActiveOffPeak;
			parameters[9].Value = model.SyncFlag;
			parameters[10].Value = model.id;
			parameters[11].Value = model.MeterID;
			parameters[12].Value = model.FreezeMonth;

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
			strSql.Append("delete from FreezeMonthDosage ");
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int MeterID,string FreezeMonth)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FreezeMonthDosage ");
			strSql.Append(" where MeterID=@MeterID and FreezeMonth=@FreezeMonth ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FreezeMonth", SqlDbType.VarChar,7)			};
			parameters[0].Value = MeterID;
			parameters[1].Value = FreezeMonth;

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
			strSql.Append("delete from FreezeMonthDosage ");
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
		public WebDemo.Model.WebDemo.FreezeMonthDosage GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,MeterID,BeginMonth,BeginNumber,FreezeMonth,EndNumber,UseNumber,InsertDate,UseActiveSharp,UseActivePeak,UseActiveShoulder,UseActiveOffPeak,SyncFlag from FreezeMonthDosage ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			WebDemo.Model.WebDemo.FreezeMonthDosage model=new WebDemo.Model.WebDemo.FreezeMonthDosage();
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
		public WebDemo.Model.WebDemo.FreezeMonthDosage DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.FreezeMonthDosage model=new WebDemo.Model.WebDemo.FreezeMonthDosage();
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
				if(row["BeginMonth"]!=null)
				{
					model.BeginMonth=row["BeginMonth"].ToString();
				}
				if(row["BeginNumber"]!=null && row["BeginNumber"].ToString()!="")
				{
					model.BeginNumber=decimal.Parse(row["BeginNumber"].ToString());
				}
				if(row["FreezeMonth"]!=null)
				{
					model.FreezeMonth=row["FreezeMonth"].ToString();
				}
				if(row["EndNumber"]!=null && row["EndNumber"].ToString()!="")
				{
					model.EndNumber=decimal.Parse(row["EndNumber"].ToString());
				}
				if(row["UseNumber"]!=null && row["UseNumber"].ToString()!="")
				{
					model.UseNumber=decimal.Parse(row["UseNumber"].ToString());
				}
				if(row["InsertDate"]!=null && row["InsertDate"].ToString()!="")
				{
					model.InsertDate=DateTime.Parse(row["InsertDate"].ToString());
				}
				if(row["UseActiveSharp"]!=null && row["UseActiveSharp"].ToString()!="")
				{
					model.UseActiveSharp=decimal.Parse(row["UseActiveSharp"].ToString());
				}
				if(row["UseActivePeak"]!=null && row["UseActivePeak"].ToString()!="")
				{
					model.UseActivePeak=decimal.Parse(row["UseActivePeak"].ToString());
				}
				if(row["UseActiveShoulder"]!=null && row["UseActiveShoulder"].ToString()!="")
				{
					model.UseActiveShoulder=decimal.Parse(row["UseActiveShoulder"].ToString());
				}
				if(row["UseActiveOffPeak"]!=null && row["UseActiveOffPeak"].ToString()!="")
				{
					model.UseActiveOffPeak=decimal.Parse(row["UseActiveOffPeak"].ToString());
				}
				if(row["SyncFlag"]!=null && row["SyncFlag"].ToString()!="")
				{
					model.SyncFlag=int.Parse(row["SyncFlag"].ToString());
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
			strSql.Append("select id,MeterID,BeginMonth,BeginNumber,FreezeMonth,EndNumber,UseNumber,InsertDate,UseActiveSharp,UseActivePeak,UseActiveShoulder,UseActiveOffPeak,SyncFlag ");
			strSql.Append(" FROM FreezeMonthDosage ");
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
			strSql.Append(" id,MeterID,BeginMonth,BeginNumber,FreezeMonth,EndNumber,UseNumber,InsertDate,UseActiveSharp,UseActivePeak,UseActiveShoulder,UseActiveOffPeak,SyncFlag ");
			strSql.Append(" FROM FreezeMonthDosage ");
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
			strSql.Append("select count(1) FROM FreezeMonthDosage ");
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
			strSql.Append(")AS Row, T.*  from FreezeMonthDosage T ");
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
			parameters[0].Value = "FreezeMonthDosage";
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

