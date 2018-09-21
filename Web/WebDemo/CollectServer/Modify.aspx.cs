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
namespace WebDemo.Web.WebDemo.CollectServer
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ServerId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ServerId);
				}
			}
		}
			
	private void ShowInfo(int ServerId)
	{
		WebDemo.BLL.WebDemo.CollectServer bll=new WebDemo.BLL.WebDemo.CollectServer();
		WebDemo.Model.WebDemo.CollectServer model=bll.GetModel(ServerId);
		this.lblServerId.Text=model.ServerId.ToString();
		this.txtServerName.Text=model.ServerName;
		this.txtServerType.Text=model.ServerType.ToString();
		this.txtServerIp.Text=model.ServerIp;
		this.txtWcfUrl.Text=model.WcfUrl;
		this.txtOperTime.Text=model.OperTime.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtPort.Text=model.Port.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtServerName.Text.Trim().Length==0)
			{
				strErr+="ServerName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtServerType.Text))
			{
				strErr+="ServerType格式错误！\\n";	
			}
			if(this.txtServerIp.Text.Trim().Length==0)
			{
				strErr+="ServerIp不能为空！\\n";	
			}
			if(this.txtWcfUrl.Text.Trim().Length==0)
			{
				strErr+="WcfUrl不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperTime.Text))
			{
				strErr+="OperTime格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPort.Text))
			{
				strErr+="Port格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ServerId=int.Parse(this.lblServerId.Text);
			string ServerName=this.txtServerName.Text;
			int ServerType=int.Parse(this.txtServerType.Text);
			string ServerIp=this.txtServerIp.Text;
			string WcfUrl=this.txtWcfUrl.Text;
			DateTime OperTime=DateTime.Parse(this.txtOperTime.Text);
			string Remark=this.txtRemark.Text;
			int Port=int.Parse(this.txtPort.Text);


			WebDemo.Model.WebDemo.CollectServer model=new WebDemo.Model.WebDemo.CollectServer();
			model.ServerId=ServerId;
			model.ServerName=ServerName;
			model.ServerType=ServerType;
			model.ServerIp=ServerIp;
			model.WcfUrl=WcfUrl;
			model.OperTime=OperTime;
			model.Remark=Remark;
			model.Port=Port;

			WebDemo.BLL.WebDemo.CollectServer bll=new WebDemo.BLL.WebDemo.CollectServer();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
