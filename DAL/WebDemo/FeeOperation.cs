using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:FeeOperation
	/// </summary>
	public partial class FeeOperation
	{
		public FeeOperation()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("FID", "FeeOperation"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int FID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FeeOperation");
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
		public int Add(WebDemo.Model.WebDemo.FeeOperation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FeeOperation(");
			strSql.Append("UsersID,FareID,Fee,FactFee,OperDate,OperatorID,SiteID)");
			strSql.Append(" values (");
			strSql.Append("@UsersID,@FareID,@Fee,@FactFee,@OperDate,@OperatorID,@SiteID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@FareID", SqlDbType.Int,4),
					new SqlParameter("@Fee", SqlDbType.Decimal,9),
					new SqlParameter("@FactFee", SqlDbType.Decimal,9),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4)};
			parameters[0].Value = model.UsersID;
			parameters[1].Value = model.FareID;
			parameters[2].Value = model.Fee;
			parameters[3].Value = model.FactFee;
			parameters[4].Value = model.OperDate;
			parameters[5].Value = model.OperatorID;
			parameters[6].Value = model.SiteID;

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
		public bool Update(WebDemo.Model.WebDemo.FeeOperation model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FeeOperation set ");
			strSql.Append("UsersID=@UsersID,");
			strSql.Append("FareID=@FareID,");
			strSql.Append("Fee=@Fee,");
			strSql.Append("FactFee=@FactFee,");
			strSql.Append("OperDate=@OperDate,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("SiteID=@SiteID");
			strSql.Append(" where FID=@FID");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@FareID", SqlDbType.Int,4),
					new SqlParameter("@Fee", SqlDbType.Decimal,9),
					new SqlParameter("@FactFee", SqlDbType.Decimal,9),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@FID", SqlDbType.Int,4)};
			parameters[0].Value = model.UsersID;
			parameters[1].Value = model.FareID;
			parameters[2].Value = model.Fee;
			parameters[3].Value = model.FactFee;
			parameters[4].Value = model.OperDate;
			parameters[5].Value = model.OperatorID;
			parameters[6].Value = model.SiteID;
			parameters[7].Value = model.FID;

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
			strSql.Append("delete from FeeOperation ");
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
			strSql.Append("delete from FeeOperation ");
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
		public WebDemo.Model.WebDemo.FeeOperation GetModel(int FID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 FID,UsersID,FareID,Fee,FactFee,OperDate,OperatorID,SiteID from FeeOperation ");
			strSql.Append(" where FID=@FID");
			SqlParameter[] parameters = {
					new SqlParameter("@FID", SqlDbType.Int,4)
			};
			parameters[0].Value = FID;

			WebDemo.Model.WebDemo.FeeOperation model=new WebDemo.Model.WebDemo.FeeOperation();
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
		public WebDemo.Model.WebDemo.FeeOperation DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.FeeOperation model=new WebDemo.Model.WebDemo.FeeOperation();
			if (row != null)
			{
				if(row["FID"]!=null && row["FID"].ToString()!="")
				{
					model.FID=int.Parse(row["FID"].ToString());
				}
				if(row["UsersID"]!=null && row["UsersID"].ToString()!="")
				{
					model.UsersID=int.Parse(row["UsersID"].ToString());
				}
				if(row["FareID"]!=null && row["FareID"].ToString()!="")
				{
					model.FareID=int.Parse(row["FareID"].ToString());
				}
				if(row["Fee"]!=null && row["Fee"].ToString()!="")
				{
					model.Fee=decimal.Parse(row["Fee"].ToString());
				}
				if(row["FactFee"]!=null && row["FactFee"].ToString()!="")
				{
					model.FactFee=decimal.Parse(row["FactFee"].ToString());
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select FID,UsersID,FareID,Fee,FactFee,OperDate,OperatorID,SiteID ");
			strSql.Append(" FROM FeeOperation ");
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
			strSql.Append(" FID,UsersID,FareID,Fee,FactFee,OperDate,OperatorID,SiteID ");
			strSql.Append(" FROM FeeOperation ");
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
			strSql.Append("select count(1) FROM FeeOperation ");
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
			strSql.Append(")AS Row, T.*  from FeeOperation T ");
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
			parameters[0].Value = "FeeOperation";
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

