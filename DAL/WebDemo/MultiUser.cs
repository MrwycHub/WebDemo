using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MultiUser
	/// </summary>
	public partial class MultiUser
	{
		public MultiUser()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MultiUserID", "MultiUser"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MultiUserID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MultiUser");
			strSql.Append(" where MultiUserID=@MultiUserID");
			SqlParameter[] parameters = {
					new SqlParameter("@MultiUserID", SqlDbType.Int,4)
			};
			parameters[0].Value = MultiUserID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.MultiUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MultiUser(");
			strSql.Append("UserCode,UserName,DeptID,CardId,CardSector,CardSn,Mark,Sex,Phone,PaperType,PaperNo,uAccount,OpenTime,ValidDate,LastMoney,TotalMoney,ReMark)");
			strSql.Append(" values (");
			strSql.Append("@UserCode,@UserName,@DeptID,@CardId,@CardSector,@CardSn,@Mark,@Sex,@Phone,@PaperType,@PaperNo,@uAccount,@OpenTime,@ValidDate,@LastMoney,@TotalMoney,@ReMark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@DeptID", SqlDbType.VarChar,50),
					new SqlParameter("@CardId", SqlDbType.Int,4),
					new SqlParameter("@CardSector", SqlDbType.Int,4),
					new SqlParameter("@CardSn", SqlDbType.VarChar,8),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@Sex", SqlDbType.VarChar,20),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@PaperType", SqlDbType.Int,4),
					new SqlParameter("@PaperNo", SqlDbType.VarChar,50),
					new SqlParameter("@uAccount", SqlDbType.VarChar,50),
					new SqlParameter("@OpenTime", SqlDbType.DateTime),
					new SqlParameter("@ValidDate", SqlDbType.DateTime),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TotalMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ReMark", SqlDbType.VarChar,50)};
			parameters[0].Value = model.UserCode;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.DeptID;
			parameters[3].Value = model.CardId;
			parameters[4].Value = model.CardSector;
			parameters[5].Value = model.CardSn;
			parameters[6].Value = model.Mark;
			parameters[7].Value = model.Sex;
			parameters[8].Value = model.Phone;
			parameters[9].Value = model.PaperType;
			parameters[10].Value = model.PaperNo;
			parameters[11].Value = model.uAccount;
			parameters[12].Value = model.OpenTime;
			parameters[13].Value = model.ValidDate;
			parameters[14].Value = model.LastMoney;
			parameters[15].Value = model.TotalMoney;
			parameters[16].Value = model.ReMark;

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
		public bool Update(WebDemo.Model.WebDemo.MultiUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MultiUser set ");
			strSql.Append("UserCode=@UserCode,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("DeptID=@DeptID,");
			strSql.Append("CardId=@CardId,");
			strSql.Append("CardSector=@CardSector,");
			strSql.Append("CardSn=@CardSn,");
			strSql.Append("Mark=@Mark,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("PaperType=@PaperType,");
			strSql.Append("PaperNo=@PaperNo,");
			strSql.Append("uAccount=@uAccount,");
			strSql.Append("OpenTime=@OpenTime,");
			strSql.Append("ValidDate=@ValidDate,");
			strSql.Append("LastMoney=@LastMoney,");
			strSql.Append("TotalMoney=@TotalMoney,");
			strSql.Append("ReMark=@ReMark");
			strSql.Append(" where MultiUserID=@MultiUserID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@DeptID", SqlDbType.VarChar,50),
					new SqlParameter("@CardId", SqlDbType.Int,4),
					new SqlParameter("@CardSector", SqlDbType.Int,4),
					new SqlParameter("@CardSn", SqlDbType.VarChar,8),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@Sex", SqlDbType.VarChar,20),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@PaperType", SqlDbType.Int,4),
					new SqlParameter("@PaperNo", SqlDbType.VarChar,50),
					new SqlParameter("@uAccount", SqlDbType.VarChar,50),
					new SqlParameter("@OpenTime", SqlDbType.DateTime),
					new SqlParameter("@ValidDate", SqlDbType.DateTime),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@TotalMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ReMark", SqlDbType.VarChar,50),
					new SqlParameter("@MultiUserID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserCode;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.DeptID;
			parameters[3].Value = model.CardId;
			parameters[4].Value = model.CardSector;
			parameters[5].Value = model.CardSn;
			parameters[6].Value = model.Mark;
			parameters[7].Value = model.Sex;
			parameters[8].Value = model.Phone;
			parameters[9].Value = model.PaperType;
			parameters[10].Value = model.PaperNo;
			parameters[11].Value = model.uAccount;
			parameters[12].Value = model.OpenTime;
			parameters[13].Value = model.ValidDate;
			parameters[14].Value = model.LastMoney;
			parameters[15].Value = model.TotalMoney;
			parameters[16].Value = model.ReMark;
			parameters[17].Value = model.MultiUserID;

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
		public bool Delete(int MultiUserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MultiUser ");
			strSql.Append(" where MultiUserID=@MultiUserID");
			SqlParameter[] parameters = {
					new SqlParameter("@MultiUserID", SqlDbType.Int,4)
			};
			parameters[0].Value = MultiUserID;

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
		public bool DeleteList(string MultiUserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MultiUser ");
			strSql.Append(" where MultiUserID in ("+MultiUserIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.MultiUser GetModel(int MultiUserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MultiUserID,UserCode,UserName,DeptID,CardId,CardSector,CardSn,Mark,Sex,Phone,PaperType,PaperNo,uAccount,OpenTime,ValidDate,LastMoney,TotalMoney,ReMark from MultiUser ");
			strSql.Append(" where MultiUserID=@MultiUserID");
			SqlParameter[] parameters = {
					new SqlParameter("@MultiUserID", SqlDbType.Int,4)
			};
			parameters[0].Value = MultiUserID;

			WebDemo.Model.WebDemo.MultiUser model=new WebDemo.Model.WebDemo.MultiUser();
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
		public WebDemo.Model.WebDemo.MultiUser DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MultiUser model=new WebDemo.Model.WebDemo.MultiUser();
			if (row != null)
			{
				if(row["MultiUserID"]!=null && row["MultiUserID"].ToString()!="")
				{
					model.MultiUserID=int.Parse(row["MultiUserID"].ToString());
				}
				if(row["UserCode"]!=null)
				{
					model.UserCode=row["UserCode"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["DeptID"]!=null)
				{
					model.DeptID=row["DeptID"].ToString();
				}
				if(row["CardId"]!=null && row["CardId"].ToString()!="")
				{
					model.CardId=int.Parse(row["CardId"].ToString());
				}
				if(row["CardSector"]!=null && row["CardSector"].ToString()!="")
				{
					model.CardSector=int.Parse(row["CardSector"].ToString());
				}
				if(row["CardSn"]!=null)
				{
					model.CardSn=row["CardSn"].ToString();
				}
				if(row["Mark"]!=null && row["Mark"].ToString()!="")
				{
					model.Mark=int.Parse(row["Mark"].ToString());
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["PaperType"]!=null && row["PaperType"].ToString()!="")
				{
					model.PaperType=int.Parse(row["PaperType"].ToString());
				}
				if(row["PaperNo"]!=null)
				{
					model.PaperNo=row["PaperNo"].ToString();
				}
				if(row["uAccount"]!=null)
				{
					model.uAccount=row["uAccount"].ToString();
				}
				if(row["OpenTime"]!=null && row["OpenTime"].ToString()!="")
				{
					model.OpenTime=DateTime.Parse(row["OpenTime"].ToString());
				}
				if(row["ValidDate"]!=null && row["ValidDate"].ToString()!="")
				{
					model.ValidDate=DateTime.Parse(row["ValidDate"].ToString());
				}
				if(row["LastMoney"]!=null && row["LastMoney"].ToString()!="")
				{
					model.LastMoney=decimal.Parse(row["LastMoney"].ToString());
				}
				if(row["TotalMoney"]!=null && row["TotalMoney"].ToString()!="")
				{
					model.TotalMoney=decimal.Parse(row["TotalMoney"].ToString());
				}
				if(row["ReMark"]!=null)
				{
					model.ReMark=row["ReMark"].ToString();
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
			strSql.Append("select MultiUserID,UserCode,UserName,DeptID,CardId,CardSector,CardSn,Mark,Sex,Phone,PaperType,PaperNo,uAccount,OpenTime,ValidDate,LastMoney,TotalMoney,ReMark ");
			strSql.Append(" FROM MultiUser ");
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
			strSql.Append(" MultiUserID,UserCode,UserName,DeptID,CardId,CardSector,CardSn,Mark,Sex,Phone,PaperType,PaperNo,uAccount,OpenTime,ValidDate,LastMoney,TotalMoney,ReMark ");
			strSql.Append(" FROM MultiUser ");
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
			strSql.Append("select count(1) FROM MultiUser ");
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
				strSql.Append("order by T.MultiUserID desc");
			}
			strSql.Append(")AS Row, T.*  from MultiUser T ");
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
			parameters[0].Value = "MultiUser";
			parameters[1].Value = "MultiUserID";
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

