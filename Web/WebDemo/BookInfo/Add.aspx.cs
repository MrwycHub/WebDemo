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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
