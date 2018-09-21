using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Otherfare
	/// </summary>
	public partial class Otherfare
	{
		public Otherfare()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("OtherID", "Otherfare"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OtherID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Otherfare");
			strSql.Append(" where OtherID=@OtherID");
			SqlParameter[] parameters = {
					new SqlParameter("@OtherID", SqlDbType.Int,4)
			};
			parameters[0].Value = OtherID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.Otherfare model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Otherfare(");
			strSql.Append("MeterID,FareID,FareNum,Remark,Flag)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@FareID,@FareNum,@Remark,@Flag)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FareID", SqlDbType.Int,4),
					new SqlParameter("@FareNum", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@Flag", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.FareID;
			parameters[2].Value = model.FareNum;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.Flag;

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
		public bool Update(WebDemo.Model.WebDemo.Otherfare model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Otherfare set ");
			strSql.Append("MeterID=@MeterID,");
			strSql.Append("FareID=@FareID,");
			strSql.Append("FareNum=@FareNum,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Flag=@Flag");
			strSql.Append(" where OtherID=@OtherID");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FareID", SqlDbType.Int,4),
					new SqlParameter("@FareNum", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@OtherID", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.FareID;
			parameters[2].Value = model.FareNum;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.Flag;
			parameters[5].Value = model.OtherID;

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
		public bool Delete(int OtherID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Otherfare ");
			strSql.Append(" where OtherID=@OtherID");
			SqlParameter[] parameters = {
					new SqlParameter("@OtherID", SqlDbType.Int,4)
			};
			parameters[0].Value = OtherID;

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
		public bool DeleteList(string OtherIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Otherfare ");
			strSql.Append(" where OtherID in ("+OtherIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.Otherfare GetModel(int OtherID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OtherID,MeterID,FareID,FareNum,Remark,Flag from Otherfare ");
			strSql.Append(" where OtherID=@OtherID");
			SqlParameter[] parameters = {
					new SqlParameter("@OtherID", SqlDbType.Int,4)
			};
			parameters[0].Value = OtherID;

			WebDemo.Model.WebDemo.Otherfare model=new WebDemo.Model.WebDemo.Otherfare();
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
		public WebDemo.Model.WebDemo.Otherfare DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Otherfare model=new WebDemo.Model.WebDemo.Otherfare();
			if (row != null)
			{
				if(row["OtherID"]!=null && row["OtherID"].ToString()!="")
				{
					model.OtherID=int.Parse(row["OtherID"].ToString());
				}
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["FareID"]!=null && row["FareID"].ToString()!="")
				{
					model.FareID=int.Parse(row["FareID"].ToString());
				}
				if(row["FareNum"]!=null && row["FareNum"].ToString()!="")
				{
					model.FareNum=int.Parse(row["FareNum"].ToString());
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
			strSql.Append("select OtherID,MeterID,FareID,FareNum,Remark,Flag ");
			strSql.Append(" FROM Otherfare ");
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
			strSql.Append(" OtherID,MeterID,FareID,FareNum,Remark,Flag ");
			strSql.Append(" FROM Otherfare ");
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
			strSql.Append("select count(1) FROM Otherfare ");
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
				strSql.Append("order by T.OtherID desc");
			}
			strSql.Append(")AS Row, T.*  from Otherfare T ");
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
			parameters[0].Value = "Otherfare";
			parameters[1].Value = "OtherID";
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

