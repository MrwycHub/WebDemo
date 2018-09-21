﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:FreezeMonthLog
	/// </summary>
	public partial class FreezeMonthLog
	{
		public FreezeMonthLog()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeterID", "FreezeMonthLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeterID,string FreezeMonth,DateTime ReadDate,int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FreezeMonthLog");
			strSql.Append(" where MeterID=@MeterID and FreezeMonth=@FreezeMonth and ReadDate=@ReadDate and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FreezeMonth", SqlDbType.Char,7),
					new SqlParameter("@ReadDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;
			parameters[1].Value = FreezeMonth;
			parameters[2].Value = ReadDate;
			parameters[3].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.FreezeMonthLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FreezeMonthLog(");
			strSql.Append("MeterID,FreezeMonth,FreezeNumber,ReadDate,InstantNumber,PileNumber,Watertemp,BackWatertemp,WorkDate,FactDate,BatteryState,Warning,OldFreezeNumber,Megabit,PriceSetNo,CollectorReadDate,ActiveSharp,ActivePeak,ActiveShoulder,ActiveOffPeak,Remnant,ValveState)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@FreezeMonth,@FreezeNumber,@ReadDate,@InstantNumber,@PileNumber,@Watertemp,@BackWatertemp,@WorkDate,@FactDate,@BatteryState,@Warning,@OldFreezeNumber,@Megabit,@PriceSetNo,@CollectorReadDate,@ActiveSharp,@ActivePeak,@ActiveShoulder,@ActiveOffPeak,@Remnant,@ValveState)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FreezeMonth", SqlDbType.Char,7),
					new SqlParameter("@FreezeNumber", SqlDbType.Decimal,9),
					new SqlParameter("@ReadDate", SqlDbType.DateTime),
					new SqlParameter("@InstantNumber", SqlDbType.Decimal,9),
					new SqlParameter("@PileNumber", SqlDbType.Decimal,9),
					new SqlParameter("@Watertemp", SqlDbType.Decimal,9),
					new SqlParameter("@BackWatertemp", SqlDbType.Decimal,9),
					new SqlParameter("@WorkDate", SqlDbType.Int,4),
					new SqlParameter("@FactDate", SqlDbType.VarChar,50),
					new SqlParameter("@BatteryState", SqlDbType.Int,4),
					new SqlParameter("@Warning", SqlDbType.Int,4),
					new SqlParameter("@OldFreezeNumber", SqlDbType.Decimal,9),
					new SqlParameter("@Megabit", SqlDbType.Int,4),
					new SqlParameter("@PriceSetNo", SqlDbType.Int,4),
					new SqlParameter("@CollectorReadDate", SqlDbType.DateTime),
					new SqlParameter("@ActiveSharp", SqlDbType.Decimal,9),
					new SqlParameter("@ActivePeak", SqlDbType.Decimal,9),
					new SqlParameter("@ActiveShoulder", SqlDbType.Decimal,9),
					new SqlParameter("@ActiveOffPeak", SqlDbType.Decimal,9),
					new SqlParameter("@Remnant", SqlDbType.Decimal,9),
					new SqlParameter("@ValveState", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.FreezeMonth;
			parameters[2].Value = model.FreezeNumber;
			parameters[3].Value = model.ReadDate;
			parameters[4].Value = model.InstantNumber;
			parameters[5].Value = model.PileNumber;
			parameters[6].Value = model.Watertemp;
			parameters[7].Value = model.BackWatertemp;
			parameters[8].Value = model.WorkDate;
			parameters[9].Value = model.FactDate;
			parameters[10].Value = model.BatteryState;
			parameters[11].Value = model.Warning;
			parameters[12].Value = model.OldFreezeNumber;
			parameters[13].Value = model.Megabit;
			parameters[14].Value = model.PriceSetNo;
			parameters[15].Value = model.CollectorReadDate;
			parameters[16].Value = model.ActiveSharp;
			parameters[17].Value = model.ActivePeak;
			parameters[18].Value = model.ActiveShoulder;
			parameters[19].Value = model.ActiveOffPeak;
			parameters[20].Value = model.Remnant;
			parameters[21].Value = model.ValveState;

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
		public bool Update(WebDemo.Model.WebDemo.FreezeMonthLog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FreezeMonthLog set ");
			strSql.Append("FreezeNumber=@FreezeNumber,");
			strSql.Append("InstantNumber=@InstantNumber,");
			strSql.Append("PileNumber=@PileNumber,");
			strSql.Append("Watertemp=@Watertemp,");
			strSql.Append("BackWatertemp=@BackWatertemp,");
			strSql.Append("WorkDate=@WorkDate,");
			strSql.Append("FactDate=@FactDate,");
			strSql.Append("BatteryState=@BatteryState,");
			strSql.Append("Warning=@Warning,");
			strSql.Append("OldFreezeNumber=@OldFreezeNumber,");
			strSql.Append("Megabit=@Megabit,");
			strSql.Append("PriceSetNo=@PriceSetNo,");
			strSql.Append("CollectorReadDate=@CollectorReadDate,");
			strSql.Append("ActiveSharp=@ActiveSharp,");
			strSql.Append("ActivePeak=@ActivePeak,");
			strSql.Append("ActiveShoulder=@ActiveShoulder,");
			strSql.Append("ActiveOffPeak=@ActiveOffPeak,");
			strSql.Append("Remnant=@Remnant,");
			strSql.Append("ValveState=@ValveState");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FreezeNumber", SqlDbType.Decimal,9),
					new SqlParameter("@InstantNumber", SqlDbType.Decimal,9),
					new SqlParameter("@PileNumber", SqlDbType.Decimal,9),
					new SqlParameter("@Watertemp", SqlDbType.Decimal,9),
					new SqlParameter("@BackWatertemp", SqlDbType.Decimal,9),
					new SqlParameter("@WorkDate", SqlDbType.Int,4),
					new SqlParameter("@FactDate", SqlDbType.VarChar,50),
					new SqlParameter("@BatteryState", SqlDbType.Int,4),
					new SqlParameter("@Warning", SqlDbType.Int,4),
					new SqlParameter("@OldFreezeNumber", SqlDbType.Decimal,9),
					new SqlParameter("@Megabit", SqlDbType.Int,4),
					new SqlParameter("@PriceSetNo", SqlDbType.Int,4),
					new SqlParameter("@CollectorReadDate", SqlDbType.DateTime),
					new SqlParameter("@ActiveSharp", SqlDbType.Decimal,9),
					new SqlParameter("@ActivePeak", SqlDbType.Decimal,9),
					new SqlParameter("@ActiveShoulder", SqlDbType.Decimal,9),
					new SqlParameter("@ActiveOffPeak", SqlDbType.Decimal,9),
					new SqlParameter("@Remnant", SqlDbType.Decimal,9),
					new SqlParameter("@ValveState", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FreezeMonth", SqlDbType.Char,7),
					new SqlParameter("@ReadDate", SqlDbType.DateTime)};
			parameters[0].Value = model.FreezeNumber;
			parameters[1].Value = model.InstantNumber;
			parameters[2].Value = model.PileNumber;
			parameters[3].Value = model.Watertemp;
			parameters[4].Value = model.BackWatertemp;
			parameters[5].Value = model.WorkDate;
			parameters[6].Value = model.FactDate;
			parameters[7].Value = model.BatteryState;
			parameters[8].Value = model.Warning;
			parameters[9].Value = model.OldFreezeNumber;
			parameters[10].Value = model.Megabit;
			parameters[11].Value = model.PriceSetNo;
			parameters[12].Value = model.CollectorReadDate;
			parameters[13].Value = model.ActiveSharp;
			parameters[14].Value = model.ActivePeak;
			parameters[15].Value = model.ActiveShoulder;
			parameters[16].Value = model.ActiveOffPeak;
			parameters[17].Value = model.Remnant;
			parameters[18].Value = model.ValveState;
			parameters[19].Value = model.ID;
			parameters[20].Value = model.MeterID;
			parameters[21].Value = model.FreezeMonth;
			parameters[22].Value = model.ReadDate;

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
			strSql.Append("delete from FreezeMonthLog ");
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int MeterID,string FreezeMonth,DateTime ReadDate,int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from FreezeMonthLog ");
			strSql.Append(" where MeterID=@MeterID and FreezeMonth=@FreezeMonth and ReadDate=@ReadDate and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FreezeMonth", SqlDbType.Char,7),
					new SqlParameter("@ReadDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;
			parameters[1].Value = FreezeMonth;
			parameters[2].Value = ReadDate;
			parameters[3].Value = ID;

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
			strSql.Append("delete from FreezeMonthLog ");
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
		public WebDemo.Model.WebDemo.FreezeMonthLog GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MeterID,FreezeMonth,FreezeNumber,ReadDate,InstantNumber,PileNumber,Watertemp,BackWatertemp,WorkDate,FactDate,BatteryState,Warning,OldFreezeNumber,Megabit,PriceSetNo,CollectorReadDate,ActiveSharp,ActivePeak,ActiveShoulder,ActiveOffPeak,Remnant,ValveState from FreezeMonthLog ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.FreezeMonthLog model=new WebDemo.Model.WebDemo.FreezeMonthLog();
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
		public WebDemo.Model.WebDemo.FreezeMonthLog DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.FreezeMonthLog model=new WebDemo.Model.WebDemo.FreezeMonthLog();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["FreezeMonth"]!=null)
				{
					model.FreezeMonth=row["FreezeMonth"].ToString();
				}
				if(row["FreezeNumber"]!=null && row["FreezeNumber"].ToString()!="")
				{
					model.FreezeNumber=decimal.Parse(row["FreezeNumber"].ToString());
				}
				if(row["ReadDate"]!=null && row["ReadDate"].ToString()!="")
				{
					model.ReadDate=DateTime.Parse(row["ReadDate"].ToString());
				}
				if(row["InstantNumber"]!=null && row["InstantNumber"].ToString()!="")
				{
					model.InstantNumber=decimal.Parse(row["InstantNumber"].ToString());
				}
				if(row["PileNumber"]!=null && row["PileNumber"].ToString()!="")
				{
					model.PileNumber=decimal.Parse(row["PileNumber"].ToString());
				}
				if(row["Watertemp"]!=null && row["Watertemp"].ToString()!="")
				{
					model.Watertemp=decimal.Parse(row["Watertemp"].ToString());
				}
				if(row["BackWatertemp"]!=null && row["BackWatertemp"].ToString()!="")
				{
					model.BackWatertemp=decimal.Parse(row["BackWatertemp"].ToString());
				}
				if(row["WorkDate"]!=null && row["WorkDate"].ToString()!="")
				{
					model.WorkDate=int.Parse(row["WorkDate"].ToString());
				}
				if(row["FactDate"]!=null)
				{
					model.FactDate=row["FactDate"].ToString();
				}
				if(row["BatteryState"]!=null && row["BatteryState"].ToString()!="")
				{
					model.BatteryState=int.Parse(row["BatteryState"].ToString());
				}
				if(row["Warning"]!=null && row["Warning"].ToString()!="")
				{
					model.Warning=int.Parse(row["Warning"].ToString());
				}
				if(row["OldFreezeNumber"]!=null && row["OldFreezeNumber"].ToString()!="")
				{
					model.OldFreezeNumber=decimal.Parse(row["OldFreezeNumber"].ToString());
				}
				if(row["Megabit"]!=null && row["Megabit"].ToString()!="")
				{
					model.Megabit=int.Parse(row["Megabit"].ToString());
				}
				if(row["PriceSetNo"]!=null && row["PriceSetNo"].ToString()!="")
				{
					model.PriceSetNo=int.Parse(row["PriceSetNo"].ToString());
				}
				if(row["CollectorReadDate"]!=null && row["CollectorReadDate"].ToString()!="")
				{
					model.CollectorReadDate=DateTime.Parse(row["CollectorReadDate"].ToString());
				}
				if(row["ActiveSharp"]!=null && row["ActiveSharp"].ToString()!="")
				{
					model.ActiveSharp=decimal.Parse(row["ActiveSharp"].ToString());
				}
				if(row["ActivePeak"]!=null && row["ActivePeak"].ToString()!="")
				{
					model.ActivePeak=decimal.Parse(row["ActivePeak"].ToString());
				}
				if(row["ActiveShoulder"]!=null && row["ActiveShoulder"].ToString()!="")
				{
					model.ActiveShoulder=decimal.Parse(row["ActiveShoulder"].ToString());
				}
				if(row["ActiveOffPeak"]!=null && row["ActiveOffPeak"].ToString()!="")
				{
					model.ActiveOffPeak=decimal.Parse(row["ActiveOffPeak"].ToString());
				}
				if(row["Remnant"]!=null && row["Remnant"].ToString()!="")
				{
					model.Remnant=decimal.Parse(row["Remnant"].ToString());
				}
				if(row["ValveState"]!=null && row["ValveState"].ToString()!="")
				{
					model.ValveState=int.Parse(row["ValveState"].ToString());
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
			strSql.Append("select ID,MeterID,FreezeMonth,FreezeNumber,ReadDate,InstantNumber,PileNumber,Watertemp,BackWatertemp,WorkDate,FactDate,BatteryState,Warning,OldFreezeNumber,Megabit,PriceSetNo,CollectorReadDate,ActiveSharp,ActivePeak,ActiveShoulder,ActiveOffPeak,Remnant,ValveState ");
			strSql.Append(" FROM FreezeMonthLog ");
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
			strSql.Append(" ID,MeterID,FreezeMonth,FreezeNumber,ReadDate,InstantNumber,PileNumber,Watertemp,BackWatertemp,WorkDate,FactDate,BatteryState,Warning,OldFreezeNumber,Megabit,PriceSetNo,CollectorReadDate,ActiveSharp,ActivePeak,ActiveShoulder,ActiveOffPeak,Remnant,ValveState ");
			strSql.Append(" FROM FreezeMonthLog ");
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
			strSql.Append("select count(1) FROM FreezeMonthLog ");
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
			strSql.Append(")AS Row, T.*  from FreezeMonthLog T ");
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
			parameters[0].Value = "FreezeMonthLog";
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

