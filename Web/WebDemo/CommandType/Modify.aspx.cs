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
namespace WebDemo.Web.WebDemo.CommandType
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int CommandID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(CommandID);
				}
			}
		}
			
	private void ShowInfo(int CommandID)
	{
		WebDemo.BLL.WebDemo.CommandType bll=new WebDemo.BLL.WebDemo.CommandType();
		WebDemo.Model.WebDemo.CommandType model=bll.GetModel(CommandID);
		this.lblCommandID.Text=model.CommandID.ToString();
		this.txtCommandName.Text=model.CommandName;
		this.txtFlag.Text=model.Flag.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCommandName.Text.Trim().Length==0)
			{
				strErr+="指令名称不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int CommandID=int.Parse(this.lblCommandID.Text);
			string CommandName=this.txtCommandName.Text;
			int Flag=int.Parse(this.txtFlag.Text);


			WebDemo.Model.WebDemo.CommandType model=new WebDemo.Model.WebDemo.CommandType();
			model.CommandID=CommandID;
			model.CommandName=CommandName;
			model.Flag=Flag;

			WebDemo.BLL.WebDemo.CommandType bll=new WebDemo.BLL.WebDemo.CommandType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
