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
namespace WebDemo.Web.WebDemo.MessageRemind
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
		WebDemo.BLL.WebDemo.MessageRemind bll=new WebDemo.BLL.WebDemo.MessageRemind();
		WebDemo.Model.WebDemo.MessageRemind model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtRemindType.Text=model.RemindType.ToString();
		this.txtRemindContent.Text=model.RemindContent;
		this.txtOperatorIDStr.Text=model.OperatorIDStr;
		this.txtReadedStr.Text=model.ReadedStr;
		this.txtUpdateTime.Text=model.UpdateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtRemindType.Text))
			{
				strErr+="RemindType格式错误！\\n";	
			}
			if(this.txtRemindContent.Text.Trim().Length==0)
			{
				strErr+="RemindContent不能为空！\\n";	
			}
			if(this.txtOperatorIDStr.Text.Trim().Length==0)
			{
				strErr+="OperatorIDStr不能为空！\\n";	
			}
			if(this.txtReadedStr.Text.Trim().Length==0)
			{
				strErr+="ReadedStr不能为空！\\n";	
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
			int RemindType=int.Parse(this.txtRemindType.Text);
			string RemindContent=this.txtRemindContent.Text;
			string OperatorIDStr=this.txtOperatorIDStr.Text;
			string ReadedStr=this.txtReadedStr.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);


			WebDemo.Model.WebDemo.MessageRemind model=new WebDemo.Model.WebDemo.MessageRemind();
			model.ID=ID;
			model.RemindType=RemindType;
			model.RemindContent=RemindContent;
			model.OperatorIDStr=OperatorIDStr;
			model.ReadedStr=ReadedStr;
			model.UpdateTime=UpdateTime;

			WebDemo.BLL.WebDemo.MessageRemind bll=new WebDemo.BLL.WebDemo.MessageRemind();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
