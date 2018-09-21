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
namespace WebDemo.Web.WebDemo.ParamsKinds
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtParamName.Text.Trim().Length==0)
			{
				strErr+="参数名称不能为空！\\n";	
			}
			if(this.txtPTypeNum.Text.Trim().Length==0)
			{
				strErr+="参数编号不能为空！\\n";	
			}
			if(this.txtPDisplayValue.Text.Trim().Length==0)
			{
				strErr+="显示值不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}
			if(this.txtPTypeValue.Text.Trim().Length==0)
			{
				strErr+="PTypeValue不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ParamName=this.txtParamName.Text;
			string PTypeNum=this.txtPTypeNum.Text;
			string PDisplayValue=this.txtPDisplayValue.Text;
			string Remark=this.txtRemark.Text;
			int Flag=int.Parse(this.txtFlag.Text);
			string PTypeValue=this.txtPTypeValue.Text;

			WebDemo.Model.WebDemo.ParamsKinds model=new WebDemo.Model.WebDemo.ParamsKinds();
			model.ParamName=ParamName;
			model.PTypeNum=PTypeNum;
			model.PDisplayValue=PDisplayValue;
			model.Remark=Remark;
			model.Flag=Flag;
			model.PTypeValue=PTypeValue;

			WebDemo.BLL.WebDemo.ParamsKinds bll=new WebDemo.BLL.WebDemo.ParamsKinds();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
