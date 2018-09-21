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
namespace WebDemo.Web.WebDemo.ClientEnvironmentInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					long Id=(Convert.ToInt64(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(long Id)
	{
		WebDemo.BLL.WebDemo.ClientEnvironmentInfo bll=new WebDemo.BLL.WebDemo.ClientEnvironmentInfo();
		WebDemo.Model.WebDemo.ClientEnvironmentInfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblDanWeiName.Text=model.DanWeiName;
		this.lblJiQiMa.Text=model.JiQiMa;
		this.txtOperatorCode.Text=model.OperatorCode;
		this.txtIP.Text=model.IP;
		this.txtBrowserName.Text=model.BrowserName;
		this.txtBrowerVersion.Text=model.BrowerVersion;
		this.txtOSName.Text=model.OSName;
		this.lblCreateTime.Text=model.CreateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtOperatorCode.Text.Trim().Length==0)
			{
				strErr+="OperatorCode不能为空！\\n";	
			}
			if(this.txtIP.Text.Trim().Length==0)
			{
				strErr+="IP不能为空！\\n";	
			}
			if(this.txtBrowserName.Text.Trim().Length==0)
			{
				strErr+="BrowserName不能为空！\\n";	
			}
			if(this.txtBrowerVersion.Text.Trim().Length==0)
			{
				strErr+="BrowerVersion不能为空！\\n";	
			}
			if(this.txtOSName.Text.Trim().Length==0)
			{
				strErr+="OSName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateTime.Text))
			{
				strErr+="CreateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			long Id=long.Parse(this.lblId.Text);
			string DanWeiName=this.lblDanWeiName.Text;
			string JiQiMa=this.lblJiQiMa.Text;
			string OperatorCode=this.txtOperatorCode.Text;
			string IP=this.txtIP.Text;
			string BrowserName=this.txtBrowserName.Text;
			string BrowerVersion=this.txtBrowerVersion.Text;
			string OSName=this.txtOSName.Text;
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);


			WebDemo.Model.WebDemo.ClientEnvironmentInfo model=new WebDemo.Model.WebDemo.ClientEnvironmentInfo();
			model.Id=Id;
			model.DanWeiName=DanWeiName;
			model.JiQiMa=JiQiMa;
			model.OperatorCode=OperatorCode;
			model.IP=IP;
			model.BrowserName=BrowserName;
			model.BrowerVersion=BrowerVersion;
			model.OSName=OSName;
			model.CreateTime=CreateTime;

			WebDemo.BLL.WebDemo.ClientEnvironmentInfo bll=new WebDemo.BLL.WebDemo.ClientEnvironmentInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
