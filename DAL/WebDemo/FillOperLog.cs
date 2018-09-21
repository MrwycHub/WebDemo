using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:FillOperLog
	/// </summary>
	public partial class FillOperLog
	{
		public FillOperLog()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.FillOperLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FillOperLog(");
			strSql.Append("OperID,OperType,OperDate,OperFlag,OperInfo,OperatorID)");
			strSql.Append(" values (");
			strSql.Append("@OperID,@OperType,@OperDate,@OperFlag,@OperInfo,@OperatorID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@OperType", SqlDbType.VarChar,50),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperFlag", SqlDbType.Int,4),
					new SqlParameter("@OperInfo", SqlDbType.VarChar,1000),
					new SqlParameter("@OperatorID", SqlDbType.Int,4)};
			parameters[0].Value = model.OperID;
			parameters[1].Value = model.OperType;
			parameters[2].Value = model.OperDate;
			parameters[3].Value = model.OperFlag;
			parameters[4].Value = model.OperInfo;
			parameters[5].Value = model.OperatorID;

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
		public bool Update(WebDemo.Model.WebDemo.FillOperLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FillOperLog set ");
			strSql.Append("OperID=@OperID,");
			strSql.Append("OperType=@OperType,");
			strSql.Append("OperDate=@OperDate,");
			strSql.Append("OperFlag=@OperFlag,");
			strSql.Append("OperInfo=@OperInfo,");
			strSql.Append("OperatorID=@OperatorID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@OperType", SqlDbType.VarChar,50),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperFlag", SqlDbType.Int,4),
					new SqlParameter("@OperInfo", SqlDbType.VarChar,1000),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.OperID;
			parameters[1].Value = model.OperType;
			parameters[2].Value = model.OperDate;
			parameters[3].Value = model.OperFlag;
			parameters[4].Value = model.OperInfo;
			parameters[5].Value = model.OperatorID;
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
			strSql.Append("delete from FillOperLog ");
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
			strSql.Append("delete from FillOperLog ");
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
		public WebDemo.Model.WebDemo.FillOperLog GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,OperID,OperType,OperDate,OperFlag,OperInfo,OperatorID from FillOperLog ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.FillOperLog model=new WebDemo.Model.WebDemo.FillOperLog();
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
		public WebDemo.Model.WebDemo.FillOperLog DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.FillOperLog model=new WebDemo.Model.WebDemo.FillOperLog();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
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
				if(row["OperFlag"]!=null && row["OperFlag"].ToString()!="")
				{
					model.OperFlag=int.Parse(row["OperFlag"].ToString());
				}
				if(row["OperInfo"]!=null)
				{
					model.OperInfo=row["OperInfo"].ToString();
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
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
			strSql.Append("select ID,OperID,OperType,OperDate,OperFlag,OperInfo,OperatorID ");
			strSql.Append(" FROM FillOperLog ");
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
			strSql.Append(" ID,OperID,OperType,OperDate,OperFlag,OperInfo,OperatorID ");
			strSql.Append(" FROM FillOperLog ");
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
			strSql.Append("select count(1) FROM FillOperLog ");
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
			strSql.Append(")AS Row, T.*  from FillOperLog T ");
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
			parameters[0].Value = "FillOperLog";
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

