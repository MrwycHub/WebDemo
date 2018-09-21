using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MetersDev
	/// </summary>
	public partial class MetersDev
	{
		public MetersDev()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeterID", "MetersDev"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeterID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MetersDev");
			strSql.Append(" where MeterID=@MeterID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.MetersDev model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MetersDev(");
			strSql.Append("MeterID,DisenableDate,SiteDir,InsureCode,InsureDate,InsureEndDate,GasDir,InstallPos,InstallWorkerID,InstallDate,FireWorkerID,FireDate,FirstCheckDate,FirstCheckMark,CheckCyc,BoilerFlag,SelfFlag,BookID,InstallID,FirstCheckInfo,FirstCheckWorkerID,CurrValveState)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@DisenableDate,@SiteDir,@InsureCode,@InsureDate,@InsureEndDate,@GasDir,@InstallPos,@InstallWorkerID,@InstallDate,@FireWorkerID,@FireDate,@FirstCheckDate,@FirstCheckMark,@CheckCyc,@BoilerFlag,@SelfFlag,@BookID,@InstallID,@FirstCheckInfo,@FirstCheckWorkerID,@CurrValveState)");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@DisenableDate", SqlDbType.DateTime),
					new SqlParameter("@SiteDir", SqlDbType.Int,4),
					new SqlParameter("@InsureCode", SqlDbType.VarChar,50),
					new SqlParameter("@InsureDate", SqlDbType.DateTime),
					new SqlParameter("@InsureEndDate", SqlDbType.DateTime),
					new SqlParameter("@GasDir", SqlDbType.Int,4),
					new SqlParameter("@InstallPos", SqlDbType.Int,4),
					new SqlParameter("@InstallWorkerID", SqlDbType.Int,4),
					new SqlParameter("@InstallDate", SqlDbType.DateTime),
					new SqlParameter("@FireWorkerID", SqlDbType.Int,4),
					new SqlParameter("@FireDate", SqlDbType.DateTime),
					new SqlParameter("@FirstCheckDate", SqlDbType.DateTime),
					new SqlParameter("@FirstCheckMark", SqlDbType.Int,4),
					new SqlParameter("@CheckCyc", SqlDbType.Int,4),
					new SqlParameter("@BoilerFlag", SqlDbType.Int,4),
					new SqlParameter("@SelfFlag", SqlDbType.Int,4),
					new SqlParameter("@BookID", SqlDbType.Int,4),
					new SqlParameter("@InstallID", SqlDbType.Int,4),
					new SqlParameter("@FirstCheckInfo", SqlDbType.VarChar,50),
					new SqlParameter("@FirstCheckWorkerID", SqlDbType.Int,4),
					new SqlParameter("@CurrValveState", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.DisenableDate;
			parameters[2].Value = model.SiteDir;
			parameters[3].Value = model.InsureCode;
			parameters[4].Value = model.InsureDate;
			parameters[5].Value = model.InsureEndDate;
			parameters[6].Value = model.GasDir;
			parameters[7].Value = model.InstallPos;
			parameters[8].Value = model.InstallWorkerID;
			parameters[9].Value = model.InstallDate;
			parameters[10].Value = model.FireWorkerID;
			parameters[11].Value = model.FireDate;
			parameters[12].Value = model.FirstCheckDate;
			parameters[13].Value = model.FirstCheckMark;
			parameters[14].Value = model.CheckCyc;
			parameters[15].Value = model.BoilerFlag;
			parameters[16].Value = model.SelfFlag;
			parameters[17].Value = model.BookID;
			parameters[18].Value = model.InstallID;
			parameters[19].Value = model.FirstCheckInfo;
			parameters[20].Value = model.FirstCheckWorkerID;
			parameters[21].Value = model.CurrValveState;

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
		public bool Update(WebDemo.Model.WebDemo.MetersDev model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MetersDev set ");
			strSql.Append("DisenableDate=@DisenableDate,");
			strSql.Append("SiteDir=@SiteDir,");
			strSql.Append("InsureCode=@InsureCode,");
			strSql.Append("InsureDate=@InsureDate,");
			strSql.Append("InsureEndDate=@InsureEndDate,");
			strSql.Append("GasDir=@GasDir,");
			strSql.Append("InstallPos=@InstallPos,");
			strSql.Append("InstallWorkerID=@InstallWorkerID,");
			strSql.Append("InstallDate=@InstallDate,");
			strSql.Append("FireWorkerID=@FireWorkerID,");
			strSql.Append("FireDate=@FireDate,");
			strSql.Append("FirstCheckDate=@FirstCheckDate,");
			strSql.Append("FirstCheckMark=@FirstCheckMark,");
			strSql.Append("CheckCyc=@CheckCyc,");
			strSql.Append("BoilerFlag=@BoilerFlag,");
			strSql.Append("SelfFlag=@SelfFlag,");
			strSql.Append("BookID=@BookID,");
			strSql.Append("InstallID=@InstallID,");
			strSql.Append("FirstCheckInfo=@FirstCheckInfo,");
			strSql.Append("FirstCheckWorkerID=@FirstCheckWorkerID,");
			strSql.Append("CurrValveState=@CurrValveState");
			strSql.Append(" where MeterID=@MeterID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DisenableDate", SqlDbType.DateTime),
					new SqlParameter("@SiteDir", SqlDbType.Int,4),
					new SqlParameter("@InsureCode", SqlDbType.VarChar,50),
					new SqlParameter("@InsureDate", SqlDbType.DateTime),
					new SqlParameter("@InsureEndDate", SqlDbType.DateTime),
					new SqlParameter("@GasDir", SqlDbType.Int,4),
					new SqlParameter("@InstallPos", SqlDbType.Int,4),
					new SqlParameter("@InstallWorkerID", SqlDbType.Int,4),
					new SqlParameter("@InstallDate", SqlDbType.DateTime),
					new SqlParameter("@FireWorkerID", SqlDbType.Int,4),
					new SqlParameter("@FireDate", SqlDbType.DateTime),
					new SqlParameter("@FirstCheckDate", SqlDbType.DateTime),
					new SqlParameter("@FirstCheckMark", SqlDbType.Int,4),
					new SqlParameter("@CheckCyc", SqlDbType.Int,4),
					new SqlParameter("@BoilerFlag", SqlDbType.Int,4),
					new SqlParameter("@SelfFlag", SqlDbType.Int,4),
					new SqlParameter("@BookID", SqlDbType.Int,4),
					new SqlParameter("@InstallID", SqlDbType.Int,4),
					new SqlParameter("@FirstCheckInfo", SqlDbType.VarChar,50),
					new SqlParameter("@FirstCheckWorkerID", SqlDbType.Int,4),
					new SqlParameter("@CurrValveState", SqlDbType.Int,4),
					new SqlParameter("@MeterID", SqlDbType.Int,4)};
			parameters[0].Value = model.DisenableDate;
			parameters[1].Value = model.SiteDir;
			parameters[2].Value = model.InsureCode;
			parameters[3].Value = model.InsureDate;
			parameters[4].Value = model.InsureEndDate;
			parameters[5].Value = model.GasDir;
			parameters[6].Value = model.InstallPos;
			parameters[7].Value = model.InstallWorkerID;
			parameters[8].Value = model.InstallDate;
			parameters[9].Value = model.FireWorkerID;
			parameters[10].Value = model.FireDate;
			parameters[11].Value = model.FirstCheckDate;
			parameters[12].Value = model.FirstCheckMark;
			parameters[13].Value = model.CheckCyc;
			parameters[14].Value = model.BoilerFlag;
			parameters[15].Value = model.SelfFlag;
			parameters[16].Value = model.BookID;
			parameters[17].Value = model.InstallID;
			parameters[18].Value = model.FirstCheckInfo;
			parameters[19].Value = model.FirstCheckWorkerID;
			parameters[20].Value = model.CurrValveState;
			parameters[21].Value = model.MeterID;

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
			strSql.Append("delete from MetersDev ");
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
		public bool DeleteList(string MeterIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MetersDev ");
			strSql.Append(" where MeterID in ("+MeterIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.MetersDev GetModel(int MeterID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MeterID,DisenableDate,SiteDir,InsureCode,InsureDate,InsureEndDate,GasDir,InstallPos,InstallWorkerID,InstallDate,FireWorkerID,FireDate,FirstCheckDate,FirstCheckMark,CheckCyc,BoilerFlag,SelfFlag,BookID,InstallID,FirstCheckInfo,FirstCheckWorkerID,CurrValveState from MetersDev ");
			strSql.Append(" where MeterID=@MeterID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4)			};
			parameters[0].Value = MeterID;

			WebDemo.Model.WebDemo.MetersDev model=new WebDemo.Model.WebDemo.MetersDev();
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
		public WebDemo.Model.WebDemo.MetersDev DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MetersDev model=new WebDemo.Model.WebDemo.MetersDev();
			if (row != null)
			{
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
				}
				if(row["DisenableDate"]!=null && row["DisenableDate"].ToString()!="")
				{
					model.DisenableDate=DateTime.Parse(row["DisenableDate"].ToString());
				}
				if(row["SiteDir"]!=null && row["SiteDir"].ToString()!="")
				{
					model.SiteDir=int.Parse(row["SiteDir"].ToString());
				}
				if(row["InsureCode"]!=null)
				{
					model.InsureCode=row["InsureCode"].ToString();
				}
				if(row["InsureDate"]!=null && row["InsureDate"].ToString()!="")
				{
					model.InsureDate=DateTime.Parse(row["InsureDate"].ToString());
				}
				if(row["InsureEndDate"]!=null && row["InsureEndDate"].ToString()!="")
				{
					model.InsureEndDate=DateTime.Parse(row["InsureEndDate"].ToString());
				}
				if(row["GasDir"]!=null && row["GasDir"].ToString()!="")
				{
					model.GasDir=int.Parse(row["GasDir"].ToString());
				}
				if(row["InstallPos"]!=null && row["InstallPos"].ToString()!="")
				{
					model.InstallPos=int.Parse(row["InstallPos"].ToString());
				}
				if(row["InstallWorkerID"]!=null && row["InstallWorkerID"].ToString()!="")
				{
					model.InstallWorkerID=int.Parse(row["InstallWorkerID"].ToString());
				}
				if(row["InstallDate"]!=null && row["InstallDate"].ToString()!="")
				{
					model.InstallDate=DateTime.Parse(row["InstallDate"].ToString());
				}
				if(row["FireWorkerID"]!=null && row["FireWorkerID"].ToString()!="")
				{
					model.FireWorkerID=int.Parse(row["FireWorkerID"].ToString());
				}
				if(row["FireDate"]!=null && row["FireDate"].ToString()!="")
				{
					model.FireDate=DateTime.Parse(row["FireDate"].ToString());
				}
				if(row["FirstCheckDate"]!=null && row["FirstCheckDate"].ToString()!="")
				{
					model.FirstCheckDate=DateTime.Parse(row["FirstCheckDate"].ToString());
				}
				if(row["FirstCheckMark"]!=null && row["FirstCheckMark"].ToString()!="")
				{
					model.FirstCheckMark=int.Parse(row["FirstCheckMark"].ToString());
				}
				if(row["CheckCyc"]!=null && row["CheckCyc"].ToString()!="")
				{
					model.CheckCyc=int.Parse(row["CheckCyc"].ToString());
				}
				if(row["BoilerFlag"]!=null && row["BoilerFlag"].ToString()!="")
				{
					model.BoilerFlag=int.Parse(row["BoilerFlag"].ToString());
				}
				if(row["SelfFlag"]!=null && row["SelfFlag"].ToString()!="")
				{
					model.SelfFlag=int.Parse(row["SelfFlag"].ToString());
				}
				if(row["BookID"]!=null && row["BookID"].ToString()!="")
				{
					model.BookID=int.Parse(row["BookID"].ToString());
				}
				if(row["InstallID"]!=null && row["InstallID"].ToString()!="")
				{
					model.InstallID=int.Parse(row["InstallID"].ToString());
				}
				if(row["FirstCheckInfo"]!=null)
				{
					model.FirstCheckInfo=row["FirstCheckInfo"].ToString();
				}
				if(row["FirstCheckWorkerID"]!=null && row["FirstCheckWorkerID"].ToString()!="")
				{
					model.FirstCheckWorkerID=int.Parse(row["FirstCheckWorkerID"].ToString());
				}
				if(row["CurrValveState"]!=null && row["CurrValveState"].ToString()!="")
				{
					model.CurrValveState=int.Parse(row["CurrValveState"].ToString());
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
			strSql.Append("select MeterID,DisenableDate,SiteDir,InsureCode,InsureDate,InsureEndDate,GasDir,InstallPos,InstallWorkerID,InstallDate,FireWorkerID,FireDate,FirstCheckDate,FirstCheckMark,CheckCyc,BoilerFlag,SelfFlag,BookID,InstallID,FirstCheckInfo,FirstCheckWorkerID,CurrValveState ");
			strSql.Append(" FROM MetersDev ");
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
			strSql.Append(" MeterID,DisenableDate,SiteDir,InsureCode,InsureDate,InsureEndDate,GasDir,InstallPos,InstallWorkerID,InstallDate,FireWorkerID,FireDate,FirstCheckDate,FirstCheckMark,CheckCyc,BoilerFlag,SelfFlag,BookID,InstallID,FirstCheckInfo,FirstCheckWorkerID,CurrValveState ");
			strSql.Append(" FROM MetersDev ");
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
			strSql.Append("select count(1) FROM MetersDev ");
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
				strSql.Append("order by T.MeterID desc");
			}
			strSql.Append(")AS Row, T.*  from MetersDev T ");
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
			parameters[0].Value = "MetersDev";
			parameters[1].Value = "MeterID";
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

