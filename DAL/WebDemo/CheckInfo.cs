using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:CheckInfo
	/// </summary>
	public partial class CheckInfo
	{
		public CheckInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FID", "CheckInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CheckInfo");
			strSql.Append(" where FID=@FID");
			SqlParameter[] parameters = {
					new SqlParameter("@FID", SqlDbType.Int,4)
			};
			parameters[0].Value = FID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.CheckInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CheckInfo(");
			strSql.Append("MeterID,CheckDate,CheckWorker,CheckInfo,CheckMark)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@CheckDate,@CheckWorker,@CheckInfo,@CheckMark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@CheckDate", SqlDbType.DateTime),
					new SqlParameter("@CheckWorker", SqlDbType.VarChar,50),
					new SqlParameter("@CheckInfo", SqlDbType.VarChar,50),
					new SqlParameter("@CheckMark", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.CheckDate;
			parameters[2].Value = model.CheckWorker;
			parameters[3].Value = model.CheckInfo;
			parameters[4].Value = model.CheckMark;

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
		public bool Update(WebDemo.Model.WebDemo.CheckInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CheckInfo set ");
			strSql.Append("MeterID=@MeterID,");
			strSql.Append("CheckDate=@CheckDate,");
			strSql.Append("CheckWorker=@CheckWorker,");
			strSql.Append("CheckInfo=@CheckInfo,");
			strSql.Append("CheckMark=@CheckMark");
			strSql.Append(" where FID=@FID");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@CheckDate", SqlDbType.DateTime),
					new SqlParameter("@CheckWorker", SqlDbType.VarChar,50),
					new SqlParameter("@CheckInfo", SqlDbType.VarChar,50),
					new SqlParameter("@CheckMark", SqlDbType.Int,4),
					new SqlParameter("@FID", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.CheckDate;
			parameters[2].Value = model.CheckWorker;
			parameters[3].Value = model.CheckInfo;
			parameters[4].Value = model.CheckMark;
			parameters[5].Value = model.FID;

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
		public bool Delete(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CheckInfo ");
			strSql.Append(" where FID=@FID");
			SqlParameter[] parameters = {
					new SqlParameter("@FID", SqlDbType.Int,4)
			};
			parameters[0].Value = FID;

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
		public bool DeleteList(string FIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CheckInfo ");
			strSql.Append(" where FID in ("+FIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.CheckInfo GetModel(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FID,MeterID,CheckDate,CheckWorker,CheckInfo,CheckMark from CheckInfo ");
			strSql.Append(" where FID=@FID");
			SqlParameter[] parameters = {
					new SqlParameter("@FID", SqlDbType.Int,4)
			};
			parameters[0].Value = FID;

			WebDemo.Model.WebDemo.CheckInfo model=new WebDemo.Model.WebDemo.CheckInfo();
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
		public WebDemo.Model.WebDemo.CheckInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.CheckInfo model=new WebDemo.Model.WebDemo.CheckInfo();
			if (row != null)
			{
				if(row["FID"]!=null && row["FID"].ToString()!="")
				{
					model.FID=int.Parse(row["FID"].ToString());
				}
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["CheckDate"]!=null && row["CheckDate"].ToString()!="")
				{
					model.CheckDate=DateTime.Parse(row["CheckDate"].ToString());
				}
				if(row["CheckWorker"]!=null)
				{
					model.CheckWorker=row["CheckWorker"].ToString();
				}
				if(row["CheckInfo"]!=null)
				{
					model.CheckInfo=row["CheckInfo"].ToString();
				}
				if(row["CheckMark"]!=null && row["CheckMark"].ToString()!="")
				{
					model.CheckMark=int.Parse(row["CheckMark"].ToString());
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
			strSql.Append("select FID,MeterID,CheckDate,CheckWorker,CheckInfo,CheckMark ");
			strSql.Append(" FROM CheckInfo ");
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
			strSql.Append(" FID,MeterID,CheckDate,CheckWorker,CheckInfo,CheckMark ");
			strSql.Append(" FROM CheckInfo ");
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
			strSql.Append("select count(1) FROM CheckInfo ");
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
				strSql.Append("order by T.FID desc");
			}
			strSql.Append(")AS Row, T.*  from CheckInfo T ");
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
			parameters[0].Value = "CheckInfo";
			parameters[1].Value = "FID";
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

