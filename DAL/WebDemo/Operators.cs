using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Operators
	/// </summary>
	public partial class Operators
	{
		public Operators()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("OperatorID", "Operators"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OperatorID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Operators");
			strSql.Append(" where OperatorID=@OperatorID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorID", SqlDbType.Int,4)			};
			parameters[0].Value = OperatorID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.Operators model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Operators(");
			strSql.Append("OperatorID,OperatorCode,OperatorName,RoleID,OperPassword,SiteID,Flag,CreateDate,LastLoginDate,PageRowCounts,OperLevel,TemplateID,PaymentTemplateID,ICTemplateID,Phone,SelfSetting,AutoRead,PhoneSerialNumber,IsBinding,RoleLevel,ExpiryDate,Skin)");
			strSql.Append(" values (");
			strSql.Append("@OperatorID,@OperatorCode,@OperatorName,@RoleID,@OperPassword,@SiteID,@Flag,@CreateDate,@LastLoginDate,@PageRowCounts,@OperLevel,@TemplateID,@PaymentTemplateID,@ICTemplateID,@Phone,@SelfSetting,@AutoRead,@PhoneSerialNumber,@IsBinding,@RoleLevel,@ExpiryDate,@Skin)");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@OperatorCode", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@RoleID", SqlDbType.Int,4),
					new SqlParameter("@OperPassword", SqlDbType.VarChar,50),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@LastLoginDate", SqlDbType.DateTime),
					new SqlParameter("@PageRowCounts", SqlDbType.Int,4),
					new SqlParameter("@OperLevel", SqlDbType.VarChar,50),
					new SqlParameter("@TemplateID", SqlDbType.Int,4),
					new SqlParameter("@PaymentTemplateID", SqlDbType.Int,4),
					new SqlParameter("@ICTemplateID", SqlDbType.Int,4),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@SelfSetting", SqlDbType.VarChar,500),
					new SqlParameter("@AutoRead", SqlDbType.Int,4),
					new SqlParameter("@PhoneSerialNumber", SqlDbType.VarChar,50),
					new SqlParameter("@IsBinding", SqlDbType.Int,4),
					new SqlParameter("@RoleLevel", SqlDbType.Int,4),
					new SqlParameter("@ExpiryDate", SqlDbType.DateTime),
					new SqlParameter("@Skin", SqlDbType.VarChar,50)};
			parameters[0].Value = model.OperatorID;
			parameters[1].Value = model.OperatorCode;
			parameters[2].Value = model.OperatorName;
			parameters[3].Value = model.RoleID;
			parameters[4].Value = model.OperPassword;
			parameters[5].Value = model.SiteID;
			parameters[6].Value = model.Flag;
			parameters[7].Value = model.CreateDate;
			parameters[8].Value = model.LastLoginDate;
			parameters[9].Value = model.PageRowCounts;
			parameters[10].Value = model.OperLevel;
			parameters[11].Value = model.TemplateID;
			parameters[12].Value = model.PaymentTemplateID;
			parameters[13].Value = model.ICTemplateID;
			parameters[14].Value = model.Phone;
			parameters[15].Value = model.SelfSetting;
			parameters[16].Value = model.AutoRead;
			parameters[17].Value = model.PhoneSerialNumber;
			parameters[18].Value = model.IsBinding;
			parameters[19].Value = model.RoleLevel;
			parameters[20].Value = model.ExpiryDate;
			parameters[21].Value = model.Skin;

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
		public bool Update(WebDemo.Model.WebDemo.Operators model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Operators set ");
			strSql.Append("OperatorCode=@OperatorCode,");
			strSql.Append("OperatorName=@OperatorName,");
			strSql.Append("RoleID=@RoleID,");
			strSql.Append("OperPassword=@OperPassword,");
			strSql.Append("SiteID=@SiteID,");
			strSql.Append("Flag=@Flag,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("LastLoginDate=@LastLoginDate,");
			strSql.Append("PageRowCounts=@PageRowCounts,");
			strSql.Append("OperLevel=@OperLevel,");
			strSql.Append("TemplateID=@TemplateID,");
			strSql.Append("PaymentTemplateID=@PaymentTemplateID,");
			strSql.Append("ICTemplateID=@ICTemplateID,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("SelfSetting=@SelfSetting,");
			strSql.Append("AutoRead=@AutoRead,");
			strSql.Append("PhoneSerialNumber=@PhoneSerialNumber,");
			strSql.Append("IsBinding=@IsBinding,");
			strSql.Append("RoleLevel=@RoleLevel,");
			strSql.Append("ExpiryDate=@ExpiryDate,");
			strSql.Append("Skin=@Skin");
			strSql.Append(" where OperatorID=@OperatorID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorCode", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorName", SqlDbType.VarChar,50),
					new SqlParameter("@RoleID", SqlDbType.Int,4),
					new SqlParameter("@OperPassword", SqlDbType.VarChar,50),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@LastLoginDate", SqlDbType.DateTime),
					new SqlParameter("@PageRowCounts", SqlDbType.Int,4),
					new SqlParameter("@OperLevel", SqlDbType.VarChar,50),
					new SqlParameter("@TemplateID", SqlDbType.Int,4),
					new SqlParameter("@PaymentTemplateID", SqlDbType.Int,4),
					new SqlParameter("@ICTemplateID", SqlDbType.Int,4),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@SelfSetting", SqlDbType.VarChar,500),
					new SqlParameter("@AutoRead", SqlDbType.Int,4),
					new SqlParameter("@PhoneSerialNumber", SqlDbType.VarChar,50),
					new SqlParameter("@IsBinding", SqlDbType.Int,4),
					new SqlParameter("@RoleLevel", SqlDbType.Int,4),
					new SqlParameter("@ExpiryDate", SqlDbType.DateTime),
					new SqlParameter("@Skin", SqlDbType.VarChar,50),
					new SqlParameter("@OperatorID", SqlDbType.Int,4)};
			parameters[0].Value = model.OperatorCode;
			parameters[1].Value = model.OperatorName;
			parameters[2].Value = model.RoleID;
			parameters[3].Value = model.OperPassword;
			parameters[4].Value = model.SiteID;
			parameters[5].Value = model.Flag;
			parameters[6].Value = model.CreateDate;
			parameters[7].Value = model.LastLoginDate;
			parameters[8].Value = model.PageRowCounts;
			parameters[9].Value = model.OperLevel;
			parameters[10].Value = model.TemplateID;
			parameters[11].Value = model.PaymentTemplateID;
			parameters[12].Value = model.ICTemplateID;
			parameters[13].Value = model.Phone;
			parameters[14].Value = model.SelfSetting;
			parameters[15].Value = model.AutoRead;
			parameters[16].Value = model.PhoneSerialNumber;
			parameters[17].Value = model.IsBinding;
			parameters[18].Value = model.RoleLevel;
			parameters[19].Value = model.ExpiryDate;
			parameters[20].Value = model.Skin;
			parameters[21].Value = model.OperatorID;

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
		public bool Delete(int OperatorID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Operators ");
			strSql.Append(" where OperatorID=@OperatorID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorID", SqlDbType.Int,4)			};
			parameters[0].Value = OperatorID;

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
		public bool DeleteList(string OperatorIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Operators ");
			strSql.Append(" where OperatorID in ("+OperatorIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.Operators GetModel(int OperatorID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 OperatorID,OperatorCode,OperatorName,RoleID,OperPassword,SiteID,Flag,CreateDate,LastLoginDate,PageRowCounts,OperLevel,TemplateID,PaymentTemplateID,ICTemplateID,Phone,SelfSetting,AutoRead,PhoneSerialNumber,IsBinding,RoleLevel,ExpiryDate,Skin from Operators ");
			strSql.Append(" where OperatorID=@OperatorID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OperatorID", SqlDbType.Int,4)			};
			parameters[0].Value = OperatorID;

			WebDemo.Model.WebDemo.Operators model=new WebDemo.Model.WebDemo.Operators();
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
		public WebDemo.Model.WebDemo.Operators DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Operators model=new WebDemo.Model.WebDemo.Operators();
			if (row != null)
			{
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["OperatorCode"]!=null)
				{
					model.OperatorCode=row["OperatorCode"].ToString();
				}
				if(row["OperatorName"]!=null)
				{
					model.OperatorName=row["OperatorName"].ToString();
				}
				if(row["RoleID"]!=null && row["RoleID"].ToString()!="")
				{
					model.RoleID=int.Parse(row["RoleID"].ToString());
				}
				if(row["OperPassword"]!=null)
				{
					model.OperPassword=row["OperPassword"].ToString();
				}
				if(row["SiteID"]!=null && row["SiteID"].ToString()!="")
				{
					model.SiteID=int.Parse(row["SiteID"].ToString());
				}
				if(row["Flag"]!=null && row["Flag"].ToString()!="")
				{
					model.Flag=int.Parse(row["Flag"].ToString());
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
				if(row["LastLoginDate"]!=null && row["LastLoginDate"].ToString()!="")
				{
					model.LastLoginDate=DateTime.Parse(row["LastLoginDate"].ToString());
				}
				if(row["PageRowCounts"]!=null && row["PageRowCounts"].ToString()!="")
				{
					model.PageRowCounts=int.Parse(row["PageRowCounts"].ToString());
				}
				if(row["OperLevel"]!=null)
				{
					model.OperLevel=row["OperLevel"].ToString();
				}
				if(row["TemplateID"]!=null && row["TemplateID"].ToString()!="")
				{
					model.TemplateID=int.Parse(row["TemplateID"].ToString());
				}
				if(row["PaymentTemplateID"]!=null && row["PaymentTemplateID"].ToString()!="")
				{
					model.PaymentTemplateID=int.Parse(row["PaymentTemplateID"].ToString());
				}
				if(row["ICTemplateID"]!=null && row["ICTemplateID"].ToString()!="")
				{
					model.ICTemplateID=int.Parse(row["ICTemplateID"].ToString());
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["SelfSetting"]!=null)
				{
					model.SelfSetting=row["SelfSetting"].ToString();
				}
				if(row["AutoRead"]!=null && row["AutoRead"].ToString()!="")
				{
					model.AutoRead=int.Parse(row["AutoRead"].ToString());
				}
				if(row["PhoneSerialNumber"]!=null)
				{
					model.PhoneSerialNumber=row["PhoneSerialNumber"].ToString();
				}
				if(row["IsBinding"]!=null && row["IsBinding"].ToString()!="")
				{
					model.IsBinding=int.Parse(row["IsBinding"].ToString());
				}
				if(row["RoleLevel"]!=null && row["RoleLevel"].ToString()!="")
				{
					model.RoleLevel=int.Parse(row["RoleLevel"].ToString());
				}
				if(row["ExpiryDate"]!=null && row["ExpiryDate"].ToString()!="")
				{
					model.ExpiryDate=DateTime.Parse(row["ExpiryDate"].ToString());
				}
				if(row["Skin"]!=null)
				{
					model.Skin=row["Skin"].ToString();
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
			strSql.Append("select OperatorID,OperatorCode,OperatorName,RoleID,OperPassword,SiteID,Flag,CreateDate,LastLoginDate,PageRowCounts,OperLevel,TemplateID,PaymentTemplateID,ICTemplateID,Phone,SelfSetting,AutoRead,PhoneSerialNumber,IsBinding,RoleLevel,ExpiryDate,Skin ");
			strSql.Append(" FROM Operators ");
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
			strSql.Append(" OperatorID,OperatorCode,OperatorName,RoleID,OperPassword,SiteID,Flag,CreateDate,LastLoginDate,PageRowCounts,OperLevel,TemplateID,PaymentTemplateID,ICTemplateID,Phone,SelfSetting,AutoRead,PhoneSerialNumber,IsBinding,RoleLevel,ExpiryDate,Skin ");
			strSql.Append(" FROM Operators ");
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
			strSql.Append("select count(1) FROM Operators ");
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
				strSql.Append("order by T.OperatorID desc");
			}
			strSql.Append(")AS Row, T.*  from Operators T ");
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
			parameters[0].Value = "Operators";
			parameters[1].Value = "OperatorID";
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

