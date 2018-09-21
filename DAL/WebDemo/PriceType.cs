using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:PriceType
	/// </summary>
	public partial class PriceType
	{
		public PriceType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("PriceTypeID", "PriceType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PriceTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PriceType");
			strSql.Append(" where PriceTypeID=@PriceTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4)
			};
			parameters[0].Value = PriceTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.PriceType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PriceType(");
			strSql.Append("PriceTypeName,MeterTypeID,PriceNo,Price,Price2,Price3,Divid1,Divid2,PriceUnit,Remark,Price4,Price5,Price6,Divid3,Divid4,Divid5,ExeDate,SetNo,SuiteNo,GroupPriceNo,PriceTypeCode,IsStartStar,IsStartPeople,PeopleCheck,MaxPeople,AddUseNumber,StarsLevel,StarsPeriod,StarsCorrected,IsStartArea,Coefficient,CalculateDay,StarsAreaWay,StarsByUser)");
			strSql.Append(" values (");
			strSql.Append("@PriceTypeName,@MeterTypeID,@PriceNo,@Price,@Price2,@Price3,@Divid1,@Divid2,@PriceUnit,@Remark,@Price4,@Price5,@Price6,@Divid3,@Divid4,@Divid5,@ExeDate,@SetNo,@SuiteNo,@GroupPriceNo,@PriceTypeCode,@IsStartStar,@IsStartPeople,@PeopleCheck,@MaxPeople,@AddUseNumber,@StarsLevel,@StarsPeriod,@StarsCorrected,@IsStartArea,@Coefficient,@CalculateDay,@StarsAreaWay,@StarsByUser)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@MeterTypeID", SqlDbType.Int,4),
					new SqlParameter("@PriceNo", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@Divid1", SqlDbType.Int,4),
					new SqlParameter("@Divid2", SqlDbType.Int,4),
					new SqlParameter("@PriceUnit", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@Price4", SqlDbType.Decimal,9),
					new SqlParameter("@Price5", SqlDbType.Decimal,9),
					new SqlParameter("@Price6", SqlDbType.Decimal,9),
					new SqlParameter("@Divid3", SqlDbType.Int,4),
					new SqlParameter("@Divid4", SqlDbType.Int,4),
					new SqlParameter("@Divid5", SqlDbType.Int,4),
					new SqlParameter("@ExeDate", SqlDbType.DateTime),
					new SqlParameter("@SetNo", SqlDbType.Int,4),
					new SqlParameter("@SuiteNo", SqlDbType.Int,4),
					new SqlParameter("@GroupPriceNo", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeCode", SqlDbType.VarChar,100),
					new SqlParameter("@IsStartStar", SqlDbType.Int,4),
					new SqlParameter("@IsStartPeople", SqlDbType.Int,4),
					new SqlParameter("@PeopleCheck", SqlDbType.Int,4),
					new SqlParameter("@MaxPeople", SqlDbType.Int,4),
					new SqlParameter("@AddUseNumber", SqlDbType.Decimal,9),
					new SqlParameter("@StarsLevel", SqlDbType.Int,4),
					new SqlParameter("@StarsPeriod", SqlDbType.Int,4),
					new SqlParameter("@StarsCorrected", SqlDbType.Int,4),
					new SqlParameter("@IsStartArea", SqlDbType.Int,4),
					new SqlParameter("@Coefficient", SqlDbType.Decimal,9),
					new SqlParameter("@CalculateDay", SqlDbType.Int,4),
					new SqlParameter("@StarsAreaWay", SqlDbType.Int,4),
					new SqlParameter("@StarsByUser", SqlDbType.Int,4)};
			parameters[0].Value = model.PriceTypeName;
			parameters[1].Value = model.MeterTypeID;
			parameters[2].Value = model.PriceNo;
			parameters[3].Value = model.Price;
			parameters[4].Value = model.Price2;
			parameters[5].Value = model.Price3;
			parameters[6].Value = model.Divid1;
			parameters[7].Value = model.Divid2;
			parameters[8].Value = model.PriceUnit;
			parameters[9].Value = model.Remark;
			parameters[10].Value = model.Price4;
			parameters[11].Value = model.Price5;
			parameters[12].Value = model.Price6;
			parameters[13].Value = model.Divid3;
			parameters[14].Value = model.Divid4;
			parameters[15].Value = model.Divid5;
			parameters[16].Value = model.ExeDate;
			parameters[17].Value = model.SetNo;
			parameters[18].Value = model.SuiteNo;
			parameters[19].Value = model.GroupPriceNo;
			parameters[20].Value = model.PriceTypeCode;
			parameters[21].Value = model.IsStartStar;
			parameters[22].Value = model.IsStartPeople;
			parameters[23].Value = model.PeopleCheck;
			parameters[24].Value = model.MaxPeople;
			parameters[25].Value = model.AddUseNumber;
			parameters[26].Value = model.StarsLevel;
			parameters[27].Value = model.StarsPeriod;
			parameters[28].Value = model.StarsCorrected;
			parameters[29].Value = model.IsStartArea;
			parameters[30].Value = model.Coefficient;
			parameters[31].Value = model.CalculateDay;
			parameters[32].Value = model.StarsAreaWay;
			parameters[33].Value = model.StarsByUser;

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
		public bool Update(WebDemo.Model.WebDemo.PriceType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PriceType set ");
			strSql.Append("PriceTypeName=@PriceTypeName,");
			strSql.Append("MeterTypeID=@MeterTypeID,");
			strSql.Append("PriceNo=@PriceNo,");
			strSql.Append("Price=@Price,");
			strSql.Append("Price2=@Price2,");
			strSql.Append("Price3=@Price3,");
			strSql.Append("Divid1=@Divid1,");
			strSql.Append("Divid2=@Divid2,");
			strSql.Append("PriceUnit=@PriceUnit,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Price4=@Price4,");
			strSql.Append("Price5=@Price5,");
			strSql.Append("Price6=@Price6,");
			strSql.Append("Divid3=@Divid3,");
			strSql.Append("Divid4=@Divid4,");
			strSql.Append("Divid5=@Divid5,");
			strSql.Append("ExeDate=@ExeDate,");
			strSql.Append("SetNo=@SetNo,");
			strSql.Append("SuiteNo=@SuiteNo,");
			strSql.Append("GroupPriceNo=@GroupPriceNo,");
			strSql.Append("PriceTypeCode=@PriceTypeCode,");
			strSql.Append("IsStartStar=@IsStartStar,");
			strSql.Append("IsStartPeople=@IsStartPeople,");
			strSql.Append("PeopleCheck=@PeopleCheck,");
			strSql.Append("MaxPeople=@MaxPeople,");
			strSql.Append("AddUseNumber=@AddUseNumber,");
			strSql.Append("StarsLevel=@StarsLevel,");
			strSql.Append("StarsPeriod=@StarsPeriod,");
			strSql.Append("StarsCorrected=@StarsCorrected,");
			strSql.Append("IsStartArea=@IsStartArea,");
			strSql.Append("Coefficient=@Coefficient,");
			strSql.Append("CalculateDay=@CalculateDay,");
			strSql.Append("StarsAreaWay=@StarsAreaWay,");
			strSql.Append("StarsByUser=@StarsByUser");
			strSql.Append(" where PriceTypeID=@PriceTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeName", SqlDbType.VarChar,50),
					new SqlParameter("@MeterTypeID", SqlDbType.Int,4),
					new SqlParameter("@PriceNo", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Price2", SqlDbType.Decimal,9),
					new SqlParameter("@Price3", SqlDbType.Decimal,9),
					new SqlParameter("@Divid1", SqlDbType.Int,4),
					new SqlParameter("@Divid2", SqlDbType.Int,4),
					new SqlParameter("@PriceUnit", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@Price4", SqlDbType.Decimal,9),
					new SqlParameter("@Price5", SqlDbType.Decimal,9),
					new SqlParameter("@Price6", SqlDbType.Decimal,9),
					new SqlParameter("@Divid3", SqlDbType.Int,4),
					new SqlParameter("@Divid4", SqlDbType.Int,4),
					new SqlParameter("@Divid5", SqlDbType.Int,4),
					new SqlParameter("@ExeDate", SqlDbType.DateTime),
					new SqlParameter("@SetNo", SqlDbType.Int,4),
					new SqlParameter("@SuiteNo", SqlDbType.Int,4),
					new SqlParameter("@GroupPriceNo", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeCode", SqlDbType.VarChar,100),
					new SqlParameter("@IsStartStar", SqlDbType.Int,4),
					new SqlParameter("@IsStartPeople", SqlDbType.Int,4),
					new SqlParameter("@PeopleCheck", SqlDbType.Int,4),
					new SqlParameter("@MaxPeople", SqlDbType.Int,4),
					new SqlParameter("@AddUseNumber", SqlDbType.Decimal,9),
					new SqlParameter("@StarsLevel", SqlDbType.Int,4),
					new SqlParameter("@StarsPeriod", SqlDbType.Int,4),
					new SqlParameter("@StarsCorrected", SqlDbType.Int,4),
					new SqlParameter("@IsStartArea", SqlDbType.Int,4),
					new SqlParameter("@Coefficient", SqlDbType.Decimal,9),
					new SqlParameter("@CalculateDay", SqlDbType.Int,4),
					new SqlParameter("@StarsAreaWay", SqlDbType.Int,4),
					new SqlParameter("@StarsByUser", SqlDbType.Int,4),
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4)};
			parameters[0].Value = model.PriceTypeName;
			parameters[1].Value = model.MeterTypeID;
			parameters[2].Value = model.PriceNo;
			parameters[3].Value = model.Price;
			parameters[4].Value = model.Price2;
			parameters[5].Value = model.Price3;
			parameters[6].Value = model.Divid1;
			parameters[7].Value = model.Divid2;
			parameters[8].Value = model.PriceUnit;
			parameters[9].Value = model.Remark;
			parameters[10].Value = model.Price4;
			parameters[11].Value = model.Price5;
			parameters[12].Value = model.Price6;
			parameters[13].Value = model.Divid3;
			parameters[14].Value = model.Divid4;
			parameters[15].Value = model.Divid5;
			parameters[16].Value = model.ExeDate;
			parameters[17].Value = model.SetNo;
			parameters[18].Value = model.SuiteNo;
			parameters[19].Value = model.GroupPriceNo;
			parameters[20].Value = model.PriceTypeCode;
			parameters[21].Value = model.IsStartStar;
			parameters[22].Value = model.IsStartPeople;
			parameters[23].Value = model.PeopleCheck;
			parameters[24].Value = model.MaxPeople;
			parameters[25].Value = model.AddUseNumber;
			parameters[26].Value = model.StarsLevel;
			parameters[27].Value = model.StarsPeriod;
			parameters[28].Value = model.StarsCorrected;
			parameters[29].Value = model.IsStartArea;
			parameters[30].Value = model.Coefficient;
			parameters[31].Value = model.CalculateDay;
			parameters[32].Value = model.StarsAreaWay;
			parameters[33].Value = model.StarsByUser;
			parameters[34].Value = model.PriceTypeID;

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
		public bool Delete(int PriceTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PriceType ");
			strSql.Append(" where PriceTypeID=@PriceTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4)
			};
			parameters[0].Value = PriceTypeID;

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
		public bool DeleteList(string PriceTypeIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PriceType ");
			strSql.Append(" where PriceTypeID in ("+PriceTypeIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.PriceType GetModel(int PriceTypeID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PriceTypeID,PriceTypeName,MeterTypeID,PriceNo,Price,Price2,Price3,Divid1,Divid2,PriceUnit,Remark,Price4,Price5,Price6,Divid3,Divid4,Divid5,ExeDate,SetNo,SuiteNo,GroupPriceNo,PriceTypeCode,IsStartStar,IsStartPeople,PeopleCheck,MaxPeople,AddUseNumber,StarsLevel,StarsPeriod,StarsCorrected,IsStartArea,Coefficient,CalculateDay,StarsAreaWay,StarsByUser from PriceType ");
			strSql.Append(" where PriceTypeID=@PriceTypeID");
			SqlParameter[] parameters = {
					new SqlParameter("@PriceTypeID", SqlDbType.Int,4)
			};
			parameters[0].Value = PriceTypeID;

			WebDemo.Model.WebDemo.PriceType model=new WebDemo.Model.WebDemo.PriceType();
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
		public WebDemo.Model.WebDemo.PriceType DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.PriceType model=new WebDemo.Model.WebDemo.PriceType();
			if (row != null)
			{
				if(row["PriceTypeID"]!=null && row["PriceTypeID"].ToString()!="")
				{
					model.PriceTypeID=int.Parse(row["PriceTypeID"].ToString());
				}
				if(row["PriceTypeName"]!=null)
				{
					model.PriceTypeName=row["PriceTypeName"].ToString();
				}
				if(row["MeterTypeID"]!=null && row["MeterTypeID"].ToString()!="")
				{
					model.MeterTypeID=int.Parse(row["MeterTypeID"].ToString());
				}
				if(row["PriceNo"]!=null && row["PriceNo"].ToString()!="")
				{
					model.PriceNo=int.Parse(row["PriceNo"].ToString());
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
				if(row["Divid1"]!=null && row["Divid1"].ToString()!="")
				{
					model.Divid1=int.Parse(row["Divid1"].ToString());
				}
				if(row["Divid2"]!=null && row["Divid2"].ToString()!="")
				{
					model.Divid2=int.Parse(row["Divid2"].ToString());
				}
				if(row["PriceUnit"]!=null)
				{
					model.PriceUnit=row["PriceUnit"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
				if(row["ExeDate"]!=null && row["ExeDate"].ToString()!="")
				{
					model.ExeDate=DateTime.Parse(row["ExeDate"].ToString());
				}
				if(row["SetNo"]!=null && row["SetNo"].ToString()!="")
				{
					model.SetNo=int.Parse(row["SetNo"].ToString());
				}
				if(row["SuiteNo"]!=null && row["SuiteNo"].ToString()!="")
				{
					model.SuiteNo=int.Parse(row["SuiteNo"].ToString());
				}
				if(row["GroupPriceNo"]!=null && row["GroupPriceNo"].ToString()!="")
				{
					model.GroupPriceNo=int.Parse(row["GroupPriceNo"].ToString());
				}
				if(row["PriceTypeCode"]!=null)
				{
					model.PriceTypeCode=row["PriceTypeCode"].ToString();
				}
				if(row["IsStartStar"]!=null && row["IsStartStar"].ToString()!="")
				{
					model.IsStartStar=int.Parse(row["IsStartStar"].ToString());
				}
				if(row["IsStartPeople"]!=null && row["IsStartPeople"].ToString()!="")
				{
					model.IsStartPeople=int.Parse(row["IsStartPeople"].ToString());
				}
				if(row["PeopleCheck"]!=null && row["PeopleCheck"].ToString()!="")
				{
					model.PeopleCheck=int.Parse(row["PeopleCheck"].ToString());
				}
				if(row["MaxPeople"]!=null && row["MaxPeople"].ToString()!="")
				{
					model.MaxPeople=int.Parse(row["MaxPeople"].ToString());
				}
				if(row["AddUseNumber"]!=null && row["AddUseNumber"].ToString()!="")
				{
					model.AddUseNumber=decimal.Parse(row["AddUseNumber"].ToString());
				}
				if(row["StarsLevel"]!=null && row["StarsLevel"].ToString()!="")
				{
					model.StarsLevel=int.Parse(row["StarsLevel"].ToString());
				}
				if(row["StarsPeriod"]!=null && row["StarsPeriod"].ToString()!="")
				{
					model.StarsPeriod=int.Parse(row["StarsPeriod"].ToString());
				}
				if(row["StarsCorrected"]!=null && row["StarsCorrected"].ToString()!="")
				{
					model.StarsCorrected=int.Parse(row["StarsCorrected"].ToString());
				}
				if(row["IsStartArea"]!=null && row["IsStartArea"].ToString()!="")
				{
					model.IsStartArea=int.Parse(row["IsStartArea"].ToString());
				}
				if(row["Coefficient"]!=null && row["Coefficient"].ToString()!="")
				{
					model.Coefficient=decimal.Parse(row["Coefficient"].ToString());
				}
				if(row["CalculateDay"]!=null && row["CalculateDay"].ToString()!="")
				{
					model.CalculateDay=int.Parse(row["CalculateDay"].ToString());
				}
				if(row["StarsAreaWay"]!=null && row["StarsAreaWay"].ToString()!="")
				{
					model.StarsAreaWay=int.Parse(row["StarsAreaWay"].ToString());
				}
				if(row["StarsByUser"]!=null && row["StarsByUser"].ToString()!="")
				{
					model.StarsByUser=int.Parse(row["StarsByUser"].ToString());
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
			strSql.Append("select PriceTypeID,PriceTypeName,MeterTypeID,PriceNo,Price,Price2,Price3,Divid1,Divid2,PriceUnit,Remark,Price4,Price5,Price6,Divid3,Divid4,Divid5,ExeDate,SetNo,SuiteNo,GroupPriceNo,PriceTypeCode,IsStartStar,IsStartPeople,PeopleCheck,MaxPeople,AddUseNumber,StarsLevel,StarsPeriod,StarsCorrected,IsStartArea,Coefficient,CalculateDay,StarsAreaWay,StarsByUser ");
			strSql.Append(" FROM PriceType ");
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
			strSql.Append(" PriceTypeID,PriceTypeName,MeterTypeID,PriceNo,Price,Price2,Price3,Divid1,Divid2,PriceUnit,Remark,Price4,Price5,Price6,Divid3,Divid4,Divid5,ExeDate,SetNo,SuiteNo,GroupPriceNo,PriceTypeCode,IsStartStar,IsStartPeople,PeopleCheck,MaxPeople,AddUseNumber,StarsLevel,StarsPeriod,StarsCorrected,IsStartArea,Coefficient,CalculateDay,StarsAreaWay,StarsByUser ");
			strSql.Append(" FROM PriceType ");
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
			strSql.Append("select count(1) FROM PriceType ");
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
				strSql.Append("order by T.PriceTypeID desc");
			}
			strSql.Append(")AS Row, T.*  from PriceType T ");
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
			parameters[0].Value = "PriceType";
			parameters[1].Value = "PriceTypeID";
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

