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
namespace WebDemo.Web.WebDemo.FeeOperation
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int FID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(FID);
				}
			}
		}
			
	private void ShowInfo(int FID)
	{
		WebDemo.BLL.WebDemo.FeeOperation bll=new WebDemo.BLL.WebDemo.FeeOperation();
		WebDemo.Model.WebDemo.FeeOperation model=bll.GetModel(FID);
		this.lblFID.Text=model.FID.ToString();
		this.txtUsersID.Text=model.UsersID.ToString();
		this.txtFareID.Text=model.FareID.ToString();
		this.txtFee.Text=model.Fee.ToString();
		this.txtFactFee.Text=model.FactFee.ToString();
		this.txtOperDate.Text=model.OperDate.ToString();
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtSiteID.Text=model.SiteID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUsersID.Text))
			{
				strErr+="UsersID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFareID.Text))
			{
				strErr+="FareID格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFee.Text))
			{
				strErr+="Fee格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFactFee.Text))
			{
				strErr+="FactFee格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="OperDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="SiteID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int FID=int.Parse(this.lblFID.Text);
			int UsersID=int.Parse(this.txtUsersID.Text);
			int FareID=int.Parse(this.txtFareID.Text);
			decimal Fee=decimal.Parse(this.txtFee.Text);
			decimal FactFee=decimal.Parse(this.txtFactFee.Text);
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			int SiteID=int.Parse(this.txtSiteID.Text);


			WebDemo.Model.WebDemo.FeeOperation model=new WebDemo.Model.WebDemo.FeeOperation();
			model.FID=FID;
			model.UsersID=UsersID;
			model.FareID=FareID;
			model.Fee=Fee;
			model.FactFee=FactFee;
			model.OperDate=OperDate;
			model.OperatorID=OperatorID;
			model.SiteID=SiteID;

			WebDemo.BLL.WebDemo.FeeOperation bll=new WebDemo.BLL.WebDemo.FeeOperation();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
