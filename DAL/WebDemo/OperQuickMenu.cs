using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:OperQuickMenu
	/// </summary>
	public partial class OperQuickMenu
	{
		public OperQuickMenu()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("OperatorID", "OperQuickMenu"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OperatorID,int MenuID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OperQuickMenu");
			strSql.Append(" where OperatorID=@OperatorID and MenuID=@MenuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@MenuID", SqlDbType.Int,4)			};
			parameters[0].Value = OperatorID;
			parameters[1].Value = MenuID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.OperQuickMenu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OperQuickMenu(");
			strSql.Append("OperatorID,MenuID,OrderNo,QuickMenuNum)");
			strSql.Append(" values (");
			strSql.Append("@OperatorID,@MenuID,@OrderNo,@QuickMenuNum)");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@MenuID", SqlDbType.Int,4),
					new SqlParameter("@OrderNo", SqlDbType.Int,4),
					new SqlParameter("@QuickMenuNum", SqlDbType.Int,4)};
			parameters[0].Value = model.OperatorID;
			parameters[1].Value = model.MenuID;
			parameters[2].Value = model.OrderNo;
			parameters[3].Value = model.QuickMenuNum;

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
		public bool Update(WebDemo.Model.WebDemo.OperQuickMenu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OperQuickMenu set ");
			strSql.Append("OrderNo=@OrderNo,");
			strSql.Append("QuickMenuNum=@QuickMenuNum");
			strSql.Append(" where OperatorID=@OperatorID and MenuID=@MenuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OrderNo", SqlDbType.Int,4),
					new SqlParameter("@QuickMenuNum", SqlDbType.Int,4),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@MenuID", SqlDbType.Int,4)};
			parameters[0].Value = model.OrderNo;
			parameters[1].Value = model.QuickMenuNum;
			parameters[2].Value = model.OperatorID;
			parameters[3].Value = model.MenuID;

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
		public bool Delete(int OperatorID,int MenuID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OperQuickMenu ");
			strSql.Append(" where OperatorID=@OperatorID and MenuID=@MenuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@MenuID", SqlDbType.Int,4)			};
			parameters[0].Value = OperatorID;
			parameters[1].Value = MenuID;

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
		public WebDemo.Model.WebDemo.OperQuickMenu GetModel(int OperatorID,int MenuID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OperatorID,MenuID,OrderNo,QuickMenuNum from OperQuickMenu ");
			strSql.Append(" where OperatorID=@OperatorID and MenuID=@MenuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@MenuID", SqlDbType.Int,4)			};
			parameters[0].Value = OperatorID;
			parameters[1].Value = MenuID;

			WebDemo.Model.WebDemo.OperQuickMenu model=new WebDemo.Model.WebDemo.OperQuickMenu();
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
		public WebDemo.Model.WebDemo.OperQuickMenu DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.OperQuickMenu model=new WebDemo.Model.WebDemo.OperQuickMenu();
			if (row != null)
			{
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["MenuID"]!=null && row["MenuID"].ToString()!="")
				{
					model.MenuID=int.Parse(row["MenuID"].ToString());
				}
				if(row["OrderNo"]!=null && row["OrderNo"].ToString()!="")
				{
					model.OrderNo=int.Parse(row["OrderNo"].ToString());
				}
				if(row["QuickMenuNum"]!=null && row["QuickMenuNum"].ToString()!="")
				{
					model.QuickMenuNum=int.Parse(row["QuickMenuNum"].ToString());
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
			strSql.Append("select OperatorID,MenuID,OrderNo,QuickMenuNum ");
			strSql.Append(" FROM OperQuickMenu ");
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
			strSql.Append(" OperatorID,MenuID,OrderNo,QuickMenuNum ");
			strSql.Append(" FROM OperQuickMenu ");
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
			strSql.Append("select count(1) FROM OperQuickMenu ");
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
				strSql.Append("order by T.MenuID desc");
			}
			strSql.Append(")AS Row, T.*  from OperQuickMenu T ");
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
			parameters[0].Value = "OperQuickMenu";
			parameters[1].Value = "MenuID";
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

