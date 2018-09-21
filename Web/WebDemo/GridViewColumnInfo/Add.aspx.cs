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
namespace WebDemo.Web.WebDemo.GridViewColumnInfo
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
			if(!PageValidate.IsNumber(txtColumnID.Text))
			{
				strErr+="ColumnID格式错误！\\n";	
			}
			if(this.txtDataField.Text.Trim().Length==0)
			{
				strErr+="DataField不能为空！\\n";	
			}
			if(this.txtHeaderText.Text.Trim().Length==0)
			{
				strErr+="HeaderText不能为空！\\n";	
			}
			if(this.txtDataFormat.Text.Trim().Length==0)
			{
				strErr+="DataFormat不能为空！\\n";	
			}
			if(this.txtSortExpression.Text.Trim().Length==0)
			{
				strErr+="SortExpression不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderNum.Text))
			{
				strErr+="OrderNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
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
			int ColumnID=int.Parse(this.txtColumnID.Text);
			string DataField=this.txtDataField.Text;
			string HeaderText=this.txtHeaderText.Text;
			string DataFormat=this.txtDataFormat.Text;
			string SortExpression=this.txtSortExpression.Text;
			bool IsEdit=this.chkIsEdit.Checked;
			bool IsShow=this.chkIsShow.Checked;
			int OrderNum=int.Parse(this.txtOrderNum.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			string Remark=this.txtRemark.Text;

			WebDemo.Model.WebDemo.GridViewColumnInfo model=new WebDemo.Model.WebDemo.GridViewColumnInfo();
			model.GridViewTypeID=GridViewTypeID;
			model.ColumnID=ColumnID;
			model.DataField=DataField;
			model.HeaderText=HeaderText;
			model.DataFormat=DataFormat;
			model.SortExpression=SortExpression;
			model.IsEdit=IsEdit;
			model.IsShow=IsShow;
			model.OrderNum=OrderNum;
			model.OperatorID=OperatorID;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.GridViewColumnInfo bll=new WebDemo.BLL.WebDemo.GridViewColumnInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
