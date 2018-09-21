using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:ChangeMeterRegist
	/// </summary>
	public partial class ChangeMeterRegist
	{
		public ChangeMeterRegist()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ChangeMeterRegist"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ChangeMeterRegist");
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
		public int Add(WebDemo.Model.WebDemo.ChangeMeterRegist model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ChangeMeterRegist(");
			strSql.Append("UsersID,UserCode,OldNumber,NewMeterAddr,Remark,Status,ImagePath,OperatorCode,NewNumber,NewMeterId,InsertDate,ChangeMeterDate,MeterID)");
			strSql.Append(" values (");
			strSql.Append("@UsersID,@UserCode,@OldNumber,@NewMeterAddr,@Remark,@Status,@ImagePath,@OperatorCode,@NewNumber,@NewMeterId,@InsertDate,@ChangeMeterDate,@MeterID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@UserCode", SqlDbType.VarChar,100),
					new SqlParameter("@OldNumber", SqlDbType.Decimal,9),
					new SqlParameter("@NewMeterAddr", SqlDbType.VarChar,100),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@Status", SqlDbType.Int,4),
					new SqlParameter("@ImagePath", SqlDbType.VarChar,8000),
					new SqlParameter("@OperatorCode", SqlDbType.VarChar,100),
					new SqlParameter("@NewNumber", SqlDbType.Decimal,9),
					new SqlParameter("@NewMeterId", SqlDbType.Int,4),
					new SqlParameter("@InsertDate", SqlDbType.DateTime),
					new SqlParameter("@ChangeMeterDate", SqlDbType.DateTime),
					new SqlParameter("@MeterID", SqlDbType.Int,4)};
			parameters[0].Value = model.UsersID;
			parameters[1].Value = model.UserCode;
			parameters[2].Value = model.OldNumber;
			parameters[3].Value = model.NewMeterAddr;
			parameters[4].Value = model.Remark;
			parameters[5].Value = model.Status;
			parameters[6].Value = model.ImagePath;
			parameters[7].Value = model.OperatorCode;
			parameters[8].Value = model.NewNumber;
			parameters[9].Value = model.NewMeterId;
			parameters[10].Value = model.InsertDate;
			parameters[11].Value = model.ChangeMeterDate;
			parameters[12].Value = model.MeterID;

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
		public bool Update(WebDemo.Model.WebDemo.ChangeMeterRegist model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ChangeMeterRegist set ");
			strSql.Append("UsersID=@UsersID,");
			strSql.Append("UserCode=@UserCode,");
			strSql.Append("OldNumber=@OldNumber,");
			strSql.Append("NewMeterAddr=@NewMeterAddr,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Status=@Status,");
			strSql.Append("ImagePath=@ImagePath,");
			strSql.Append("OperatorCode=@OperatorCode,");
			strSql.Append("NewNumber=@NewNumber,");
			strSql.Append("NewMeterId=@NewMeterId,");
			strSql.Append("InsertDate=@InsertDate,");
			strSql.Append("ChangeMeterDate=@ChangeMeterDate,");
			strSql.Append("MeterID=@MeterID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UsersID", SqlDbType.Int,4),
					new SqlParameter("@UserCode", SqlDbType.VarChar,100),
					new SqlParameter("@OldNumber", SqlDbType.Decimal,9),
					new SqlParameter("@NewMeterAddr", SqlDbType.VarChar,100),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@Status", SqlDbType.Int,4),
					new SqlParameter("@ImagePath", SqlDbType.VarChar,8000),
					new SqlParameter("@OperatorCode", SqlDbType.VarChar,100),
					new SqlParameter("@NewNumber", SqlDbType.Decimal,9),
					new SqlParameter("@NewMeterId", SqlDbType.Int,4),
					new SqlParameter("@InsertDate", SqlDbType.DateTime),
					new SqlParameter("@ChangeMeterDate", SqlDbType.DateTime),
					new SqlParameter("@MeterID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.UsersID;
			parameters[1].Value = model.UserCode;
			parameters[2].Value = model.OldNumber;
			parameters[3].Value = model.NewMeterAddr;
			parameters[4].Value = model.Remark;
			parameters[5].Value = model.Status;
			parameters[6].Value = model.ImagePath;
			parameters[7].Value = model.OperatorCode;
			parameters[8].Value = model.NewNumber;
			parameters[9].Value = model.NewMeterId;
			parameters[10].Value = model.InsertDate;
			parameters[11].Value = model.ChangeMeterDate;
			parameters[12].Value = model.MeterID;
			parameters[13].Value = model.ID;

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
			strSql.Append("delete from ChangeMeterRegist ");
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
			strSql.Append("delete from ChangeMeterRegist ");
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
		public WebDemo.Model.WebDemo.ChangeMeterRegist GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,UsersID,UserCode,OldNumber,NewMeterAddr,Remark,Status,ImagePath,OperatorCode,NewNumber,NewMeterId,InsertDate,ChangeMeterDate,MeterID from ChangeMeterRegist ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.ChangeMeterRegist model=new WebDemo.Model.WebDemo.ChangeMeterRegist();
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
		public WebDemo.Model.WebDemo.ChangeMeterRegist DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.ChangeMeterRegist model=new WebDemo.Model.WebDemo.ChangeMeterRegist();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["UsersID"]!=null && row["UsersID"].ToString()!="")
				{
					model.UsersID=int.Parse(row["UsersID"].ToString());
				}
				if(row["UserCode"]!=null)
				{
					model.UserCode=row["UserCode"].ToString();
				}
				if(row["OldNumber"]!=null && row["OldNumber"].ToString()!="")
				{
					model.OldNumber=decimal.Parse(row["OldNumber"].ToString());
				}
				if(row["NewMeterAddr"]!=null)
				{
					model.NewMeterAddr=row["NewMeterAddr"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["Status"]!=null && row["Status"].ToString()!="")
				{
					model.Status=int.Parse(row["Status"].ToString());
				}
				if(row["ImagePath"]!=null)
				{
					model.ImagePath=row["ImagePath"].ToString();
				}
				if(row["OperatorCode"]!=null)
				{
					model.OperatorCode=row["OperatorCode"].ToString();
				}
				if(row["NewNumber"]!=null && row["NewNumber"].ToString()!="")
				{
					model.NewNumber=decimal.Parse(row["NewNumber"].ToString());
				}
				if(row["NewMeterId"]!=null && row["NewMeterId"].ToString()!="")
				{
					model.NewMeterId=int.Parse(row["NewMeterId"].ToString());
				}
				if(row["InsertDate"]!=null && row["InsertDate"].ToString()!="")
				{
					model.InsertDate=DateTime.Parse(row["InsertDate"].ToString());
				}
				if(row["ChangeMeterDate"]!=null && row["ChangeMeterDate"].ToString()!="")
				{
					model.ChangeMeterDate=DateTime.Parse(row["ChangeMeterDate"].ToString());
				}
				if(row["MeterID"]!=null && row["MeterID"].ToString()!="")
				{
					model.MeterID=int.Parse(row["MeterID"].ToString());
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
			strSql.Append("select ID,UsersID,UserCode,OldNumber,NewMeterAddr,Remark,Status,ImagePath,OperatorCode,NewNumber,NewMeterId,InsertDate,ChangeMeterDate,MeterID ");
			strSql.Append(" FROM ChangeMeterRegist ");
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
			strSql.Append(" ID,UsersID,UserCode,OldNumber,NewMeterAddr,Remark,Status,ImagePath,OperatorCode,NewNumber,NewMeterId,InsertDate,ChangeMeterDate,MeterID ");
			strSql.Append(" FROM ChangeMeterRegist ");
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
			strSql.Append("select count(1) FROM ChangeMeterRegist ");
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
			strSql.Append(")AS Row, T.*  from ChangeMeterRegist T ");
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
			parameters[0].Value = "ChangeMeterRegist";
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

