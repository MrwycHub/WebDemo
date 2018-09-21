using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MeterImageData
	/// </summary>
	public partial class MeterImageData
	{
		public MeterImageData()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeterID", "MeterImageData"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeterID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MeterImageData");
			strSql.Append(" where MeterID=@MeterID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.MeterImageData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MeterImageData(");
			strSql.Append("MeterID,ReadTime,Voltage,ValveState,LowVoltage,MagneticDisturb,ImageQuality,EnableUpload,MeterImage,InsertDate,FreezeNumber,LeftMeterImage,RightMeterImage)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@ReadTime,@Voltage,@ValveState,@LowVoltage,@MagneticDisturb,@ImageQuality,@EnableUpload,@MeterImage,@InsertDate,@FreezeNumber,@LeftMeterImage,@RightMeterImage)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@ReadTime", SqlDbType.DateTime),
					new SqlParameter("@Voltage", SqlDbType.Decimal,9),
					new SqlParameter("@ValveState", SqlDbType.Int,4),
					new SqlParameter("@LowVoltage", SqlDbType.Bit,1),
					new SqlParameter("@MagneticDisturb", SqlDbType.Bit,1),
					new SqlParameter("@ImageQuality", SqlDbType.Int,4),
					new SqlParameter("@EnableUpload", SqlDbType.Bit,1),
					new SqlParameter("@MeterImage", SqlDbType.VarBinary,-1),
					new SqlParameter("@InsertDate", SqlDbType.DateTime),
					new SqlParameter("@FreezeNumber", SqlDbType.Decimal,9),
					new SqlParameter("@LeftMeterImage", SqlDbType.VarBinary,-1),
					new SqlParameter("@RightMeterImage", SqlDbType.VarBinary,-1)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.ReadTime;
			parameters[2].Value = model.Voltage;
			parameters[3].Value = model.ValveState;
			parameters[4].Value = model.LowVoltage;
			parameters[5].Value = model.MagneticDisturb;
			parameters[6].Value = model.ImageQuality;
			parameters[7].Value = model.EnableUpload;
			parameters[8].Value = model.MeterImage;
			parameters[9].Value = model.InsertDate;
			parameters[10].Value = model.FreezeNumber;
			parameters[11].Value = model.LeftMeterImage;
			parameters[12].Value = model.RightMeterImage;

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
		public bool Update(WebDemo.Model.WebDemo.MeterImageData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MeterImageData set ");
			strSql.Append("ReadTime=@ReadTime,");
			strSql.Append("Voltage=@Voltage,");
			strSql.Append("ValveState=@ValveState,");
			strSql.Append("LowVoltage=@LowVoltage,");
			strSql.Append("MagneticDisturb=@MagneticDisturb,");
			strSql.Append("ImageQuality=@ImageQuality,");
			strSql.Append("EnableUpload=@EnableUpload,");
			strSql.Append("MeterImage=@MeterImage,");
			strSql.Append("InsertDate=@InsertDate,");
			strSql.Append("FreezeNumber=@FreezeNumber,");
			strSql.Append("LeftMeterImage=@LeftMeterImage,");
			strSql.Append("RightMeterImage=@RightMeterImage");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ReadTime", SqlDbType.DateTime),
					new SqlParameter("@Voltage", SqlDbType.Decimal,9),
					new SqlParameter("@ValveState", SqlDbType.Int,4),
					new SqlParameter("@LowVoltage", SqlDbType.Bit,1),
					new SqlParameter("@MagneticDisturb", SqlDbType.Bit,1),
					new SqlParameter("@ImageQuality", SqlDbType.Int,4),
					new SqlParameter("@EnableUpload", SqlDbType.Bit,1),
					new SqlParameter("@MeterImage", SqlDbType.VarBinary,-1),
					new SqlParameter("@InsertDate", SqlDbType.DateTime),
					new SqlParameter("@FreezeNumber", SqlDbType.Decimal,9),
					new SqlParameter("@LeftMeterImage", SqlDbType.VarBinary,-1),
					new SqlParameter("@RightMeterImage", SqlDbType.VarBinary,-1),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MeterID", SqlDbType.Int,4)};
			parameters[0].Value = model.ReadTime;
			parameters[1].Value = model.Voltage;
			parameters[2].Value = model.ValveState;
			parameters[3].Value = model.LowVoltage;
			parameters[4].Value = model.MagneticDisturb;
			parameters[5].Value = model.ImageQuality;
			parameters[6].Value = model.EnableUpload;
			parameters[7].Value = model.MeterImage;
			parameters[8].Value = model.InsertDate;
			parameters[9].Value = model.FreezeNumber;
			parameters[10].Value = model.LeftMeterImage;
			parameters[11].Value = model.RightMeterImage;
			parameters[12].Value = model.ID;
			parameters[13].Value = model.MeterID;

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
			strSql.Append("delete from MeterImageData ");
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
		public bool Delete(int MeterID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeterImageData ");
			strSql.Append(" where MeterID=@MeterID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;

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
			strSql.Append("delete from MeterImageData ");
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
		public WebDemo.Model.WebDemo.MeterImageData GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MeterID,ReadTime,Voltage,ValveState,LowVoltage,MagneticDisturb,ImageQuality,EnableUpload,MeterImage,InsertDate,FreezeNumber,LeftMeterImage,RightMeterImage from MeterImageData ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.MeterImageData model=new WebDemo.Model.WebDemo.MeterImageData();
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
		public WebDemo.Model.WebDemo.MeterImageData DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MeterImageData model=new WebDemo.Model.WebDemo.MeterImageData();
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
				if(row["ReadTime"]!=null && row["ReadTime"].ToString()!="")
				{
					model.ReadTime=DateTime.Parse(row["ReadTime"].ToString());
				}
				if(row["Voltage"]!=null && row["Voltage"].ToString()!="")
				{
					model.Voltage=decimal.Parse(row["Voltage"].ToString());
				}
				if(row["ValveState"]!=null && row["ValveState"].ToString()!="")
				{
					model.ValveState=int.Parse(row["ValveState"].ToString());
				}
				if(row["LowVoltage"]!=null && row["LowVoltage"].ToString()!="")
				{
					if((row["LowVoltage"].ToString()=="1")||(row["LowVoltage"].ToString().ToLower()=="true"))
					{
						model.LowVoltage=true;
					}
					else
					{
						model.LowVoltage=false;
					}
				}
				if(row["MagneticDisturb"]!=null && row["MagneticDisturb"].ToString()!="")
				{
					if((row["MagneticDisturb"].ToString()=="1")||(row["MagneticDisturb"].ToString().ToLower()=="true"))
					{
						model.MagneticDisturb=true;
					}
					else
					{
						model.MagneticDisturb=false;
					}
				}
				if(row["ImageQuality"]!=null && row["ImageQuality"].ToString()!="")
				{
					model.ImageQuality=int.Parse(row["ImageQuality"].ToString());
				}
				if(row["EnableUpload"]!=null && row["EnableUpload"].ToString()!="")
				{
					if((row["EnableUpload"].ToString()=="1")||(row["EnableUpload"].ToString().ToLower()=="true"))
					{
						model.EnableUpload=true;
					}
					else
					{
						model.EnableUpload=false;
					}
				}
				if(row["MeterImage"]!=null && row["MeterImage"].ToString()!="")
				{
					model.MeterImage=(byte[])row["MeterImage"];
				}
				if(row["InsertDate"]!=null && row["InsertDate"].ToString()!="")
				{
					model.InsertDate=DateTime.Parse(row["InsertDate"].ToString());
				}
				if(row["FreezeNumber"]!=null && row["FreezeNumber"].ToString()!="")
				{
					model.FreezeNumber=decimal.Parse(row["FreezeNumber"].ToString());
				}
				if(row["LeftMeterImage"]!=null && row["LeftMeterImage"].ToString()!="")
				{
					model.LeftMeterImage=(byte[])row["LeftMeterImage"];
				}
				if(row["RightMeterImage"]!=null && row["RightMeterImage"].ToString()!="")
				{
					model.RightMeterImage=(byte[])row["RightMeterImage"];
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
			strSql.Append("select ID,MeterID,ReadTime,Voltage,ValveState,LowVoltage,MagneticDisturb,ImageQuality,EnableUpload,MeterImage,InsertDate,FreezeNumber,LeftMeterImage,RightMeterImage ");
			strSql.Append(" FROM MeterImageData ");
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
			strSql.Append(" ID,MeterID,ReadTime,Voltage,ValveState,LowVoltage,MagneticDisturb,ImageQuality,EnableUpload,MeterImage,InsertDate,FreezeNumber,LeftMeterImage,RightMeterImage ");
			strSql.Append(" FROM MeterImageData ");
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
			strSql.Append("select count(1) FROM MeterImageData ");
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
			strSql.Append(")AS Row, T.*  from MeterImageData T ");
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
			parameters[0].Value = "MeterImageData";
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

