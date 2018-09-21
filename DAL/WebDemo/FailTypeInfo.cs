using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:FailTypeInfo
	/// </summary>
	public partial class FailTypeInfo
	{
		public FailTypeInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "FailTypeInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FailTypeInfo");
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
		public int Add(WebDemo.Model.WebDemo.FailTypeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FailTypeInfo(");
			strSql.Append("FailTypeNum,FailTypeName,FailFlag,Remark,EnableDelete,AutoAnalyse)");
			strSql.Append(" values (");
			strSql.Append("@FailTypeNum,@FailTypeName,@FailFlag,@Remark,@EnableDelete,@AutoAnalyse)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FailTypeNum", SqlDbType.Int,4),
					new SqlParameter("@FailTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@FailFlag", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@EnableDelete", SqlDbType.Int,4),
					new SqlParameter("@AutoAnalyse", SqlDbType.Int,4)};
			parameters[0].Value = model.FailTypeNum;
			parameters[1].Value = model.FailTypeName;
			parameters[2].Value = model.FailFlag;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.EnableDelete;
			parameters[5].Value = model.AutoAnalyse;

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
		public bool Update(WebDemo.Model.WebDemo.FailTypeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FailTypeInfo set ");
			strSql.Append("FailTypeNum=@FailTypeNum,");
			strSql.Append("FailTypeName=@FailTypeName,");
			strSql.Append("FailFlag=@FailFlag,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("EnableDelete=@EnableDelete,");
			strSql.Append("AutoAnalyse=@AutoAnalyse");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FailTypeNum", SqlDbType.Int,4),
					new SqlParameter("@FailTypeName", SqlDbType.VarChar,200),
					new SqlParameter("@FailFlag", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@EnableDelete", SqlDbType.Int,4),
					new SqlParameter("@AutoAnalyse", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.FailTypeNum;
			parameters[1].Value = model.FailTypeName;
			parameters[2].Value = model.FailFlag;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.EnableDelete;
			parameters[5].Value = model.AutoAnalyse;
			parameters[6].Value = model.ID;

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
			strSql.Append("delete from FailTypeInfo ");
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
			strSql.Append("delete from FailTypeInfo ");
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
		public WebDemo.Model.WebDemo.FailTypeInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,FailTypeNum,FailTypeName,FailFlag,Remark,EnableDelete,AutoAnalyse from FailTypeInfo ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.FailTypeInfo model=new WebDemo.Model.WebDemo.FailTypeInfo();
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
		public WebDemo.Model.WebDemo.FailTypeInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.FailTypeInfo model=new WebDemo.Model.WebDemo.FailTypeInfo();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["FailTypeNum"]!=null && row["FailTypeNum"].ToString()!="")
				{
					model.FailTypeNum=int.Parse(row["FailTypeNum"].ToString());
				}
				if(row["FailTypeName"]!=null)
				{
					model.FailTypeName=row["FailTypeName"].ToString();
				}
				if(row["FailFlag"]!=null && row["FailFlag"].ToString()!="")
				{
					model.FailFlag=int.Parse(row["FailFlag"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["EnableDelete"]!=null && row["EnableDelete"].ToString()!="")
				{
					model.EnableDelete=int.Parse(row["EnableDelete"].ToString());
				}
				if(row["AutoAnalyse"]!=null && row["AutoAnalyse"].ToString()!="")
				{
					model.AutoAnalyse=int.Parse(row["AutoAnalyse"].ToString());
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
			strSql.Append("select ID,FailTypeNum,FailTypeName,FailFlag,Remark,EnableDelete,AutoAnalyse ");
			strSql.Append(" FROM FailTypeInfo ");
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
			strSql.Append(" ID,FailTypeNum,FailTypeName,FailFlag,Remark,EnableDelete,AutoAnalyse ");
			strSql.Append(" FROM FailTypeInfo ");
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
			strSql.Append("select count(1) FROM FailTypeInfo ");
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
			strSql.Append(")AS Row, T.*  from FailTypeInfo T ");
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
			parameters[0].Value = "FailTypeInfo";
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

