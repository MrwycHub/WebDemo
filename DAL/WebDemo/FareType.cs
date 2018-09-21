using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:FareType
	/// </summary>
	public partial class FareType
	{
		public FareType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string FareTypeName)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FareType");
			strSql.Append(" where FareTypeName=@FareTypeName ");
			SqlParameter[] parameters = {
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,50)			};
			parameters[0].Value = FareTypeName;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.FareType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FareType(");
			strSql.Append("FareTypeName,Remark,MeterTypeID)");
			strSql.Append(" values (");
			strSql.Append("@FareTypeName,@Remark,@MeterTypeID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@MeterTypeID", SqlDbType.Int,4)};
			parameters[0].Value = model.FareTypeName;
			parameters[1].Value = model.Remark;
			parameters[2].Value = model.MeterTypeID;

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
		public bool Update(WebDemo.Model.WebDemo.FareType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FareType set ");
			strSql.Append("Remark=@Remark,");
			strSql.Append("MeterTypeID=@MeterTypeID");
			strSql.Append(" where FareTypeID=@FareTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@MeterTypeID", SqlDbType.Int,4),
					new SqlParameter("@FareTypeID", SqlDbType.Int,4),
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Remark;
			parameters[1].Value = model.MeterTypeID;
			parameters[2].Value = model.FareTypeID;
			parameters[3].Value = model.FareTypeName;

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
		public bool Delete(int FareTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FareType ");
			strSql.Append(" where FareTypeID=@FareTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@FareTypeID", SqlDbType.Int,4)
			};
			parameters[0].Value = FareTypeID;

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
		public bool Delete(string FareTypeName)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FareType ");
			strSql.Append(" where FareTypeName=@FareTypeName ");
			SqlParameter[] parameters = {
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,50)			};
			parameters[0].Value = FareTypeName;

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
		public bool DeleteList(string FareTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FareType ");
			strSql.Append(" where FareTypeID in ("+FareTypeIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.FareType GetModel(int FareTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FareTypeID,FareTypeName,Remark,MeterTypeID from FareType ");
			strSql.Append(" where FareTypeID=@FareTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@FareTypeID", SqlDbType.Int,4)
			};
			parameters[0].Value = FareTypeID;

			WebDemo.Model.WebDemo.FareType model=new WebDemo.Model.WebDemo.FareType();
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
		public WebDemo.Model.WebDemo.FareType DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.FareType model=new WebDemo.Model.WebDemo.FareType();
			if (row != null)
			{
				if(row["FareTypeID"]!=null && row["FareTypeID"].ToString()!="")
				{
					model.FareTypeID=int.Parse(row["FareTypeID"].ToString());
				}
				if(row["FareTypeName"]!=null)
				{
					model.FareTypeName=row["FareTypeName"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["MeterTypeID"]!=null && row["MeterTypeID"].ToString()!="")
				{
					model.MeterTypeID=int.Parse(row["MeterTypeID"].ToString());
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
			strSql.Append("select FareTypeID,FareTypeName,Remark,MeterTypeID ");
			strSql.Append(" FROM FareType ");
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
			strSql.Append(" FareTypeID,FareTypeName,Remark,MeterTypeID ");
			strSql.Append(" FROM FareType ");
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
			strSql.Append("select count(1) FROM FareType ");
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
				strSql.Append("order by T.FareTypeID desc");
			}
			strSql.Append(")AS Row, T.*  from FareType T ");
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
			parameters[0].Value = "FareType";
			parameters[1].Value = "FareTypeID";
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

