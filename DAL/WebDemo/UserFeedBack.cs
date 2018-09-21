using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace WebDemo.DAL.WebDemo
{
	/// <summary>
	/// 数据访问类:UserFeedBack
	/// </summary>
	public partial class UserFeedBack
	{
		public UserFeedBack()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "UserFeedBack"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserFeedBack");
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
		public int Add(WebDemo.Model.WebDemo.UserFeedBack model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserFeedBack(");
			strSql.Append("UserCode,ContactWay,Phone,Content,PublishDate,ReplyMan,ReplyContent,ReplyDate,Flag,TypeId,Contact,ReplyFlag)");
			strSql.Append(" values (");
			strSql.Append("@UserCode,@ContactWay,@Phone,@Content,@PublishDate,@ReplyMan,@ReplyContent,@ReplyDate,@Flag,@TypeId,@Contact,@ReplyFlag)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,50),
					new SqlParameter("@ContactWay", SqlDbType.VarChar,100),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Content", SqlDbType.VarChar,500),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@ReplyMan", SqlDbType.VarChar,100),
					new SqlParameter("@ReplyContent", SqlDbType.VarChar,50),
					new SqlParameter("@ReplyDate", SqlDbType.DateTime),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@TypeId", SqlDbType.Int,4),
					new SqlParameter("@Contact", SqlDbType.VarChar,50),
					new SqlParameter("@ReplyFlag", SqlDbType.Int,4)};
			parameters[0].Value = model.UserCode;
			parameters[1].Value = model.ContactWay;
			parameters[2].Value = model.Phone;
			parameters[3].Value = model.Content;
			parameters[4].Value = model.PublishDate;
			parameters[5].Value = model.ReplyMan;
			parameters[6].Value = model.ReplyContent;
			parameters[7].Value = model.ReplyDate;
			parameters[8].Value = model.Flag;
			parameters[9].Value = model.TypeId;
			parameters[10].Value = model.Contact;
			parameters[11].Value = model.ReplyFlag;

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
		public bool Update(WebDemo.Model.WebDemo.UserFeedBack model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserFeedBack set ");
			strSql.Append("UserCode=@UserCode,");
			strSql.Append("ContactWay=@ContactWay,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Content=@Content,");
			strSql.Append("PublishDate=@PublishDate,");
			strSql.Append("ReplyMan=@ReplyMan,");
			strSql.Append("ReplyContent=@ReplyContent,");
			strSql.Append("ReplyDate=@ReplyDate,");
			strSql.Append("Flag=@Flag,");
			strSql.Append("TypeId=@TypeId,");
			strSql.Append("Contact=@Contact,");
			strSql.Append("ReplyFlag=@ReplyFlag");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserCode", SqlDbType.VarChar,50),
					new SqlParameter("@ContactWay", SqlDbType.VarChar,100),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@Content", SqlDbType.VarChar,500),
					new SqlParameter("@PublishDate", SqlDbType.DateTime),
					new SqlParameter("@ReplyMan", SqlDbType.VarChar,100),
					new SqlParameter("@ReplyContent", SqlDbType.VarChar,50),
					new SqlParameter("@ReplyDate", SqlDbType.DateTime),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@TypeId", SqlDbType.Int,4),
					new SqlParameter("@Contact", SqlDbType.VarChar,50),
					new SqlParameter("@ReplyFlag", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserCode;
			parameters[1].Value = model.ContactWay;
			parameters[2].Value = model.Phone;
			parameters[3].Value = model.Content;
			parameters[4].Value = model.PublishDate;
			parameters[5].Value = model.ReplyMan;
			parameters[6].Value = model.ReplyContent;
			parameters[7].Value = model.ReplyDate;
			parameters[8].Value = model.Flag;
			parameters[9].Value = model.TypeId;
			parameters[10].Value = model.Contact;
			parameters[11].Value = model.ReplyFlag;
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
			strSql.Append("delete from UserFeedBack ");
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
			strSql.Append("delete from UserFeedBack ");
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
		public WebDemo.Model.WebDemo.UserFeedBack GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,UserCode,ContactWay,Phone,Content,PublishDate,ReplyMan,ReplyContent,ReplyDate,Flag,TypeId,Contact,ReplyFlag from UserFeedBack ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			WebDemo.Model.WebDemo.UserFeedBack model=new WebDemo.Model.WebDemo.UserFeedBack();
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
		public WebDemo.Model.WebDemo.UserFeedBack DataRowToModel(DataRow row)
		{
			WebDemo.Model.WebDemo.UserFeedBack model=new WebDemo.Model.WebDemo.UserFeedBack();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["UserCode"]!=null)
				{
					model.UserCode=row["UserCode"].ToString();
				}
				if(row["ContactWay"]!=null)
				{
					model.ContactWay=row["ContactWay"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Content"]!=null)
				{
					model.Content=row["Content"].ToString();
				}
				if(row["PublishDate"]!=null && row["PublishDate"].ToString()!="")
				{
					model.PublishDate=DateTime.Parse(row["PublishDate"].ToString());
				}
				if(row["ReplyMan"]!=null)
				{
					model.ReplyMan=row["ReplyMan"].ToString();
				}
				if(row["ReplyContent"]!=null)
				{
					model.ReplyContent=row["ReplyContent"].ToString();
				}
				if(row["ReplyDate"]!=null && row["ReplyDate"].ToString()!="")
				{
					model.ReplyDate=DateTime.Parse(row["ReplyDate"].ToString());
				}
				if(row["Flag"]!=null && row["Flag"].ToString()!="")
				{
					model.Flag=int.Parse(row["Flag"].ToString());
				}
				if(row["TypeId"]!=null && row["TypeId"].ToString()!="")
				{
					model.TypeId=int.Parse(row["TypeId"].ToString());
				}
				if(row["Contact"]!=null)
				{
					model.Contact=row["Contact"].ToString();
				}
				if(row["ReplyFlag"]!=null && row["ReplyFlag"].ToString()!="")
				{
					model.ReplyFlag=int.Parse(row["ReplyFlag"].ToString());
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
			strSql.Append("select ID,UserCode,ContactWay,Phone,Content,PublishDate,ReplyMan,ReplyContent,ReplyDate,Flag,TypeId,Contact,ReplyFlag ");
			strSql.Append(" FROM UserFeedBack ");
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
			strSql.Append(" ID,UserCode,ContactWay,Phone,Content,PublishDate,ReplyMan,ReplyContent,ReplyDate,Flag,TypeId,Contact,ReplyFlag ");
			strSql.Append(" FROM UserFeedBack ");
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
			strSql.Append("select count(1) FROM UserFeedBack ");
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
			strSql.Append(")AS Row, T.*  from UserFeedBack T ");
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
			parameters[0].Value = "UserFeedBack";
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

