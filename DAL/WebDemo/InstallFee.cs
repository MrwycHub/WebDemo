using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:InstallFee
	/// </summary>
	public partial class InstallFee
	{
		public InstallFee()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("InstallID", "InstallFee"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int InstallID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InstallFee");
			strSql.Append(" where InstallID=@InstallID");
			SqlParameter[] parameters = {
					new SqlParameter("@InstallID", SqlDbType.Int,4)
			};
			parameters[0].Value = InstallID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.InstallFee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InstallFee(");
			strSql.Append("UserNum,SingleFee,SumFee,OperDate,OperatorID,SiteID,Mark,InstallMark)");
			strSql.Append(" values (");
			strSql.Append("@UserNum,@SingleFee,@SumFee,@OperDate,@OperatorID,@SiteID,@Mark,@InstallMark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserNum", SqlDbType.Int,4),
					new SqlParameter("@SingleFee", SqlDbType.Decimal,9),
					new SqlParameter("@SumFee", SqlDbType.Decimal,9),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@InstallMark", SqlDbType.Int,4)};
			parameters[0].Value = model.UserNum;
			parameters[1].Value = model.SingleFee;
			parameters[2].Value = model.SumFee;
			parameters[3].Value = model.OperDate;
			parameters[4].Value = model.OperatorID;
			parameters[5].Value = model.SiteID;
			parameters[6].Value = model.Mark;
			parameters[7].Value = model.InstallMark;

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
		public bool Update(WebDemo.Model.WebDemo.InstallFee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InstallFee set ");
			strSql.Append("UserNum=@UserNum,");
			strSql.Append("SingleFee=@SingleFee,");
			strSql.Append("SumFee=@SumFee,");
			strSql.Append("OperDate=@OperDate,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("SiteID=@SiteID,");
			strSql.Append("Mark=@Mark,");
			strSql.Append("InstallMark=@InstallMark");
			strSql.Append(" where InstallID=@InstallID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserNum", SqlDbType.Int,4),
					new SqlParameter("@SingleFee", SqlDbType.Decimal,9),
					new SqlParameter("@SumFee", SqlDbType.Decimal,9),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@InstallMark", SqlDbType.Int,4),
					new SqlParameter("@InstallID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserNum;
			parameters[1].Value = model.SingleFee;
			parameters[2].Value = model.SumFee;
			parameters[3].Value = model.OperDate;
			parameters[4].Value = model.OperatorID;
			parameters[5].Value = model.SiteID;
			parameters[6].Value = model.Mark;
			parameters[7].Value = model.InstallMark;
			parameters[8].Value = model.InstallID;

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
		public bool Delete(int InstallID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InstallFee ");
			strSql.Append(" where InstallID=@InstallID");
			SqlParameter[] parameters = {
					new SqlParameter("@InstallID", SqlDbType.Int,4)
			};
			parameters[0].Value = InstallID;

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
		public bool DeleteList(string InstallIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InstallFee ");
			strSql.Append(" where InstallID in ("+InstallIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.InstallFee GetModel(int InstallID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 InstallID,UserNum,SingleFee,SumFee,OperDate,OperatorID,SiteID,Mark,InstallMark from InstallFee ");
			strSql.Append(" where InstallID=@InstallID");
			SqlParameter[] parameters = {
					new SqlParameter("@InstallID", SqlDbType.Int,4)
			};
			parameters[0].Value = InstallID;

			WebDemo.Model.WebDemo.InstallFee model=new WebDemo.Model.WebDemo.InstallFee();
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
		public WebDemo.Model.WebDemo.InstallFee DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.InstallFee model=new WebDemo.Model.WebDemo.InstallFee();
			if (row != null)
			{
				if(row["InstallID"]!=null && row["InstallID"].ToString()!="")
				{
					model.InstallID=int.Parse(row["InstallID"].ToString());
				}
				if(row["UserNum"]!=null && row["UserNum"].ToString()!="")
				{
					model.UserNum=int.Parse(row["UserNum"].ToString());
				}
				if(row["SingleFee"]!=null && row["SingleFee"].ToString()!="")
				{
					model.SingleFee=decimal.Parse(row["SingleFee"].ToString());
				}
				if(row["SumFee"]!=null && row["SumFee"].ToString()!="")
				{
					model.SumFee=decimal.Parse(row["SumFee"].ToString());
				}
				if(row["OperDate"]!=null && row["OperDate"].ToString()!="")
				{
					model.OperDate=DateTime.Parse(row["OperDate"].ToString());
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["SiteID"]!=null && row["SiteID"].ToString()!="")
				{
					model.SiteID=int.Parse(row["SiteID"].ToString());
				}
				if(row["Mark"]!=null && row["Mark"].ToString()!="")
				{
					model.Mark=int.Parse(row["Mark"].ToString());
				}
				if(row["InstallMark"]!=null && row["InstallMark"].ToString()!="")
				{
					model.InstallMark=int.Parse(row["InstallMark"].ToString());
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
			strSql.Append("select InstallID,UserNum,SingleFee,SumFee,OperDate,OperatorID,SiteID,Mark,InstallMark ");
			strSql.Append(" FROM InstallFee ");
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
			strSql.Append(" InstallID,UserNum,SingleFee,SumFee,OperDate,OperatorID,SiteID,Mark,InstallMark ");
			strSql.Append(" FROM InstallFee ");
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
			strSql.Append("select count(1) FROM InstallFee ");
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
				strSql.Append("order by T.InstallID desc");
			}
			strSql.Append(")AS Row, T.*  from InstallFee T ");
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
			parameters[0].Value = "InstallFee";
			parameters[1].Value = "InstallID";
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

