using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MeterType
	/// </summary>
	public partial class MeterType
	{
		public MeterType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeterTypeID", "MeterType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeterTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MeterType");
			strSql.Append(" where MeterTypeID=@MeterTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.MeterType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MeterType(");
			strSql.Append("MeterTypeID,MeterTypeName,Remark,Flag)");
			strSql.Append(" values (");
			strSql.Append("@MeterTypeID,@MeterTypeName,@Remark,@Flag)");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterTypeID", SqlDbType.Int,4),
					new SqlParameter("@MeterTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@Flag", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterTypeID;
			parameters[1].Value = model.MeterTypeName;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.Flag;

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
		public bool Update(WebDemo.Model.WebDemo.MeterType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MeterType set ");
			strSql.Append("MeterTypeName=@MeterTypeName,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Flag=@Flag");
			strSql.Append(" where MeterTypeID=@MeterTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@MeterTypeID", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterTypeName;
			parameters[1].Value = model.Remark;
			parameters[2].Value = model.Flag;
			parameters[3].Value = model.MeterTypeID;

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
		public bool Delete(int MeterTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeterType ");
			strSql.Append(" where MeterTypeID=@MeterTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterTypeID;

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
		public bool DeleteList(string MeterTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeterType ");
			strSql.Append(" where MeterTypeID in ("+MeterTypeIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.MeterType GetModel(int MeterTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MeterTypeID,MeterTypeName,Remark,Flag from MeterType ");
			strSql.Append(" where MeterTypeID=@MeterTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterTypeID;

			WebDemo.Model.WebDemo.MeterType model=new WebDemo.Model.WebDemo.MeterType();
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
		public WebDemo.Model.WebDemo.MeterType DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MeterType model=new WebDemo.Model.WebDemo.MeterType();
			if (row != null)
			{
				if(row["MeterTypeID"]!=null && row["MeterTypeID"].ToString()!="")
				{
					model.MeterTypeID=int.Parse(row["MeterTypeID"].ToString());
				}
				if(row["MeterTypeName"]!=null)
				{
					model.MeterTypeName=row["MeterTypeName"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["Flag"]!=null && row["Flag"].ToString()!="")
				{
					model.Flag=int.Parse(row["Flag"].ToString());
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
			strSql.Append("select MeterTypeID,MeterTypeName,Remark,Flag ");
			strSql.Append(" FROM MeterType ");
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
			strSql.Append(" MeterTypeID,MeterTypeName,Remark,Flag ");
			strSql.Append(" FROM MeterType ");
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
			strSql.Append("select count(1) FROM MeterType ");
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
				strSql.Append("order by T.MeterTypeID desc");
			}
			strSql.Append(")AS Row, T.*  from MeterType T ");
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
			parameters[0].Value = "MeterType";
			parameters[1].Value = "MeterTypeID";
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

