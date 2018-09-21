using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:ActivityValveInfo
	/// </summary>
	public partial class ActivityValveInfo
	{
		public ActivityValveInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeterID", "ActivityValveInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeterID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ActivityValveInfo");
			strSql.Append(" where MeterID=@MeterID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.ActivityValveInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ActivityValveInfo(");
			strSql.Append("MeterID,ValveStatusBefore,ValveStatusAfter,OperTime,OperFlag)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@ValveStatusBefore,@ValveStatusAfter,@OperTime,@OperFlag)");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@ValveStatusBefore", SqlDbType.Int,4),
					new SqlParameter("@ValveStatusAfter", SqlDbType.Int,4),
					new SqlParameter("@OperTime", SqlDbType.DateTime),
					new SqlParameter("@OperFlag", SqlDbType.VarChar,20)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.ValveStatusBefore;
			parameters[2].Value = model.ValveStatusAfter;
			parameters[3].Value = model.OperTime;
			parameters[4].Value = model.OperFlag;

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
		public bool Update(WebDemo.Model.WebDemo.ActivityValveInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ActivityValveInfo set ");
			strSql.Append("ValveStatusBefore=@ValveStatusBefore,");
			strSql.Append("ValveStatusAfter=@ValveStatusAfter,");
			strSql.Append("OperTime=@OperTime,");
			strSql.Append("OperFlag=@OperFlag");
			strSql.Append(" where MeterID=@MeterID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ValveStatusBefore", SqlDbType.Int,4),
					new SqlParameter("@ValveStatusAfter", SqlDbType.Int,4),
					new SqlParameter("@OperTime", SqlDbType.DateTime),
					new SqlParameter("@OperFlag", SqlDbType.VarChar,20),
					new SqlParameter("@MeterID", SqlDbType.Int,4)};
			parameters[0].Value = model.ValveStatusBefore;
			parameters[1].Value = model.ValveStatusAfter;
			parameters[2].Value = model.OperTime;
			parameters[3].Value = model.OperFlag;
			parameters[4].Value = model.MeterID;

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
		public bool Delete(int MeterID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ActivityValveInfo ");
			strSql.Append(" where MeterID=@MeterID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;

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
		public bool DeleteList(string MeterIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ActivityValveInfo ");
			strSql.Append(" where MeterID in ("+MeterIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.ActivityValveInfo GetModel(int MeterID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MeterID,ValveStatusBefore,ValveStatusAfter,OperTime,OperFlag from ActivityValveInfo ");
			strSql.Append(" where MeterID=@MeterID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;

			WebDemo.Model.WebDemo.ActivityValveInfo model=new WebDemo.Model.WebDemo.ActivityValveInfo();
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
		public WebDemo.Model.WebDemo.ActivityValveInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.ActivityValveInfo model=new WebDemo.Model.WebDemo.ActivityValveInfo();
			if (row != null)
			{
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["ValveStatusBefore"]!=null && row["ValveStatusBefore"].ToString()!="")
				{
					model.ValveStatusBefore=int.Parse(row["ValveStatusBefore"].ToString());
				}
				if(row["ValveStatusAfter"]!=null && row["ValveStatusAfter"].ToString()!="")
				{
					model.ValveStatusAfter=int.Parse(row["ValveStatusAfter"].ToString());
				}
				if(row["OperTime"]!=null && row["OperTime"].ToString()!="")
				{
					model.OperTime=DateTime.Parse(row["OperTime"].ToString());
				}
				if(row["OperFlag"]!=null)
				{
					model.OperFlag=row["OperFlag"].ToString();
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
			strSql.Append("select MeterID,ValveStatusBefore,ValveStatusAfter,OperTime,OperFlag ");
			strSql.Append(" FROM ActivityValveInfo ");
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
			strSql.Append(" MeterID,ValveStatusBefore,ValveStatusAfter,OperTime,OperFlag ");
			strSql.Append(" FROM ActivityValveInfo ");
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
			strSql.Append("select count(1) FROM ActivityValveInfo ");
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
				strSql.Append("order by T.MeterID desc");
			}
			strSql.Append(")AS Row, T.*  from ActivityValveInfo T ");
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
			parameters[0].Value = "ActivityValveInfo";
			parameters[1].Value = "MeterID";
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

