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
namespace WebDemo.Web.WebDemo.UserFeedBack
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
		WebDemo.BLL.WebDemo.UserFeedBack bll=new WebDemo.BLL.WebDemo.UserFeedBack();
		WebDemo.Model.WebDemo.UserFeedBack model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtUserCode.Text=model.UserCode;
		this.txtContactWay.Text=model.ContactWay;
		this.txtPhone.Text=model.Phone;
		this.txtContent.Text=model.Content;
		this.txtPublishDate.Text=model.PublishDate.ToString();
		this.txtReplyMan.Text=model.ReplyMan;
		this.txtReplyContent.Text=model.ReplyContent;
		this.txtReplyDate.Text=model.ReplyDate.ToString();
		this.txtFlag.Text=model.Flag.ToString();
		this.txtTypeId.Text=model.TypeId.ToString();
		this.txtContact.Text=model.Contact;
		this.txtReplyFlag.Text=model.ReplyFlag.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserCode.Text.Trim().Length==0)
			{
				strErr+="UserCode不能为空！\\n";	
			}
			if(this.txtContactWay.Text.Trim().Length==0)
			{
				strErr+="ContactWay不能为空！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="Phone不能为空！\\n";	
			}
			if(this.txtContent.Text.Trim().Length==0)
			{
				strErr+="Content不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtPublishDate.Text))
			{
				strErr+="PublishDate格式错误！\\n";	
			}
			if(this.txtReplyMan.Text.Trim().Length==0)
			{
				strErr+="ReplyMan不能为空！\\n";	
			}
			if(this.txtReplyContent.Text.Trim().Length==0)
			{
				strErr+="ReplyContent不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtReplyDate.Text))
			{
				strErr+="ReplyDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTypeId.Text))
			{
				strErr+="TypeId格式错误！\\n";	
			}
			if(this.txtContact.Text.Trim().Length==0)
			{
				strErr+="Contact不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtReplyFlag.Text))
			{
				strErr+="ReplyFlag格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string UserCode=this.txtUserCode.Text;
			string ContactWay=this.txtContactWay.Text;
			string Phone=this.txtPhone.Text;
			string Content=this.txtContent.Text;
			DateTime PublishDate=DateTime.Parse(this.txtPublishDate.Text);
			string ReplyMan=this.txtReplyMan.Text;
			string ReplyContent=this.txtReplyContent.Text;
			DateTime ReplyDate=DateTime.Parse(this.txtReplyDate.Text);
			int Flag=int.Parse(this.txtFlag.Text);
			int TypeId=int.Parse(this.txtTypeId.Text);
			string Contact=this.txtContact.Text;
			int ReplyFlag=int.Parse(this.txtReplyFlag.Text);


			WebDemo.Model.WebDemo.UserFeedBack model=new WebDemo.Model.WebDemo.UserFeedBack();
			model.ID=ID;
			model.UserCode=UserCode;
			model.ContactWay=ContactWay;
			model.Phone=Phone;
			model.Content=Content;
			model.PublishDate=PublishDate;
			model.ReplyMan=ReplyMan;
			model.ReplyContent=ReplyContent;
			model.ReplyDate=ReplyDate;
			model.Flag=Flag;
			model.TypeId=TypeId;
			model.Contact=Contact;
			model.ReplyFlag=ReplyFlag;

			WebDemo.BLL.WebDemo.UserFeedBack bll=new WebDemo.BLL.WebDemo.UserFeedBack();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
