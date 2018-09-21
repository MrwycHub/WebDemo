using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:InvoiceTemplate
	/// </summary>
	public partial class InvoiceTemplate
	{
		public InvoiceTemplate()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.InvoiceTemplate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InvoiceTemplate(");
			strSql.Append("TemplateID,TemplateName,TemplatePath,Flag,TemplateFile,LastOperTime,LastOperatorId,Remark)");
			strSql.Append(" values (");
			strSql.Append("@TemplateID,@TemplateName,@TemplatePath,@Flag,@TemplateFile,@LastOperTime,@LastOperatorId,@Remark)");
			SqlParameter[] parameters = {
					new SqlParameter("@TemplateID", SqlDbType.Int,4),
					new SqlParameter("@TemplateName", SqlDbType.VarChar,200),
					new SqlParameter("@TemplatePath", SqlDbType.VarChar,200),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@TemplateFile", SqlDbType.VarBinary,1),
					new SqlParameter("@LastOperTime", SqlDbType.DateTime),
					new SqlParameter("@LastOperatorId", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
			parameters[0].Value = model.TemplateID;
			parameters[1].Value = model.TemplateName;
			parameters[2].Value = model.TemplatePath;
			parameters[3].Value = model.Flag;
			parameters[4].Value = model.TemplateFile;
			parameters[5].Value = model.LastOperTime;
			parameters[6].Value = model.LastOperatorId;
			parameters[7].Value = model.Remark;

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
		public bool Update(WebDemo.Model.WebDemo.InvoiceTemplate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InvoiceTemplate set ");
			strSql.Append("TemplateID=@TemplateID,");
			strSql.Append("TemplateName=@TemplateName,");
			strSql.Append("TemplatePath=@TemplatePath,");
			strSql.Append("Flag=@Flag,");
			strSql.Append("TemplateFile=@TemplateFile,");
			strSql.Append("LastOperTime=@LastOperTime,");
			strSql.Append("LastOperatorId=@LastOperatorId,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@TemplateID", SqlDbType.Int,4),
					new SqlParameter("@TemplateName", SqlDbType.VarChar,200),
					new SqlParameter("@TemplatePath", SqlDbType.VarChar,200),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@TemplateFile", SqlDbType.VarBinary,1),
					new SqlParameter("@LastOperTime", SqlDbType.DateTime),
					new SqlParameter("@LastOperatorId", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
			parameters[0].Value = model.TemplateID;
			parameters[1].Value = model.TemplateName;
			parameters[2].Value = model.TemplatePath;
			parameters[3].Value = model.Flag;
			parameters[4].Value = model.TemplateFile;
			parameters[5].Value = model.LastOperTime;
			parameters[6].Value = model.LastOperatorId;
			parameters[7].Value = model.Remark;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InvoiceTemplate ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public WebDemo.Model.WebDemo.InvoiceTemplate GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TemplateID,TemplateName,TemplatePath,Flag,TemplateFile,LastOperTime,LastOperatorId,Remark from InvoiceTemplate ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			WebDemo.Model.WebDemo.InvoiceTemplate model=new WebDemo.Model.WebDemo.InvoiceTemplate();
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
		public WebDemo.Model.WebDemo.InvoiceTemplate DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.InvoiceTemplate model=new WebDemo.Model.WebDemo.InvoiceTemplate();
			if (row != null)
			{
				if(row["TemplateID"]!=null && row["TemplateID"].ToString()!="")
				{
					model.TemplateID=int.Parse(row["TemplateID"].ToString());
				}
				if(row["TemplateName"]!=null)
				{
					model.TemplateName=row["TemplateName"].ToString();
				}
				if(row["TemplatePath"]!=null)
				{
					model.TemplatePath=row["TemplatePath"].ToString();
				}
				if(row["Flag"]!=null && row["Flag"].ToString()!="")
				{
					model.Flag=int.Parse(row["Flag"].ToString());
				}
				if(row["TemplateFile"]!=null && row["TemplateFile"].ToString()!="")
				{
					model.TemplateFile=(byte[])row["TemplateFile"];
				}
				if(row["LastOperTime"]!=null && row["LastOperTime"].ToString()!="")
				{
					model.LastOperTime=DateTime.Parse(row["LastOperTime"].ToString());
				}
				if(row["LastOperatorId"]!=null && row["LastOperatorId"].ToString()!="")
				{
					model.LastOperatorId=int.Parse(row["LastOperatorId"].ToString());
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
			strSql.Append("select TemplateID,TemplateName,TemplatePath,Flag,TemplateFile,LastOperTime,LastOperatorId,Remark ");
			strSql.Append(" FROM InvoiceTemplate ");
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
			strSql.Append(" TemplateID,TemplateName,TemplatePath,Flag,TemplateFile,LastOperTime,LastOperatorId,Remark ");
			strSql.Append(" FROM InvoiceTemplate ");
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
			strSql.Append("select count(1) FROM InvoiceTemplate ");
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
				strSql.Append("order by T.BatchId desc");
			}
			strSql.Append(")AS Row, T.*  from InvoiceTemplate T ");
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
			parameters[0].Value = "InvoiceTemplate";
			parameters[1].Value = "BatchId";
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

