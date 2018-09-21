using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Collectors
	/// </summary>
	public partial class Collectors
	{
		public Collectors()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("CollectorID", "Collectors"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int CollectorID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Collectors");
			strSql.Append(" where CollectorID=@CollectorID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CollectorID", SqlDbType.Int,4)			};
			parameters[0].Value = CollectorID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.Collectors model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Collectors(");
			strSql.Append("CollectorID,CollectorName,CollectorAddr,CollectorType,DeptID,PhoneNumber,CollOverTime,IPNumber,PortNumber,GprsCycle,FreezeDay,FreezeHour,ReadDay,LoginDate,UpdateDate,LoginIP,LoginPort,Mark,Remark,CollectorVer,CollectorModel,CollectorAPN,IsServerMode,WorkTime,NetWorkTime,FactoryCode,FramesType,MeterAddrFormat,GprsPhone,ExpireTime,WorkMode,Lng,Lat)");
			strSql.Append(" values (");
			strSql.Append("@CollectorID,@CollectorName,@CollectorAddr,@CollectorType,@DeptID,@PhoneNumber,@CollOverTime,@IPNumber,@PortNumber,@GprsCycle,@FreezeDay,@FreezeHour,@ReadDay,@LoginDate,@UpdateDate,@LoginIP,@LoginPort,@Mark,@Remark,@CollectorVer,@CollectorModel,@CollectorAPN,@IsServerMode,@WorkTime,@NetWorkTime,@FactoryCode,@FramesType,@MeterAddrFormat,@GprsPhone,@ExpireTime,@WorkMode,@Lng,@Lat)");
			SqlParameter[] parameters = {
					new SqlParameter("@CollectorID", SqlDbType.Int,4),
					new SqlParameter("@CollectorName", SqlDbType.VarChar,50),
					new SqlParameter("@CollectorAddr", SqlDbType.VarChar,10),
					new SqlParameter("@CollectorType", SqlDbType.Int,4),
					new SqlParameter("@DeptID", SqlDbType.VarChar,50),
					new SqlParameter("@PhoneNumber", SqlDbType.VarChar,50),
					new SqlParameter("@CollOverTime", SqlDbType.Int,4),
					new SqlParameter("@IPNumber", SqlDbType.VarChar,50),
					new SqlParameter("@PortNumber", SqlDbType.Int,4),
					new SqlParameter("@GprsCycle", SqlDbType.Int,4),
					new SqlParameter("@FreezeDay", SqlDbType.Int,4),
					new SqlParameter("@FreezeHour", SqlDbType.Int,4),
					new SqlParameter("@ReadDay", SqlDbType.VarChar,10),
					new SqlParameter("@LoginDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@LoginIP", SqlDbType.VarChar,50),
					new SqlParameter("@LoginPort", SqlDbType.Int,4),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@CollectorVer", SqlDbType.VarChar,50),
					new SqlParameter("@CollectorModel", SqlDbType.VarChar,50),
					new SqlParameter("@CollectorAPN", SqlDbType.VarChar,102),
					new SqlParameter("@IsServerMode", SqlDbType.Int,4),
					new SqlParameter("@WorkTime", SqlDbType.VarChar,24),
					new SqlParameter("@NetWorkTime", SqlDbType.VarChar,24),
					new SqlParameter("@FactoryCode", SqlDbType.VarChar,50),
					new SqlParameter("@FramesType", SqlDbType.Int,4),
					new SqlParameter("@MeterAddrFormat", SqlDbType.Int,4),
					new SqlParameter("@GprsPhone", SqlDbType.VarChar,20),
					new SqlParameter("@ExpireTime", SqlDbType.VarChar,10),
					new SqlParameter("@WorkMode", SqlDbType.TinyInt,1),
					new SqlParameter("@Lng", SqlDbType.Decimal,9),
					new SqlParameter("@Lat", SqlDbType.Decimal,9)};
			parameters[0].Value = model.CollectorID;
			parameters[1].Value = model.CollectorName;
			parameters[2].Value = model.CollectorAddr;
			parameters[3].Value = model.CollectorType;
			parameters[4].Value = model.DeptID;
			parameters[5].Value = model.PhoneNumber;
			parameters[6].Value = model.CollOverTime;
			parameters[7].Value = model.IPNumber;
			parameters[8].Value = model.PortNumber;
			parameters[9].Value = model.GprsCycle;
			parameters[10].Value = model.FreezeDay;
			parameters[11].Value = model.FreezeHour;
			parameters[12].Value = model.ReadDay;
			parameters[13].Value = model.LoginDate;
			parameters[14].Value = model.UpdateDate;
			parameters[15].Value = model.LoginIP;
			parameters[16].Value = model.LoginPort;
			parameters[17].Value = model.Mark;
			parameters[18].Value = model.Remark;
			parameters[19].Value = model.CollectorVer;
			parameters[20].Value = model.CollectorModel;
			parameters[21].Value = model.CollectorAPN;
			parameters[22].Value = model.IsServerMode;
			parameters[23].Value = model.WorkTime;
			parameters[24].Value = model.NetWorkTime;
			parameters[25].Value = model.FactoryCode;
			parameters[26].Value = model.FramesType;
			parameters[27].Value = model.MeterAddrFormat;
			parameters[28].Value = model.GprsPhone;
			parameters[29].Value = model.ExpireTime;
			parameters[30].Value = model.WorkMode;
			parameters[31].Value = model.Lng;
			parameters[32].Value = model.Lat;

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
		public bool Update(WebDemo.Model.WebDemo.Collectors model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Collectors set ");
			strSql.Append("CollectorName=@CollectorName,");
			strSql.Append("CollectorAddr=@CollectorAddr,");
			strSql.Append("CollectorType=@CollectorType,");
			strSql.Append("DeptID=@DeptID,");
			strSql.Append("PhoneNumber=@PhoneNumber,");
			strSql.Append("CollOverTime=@CollOverTime,");
			strSql.Append("IPNumber=@IPNumber,");
			strSql.Append("PortNumber=@PortNumber,");
			strSql.Append("GprsCycle=@GprsCycle,");
			strSql.Append("FreezeDay=@FreezeDay,");
			strSql.Append("FreezeHour=@FreezeHour,");
			strSql.Append("ReadDay=@ReadDay,");
			strSql.Append("LoginDate=@LoginDate,");
			strSql.Append("UpdateDate=@UpdateDate,");
			strSql.Append("LoginIP=@LoginIP,");
			strSql.Append("LoginPort=@LoginPort,");
			strSql.Append("Mark=@Mark,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("CollectorVer=@CollectorVer,");
			strSql.Append("CollectorModel=@CollectorModel,");
			strSql.Append("CollectorAPN=@CollectorAPN,");
			strSql.Append("IsServerMode=@IsServerMode,");
			strSql.Append("WorkTime=@WorkTime,");
			strSql.Append("NetWorkTime=@NetWorkTime,");
			strSql.Append("FactoryCode=@FactoryCode,");
			strSql.Append("FramesType=@FramesType,");
			strSql.Append("MeterAddrFormat=@MeterAddrFormat,");
			strSql.Append("GprsPhone=@GprsPhone,");
			strSql.Append("ExpireTime=@ExpireTime,");
			strSql.Append("WorkMode=@WorkMode,");
			strSql.Append("Lng=@Lng,");
			strSql.Append("Lat=@Lat");
			strSql.Append(" where CollectorID=@CollectorID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CollectorName", SqlDbType.VarChar,50),
					new SqlParameter("@CollectorAddr", SqlDbType.VarChar,10),
					new SqlParameter("@CollectorType", SqlDbType.Int,4),
					new SqlParameter("@DeptID", SqlDbType.VarChar,50),
					new SqlParameter("@PhoneNumber", SqlDbType.VarChar,50),
					new SqlParameter("@CollOverTime", SqlDbType.Int,4),
					new SqlParameter("@IPNumber", SqlDbType.VarChar,50),
					new SqlParameter("@PortNumber", SqlDbType.Int,4),
					new SqlParameter("@GprsCycle", SqlDbType.Int,4),
					new SqlParameter("@FreezeDay", SqlDbType.Int,4),
					new SqlParameter("@FreezeHour", SqlDbType.Int,4),
					new SqlParameter("@ReadDay", SqlDbType.VarChar,10),
					new SqlParameter("@LoginDate", SqlDbType.DateTime),
					new SqlParameter("@UpdateDate", SqlDbType.DateTime),
					new SqlParameter("@LoginIP", SqlDbType.VarChar,50),
					new SqlParameter("@LoginPort", SqlDbType.Int,4),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@CollectorVer", SqlDbType.VarChar,50),
					new SqlParameter("@CollectorModel", SqlDbType.VarChar,50),
					new SqlParameter("@CollectorAPN", SqlDbType.VarChar,102),
					new SqlParameter("@IsServerMode", SqlDbType.Int,4),
					new SqlParameter("@WorkTime", SqlDbType.VarChar,24),
					new SqlParameter("@NetWorkTime", SqlDbType.VarChar,24),
					new SqlParameter("@FactoryCode", SqlDbType.VarChar,50),
					new SqlParameter("@FramesType", SqlDbType.Int,4),
					new SqlParameter("@MeterAddrFormat", SqlDbType.Int,4),
					new SqlParameter("@GprsPhone", SqlDbType.VarChar,20),
					new SqlParameter("@ExpireTime", SqlDbType.VarChar,10),
					new SqlParameter("@WorkMode", SqlDbType.TinyInt,1),
					new SqlParameter("@Lng", SqlDbType.Decimal,9),
					new SqlParameter("@Lat", SqlDbType.Decimal,9),
					new SqlParameter("@CollectorID", SqlDbType.Int,4)};
			parameters[0].Value = model.CollectorName;
			parameters[1].Value = model.CollectorAddr;
			parameters[2].Value = model.CollectorType;
			parameters[3].Value = model.DeptID;
			parameters[4].Value = model.PhoneNumber;
			parameters[5].Value = model.CollOverTime;
			parameters[6].Value = model.IPNumber;
			parameters[7].Value = model.PortNumber;
			parameters[8].Value = model.GprsCycle;
			parameters[9].Value = model.FreezeDay;
			parameters[10].Value = model.FreezeHour;
			parameters[11].Value = model.ReadDay;
			parameters[12].Value = model.LoginDate;
			parameters[13].Value = model.UpdateDate;
			parameters[14].Value = model.LoginIP;
			parameters[15].Value = model.LoginPort;
			parameters[16].Value = model.Mark;
			parameters[17].Value = model.Remark;
			parameters[18].Value = model.CollectorVer;
			parameters[19].Value = model.CollectorModel;
			parameters[20].Value = model.CollectorAPN;
			parameters[21].Value = model.IsServerMode;
			parameters[22].Value = model.WorkTime;
			parameters[23].Value = model.NetWorkTime;
			parameters[24].Value = model.FactoryCode;
			parameters[25].Value = model.FramesType;
			parameters[26].Value = model.MeterAddrFormat;
			parameters[27].Value = model.GprsPhone;
			parameters[28].Value = model.ExpireTime;
			parameters[29].Value = model.WorkMode;
			parameters[30].Value = model.Lng;
			parameters[31].Value = model.Lat;
			parameters[32].Value = model.CollectorID;

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
		public bool Delete(int CollectorID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Collectors ");
			strSql.Append(" where CollectorID=@CollectorID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CollectorID", SqlDbType.Int,4)			};
			parameters[0].Value = CollectorID;

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
		public bool DeleteList(string CollectorIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Collectors ");
			strSql.Append(" where CollectorID in ("+CollectorIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.Collectors GetModel(int CollectorID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 CollectorID,CollectorName,CollectorAddr,CollectorType,DeptID,PhoneNumber,CollOverTime,IPNumber,PortNumber,GprsCycle,FreezeDay,FreezeHour,ReadDay,LoginDate,UpdateDate,LoginIP,LoginPort,Mark,Remark,CollectorVer,CollectorModel,CollectorAPN,IsServerMode,WorkTime,NetWorkTime,FactoryCode,FramesType,MeterAddrFormat,GprsPhone,ExpireTime,WorkMode,Lng,Lat from Collectors ");
			strSql.Append(" where CollectorID=@CollectorID ");
			SqlParameter[] parameters = {
					new SqlParameter("@CollectorID", SqlDbType.Int,4)			};
			parameters[0].Value = CollectorID;

			WebDemo.Model.WebDemo.Collectors model=new WebDemo.Model.WebDemo.Collectors();
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
		public WebDemo.Model.WebDemo.Collectors DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Collectors model=new WebDemo.Model.WebDemo.Collectors();
			if (row != null)
			{
				if(row["CollectorID"]!=null && row["CollectorID"].ToString()!="")
				{
					model.CollectorID=int.Parse(row["CollectorID"].ToString());
				}
				if(row["CollectorName"]!=null)
				{
					model.CollectorName=row["CollectorName"].ToString();
				}
				if(row["CollectorAddr"]!=null)
				{
					model.CollectorAddr=row["CollectorAddr"].ToString();
				}
				if(row["CollectorType"]!=null && row["CollectorType"].ToString()!="")
				{
					model.CollectorType=int.Parse(row["CollectorType"].ToString());
				}
				if(row["DeptID"]!=null)
				{
					model.DeptID=row["DeptID"].ToString();
				}
				if(row["PhoneNumber"]!=null)
				{
					model.PhoneNumber=row["PhoneNumber"].ToString();
				}
				if(row["CollOverTime"]!=null && row["CollOverTime"].ToString()!="")
				{
					model.CollOverTime=int.Parse(row["CollOverTime"].ToString());
				}
				if(row["IPNumber"]!=null)
				{
					model.IPNumber=row["IPNumber"].ToString();
				}
				if(row["PortNumber"]!=null && row["PortNumber"].ToString()!="")
				{
					model.PortNumber=int.Parse(row["PortNumber"].ToString());
				}
				if(row["GprsCycle"]!=null && row["GprsCycle"].ToString()!="")
				{
					model.GprsCycle=int.Parse(row["GprsCycle"].ToString());
				}
				if(row["FreezeDay"]!=null && row["FreezeDay"].ToString()!="")
				{
					model.FreezeDay=int.Parse(row["FreezeDay"].ToString());
				}
				if(row["FreezeHour"]!=null && row["FreezeHour"].ToString()!="")
				{
					model.FreezeHour=int.Parse(row["FreezeHour"].ToString());
				}
				if(row["ReadDay"]!=null)
				{
					model.ReadDay=row["ReadDay"].ToString();
				}
				if(row["LoginDate"]!=null && row["LoginDate"].ToString()!="")
				{
					model.LoginDate=DateTime.Parse(row["LoginDate"].ToString());
				}
				if(row["UpdateDate"]!=null && row["UpdateDate"].ToString()!="")
				{
					model.UpdateDate=DateTime.Parse(row["UpdateDate"].ToString());
				}
				if(row["LoginIP"]!=null)
				{
					model.LoginIP=row["LoginIP"].ToString();
				}
				if(row["LoginPort"]!=null && row["LoginPort"].ToString()!="")
				{
					model.LoginPort=int.Parse(row["LoginPort"].ToString());
				}
				if(row["Mark"]!=null && row["Mark"].ToString()!="")
				{
					model.Mark=int.Parse(row["Mark"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["CollectorVer"]!=null)
				{
					model.CollectorVer=row["CollectorVer"].ToString();
				}
				if(row["CollectorModel"]!=null)
				{
					model.CollectorModel=row["CollectorModel"].ToString();
				}
				if(row["CollectorAPN"]!=null)
				{
					model.CollectorAPN=row["CollectorAPN"].ToString();
				}
				if(row["IsServerMode"]!=null && row["IsServerMode"].ToString()!="")
				{
					model.IsServerMode=int.Parse(row["IsServerMode"].ToString());
				}
				if(row["WorkTime"]!=null)
				{
					model.WorkTime=row["WorkTime"].ToString();
				}
				if(row["NetWorkTime"]!=null)
				{
					model.NetWorkTime=row["NetWorkTime"].ToString();
				}
				if(row["FactoryCode"]!=null)
				{
					model.FactoryCode=row["FactoryCode"].ToString();
				}
				if(row["FramesType"]!=null && row["FramesType"].ToString()!="")
				{
					model.FramesType=int.Parse(row["FramesType"].ToString());
				}
				if(row["MeterAddrFormat"]!=null && row["MeterAddrFormat"].ToString()!="")
				{
					model.MeterAddrFormat=int.Parse(row["MeterAddrFormat"].ToString());
				}
				if(row["GprsPhone"]!=null)
				{
					model.GprsPhone=row["GprsPhone"].ToString();
				}
				if(row["ExpireTime"]!=null)
				{
					model.ExpireTime=row["ExpireTime"].ToString();
				}
				if(row["WorkMode"]!=null && row["WorkMode"].ToString()!="")
				{
					model.WorkMode=int.Parse(row["WorkMode"].ToString());
				}
				if(row["Lng"]!=null && row["Lng"].ToString()!="")
				{
					model.Lng=decimal.Parse(row["Lng"].ToString());
				}
				if(row["Lat"]!=null && row["Lat"].ToString()!="")
				{
					model.Lat=decimal.Parse(row["Lat"].ToString());
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
			strSql.Append("select CollectorID,CollectorName,CollectorAddr,CollectorType,DeptID,PhoneNumber,CollOverTime,IPNumber,PortNumber,GprsCycle,FreezeDay,FreezeHour,ReadDay,LoginDate,UpdateDate,LoginIP,LoginPort,Mark,Remark,CollectorVer,CollectorModel,CollectorAPN,IsServerMode,WorkTime,NetWorkTime,FactoryCode,FramesType,MeterAddrFormat,GprsPhone,ExpireTime,WorkMode,Lng,Lat ");
			strSql.Append(" FROM Collectors ");
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
			strSql.Append(" CollectorID,CollectorName,CollectorAddr,CollectorType,DeptID,PhoneNumber,CollOverTime,IPNumber,PortNumber,GprsCycle,FreezeDay,FreezeHour,ReadDay,LoginDate,UpdateDate,LoginIP,LoginPort,Mark,Remark,CollectorVer,CollectorModel,CollectorAPN,IsServerMode,WorkTime,NetWorkTime,FactoryCode,FramesType,MeterAddrFormat,GprsPhone,ExpireTime,WorkMode,Lng,Lat ");
			strSql.Append(" FROM Collectors ");
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
			strSql.Append("select count(1) FROM Collectors ");
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
				strSql.Append("order by T.CollectorID desc");
			}
			strSql.Append(")AS Row, T.*  from Collectors T ");
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
			parameters[0].Value = "Collectors";
			parameters[1].Value = "CollectorID";
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

