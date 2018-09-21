using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:SwitchBookLog
	/// </summary>
	public partial class SwitchBookLog
	{
		public SwitchBookLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SwitchBookLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SwitchBookLog");
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
		public int Add(WebDemo.Model.WebDemo.SwitchBookLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SwitchBookLog(");
			strSql.Append("MeterID,BookIDBefore,BookNumBefore,BookIDAfter,BookNumAfter,OperTime)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@BookIDBefore,@BookNumBefore,@BookIDAfter,@BookNumAfter,@OperTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@BookIDBefore", SqlDbType.Int,4),
					new SqlParameter("@BookNumBefore", SqlDbType.Int,4),
					new SqlParameter("@BookIDAfter", SqlDbType.Int,4),
					new SqlParameter("@BookNumAfter", SqlDbType.Int,4),
					new SqlParameter("@OperTime", SqlDbType.DateTime)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.BookIDBefore;
			parameters[2].Value = model.BookNumBefore;
			parameters[3].Value = model.BookIDAfter;
			parameters[4].Value = model.BookNumAfter;
			parameters[5].Value = model.OperTime;

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
		public bool Update(WebDemo.Model.WebDemo.SwitchBookLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SwitchBookLog set ");
			strSql.Append("MeterID=@MeterID,");
			strSql.Append("BookIDBefore=@BookIDBefore,");
			strSql.Append("BookNumBefore=@BookNumBefore,");
			strSql.Append("BookIDAfter=@BookIDAfter,");
			strSql.Append("BookNumAfter=@BookNumAfter,");
			strSql.Append("OperTime=@OperTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@BookIDBefore", SqlDbType.Int,4),
					new SqlParameter("@BookNumBefore", SqlDbType.Int,4),
					new SqlParameter("@BookIDAfter", SqlDbType.Int,4),
					new SqlParameter("@BookNumAfter", SqlDbType.Int,4),
					new SqlParameter("@OperTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.BookIDBefore;
			parameters[2].Value = model.BookNumBefore;
			parameters[3].Value = model.BookIDAfter;
			parameters[4].Value = model.BookNumAfter;
			parameters[5].Value = model.OperTime;
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
			strSql.Append("delete from SwitchBookLog ");
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
			strSql.Append("delete from SwitchBookLog ");
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
		public WebDemo.Model.WebDemo.SwitchBookLog GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MeterID,BookIDBefore,BookNumBefore,BookIDAfter,BookNumAfter,OperTime from SwitchBookLog ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.SwitchBookLog model=new WebDemo.Model.WebDemo.SwitchBookLog();
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
		public WebDemo.Model.WebDemo.SwitchBookLog DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.SwitchBookLog model=new WebDemo.Model.WebDemo.SwitchBookLog();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["BookIDBefore"]!=null && row["BookIDBefore"].ToString()!="")
				{
					model.BookIDBefore=int.Parse(row["BookIDBefore"].ToString());
				}
				if(row["BookNumBefore"]!=null && row["BookNumBefore"].ToString()!="")
				{
					model.BookNumBefore=int.Parse(row["BookNumBefore"].ToString());
				}
				if(row["BookIDAfter"]!=null && row["BookIDAfter"].ToString()!="")
				{
					model.BookIDAfter=int.Parse(row["BookIDAfter"].ToString());
				}
				if(row["BookNumAfter"]!=null && row["BookNumAfter"].ToString()!="")
				{
					model.BookNumAfter=int.Parse(row["BookNumAfter"].ToString());
				}
				if(row["OperTime"]!=null && row["OperTime"].ToString()!="")
				{
					model.OperTime=DateTime.Parse(row["OperTime"].ToString());
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
			strSql.Append("select ID,MeterID,BookIDBefore,BookNumBefore,BookIDAfter,BookNumAfter,OperTime ");
			strSql.Append(" FROM SwitchBookLog ");
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
			strSql.Append(" ID,MeterID,BookIDBefore,BookNumBefore,BookIDAfter,BookNumAfter,OperTime ");
			strSql.Append(" FROM SwitchBookLog ");
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
			strSql.Append("select count(1) FROM SwitchBookLog ");
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
			strSql.Append(")AS Row, T.*  from SwitchBookLog T ");
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
			parameters[0].Value = "SwitchBookLog";
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

