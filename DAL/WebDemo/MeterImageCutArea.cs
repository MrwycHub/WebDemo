using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MeterImageCutArea
	/// </summary>
	public partial class MeterImageCutArea
	{
		public MeterImageCutArea()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeterId", "MeterImageCutArea"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeterId,int CameraNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MeterImageCutArea");
			strSql.Append(" where MeterId=@MeterId and CameraNo=@CameraNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterId", SqlDbType.Int,4),
					new SqlParameter("@CameraNo", SqlDbType.Int,4)			};
			parameters[0].Value = MeterId;
			parameters[1].Value = CameraNo;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(WebDemo.Model.WebDemo.MeterImageCutArea model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MeterImageCutArea(");
			strSql.Append("MeterId,CameraNo,CutLocationX,CutLocationY,CutWidth,CutHeight,LastOperDate)");
			strSql.Append(" values (");
			strSql.Append("@MeterId,@CameraNo,@CutLocationX,@CutLocationY,@CutWidth,@CutHeight,@LastOperDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterId", SqlDbType.Int,4),
					new SqlParameter("@CameraNo", SqlDbType.Int,4),
					new SqlParameter("@CutLocationX", SqlDbType.Int,4),
					new SqlParameter("@CutLocationY", SqlDbType.Int,4),
					new SqlParameter("@CutWidth", SqlDbType.Int,4),
					new SqlParameter("@CutHeight", SqlDbType.Int,4),
					new SqlParameter("@LastOperDate", SqlDbType.DateTime)};
			parameters[0].Value = model.MeterId;
			parameters[1].Value = model.CameraNo;
			parameters[2].Value = model.CutLocationX;
			parameters[3].Value = model.CutLocationY;
			parameters[4].Value = model.CutWidth;
			parameters[5].Value = model.CutHeight;
			parameters[6].Value = model.LastOperDate;

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
		public bool Update(WebDemo.Model.WebDemo.MeterImageCutArea model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MeterImageCutArea set ");
			strSql.Append("CutLocationX=@CutLocationX,");
			strSql.Append("CutLocationY=@CutLocationY,");
			strSql.Append("CutWidth=@CutWidth,");
			strSql.Append("CutHeight=@CutHeight,");
			strSql.Append("LastOperDate=@LastOperDate");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@CutLocationX", SqlDbType.Int,4),
					new SqlParameter("@CutLocationY", SqlDbType.Int,4),
					new SqlParameter("@CutWidth", SqlDbType.Int,4),
					new SqlParameter("@CutHeight", SqlDbType.Int,4),
					new SqlParameter("@LastOperDate", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@MeterId", SqlDbType.Int,4),
					new SqlParameter("@CameraNo", SqlDbType.Int,4)};
			parameters[0].Value = model.CutLocationX;
			parameters[1].Value = model.CutLocationY;
			parameters[2].Value = model.CutWidth;
			parameters[3].Value = model.CutHeight;
			parameters[4].Value = model.LastOperDate;
			parameters[5].Value = model.Id;
			parameters[6].Value = model.MeterId;
			parameters[7].Value = model.CameraNo;

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
			strSql.Append("delete from MeterImageCutArea ");
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
		public bool Delete(int MeterId,int CameraNo)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MeterImageCutArea ");
			strSql.Append(" where MeterId=@MeterId and CameraNo=@CameraNo ");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterId", SqlDbType.Int,4),
					new SqlParameter("@CameraNo", SqlDbType.Int,4)			};
			parameters[0].Value = MeterId;
			parameters[1].Value = CameraNo;

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
			strSql.Append("delete from MeterImageCutArea ");
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
		public WebDemo.Model.WebDemo.MeterImageCutArea GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,MeterId,CameraNo,CutLocationX,CutLocationY,CutWidth,CutHeight,LastOperDate from MeterImageCutArea ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			WebDemo.Model.WebDemo.MeterImageCutArea model=new WebDemo.Model.WebDemo.MeterImageCutArea();
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
		public WebDemo.Model.WebDemo.MeterImageCutArea DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MeterImageCutArea model=new WebDemo.Model.WebDemo.MeterImageCutArea();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["MeterId"]!=null && row["MeterId"].ToString()!="")
				{
					model.MeterId=int.Parse(row["MeterId"].ToString());
				}
				if(row["CameraNo"]!=null && row["CameraNo"].ToString()!="")
				{
					model.CameraNo=int.Parse(row["CameraNo"].ToString());
				}
				if(row["CutLocationX"]!=null && row["CutLocationX"].ToString()!="")
				{
					model.CutLocationX=int.Parse(row["CutLocationX"].ToString());
				}
				if(row["CutLocationY"]!=null && row["CutLocationY"].ToString()!="")
				{
					model.CutLocationY=int.Parse(row["CutLocationY"].ToString());
				}
				if(row["CutWidth"]!=null && row["CutWidth"].ToString()!="")
				{
					model.CutWidth=int.Parse(row["CutWidth"].ToString());
				}
				if(row["CutHeight"]!=null && row["CutHeight"].ToString()!="")
				{
					model.CutHeight=int.Parse(row["CutHeight"].ToString());
				}
				if(row["LastOperDate"]!=null && row["LastOperDate"].ToString()!="")
				{
					model.LastOperDate=DateTime.Parse(row["LastOperDate"].ToString());
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
			strSql.Append("select Id,MeterId,CameraNo,CutLocationX,CutLocationY,CutWidth,CutHeight,LastOperDate ");
			strSql.Append(" FROM MeterImageCutArea ");
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
			strSql.Append(" Id,MeterId,CameraNo,CutLocationX,CutLocationY,CutWidth,CutHeight,LastOperDate ");
			strSql.Append(" FROM MeterImageCutArea ");
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
			strSql.Append("select count(1) FROM MeterImageCutArea ");
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
			strSql.Append(")AS Row, T.*  from MeterImageCutArea T ");
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
			parameters[0].Value = "MeterImageCutArea";
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

