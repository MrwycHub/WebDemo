using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MeterStateDictionary
	/// </summary>
	public partial class MeterStateDictionary
	{
		public MeterStateDictionary()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("StateCode", "MeterStateDictionary"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int StateCode)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MeterStateDictionary");
			strSql.Append(" where StateCode=@StateCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@StateCode", SqlDbType.Int,4)			};
			parameters[0].Value = StateCode;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.MeterStateDictionary model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MeterStateDictionary(");
			strSql.Append("StateCode,StateName,Enable,IsShow,OrderNum,Reasion,Operation)");
			strSql.Append(" values (");
			strSql.Append("@StateCode,@StateName,@Enable,@IsShow,@OrderNum,@Reasion,@Operation)");
			SqlParameter[] parameters = {
					new SqlParameter("@StateCode", SqlDbType.Int,4),
					new SqlParameter("@StateName", SqlDbType.VarChar,50),
					new SqlParameter("@Enable", SqlDbType.Bit,1),
					new SqlParameter("@IsShow", SqlDbType.Bit,1),
					new SqlParameter("@OrderNum", SqlDbType.Int,4),
					new SqlParameter("@Reasion", SqlDbType.VarChar,500),
					new SqlParameter("@Operation", SqlDbType.VarChar,500)};
			parameters[0].Value = model.StateCode;
			parameters[1].Value = model.StateName;
			parameters[2].Value = model.Enable;
			parameters[3].Value = model.IsShow;
			parameters[4].Value = model.OrderNum;
			parameters[5].Value = model.Reasion;
			parameters[6].Value = model.Operation;

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
		public bool Update(WebDemo.Model.WebDemo.MeterStateDictionary model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MeterStateDictionary set ");
			strSql.Append("StateName=@StateName,");
			strSql.Append("Enable=@Enable,");
			strSql.Append("IsShow=@IsShow,");
			strSql.Append("OrderNum=@OrderNum,");
			strSql.Append("Reasion=@Reasion,");
			strSql.Append("Operation=@Operation");
			strSql.Append(" where StateCode=@StateCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@StateName", SqlDbType.VarChar,50),
					new SqlParameter("@Enable", SqlDbType.Bit,1),
					new SqlParameter("@IsShow", SqlDbType.Bit,1),
					new SqlParameter("@OrderNum", SqlDbType.Int,4),
					new SqlParameter("@Reasion", SqlDbType.VarChar,500),
					new SqlParameter("@Operation", SqlDbType.VarChar,500),
					new SqlParameter("@StateCode", SqlDbType.Int,4)};
			parameters[0].Value = model.StateName;
			parameters[1].Value = model.Enable;
			parameters[2].Value = model.IsShow;
			parameters[3].Value = model.OrderNum;
			parameters[4].Value = model.Reasion;
			parameters[5].Value = model.Operation;
			parameters[6].Value = model.StateCode;

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
		public bool Delete(int StateCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeterStateDictionary ");
			strSql.Append(" where StateCode=@StateCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@StateCode", SqlDbType.Int,4)			};
			parameters[0].Value = StateCode;

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
		public bool DeleteList(string StateCodelist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeterStateDictionary ");
			strSql.Append(" where StateCode in ("+StateCodelist + ")  ");
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
		public WebDemo.Model.WebDemo.MeterStateDictionary GetModel(int StateCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 StateCode,StateName,Enable,IsShow,OrderNum,Reasion,Operation from MeterStateDictionary ");
			strSql.Append(" where StateCode=@StateCode ");
			SqlParameter[] parameters = {
					new SqlParameter("@StateCode", SqlDbType.Int,4)			};
			parameters[0].Value = StateCode;

			WebDemo.Model.WebDemo.MeterStateDictionary model=new WebDemo.Model.WebDemo.MeterStateDictionary();
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
		public WebDemo.Model.WebDemo.MeterStateDictionary DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MeterStateDictionary model=new WebDemo.Model.WebDemo.MeterStateDictionary();
			if (row != null)
			{
				if(row["StateCode"]!=null && row["StateCode"].ToString()!="")
				{
					model.StateCode=int.Parse(row["StateCode"].ToString());
				}
				if(row["StateName"]!=null)
				{
					model.StateName=row["StateName"].ToString();
				}
				if(row["Enable"]!=null && row["Enable"].ToString()!="")
				{
					if((row["Enable"].ToString()=="1")||(row["Enable"].ToString().ToLower()=="true"))
					{
						model.Enable=true;
					}
					else
					{
						model.Enable=false;
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
				if(row["Reasion"]!=null)
				{
					model.Reasion=row["Reasion"].ToString();
				}
				if(row["Operation"]!=null)
				{
					model.Operation=row["Operation"].ToString();
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
			strSql.Append("select StateCode,StateName,Enable,IsShow,OrderNum,Reasion,Operation ");
			strSql.Append(" FROM MeterStateDictionary ");
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
			strSql.Append(" StateCode,StateName,Enable,IsShow,OrderNum,Reasion,Operation ");
			strSql.Append(" FROM MeterStateDictionary ");
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
			strSql.Append("select count(1) FROM MeterStateDictionary ");
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
			strSql.Append(")AS Row, T.*  from MeterStateDictionary T ");
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
			parameters[0].Value = "MeterStateDictionary";
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

