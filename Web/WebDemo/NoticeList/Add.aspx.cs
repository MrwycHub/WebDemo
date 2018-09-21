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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string NoticeTitle=this.txtNoticeTitle.Text;
			string NoticeInfo=this.txtNoticeInfo.Text;
			DateTime NoticeDate=DateTime.Parse(this.txtNoticeDate.Text);
			string Author=this.txtAuthor.Text;
			int ShowType=int.Parse(this.txtShowType.Text);

			WebDemo.Model.WebDemo.NoticeList model=new WebDemo.Model.WebDemo.NoticeList();
			model.NoticeTitle=NoticeTitle;
			model.NoticeInfo=NoticeInfo;
			model.NoticeDate=NoticeDate;
			model.Author=Author;
			model.ShowType=ShowType;

			WebDemo.BLL.WebDemo.NoticeList bll=new WebDemo.BLL.WebDemo.NoticeList();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
