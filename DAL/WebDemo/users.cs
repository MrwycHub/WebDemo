using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:users
	/// </summary>
	public partial class users
	{
		public users()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UsersID", "users"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UsersID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from users");
			strSql.Append(" where UsersID=@UsersID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4)			};
			parameters[0].Value = UsersID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into users(");
			strSql.Append("UsersID,UserCode,UserName,Doorplate,PaperType,PaperNo,Address,Phone,Tel,Acreage,ChargeAcreage,Reserve,Sex,Populace,Remark,Mark,DeptID,UserFloor,HouseDir,UserType,ClientId,Remnant,Remnant2,Remnant3,UpdateTime,RegistPhone,EInvoiceType)");
			strSql.Append(" values (");
			strSql.Append("@UsersID,@UserCode,@UserName,@Doorplate,@PaperType,@PaperNo,@Address,@Phone,@Tel,@Acreage,@ChargeAcreage,@Reserve,@Sex,@Populace,@Remark,@Mark,@DeptID,@UserFloor,@HouseDir,@UserType,@ClientId,@Remnant,@Remnant2,@Remnant3,@UpdateTime,@RegistPhone,@EInvoiceType)");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@UserCode", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,100),
					new SqlParameter("@Doorplate", SqlDbType.VarChar,50),
					new SqlParameter("@PaperType", SqlDbType.VarChar,50),
					new SqlParameter("@PaperNo", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Acreage", SqlDbType.Decimal,9),
					new SqlParameter("@ChargeAcreage", SqlDbType.Decimal,9),
					new SqlParameter("@Reserve", SqlDbType.Decimal,9),
					new SqlParameter("@Sex", SqlDbType.VarChar,20),
					new SqlParameter("@Populace", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@DeptID", SqlDbType.VarChar,60),
					new SqlParameter("@UserFloor", SqlDbType.VarChar,50),
					new SqlParameter("@HouseDir", SqlDbType.VarChar,50),
					new SqlParameter("@UserType", SqlDbType.VarChar,5),
					new SqlParameter("@ClientId", SqlDbType.VarChar,50),
					new SqlParameter("@Remnant", SqlDbType.Decimal,9),
					new SqlParameter("@Remnant2", SqlDbType.Decimal,9),
					new SqlParameter("@Remnant3", SqlDbType.Decimal,9),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@RegistPhone", SqlDbType.VarChar,50),
					new SqlParameter("@EInvoiceType", SqlDbType.Int,4)};
			parameters[0].Value = model.UsersID;
			parameters[1].Value = model.UserCode;
			parameters[2].Value = model.UserName;
			parameters[3].Value = model.Doorplate;
			parameters[4].Value = model.PaperType;
			parameters[5].Value = model.PaperNo;
			parameters[6].Value = model.Address;
			parameters[7].Value = model.Phone;
			parameters[8].Value = model.Tel;
			parameters[9].Value = model.Acreage;
			parameters[10].Value = model.ChargeAcreage;
			parameters[11].Value = model.Reserve;
			parameters[12].Value = model.Sex;
			parameters[13].Value = model.Populace;
			parameters[14].Value = model.Remark;
			parameters[15].Value = model.Mark;
			parameters[16].Value = model.DeptID;
			parameters[17].Value = model.UserFloor;
			parameters[18].Value = model.HouseDir;
			parameters[19].Value = model.UserType;
			parameters[20].Value = model.ClientId;
			parameters[21].Value = model.Remnant;
			parameters[22].Value = model.Remnant2;
			parameters[23].Value = model.Remnant3;
			parameters[24].Value = model.UpdateTime;
			parameters[25].Value = model.RegistPhone;
			parameters[26].Value = model.EInvoiceType;

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
		public bool Update(WebDemo.Model.WebDemo.users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update users set ");
			strSql.Append("UserCode=@UserCode,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Doorplate=@Doorplate,");
			strSql.Append("PaperType=@PaperType,");
			strSql.Append("PaperNo=@PaperNo,");
			strSql.Append("Address=@Address,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Acreage=@Acreage,");
			strSql.Append("ChargeAcreage=@ChargeAcreage,");
			strSql.Append("Reserve=@Reserve,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Populace=@Populace,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Mark=@Mark,");
			strSql.Append("DeptID=@DeptID,");
			strSql.Append("UserFloor=@UserFloor,");
			strSql.Append("HouseDir=@HouseDir,");
			strSql.Append("UserType=@UserType,");
			strSql.Append("ClientId=@ClientId,");
			strSql.Append("Remnant=@Remnant,");
			strSql.Append("Remnant2=@Remnant2,");
			strSql.Append("Remnant3=@Remnant3,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("RegistPhone=@RegistPhone,");
			strSql.Append("EInvoiceType=@EInvoiceType");
			strSql.Append(" where UsersID=@UsersID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,100),
					new SqlParameter("@Doorplate", SqlDbType.VarChar,50),
					new SqlParameter("@PaperType", SqlDbType.VarChar,50),
					new SqlParameter("@PaperNo", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Acreage", SqlDbType.Decimal,9),
					new SqlParameter("@ChargeAcreage", SqlDbType.Decimal,9),
					new SqlParameter("@Reserve", SqlDbType.Decimal,9),
					new SqlParameter("@Sex", SqlDbType.VarChar,20),
					new SqlParameter("@Populace", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@DeptID", SqlDbType.VarChar,60),
					new SqlParameter("@UserFloor", SqlDbType.VarChar,50),
					new SqlParameter("@HouseDir", SqlDbType.VarChar,50),
					new SqlParameter("@UserType", SqlDbType.VarChar,5),
					new SqlParameter("@ClientId", SqlDbType.VarChar,50),
					new SqlParameter("@Remnant", SqlDbType.Decimal,9),
					new SqlParameter("@Remnant2", SqlDbType.Decimal,9),
					new SqlParameter("@Remnant3", SqlDbType.Decimal,9),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@RegistPhone", SqlDbType.VarChar,50),
					new SqlParameter("@EInvoiceType", SqlDbType.Int,4),
					new SqlParameter("@UsersID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserCode;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.Doorplate;
			parameters[3].Value = model.PaperType;
			parameters[4].Value = model.PaperNo;
			parameters[5].Value = model.Address;
			parameters[6].Value = model.Phone;
			parameters[7].Value = model.Tel;
			parameters[8].Value = model.Acreage;
			parameters[9].Value = model.ChargeAcreage;
			parameters[10].Value = model.Reserve;
			parameters[11].Value = model.Sex;
			parameters[12].Value = model.Populace;
			parameters[13].Value = model.Remark;
			parameters[14].Value = model.Mark;
			parameters[15].Value = model.DeptID;
			parameters[16].Value = model.UserFloor;
			parameters[17].Value = model.HouseDir;
			parameters[18].Value = model.UserType;
			parameters[19].Value = model.ClientId;
			parameters[20].Value = model.Remnant;
			parameters[21].Value = model.Remnant2;
			parameters[22].Value = model.Remnant3;
			parameters[23].Value = model.UpdateTime;
			parameters[24].Value = model.RegistPhone;
			parameters[25].Value = model.EInvoiceType;
			parameters[26].Value = model.UsersID;

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
		public bool Delete(int UsersID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from users ");
			strSql.Append(" where UsersID=@UsersID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4)			};
			parameters[0].Value = UsersID;

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
		public bool DeleteList(string UsersIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from users ");
			strSql.Append(" where UsersID in ("+UsersIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.users GetModel(int UsersID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UsersID,UserCode,UserName,Doorplate,PaperType,PaperNo,Address,Phone,Tel,Acreage,ChargeAcreage,Reserve,Sex,Populace,Remark,Mark,DeptID,UserFloor,HouseDir,UserType,ClientId,Remnant,Remnant2,Remnant3,UpdateTime,RegistPhone,EInvoiceType from users ");
			strSql.Append(" where UsersID=@UsersID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4)			};
			parameters[0].Value = UsersID;

			WebDemo.Model.WebDemo.users model=new WebDemo.Model.WebDemo.users();
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
		public WebDemo.Model.WebDemo.users DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.users model=new WebDemo.Model.WebDemo.users();
			if (row != null)
			{
				if(row["UsersID"]!=null && row["UsersID"].ToString()!="")
				{
					model.UsersID=int.Parse(row["UsersID"].ToString());
				}
				if(row["UserCode"]!=null)
				{
					model.UserCode=row["UserCode"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["Doorplate"]!=null)
				{
					model.Doorplate=row["Doorplate"].ToString();
				}
				if(row["PaperType"]!=null)
				{
					model.PaperType=row["PaperType"].ToString();
				}
				if(row["PaperNo"]!=null)
				{
					model.PaperNo=row["PaperNo"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["Acreage"]!=null && row["Acreage"].ToString()!="")
				{
					model.Acreage=decimal.Parse(row["Acreage"].ToString());
				}
				if(row["ChargeAcreage"]!=null && row["ChargeAcreage"].ToString()!="")
				{
					model.ChargeAcreage=decimal.Parse(row["ChargeAcreage"].ToString());
				}
				if(row["Reserve"]!=null && row["Reserve"].ToString()!="")
				{
					model.Reserve=decimal.Parse(row["Reserve"].ToString());
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["Populace"]!=null && row["Populace"].ToString()!="")
				{
					model.Populace=int.Parse(row["Populace"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["Mark"]!=null && row["Mark"].ToString()!="")
				{
					model.Mark=int.Parse(row["Mark"].ToString());
				}
				if(row["DeptID"]!=null)
				{
					model.DeptID=row["DeptID"].ToString();
				}
				if(row["UserFloor"]!=null)
				{
					model.UserFloor=row["UserFloor"].ToString();
				}
				if(row["HouseDir"]!=null)
				{
					model.HouseDir=row["HouseDir"].ToString();
				}
				if(row["UserType"]!=null)
				{
					model.UserType=row["UserType"].ToString();
				}
				if(row["ClientId"]!=null)
				{
					model.ClientId=row["ClientId"].ToString();
				}
				if(row["Remnant"]!=null && row["Remnant"].ToString()!="")
				{
					model.Remnant=decimal.Parse(row["Remnant"].ToString());
				}
				if(row["Remnant2"]!=null && row["Remnant2"].ToString()!="")
				{
					model.Remnant2=decimal.Parse(row["Remnant2"].ToString());
				}
				if(row["Remnant3"]!=null && row["Remnant3"].ToString()!="")
				{
					model.Remnant3=decimal.Parse(row["Remnant3"].ToString());
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
				}
				if(row["RegistPhone"]!=null)
				{
					model.RegistPhone=row["RegistPhone"].ToString();
				}
				if(row["EInvoiceType"]!=null && row["EInvoiceType"].ToString()!="")
				{
					model.EInvoiceType=int.Parse(row["EInvoiceType"].ToString());
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
			strSql.Append("select UsersID,UserCode,UserName,Doorplate,PaperType,PaperNo,Address,Phone,Tel,Acreage,ChargeAcreage,Reserve,Sex,Populace,Remark,Mark,DeptID,UserFloor,HouseDir,UserType,ClientId,Remnant,Remnant2,Remnant3,UpdateTime,RegistPhone,EInvoiceType ");
			strSql.Append(" FROM users ");
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
			strSql.Append(" UsersID,UserCode,UserName,Doorplate,PaperType,PaperNo,Address,Phone,Tel,Acreage,ChargeAcreage,Reserve,Sex,Populace,Remark,Mark,DeptID,UserFloor,HouseDir,UserType,ClientId,Remnant,Remnant2,Remnant3,UpdateTime,RegistPhone,EInvoiceType ");
			strSql.Append(" FROM users ");
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
			strSql.Append("select count(1) FROM users ");
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
				strSql.Append("order by T.UsersID desc");
			}
			strSql.Append(")AS Row, T.*  from users T ");
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
			parameters[0].Value = "users";
			parameters[1].Value = "UsersID";
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

