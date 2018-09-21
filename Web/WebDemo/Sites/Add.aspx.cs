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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string SiteName=this.txtSiteName.Text;
			string SiteAddr=this.txtSiteAddr.Text;
			string Remark=this.txtRemark.Text;

			WebDemo.Model.WebDemo.Sites model=new WebDemo.Model.WebDemo.Sites();
			model.SiteName=SiteName;
			model.SiteAddr=SiteAddr;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.Sites bll=new WebDemo.BLL.WebDemo.Sites();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
