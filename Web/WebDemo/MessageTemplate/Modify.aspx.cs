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
namespace WebDemo.Web.WebDemo.MessageTemplate
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
		WebDemo.BLL.WebDemo.MessageTemplate bll=new WebDemo.BLL.WebDemo.MessageTemplate();
		WebDemo.Model.WebDemo.MessageTemplate model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtMessageID.Text=model.MessageID.ToString();
		this.txtFlag.Text=model.Flag.ToString();
		this.txtTitle.Text=model.Title;
		this.txtContent.Text=model.Content;
		this.txtUpdateTime.Text=model.UpdateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMessageID.Text))
			{
				strErr+="MessageID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="Title不能为空！\\n";	
			}
			if(this.txtContent.Text.Trim().Length==0)
			{
				strErr+="Content不能为空！\\n";	
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
			int MessageID=int.Parse(this.txtMessageID.Text);
			int Flag=int.Parse(this.txtFlag.Text);
			string Title=this.txtTitle.Text;
			string Content=this.txtContent.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);


			WebDemo.Model.WebDemo.MessageTemplate model=new WebDemo.Model.WebDemo.MessageTemplate();
			model.ID=ID;
			model.MessageID=MessageID;
			model.Flag=Flag;
			model.Title=Title;
			model.Content=Content;
			model.UpdateTime=UpdateTime;

			WebDemo.BLL.WebDemo.MessageTemplate bll=new WebDemo.BLL.WebDemo.MessageTemplate();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
