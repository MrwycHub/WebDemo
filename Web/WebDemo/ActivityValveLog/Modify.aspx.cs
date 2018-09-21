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
namespace WebDemo.Web.WebDemo.ActivityValveLog
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
		WebDemo.BLL.WebDemo.ActivityValveLog bll=new WebDemo.BLL.WebDemo.ActivityValveLog();
		WebDemo.Model.WebDemo.ActivityValveLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtMeterID.Text=model.MeterID.ToString();
		this.txtValveStatusBefore.Text=model.ValveStatusBefore.ToString();
		this.txtValveStatusAfter.Text=model.ValveStatusAfter.ToString();
		this.txtOperTime.Text=model.OperTime.ToString();
		this.txtOperFlag.Text=model.OperFlag;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}
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
			int ID=int.Parse(this.lblID.Text);
			int MeterID=int.Parse(this.txtMeterID.Text);
			int ValveStatusBefore=int.Parse(this.txtValveStatusBefore.Text);
			int ValveStatusAfter=int.Parse(this.txtValveStatusAfter.Text);
			DateTime OperTime=DateTime.Parse(this.txtOperTime.Text);
			string OperFlag=this.txtOperFlag.Text;


			WebDemo.Model.WebDemo.ActivityValveLog model=new WebDemo.Model.WebDemo.ActivityValveLog();
			model.ID=ID;
			model.MeterID=MeterID;
			model.ValveStatusBefore=ValveStatusBefore;
			model.ValveStatusAfter=ValveStatusAfter;
			model.OperTime=OperTime;
			model.OperFlag=OperFlag;

			WebDemo.BLL.WebDemo.ActivityValveLog bll=new WebDemo.BLL.WebDemo.ActivityValveLog();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
