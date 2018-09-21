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
namespace WebDemo.Web.WebDemo.Sites
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int SiteID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(SiteID);
				}
			}
		}
			
	private void ShowInfo(int SiteID)
	{
		WebDemo.BLL.WebDemo.Sites bll=new WebDemo.BLL.WebDemo.Sites();
		WebDemo.Model.WebDemo.Sites model=bll.GetModel(SiteID);
		this.lblSiteID.Text=model.SiteID.ToString();
		this.txtSiteName.Text=model.SiteName;
		this.txtSiteAddr.Text=model.SiteAddr;
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSiteName.Text.Trim().Length==0)
			{
				strErr+="SiteName不能为空！\\n";	
			}
			if(this.txtSiteAddr.Text.Trim().Length==0)
			{
				strErr+="SiteAddr不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int SiteID=int.Parse(this.lblSiteID.Text);
			string SiteName=this.txtSiteName.Text;
			string SiteAddr=this.txtSiteAddr.Text;
			string Remark=this.txtRemark.Text;


			WebDemo.Model.WebDemo.Sites model=new WebDemo.Model.WebDemo.Sites();
			model.SiteID=SiteID;
			model.SiteName=SiteName;
			model.SiteAddr=SiteAddr;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.Sites bll=new WebDemo.BLL.WebDemo.Sites();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
