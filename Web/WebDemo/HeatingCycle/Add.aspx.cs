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
namespace WebDemo.Web.WebDemo.HeatingCycle
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtYear.Text))
			{
				strErr+="Year格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtStartDate.Text))
			{
				strErr+="StartDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEndDate.Text))
			{
				strErr+="EndDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Year=int.Parse(this.txtYear.Text);
			DateTime StartDate=DateTime.Parse(this.txtStartDate.Text);
			DateTime EndDate=DateTime.Parse(this.txtEndDate.Text);

			WebDemo.Model.WebDemo.HeatingCycle model=new WebDemo.Model.WebDemo.HeatingCycle();
			model.Year=Year;
			model.StartDate=StartDate;
			model.EndDate=EndDate;

			WebDemo.BLL.WebDemo.HeatingCycle bll=new WebDemo.BLL.WebDemo.HeatingCycle();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
