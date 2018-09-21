using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MeterCurrentState
	/// </summary>
	public partial class MeterCurrentState
	{
		public MeterCurrentState()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeterID", "MeterCurrentState"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeterID,int StateCode)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MeterCurrentState");
			strSql.Append(" where MeterID=@MeterID and StateCode=@StateCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@StateCode", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;
			parameters[1].Value = StateCode;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.MeterCurrentState model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MeterCurrentState(");
			strSql.Append("MeterID,StateCode,StateValue,StateInfo,UpdateTime)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@StateCode,@StateValue,@StateInfo,@UpdateTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@StateCode", SqlDbType.Int,4),
					new SqlParameter("@StateValue", SqlDbType.VarChar,50),
					new SqlParameter("@StateInfo", SqlDbType.VarChar,50),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.StateCode;
			parameters[2].Value = model.StateValue;
			parameters[3].Value = model.StateInfo;
			parameters[4].Value = model.UpdateTime;

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
		public bool Update(WebDemo.Model.WebDemo.MeterCurrentState model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MeterCurrentState set ");
			strSql.Append("StateValue=@StateValue,");
			strSql.Append("StateInfo=@StateInfo,");
			strSql.Append("UpdateTime=@UpdateTime");
			strSql.Append(" where MeterID=@MeterID and StateCode=@StateCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@StateValue", SqlDbType.VarChar,50),
					new SqlParameter("@StateInfo", SqlDbType.VarChar,50),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@StateCode", SqlDbType.Int,4)};
			parameters[0].Value = model.StateValue;
			parameters[1].Value = model.StateInfo;
			parameters[2].Value = model.UpdateTime;
			parameters[3].Value = model.MeterID;
			parameters[4].Value = model.StateCode;

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
		public bool Delete(int MeterID,int StateCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeterCurrentState ");
			strSql.Append(" where MeterID=@MeterID and StateCode=@StateCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@StateCode", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;
			parameters[1].Value = StateCode;

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
		public WebDemo.Model.WebDemo.MeterCurrentState GetModel(int MeterID,int StateCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MeterID,StateCode,StateValue,StateInfo,UpdateTime from MeterCurrentState ");
			strSql.Append(" where MeterID=@MeterID and StateCode=@StateCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@StateCode", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;
			parameters[1].Value = StateCode;

			WebDemo.Model.WebDemo.MeterCurrentState model=new WebDemo.Model.WebDemo.MeterCurrentState();
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
		public WebDemo.Model.WebDemo.MeterCurrentState DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MeterCurrentState model=new WebDemo.Model.WebDemo.MeterCurrentState();
			if (row != null)
			{
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["StateCode"]!=null && row["StateCode"].ToString()!="")
				{
					model.StateCode=int.Parse(row["StateCode"].ToString());
				}
				if(row["StateValue"]!=null)
				{
					model.StateValue=row["StateValue"].ToString();
				}
				if(row["StateInfo"]!=null)
				{
					model.StateInfo=row["StateInfo"].ToString();
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
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
			strSql.Append("select MeterID,StateCode,StateValue,StateInfo,UpdateTime ");
			strSql.Append(" FROM MeterCurrentState ");
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
			strSql.Append(" MeterID,StateCode,StateValue,StateInfo,UpdateTime ");
			strSql.Append(" FROM MeterCurrentState ");
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
			strSql.Append("select count(1) FROM MeterCurrentState ");
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
				strSql.Append("order by T.StateCode desc");
			}
			strSql.Append(")AS Row, T.*  from MeterCurrentState T ");
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
			parameters[0].Value = "MeterCurrentState";
			parameters[1].Value = "StateCode";
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

