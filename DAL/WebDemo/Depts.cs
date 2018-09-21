using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:Depts
	/// </summary>
	public partial class Depts
	{
		public Depts()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string DeptID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Depts");
			strSql.Append(" where DeptID=@DeptID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptID", SqlDbType.VarChar,50)			};
			parameters[0].Value = DeptID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(WebDemo.Model.WebDemo.Depts model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Depts(");
			strSql.Append("DeptID,DeptName,UpperDept,Address,imgIndex,SelectimgIndex,Remark,CustomCode,DeptType,LocationX,LocationY,UpdateTime,OrderNum)");
			strSql.Append(" values (");
			strSql.Append("@DeptID,@DeptName,@UpperDept,@Address,@imgIndex,@SelectimgIndex,@Remark,@CustomCode,@DeptType,@LocationX,@LocationY,@UpdateTime,@OrderNum)");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptID", SqlDbType.VarChar,50),
					new SqlParameter("@DeptName", SqlDbType.VarChar,50),
					new SqlParameter("@UpperDept", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,100),
					new SqlParameter("@imgIndex", SqlDbType.Int,4),
					new SqlParameter("@SelectimgIndex", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@CustomCode", SqlDbType.VarChar,50),
					new SqlParameter("@DeptType", SqlDbType.Int,4),
					new SqlParameter("@LocationX", SqlDbType.Decimal,9),
					new SqlParameter("@LocationY", SqlDbType.Decimal,9),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@OrderNum", SqlDbType.Int,4)};
			parameters[0].Value = model.DeptID;
			parameters[1].Value = model.DeptName;
			parameters[2].Value = model.UpperDept;
			parameters[3].Value = model.Address;
			parameters[4].Value = model.imgIndex;
			parameters[5].Value = model.SelectimgIndex;
			parameters[6].Value = model.Remark;
			parameters[7].Value = model.CustomCode;
			parameters[8].Value = model.DeptType;
			parameters[9].Value = model.LocationX;
			parameters[10].Value = model.LocationY;
			parameters[11].Value = model.UpdateTime;
			parameters[12].Value = model.OrderNum;

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
		public bool Update(WebDemo.Model.WebDemo.Depts model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Depts set ");
			strSql.Append("DeptName=@DeptName,");
			strSql.Append("UpperDept=@UpperDept,");
			strSql.Append("Address=@Address,");
			strSql.Append("imgIndex=@imgIndex,");
			strSql.Append("SelectimgIndex=@SelectimgIndex,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("CustomCode=@CustomCode,");
			strSql.Append("DeptType=@DeptType,");
			strSql.Append("LocationX=@LocationX,");
			strSql.Append("LocationY=@LocationY,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("OrderNum=@OrderNum");
			strSql.Append(" where DeptID=@DeptID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptName", SqlDbType.VarChar,50),
					new SqlParameter("@UpperDept", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,100),
					new SqlParameter("@imgIndex", SqlDbType.Int,4),
					new SqlParameter("@SelectimgIndex", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@CustomCode", SqlDbType.VarChar,50),
					new SqlParameter("@DeptType", SqlDbType.Int,4),
					new SqlParameter("@LocationX", SqlDbType.Decimal,9),
					new SqlParameter("@LocationY", SqlDbType.Decimal,9),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@OrderNum", SqlDbType.Int,4),
					new SqlParameter("@DeptID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.DeptName;
			parameters[1].Value = model.UpperDept;
			parameters[2].Value = model.Address;
			parameters[3].Value = model.imgIndex;
			parameters[4].Value = model.SelectimgIndex;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.CustomCode;
			parameters[7].Value = model.DeptType;
			parameters[8].Value = model.LocationX;
			parameters[9].Value = model.LocationY;
			parameters[10].Value = model.UpdateTime;
			parameters[11].Value = model.OrderNum;
			parameters[12].Value = model.DeptID;

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
		public bool Delete(string DeptID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Depts ");
			strSql.Append(" where DeptID=@DeptID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptID", SqlDbType.VarChar,50)			};
			parameters[0].Value = DeptID;

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
		public bool DeleteList(string DeptIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Depts ");
			strSql.Append(" where DeptID in ("+DeptIDlist + ")  ");
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
		public WebDemo.Model.WebDemo.Depts GetModel(string DeptID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DeptID,DeptName,UpperDept,Address,imgIndex,SelectimgIndex,Remark,CustomCode,DeptType,LocationX,LocationY,UpdateTime,OrderNum from Depts ");
			strSql.Append(" where DeptID=@DeptID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DeptID", SqlDbType.VarChar,50)			};
			parameters[0].Value = DeptID;

			WebDemo.Model.WebDemo.Depts model=new WebDemo.Model.WebDemo.Depts();
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
		public WebDemo.Model.WebDemo.Depts DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.Depts model=new WebDemo.Model.WebDemo.Depts();
			if (row != null)
			{
				if(row["DeptID"]!=null)
				{
					model.DeptID=row["DeptID"].ToString();
				}
				if(row["DeptName"]!=null)
				{
					model.DeptName=row["DeptName"].ToString();
				}
				if(row["UpperDept"]!=null)
				{
					model.UpperDept=row["UpperDept"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["imgIndex"]!=null && row["imgIndex"].ToString()!="")
				{
					model.imgIndex=int.Parse(row["imgIndex"].ToString());
				}
				if(row["SelectimgIndex"]!=null && row["SelectimgIndex"].ToString()!="")
				{
					model.SelectimgIndex=int.Parse(row["SelectimgIndex"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["CustomCode"]!=null)
				{
					model.CustomCode=row["CustomCode"].ToString();
				}
				if(row["DeptType"]!=null && row["DeptType"].ToString()!="")
				{
					model.DeptType=int.Parse(row["DeptType"].ToString());
				}
				if(row["LocationX"]!=null && row["LocationX"].ToString()!="")
				{
					model.LocationX=decimal.Parse(row["LocationX"].ToString());
				}
				if(row["LocationY"]!=null && row["LocationY"].ToString()!="")
				{
					model.LocationY=decimal.Parse(row["LocationY"].ToString());
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
				}
				if(row["OrderNum"]!=null && row["OrderNum"].ToString()!="")
				{
					model.OrderNum=int.Parse(row["OrderNum"].ToString());
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
			strSql.Append("select DeptID,DeptName,UpperDept,Address,imgIndex,SelectimgIndex,Remark,CustomCode,DeptType,LocationX,LocationY,UpdateTime,OrderNum ");
			strSql.Append(" FROM Depts ");
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
			strSql.Append(" DeptID,DeptName,UpperDept,Address,imgIndex,SelectimgIndex,Remark,CustomCode,DeptType,LocationX,LocationY,UpdateTime,OrderNum ");
			strSql.Append(" FROM Depts ");
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
			strSql.Append("select count(1) FROM Depts ");
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
				strSql.Append("order by T.DeptID desc");
			}
			strSql.Append(")AS Row, T.*  from Depts T ");
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
			parameters[0].Value = "Depts";
			parameters[1].Value = "DeptID";
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

