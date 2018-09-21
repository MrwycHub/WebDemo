using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:OperationTotal
	/// </summary>
	public partial class OperationTotal
	{
		public OperationTotal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("TID", "OperationTotal"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OperationTotal");
			strSql.Append(" where TID=@TID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TID", SqlDbType.Int,4)			};
			parameters[0].Value = TID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.OperationTotal model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OperationTotal(");
			strSql.Append("TID,MeterID,PayID,BeginMonth,BeginNumber,EndMonth,EndNumber,UseNumber,PriceTypeID,PriceTypeName,Price,Price2,Price3,FareMoney,PayMark,OperType,OperDate,OperatorID,opermonth,PriceUnit,OperationName,Divid1,Divid2,UseNumber1,UseNumber2,UseNumber3,AdditionNum)");
			strSql.Append(" values (");
			strSql.Append("@TID,@MeterID,@PayID,@BeginMonth,@BeginNumber,@EndMonth,@EndNumber,@UseNumber,@PriceTypeID,@PriceTypeName,@Price,@Price2,@Price3,@FareMoney,@PayMark,@OperType,@OperDate,@OperatorID,@opermonth,@PriceUnit,@OperationName,@Divid1,@Divid2,@UseNumber1,@UseNumber2,@UseNumber3,@AdditionNum)");
			SqlParameter[] parameters = {
					new SqlParameter("@TID", SqlDbType.Int,4),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@BeginMonth", SqlDbType.VarChar,7),
					new SqlParameter("@BeginNumber", SqlDbType.Int,4),
					new SqlParameter("@EndMonth", SqlDbType.VarChar,7),
					new SqlParameter("@EndNumber", SqlDbType.Int,4),
					new SqlParameter("@UseNumber", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@FareMoney", SqlDbType.Decimal,9),
					new SqlParameter("@PayMark", SqlDbType.Int,4),
					new SqlParameter("@OperType", SqlDbType.Int,4),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@opermonth", SqlDbType.VarChar,7),
					new SqlParameter("@PriceUnit", SqlDbType.VarChar,50),
					new SqlParameter("@OperationName", SqlDbType.VarChar,50),
					new SqlParameter("@Divid1", SqlDbType.Int,4),
					new SqlParameter("@Divid2", SqlDbType.Int,4),
					new SqlParameter("@UseNumber1", SqlDbType.Decimal,9),
					new SqlParameter("@UseNumber2", SqlDbType.Decimal,9),
					new SqlParameter("@UseNumber3", SqlDbType.Decimal,9),
					new SqlParameter("@AdditionNum", SqlDbType.Decimal,9)};
			parameters[0].Value = model.TID;
			parameters[1].Value = model.MeterID;
			parameters[2].Value = model.PayID;
			parameters[3].Value = model.BeginMonth;
			parameters[4].Value = model.BeginNumber;
			parameters[5].Value = model.EndMonth;
			parameters[6].Value = model.EndNumber;
			parameters[7].Value = model.UseNumber;
			parameters[8].Value = model.PriceTypeID;
			parameters[9].Value = model.PriceTypeName;
			parameters[10].Value = model.Price;
			parameters[11].Value = model.Price2;
			parameters[12].Value = model.Price3;
			parameters[13].Value = model.FareMoney;
			parameters[14].Value = model.PayMark;
			parameters[15].Value = model.OperType;
			parameters[16].Value = model.OperDate;
			parameters[17].Value = model.OperatorID;
			parameters[18].Value = model.opermonth;
			parameters[19].Value = model.PriceUnit;
			parameters[20].Value = model.OperationName;
			parameters[21].Value = model.Divid1;
			parameters[22].Value = model.Divid2;
			parameters[23].Value = model.UseNumber1;
			parameters[24].Value = model.UseNumber2;
			parameters[25].Value = model.UseNumber3;
			parameters[26].Value = model.AdditionNum;

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
		public bool Update(WebDemo.Model.WebDemo.OperationTotal model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OperationTotal set ");
			strSql.Append("MeterID=@MeterID,");
			strSql.Append("PayID=@PayID,");
			strSql.Append("BeginMonth=@BeginMonth,");
			strSql.Append("BeginNumber=@BeginNumber,");
			strSql.Append("EndMonth=@EndMonth,");
			strSql.Append("EndNumber=@EndNumber,");
			strSql.Append("UseNumber=@UseNumber,");
			strSql.Append("PriceTypeID=@PriceTypeID,");
			strSql.Append("PriceTypeName=@PriceTypeName,");
			strSql.Append("Price=@Price,");
			strSql.Append("Price2=@Price2,");
			strSql.Append("Price3=@Price3,");
			strSql.Append("FareMoney=@FareMoney,");
			strSql.Append("PayMark=@PayMark,");
			strSql.Append("OperType=@OperType,");
			strSql.Append("OperDate=@OperDate,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("opermonth=@opermonth,");
			strSql.Append("PriceUnit=@PriceUnit,");
			strSql.Append("OperationName=@OperationName,");
			strSql.Append("Divid1=@Divid1,");
			strSql.Append("Divid2=@Divid2,");
			strSql.Append("UseNumber1=@UseNumber1,");
			strSql.Append("UseNumber2=@UseNumber2,");
			strSql.Append("UseNumber3=@UseNumber3,");
			strSql.Append("AdditionNum=@AdditionNum");
			strSql.Append(" where TID=@TID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@BeginMonth", SqlDbType.VarChar,7),
					new SqlParameter("@BeginNumber", SqlDbType.Int,4),
					new SqlParameter("@EndMonth", SqlDbType.VarChar,7),
					new SqlParameter("@EndNumber", SqlDbType.Int,4),
					new SqlParameter("@UseNumber", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@FareMoney", SqlDbType.Decimal,9),
					new SqlParameter("@PayMark", SqlDbType.Int,4),
					new SqlParameter("@OperType", SqlDbType.Int,4),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@opermonth", SqlDbType.VarChar,7),
					new SqlParameter("@PriceUnit", SqlDbType.VarChar,50),
					new SqlParameter("@OperationName", SqlDbType.VarChar,50),
					new SqlParameter("@Divid1", SqlDbType.Int,4),
					new SqlParameter("@Divid2", SqlDbType.Int,4),
					new SqlParameter("@UseNumber1", SqlDbType.Decimal,9),
					new SqlParameter("@UseNumber2", SqlDbType.Decimal,9),
					new SqlParameter("@UseNumber3", SqlDbType.Decimal,9),
					new SqlParameter("@AdditionNum", SqlDbType.Decimal,9),
					new SqlParameter("@TID", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.PayID;
			parameters[2].Value = model.BeginMonth;
			parameters[3].Value = model.BeginNumber;
			parameters[4].Value = model.EndMonth;
			parameters[5].Value = model.EndNumber;
			parameters[6].Value = model.UseNumber;
			parameters[7].Value = model.PriceTypeID;
			parameters[8].Value = model.PriceTypeName;
			parameters[9].Value = model.Price;
			parameters[10].Value = model.Price2;
			parameters[11].Value = model.Price3;
			parameters[12].Value = model.FareMoney;
			parameters[13].Value = model.PayMark;
			parameters[14].Value = model.OperType;
			parameters[15].Value = model.OperDate;
			parameters[16].Value = model.OperatorID;
			parameters[17].Value = model.opermonth;
			parameters[18].Value = model.PriceUnit;
			parameters[19].Value = model.OperationName;
			parameters[20].Value = model.Divid1;
			parameters[21].Value = model.Divid2;
			parameters[22].Value = model.UseNumber1;
			parameters[23].Value = model.UseNumber2;
			parameters[24].Value = model.UseNumber3;
			parameters[25].Value = model.AdditionNum;
			parameters[26].Value = model.TID;

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
		public bool Delete(int TID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OperationTotal ");
			strSql.Append(" where TID=@TID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TID", SqlDbType.Int,4)			};
			parameters[0].Value = TID;

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
		public bool DeleteList(string TIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OperationTotal ");
			strSql.Append(" where TID in ("+TIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.OperationTotal GetModel(int TID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TID,MeterID,PayID,BeginMonth,BeginNumber,EndMonth,EndNumber,UseNumber,PriceTypeID,PriceTypeName,Price,Price2,Price3,FareMoney,PayMark,OperType,OperDate,OperatorID,opermonth,PriceUnit,OperationName,Divid1,Divid2,UseNumber1,UseNumber2,UseNumber3,AdditionNum from OperationTotal ");
			strSql.Append(" where TID=@TID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TID", SqlDbType.Int,4)			};
			parameters[0].Value = TID;

			WebDemo.Model.WebDemo.OperationTotal model=new WebDemo.Model.WebDemo.OperationTotal();
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
		public WebDemo.Model.WebDemo.OperationTotal DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.OperationTotal model=new WebDemo.Model.WebDemo.OperationTotal();
			if (row != null)
			{
				if(row["TID"]!=null && row["TID"].ToString()!="")
				{
					model.TID=int.Parse(row["TID"].ToString());
				}
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["PayID"]!=null && row["PayID"].ToString()!="")
				{
					model.PayID=int.Parse(row["PayID"].ToString());
				}
				if(row["BeginMonth"]!=null)
				{
					model.BeginMonth=row["BeginMonth"].ToString();
				}
				if(row["BeginNumber"]!=null && row["BeginNumber"].ToString()!="")
				{
					model.BeginNumber=int.Parse(row["BeginNumber"].ToString());
				}
				if(row["EndMonth"]!=null)
				{
					model.EndMonth=row["EndMonth"].ToString();
				}
				if(row["EndNumber"]!=null && row["EndNumber"].ToString()!="")
				{
					model.EndNumber=int.Parse(row["EndNumber"].ToString());
				}
				if(row["UseNumber"]!=null && row["UseNumber"].ToString()!="")
				{
					model.UseNumber=int.Parse(row["UseNumber"].ToString());
				}
				if(row["PriceTypeID"]!=null && row["PriceTypeID"].ToString()!="")
				{
					model.PriceTypeID=int.Parse(row["PriceTypeID"].ToString());
				}
				if(row["PriceTypeName"]!=null)
				{
					model.PriceTypeName=row["PriceTypeName"].ToString();
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
				if(row["FareMoney"]!=null && row["FareMoney"].ToString()!="")
				{
					model.FareMoney=decimal.Parse(row["FareMoney"].ToString());
				}
				if(row["PayMark"]!=null && row["PayMark"].ToString()!="")
				{
					model.PayMark=int.Parse(row["PayMark"].ToString());
				}
				if(row["OperType"]!=null && row["OperType"].ToString()!="")
				{
					model.OperType=int.Parse(row["OperType"].ToString());
				}
				if(row["OperDate"]!=null && row["OperDate"].ToString()!="")
				{
					model.OperDate=DateTime.Parse(row["OperDate"].ToString());
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["opermonth"]!=null)
				{
					model.opermonth=row["opermonth"].ToString();
				}
				if(row["PriceUnit"]!=null)
				{
					model.PriceUnit=row["PriceUnit"].ToString();
				}
				if(row["OperationName"]!=null)
				{
					model.OperationName=row["OperationName"].ToString();
				}
				if(row["Divid1"]!=null && row["Divid1"].ToString()!="")
				{
					model.Divid1=int.Parse(row["Divid1"].ToString());
				}
				if(row["Divid2"]!=null && row["Divid2"].ToString()!="")
				{
					model.Divid2=int.Parse(row["Divid2"].ToString());
				}
				if(row["UseNumber1"]!=null && row["UseNumber1"].ToString()!="")
				{
					model.UseNumber1=decimal.Parse(row["UseNumber1"].ToString());
				}
				if(row["UseNumber2"]!=null && row["UseNumber2"].ToString()!="")
				{
					model.UseNumber2=decimal.Parse(row["UseNumber2"].ToString());
				}
				if(row["UseNumber3"]!=null && row["UseNumber3"].ToString()!="")
				{
					model.UseNumber3=decimal.Parse(row["UseNumber3"].ToString());
				}
				if(row["AdditionNum"]!=null && row["AdditionNum"].ToString()!="")
				{
					model.AdditionNum=decimal.Parse(row["AdditionNum"].ToString());
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
			strSql.Append("select TID,MeterID,PayID,BeginMonth,BeginNumber,EndMonth,EndNumber,UseNumber,PriceTypeID,PriceTypeName,Price,Price2,Price3,FareMoney,PayMark,OperType,OperDate,OperatorID,opermonth,PriceUnit,OperationName,Divid1,Divid2,UseNumber1,UseNumber2,UseNumber3,AdditionNum ");
			strSql.Append(" FROM OperationTotal ");
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
			strSql.Append(" TID,MeterID,PayID,BeginMonth,BeginNumber,EndMonth,EndNumber,UseNumber,PriceTypeID,PriceTypeName,Price,Price2,Price3,FareMoney,PayMark,OperType,OperDate,OperatorID,opermonth,PriceUnit,OperationName,Divid1,Divid2,UseNumber1,UseNumber2,UseNumber3,AdditionNum ");
			strSql.Append(" FROM OperationTotal ");
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
			strSql.Append("select count(1) FROM OperationTotal ");
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
				strSql.Append("order by T.TID desc");
			}
			strSql.Append(")AS Row, T.*  from OperationTotal T ");
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
			parameters[0].Value = "OperationTotal";
			parameters[1].Value = "TID";
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

