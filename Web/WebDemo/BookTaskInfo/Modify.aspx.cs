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
namespace WebDemo.Web.WebDemo.BookTaskInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.BookTaskInfo bll=new WebDemo.BLL.WebDemo.BookTaskInfo();
		WebDemo.Model.WebDemo.BookTaskInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtBookID.Text=model.BookID.ToString();
		this.txtReadDate.Text=model.ReadDate;
		this.txtBookCode.Text=model.BookCode;
		this.txtBookName.Text=model.BookName;
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtRoutes.Text=model.Routes;
		this.txtUserNum.Text=model.UserNum.ToString();
		this.txtFactNum.Text=model.FactNum.ToString();
		this.txtUpdateTime.Text=model.UpdateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtBookID.Text))
			{
				strErr+="BookID格式错误！\\n";	
			}
			if(this.txtReadDate.Text.Trim().Length==0)
			{
				strErr+="ReadDate不能为空！\\n";	
			}
			if(this.txtBookCode.Text.Trim().Length==0)
			{
				strErr+="BookCode不能为空！\\n";	
			}
			if(this.txtBookName.Text.Trim().Length==0)
			{
				strErr+="BookName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(this.txtRoutes.Text.Trim().Length==0)
			{
				strErr+="Routes不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserNum.Text))
			{
				strErr+="UserNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFactNum.Text))
			{
				strErr+="FactNum格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="UpdateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int BookID=int.Parse(this.txtBookID.Text);
			string ReadDate=this.txtReadDate.Text;
			string BookCode=this.txtBookCode.Text;
			string BookName=this.txtBookName.Text;
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			string Remark=this.txtRemark.Text;
			string Routes=this.txtRoutes.Text;
			int UserNum=int.Parse(this.txtUserNum.Text);
			int FactNum=int.Parse(this.txtFactNum.Text);
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);


			WebDemo.Model.WebDemo.BookTaskInfo model=new WebDemo.Model.WebDemo.BookTaskInfo();
			model.ID=ID;
			model.BookID=BookID;
			model.ReadDate=ReadDate;
			model.BookCode=BookCode;
			model.BookName=BookName;
			model.OperatorID=OperatorID;
			model.Remark=Remark;
			model.Routes=Routes;
			model.UserNum=UserNum;
			model.FactNum=FactNum;
			model.UpdateTime=UpdateTime;

			WebDemo.BLL.WebDemo.BookTaskInfo bll=new WebDemo.BLL.WebDemo.BookTaskInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
