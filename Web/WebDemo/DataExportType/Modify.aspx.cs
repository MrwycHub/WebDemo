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
namespace WebDemo.Web.WebDemo.DataExportType
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
		WebDemo.BLL.WebDemo.DataExportType bll=new WebDemo.BLL.WebDemo.DataExportType();
		WebDemo.Model.WebDemo.DataExportType model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtName.Text=model.Name;
		this.chkIsShow.Checked=model.IsShow;
		this.txtOrderNum.Text=model.OrderNum.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtConnString.Text=model.ConnString;
		this.txtTableName.Text=model.TableName;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="Name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderNum.Text))
			{
				strErr+="OrderNum格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(this.txtConnString.Text.Trim().Length==0)
			{
				strErr+="ConnString不能为空！\\n";	
			}
			if(this.txtTableName.Text.Trim().Length==0)
			{
				strErr+="TableName不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string Name=this.txtName.Text;
			bool IsShow=this.chkIsShow.Checked;
			int OrderNum=int.Parse(this.txtOrderNum.Text);
			string Remark=this.txtRemark.Text;
			string ConnString=this.txtConnString.Text;
			string TableName=this.txtTableName.Text;


			WebDemo.Model.WebDemo.DataExportType model=new WebDemo.Model.WebDemo.DataExportType();
			model.ID=ID;
			model.Name=Name;
			model.IsShow=IsShow;
			model.OrderNum=OrderNum;
			model.Remark=Remark;
			model.ConnString=ConnString;
			model.TableName=TableName;

			WebDemo.BLL.WebDemo.DataExportType bll=new WebDemo.BLL.WebDemo.DataExportType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
