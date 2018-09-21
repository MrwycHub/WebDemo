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
namespace WebDemo.Web.WebDemo.GridViewType
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtGridViewTypeID.Text))
			{
				strErr+="GridViewTypeID格式错误！\\n";	
			}
			if(this.txtGridViewTypeName.Text.Trim().Length==0)
			{
				strErr+="GridViewTypeName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderNum.Text))
			{
				strErr+="OrderNum格式错误！\\n";	
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
			int GridViewTypeID=int.Parse(this.txtGridViewTypeID.Text);
			string GridViewTypeName=this.txtGridViewTypeName.Text;
			bool IsEdit=this.chkIsEdit.Checked;
			bool IsShow=this.chkIsShow.Checked;
			int OrderNum=int.Parse(this.txtOrderNum.Text);
			string Remark=this.txtRemark.Text;

			WebDemo.Model.WebDemo.GridViewType model=new WebDemo.Model.WebDemo.GridViewType();
			model.GridViewTypeID=GridViewTypeID;
			model.GridViewTypeName=GridViewTypeName;
			model.IsEdit=IsEdit;
			model.IsShow=IsShow;
			model.OrderNum=OrderNum;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.GridViewType bll=new WebDemo.BLL.WebDemo.GridViewType();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
