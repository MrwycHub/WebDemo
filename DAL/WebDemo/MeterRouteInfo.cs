using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MeterRouteInfo
	/// </summary>
	public partial class MeterRouteInfo
	{
		public MeterRouteInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string MeterAddr)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MeterRouteInfo");
			strSql.Append(" where MeterAddr=@MeterAddr ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,20)			};
			parameters[0].Value = MeterAddr;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.MeterRouteInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MeterRouteInfo(");
			strSql.Append("MeterAddr,MeterNo,Node1,Depth1,Node2,Depth2,Node3,Depth3,Node4,Depth4,Result,CollectorId,MeterId,ReadTime)");
			strSql.Append(" values (");
			strSql.Append("@MeterAddr,@MeterNo,@Node1,@Depth1,@Node2,@Depth2,@Node3,@Depth3,@Node4,@Depth4,@Result,@CollectorId,@MeterId,@ReadTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,20),
					new SqlParameter("@MeterNo", SqlDbType.Int,4),
					new SqlParameter("@Node1", SqlDbType.VarChar,20),
					new SqlParameter("@Depth1", SqlDbType.Int,4),
					new SqlParameter("@Node2", SqlDbType.VarChar,20),
					new SqlParameter("@Depth2", SqlDbType.Int,4),
					new SqlParameter("@Node3", SqlDbType.VarChar,20),
					new SqlParameter("@Depth3", SqlDbType.Int,4),
					new SqlParameter("@Node4", SqlDbType.VarChar,20),
					new SqlParameter("@Depth4", SqlDbType.Int,4),
					new SqlParameter("@Result", SqlDbType.Bit,1),
					new SqlParameter("@CollectorId", SqlDbType.Int,4),
					new SqlParameter("@MeterId", SqlDbType.Int,4),
					new SqlParameter("@ReadTime", SqlDbType.DateTime)};
			parameters[0].Value = model.MeterAddr;
			parameters[1].Value = model.MeterNo;
			parameters[2].Value = model.Node1;
			parameters[3].Value = model.Depth1;
			parameters[4].Value = model.Node2;
			parameters[5].Value = model.Depth2;
			parameters[6].Value = model.Node3;
			parameters[7].Value = model.Depth3;
			parameters[8].Value = model.Node4;
			parameters[9].Value = model.Depth4;
			parameters[10].Value = model.Result;
			parameters[11].Value = model.CollectorId;
			parameters[12].Value = model.MeterId;
			parameters[13].Value = model.ReadTime;

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
		public bool Update(WebDemo.Model.WebDemo.MeterRouteInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MeterRouteInfo set ");
			strSql.Append("MeterNo=@MeterNo,");
			strSql.Append("Node1=@Node1,");
			strSql.Append("Depth1=@Depth1,");
			strSql.Append("Node2=@Node2,");
			strSql.Append("Depth2=@Depth2,");
			strSql.Append("Node3=@Node3,");
			strSql.Append("Depth3=@Depth3,");
			strSql.Append("Node4=@Node4,");
			strSql.Append("Depth4=@Depth4,");
			strSql.Append("Result=@Result,");
			strSql.Append("CollectorId=@CollectorId,");
			strSql.Append("MeterId=@MeterId,");
			strSql.Append("ReadTime=@ReadTime");
			strSql.Append(" where MeterAddr=@MeterAddr ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterNo", SqlDbType.Int,4),
					new SqlParameter("@Node1", SqlDbType.VarChar,20),
					new SqlParameter("@Depth1", SqlDbType.Int,4),
					new SqlParameter("@Node2", SqlDbType.VarChar,20),
					new SqlParameter("@Depth2", SqlDbType.Int,4),
					new SqlParameter("@Node3", SqlDbType.VarChar,20),
					new SqlParameter("@Depth3", SqlDbType.Int,4),
					new SqlParameter("@Node4", SqlDbType.VarChar,20),
					new SqlParameter("@Depth4", SqlDbType.Int,4),
					new SqlParameter("@Result", SqlDbType.Bit,1),
					new SqlParameter("@CollectorId", SqlDbType.Int,4),
					new SqlParameter("@MeterId", SqlDbType.Int,4),
					new SqlParameter("@ReadTime", SqlDbType.DateTime),
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,20)};
			parameters[0].Value = model.MeterNo;
			parameters[1].Value = model.Node1;
			parameters[2].Value = model.Depth1;
			parameters[3].Value = model.Node2;
			parameters[4].Value = model.Depth2;
			parameters[5].Value = model.Node3;
			parameters[6].Value = model.Depth3;
			parameters[7].Value = model.Node4;
			parameters[8].Value = model.Depth4;
			parameters[9].Value = model.Result;
			parameters[10].Value = model.CollectorId;
			parameters[11].Value = model.MeterId;
			parameters[12].Value = model.ReadTime;
			parameters[13].Value = model.MeterAddr;

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
		public bool Delete(string MeterAddr)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeterRouteInfo ");
			strSql.Append(" where MeterAddr=@MeterAddr ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,20)			};
			parameters[0].Value = MeterAddr;

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
		public bool DeleteList(string MeterAddrlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeterRouteInfo ");
			strSql.Append(" where MeterAddr in ("+MeterAddrlist + ")  ");
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
		public WebDemo.Model.WebDemo.MeterRouteInfo GetModel(string MeterAddr)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MeterAddr,MeterNo,Node1,Depth1,Node2,Depth2,Node3,Depth3,Node4,Depth4,Result,CollectorId,MeterId,ReadTime from MeterRouteInfo ");
			strSql.Append(" where MeterAddr=@MeterAddr ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterAddr", SqlDbType.VarChar,20)			};
			parameters[0].Value = MeterAddr;

			WebDemo.Model.WebDemo.MeterRouteInfo model=new WebDemo.Model.WebDemo.MeterRouteInfo();
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
		public WebDemo.Model.WebDemo.MeterRouteInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MeterRouteInfo model=new WebDemo.Model.WebDemo.MeterRouteInfo();
			if (row != null)
			{
				if(row["MeterAddr"]!=null)
				{
					model.MeterAddr=row["MeterAddr"].ToString();
				}
				if(row["MeterNo"]!=null && row["MeterNo"].ToString()!="")
				{
					model.MeterNo=int.Parse(row["MeterNo"].ToString());
				}
				if(row["Node1"]!=null)
				{
					model.Node1=row["Node1"].ToString();
				}
				if(row["Depth1"]!=null && row["Depth1"].ToString()!="")
				{
					model.Depth1=int.Parse(row["Depth1"].ToString());
				}
				if(row["Node2"]!=null)
				{
					model.Node2=row["Node2"].ToString();
				}
				if(row["Depth2"]!=null && row["Depth2"].ToString()!="")
				{
					model.Depth2=int.Parse(row["Depth2"].ToString());
				}
				if(row["Node3"]!=null)
				{
					model.Node3=row["Node3"].ToString();
				}
				if(row["Depth3"]!=null && row["Depth3"].ToString()!="")
				{
					model.Depth3=int.Parse(row["Depth3"].ToString());
				}
				if(row["Node4"]!=null)
				{
					model.Node4=row["Node4"].ToString();
				}
				if(row["Depth4"]!=null && row["Depth4"].ToString()!="")
				{
					model.Depth4=int.Parse(row["Depth4"].ToString());
				}
				if(row["Result"]!=null && row["Result"].ToString()!="")
				{
					if((row["Result"].ToString()=="1")||(row["Result"].ToString().ToLower()=="true"))
					{
						model.Result=true;
					}
					else
					{
						model.Result=false;
					}
				}
				if(row["CollectorId"]!=null && row["CollectorId"].ToString()!="")
				{
					model.CollectorId=int.Parse(row["CollectorId"].ToString());
				}
				if(row["MeterId"]!=null && row["MeterId"].ToString()!="")
				{
					model.MeterId=int.Parse(row["MeterId"].ToString());
				}
				if(row["ReadTime"]!=null && row["ReadTime"].ToString()!="")
				{
					model.ReadTime=DateTime.Parse(row["ReadTime"].ToString());
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
			strSql.Append("select MeterAddr,MeterNo,Node1,Depth1,Node2,Depth2,Node3,Depth3,Node4,Depth4,Result,CollectorId,MeterId,ReadTime ");
			strSql.Append(" FROM MeterRouteInfo ");
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
			strSql.Append(" MeterAddr,MeterNo,Node1,Depth1,Node2,Depth2,Node3,Depth3,Node4,Depth4,Result,CollectorId,MeterId,ReadTime ");
			strSql.Append(" FROM MeterRouteInfo ");
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
			strSql.Append("select count(1) FROM MeterRouteInfo ");
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
				strSql.Append("order by T.MeterAddr desc");
			}
			strSql.Append(")AS Row, T.*  from MeterRouteInfo T ");
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
			parameters[0].Value = "MeterRouteInfo";
			parameters[1].Value = "MeterAddr";
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

