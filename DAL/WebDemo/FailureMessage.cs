using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:FailureMessage
	/// </summary>
	public partial class FailureMessage
	{
		public FailureMessage()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "FailureMessage"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FailureMessage");
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
		public int Add(WebDemo.Model.WebDemo.FailureMessage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FailureMessage(");
			strSql.Append("FailID,Type,Flag,Name,UpLoadTime,Size,Pattern,Url,LocationX,LocationY)");
			strSql.Append(" values (");
			strSql.Append("@FailID,@Type,@Flag,@Name,@UpLoadTime,@Size,@Pattern,@Url,@LocationX,@LocationY)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FailID", SqlDbType.Int,4),
					new SqlParameter("@Type", SqlDbType.Int,4),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,100),
					new SqlParameter("@UpLoadTime", SqlDbType.DateTime),
					new SqlParameter("@Size", SqlDbType.VarChar,20),
					new SqlParameter("@Pattern", SqlDbType.VarChar,20),
					new SqlParameter("@Url", SqlDbType.VarChar,500),
					new SqlParameter("@LocationX", SqlDbType.Decimal,9),
					new SqlParameter("@LocationY", SqlDbType.Decimal,9)};
			parameters[0].Value = model.FailID;
			parameters[1].Value = model.Type;
			parameters[2].Value = model.Flag;
			parameters[3].Value = model.Name;
			parameters[4].Value = model.UpLoadTime;
			parameters[5].Value = model.Size;
			parameters[6].Value = model.Pattern;
			parameters[7].Value = model.Url;
			parameters[8].Value = model.LocationX;
			parameters[9].Value = model.LocationY;

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
		public bool Update(WebDemo.Model.WebDemo.FailureMessage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FailureMessage set ");
			strSql.Append("FailID=@FailID,");
			strSql.Append("Type=@Type,");
			strSql.Append("Flag=@Flag,");
			strSql.Append("Name=@Name,");
			strSql.Append("UpLoadTime=@UpLoadTime,");
			strSql.Append("Size=@Size,");
			strSql.Append("Pattern=@Pattern,");
			strSql.Append("Url=@Url,");
			strSql.Append("LocationX=@LocationX,");
			strSql.Append("LocationY=@LocationY");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FailID", SqlDbType.Int,4),
					new SqlParameter("@Type", SqlDbType.Int,4),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.VarChar,100),
					new SqlParameter("@UpLoadTime", SqlDbType.DateTime),
					new SqlParameter("@Size", SqlDbType.VarChar,20),
					new SqlParameter("@Pattern", SqlDbType.VarChar,20),
					new SqlParameter("@Url", SqlDbType.VarChar,500),
					new SqlParameter("@LocationX", SqlDbType.Decimal,9),
					new SqlParameter("@LocationY", SqlDbType.Decimal,9),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.FailID;
			parameters[1].Value = model.Type;
			parameters[2].Value = model.Flag;
			parameters[3].Value = model.Name;
			parameters[4].Value = model.UpLoadTime;
			parameters[5].Value = model.Size;
			parameters[6].Value = model.Pattern;
			parameters[7].Value = model.Url;
			parameters[8].Value = model.LocationX;
			parameters[9].Value = model.LocationY;
			parameters[10].Value = model.ID;

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
			strSql.Append("delete from FailureMessage ");
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
			strSql.Append("delete from FailureMessage ");
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
		public WebDemo.Model.WebDemo.FailureMessage GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,FailID,Type,Flag,Name,UpLoadTime,Size,Pattern,Url,LocationX,LocationY from FailureMessage ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.FailureMessage model=new WebDemo.Model.WebDemo.FailureMessage();
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
		public WebDemo.Model.WebDemo.FailureMessage DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.FailureMessage model=new WebDemo.Model.WebDemo.FailureMessage();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["FailID"]!=null && row["FailID"].ToString()!="")
				{
					model.FailID=int.Parse(row["FailID"].ToString());
				}
				if(row["Type"]!=null && row["Type"].ToString()!="")
				{
					model.Type=int.Parse(row["Type"].ToString());
				}
				if(row["Flag"]!=null && row["Flag"].ToString()!="")
				{
					model.Flag=int.Parse(row["Flag"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["UpLoadTime"]!=null && row["UpLoadTime"].ToString()!="")
				{
					model.UpLoadTime=DateTime.Parse(row["UpLoadTime"].ToString());
				}
				if(row["Size"]!=null)
				{
					model.Size=row["Size"].ToString();
				}
				if(row["Pattern"]!=null)
				{
					model.Pattern=row["Pattern"].ToString();
				}
				if(row["Url"]!=null)
				{
					model.Url=row["Url"].ToString();
				}
				if(row["LocationX"]!=null && row["LocationX"].ToString()!="")
				{
					model.LocationX=decimal.Parse(row["LocationX"].ToString());
				}
				if(row["LocationY"]!=null && row["LocationY"].ToString()!="")
				{
					model.LocationY=decimal.Parse(row["LocationY"].ToString());
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
			strSql.Append("select ID,FailID,Type,Flag,Name,UpLoadTime,Size,Pattern,Url,LocationX,LocationY ");
			strSql.Append(" FROM FailureMessage ");
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
			strSql.Append(" ID,FailID,Type,Flag,Name,UpLoadTime,Size,Pattern,Url,LocationX,LocationY ");
			strSql.Append(" FROM FailureMessage ");
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
			strSql.Append("select count(1) FROM FailureMessage ");
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
			strSql.Append(")AS Row, T.*  from FailureMessage T ");
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
			parameters[0].Value = "FailureMessage";
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

