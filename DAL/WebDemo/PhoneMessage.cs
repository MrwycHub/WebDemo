using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:PhoneMessage
	/// </summary>
	public partial class PhoneMessage
	{
		public PhoneMessage()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "PhoneMessage"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PhoneMessage");
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
		public int Add(WebDemo.Model.WebDemo.PhoneMessage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PhoneMessage(");
			strSql.Append("SoftName,Brands,Model,Version,BlueToothVer,SDKVer,IMEI,CPU,Memory,Resolution,FirstLoginDate)");
			strSql.Append(" values (");
			strSql.Append("@SoftName,@Brands,@Model,@Version,@BlueToothVer,@SDKVer,@IMEI,@CPU,@Memory,@Resolution,@FirstLoginDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SoftName", SqlDbType.VarChar,100),
					new SqlParameter("@Brands", SqlDbType.VarChar,50),
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@Version", SqlDbType.VarChar,50),
					new SqlParameter("@BlueToothVer", SqlDbType.VarChar,50),
					new SqlParameter("@SDKVer", SqlDbType.VarChar,50),
					new SqlParameter("@IMEI", SqlDbType.VarChar,50),
					new SqlParameter("@CPU", SqlDbType.VarChar,50),
					new SqlParameter("@Memory", SqlDbType.VarChar,50),
					new SqlParameter("@Resolution", SqlDbType.VarChar,50),
					new SqlParameter("@FirstLoginDate", SqlDbType.DateTime)};
			parameters[0].Value = model.SoftName;
			parameters[1].Value = model.Brands;
			parameters[2].Value = model.Model;
			parameters[3].Value = model.Version;
			parameters[4].Value = model.BlueToothVer;
			parameters[5].Value = model.SDKVer;
			parameters[6].Value = model.IMEI;
			parameters[7].Value = model.CPU;
			parameters[8].Value = model.Memory;
			parameters[9].Value = model.Resolution;
			parameters[10].Value = model.FirstLoginDate;

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
		public bool Update(WebDemo.Model.WebDemo.PhoneMessage model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PhoneMessage set ");
			strSql.Append("SoftName=@SoftName,");
			strSql.Append("Brands=@Brands,");
			strSql.Append("Model=@Model,");
			strSql.Append("Version=@Version,");
			strSql.Append("BlueToothVer=@BlueToothVer,");
			strSql.Append("SDKVer=@SDKVer,");
			strSql.Append("IMEI=@IMEI,");
			strSql.Append("CPU=@CPU,");
			strSql.Append("Memory=@Memory,");
			strSql.Append("Resolution=@Resolution,");
			strSql.Append("FirstLoginDate=@FirstLoginDate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@SoftName", SqlDbType.VarChar,100),
					new SqlParameter("@Brands", SqlDbType.VarChar,50),
					new SqlParameter("@Model", SqlDbType.VarChar,50),
					new SqlParameter("@Version", SqlDbType.VarChar,50),
					new SqlParameter("@BlueToothVer", SqlDbType.VarChar,50),
					new SqlParameter("@SDKVer", SqlDbType.VarChar,50),
					new SqlParameter("@IMEI", SqlDbType.VarChar,50),
					new SqlParameter("@CPU", SqlDbType.VarChar,50),
					new SqlParameter("@Memory", SqlDbType.VarChar,50),
					new SqlParameter("@Resolution", SqlDbType.VarChar,50),
					new SqlParameter("@FirstLoginDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.SoftName;
			parameters[1].Value = model.Brands;
			parameters[2].Value = model.Model;
			parameters[3].Value = model.Version;
			parameters[4].Value = model.BlueToothVer;
			parameters[5].Value = model.SDKVer;
			parameters[6].Value = model.IMEI;
			parameters[7].Value = model.CPU;
			parameters[8].Value = model.Memory;
			parameters[9].Value = model.Resolution;
			parameters[10].Value = model.FirstLoginDate;
			parameters[11].Value = model.ID;

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
			strSql.Append("delete from PhoneMessage ");
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
			strSql.Append("delete from PhoneMessage ");
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
		public WebDemo.Model.WebDemo.PhoneMessage GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,SoftName,Brands,Model,Version,BlueToothVer,SDKVer,IMEI,CPU,Memory,Resolution,FirstLoginDate from PhoneMessage ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.PhoneMessage model=new WebDemo.Model.WebDemo.PhoneMessage();
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
		public WebDemo.Model.WebDemo.PhoneMessage DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.PhoneMessage model=new WebDemo.Model.WebDemo.PhoneMessage();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["SoftName"]!=null)
				{
					model.SoftName=row["SoftName"].ToString();
				}
				if(row["Brands"]!=null)
				{
					model.Brands=row["Brands"].ToString();
				}
				if(row["Model"]!=null)
				{
					model.Model=row["Model"].ToString();
				}
				if(row["Version"]!=null)
				{
					model.Version=row["Version"].ToString();
				}
				if(row["BlueToothVer"]!=null)
				{
					model.BlueToothVer=row["BlueToothVer"].ToString();
				}
				if(row["SDKVer"]!=null)
				{
					model.SDKVer=row["SDKVer"].ToString();
				}
				if(row["IMEI"]!=null)
				{
					model.IMEI=row["IMEI"].ToString();
				}
				if(row["CPU"]!=null)
				{
					model.CPU=row["CPU"].ToString();
				}
				if(row["Memory"]!=null)
				{
					model.Memory=row["Memory"].ToString();
				}
				if(row["Resolution"]!=null)
				{
					model.Resolution=row["Resolution"].ToString();
				}
				if(row["FirstLoginDate"]!=null && row["FirstLoginDate"].ToString()!="")
				{
					model.FirstLoginDate=DateTime.Parse(row["FirstLoginDate"].ToString());
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
			strSql.Append("select ID,SoftName,Brands,Model,Version,BlueToothVer,SDKVer,IMEI,CPU,Memory,Resolution,FirstLoginDate ");
			strSql.Append(" FROM PhoneMessage ");
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
			strSql.Append(" ID,SoftName,Brands,Model,Version,BlueToothVer,SDKVer,IMEI,CPU,Memory,Resolution,FirstLoginDate ");
			strSql.Append(" FROM PhoneMessage ");
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
			strSql.Append("select count(1) FROM PhoneMessage ");
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
			strSql.Append(")AS Row, T.*  from PhoneMessage T ");
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
			parameters[0].Value = "PhoneMessage";
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

