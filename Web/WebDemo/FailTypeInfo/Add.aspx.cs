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
namespace WebDemo.Web.WebDemo.FailTypeInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtFailTypeNum.Text))
			{
				strErr+="FailTypeNum格式错误！\\n";	
			}
			if(this.txtFailTypeName.Text.Trim().Length==0)
			{
				strErr+="FailTypeName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFailFlag.Text))
			{
				strErr+="FailFlag格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtEnableDelete.Text))
			{
				strErr+="EnableDelete格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtAutoAnalyse.Text))
			{
				strErr+="AutoAnalyse格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int FailTypeNum=int.Parse(this.txtFailTypeNum.Text);
			string FailTypeName=this.txtFailTypeName.Text;
			int FailFlag=int.Parse(this.txtFailFlag.Text);
			string Remark=this.txtRemark.Text;
			int EnableDelete=int.Parse(this.txtEnableDelete.Text);
			int AutoAnalyse=int.Parse(this.txtAutoAnalyse.Text);

			WebDemo.Model.WebDemo.FailTypeInfo model=new WebDemo.Model.WebDemo.FailTypeInfo();
			model.FailTypeNum=FailTypeNum;
			model.FailTypeName=FailTypeName;
			model.FailFlag=FailFlag;
			model.Remark=Remark;
			model.EnableDelete=EnableDelete;
			model.AutoAnalyse=AutoAnalyse;

			WebDemo.BLL.WebDemo.FailTypeInfo bll=new WebDemo.BLL.WebDemo.FailTypeInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
