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
namespace WebDemo.Web.WebDemo.CollectorWork
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtCollectorID.Text))
			{
				strErr+="集中器ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtWorkID.Text))
			{
				strErr+="工作时段格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtWorkTime.Text))
			{
				strErr+="时段区间格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int CollectorID=int.Parse(this.txtCollectorID.Text);
			int WorkID=int.Parse(this.txtWorkID.Text);
			int WorkTime=int.Parse(this.txtWorkTime.Text);

			WebDemo.Model.WebDemo.CollectorWork model=new WebDemo.Model.WebDemo.CollectorWork();
			model.CollectorID=CollectorID;
			model.WorkID=WorkID;
			model.WorkTime=WorkTime;

			WebDemo.BLL.WebDemo.CollectorWork bll=new WebDemo.BLL.WebDemo.CollectorWork();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
