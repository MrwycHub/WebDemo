using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Menus
	/// </summary>
	public partial class Menus
	{
		public Menus()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MenuID", "Menus"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MenuID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Menus");
			strSql.Append(" where MenuID=@MenuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.Int,4)			};
			parameters[0].Value = MenuID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.Menus model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Menus(");
			strSql.Append("MenuID,UpperID,MenuName,UrlAddr,UrlTarget,ImageUrl,Flag,Ordernum,SystemNum,PayType,ReMark,PayTypeBak)");
			strSql.Append(" values (");
			strSql.Append("@MenuID,@UpperID,@MenuName,@UrlAddr,@UrlTarget,@ImageUrl,@Flag,@Ordernum,@SystemNum,@PayType,@ReMark,@PayTypeBak)");
			SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.Int,4),
					new SqlParameter("@UpperID", SqlDbType.Int,4),
					new SqlParameter("@MenuName", SqlDbType.VarChar,50),
					new SqlParameter("@UrlAddr", SqlDbType.VarChar,200),
					new SqlParameter("@UrlTarget", SqlDbType.VarChar,50),
					new SqlParameter("@ImageUrl", SqlDbType.VarChar,50),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@Ordernum", SqlDbType.Int,4),
					new SqlParameter("@SystemNum", SqlDbType.Int,4),
					new SqlParameter("@PayType", SqlDbType.VarChar,50),
					new SqlParameter("@ReMark", SqlDbType.VarChar,50),
					new SqlParameter("@PayTypeBak", SqlDbType.VarChar,50)};
			parameters[0].Value = model.MenuID;
			parameters[1].Value = model.UpperID;
			parameters[2].Value = model.MenuName;
			parameters[3].Value = model.UrlAddr;
			parameters[4].Value = model.UrlTarget;
			parameters[5].Value = model.ImageUrl;
			parameters[6].Value = model.Flag;
			parameters[7].Value = model.Ordernum;
			parameters[8].Value = model.SystemNum;
			parameters[9].Value = model.PayType;
			parameters[10].Value = model.ReMark;
			parameters[11].Value = model.PayTypeBak;

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
		public bool Update(WebDemo.Model.WebDemo.Menus model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Menus set ");
			strSql.Append("UpperID=@UpperID,");
			strSql.Append("MenuName=@MenuName,");
			strSql.Append("UrlAddr=@UrlAddr,");
			strSql.Append("UrlTarget=@UrlTarget,");
			strSql.Append("ImageUrl=@ImageUrl,");
			strSql.Append("Flag=@Flag,");
			strSql.Append("Ordernum=@Ordernum,");
			strSql.Append("SystemNum=@SystemNum,");
			strSql.Append("PayType=@PayType,");
			strSql.Append("ReMark=@ReMark,");
			strSql.Append("PayTypeBak=@PayTypeBak");
			strSql.Append(" where MenuID=@MenuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UpperID", SqlDbType.Int,4),
					new SqlParameter("@MenuName", SqlDbType.VarChar,50),
					new SqlParameter("@UrlAddr", SqlDbType.VarChar,200),
					new SqlParameter("@UrlTarget", SqlDbType.VarChar,50),
					new SqlParameter("@ImageUrl", SqlDbType.VarChar,50),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@Ordernum", SqlDbType.Int,4),
					new SqlParameter("@SystemNum", SqlDbType.Int,4),
					new SqlParameter("@PayType", SqlDbType.VarChar,50),
					new SqlParameter("@ReMark", SqlDbType.VarChar,50),
					new SqlParameter("@PayTypeBak", SqlDbType.VarChar,50),
					new SqlParameter("@MenuID", SqlDbType.Int,4)};
			parameters[0].Value = model.UpperID;
			parameters[1].Value = model.MenuName;
			parameters[2].Value = model.UrlAddr;
			parameters[3].Value = model.UrlTarget;
			parameters[4].Value = model.ImageUrl;
			parameters[5].Value = model.Flag;
			parameters[6].Value = model.Ordernum;
			parameters[7].Value = model.SystemNum;
			parameters[8].Value = model.PayType;
			parameters[9].Value = model.ReMark;
			parameters[10].Value = model.PayTypeBak;
			parameters[11].Value = model.MenuID;

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
		public bool Delete(int MenuID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Menus ");
			strSql.Append(" where MenuID=@MenuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.Int,4)			};
			parameters[0].Value = MenuID;

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
		public bool DeleteList(string MenuIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Menus ");
			strSql.Append(" where MenuID in ("+MenuIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.Menus GetModel(int MenuID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MenuID,UpperID,MenuName,UrlAddr,UrlTarget,ImageUrl,Flag,Ordernum,SystemNum,PayType,ReMark,PayTypeBak from Menus ");
			strSql.Append(" where MenuID=@MenuID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MenuID", SqlDbType.Int,4)			};
			parameters[0].Value = MenuID;

			WebDemo.Model.WebDemo.Menus model=new WebDemo.Model.WebDemo.Menus();
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
		public WebDemo.Model.WebDemo.Menus DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Menus model=new WebDemo.Model.WebDemo.Menus();
			if (row != null)
			{
				if(row["MenuID"]!=null && row["MenuID"].ToString()!="")
				{
					model.MenuID=int.Parse(row["MenuID"].ToString());
				}
				if(row["UpperID"]!=null && row["UpperID"].ToString()!="")
				{
					model.UpperID=int.Parse(row["UpperID"].ToString());
				}
				if(row["MenuName"]!=null)
				{
					model.MenuName=row["MenuName"].ToString();
				}
				if(row["UrlAddr"]!=null)
				{
					model.UrlAddr=row["UrlAddr"].ToString();
				}
				if(row["UrlTarget"]!=null)
				{
					model.UrlTarget=row["UrlTarget"].ToString();
				}
				if(row["ImageUrl"]!=null)
				{
					model.ImageUrl=row["ImageUrl"].ToString();
				}
				if(row["Flag"]!=null && row["Flag"].ToString()!="")
				{
					model.Flag=int.Parse(row["Flag"].ToString());
				}
				if(row["Ordernum"]!=null && row["Ordernum"].ToString()!="")
				{
					model.Ordernum=int.Parse(row["Ordernum"].ToString());
				}
				if(row["SystemNum"]!=null && row["SystemNum"].ToString()!="")
				{
					model.SystemNum=int.Parse(row["SystemNum"].ToString());
				}
				if(row["PayType"]!=null)
				{
					model.PayType=row["PayType"].ToString();
				}
				if(row["ReMark"]!=null)
				{
					model.ReMark=row["ReMark"].ToString();
				}
				if(row["PayTypeBak"]!=null)
				{
					model.PayTypeBak=row["PayTypeBak"].ToString();
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
			strSql.Append("select MenuID,UpperID,MenuName,UrlAddr,UrlTarget,ImageUrl,Flag,Ordernum,SystemNum,PayType,ReMark,PayTypeBak ");
			strSql.Append(" FROM Menus ");
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
			strSql.Append(" MenuID,UpperID,MenuName,UrlAddr,UrlTarget,ImageUrl,Flag,Ordernum,SystemNum,PayType,ReMark,PayTypeBak ");
			strSql.Append(" FROM Menus ");
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
			strSql.Append("select count(1) FROM Menus ");
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
			strSql.Append(")AS Row, T.*  from Menus T ");
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
			parameters[0].Value = "Menus";
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

