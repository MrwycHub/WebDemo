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
namespace WebDemo.Web.WebDemo.LostInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int LostID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(LostID);
				}
			}
		}
			
	private void ShowInfo(int LostID)
	{
		WebDemo.BLL.WebDemo.LostInfo bll=new WebDemo.BLL.WebDemo.LostInfo();
		WebDemo.Model.WebDemo.LostInfo model=bll.GetModel(LostID);
		this.lblLostID.Text=model.LostID.ToString();
		this.txtMultiUserID.Text=model.MultiUserID.ToString();
		this.txtCardID.Text=model.CardID.ToString();
		this.txtLostDate.Text=model.LostDate.ToString();
		this.txtDownloadDate.Text=model.DownloadDate.ToString();
		this.txtSuccessMeterID.Text=model.SuccessMeterID.ToString();
		this.txtSuccessDate.Text=model.SuccessDate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMultiUserID.Text))
			{
				strErr+="MultiUserID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtCardID.Text))
			{
				strErr+="CardID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLostDate.Text))
			{
				strErr+="LostDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDownloadDate.Text))
			{
				strErr+="DownloadDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSuccessMeterID.Text))
			{
				strErr+="SuccessMeterID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSuccessDate.Text))
			{
				strErr+="SuccessDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int LostID=int.Parse(this.lblLostID.Text);
			int MultiUserID=int.Parse(this.txtMultiUserID.Text);
			int CardID=int.Parse(this.txtCardID.Text);
			DateTime LostDate=DateTime.Parse(this.txtLostDate.Text);
			DateTime DownloadDate=DateTime.Parse(this.txtDownloadDate.Text);
			int SuccessMeterID=int.Parse(this.txtSuccessMeterID.Text);
			DateTime SuccessDate=DateTime.Parse(this.txtSuccessDate.Text);


			WebDemo.Model.WebDemo.LostInfo model=new WebDemo.Model.WebDemo.LostInfo();
			model.LostID=LostID;
			model.MultiUserID=MultiUserID;
			model.CardID=CardID;
			model.LostDate=LostDate;
			model.DownloadDate=DownloadDate;
			model.SuccessMeterID=SuccessMeterID;
			model.SuccessDate=SuccessDate;

			WebDemo.BLL.WebDemo.LostInfo bll=new WebDemo.BLL.WebDemo.LostInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
