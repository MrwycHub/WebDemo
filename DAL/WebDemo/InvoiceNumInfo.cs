using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:InvoiceNumInfo
	/// </summary>
	public partial class InvoiceNumInfo
	{
		public InvoiceNumInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "InvoiceNumInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from InvoiceNumInfo");
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
		public int Add(WebDemo.Model.WebDemo.InvoiceNumInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InvoiceNumInfo(");
			strSql.Append("DisId,BatchId,InCode,InvoiceNum,OrderNum,Mark,SubFlag,OperatorID,AssignOperator,AssignDate,OperDate,Remark)");
			strSql.Append(" values (");
			strSql.Append("@DisId,@BatchId,@InCode,@InvoiceNum,@OrderNum,@Mark,@SubFlag,@OperatorID,@AssignOperator,@AssignDate,@OperDate,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DisId", SqlDbType.Int,4),
					new SqlParameter("@BatchId", SqlDbType.Int,4),
					new SqlParameter("@InCode", SqlDbType.VarChar,50),
					new SqlParameter("@InvoiceNum", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNum", SqlDbType.VarChar,50),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@SubFlag", SqlDbType.Int,4),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@AssignOperator", SqlDbType.VarChar,50),
					new SqlParameter("@AssignDate", SqlDbType.DateTime),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
			parameters[0].Value = model.DisId;
			parameters[1].Value = model.BatchId;
			parameters[2].Value = model.InCode;
			parameters[3].Value = model.InvoiceNum;
			parameters[4].Value = model.OrderNum;
			parameters[5].Value = model.Mark;
			parameters[6].Value = model.SubFlag;
			parameters[7].Value = model.OperatorID;
			parameters[8].Value = model.AssignOperator;
			parameters[9].Value = model.AssignDate;
			parameters[10].Value = model.OperDate;
			parameters[11].Value = model.Remark;

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
		public bool Update(WebDemo.Model.WebDemo.InvoiceNumInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InvoiceNumInfo set ");
			strSql.Append("DisId=@DisId,");
			strSql.Append("BatchId=@BatchId,");
			strSql.Append("InCode=@InCode,");
			strSql.Append("InvoiceNum=@InvoiceNum,");
			strSql.Append("OrderNum=@OrderNum,");
			strSql.Append("Mark=@Mark,");
			strSql.Append("SubFlag=@SubFlag,");
			strSql.Append("OperatorID=@OperatorID,");
			strSql.Append("AssignOperator=@AssignOperator,");
			strSql.Append("AssignDate=@AssignDate,");
			strSql.Append("OperDate=@OperDate,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@DisId", SqlDbType.Int,4),
					new SqlParameter("@BatchId", SqlDbType.Int,4),
					new SqlParameter("@InCode", SqlDbType.VarChar,50),
					new SqlParameter("@InvoiceNum", SqlDbType.VarChar,50),
					new SqlParameter("@OrderNum", SqlDbType.VarChar,50),
					new SqlParameter("@Mark", SqlDbType.Int,4),
					new SqlParameter("@SubFlag", SqlDbType.Int,4),
					new SqlParameter("@OperatorID", SqlDbType.Int,4),
					new SqlParameter("@AssignOperator", SqlDbType.VarChar,50),
					new SqlParameter("@AssignDate", SqlDbType.DateTime),
					new SqlParameter("@OperDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.DisId;
			parameters[1].Value = model.BatchId;
			parameters[2].Value = model.InCode;
			parameters[3].Value = model.InvoiceNum;
			parameters[4].Value = model.OrderNum;
			parameters[5].Value = model.Mark;
			parameters[6].Value = model.SubFlag;
			parameters[7].Value = model.OperatorID;
			parameters[8].Value = model.AssignOperator;
			parameters[9].Value = model.AssignDate;
			parameters[10].Value = model.OperDate;
			parameters[11].Value = model.Remark;
			parameters[12].Value = model.ID;

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
			strSql.Append("delete from InvoiceNumInfo ");
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
			strSql.Append("delete from InvoiceNumInfo ");
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
		public WebDemo.Model.WebDemo.InvoiceNumInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,DisId,BatchId,InCode,InvoiceNum,OrderNum,Mark,SubFlag,OperatorID,AssignOperator,AssignDate,OperDate,Remark from InvoiceNumInfo ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.InvoiceNumInfo model=new WebDemo.Model.WebDemo.InvoiceNumInfo();
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
		public WebDemo.Model.WebDemo.InvoiceNumInfo DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.InvoiceNumInfo model=new WebDemo.Model.WebDemo.InvoiceNumInfo();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["DisId"]!=null && row["DisId"].ToString()!="")
				{
					model.DisId=int.Parse(row["DisId"].ToString());
				}
				if(row["BatchId"]!=null && row["BatchId"].ToString()!="")
				{
					model.BatchId=int.Parse(row["BatchId"].ToString());
				}
				if(row["InCode"]!=null)
				{
					model.InCode=row["InCode"].ToString();
				}
				if(row["InvoiceNum"]!=null)
				{
					model.InvoiceNum=row["InvoiceNum"].ToString();
				}
				if(row["OrderNum"]!=null)
				{
					model.OrderNum=row["OrderNum"].ToString();
				}
				if(row["Mark"]!=null && row["Mark"].ToString()!="")
				{
					model.Mark=int.Parse(row["Mark"].ToString());
				}
				if(row["SubFlag"]!=null && row["SubFlag"].ToString()!="")
				{
					model.SubFlag=int.Parse(row["SubFlag"].ToString());
				}
				if(row["OperatorID"]!=null && row["OperatorID"].ToString()!="")
				{
					model.OperatorID=int.Parse(row["OperatorID"].ToString());
				}
				if(row["AssignOperator"]!=null)
				{
					model.AssignOperator=row["AssignOperator"].ToString();
				}
				if(row["AssignDate"]!=null && row["AssignDate"].ToString()!="")
				{
					model.AssignDate=DateTime.Parse(row["AssignDate"].ToString());
				}
				if(row["OperDate"]!=null && row["OperDate"].ToString()!="")
				{
					model.OperDate=DateTime.Parse(row["OperDate"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select ID,DisId,BatchId,InCode,InvoiceNum,OrderNum,Mark,SubFlag,OperatorID,AssignOperator,AssignDate,OperDate,Remark ");
			strSql.Append(" FROM InvoiceNumInfo ");
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
			strSql.Append(" ID,DisId,BatchId,InCode,InvoiceNum,OrderNum,Mark,SubFlag,OperatorID,AssignOperator,AssignDate,OperDate,Remark ");
			strSql.Append(" FROM InvoiceNumInfo ");
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
			strSql.Append("select count(1) FROM InvoiceNumInfo ");
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
			strSql.Append(")AS Row, T.*  from InvoiceNumInfo T ");
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
			parameters[0].Value = "InvoiceNumInfo";
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

