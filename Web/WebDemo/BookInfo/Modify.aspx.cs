using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace WebDemo.Web.WebDemo.BookInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int BookID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(BookID);
				}
			}
		}
			
	private void ShowInfo(int BookID)
	{
		WebDemo.BLL.WebDemo.BookInfo bll=new WebDemo.BLL.WebDemo.BookInfo();
		WebDemo.Model.WebDemo.BookInfo model=bll.GetModel(BookID);
		this.lblBookID.Text=model.BookID.ToString();
		this.txtDeptIDs.Text=model.DeptIDs;
		this.txtBookName.Text=model.BookName;
		this.txtWorkerID.Text=model.WorkerID.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtBookCode.Text=model.BookCode;
		this.txtRoutes.Text=model.Routes;
		this.txtReadDay.Text=model.ReadDay.ToString();
		this.txtReadType.Text=model.ReadType.ToString();
		this.txtUserNum.Text=model.UserNum.ToString();
		this.txtUpdateTime.Text=model.UpdateTime.ToString();
		this.txtAutoReadBeginDate.Text=model.AutoReadBeginDate;
		this.txtAutoReadEndDate.Text=model.AutoReadEndDate;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDeptIDs.Text.Trim().Length==0)
			{
				strErr+="DeptIDs不能为空！\\n";	
			}
			if(this.txtBookName.Text.Trim().Length==0)
			{
				strErr+="BookName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtWorkerID.Text))
			{
				strErr+="WorkerID格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(this.txtBookCode.Text.Trim().Length==0)
			{
				strErr+="BookCode不能为空！\\n";	
			}
			if(this.txtRoutes.Text.Trim().Length==0)
			{
				strErr+="Routes不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtReadDay.Text))
			{
				strErr+="ReadDay格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtReadType.Text))
			{
				strErr+="ReadType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserNum.Text))
			{
				strErr+="UserNum格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="UpdateTime格式错误！\\n";	
			}
			if(this.txtAutoReadBeginDate.Text.Trim().Length==0)
			{
				strErr+="AutoReadBeginDate不能为空！\\n";	
			}
			if(this.txtAutoReadEndDate.Text.Trim().Length==0)
			{
				strErr+="AutoReadEndDate不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int BookID=int.Parse(this.lblBookID.Text);
			string DeptIDs=this.txtDeptIDs.Text;
			string BookName=this.txtBookName.Text;
			int WorkerID=int.Parse(this.txtWorkerID.Text);
			string Remark=this.txtRemark.Text;
			string BookCode=this.txtBookCode.Text;
			string Routes=this.txtRoutes.Text;
			int ReadDay=int.Parse(this.txtReadDay.Text);
			int ReadType=int.Parse(this.txtReadType.Text);
			int UserNum=int.Parse(this.txtUserNum.Text);
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			string AutoReadBeginDate=this.txtAutoReadBeginDate.Text;
			string AutoReadEndDate=this.txtAutoReadEndDate.Text;


			WebDemo.Model.WebDemo.BookInfo model=new WebDemo.Model.WebDemo.BookInfo();
			model.BookID=BookID;
			model.DeptIDs=DeptIDs;
			model.BookName=BookName;
			model.WorkerID=WorkerID;
			model.Remark=Remark;
			model.BookCode=BookCode;
			model.Routes=Routes;
			model.ReadDay=ReadDay;
			model.ReadType=ReadType;
			model.UserNum=UserNum;
			model.UpdateTime=UpdateTime;
			model.AutoReadBeginDate=AutoReadBeginDate;
			model.AutoReadEndDate=AutoReadEndDate;

			WebDemo.BLL.WebDemo.BookInfo bll=new WebDemo.BLL.WebDemo.BookInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
