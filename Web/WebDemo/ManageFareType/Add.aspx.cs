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
namespace WebDemo.Web.WebDemo.ManageFareType
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtManageFareTypeID.Text))
			{
				strErr+="ManageFareTypeID格式错误！\\n";	
			}
			if(this.txtManageFareTypeName.Text.Trim().Length==0)
			{
				strErr+="1按月2按面积3按人口4手工输不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ManageFareTypeID=int.Parse(this.txtManageFareTypeID.Text);
			string ManageFareTypeName=this.txtManageFareTypeName.Text;

			WebDemo.Model.WebDemo.ManageFareType model=new WebDemo.Model.WebDemo.ManageFareType();
			model.ManageFareTypeID=ManageFareTypeID;
			model.ManageFareTypeName=ManageFareTypeName;

			WebDemo.BLL.WebDemo.ManageFareType bll=new WebDemo.BLL.WebDemo.ManageFareType();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
