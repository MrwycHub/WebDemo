using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:CompanyInfo
	/// </summary>
	public partial class CompanyInfo
	{
		public CompanyInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "CompanyInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CompanyInfo");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.CompanyInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CompanyInfo(");
			strSql.Append("CompanyName,CompanyNo,Pwd,AuthorizationCode,IDCode,EFileCode,TaxAgencyCode,AgentMark,ProjectName,ProjectCode,AccountBank,AccountNumber,CompanyAddress,CompanyPhone,SleepTime,UpdateTime)");
			strSql.Append(" values (");
			strSql.Append("@CompanyName,@CompanyNo,@Pwd,@AuthorizationCode,@IDCode,@EFileCode,@TaxAgencyCode,@AgentMark,@ProjectName,@ProjectCode,@AccountBank,@AccountNumber,@CompanyAddress,@CompanyPhone,@SleepTime,@UpdateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,200),
					new SqlParameter("@CompanyNo", SqlDbType.NVarChar,8),
					new SqlParameter("@Pwd", SqlDbType.NVarChar,100),
					new SqlParameter("@AuthorizationCode", SqlDbType.NVarChar,100),
					new SqlParameter("@IDCode", SqlDbType.NVarChar,20),
					new SqlParameter("@EFileCode", SqlDbType.NVarChar,20),
					new SqlParameter("@TaxAgencyCode", SqlDbType.NVarChar,11),
					new SqlParameter("@AgentMark", SqlDbType.Char,1),
					new SqlParameter("@ProjectName", SqlDbType.NVarChar,200),
					new SqlParameter("@ProjectCode", SqlDbType.NVarChar,20),
					new SqlParameter("@AccountBank", SqlDbType.NVarChar,100),
					new SqlParameter("@AccountNumber", SqlDbType.NVarChar,100),
					new SqlParameter("@CompanyAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@CompanyPhone", SqlDbType.NVarChar,20),
					new SqlParameter("@SleepTime", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.CompanyName;
			parameters[1].Value = model.CompanyNo;
			parameters[2].Value = model.Pwd;
			parameters[3].Value = model.AuthorizationCode;
			parameters[4].Value = model.IDCode;
			parameters[5].Value = model.EFileCode;
			parameters[6].Value = model.TaxAgencyCode;
			parameters[7].Value = model.AgentMark;
			parameters[8].Value = model.ProjectName;
			parameters[9].Value = model.ProjectCode;
			parameters[10].Value = model.AccountBank;
			parameters[11].Value = model.AccountNumber;
			parameters[12].Value = model.CompanyAddress;
			parameters[13].Value = model.CompanyPhone;
			parameters[14].Value = model.SleepTime;
			parameters[15].Value = model.UpdateTime;

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
		public bool Update(WebDemo.Model.WebDemo.CompanyInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CompanyInfo set ");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("CompanyNo=@CompanyNo,");
			strSql.Append("Pwd=@Pwd,");
			strSql.Append("AuthorizationCode=@AuthorizationCode,");
			strSql.Append("IDCode=@IDCode,");
			strSql.Append("EFileCode=@EFileCode,");
			strSql.Append("TaxAgencyCode=@TaxAgencyCode,");
			strSql.Append("AgentMark=@AgentMark,");
			strSql.Append("ProjectName=@ProjectName,");
			strSql.Append("ProjectCode=@ProjectCode,");
			strSql.Append("AccountBank=@AccountBank,");
			strSql.Append("AccountNumber=@AccountNumber,");
			strSql.Append("CompanyAddress=@CompanyAddress,");
			strSql.Append("CompanyPhone=@CompanyPhone,");
			strSql.Append("SleepTime=@SleepTime,");
			strSql.Append("UpdateTime=@UpdateTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,200),
					new SqlParameter("@CompanyNo", SqlDbType.NVarChar,8),
					new SqlParameter("@Pwd", SqlDbType.NVarChar,100),
					new SqlParameter("@AuthorizationCode", SqlDbType.NVarChar,100),
					new SqlParameter("@IDCode", SqlDbType.NVarChar,20),
					new SqlParameter("@EFileCode", SqlDbType.NVarChar,20),
					new SqlParameter("@TaxAgencyCode", SqlDbType.NVarChar,11),
					new SqlParameter("@AgentMark", SqlDbType.Char,1),
					new SqlParameter("@ProjectName", SqlDbType.NVarChar,200),
					new SqlParameter("@ProjectCode", SqlDbType.NVarChar,20),
					new SqlParameter("@AccountBank", SqlDbType.NVarChar,100),
					new SqlParameter("@AccountNumber", SqlDbType.NVarChar,100),
					new SqlParameter("@CompanyAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@CompanyPhone", SqlDbType.NVarChar,20),
					new SqlParameter("@SleepTime", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.CompanyName;
			parameters[1].Value = model.CompanyNo;
			parameters[2].Value = model.Pwd;
			parameters[3].Value = model.AuthorizationCode;
			parameters[4].Value = model.IDCode;
			parameters[5].Value = model.EFileCode;
			parameters[6].Value = model.TaxAgencyCode;
			parameters[7].Value = model.AgentMark;
			parameters[8].Value = model.ProjectName;
			parameters[9].Value = model.ProjectCode;
			parameters[10].Value = model.AccountBank;
			parameters[11].Value = model.AccountNumber;
			parameters[12].Value = model.CompanyAddress;
			parameters[13].Value = model.CompanyPhone;
			parameters[14].Value = model.SleepTime;
			parameters[15].Value = model.UpdateTime;
			parameters[16].Value = model.ID;

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
			strSql.Append("delete from CompanyInfo ");
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
			strSql.Append("delete from CompanyInfo ");
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
		public WebDemo.Model.WebDemo.CompanyInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,CompanyName,CompanyNo,Pwd,AuthorizationCode,IDCode,EFileCode,TaxAgencyCode,AgentMark,ProjectName,ProjectCode,AccountBank,AccountNumber,CompanyAddress,CompanyPhone,SleepTime,UpdateTime from CompanyInfo ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.CompanyInfo model=new WebDemo.Model.WebDemo.CompanyInfo();
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
		public WebDemo.Model.WebDemo.CompanyInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.CompanyInfo model=new WebDemo.Model.WebDemo.CompanyInfo();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["CompanyName"]!=null)
				{
					model.CompanyName=row["CompanyName"].ToString();
				}
				if(row["CompanyNo"]!=null)
				{
					model.CompanyNo=row["CompanyNo"].ToString();
				}
				if(row["Pwd"]!=null)
				{
					model.Pwd=row["Pwd"].ToString();
				}
				if(row["AuthorizationCode"]!=null)
				{
					model.AuthorizationCode=row["AuthorizationCode"].ToString();
				}
				if(row["IDCode"]!=null)
				{
					model.IDCode=row["IDCode"].ToString();
				}
				if(row["EFileCode"]!=null)
				{
					model.EFileCode=row["EFileCode"].ToString();
				}
				if(row["TaxAgencyCode"]!=null)
				{
					model.TaxAgencyCode=row["TaxAgencyCode"].ToString();
				}
				if(row["AgentMark"]!=null)
				{
					model.AgentMark=row["AgentMark"].ToString();
				}
				if(row["ProjectName"]!=null)
				{
					model.ProjectName=row["ProjectName"].ToString();
				}
				if(row["ProjectCode"]!=null)
				{
					model.ProjectCode=row["ProjectCode"].ToString();
				}
				if(row["AccountBank"]!=null)
				{
					model.AccountBank=row["AccountBank"].ToString();
				}
				if(row["AccountNumber"]!=null)
				{
					model.AccountNumber=row["AccountNumber"].ToString();
				}
				if(row["CompanyAddress"]!=null)
				{
					model.CompanyAddress=row["CompanyAddress"].ToString();
				}
				if(row["CompanyPhone"]!=null)
				{
					model.CompanyPhone=row["CompanyPhone"].ToString();
				}
				if(row["SleepTime"]!=null && row["SleepTime"].ToString()!="")
				{
					model.SleepTime=int.Parse(row["SleepTime"].ToString());
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
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
			strSql.Append("select ID,CompanyName,CompanyNo,Pwd,AuthorizationCode,IDCode,EFileCode,TaxAgencyCode,AgentMark,ProjectName,ProjectCode,AccountBank,AccountNumber,CompanyAddress,CompanyPhone,SleepTime,UpdateTime ");
			strSql.Append(" FROM CompanyInfo ");
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
			strSql.Append(" ID,CompanyName,CompanyNo,Pwd,AuthorizationCode,IDCode,EFileCode,TaxAgencyCode,AgentMark,ProjectName,ProjectCode,AccountBank,AccountNumber,CompanyAddress,CompanyPhone,SleepTime,UpdateTime ");
			strSql.Append(" FROM CompanyInfo ");
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
			strSql.Append("select count(1) FROM CompanyInfo ");
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
			strSql.Append(")AS Row, T.*  from CompanyInfo T ");
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
			parameters[0].Value = "CompanyInfo";
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

