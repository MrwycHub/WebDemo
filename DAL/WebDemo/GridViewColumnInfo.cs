using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:GridViewColumnInfo
	/// </summary>
	public partial class GridViewColumnInfo
	{
		public GridViewColumnInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("GridViewTypeID", "GridViewColumnInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int GridViewTypeID,string DataField,int OperatorID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from GridViewColumnInfo");
			strSql.Append(" where GridViewTypeID=@GridViewTypeID and DataField=@DataField and OperatorID=@OperatorID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GridViewTypeID", SqlDbType.Int,4),
					new SqlParameter("@DataField", SqlDbType.VarChar,100),
					new SqlParameter("@OperatorID", SqlDbType.Int,4)			};
			parameters[0].Value = GridViewTypeID;
			parameters[1].Value = DataField;
			parameters[2].Value = OperatorID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.GridViewColumnInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GridViewColumnInfo(");
			strSql.Append("GridViewTypeID,ColumnID,DataField,HeaderText,DataFormat,SortExpression,IsEdit,IsShow,OrderNum,OperatorID,Remark)");
			strSql.Append(" values (");
			strSql.Append("@GridViewTypeID,@ColumnID,@DataField,@HeaderText,@DataFormat,@SortExpression,@IsEdit,@IsShow,@OrderNum,@OperatorID,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GridViewTypeID", SqlDbType.Int,4),
					new SqlParameter("@ColumnID", SqlDbType.Int,4),
					new SqlParameter("@DataField", SqlDbType.VarChar,100),
					new SqlParameter("@HeaderText", SqlDbType.VarChar,100),
					new SqlParameter("@DataFormat", SqlDbType.VarChar,100),
					new SqlParameter("@SortExpression", SqlDbType.VarChar,100),
					new SqlParameter("@IsEdit", SqlDbType.Bit,1),
					new SqlParameter("@IsShow", SqlDbType.Bit,1),
					new SqlParameter("@OrderNum", SqlDbType.Int,4),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
			parameters[0].Value = model.GridViewTypeID;
			parameters[1].Value = model.ColumnID;
			parameters[2].Value = model.DataField;
			parameters[3].Value = model.HeaderText;
			parameters[4].Value = model.DataFormat;
			parameters[5].Value = model.SortExpression;
			parameters[6].Value = model.IsEdit;
			parameters[7].Value = model.IsShow;
			parameters[8].Value = model.OrderNum;
			parameters[9].Value = model.OperatorID;
			parameters[10].Value = model.Remark;

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
		public bool Update(WebDemo.Model.WebDemo.GridViewColumnInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update GridViewColumnInfo set ");
			strSql.Append("ColumnID=@ColumnID,");
			strSql.Append("HeaderText=@HeaderText,");
			strSql.Append("DataFormat=@DataFormat,");
			strSql.Append("SortExpression=@SortExpression,");
			strSql.Append("IsEdit=@IsEdit,");
			strSql.Append("IsShow=@IsShow,");
			strSql.Append("OrderNum=@OrderNum,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@ColumnID", SqlDbType.Int,4),
					new SqlParameter("@HeaderText", SqlDbType.VarChar,100),
					new SqlParameter("@DataFormat", SqlDbType.VarChar,100),
					new SqlParameter("@SortExpression", SqlDbType.VarChar,100),
					new SqlParameter("@IsEdit", SqlDbType.Bit,1),
					new SqlParameter("@IsShow", SqlDbType.Bit,1),
					new SqlParameter("@OrderNum", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@GridViewTypeID", SqlDbType.Int,4),
					new SqlParameter("@DataField", SqlDbType.VarChar,100),
					new SqlParameter("@OperatorID", SqlDbType.Int,4)};
			parameters[0].Value = model.ColumnID;
			parameters[1].Value = model.HeaderText;
			parameters[2].Value = model.DataFormat;
			parameters[3].Value = model.SortExpression;
			parameters[4].Value = model.IsEdit;
			parameters[5].Value = model.IsShow;
			parameters[6].Value = model.OrderNum;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.Id;
			parameters[9].Value = model.GridViewTypeID;
			parameters[10].Value = model.DataField;
			parameters[11].Value = model.OperatorID;

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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GridViewColumnInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

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
		public bool Delete(int GridViewTypeID,string DataField,int OperatorID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GridViewColumnInfo ");
			strSql.Append(" where GridViewTypeID=@GridViewTypeID and DataField=@DataField and OperatorID=@OperatorID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GridViewTypeID", SqlDbType.Int,4),
					new SqlParameter("@DataField", SqlDbType.VarChar,100),
					new SqlParameter("@OperatorID", SqlDbType.Int,4)			};
			parameters[0].Value = GridViewTypeID;
			parameters[1].Value = DataField;
			parameters[2].Value = OperatorID;

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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from GridViewColumnInfo ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
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
		public WebDemo.Model.WebDemo.GridViewColumnInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,GridViewTypeID,ColumnID,DataField,HeaderText,DataFormat,SortExpression,IsEdit,IsShow,OrderNum,OperatorID,Remark from GridViewColumnInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			WebDemo.Model.WebDemo.GridViewColumnInfo model=new WebDemo.Model.WebDemo.GridViewColumnInfo();
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
		public WebDemo.Model.WebDemo.GridViewColumnInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.GridViewColumnInfo model=new WebDemo.Model.WebDemo.GridViewColumnInfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["GridViewTypeID"]!=null && row["GridViewTypeID"].ToString()!="")
				{
					model.GridViewTypeID=int.Parse(row["GridViewTypeID"].ToString());
				}
				if(row["ColumnID"]!=null && row["ColumnID"].ToString()!="")
				{
					model.ColumnID=int.Parse(row["ColumnID"].ToString());
				}
				if(row["DataField"]!=null)
				{
					model.DataField=row["DataField"].ToString();
				}
				if(row["HeaderText"]!=null)
				{
					model.HeaderText=row["HeaderText"].ToString();
				}
				if(row["DataFormat"]!=null)
				{
					model.DataFormat=row["DataFormat"].ToString();
				}
				if(row["SortExpression"]!=null)
				{
					model.SortExpression=row["SortExpression"].ToString();
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
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
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
			strSql.Append("select Id,GridViewTypeID,ColumnID,DataField,HeaderText,DataFormat,SortExpression,IsEdit,IsShow,OrderNum,OperatorID,Remark ");
			strSql.Append(" FROM GridViewColumnInfo ");
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
			strSql.Append(" Id,GridViewTypeID,ColumnID,DataField,HeaderText,DataFormat,SortExpression,IsEdit,IsShow,OrderNum,OperatorID,Remark ");
			strSql.Append(" FROM GridViewColumnInfo ");
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
			strSql.Append("select count(1) FROM GridViewColumnInfo ");
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from GridViewColumnInfo T ");
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
			parameters[0].Value = "GridViewColumnInfo";
			parameters[1].Value = "Id";
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

