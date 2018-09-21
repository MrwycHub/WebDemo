using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:ParamsKinds
	/// </summary>
	public partial class ParamsKinds
	{
		public ParamsKinds()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string ParamName,string PTypeNum)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ParamsKinds");
			strSql.Append(" where ParamName=@ParamName and PTypeNum=@PTypeNum ");
			SqlParameter[] parameters = {
					new SqlParameter("@ParamName", SqlDbType.VarChar,50),
					new SqlParameter("@PTypeNum", SqlDbType.VarChar,10)			};
			parameters[0].Value = ParamName;
			parameters[1].Value = PTypeNum;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.ParamsKinds model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ParamsKinds(");
			strSql.Append("ParamName,PTypeNum,PDisplayValue,Remark,Flag,PTypeValue)");
			strSql.Append(" values (");
			strSql.Append("@ParamName,@PTypeNum,@PDisplayValue,@Remark,@Flag,@PTypeValue)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ParamName", SqlDbType.VarChar,50),
					new SqlParameter("@PTypeNum", SqlDbType.VarChar,10),
					new SqlParameter("@PDisplayValue", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,50),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@PTypeValue", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ParamName;
			parameters[1].Value = model.PTypeNum;
			parameters[2].Value = model.PDisplayValue;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.Flag;
			parameters[5].Value = model.PTypeValue;

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
		public bool Update(WebDemo.Model.WebDemo.ParamsKinds model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ParamsKinds set ");
			strSql.Append("PDisplayValue=@PDisplayValue,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Flag=@Flag,");
			strSql.Append("PTypeValue=@PTypeValue");
			strSql.Append(" where Pid=@Pid");
			SqlParameter[] parameters = {
					new SqlParameter("@PDisplayValue", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,50),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@PTypeValue", SqlDbType.VarChar,50),
					new SqlParameter("@Pid", SqlDbType.Int,4),
					new SqlParameter("@ParamName", SqlDbType.VarChar,50),
					new SqlParameter("@PTypeNum", SqlDbType.VarChar,10)};
			parameters[0].Value = model.PDisplayValue;
			parameters[1].Value = model.Remark;
			parameters[2].Value = model.Flag;
			parameters[3].Value = model.PTypeValue;
			parameters[4].Value = model.Pid;
			parameters[5].Value = model.ParamName;
			parameters[6].Value = model.PTypeNum;

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
		public bool Delete(int Pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ParamsKinds ");
			strSql.Append(" where Pid=@Pid");
			SqlParameter[] parameters = {
					new SqlParameter("@Pid", SqlDbType.Int,4)
			};
			parameters[0].Value = Pid;

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
		public bool Delete(string ParamName,string PTypeNum)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ParamsKinds ");
			strSql.Append(" where ParamName=@ParamName and PTypeNum=@PTypeNum ");
			SqlParameter[] parameters = {
					new SqlParameter("@ParamName", SqlDbType.VarChar,50),
					new SqlParameter("@PTypeNum", SqlDbType.VarChar,10)			};
			parameters[0].Value = ParamName;
			parameters[1].Value = PTypeNum;

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
		public bool DeleteList(string Pidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ParamsKinds ");
			strSql.Append(" where Pid in ("+Pidlist + ")  ");
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
		public WebDemo.Model.WebDemo.ParamsKinds GetModel(int Pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Pid,ParamName,PTypeNum,PDisplayValue,Remark,Flag,PTypeValue from ParamsKinds ");
			strSql.Append(" where Pid=@Pid");
			SqlParameter[] parameters = {
					new SqlParameter("@Pid", SqlDbType.Int,4)
			};
			parameters[0].Value = Pid;

			WebDemo.Model.WebDemo.ParamsKinds model=new WebDemo.Model.WebDemo.ParamsKinds();
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
		public WebDemo.Model.WebDemo.ParamsKinds DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.ParamsKinds model=new WebDemo.Model.WebDemo.ParamsKinds();
			if (row != null)
			{
				if(row["Pid"]!=null && row["Pid"].ToString()!="")
				{
					model.Pid=int.Parse(row["Pid"].ToString());
				}
				if(row["ParamName"]!=null)
				{
					model.ParamName=row["ParamName"].ToString();
				}
				if(row["PTypeNum"]!=null)
				{
					model.PTypeNum=row["PTypeNum"].ToString();
				}
				if(row["PDisplayValue"]!=null)
				{
					model.PDisplayValue=row["PDisplayValue"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["Flag"]!=null && row["Flag"].ToString()!="")
				{
					model.Flag=int.Parse(row["Flag"].ToString());
				}
				if(row["PTypeValue"]!=null)
				{
					model.PTypeValue=row["PTypeValue"].ToString();
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
			strSql.Append("select Pid,ParamName,PTypeNum,PDisplayValue,Remark,Flag,PTypeValue ");
			strSql.Append(" FROM ParamsKinds ");
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
			strSql.Append(" Pid,ParamName,PTypeNum,PDisplayValue,Remark,Flag,PTypeValue ");
			strSql.Append(" FROM ParamsKinds ");
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
			strSql.Append("select count(1) FROM ParamsKinds ");
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
				strSql.Append("order by T.Pid desc");
			}
			strSql.Append(")AS Row, T.*  from ParamsKinds T ");
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
			parameters[0].Value = "ParamsKinds";
			parameters[1].Value = "Pid";
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

