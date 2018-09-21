using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:MeterImageParam
	/// </summary>
	public partial class MeterImageParam
	{
		public MeterImageParam()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MeterId", "MeterImageParam"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MeterId,int CameraNo)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MeterImageParam");
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
		public int Add(WebDemo.Model.WebDemo.MeterImageParam model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MeterImageParam(");
			strSql.Append("MeterId,CameraNo,NumberCount,CaptureStartPixs,UpClipPixs,DownClipPixs,LeftClipPixs,RightClipPixs,CircumgyrateDegree,InclineDegree,ModelHeight,ModelWidth,ModelOneWidth,NumberSpace,BitValueLimen,BitValueRadius,BitValueBlackProportion,MorphologicFilterParam,SearchlimitParam,WindowHeight,LastOperDate)");
			strSql.Append(" values (");
			strSql.Append("@MeterId,@CameraNo,@NumberCount,@CaptureStartPixs,@UpClipPixs,@DownClipPixs,@LeftClipPixs,@RightClipPixs,@CircumgyrateDegree,@InclineDegree,@ModelHeight,@ModelWidth,@ModelOneWidth,@NumberSpace,@BitValueLimen,@BitValueRadius,@BitValueBlackProportion,@MorphologicFilterParam,@SearchlimitParam,@WindowHeight,@LastOperDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MeterId", SqlDbType.Int,4),
					new SqlParameter("@CameraNo", SqlDbType.Int,4),
					new SqlParameter("@NumberCount", SqlDbType.Int,4),
					new SqlParameter("@CaptureStartPixs", SqlDbType.Int,4),
					new SqlParameter("@UpClipPixs", SqlDbType.Int,4),
					new SqlParameter("@DownClipPixs", SqlDbType.Int,4),
					new SqlParameter("@LeftClipPixs", SqlDbType.Int,4),
					new SqlParameter("@RightClipPixs", SqlDbType.Int,4),
					new SqlParameter("@CircumgyrateDegree", SqlDbType.Int,4),
					new SqlParameter("@InclineDegree", SqlDbType.Int,4),
					new SqlParameter("@ModelHeight", SqlDbType.Int,4),
					new SqlParameter("@ModelWidth", SqlDbType.Int,4),
					new SqlParameter("@ModelOneWidth", SqlDbType.Int,4),
					new SqlParameter("@NumberSpace", SqlDbType.Int,4),
					new SqlParameter("@BitValueLimen", SqlDbType.Int,4),
					new SqlParameter("@BitValueRadius", SqlDbType.Int,4),
					new SqlParameter("@BitValueBlackProportion", SqlDbType.Int,4),
					new SqlParameter("@MorphologicFilterParam", SqlDbType.Int,4),
					new SqlParameter("@SearchlimitParam", SqlDbType.Int,4),
					new SqlParameter("@WindowHeight", SqlDbType.Int,4),
					new SqlParameter("@LastOperDate", SqlDbType.DateTime)};
			parameters[0].Value = model.MeterId;
			parameters[1].Value = model.CameraNo;
			parameters[2].Value = model.NumberCount;
			parameters[3].Value = model.CaptureStartPixs;
			parameters[4].Value = model.UpClipPixs;
			parameters[5].Value = model.DownClipPixs;
			parameters[6].Value = model.LeftClipPixs;
			parameters[7].Value = model.RightClipPixs;
			parameters[8].Value = model.CircumgyrateDegree;
			parameters[9].Value = model.InclineDegree;
			parameters[10].Value = model.ModelHeight;
			parameters[11].Value = model.ModelWidth;
			parameters[12].Value = model.ModelOneWidth;
			parameters[13].Value = model.NumberSpace;
			parameters[14].Value = model.BitValueLimen;
			parameters[15].Value = model.BitValueRadius;
			parameters[16].Value = model.BitValueBlackProportion;
			parameters[17].Value = model.MorphologicFilterParam;
			parameters[18].Value = model.SearchlimitParam;
			parameters[19].Value = model.WindowHeight;
			parameters[20].Value = model.LastOperDate;

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
		public bool Update(WebDemo.Model.WebDemo.MeterImageParam model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MeterImageParam set ");
			strSql.Append("NumberCount=@NumberCount,");
			strSql.Append("CaptureStartPixs=@CaptureStartPixs,");
			strSql.Append("UpClipPixs=@UpClipPixs,");
			strSql.Append("DownClipPixs=@DownClipPixs,");
			strSql.Append("LeftClipPixs=@LeftClipPixs,");
			strSql.Append("RightClipPixs=@RightClipPixs,");
			strSql.Append("CircumgyrateDegree=@CircumgyrateDegree,");
			strSql.Append("InclineDegree=@InclineDegree,");
			strSql.Append("ModelHeight=@ModelHeight,");
			strSql.Append("ModelWidth=@ModelWidth,");
			strSql.Append("ModelOneWidth=@ModelOneWidth,");
			strSql.Append("NumberSpace=@NumberSpace,");
			strSql.Append("BitValueLimen=@BitValueLimen,");
			strSql.Append("BitValueRadius=@BitValueRadius,");
			strSql.Append("BitValueBlackProportion=@BitValueBlackProportion,");
			strSql.Append("MorphologicFilterParam=@MorphologicFilterParam,");
			strSql.Append("SearchlimitParam=@SearchlimitParam,");
			strSql.Append("WindowHeight=@WindowHeight,");
			strSql.Append("LastOperDate=@LastOperDate");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@NumberCount", SqlDbType.Int,4),
					new SqlParameter("@CaptureStartPixs", SqlDbType.Int,4),
					new SqlParameter("@UpClipPixs", SqlDbType.Int,4),
					new SqlParameter("@DownClipPixs", SqlDbType.Int,4),
					new SqlParameter("@LeftClipPixs", SqlDbType.Int,4),
					new SqlParameter("@RightClipPixs", SqlDbType.Int,4),
					new SqlParameter("@CircumgyrateDegree", SqlDbType.Int,4),
					new SqlParameter("@InclineDegree", SqlDbType.Int,4),
					new SqlParameter("@ModelHeight", SqlDbType.Int,4),
					new SqlParameter("@ModelWidth", SqlDbType.Int,4),
					new SqlParameter("@ModelOneWidth", SqlDbType.Int,4),
					new SqlParameter("@NumberSpace", SqlDbType.Int,4),
					new SqlParameter("@BitValueLimen", SqlDbType.Int,4),
					new SqlParameter("@BitValueRadius", SqlDbType.Int,4),
					new SqlParameter("@BitValueBlackProportion", SqlDbType.Int,4),
					new SqlParameter("@MorphologicFilterParam", SqlDbType.Int,4),
					new SqlParameter("@SearchlimitParam", SqlDbType.Int,4),
					new SqlParameter("@WindowHeight", SqlDbType.Int,4),
					new SqlParameter("@LastOperDate", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@MeterId", SqlDbType.Int,4),
					new SqlParameter("@CameraNo", SqlDbType.Int,4)};
			parameters[0].Value = model.NumberCount;
			parameters[1].Value = model.CaptureStartPixs;
			parameters[2].Value = model.UpClipPixs;
			parameters[3].Value = model.DownClipPixs;
			parameters[4].Value = model.LeftClipPixs;
			parameters[5].Value = model.RightClipPixs;
			parameters[6].Value = model.CircumgyrateDegree;
			parameters[7].Value = model.InclineDegree;
			parameters[8].Value = model.ModelHeight;
			parameters[9].Value = model.ModelWidth;
			parameters[10].Value = model.ModelOneWidth;
			parameters[11].Value = model.NumberSpace;
			parameters[12].Value = model.BitValueLimen;
			parameters[13].Value = model.BitValueRadius;
			parameters[14].Value = model.BitValueBlackProportion;
			parameters[15].Value = model.MorphologicFilterParam;
			parameters[16].Value = model.SearchlimitParam;
			parameters[17].Value = model.WindowHeight;
			parameters[18].Value = model.LastOperDate;
			parameters[19].Value = model.Id;
			parameters[20].Value = model.MeterId;
			parameters[21].Value = model.CameraNo;

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
			strSql.Append("delete from MeterImageParam ");
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
			strSql.Append("delete from MeterImageParam ");
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
			strSql.Append("delete from MeterImageParam ");
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
		public WebDemo.Model.WebDemo.MeterImageParam GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,MeterId,CameraNo,NumberCount,CaptureStartPixs,UpClipPixs,DownClipPixs,LeftClipPixs,RightClipPixs,CircumgyrateDegree,InclineDegree,ModelHeight,ModelWidth,ModelOneWidth,NumberSpace,BitValueLimen,BitValueRadius,BitValueBlackProportion,MorphologicFilterParam,SearchlimitParam,WindowHeight,LastOperDate from MeterImageParam ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			WebDemo.Model.WebDemo.MeterImageParam model=new WebDemo.Model.WebDemo.MeterImageParam();
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
		public WebDemo.Model.WebDemo.MeterImageParam DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.MeterImageParam model=new WebDemo.Model.WebDemo.MeterImageParam();
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
				if(row["NumberCount"]!=null && row["NumberCount"].ToString()!="")
				{
					model.NumberCount=int.Parse(row["NumberCount"].ToString());
				}
				if(row["CaptureStartPixs"]!=null && row["CaptureStartPixs"].ToString()!="")
				{
					model.CaptureStartPixs=int.Parse(row["CaptureStartPixs"].ToString());
				}
				if(row["UpClipPixs"]!=null && row["UpClipPixs"].ToString()!="")
				{
					model.UpClipPixs=int.Parse(row["UpClipPixs"].ToString());
				}
				if(row["DownClipPixs"]!=null && row["DownClipPixs"].ToString()!="")
				{
					model.DownClipPixs=int.Parse(row["DownClipPixs"].ToString());
				}
				if(row["LeftClipPixs"]!=null && row["LeftClipPixs"].ToString()!="")
				{
					model.LeftClipPixs=int.Parse(row["LeftClipPixs"].ToString());
				}
				if(row["RightClipPixs"]!=null && row["RightClipPixs"].ToString()!="")
				{
					model.RightClipPixs=int.Parse(row["RightClipPixs"].ToString());
				}
				if(row["CircumgyrateDegree"]!=null && row["CircumgyrateDegree"].ToString()!="")
				{
					model.CircumgyrateDegree=int.Parse(row["CircumgyrateDegree"].ToString());
				}
				if(row["InclineDegree"]!=null && row["InclineDegree"].ToString()!="")
				{
					model.InclineDegree=int.Parse(row["InclineDegree"].ToString());
				}
				if(row["ModelHeight"]!=null && row["ModelHeight"].ToString()!="")
				{
					model.ModelHeight=int.Parse(row["ModelHeight"].ToString());
				}
				if(row["ModelWidth"]!=null && row["ModelWidth"].ToString()!="")
				{
					model.ModelWidth=int.Parse(row["ModelWidth"].ToString());
				}
				if(row["ModelOneWidth"]!=null && row["ModelOneWidth"].ToString()!="")
				{
					model.ModelOneWidth=int.Parse(row["ModelOneWidth"].ToString());
				}
				if(row["NumberSpace"]!=null && row["NumberSpace"].ToString()!="")
				{
					model.NumberSpace=int.Parse(row["NumberSpace"].ToString());
				}
				if(row["BitValueLimen"]!=null && row["BitValueLimen"].ToString()!="")
				{
					model.BitValueLimen=int.Parse(row["BitValueLimen"].ToString());
				}
				if(row["BitValueRadius"]!=null && row["BitValueRadius"].ToString()!="")
				{
					model.BitValueRadius=int.Parse(row["BitValueRadius"].ToString());
				}
				if(row["BitValueBlackProportion"]!=null && row["BitValueBlackProportion"].ToString()!="")
				{
					model.BitValueBlackProportion=int.Parse(row["BitValueBlackProportion"].ToString());
				}
				if(row["MorphologicFilterParam"]!=null && row["MorphologicFilterParam"].ToString()!="")
				{
					model.MorphologicFilterParam=int.Parse(row["MorphologicFilterParam"].ToString());
				}
				if(row["SearchlimitParam"]!=null && row["SearchlimitParam"].ToString()!="")
				{
					model.SearchlimitParam=int.Parse(row["SearchlimitParam"].ToString());
				}
				if(row["WindowHeight"]!=null && row["WindowHeight"].ToString()!="")
				{
					model.WindowHeight=int.Parse(row["WindowHeight"].ToString());
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
			strSql.Append("select Id,MeterId,CameraNo,NumberCount,CaptureStartPixs,UpClipPixs,DownClipPixs,LeftClipPixs,RightClipPixs,CircumgyrateDegree,InclineDegree,ModelHeight,ModelWidth,ModelOneWidth,NumberSpace,BitValueLimen,BitValueRadius,BitValueBlackProportion,MorphologicFilterParam,SearchlimitParam,WindowHeight,LastOperDate ");
			strSql.Append(" FROM MeterImageParam ");
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
			strSql.Append(" Id,MeterId,CameraNo,NumberCount,CaptureStartPixs,UpClipPixs,DownClipPixs,LeftClipPixs,RightClipPixs,CircumgyrateDegree,InclineDegree,ModelHeight,ModelWidth,ModelOneWidth,NumberSpace,BitValueLimen,BitValueRadius,BitValueBlackProportion,MorphologicFilterParam,SearchlimitParam,WindowHeight,LastOperDate ");
			strSql.Append(" FROM MeterImageParam ");
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
			strSql.Append("select count(1) FROM MeterImageParam ");
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
			strSql.Append(")AS Row, T.*  from MeterImageParam T ");
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
			parameters[0].Value = "MeterImageParam";
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

