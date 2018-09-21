using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:FailureInfo
	/// </summary>
	public partial class FailureInfo
	{
		public FailureInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "FailureInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FailureInfo");
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
		public int Add(WebDemo.Model.WebDemo.FailureInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FailureInfo(");
			strSql.Append("MeterID,FailurePhone,FailureMan,FailureMemo,FailureType,FailureRegTime,FailureRegType,DisposeMan,DisposeMemo,DisposeStatus,DisposeTime,sel,FailureCode,AppointMan,AppointManPhone,FailureSort,UsersID,UserCode)");
			strSql.Append(" values (");
			strSql.Append("@MeterID,@FailurePhone,@FailureMan,@FailureMemo,@FailureType,@FailureRegTime,@FailureRegType,@DisposeMan,@DisposeMemo,@DisposeStatus,@DisposeTime,@sel,@FailureCode,@AppointMan,@AppointManPhone,@FailureSort,@UsersID,@UserCode)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FailurePhone", SqlDbType.VarChar,50),
					new SqlParameter("@FailureMan", SqlDbType.VarChar,50),
					new SqlParameter("@FailureMemo", SqlDbType.VarChar,500),
					new SqlParameter("@FailureType", SqlDbType.Int,4),
					new SqlParameter("@FailureRegTime", SqlDbType.DateTime),
					new SqlParameter("@FailureRegType", SqlDbType.Int,4),
					new SqlParameter("@DisposeMan", SqlDbType.VarChar,50),
					new SqlParameter("@DisposeMemo", SqlDbType.VarChar,500),
					new SqlParameter("@DisposeStatus", SqlDbType.Int,4),
					new SqlParameter("@DisposeTime", SqlDbType.DateTime),
					new SqlParameter("@sel", SqlDbType.Bit,1),
					new SqlParameter("@FailureCode", SqlDbType.VarChar,20),
					new SqlParameter("@AppointMan", SqlDbType.VarChar,50),
					new SqlParameter("@AppointManPhone", SqlDbType.VarChar,50),
					new SqlParameter("@FailureSort", SqlDbType.Int,4),
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@UserCode", SqlDbType.VarChar,50)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.FailurePhone;
			parameters[2].Value = model.FailureMan;
			parameters[3].Value = model.FailureMemo;
			parameters[4].Value = model.FailureType;
			parameters[5].Value = model.FailureRegTime;
			parameters[6].Value = model.FailureRegType;
			parameters[7].Value = model.DisposeMan;
			parameters[8].Value = model.DisposeMemo;
			parameters[9].Value = model.DisposeStatus;
			parameters[10].Value = model.DisposeTime;
			parameters[11].Value = model.sel;
			parameters[12].Value = model.FailureCode;
			parameters[13].Value = model.AppointMan;
			parameters[14].Value = model.AppointManPhone;
			parameters[15].Value = model.FailureSort;
			parameters[16].Value = model.UsersID;
			parameters[17].Value = model.UserCode;

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
		public bool Update(WebDemo.Model.WebDemo.FailureInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FailureInfo set ");
			strSql.Append("MeterID=@MeterID,");
			strSql.Append("FailurePhone=@FailurePhone,");
			strSql.Append("FailureMan=@FailureMan,");
			strSql.Append("FailureMemo=@FailureMemo,");
			strSql.Append("FailureType=@FailureType,");
			strSql.Append("FailureRegTime=@FailureRegTime,");
			strSql.Append("FailureRegType=@FailureRegType,");
			strSql.Append("DisposeMan=@DisposeMan,");
			strSql.Append("DisposeMemo=@DisposeMemo,");
			strSql.Append("DisposeStatus=@DisposeStatus,");
			strSql.Append("DisposeTime=@DisposeTime,");
			strSql.Append("sel=@sel,");
			strSql.Append("FailureCode=@FailureCode,");
			strSql.Append("AppointMan=@AppointMan,");
			strSql.Append("AppointManPhone=@AppointManPhone,");
			strSql.Append("FailureSort=@FailureSort,");
			strSql.Append("UsersID=@UsersID,");
			strSql.Append("UserCode=@UserCode");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@FailurePhone", SqlDbType.VarChar,50),
					new SqlParameter("@FailureMan", SqlDbType.VarChar,50),
					new SqlParameter("@FailureMemo", SqlDbType.VarChar,500),
					new SqlParameter("@FailureType", SqlDbType.Int,4),
					new SqlParameter("@FailureRegTime", SqlDbType.DateTime),
					new SqlParameter("@FailureRegType", SqlDbType.Int,4),
					new SqlParameter("@DisposeMan", SqlDbType.VarChar,50),
					new SqlParameter("@DisposeMemo", SqlDbType.VarChar,500),
					new SqlParameter("@DisposeStatus", SqlDbType.Int,4),
					new SqlParameter("@DisposeTime", SqlDbType.DateTime),
					new SqlParameter("@sel", SqlDbType.Bit,1),
					new SqlParameter("@FailureCode", SqlDbType.VarChar,20),
					new SqlParameter("@AppointMan", SqlDbType.VarChar,50),
					new SqlParameter("@AppointManPhone", SqlDbType.VarChar,50),
					new SqlParameter("@FailureSort", SqlDbType.Int,4),
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@UserCode", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.MeterID;
			parameters[1].Value = model.FailurePhone;
			parameters[2].Value = model.FailureMan;
			parameters[3].Value = model.FailureMemo;
			parameters[4].Value = model.FailureType;
			parameters[5].Value = model.FailureRegTime;
			parameters[6].Value = model.FailureRegType;
			parameters[7].Value = model.DisposeMan;
			parameters[8].Value = model.DisposeMemo;
			parameters[9].Value = model.DisposeStatus;
			parameters[10].Value = model.DisposeTime;
			parameters[11].Value = model.sel;
			parameters[12].Value = model.FailureCode;
			parameters[13].Value = model.AppointMan;
			parameters[14].Value = model.AppointManPhone;
			parameters[15].Value = model.FailureSort;
			parameters[16].Value = model.UsersID;
			parameters[17].Value = model.UserCode;
			parameters[18].Value = model.ID;

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
			strSql.Append("delete from FailureInfo ");
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
			strSql.Append("delete from FailureInfo ");
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
		public WebDemo.Model.WebDemo.FailureInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MeterID,FailurePhone,FailureMan,FailureMemo,FailureType,FailureRegTime,FailureRegType,DisposeMan,DisposeMemo,DisposeStatus,DisposeTime,sel,FailureCode,AppointMan,AppointManPhone,FailureSort,UsersID,UserCode from FailureInfo ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.FailureInfo model=new WebDemo.Model.WebDemo.FailureInfo();
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
		public WebDemo.Model.WebDemo.FailureInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.FailureInfo model=new WebDemo.Model.WebDemo.FailureInfo();
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
				if(row["FailurePhone"]!=null)
				{
					model.FailurePhone=row["FailurePhone"].ToString();
				}
				if(row["FailureMan"]!=null)
				{
					model.FailureMan=row["FailureMan"].ToString();
				}
				if(row["FailureMemo"]!=null)
				{
					model.FailureMemo=row["FailureMemo"].ToString();
				}
				if(row["FailureType"]!=null && row["FailureType"].ToString()!="")
				{
					model.FailureType=int.Parse(row["FailureType"].ToString());
				}
				if(row["FailureRegTime"]!=null && row["FailureRegTime"].ToString()!="")
				{
					model.FailureRegTime=DateTime.Parse(row["FailureRegTime"].ToString());
				}
				if(row["FailureRegType"]!=null && row["FailureRegType"].ToString()!="")
				{
					model.FailureRegType=int.Parse(row["FailureRegType"].ToString());
				}
				if(row["DisposeMan"]!=null)
				{
					model.DisposeMan=row["DisposeMan"].ToString();
				}
				if(row["DisposeMemo"]!=null)
				{
					model.DisposeMemo=row["DisposeMemo"].ToString();
				}
				if(row["DisposeStatus"]!=null && row["DisposeStatus"].ToString()!="")
				{
					model.DisposeStatus=int.Parse(row["DisposeStatus"].ToString());
				}
				if(row["DisposeTime"]!=null && row["DisposeTime"].ToString()!="")
				{
					model.DisposeTime=DateTime.Parse(row["DisposeTime"].ToString());
				}
				if(row["sel"]!=null && row["sel"].ToString()!="")
				{
					if((row["sel"].ToString()=="1")||(row["sel"].ToString().ToLower()=="true"))
					{
						model.sel=true;
					}
					else
					{
						model.sel=false;
					}
				}
				if(row["FailureCode"]!=null)
				{
					model.FailureCode=row["FailureCode"].ToString();
				}
				if(row["AppointMan"]!=null)
				{
					model.AppointMan=row["AppointMan"].ToString();
				}
				if(row["AppointManPhone"]!=null)
				{
					model.AppointManPhone=row["AppointManPhone"].ToString();
				}
				if(row["FailureSort"]!=null && row["FailureSort"].ToString()!="")
				{
					model.FailureSort=int.Parse(row["FailureSort"].ToString());
				}
				if(row["UsersID"]!=null && row["UsersID"].ToString()!="")
				{
					model.UsersID=int.Parse(row["UsersID"].ToString());
				}
				if(row["UserCode"]!=null)
				{
					model.UserCode=row["UserCode"].ToString();
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
			strSql.Append("select ID,MeterID,FailurePhone,FailureMan,FailureMemo,FailureType,FailureRegTime,FailureRegType,DisposeMan,DisposeMemo,DisposeStatus,DisposeTime,sel,FailureCode,AppointMan,AppointManPhone,FailureSort,UsersID,UserCode ");
			strSql.Append(" FROM FailureInfo ");
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
			strSql.Append(" ID,MeterID,FailurePhone,FailureMan,FailureMemo,FailureType,FailureRegTime,FailureRegType,DisposeMan,DisposeMemo,DisposeStatus,DisposeTime,sel,FailureCode,AppointMan,AppointManPhone,FailureSort,UsersID,UserCode ");
			strSql.Append(" FROM FailureInfo ");
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
			strSql.Append("select count(1) FROM FailureInfo ");
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
			strSql.Append(")AS Row, T.*  from FailureInfo T ");
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
			parameters[0].Value = "FailureInfo";
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

