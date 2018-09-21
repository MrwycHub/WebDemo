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
namespace WebDemo.Web.WebDemo.MeterCurrentState
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				int MeterID = -1;
				if (Request.Params["id0"] != null && Request.Params["id0"].Trim() != "")
				{
					MeterID=(Convert.ToInt32(Request.Params["id0"]));
				}
				int StateCode = -1;
				if (Request.Params["id1"] != null && Request.Params["id1"].Trim() != "")
				{
					StateCode=(Convert.ToInt32(Request.Params["id1"]));
				}
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo(MeterID,StateCode);
			}
		}
			
	private void ShowInfo(int MeterID,int StateCode)
	{
		WebDemo.BLL.WebDemo.MeterCurrentState bll=new WebDemo.BLL.WebDemo.MeterCurrentState();
		WebDemo.Model.WebDemo.MeterCurrentState model=bll.GetModel(MeterID,StateCode);
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblStateCode.Text=model.StateCode.ToString();
		this.txtStateValue.Text=model.StateValue;
		this.txtStateInfo.Text=model.StateInfo;
		this.txtUpdateTime.Text=model.UpdateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStateValue.Text.Trim().Length==0)
			{
				strErr+="StateValue不能为空！\\n";	
			}
			if(this.txtStateInfo.Text.Trim().Length==0)
			{
				strErr+="StateInfo不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="UpdateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.lblMeterID.Text);
			int StateCode=int.Parse(this.lblStateCode.Text);
			string StateValue=this.txtStateValue.Text;
			string StateInfo=this.txtStateInfo.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);


			WebDemo.Model.WebDemo.MeterCurrentState model=new WebDemo.Model.WebDemo.MeterCurrentState();
			model.MeterID=MeterID;
			model.StateCode=StateCode;
			model.StateValue=StateValue;
			model.StateInfo=StateInfo;
			model.UpdateTime=UpdateTime;

			WebDemo.BLL.WebDemo.MeterCurrentState bll=new WebDemo.BLL.WebDemo.MeterCurrentState();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
