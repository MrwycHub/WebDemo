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
namespace WebDemo.Web.WebDemo.Params
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ParamID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ParamID);
				}
			}
		}
			
	private void ShowInfo(int ParamID)
	{
		WebDemo.BLL.WebDemo.Params bll=new WebDemo.BLL.WebDemo.Params();
		WebDemo.Model.WebDemo.Params model=bll.GetModel(ParamID);
		this.lblParamID.Text=model.ParamID.ToString();
		this.txtParamName.Text=model.ParamName;
		this.txtParamValue.Text=model.ParamValue;
		this.txtRemark.Text=model.Remark;
		this.chkIsShow.Checked=model.IsShow;
		this.chkIsEdit.Checked=model.IsEdit;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtParamName.Text.Trim().Length==0)
			{
				strErr+="ParamName不能为空！\\n";	
			}
			if(this.txtParamValue.Text.Trim().Length==0)
			{
				strErr+="ParamValue不能为空！\\n";	
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
			int ParamID=int.Parse(this.lblParamID.Text);
			string ParamName=this.txtParamName.Text;
			string ParamValue=this.txtParamValue.Text;
			string Remark=this.txtRemark.Text;
			bool IsShow=this.chkIsShow.Checked;
			bool IsEdit=this.chkIsEdit.Checked;


			WebDemo.Model.WebDemo.Params model=new WebDemo.Model.WebDemo.Params();
			model.ParamID=ParamID;
			model.ParamName=ParamName;
			model.ParamValue=ParamValue;
			model.Remark=Remark;
			model.IsShow=IsShow;
			model.IsEdit=IsEdit;

			WebDemo.BLL.WebDemo.Params bll=new WebDemo.BLL.WebDemo.Params();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
