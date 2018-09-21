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
namespace WebDemo.Web.WebDemo.HostStateLog
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
		WebDemo.BLL.WebDemo.HostStateLog bll=new WebDemo.BLL.WebDemo.HostStateLog();
		WebDemo.Model.WebDemo.HostStateLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtHostId.Text=model.HostId.ToString();
		this.txtFuncType.Text=model.FuncType.ToString();
		this.txtReadTime.Text=model.ReadTime.ToString();
		this.txtState.Text=model.State.ToString();
		this.txtDescripion.Text=model.Descripion;
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtHostId.Text))
			{
				strErr+="HostId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFuncType.Text))
			{
				strErr+="FuncType格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtReadTime.Text))
			{
				strErr+="ReadTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtState.Text))
			{
				strErr+="State格式错误！\\n";	
			}
			if(this.txtDescripion.Text.Trim().Length==0)
			{
				strErr+="Descripion不能为空！\\n";	
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
			int ID=int.Parse(this.lblID.Text);
			int HostId=int.Parse(this.txtHostId.Text);
			int FuncType=int.Parse(this.txtFuncType.Text);
			DateTime ReadTime=DateTime.Parse(this.txtReadTime.Text);
			int State=int.Parse(this.txtState.Text);
			string Descripion=this.txtDescripion.Text;
			string Remark=this.txtRemark.Text;


			WebDemo.Model.WebDemo.HostStateLog model=new WebDemo.Model.WebDemo.HostStateLog();
			model.ID=ID;
			model.HostId=HostId;
			model.FuncType=FuncType;
			model.ReadTime=ReadTime;
			model.State=State;
			model.Descripion=Descripion;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.HostStateLog bll=new WebDemo.BLL.WebDemo.HostStateLog();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
