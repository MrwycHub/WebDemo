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
namespace WebDemo.Web.WebDemo.ParamsKinds
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Pid=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(Pid);
				}
			}
		}
			
	private void ShowInfo(int Pid)
	{
		WebDemo.BLL.WebDemo.ParamsKinds bll=new WebDemo.BLL.WebDemo.ParamsKinds();
		WebDemo.Model.WebDemo.ParamsKinds model=bll.GetModel(Pid);
		this.lblPid.Text=model.Pid.ToString();
		this.lblParamName.Text=model.ParamName;
		this.lblPTypeNum.Text=model.PTypeNum;
		this.txtPDisplayValue.Text=model.PDisplayValue;
		this.txtRemark.Text=model.Remark;
		this.txtFlag.Text=model.Flag.ToString();
		this.txtPTypeValue.Text=model.PTypeValue;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtPDisplayValue.Text.Trim().Length==0)
			{
				strErr+="显示值不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}
			if(this.txtPTypeValue.Text.Trim().Length==0)
			{
				strErr+="PTypeValue不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Pid=int.Parse(this.lblPid.Text);
			string ParamName=this.lblParamName.Text;
			string PTypeNum=this.lblPTypeNum.Text;
			string PDisplayValue=this.txtPDisplayValue.Text;
			string Remark=this.txtRemark.Text;
			int Flag=int.Parse(this.txtFlag.Text);
			string PTypeValue=this.txtPTypeValue.Text;


			WebDemo.Model.WebDemo.ParamsKinds model=new WebDemo.Model.WebDemo.ParamsKinds();
			model.Pid=Pid;
			model.ParamName=ParamName;
			model.PTypeNum=PTypeNum;
			model.PDisplayValue=PDisplayValue;
			model.Remark=Remark;
			model.Flag=Flag;
			model.PTypeValue=PTypeValue;

			WebDemo.BLL.WebDemo.ParamsKinds bll=new WebDemo.BLL.WebDemo.ParamsKinds();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
