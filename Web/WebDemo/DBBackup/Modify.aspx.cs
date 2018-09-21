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
namespace WebDemo.Web.WebDemo.DBBackup
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.DBBackup bll=new WebDemo.BLL.WebDemo.DBBackup();
		WebDemo.Model.WebDemo.DBBackup model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtBackupTime.Text=model.BackupTime.ToString();
		this.txtBackupName.Text=model.BackupName;
		this.txtPath.Text=model.Path;
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtBackupTime.Text))
			{
				strErr+="BackupTime格式错误！\\n";	
			}
			if(this.txtBackupName.Text.Trim().Length==0)
			{
				strErr+="BackupName不能为空！\\n";	
			}
			if(this.txtPath.Text.Trim().Length==0)
			{
				strErr+="Path不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			DateTime BackupTime=DateTime.Parse(this.txtBackupTime.Text);
			string BackupName=this.txtBackupName.Text;
			string Path=this.txtPath.Text;
			string Remark=this.txtRemark.Text;


			WebDemo.Model.WebDemo.DBBackup model=new WebDemo.Model.WebDemo.DBBackup();
			model.ID=ID;
			model.BackupTime=BackupTime;
			model.BackupName=BackupName;
			model.Path=Path;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.DBBackup bll=new WebDemo.BLL.WebDemo.DBBackup();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
