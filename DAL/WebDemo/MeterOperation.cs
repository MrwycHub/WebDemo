using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MeterOperation
	/// </summary>
	public partial class MeterOperation
	{
		public MeterOperation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("OperID", "MeterOperation"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OperID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MeterOperation");
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
		public int Add(WebDemo.Model.WebDemo.MeterOperation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MeterOperation(");
			strSql.Append("OperType,OperDate,MeterIDOld,MeterIDNew,UseNumberOld,StatFlag)");
			strSql.Append(" values (");
			strSql.Append("@OperType,@OperDate,@MeterIDOld,@MeterIDNew,@UseNumberOld,@StatFlag)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OperType", SqlDbType.VarChar,50),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@MeterIDOld", SqlDbType.Int,4),
					new SqlParameter("@MeterIDNew", SqlDbType.Int,4),
					new SqlParameter("@UseNumberOld", SqlDbType.Decimal,9),
					new SqlParameter("@StatFlag", SqlDbType.Int,4)};
			parameters[0].Value = model.OperType;
			parameters[1].Value = model.OperDate;
			parameters[2].Value = model.MeterIDOld;
			parameters[3].Value = model.MeterIDNew;
			parameters[4].Value = model.UseNumberOld;
			parameters[5].Value = model.StatFlag;

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
		public bool Update(WebDemo.Model.WebDemo.MeterOperation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MeterOperation set ");
			strSql.Append("OperType=@OperType,");
			strSql.Append("OperDate=@OperDate,");
			strSql.Append("MeterIDOld=@MeterIDOld,");
			strSql.Append("MeterIDNew=@MeterIDNew,");
			strSql.Append("UseNumberOld=@UseNumberOld,");
			strSql.Append("StatFlag=@StatFlag");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@OperType", SqlDbType.VarChar,50),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@MeterIDOld", SqlDbType.Int,4),
					new SqlParameter("@MeterIDNew", SqlDbType.Int,4),
					new SqlParameter("@UseNumberOld", SqlDbType.Decimal,9),
					new SqlParameter("@StatFlag", SqlDbType.Int,4),
					new SqlParameter("@OperID", SqlDbType.Int,4)};
			parameters[0].Value = model.OperType;
			parameters[1].Value = model.OperDate;
			parameters[2].Value = model.MeterIDOld;
			parameters[3].Value = model.MeterIDNew;
			parameters[4].Value = model.UseNumberOld;
			parameters[5].Value = model.StatFlag;
			parameters[6].Value = model.OperID;

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
			strSql.Append("delete from MeterOperation ");
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
			strSql.Append("delete from MeterOperation ");
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
		public WebDemo.Model.WebDemo.MeterOperation GetModel(int OperID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OperID,OperType,OperDate,MeterIDOld,MeterIDNew,UseNumberOld,StatFlag from MeterOperation ");
			strSql.Append(" where OperID=@OperID");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4)
			};
			parameters[0].Value = OperID;

			WebDemo.Model.WebDemo.MeterOperation model=new WebDemo.Model.WebDemo.MeterOperation();
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
		public WebDemo.Model.WebDemo.MeterOperation DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MeterOperation model=new WebDemo.Model.WebDemo.MeterOperation();
			if (row != null)
			{
				if(row["OperID"]!=null && row["OperID"].ToString()!="")
				{
					model.OperID=int.Parse(row["OperID"].ToString());
				}
				if(row["OperType"]!=null)
				{
					model.OperType=row["OperType"].ToString();
				}
				if(row["OperDate"]!=null && row["OperDate"].ToString()!="")
				{
					model.OperDate=DateTime.Parse(row["OperDate"].ToString());
				}
				if(row["MeterIDOld"]!=null && row["MeterIDOld"].ToString()!="")
				{
					model.MeterIDOld=int.Parse(row["MeterIDOld"].ToString());
				}
				if(row["MeterIDNew"]!=null && row["MeterIDNew"].ToString()!="")
				{
					model.MeterIDNew=int.Parse(row["MeterIDNew"].ToString());
				}
				if(row["UseNumberOld"]!=null && row["UseNumberOld"].ToString()!="")
				{
					model.UseNumberOld=decimal.Parse(row["UseNumberOld"].ToString());
				}
				if(row["StatFlag"]!=null && row["StatFlag"].ToString()!="")
				{
					model.StatFlag=int.Parse(row["StatFlag"].ToString());
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
			strSql.Append("select OperID,OperType,OperDate,MeterIDOld,MeterIDNew,UseNumberOld,StatFlag ");
			strSql.Append(" FROM MeterOperation ");
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
			strSql.Append(" OperID,OperType,OperDate,MeterIDOld,MeterIDNew,UseNumberOld,StatFlag ");
			strSql.Append(" FROM MeterOperation ");
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
			strSql.Append("select count(1) FROM MeterOperation ");
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
			strSql.Append(")AS Row, T.*  from MeterOperation T ");
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
			parameters[0].Value = "MeterOperation";
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

