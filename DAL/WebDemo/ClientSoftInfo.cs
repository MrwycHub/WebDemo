using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:ClientSoftInfo
	/// </summary>
	public partial class ClientSoftInfo
	{
		public ClientSoftInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "ClientSoftInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string DanWeiName,string JiQiMa,int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ClientSoftInfo");
			strSql.Append(" where DanWeiName=@DanWeiName and JiQiMa=@JiQiMa and Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@DanWeiName", SqlDbType.NVarChar,200),
					new SqlParameter("@JiQiMa", SqlDbType.VarChar,200),
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = DanWeiName;
			parameters[1].Value = JiQiMa;
			parameters[2].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.ClientSoftInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ClientSoftInfo(");
			strSql.Append("DanWeiName,JiQiMa,RenZhengMa,SoftName,SoftHao,UsePassword,JieTiCalDate,SqlVersion,MeterTypes,CardTypes,PayTypes,UpdateTime)");
			strSql.Append(" values (");
			strSql.Append("@DanWeiName,@JiQiMa,@RenZhengMa,@SoftName,@SoftHao,@UsePassword,@JieTiCalDate,@SqlVersion,@MeterTypes,@CardTypes,@PayTypes,@UpdateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DanWeiName", SqlDbType.NVarChar,200),
					new SqlParameter("@JiQiMa", SqlDbType.VarChar,200),
					new SqlParameter("@RenZhengMa", SqlDbType.VarChar,200),
					new SqlParameter("@SoftName", SqlDbType.NVarChar,200),
					new SqlParameter("@SoftHao", SqlDbType.VarChar,50),
					new SqlParameter("@UsePassword", SqlDbType.VarChar,100),
					new SqlParameter("@JieTiCalDate", SqlDbType.VarChar,50),
					new SqlParameter("@SqlVersion", SqlDbType.Int,4),
					new SqlParameter("@MeterTypes", SqlDbType.VarChar,4000),
					new SqlParameter("@CardTypes", SqlDbType.VarChar,4000),
					new SqlParameter("@PayTypes", SqlDbType.VarChar,4000),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.DanWeiName;
			parameters[1].Value = model.JiQiMa;
			parameters[2].Value = model.RenZhengMa;
			parameters[3].Value = model.SoftName;
			parameters[4].Value = model.SoftHao;
			parameters[5].Value = model.UsePassword;
			parameters[6].Value = model.JieTiCalDate;
			parameters[7].Value = model.SqlVersion;
			parameters[8].Value = model.MeterTypes;
			parameters[9].Value = model.CardTypes;
			parameters[10].Value = model.PayTypes;
			parameters[11].Value = model.UpdateTime;

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
		public bool Update(WebDemo.Model.WebDemo.ClientSoftInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ClientSoftInfo set ");
			strSql.Append("RenZhengMa=@RenZhengMa,");
			strSql.Append("SoftName=@SoftName,");
			strSql.Append("SoftHao=@SoftHao,");
			strSql.Append("UsePassword=@UsePassword,");
			strSql.Append("JieTiCalDate=@JieTiCalDate,");
			strSql.Append("SqlVersion=@SqlVersion,");
			strSql.Append("MeterTypes=@MeterTypes,");
			strSql.Append("CardTypes=@CardTypes,");
			strSql.Append("PayTypes=@PayTypes,");
			strSql.Append("UpdateTime=@UpdateTime");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@RenZhengMa", SqlDbType.VarChar,200),
					new SqlParameter("@SoftName", SqlDbType.NVarChar,200),
					new SqlParameter("@SoftHao", SqlDbType.VarChar,50),
					new SqlParameter("@UsePassword", SqlDbType.VarChar,100),
					new SqlParameter("@JieTiCalDate", SqlDbType.VarChar,50),
					new SqlParameter("@SqlVersion", SqlDbType.Int,4),
					new SqlParameter("@MeterTypes", SqlDbType.VarChar,4000),
					new SqlParameter("@CardTypes", SqlDbType.VarChar,4000),
					new SqlParameter("@PayTypes", SqlDbType.VarChar,4000),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@DanWeiName", SqlDbType.NVarChar,200),
					new SqlParameter("@JiQiMa", SqlDbType.VarChar,200)};
			parameters[0].Value = model.RenZhengMa;
			parameters[1].Value = model.SoftName;
			parameters[2].Value = model.SoftHao;
			parameters[3].Value = model.UsePassword;
			parameters[4].Value = model.JieTiCalDate;
			parameters[5].Value = model.SqlVersion;
			parameters[6].Value = model.MeterTypes;
			parameters[7].Value = model.CardTypes;
			parameters[8].Value = model.PayTypes;
			parameters[9].Value = model.UpdateTime;
			parameters[10].Value = model.Id;
			parameters[11].Value = model.DanWeiName;
			parameters[12].Value = model.JiQiMa;

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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ClientSoftInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

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
		public bool Delete(string DanWeiName,string JiQiMa,int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ClientSoftInfo ");
			strSql.Append(" where DanWeiName=@DanWeiName and JiQiMa=@JiQiMa and Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@DanWeiName", SqlDbType.NVarChar,200),
					new SqlParameter("@JiQiMa", SqlDbType.VarChar,200),
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = DanWeiName;
			parameters[1].Value = JiQiMa;
			parameters[2].Value = Id;

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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ClientSoftInfo ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
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
		public WebDemo.Model.WebDemo.ClientSoftInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,DanWeiName,JiQiMa,RenZhengMa,SoftName,SoftHao,UsePassword,JieTiCalDate,SqlVersion,MeterTypes,CardTypes,PayTypes,UpdateTime from ClientSoftInfo ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			WebDemo.Model.WebDemo.ClientSoftInfo model=new WebDemo.Model.WebDemo.ClientSoftInfo();
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
		public WebDemo.Model.WebDemo.ClientSoftInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.ClientSoftInfo model=new WebDemo.Model.WebDemo.ClientSoftInfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["DanWeiName"]!=null)
				{
					model.DanWeiName=row["DanWeiName"].ToString();
				}
				if(row["JiQiMa"]!=null)
				{
					model.JiQiMa=row["JiQiMa"].ToString();
				}
				if(row["RenZhengMa"]!=null)
				{
					model.RenZhengMa=row["RenZhengMa"].ToString();
				}
				if(row["SoftName"]!=null)
				{
					model.SoftName=row["SoftName"].ToString();
				}
				if(row["SoftHao"]!=null)
				{
					model.SoftHao=row["SoftHao"].ToString();
				}
				if(row["UsePassword"]!=null)
				{
					model.UsePassword=row["UsePassword"].ToString();
				}
				if(row["JieTiCalDate"]!=null)
				{
					model.JieTiCalDate=row["JieTiCalDate"].ToString();
				}
				if(row["SqlVersion"]!=null && row["SqlVersion"].ToString()!="")
				{
					model.SqlVersion=int.Parse(row["SqlVersion"].ToString());
				}
				if(row["MeterTypes"]!=null)
				{
					model.MeterTypes=row["MeterTypes"].ToString();
				}
				if(row["CardTypes"]!=null)
				{
					model.CardTypes=row["CardTypes"].ToString();
				}
				if(row["PayTypes"]!=null)
				{
					model.PayTypes=row["PayTypes"].ToString();
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
			strSql.Append("select Id,DanWeiName,JiQiMa,RenZhengMa,SoftName,SoftHao,UsePassword,JieTiCalDate,SqlVersion,MeterTypes,CardTypes,PayTypes,UpdateTime ");
			strSql.Append(" FROM ClientSoftInfo ");
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
			strSql.Append(" Id,DanWeiName,JiQiMa,RenZhengMa,SoftName,SoftHao,UsePassword,JieTiCalDate,SqlVersion,MeterTypes,CardTypes,PayTypes,UpdateTime ");
			strSql.Append(" FROM ClientSoftInfo ");
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
			strSql.Append("select count(1) FROM ClientSoftInfo ");
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from ClientSoftInfo T ");
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
			parameters[0].Value = "ClientSoftInfo";
			parameters[1].Value = "Id";
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

