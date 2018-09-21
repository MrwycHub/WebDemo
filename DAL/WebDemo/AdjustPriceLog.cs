using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:AdjustPriceLog
	/// </summary>
	public partial class AdjustPriceLog
	{
		public AdjustPriceLog()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.AdjustPriceLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AdjustPriceLog(");
			strSql.Append("PriceTypeID,ExeDate,Mark,Divid1,Divid2,Divid3,Divid4,Divid5,FareID,FareTypeName,Price,Price2,Price3,Price4,Price5,Price6,FareNo,Remark,PreFareTypeName,PrePrice,PrePrice2,PrePrice3,PrePrice4,PrePrice5,PrePrice6,PreFareNo,PreRemark,SetNo,FreezeDay)");
			strSql.Append(" values (");
			strSql.Append("@PriceTypeID,@ExeDate,@Mark,@Divid1,@Divid2,@Divid3,@Divid4,@Divid5,@FareID,@FareTypeName,@Price,@Price2,@Price3,@Price4,@Price5,@Price6,@FareNo,@Remark,@PreFareTypeName,@PrePrice,@PrePrice2,@PrePrice3,@PrePrice4,@PrePrice5,@PrePrice6,@PreFareNo,@PreRemark,@SetNo,@FreezeDay)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4),
					new SqlParameter("@ExeDate", SqlDbType.DateTime),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@Divid1", SqlDbType.Int,4),
					new SqlParameter("@Divid2", SqlDbType.Int,4),
					new SqlParameter("@Divid3", SqlDbType.Int,4),
					new SqlParameter("@Divid4", SqlDbType.Int,4),
					new SqlParameter("@Divid5", SqlDbType.Int,4),
					new SqlParameter("@FareID", SqlDbType.Int,4),
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,20),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@Price4", SqlDbType.Decimal,9),
					new SqlParameter("@Price5", SqlDbType.Decimal,9),
					new SqlParameter("@Price6", SqlDbType.Decimal,9),
					new SqlParameter("@FareNo", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@PreFareTypeName", SqlDbType.VarChar,20),
					new SqlParameter("@PrePrice", SqlDbType.Decimal,9),
					new SqlParameter("@PrePrice2", SqlDbType.Decimal,9),
					new SqlParameter("@PrePrice3", SqlDbType.Decimal,9),
					new SqlParameter("@PrePrice4", SqlDbType.Decimal,9),
					new SqlParameter("@PrePrice5", SqlDbType.Decimal,9),
					new SqlParameter("@PrePrice6", SqlDbType.Decimal,9),
					new SqlParameter("@PreFareNo", SqlDbType.Int,4),
					new SqlParameter("@PreRemark", SqlDbType.VarChar,200),
					new SqlParameter("@SetNo", SqlDbType.Int,4),
					new SqlParameter("@FreezeDay", SqlDbType.Int,4)};
			parameters[0].Value = model.PriceTypeID;
			parameters[1].Value = model.ExeDate;
			parameters[2].Value = model.Mark;
			parameters[3].Value = model.Divid1;
			parameters[4].Value = model.Divid2;
			parameters[5].Value = model.Divid3;
			parameters[6].Value = model.Divid4;
			parameters[7].Value = model.Divid5;
			parameters[8].Value = model.FareID;
			parameters[9].Value = model.FareTypeName;
			parameters[10].Value = model.Price;
			parameters[11].Value = model.Price2;
			parameters[12].Value = model.Price3;
			parameters[13].Value = model.Price4;
			parameters[14].Value = model.Price5;
			parameters[15].Value = model.Price6;
			parameters[16].Value = model.FareNo;
			parameters[17].Value = model.Remark;
			parameters[18].Value = model.PreFareTypeName;
			parameters[19].Value = model.PrePrice;
			parameters[20].Value = model.PrePrice2;
			parameters[21].Value = model.PrePrice3;
			parameters[22].Value = model.PrePrice4;
			parameters[23].Value = model.PrePrice5;
			parameters[24].Value = model.PrePrice6;
			parameters[25].Value = model.PreFareNo;
			parameters[26].Value = model.PreRemark;
			parameters[27].Value = model.SetNo;
			parameters[28].Value = model.FreezeDay;

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
		public bool Update(WebDemo.Model.WebDemo.AdjustPriceLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AdjustPriceLog set ");
			strSql.Append("PriceTypeID=@PriceTypeID,");
			strSql.Append("ExeDate=@ExeDate,");
			strSql.Append("Mark=@Mark,");
			strSql.Append("Divid1=@Divid1,");
			strSql.Append("Divid2=@Divid2,");
			strSql.Append("Divid3=@Divid3,");
			strSql.Append("Divid4=@Divid4,");
			strSql.Append("Divid5=@Divid5,");
			strSql.Append("FareID=@FareID,");
			strSql.Append("FareTypeName=@FareTypeName,");
			strSql.Append("Price=@Price,");
			strSql.Append("Price2=@Price2,");
			strSql.Append("Price3=@Price3,");
			strSql.Append("Price4=@Price4,");
			strSql.Append("Price5=@Price5,");
			strSql.Append("Price6=@Price6,");
			strSql.Append("FareNo=@FareNo,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("PreFareTypeName=@PreFareTypeName,");
			strSql.Append("PrePrice=@PrePrice,");
			strSql.Append("PrePrice2=@PrePrice2,");
			strSql.Append("PrePrice3=@PrePrice3,");
			strSql.Append("PrePrice4=@PrePrice4,");
			strSql.Append("PrePrice5=@PrePrice5,");
			strSql.Append("PrePrice6=@PrePrice6,");
			strSql.Append("PreFareNo=@PreFareNo,");
			strSql.Append("PreRemark=@PreRemark,");
			strSql.Append("SetNo=@SetNo,");
			strSql.Append("FreezeDay=@FreezeDay");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4),
					new SqlParameter("@ExeDate", SqlDbType.DateTime),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@Divid1", SqlDbType.Int,4),
					new SqlParameter("@Divid2", SqlDbType.Int,4),
					new SqlParameter("@Divid3", SqlDbType.Int,4),
					new SqlParameter("@Divid4", SqlDbType.Int,4),
					new SqlParameter("@Divid5", SqlDbType.Int,4),
					new SqlParameter("@FareID", SqlDbType.Int,4),
					new SqlParameter("@FareTypeName", SqlDbType.VarChar,20),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@Price4", SqlDbType.Decimal,9),
					new SqlParameter("@Price5", SqlDbType.Decimal,9),
					new SqlParameter("@Price6", SqlDbType.Decimal,9),
					new SqlParameter("@FareNo", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@PreFareTypeName", SqlDbType.VarChar,20),
					new SqlParameter("@PrePrice", SqlDbType.Decimal,9),
					new SqlParameter("@PrePrice2", SqlDbType.Decimal,9),
					new SqlParameter("@PrePrice3", SqlDbType.Decimal,9),
					new SqlParameter("@PrePrice4", SqlDbType.Decimal,9),
					new SqlParameter("@PrePrice5", SqlDbType.Decimal,9),
					new SqlParameter("@PrePrice6", SqlDbType.Decimal,9),
					new SqlParameter("@PreFareNo", SqlDbType.Int,4),
					new SqlParameter("@PreRemark", SqlDbType.VarChar,200),
					new SqlParameter("@SetNo", SqlDbType.Int,4),
					new SqlParameter("@FreezeDay", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.PriceTypeID;
			parameters[1].Value = model.ExeDate;
			parameters[2].Value = model.Mark;
			parameters[3].Value = model.Divid1;
			parameters[4].Value = model.Divid2;
			parameters[5].Value = model.Divid3;
			parameters[6].Value = model.Divid4;
			parameters[7].Value = model.Divid5;
			parameters[8].Value = model.FareID;
			parameters[9].Value = model.FareTypeName;
			parameters[10].Value = model.Price;
			parameters[11].Value = model.Price2;
			parameters[12].Value = model.Price3;
			parameters[13].Value = model.Price4;
			parameters[14].Value = model.Price5;
			parameters[15].Value = model.Price6;
			parameters[16].Value = model.FareNo;
			parameters[17].Value = model.Remark;
			parameters[18].Value = model.PreFareTypeName;
			parameters[19].Value = model.PrePrice;
			parameters[20].Value = model.PrePrice2;
			parameters[21].Value = model.PrePrice3;
			parameters[22].Value = model.PrePrice4;
			parameters[23].Value = model.PrePrice5;
			parameters[24].Value = model.PrePrice6;
			parameters[25].Value = model.PreFareNo;
			parameters[26].Value = model.PreRemark;
			parameters[27].Value = model.SetNo;
			parameters[28].Value = model.FreezeDay;
			parameters[29].Value = model.ID;

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
			strSql.Append("delete from AdjustPriceLog ");
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
			strSql.Append("delete from AdjustPriceLog ");
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
		public WebDemo.Model.WebDemo.AdjustPriceLog GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,PriceTypeID,ExeDate,Mark,Divid1,Divid2,Divid3,Divid4,Divid5,FareID,FareTypeName,Price,Price2,Price3,Price4,Price5,Price6,FareNo,Remark,PreFareTypeName,PrePrice,PrePrice2,PrePrice3,PrePrice4,PrePrice5,PrePrice6,PreFareNo,PreRemark,SetNo,FreezeDay from AdjustPriceLog ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.AdjustPriceLog model=new WebDemo.Model.WebDemo.AdjustPriceLog();
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
		public WebDemo.Model.WebDemo.AdjustPriceLog DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.AdjustPriceLog model=new WebDemo.Model.WebDemo.AdjustPriceLog();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["PriceTypeID"]!=null && row["PriceTypeID"].ToString()!="")
				{
					model.PriceTypeID=int.Parse(row["PriceTypeID"].ToString());
				}
				if(row["ExeDate"]!=null && row["ExeDate"].ToString()!="")
				{
					model.ExeDate=DateTime.Parse(row["ExeDate"].ToString());
				}
				if(row["Mark"]!=null && row["Mark"].ToString()!="")
				{
					model.Mark=int.Parse(row["Mark"].ToString());
				}
				if(row["Divid1"]!=null && row["Divid1"].ToString()!="")
				{
					model.Divid1=int.Parse(row["Divid1"].ToString());
				}
				if(row["Divid2"]!=null && row["Divid2"].ToString()!="")
				{
					model.Divid2=int.Parse(row["Divid2"].ToString());
				}
				if(row["Divid3"]!=null && row["Divid3"].ToString()!="")
				{
					model.Divid3=int.Parse(row["Divid3"].ToString());
				}
				if(row["Divid4"]!=null && row["Divid4"].ToString()!="")
				{
					model.Divid4=int.Parse(row["Divid4"].ToString());
				}
				if(row["Divid5"]!=null && row["Divid5"].ToString()!="")
				{
					model.Divid5=int.Parse(row["Divid5"].ToString());
				}
				if(row["FareID"]!=null && row["FareID"].ToString()!="")
				{
					model.FareID=int.Parse(row["FareID"].ToString());
				}
				if(row["FareTypeName"]!=null)
				{
					model.FareTypeName=row["FareTypeName"].ToString();
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(row["Price"].ToString());
				}
				if(row["Price2"]!=null && row["Price2"].ToString()!="")
				{
					model.Price2=decimal.Parse(row["Price2"].ToString());
				}
				if(row["Price3"]!=null && row["Price3"].ToString()!="")
				{
					model.Price3=decimal.Parse(row["Price3"].ToString());
				}
				if(row["Price4"]!=null && row["Price4"].ToString()!="")
				{
					model.Price4=decimal.Parse(row["Price4"].ToString());
				}
				if(row["Price5"]!=null && row["Price5"].ToString()!="")
				{
					model.Price5=decimal.Parse(row["Price5"].ToString());
				}
				if(row["Price6"]!=null && row["Price6"].ToString()!="")
				{
					model.Price6=decimal.Parse(row["Price6"].ToString());
				}
				if(row["FareNo"]!=null && row["FareNo"].ToString()!="")
				{
					model.FareNo=int.Parse(row["FareNo"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["PreFareTypeName"]!=null)
				{
					model.PreFareTypeName=row["PreFareTypeName"].ToString();
				}
				if(row["PrePrice"]!=null && row["PrePrice"].ToString()!="")
				{
					model.PrePrice=decimal.Parse(row["PrePrice"].ToString());
				}
				if(row["PrePrice2"]!=null && row["PrePrice2"].ToString()!="")
				{
					model.PrePrice2=decimal.Parse(row["PrePrice2"].ToString());
				}
				if(row["PrePrice3"]!=null && row["PrePrice3"].ToString()!="")
				{
					model.PrePrice3=decimal.Parse(row["PrePrice3"].ToString());
				}
				if(row["PrePrice4"]!=null && row["PrePrice4"].ToString()!="")
				{
					model.PrePrice4=decimal.Parse(row["PrePrice4"].ToString());
				}
				if(row["PrePrice5"]!=null && row["PrePrice5"].ToString()!="")
				{
					model.PrePrice5=decimal.Parse(row["PrePrice5"].ToString());
				}
				if(row["PrePrice6"]!=null && row["PrePrice6"].ToString()!="")
				{
					model.PrePrice6=decimal.Parse(row["PrePrice6"].ToString());
				}
				if(row["PreFareNo"]!=null && row["PreFareNo"].ToString()!="")
				{
					model.PreFareNo=int.Parse(row["PreFareNo"].ToString());
				}
				if(row["PreRemark"]!=null)
				{
					model.PreRemark=row["PreRemark"].ToString();
				}
				if(row["SetNo"]!=null && row["SetNo"].ToString()!="")
				{
					model.SetNo=int.Parse(row["SetNo"].ToString());
				}
				if(row["FreezeDay"]!=null && row["FreezeDay"].ToString()!="")
				{
					model.FreezeDay=int.Parse(row["FreezeDay"].ToString());
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
			strSql.Append("select ID,PriceTypeID,ExeDate,Mark,Divid1,Divid2,Divid3,Divid4,Divid5,FareID,FareTypeName,Price,Price2,Price3,Price4,Price5,Price6,FareNo,Remark,PreFareTypeName,PrePrice,PrePrice2,PrePrice3,PrePrice4,PrePrice5,PrePrice6,PreFareNo,PreRemark,SetNo,FreezeDay ");
			strSql.Append(" FROM AdjustPriceLog ");
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
			strSql.Append(" ID,PriceTypeID,ExeDate,Mark,Divid1,Divid2,Divid3,Divid4,Divid5,FareID,FareTypeName,Price,Price2,Price3,Price4,Price5,Price6,FareNo,Remark,PreFareTypeName,PrePrice,PrePrice2,PrePrice3,PrePrice4,PrePrice5,PrePrice6,PreFareNo,PreRemark,SetNo,FreezeDay ");
			strSql.Append(" FROM AdjustPriceLog ");
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
			strSql.Append("select count(1) FROM AdjustPriceLog ");
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
			strSql.Append(")AS Row, T.*  from AdjustPriceLog T ");
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
			parameters[0].Value = "AdjustPriceLog";
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

