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
namespace WebDemo.Web.WebDemo.NoteBookGroup
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtGroupID.Text))
			{
				strErr+="GroupID格式错误！\\n";	
			}
			if(this.txtNoteBookID.Text.Trim().Length==0)
			{
				strErr+="NoteBookID不能为空！\\n";	
			}
			if(this.txtGroupName.Text.Trim().Length==0)
			{
				strErr+="GroupName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtLimitNum.Text))
			{
				strErr+="LimitNum格式错误！\\n";	
			}
			if(this.txtReMark.Text.Trim().Length==0)
			{
				strErr+="ReMark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int GroupID=int.Parse(this.txtGroupID.Text);
			string NoteBookID=this.txtNoteBookID.Text;
			string GroupName=this.txtGroupName.Text;
			int LimitNum=int.Parse(this.txtLimitNum.Text);
			string ReMark=this.txtReMark.Text;

			WebDemo.Model.WebDemo.NoteBookGroup model=new WebDemo.Model.WebDemo.NoteBookGroup();
			model.GroupID=GroupID;
			model.NoteBookID=NoteBookID;
			model.GroupName=GroupName;
			model.LimitNum=LimitNum;
			model.ReMark=ReMark;

			WebDemo.BLL.WebDemo.NoteBookGroup bll=new WebDemo.BLL.WebDemo.NoteBookGroup();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
