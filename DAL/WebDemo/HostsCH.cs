using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:HostsCH
	/// </summary>
	public partial class HostsCH
	{
		public HostsCH()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.HostsCH model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HostsCH(");
			strSql.Append("HostID,ChNo,FactCode,DataID,ChBand,ChBtyeType)");
			strSql.Append(" values (");
			strSql.Append("@HostID,@ChNo,@FactCode,@DataID,@ChBand,@ChBtyeType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@HostID", SqlDbType.Int,4),
					new SqlParameter("@ChNo", SqlDbType.Int,4),
					new SqlParameter("@FactCode", SqlDbType.VarChar,8),
					new SqlParameter("@DataID", SqlDbType.VarChar,8),
					new SqlParameter("@ChBand", SqlDbType.Int,4),
					new SqlParameter("@ChBtyeType", SqlDbType.VarChar,2)};
			parameters[0].Value = model.HostID;
			parameters[1].Value = model.ChNo;
			parameters[2].Value = model.FactCode;
			parameters[3].Value = model.DataID;
			parameters[4].Value = model.ChBand;
			parameters[5].Value = model.ChBtyeType;

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
		public bool Update(WebDemo.Model.WebDemo.HostsCH model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HostsCH set ");
			strSql.Append("HostID=@HostID,");
			strSql.Append("ChNo=@ChNo,");
			strSql.Append("FactCode=@FactCode,");
			strSql.Append("DataID=@DataID,");
			strSql.Append("ChBand=@ChBand,");
			strSql.Append("ChBtyeType=@ChBtyeType");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@HostID", SqlDbType.Int,4),
					new SqlParameter("@ChNo", SqlDbType.Int,4),
					new SqlParameter("@FactCode", SqlDbType.VarChar,8),
					new SqlParameter("@DataID", SqlDbType.VarChar,8),
					new SqlParameter("@ChBand", SqlDbType.Int,4),
					new SqlParameter("@ChBtyeType", SqlDbType.VarChar,2),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.HostID;
			parameters[1].Value = model.ChNo;
			parameters[2].Value = model.FactCode;
			parameters[3].Value = model.DataID;
			parameters[4].Value = model.ChBand;
			parameters[5].Value = model.ChBtyeType;
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
			strSql.Append("delete from HostsCH ");
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
			strSql.Append("delete from HostsCH ");
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
		public WebDemo.Model.WebDemo.HostsCH GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,HostID,ChNo,FactCode,DataID,ChBand,ChBtyeType from HostsCH ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.HostsCH model=new WebDemo.Model.WebDemo.HostsCH();
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
		public WebDemo.Model.WebDemo.HostsCH DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.HostsCH model=new WebDemo.Model.WebDemo.HostsCH();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["HostID"]!=null && row["HostID"].ToString()!="")
				{
					model.HostID=int.Parse(row["HostID"].ToString());
				}
				if(row["ChNo"]!=null && row["ChNo"].ToString()!="")
				{
					model.ChNo=int.Parse(row["ChNo"].ToString());
				}
				if(row["FactCode"]!=null)
				{
					model.FactCode=row["FactCode"].ToString();
				}
				if(row["DataID"]!=null)
				{
					model.DataID=row["DataID"].ToString();
				}
				if(row["ChBand"]!=null && row["ChBand"].ToString()!="")
				{
					model.ChBand=int.Parse(row["ChBand"].ToString());
				}
				if(row["ChBtyeType"]!=null)
				{
					model.ChBtyeType=row["ChBtyeType"].ToString();
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
			strSql.Append("select ID,HostID,ChNo,FactCode,DataID,ChBand,ChBtyeType ");
			strSql.Append(" FROM HostsCH ");
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
			strSql.Append(" ID,HostID,ChNo,FactCode,DataID,ChBand,ChBtyeType ");
			strSql.Append(" FROM HostsCH ");
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
			strSql.Append("select count(1) FROM HostsCH ");
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
			strSql.Append(")AS Row, T.*  from HostsCH T ");
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
			parameters[0].Value = "HostsCH";
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

