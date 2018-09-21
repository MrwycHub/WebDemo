using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:FreezeMonth
	/// </summary>
	public partial class FreezeMonth
	{
		public FreezeMonth()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeterID", "FreezeMonth"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeterID,string FreezeMonth,DateTime ReadDate,int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FreezeMonth");
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
		public int Add(WebDemo.Model.WebDemo.FreezeMonth model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FreezeMonth(");
			strSql.Append("MeterID,FreezeMonth,FreezeNumber,ReadDate,CalMark,InstantNumber,PileNumber,Watertemp,BackWatertemp,WorkDate,FactDate,BatteryState,Warning,ReadType,OldFreezeNumber,Megabit,AdditionNum,SmallImagePath,BigImagePath,LocationX,LocationY,Remark,TakePhotoDate,SyncFlag,PriceSetNo,CollectorReadDate,ActiveSharp,ActivePeak,ActiveShoulder,ActiveOffPeak,MeterStatusString,VerifyValue,Remnant,ValveState)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@FreezeMonth,@FreezeNumber,@ReadDate,@CalMark,@InstantNumber,@PileNumber,@Watertemp,@BackWatertemp,@WorkDate,@FactDate,@BatteryState,@Warning,@ReadType,@OldFreezeNumber,@Megabit,@AdditionNum,@SmallImagePath,@BigImagePath,@LocationX,@LocationY,@Remark,@TakePhotoDate,@SyncFlag,@PriceSetNo,@CollectorReadDate,@ActiveSharp,@ActivePeak,@ActiveShoulder,@ActiveOffPeak,@MeterStatusString,@VerifyValue,@Remnant,@ValveState)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FreezeMonth", SqlDbType.Char,7),
					new SqlParameter("@FreezeNumber", SqlDbType.Decimal,9),
					new SqlParameter("@ReadDate", SqlDbType.DateTime),
					new SqlParameter("@CalMark", SqlDbType.Bit,1),
					new SqlParameter("@InstantNumber", SqlDbType.Decimal,9),
					new SqlParameter("@PileNumber", SqlDbType.Decimal,9),
					new SqlParameter("@Watertemp", SqlDbType.Decimal,9),
					new SqlParameter("@BackWatertemp", SqlDbType.Decimal,9),
					new SqlParameter("@WorkDate", SqlDbType.Int,4),
					new SqlParameter("@FactDate", SqlDbType.VarChar,50),
					new SqlParameter("@BatteryState", SqlDbType.Int,4),
					new SqlParameter("@Warning", SqlDbType.Int,4),
					new SqlParameter("@ReadType", SqlDbType.Int,4),
					new SqlParameter("@OldFreezeNumber", SqlDbType.Decimal,9),
					new SqlParameter("@Megabit", SqlDbType.Int,4),
					new SqlParameter("@AdditionNum", SqlDbType.Decimal,9),
					new SqlParameter("@SmallImagePath", SqlDbType.VarChar,500),
					new SqlParameter("@BigImagePath", SqlDbType.VarChar,500),
					new SqlParameter("@LocationX", SqlDbType.Decimal,9),
					new SqlParameter("@LocationY", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@TakePhotoDate", SqlDbType.DateTime),
					new SqlParameter("@SyncFlag", SqlDbType.Int,4),
					new SqlParameter("@PriceSetNo", SqlDbType.Int,4),
					new SqlParameter("@CollectorReadDate", SqlDbType.DateTime),
					new SqlParameter("@ActiveSharp", SqlDbType.Decimal,9),
					new SqlParameter("@ActivePeak", SqlDbType.Decimal,9),
					new SqlParameter("@ActiveShoulder", SqlDbType.Decimal,9),
					new SqlParameter("@ActiveOffPeak", SqlDbType.Decimal,9),
					new SqlParameter("@MeterStatusString", SqlDbType.VarChar,1000),
					new SqlParameter("@VerifyValue", SqlDbType.Int,4),
					new SqlParameter("@Remnant", SqlDbType.Decimal,9),
					new SqlParameter("@ValveState", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.FreezeMonth;
			parameters[2].Value = model.FreezeNumber;
			parameters[3].Value = model.ReadDate;
			parameters[4].Value = model.CalMark;
			parameters[5].Value = model.InstantNumber;
			parameters[6].Value = model.PileNumber;
			parameters[7].Value = model.Watertemp;
			parameters[8].Value = model.BackWatertemp;
			parameters[9].Value = model.WorkDate;
			parameters[10].Value = model.FactDate;
			parameters[11].Value = model.BatteryState;
			parameters[12].Value = model.Warning;
			parameters[13].Value = model.ReadType;
			parameters[14].Value = model.OldFreezeNumber;
			parameters[15].Value = model.Megabit;
			parameters[16].Value = model.AdditionNum;
			parameters[17].Value = model.SmallImagePath;
			parameters[18].Value = model.BigImagePath;
			parameters[19].Value = model.LocationX;
			parameters[20].Value = model.LocationY;
			parameters[21].Value = model.Remark;
			parameters[22].Value = model.TakePhotoDate;
			parameters[23].Value = model.SyncFlag;
			parameters[24].Value = model.PriceSetNo;
			parameters[25].Value = model.CollectorReadDate;
			parameters[26].Value = model.ActiveSharp;
			parameters[27].Value = model.ActivePeak;
			parameters[28].Value = model.ActiveShoulder;
			parameters[29].Value = model.ActiveOffPeak;
			parameters[30].Value = model.MeterStatusString;
			parameters[31].Value = model.VerifyValue;
			parameters[32].Value = model.Remnant;
			parameters[33].Value = model.ValveState;

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
		public bool Update(WebDemo.Model.WebDemo.FreezeMonth model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FreezeMonth set ");
			strSql.Append("FreezeNumber=@FreezeNumber,");
			strSql.Append("CalMark=@CalMark,");
			strSql.Append("InstantNumber=@InstantNumber,");
			strSql.Append("PileNumber=@PileNumber,");
			strSql.Append("Watertemp=@Watertemp,");
			strSql.Append("BackWatertemp=@BackWatertemp,");
			strSql.Append("WorkDate=@WorkDate,");
			strSql.Append("FactDate=@FactDate,");
			strSql.Append("BatteryState=@BatteryState,");
			strSql.Append("Warning=@Warning,");
			strSql.Append("ReadType=@ReadType,");
			strSql.Append("OldFreezeNumber=@OldFreezeNumber,");
			strSql.Append("Megabit=@Megabit,");
			strSql.Append("AdditionNum=@AdditionNum,");
			strSql.Append("SmallImagePath=@SmallImagePath,");
			strSql.Append("BigImagePath=@BigImagePath,");
			strSql.Append("LocationX=@LocationX,");
			strSql.Append("LocationY=@LocationY,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("TakePhotoDate=@TakePhotoDate,");
			strSql.Append("SyncFlag=@SyncFlag,");
			strSql.Append("PriceSetNo=@PriceSetNo,");
			strSql.Append("CollectorReadDate=@CollectorReadDate,");
			strSql.Append("ActiveSharp=@ActiveSharp,");
			strSql.Append("ActivePeak=@ActivePeak,");
			strSql.Append("ActiveShoulder=@ActiveShoulder,");
			strSql.Append("ActiveOffPeak=@ActiveOffPeak,");
			strSql.Append("MeterStatusString=@MeterStatusString,");
			strSql.Append("VerifyValue=@VerifyValue,");
			strSql.Append("Remnant=@Remnant,");
			strSql.Append("ValveState=@ValveState");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FreezeNumber", SqlDbType.Decimal,9),
					new SqlParameter("@CalMark", SqlDbType.Bit,1),
					new SqlParameter("@InstantNumber", SqlDbType.Decimal,9),
					new SqlParameter("@PileNumber", SqlDbType.Decimal,9),
					new SqlParameter("@Watertemp", SqlDbType.Decimal,9),
					new SqlParameter("@BackWatertemp", SqlDbType.Decimal,9),
					new SqlParameter("@WorkDate", SqlDbType.Int,4),
					new SqlParameter("@FactDate", SqlDbType.VarChar,50),
					new SqlParameter("@BatteryState", SqlDbType.Int,4),
					new SqlParameter("@Warning", SqlDbType.Int,4),
					new SqlParameter("@ReadType", SqlDbType.Int,4),
					new SqlParameter("@OldFreezeNumber", SqlDbType.Decimal,9),
					new SqlParameter("@Megabit", SqlDbType.Int,4),
					new SqlParameter("@AdditionNum", SqlDbType.Decimal,9),
					new SqlParameter("@SmallImagePath", SqlDbType.VarChar,500),
					new SqlParameter("@BigImagePath", SqlDbType.VarChar,500),
					new SqlParameter("@LocationX", SqlDbType.Decimal,9),
					new SqlParameter("@LocationY", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@TakePhotoDate", SqlDbType.DateTime),
					new SqlParameter("@SyncFlag", SqlDbType.Int,4),
					new SqlParameter("@PriceSetNo", SqlDbType.Int,4),
					new SqlParameter("@CollectorReadDate", SqlDbType.DateTime),
					new SqlParameter("@ActiveSharp", SqlDbType.Decimal,9),
					new SqlParameter("@ActivePeak", SqlDbType.Decimal,9),
					new SqlParameter("@ActiveShoulder", SqlDbType.Decimal,9),
					new SqlParameter("@ActiveOffPeak", SqlDbType.Decimal,9),
					new SqlParameter("@MeterStatusString", SqlDbType.VarChar,1000),
					new SqlParameter("@VerifyValue", SqlDbType.Int,4),
					new SqlParameter("@Remnant", SqlDbType.Decimal,9),
					new SqlParameter("@ValveState", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FreezeMonth", SqlDbType.Char,7),
					new SqlParameter("@ReadDate", SqlDbType.DateTime)};
			parameters[0].Value = model.FreezeNumber;
			parameters[1].Value = model.CalMark;
			parameters[2].Value = model.InstantNumber;
			parameters[3].Value = model.PileNumber;
			parameters[4].Value = model.Watertemp;
			parameters[5].Value = model.BackWatertemp;
			parameters[6].Value = model.WorkDate;
			parameters[7].Value = model.FactDate;
			parameters[8].Value = model.BatteryState;
			parameters[9].Value = model.Warning;
			parameters[10].Value = model.ReadType;
			parameters[11].Value = model.OldFreezeNumber;
			parameters[12].Value = model.Megabit;
			parameters[13].Value = model.AdditionNum;
			parameters[14].Value = model.SmallImagePath;
			parameters[15].Value = model.BigImagePath;
			parameters[16].Value = model.LocationX;
			parameters[17].Value = model.LocationY;
			parameters[18].Value = model.Remark;
			parameters[19].Value = model.TakePhotoDate;
			parameters[20].Value = model.SyncFlag;
			parameters[21].Value = model.PriceSetNo;
			parameters[22].Value = model.CollectorReadDate;
			parameters[23].Value = model.ActiveSharp;
			parameters[24].Value = model.ActivePeak;
			parameters[25].Value = model.ActiveShoulder;
			parameters[26].Value = model.ActiveOffPeak;
			parameters[27].Value = model.MeterStatusString;
			parameters[28].Value = model.VerifyValue;
			parameters[29].Value = model.Remnant;
			parameters[30].Value = model.ValveState;
			parameters[31].Value = model.ID;
			parameters[32].Value = model.MeterID;
			parameters[33].Value = model.FreezeMonth;
			parameters[34].Value = model.ReadDate;

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
			strSql.Append("delete from FreezeMonth ");
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
			strSql.Append("delete from FreezeMonth ");
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
			strSql.Append("delete from FreezeMonth ");
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
		public WebDemo.Model.WebDemo.FreezeMonth GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MeterID,FreezeMonth,FreezeNumber,ReadDate,CalMark,InstantNumber,PileNumber,Watertemp,BackWatertemp,WorkDate,FactDate,BatteryState,Warning,ReadType,OldFreezeNumber,Megabit,AdditionNum,SmallImagePath,BigImagePath,LocationX,LocationY,Remark,TakePhotoDate,SyncFlag,PriceSetNo,CollectorReadDate,ActiveSharp,ActivePeak,ActiveShoulder,ActiveOffPeak,MeterStatusString,VerifyValue,Remnant,ValveState from FreezeMonth ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.FreezeMonth model=new WebDemo.Model.WebDemo.FreezeMonth();
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
		public WebDemo.Model.WebDemo.FreezeMonth DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.FreezeMonth model=new WebDemo.Model.WebDemo.FreezeMonth();
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
				if(row["CalMark"]!=null && row["CalMark"].ToString()!="")
				{
					if((row["CalMark"].ToString()=="1")||(row["CalMark"].ToString().ToLower()=="true"))
					{
						model.CalMark=true;
					}
					else
					{
						model.CalMark=false;
					}
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
				if(row["ReadType"]!=null && row["ReadType"].ToString()!="")
				{
					model.ReadType=int.Parse(row["ReadType"].ToString());
				}
				if(row["OldFreezeNumber"]!=null && row["OldFreezeNumber"].ToString()!="")
				{
					model.OldFreezeNumber=decimal.Parse(row["OldFreezeNumber"].ToString());
				}
				if(row["Megabit"]!=null && row["Megabit"].ToString()!="")
				{
					model.Megabit=int.Parse(row["Megabit"].ToString());
				}
				if(row["AdditionNum"]!=null && row["AdditionNum"].ToString()!="")
				{
					model.AdditionNum=decimal.Parse(row["AdditionNum"].ToString());
				}
				if(row["SmallImagePath"]!=null)
				{
					model.SmallImagePath=row["SmallImagePath"].ToString();
				}
				if(row["BigImagePath"]!=null)
				{
					model.BigImagePath=row["BigImagePath"].ToString();
				}
				if(row["LocationX"]!=null && row["LocationX"].ToString()!="")
				{
					model.LocationX=decimal.Parse(row["LocationX"].ToString());
				}
				if(row["LocationY"]!=null && row["LocationY"].ToString()!="")
				{
					model.LocationY=decimal.Parse(row["LocationY"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["TakePhotoDate"]!=null && row["TakePhotoDate"].ToString()!="")
				{
					model.TakePhotoDate=DateTime.Parse(row["TakePhotoDate"].ToString());
				}
				if(row["SyncFlag"]!=null && row["SyncFlag"].ToString()!="")
				{
					model.SyncFlag=int.Parse(row["SyncFlag"].ToString());
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
				if(row["MeterStatusString"]!=null)
				{
					model.MeterStatusString=row["MeterStatusString"].ToString();
				}
				if(row["VerifyValue"]!=null && row["VerifyValue"].ToString()!="")
				{
					model.VerifyValue=int.Parse(row["VerifyValue"].ToString());
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
			strSql.Append("select ID,MeterID,FreezeMonth,FreezeNumber,ReadDate,CalMark,InstantNumber,PileNumber,Watertemp,BackWatertemp,WorkDate,FactDate,BatteryState,Warning,ReadType,OldFreezeNumber,Megabit,AdditionNum,SmallImagePath,BigImagePath,LocationX,LocationY,Remark,TakePhotoDate,SyncFlag,PriceSetNo,CollectorReadDate,ActiveSharp,ActivePeak,ActiveShoulder,ActiveOffPeak,MeterStatusString,VerifyValue,Remnant,ValveState ");
			strSql.Append(" FROM FreezeMonth ");
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
			strSql.Append(" ID,MeterID,FreezeMonth,FreezeNumber,ReadDate,CalMark,InstantNumber,PileNumber,Watertemp,BackWatertemp,WorkDate,FactDate,BatteryState,Warning,ReadType,OldFreezeNumber,Megabit,AdditionNum,SmallImagePath,BigImagePath,LocationX,LocationY,Remark,TakePhotoDate,SyncFlag,PriceSetNo,CollectorReadDate,ActiveSharp,ActivePeak,ActiveShoulder,ActiveOffPeak,MeterStatusString,VerifyValue,Remnant,ValveState ");
			strSql.Append(" FROM FreezeMonth ");
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
			strSql.Append("select count(1) FROM FreezeMonth ");
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
			strSql.Append(")AS Row, T.*  from FreezeMonth T ");
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
			parameters[0].Value = "FreezeMonth";
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

