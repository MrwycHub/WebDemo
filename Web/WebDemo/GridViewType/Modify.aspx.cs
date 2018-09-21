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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int GridViewTypeID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(GridViewTypeID);
				}
			}
		}
			
	private void ShowInfo(int GridViewTypeID)
	{
		WebDemo.BLL.WebDemo.GridViewType bll=new WebDemo.BLL.WebDemo.GridViewType();
		WebDemo.Model.WebDemo.GridViewType model=bll.GetModel(GridViewTypeID);
		this.lblGridViewTypeID.Text=model.GridViewTypeID.ToString();
		this.txtGridViewTypeName.Text=model.GridViewTypeName;
		this.chkIsEdit.Checked=model.IsEdit;
		this.chkIsShow.Checked=model.IsShow;
		this.txtOrderNum.Text=model.OrderNum.ToString();
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			int GridViewTypeID=int.Parse(this.lblGridViewTypeID.Text);
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
