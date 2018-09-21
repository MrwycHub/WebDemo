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
namespace WebDemo.Web.WebDemo.Notebookpc
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string NoteBookID= Request.Params["id"];
					ShowInfo(NoteBookID);
				}
			}
		}
			
	private void ShowInfo(string NoteBookID)
	{
		WebDemo.BLL.WebDemo.Notebookpc bll=new WebDemo.BLL.WebDemo.Notebookpc();
		WebDemo.Model.WebDemo.Notebookpc model=bll.GetModel(NoteBookID);
		this.lblNoteBookID.Text=model.NoteBookID;
		this.txtNoteBookName.Text=model.NoteBookName;
		this.txtReMark.Text=model.ReMark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtNoteBookName.Text.Trim().Length==0)
			{
				strErr+="NoteBookName不能为空！\\n";	
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
			string NoteBookID=this.lblNoteBookID.Text;
			string NoteBookName=this.txtNoteBookName.Text;
			string ReMark=this.txtReMark.Text;


			WebDemo.Model.WebDemo.Notebookpc model=new WebDemo.Model.WebDemo.Notebookpc();
			model.NoteBookID=NoteBookID;
			model.NoteBookName=NoteBookName;
			model.ReMark=ReMark;

			WebDemo.BLL.WebDemo.Notebookpc bll=new WebDemo.BLL.WebDemo.Notebookpc();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
