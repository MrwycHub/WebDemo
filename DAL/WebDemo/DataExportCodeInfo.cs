using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:DataExportCodeInfo
	/// </summary>
	public partial class DataExportCodeInfo
	{
		public DataExportCodeInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "DataExportCodeInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DataExportCodeInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.DataExportCodeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DataExportCodeInfo(");
			strSql.Append("ID,Name,StrSql,ShowDeptCondition,InfoCondition,DateCondition,ExtCondition,AscString,GridViewWidth,ExportType,ShowHeader,SplitChar,CreateDbfSql,DbfFileName,Remark,EndDateCondition,ShowOtherHeader,ExportCols)");
			strSql.Append(" values (");
			strSql.Append("@ID,@Name,@StrSql,@ShowDeptCondition,@InfoCondition,@DateCondition,@ExtCondition,@AscString,@GridViewWidth,@ExportType,@ShowHeader,@SplitChar,@CreateDbfSql,@DbfFileName,@Remark,@EndDateCondition,@ShowOtherHeader,@ExportCols)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@StrSql", SqlDbType.VarChar,2000),
					new SqlParameter("@ShowDeptCondition", SqlDbType.Bit,1),
					new SqlParameter("@InfoCondition", SqlDbType.VarChar,200),
					new SqlParameter("@DateCondition", SqlDbType.VarChar,200),
					new SqlParameter("@ExtCondition", SqlDbType.VarChar,200),
					new SqlParameter("@AscString", SqlDbType.VarChar,50),
					new SqlParameter("@GridViewWidth", SqlDbType.Int,4),
					new SqlParameter("@ExportType", SqlDbType.VarChar,50),
					new SqlParameter("@ShowHeader", SqlDbType.Bit,1),
					new SqlParameter("@SplitChar", SqlDbType.VarChar,50),
					new SqlParameter("@CreateDbfSql", SqlDbType.VarChar,2000),
					new SqlParameter("@DbfFileName", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@EndDateCondition", SqlDbType.VarChar,200),
					new SqlParameter("@ShowOtherHeader", SqlDbType.NVarChar,4000),
					new SqlParameter("@ExportCols", SqlDbType.NVarChar,4000)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.StrSql;
			parameters[3].Value = model.ShowDeptCondition;
			parameters[4].Value = model.InfoCondition;
			parameters[5].Value = model.DateCondition;
			parameters[6].Value = model.ExtCondition;
			parameters[7].Value = model.AscString;
			parameters[8].Value = model.GridViewWidth;
			parameters[9].Value = model.ExportType;
			parameters[10].Value = model.ShowHeader;
			parameters[11].Value = model.SplitChar;
			parameters[12].Value = model.CreateDbfSql;
			parameters[13].Value = model.DbfFileName;
			parameters[14].Value = model.Remark;
			parameters[15].Value = model.EndDateCondition;
			parameters[16].Value = model.ShowOtherHeader;
			parameters[17].Value = model.ExportCols;

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
		public bool Update(WebDemo.Model.WebDemo.DataExportCodeInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DataExportCodeInfo set ");
			strSql.Append("Name=@Name,");
			strSql.Append("StrSql=@StrSql,");
			strSql.Append("ShowDeptCondition=@ShowDeptCondition,");
			strSql.Append("InfoCondition=@InfoCondition,");
			strSql.Append("DateCondition=@DateCondition,");
			strSql.Append("ExtCondition=@ExtCondition,");
			strSql.Append("AscString=@AscString,");
			strSql.Append("GridViewWidth=@GridViewWidth,");
			strSql.Append("ExportType=@ExportType,");
			strSql.Append("ShowHeader=@ShowHeader,");
			strSql.Append("SplitChar=@SplitChar,");
			strSql.Append("CreateDbfSql=@CreateDbfSql,");
			strSql.Append("DbfFileName=@DbfFileName,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("EndDateCondition=@EndDateCondition,");
			strSql.Append("ShowOtherHeader=@ShowOtherHeader,");
			strSql.Append("ExportCols=@ExportCols");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@StrSql", SqlDbType.VarChar,2000),
					new SqlParameter("@ShowDeptCondition", SqlDbType.Bit,1),
					new SqlParameter("@InfoCondition", SqlDbType.VarChar,200),
					new SqlParameter("@DateCondition", SqlDbType.VarChar,200),
					new SqlParameter("@ExtCondition", SqlDbType.VarChar,200),
					new SqlParameter("@AscString", SqlDbType.VarChar,50),
					new SqlParameter("@GridViewWidth", SqlDbType.Int,4),
					new SqlParameter("@ExportType", SqlDbType.VarChar,50),
					new SqlParameter("@ShowHeader", SqlDbType.Bit,1),
					new SqlParameter("@SplitChar", SqlDbType.VarChar,50),
					new SqlParameter("@CreateDbfSql", SqlDbType.VarChar,2000),
					new SqlParameter("@DbfFileName", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@EndDateCondition", SqlDbType.VarChar,200),
					new SqlParameter("@ShowOtherHeader", SqlDbType.NVarChar,4000),
					new SqlParameter("@ExportCols", SqlDbType.NVarChar,4000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.StrSql;
			parameters[2].Value = model.ShowDeptCondition;
			parameters[3].Value = model.InfoCondition;
			parameters[4].Value = model.DateCondition;
			parameters[5].Value = model.ExtCondition;
			parameters[6].Value = model.AscString;
			parameters[7].Value = model.GridViewWidth;
			parameters[8].Value = model.ExportType;
			parameters[9].Value = model.ShowHeader;
			parameters[10].Value = model.SplitChar;
			parameters[11].Value = model.CreateDbfSql;
			parameters[12].Value = model.DbfFileName;
			parameters[13].Value = model.Remark;
			parameters[14].Value = model.EndDateCondition;
			parameters[15].Value = model.ShowOtherHeader;
			parameters[16].Value = model.ExportCols;
			parameters[17].Value = model.ID;

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
			strSql.Append("delete from DataExportCodeInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)			};
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
			strSql.Append("delete from DataExportCodeInfo ");
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
		public WebDemo.Model.WebDemo.DataExportCodeInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Name,StrSql,ShowDeptCondition,InfoCondition,DateCondition,ExtCondition,AscString,GridViewWidth,ExportType,ShowHeader,SplitChar,CreateDbfSql,DbfFileName,Remark,EndDateCondition,ShowOtherHeader,ExportCols from DataExportCodeInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.DataExportCodeInfo model=new WebDemo.Model.WebDemo.DataExportCodeInfo();
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
		public WebDemo.Model.WebDemo.DataExportCodeInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.DataExportCodeInfo model=new WebDemo.Model.WebDemo.DataExportCodeInfo();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["StrSql"]!=null)
				{
					model.StrSql=row["StrSql"].ToString();
				}
				if(row["ShowDeptCondition"]!=null && row["ShowDeptCondition"].ToString()!="")
				{
					if((row["ShowDeptCondition"].ToString()=="1")||(row["ShowDeptCondition"].ToString().ToLower()=="true"))
					{
						model.ShowDeptCondition=true;
					}
					else
					{
						model.ShowDeptCondition=false;
					}
				}
				if(row["InfoCondition"]!=null)
				{
					model.InfoCondition=row["InfoCondition"].ToString();
				}
				if(row["DateCondition"]!=null)
				{
					model.DateCondition=row["DateCondition"].ToString();
				}
				if(row["ExtCondition"]!=null)
				{
					model.ExtCondition=row["ExtCondition"].ToString();
				}
				if(row["AscString"]!=null)
				{
					model.AscString=row["AscString"].ToString();
				}
				if(row["GridViewWidth"]!=null && row["GridViewWidth"].ToString()!="")
				{
					model.GridViewWidth=int.Parse(row["GridViewWidth"].ToString());
				}
				if(row["ExportType"]!=null)
				{
					model.ExportType=row["ExportType"].ToString();
				}
				if(row["ShowHeader"]!=null && row["ShowHeader"].ToString()!="")
				{
					if((row["ShowHeader"].ToString()=="1")||(row["ShowHeader"].ToString().ToLower()=="true"))
					{
						model.ShowHeader=true;
					}
					else
					{
						model.ShowHeader=false;
					}
				}
				if(row["SplitChar"]!=null)
				{
					model.SplitChar=row["SplitChar"].ToString();
				}
				if(row["CreateDbfSql"]!=null)
				{
					model.CreateDbfSql=row["CreateDbfSql"].ToString();
				}
				if(row["DbfFileName"]!=null)
				{
					model.DbfFileName=row["DbfFileName"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["EndDateCondition"]!=null)
				{
					model.EndDateCondition=row["EndDateCondition"].ToString();
				}
				if(row["ShowOtherHeader"]!=null)
				{
					model.ShowOtherHeader=row["ShowOtherHeader"].ToString();
				}
				if(row["ExportCols"]!=null)
				{
					model.ExportCols=row["ExportCols"].ToString();
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
			strSql.Append("select ID,Name,StrSql,ShowDeptCondition,InfoCondition,DateCondition,ExtCondition,AscString,GridViewWidth,ExportType,ShowHeader,SplitChar,CreateDbfSql,DbfFileName,Remark,EndDateCondition,ShowOtherHeader,ExportCols ");
			strSql.Append(" FROM DataExportCodeInfo ");
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
			strSql.Append(" ID,Name,StrSql,ShowDeptCondition,InfoCondition,DateCondition,ExtCondition,AscString,GridViewWidth,ExportType,ShowHeader,SplitChar,CreateDbfSql,DbfFileName,Remark,EndDateCondition,ShowOtherHeader,ExportCols ");
			strSql.Append(" FROM DataExportCodeInfo ");
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
			strSql.Append("select count(1) FROM DataExportCodeInfo ");
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
			strSql.Append(")AS Row, T.*  from DataExportCodeInfo T ");
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
			parameters[0].Value = "DataExportCodeInfo";
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

