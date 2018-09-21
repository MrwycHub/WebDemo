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
namespace WebDemo.Web.WebDemo.ActivityValveInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int MeterID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(MeterID);
				}
			}
		}
			
	private void ShowInfo(int MeterID)
	{
		WebDemo.BLL.WebDemo.ActivityValveInfo bll=new WebDemo.BLL.WebDemo.ActivityValveInfo();
		WebDemo.Model.WebDemo.ActivityValveInfo model=bll.GetModel(MeterID);
		this.lblMeterID.Text=model.MeterID.ToString();
		this.txtValveStatusBefore.Text=model.ValveStatusBefore.ToString();
		this.txtValveStatusAfter.Text=model.ValveStatusAfter.ToString();
		this.txtOperTime.Text=model.OperTime.ToString();
		this.txtOperFlag.Text=model.OperFlag;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtValveStatusBefore.Text))
			{
				strErr+="ValveStatusBefore格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtValveStatusAfter.Text))
			{
				strErr+="ValveStatusAfter格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperTime.Text))
			{
				strErr+="OperTime格式错误！\\n";	
			}
			if(this.txtOperFlag.Text.Trim().Length==0)
			{
				strErr+="OperFlag不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int MeterID=int.Parse(this.lblMeterID.Text);
			int ValveStatusBefore=int.Parse(this.txtValveStatusBefore.Text);
			int ValveStatusAfter=int.Parse(this.txtValveStatusAfter.Text);
			DateTime OperTime=DateTime.Parse(this.txtOperTime.Text);
			string OperFlag=this.txtOperFlag.Text;


			WebDemo.Model.WebDemo.ActivityValveInfo model=new WebDemo.Model.WebDemo.ActivityValveInfo();
			model.MeterID=MeterID;
			model.ValveStatusBefore=ValveStatusBefore;
			model.ValveStatusAfter=ValveStatusAfter;
			model.OperTime=OperTime;
			model.OperFlag=OperFlag;

			WebDemo.BLL.WebDemo.ActivityValveInfo bll=new WebDemo.BLL.WebDemo.ActivityValveInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
