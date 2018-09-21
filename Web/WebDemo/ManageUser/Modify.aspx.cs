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
namespace WebDemo.Web.WebDemo.ManageUser
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int UsersID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					UsersID=(Convert.ToInt32(Request.Params["id0"]));
				}
				string ManageFareID = "";
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					ManageFareID= Request.Params["id1"];
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(UsersID,ManageFareID);
			}
		}
			
	private void ShowInfo(int UsersID,string ManageFareID)
	{
		WebDemo.BLL.WebDemo.ManageUser bll=new WebDemo.BLL.WebDemo.ManageUser();
		WebDemo.Model.WebDemo.ManageUser model=bll.GetModel(UsersID,ManageFareID);
		this.lblUsersID.Text=model.UsersID.ToString();
		this.lblManageFareID.Text=model.ManageFareID;
		this.txtChargeDate.Text=model.ChargeDate.ToString();
		this.txtLastDate.Text=model.LastDate.ToString();
		this.txtReMark.Text=model.ReMark;
		this.txtStatus.Text=model.Status.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtChargeDate.Text))
			{
				strErr+="启用时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLastDate.Text))
			{
				strErr+="最后一次收费格式错误！\\n";	
			}
			if(this.txtReMark.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtStatus.Text))
			{
				strErr+="Status格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UsersID=int.Parse(this.lblUsersID.Text);
			string ManageFareID=this.lblManageFareID.Text;
			DateTime ChargeDate=DateTime.Parse(this.txtChargeDate.Text);
			DateTime LastDate=DateTime.Parse(this.txtLastDate.Text);
			string ReMark=this.txtReMark.Text;
			int Status=int.Parse(this.txtStatus.Text);


			WebDemo.Model.WebDemo.ManageUser model=new WebDemo.Model.WebDemo.ManageUser();
			model.UsersID=UsersID;
			model.ManageFareID=ManageFareID;
			model.ChargeDate=ChargeDate;
			model.LastDate=LastDate;
			model.ReMark=ReMark;
			model.Status=Status;

			WebDemo.BLL.WebDemo.ManageUser bll=new WebDemo.BLL.WebDemo.ManageUser();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
