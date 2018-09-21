using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:GridViewType
	/// </summary>
	public partial class GridViewType
	{
		public GridViewType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("GridViewTypeID", "GridViewType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int GridViewTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from GridViewType");
			strSql.Append(" where GridViewTypeID=@GridViewTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GridViewTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = GridViewTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.GridViewType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GridViewType(");
			strSql.Append("GridViewTypeID,GridViewTypeName,IsEdit,IsShow,OrderNum,Remark)");
			strSql.Append(" values (");
			strSql.Append("@GridViewTypeID,@GridViewTypeName,@IsEdit,@IsShow,@OrderNum,@Remark)");
			SqlParameter[] parameters = {
					new SqlParameter("@GridViewTypeID", SqlDbType.Int,4),
					new SqlParameter("@GridViewTypeName", SqlDbType.VarChar,100),
					new SqlParameter("@IsEdit", SqlDbType.Bit,1),
					new SqlParameter("@IsShow", SqlDbType.Bit,1),
					new SqlParameter("@OrderNum", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
			parameters[0].Value = model.GridViewTypeID;
			parameters[1].Value = model.GridViewTypeName;
			parameters[2].Value = model.IsEdit;
			parameters[3].Value = model.IsShow;
			parameters[4].Value = model.OrderNum;
			parameters[5].Value = model.Remark;

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
		public bool Update(WebDemo.Model.WebDemo.GridViewType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update GridViewType set ");
			strSql.Append("GridViewTypeName=@GridViewTypeName,");
			strSql.Append("IsEdit=@IsEdit,");
			strSql.Append("IsShow=@IsShow,");
			strSql.Append("OrderNum=@OrderNum,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where GridViewTypeID=@GridViewTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GridViewTypeName", SqlDbType.VarChar,100),
					new SqlParameter("@IsEdit", SqlDbType.Bit,1),
					new SqlParameter("@IsShow", SqlDbType.Bit,1),
					new SqlParameter("@OrderNum", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@GridViewTypeID", SqlDbType.Int,4)};
			parameters[0].Value = model.GridViewTypeName;
			parameters[1].Value = model.IsEdit;
			parameters[2].Value = model.IsShow;
			parameters[3].Value = model.OrderNum;
			parameters[4].Value = model.Remark;
			parameters[5].Value = model.GridViewTypeID;

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
		public bool Delete(int GridViewTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GridViewType ");
			strSql.Append(" where GridViewTypeID=@GridViewTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GridViewTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = GridViewTypeID;

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
		public bool DeleteList(string GridViewTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GridViewType ");
			strSql.Append(" where GridViewTypeID in ("+GridViewTypeIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.GridViewType GetModel(int GridViewTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 GridViewTypeID,GridViewTypeName,IsEdit,IsShow,OrderNum,Remark from GridViewType ");
			strSql.Append(" where GridViewTypeID=@GridViewTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GridViewTypeID", SqlDbType.Int,4)			};
			parameters[0].Value = GridViewTypeID;

			WebDemo.Model.WebDemo.GridViewType model=new WebDemo.Model.WebDemo.GridViewType();
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
		public WebDemo.Model.WebDemo.GridViewType DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.GridViewType model=new WebDemo.Model.WebDemo.GridViewType();
			if (row != null)
			{
				if(row["GridViewTypeID"]!=null && row["GridViewTypeID"].ToString()!="")
				{
					model.GridViewTypeID=int.Parse(row["GridViewTypeID"].ToString());
				}
				if(row["GridViewTypeName"]!=null)
				{
					model.GridViewTypeName=row["GridViewTypeName"].ToString();
				}
				if(row["IsEdit"]!=null && row["IsEdit"].ToString()!="")
				{
					if((row["IsEdit"].ToString()=="1")||(row["IsEdit"].ToString().ToLower()=="true"))
					{
						model.IsEdit=true;
					}
					else
					{
						model.IsEdit=false;
					}
				}
				if(row["IsShow"]!=null && row["IsShow"].ToString()!="")
				{
					if((row["IsShow"].ToString()=="1")||(row["IsShow"].ToString().ToLower()=="true"))
					{
						model.IsShow=true;
					}
					else
					{
						model.IsShow=false;
					}
				}
				if(row["OrderNum"]!=null && row["OrderNum"].ToString()!="")
				{
					model.OrderNum=int.Parse(row["OrderNum"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select GridViewTypeID,GridViewTypeName,IsEdit,IsShow,OrderNum,Remark ");
			strSql.Append(" FROM GridViewType ");
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
			strSql.Append(" GridViewTypeID,GridViewTypeName,IsEdit,IsShow,OrderNum,Remark ");
			strSql.Append(" FROM GridViewType ");
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
			strSql.Append("select count(1) FROM GridViewType ");
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
				strSql.Append("order by T.GridViewTypeID desc");
			}
			strSql.Append(")AS Row, T.*  from GridViewType T ");
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
			parameters[0].Value = "GridViewType";
			parameters[1].Value = "GridViewTypeID";
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

