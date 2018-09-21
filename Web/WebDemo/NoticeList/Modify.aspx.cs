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
namespace WebDemo.Web.WebDemo.NoticeList
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
		WebDemo.BLL.WebDemo.NoticeList bll=new WebDemo.BLL.WebDemo.NoticeList();
		WebDemo.Model.WebDemo.NoticeList model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtNoticeTitle.Text=model.NoticeTitle;
		this.txtNoticeInfo.Text=model.NoticeInfo;
		this.txtNoticeDate.Text=model.NoticeDate.ToString();
		this.txtAuthor.Text=model.Author;
		this.txtShowType.Text=model.ShowType.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtNoticeTitle.Text.Trim().Length==0)
			{
				strErr+="NoticeTitle不能为空！\\n";	
			}
			if(this.txtNoticeInfo.Text.Trim().Length==0)
			{
				strErr+="NoticeInfo不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtNoticeDate.Text))
			{
				strErr+="NoticeDate格式错误！\\n";	
			}
			if(this.txtAuthor.Text.Trim().Length==0)
			{
				strErr+="Author不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtShowType.Text))
			{
				strErr+="ShowType格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string NoticeTitle=this.txtNoticeTitle.Text;
			string NoticeInfo=this.txtNoticeInfo.Text;
			DateTime NoticeDate=DateTime.Parse(this.txtNoticeDate.Text);
			string Author=this.txtAuthor.Text;
			int ShowType=int.Parse(this.txtShowType.Text);


			WebDemo.Model.WebDemo.NoticeList model=new WebDemo.Model.WebDemo.NoticeList();
			model.ID=ID;
			model.NoticeTitle=NoticeTitle;
			model.NoticeInfo=NoticeInfo;
			model.NoticeDate=NoticeDate;
			model.Author=Author;
			model.ShowType=ShowType;

			WebDemo.BLL.WebDemo.NoticeList bll=new WebDemo.BLL.WebDemo.NoticeList();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
