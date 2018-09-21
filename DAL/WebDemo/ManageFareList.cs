using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:ManageFareList
	/// </summary>
	public partial class ManageFareList
	{
		public ManageFareList()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.ManageFareList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ManageFareList(");
			strSql.Append("UsersID,ManageFareID,LastMonth,ThisMonth,ManageFarePrice,OperMoney,OperatorID,OperDate,Remark,OperID,OperType,RcvFareNum)");
			strSql.Append(" values (");
			strSql.Append("@UsersID,@ManageFareID,@LastMonth,@ThisMonth,@ManageFarePrice,@OperMoney,@OperatorID,@OperDate,@Remark,@OperID,@OperType,@RcvFareNum)");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@ManageFareID", SqlDbType.Int,4),
					new SqlParameter("@LastMonth", SqlDbType.VarChar,10),
					new SqlParameter("@ThisMonth", SqlDbType.VarChar,10),
					new SqlParameter("@ManageFarePrice", SqlDbType.Decimal,9),
					new SqlParameter("@OperMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@OperType", SqlDbType.Int,4),
					new SqlParameter("@RcvFareNum", SqlDbType.Int,4)};
			parameters[0].Value = model.UsersID;
			parameters[1].Value = model.ManageFareID;
			parameters[2].Value = model.LastMonth;
			parameters[3].Value = model.ThisMonth;
			parameters[4].Value = model.ManageFarePrice;
			parameters[5].Value = model.OperMoney;
			parameters[6].Value = model.OperatorID;
			parameters[7].Value = model.OperDate;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.OperID;
			parameters[10].Value = model.OperType;
			parameters[11].Value = model.RcvFareNum;

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
		public bool Update(WebDemo.Model.WebDemo.ManageFareList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ManageFareList set ");
			strSql.Append("UsersID=@UsersID,");
			strSql.Append("ManageFareID=@ManageFareID,");
			strSql.Append("LastMonth=@LastMonth,");
			strSql.Append("ThisMonth=@ThisMonth,");
			strSql.Append("ManageFarePrice=@ManageFarePrice,");
			strSql.Append("OperMoney=@OperMoney,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("OperDate=@OperDate,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("OperID=@OperID,");
			strSql.Append("OperType=@OperType,");
			strSql.Append("RcvFareNum=@RcvFareNum");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@ManageFareID", SqlDbType.Int,4),
					new SqlParameter("@LastMonth", SqlDbType.VarChar,10),
					new SqlParameter("@ThisMonth", SqlDbType.VarChar,10),
					new SqlParameter("@ManageFarePrice", SqlDbType.Decimal,9),
					new SqlParameter("@OperMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@OperID", SqlDbType.Int,4),
					new SqlParameter("@OperType", SqlDbType.Int,4),
					new SqlParameter("@RcvFareNum", SqlDbType.Int,4)};
			parameters[0].Value = model.UsersID;
			parameters[1].Value = model.ManageFareID;
			parameters[2].Value = model.LastMonth;
			parameters[3].Value = model.ThisMonth;
			parameters[4].Value = model.ManageFarePrice;
			parameters[5].Value = model.OperMoney;
			parameters[6].Value = model.OperatorID;
			parameters[7].Value = model.OperDate;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.OperID;
			parameters[10].Value = model.OperType;
			parameters[11].Value = model.RcvFareNum;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ManageFareList ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		public WebDemo.Model.WebDemo.ManageFareList GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UsersID,ManageFareID,LastMonth,ThisMonth,ManageFarePrice,OperMoney,OperatorID,OperDate,Remark,OperID,OperType,RcvFareNum from ManageFareList ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			WebDemo.Model.WebDemo.ManageFareList model=new WebDemo.Model.WebDemo.ManageFareList();
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
		public WebDemo.Model.WebDemo.ManageFareList DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.ManageFareList model=new WebDemo.Model.WebDemo.ManageFareList();
			if (row != null)
			{
				if(row["UsersID"]!=null && row["UsersID"].ToString()!="")
				{
					model.UsersID=int.Parse(row["UsersID"].ToString());
				}
				if(row["ManageFareID"]!=null && row["ManageFareID"].ToString()!="")
				{
					model.ManageFareID=int.Parse(row["ManageFareID"].ToString());
				}
				if(row["LastMonth"]!=null)
				{
					model.LastMonth=row["LastMonth"].ToString();
				}
				if(row["ThisMonth"]!=null)
				{
					model.ThisMonth=row["ThisMonth"].ToString();
				}
				if(row["ManageFarePrice"]!=null && row["ManageFarePrice"].ToString()!="")
				{
					model.ManageFarePrice=decimal.Parse(row["ManageFarePrice"].ToString());
				}
				if(row["OperMoney"]!=null && row["OperMoney"].ToString()!="")
				{
					model.OperMoney=decimal.Parse(row["OperMoney"].ToString());
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["OperDate"]!=null && row["OperDate"].ToString()!="")
				{
					model.OperDate=DateTime.Parse(row["OperDate"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["OperID"]!=null && row["OperID"].ToString()!="")
				{
					model.OperID=int.Parse(row["OperID"].ToString());
				}
				if(row["OperType"]!=null && row["OperType"].ToString()!="")
				{
					model.OperType=int.Parse(row["OperType"].ToString());
				}
				if(row["RcvFareNum"]!=null && row["RcvFareNum"].ToString()!="")
				{
					model.RcvFareNum=int.Parse(row["RcvFareNum"].ToString());
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
			strSql.Append("select UsersID,ManageFareID,LastMonth,ThisMonth,ManageFarePrice,OperMoney,OperatorID,OperDate,Remark,OperID,OperType,RcvFareNum ");
			strSql.Append(" FROM ManageFareList ");
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
			strSql.Append(" UsersID,ManageFareID,LastMonth,ThisMonth,ManageFarePrice,OperMoney,OperatorID,OperDate,Remark,OperID,OperType,RcvFareNum ");
			strSql.Append(" FROM ManageFareList ");
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
			strSql.Append("select count(1) FROM ManageFareList ");
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
				strSql.Append("order by T.ManageFareID desc");
			}
			strSql.Append(")AS Row, T.*  from ManageFareList T ");
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
			parameters[0].Value = "ManageFareList";
			parameters[1].Value = "ManageFareID";
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

