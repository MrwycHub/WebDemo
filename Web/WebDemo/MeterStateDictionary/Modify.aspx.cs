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
namespace WebDemo.Web.WebDemo.MeterStateDictionary
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int StateCode=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(StateCode);
				}
			}
		}
			
	private void ShowInfo(int StateCode)
	{
		WebDemo.BLL.WebDemo.MeterStateDictionary bll=new WebDemo.BLL.WebDemo.MeterStateDictionary();
		WebDemo.Model.WebDemo.MeterStateDictionary model=bll.GetModel(StateCode);
		this.lblStateCode.Text=model.StateCode.ToString();
		this.txtStateName.Text=model.StateName;
		this.chkEnable.Checked=model.Enable;
		this.chkIsShow.Checked=model.IsShow;
		this.txtOrderNum.Text=model.OrderNum.ToString();
		this.txtReasion.Text=model.Reasion;
		this.txtOperation.Text=model.Operation;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStateName.Text.Trim().Length==0)
			{
				strErr+="StateName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderNum.Text))
			{
				strErr+="OrderNum格式错误！\\n";	
			}
			if(this.txtReasion.Text.Trim().Length==0)
			{
				strErr+="Reasion不能为空！\\n";	
			}
			if(this.txtOperation.Text.Trim().Length==0)
			{
				strErr+="Operation不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int StateCode=int.Parse(this.lblStateCode.Text);
			string StateName=this.txtStateName.Text;
			bool Enable=this.chkEnable.Checked;
			bool IsShow=this.chkIsShow.Checked;
			int OrderNum=int.Parse(this.txtOrderNum.Text);
			string Reasion=this.txtReasion.Text;
			string Operation=this.txtOperation.Text;


			WebDemo.Model.WebDemo.MeterStateDictionary model=new WebDemo.Model.WebDemo.MeterStateDictionary();
			model.StateCode=StateCode;
			model.StateName=StateName;
			model.Enable=Enable;
			model.IsShow=IsShow;
			model.OrderNum=OrderNum;
			model.Reasion=Reasion;
			model.Operation=Operation;

			WebDemo.BLL.WebDemo.MeterStateDictionary bll=new WebDemo.BLL.WebDemo.MeterStateDictionary();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
