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
namespace WebDemo.Web.WebDemo.FillOperLog
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
		WebDemo.BLL.WebDemo.FillOperLog bll=new WebDemo.BLL.WebDemo.FillOperLog();
		WebDemo.Model.WebDemo.FillOperLog model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtOperID.Text=model.OperID.ToString();
		this.txtOperType.Text=model.OperType;
		this.txtOperDate.Text=model.OperDate.ToString();
		this.txtOperFlag.Text=model.OperFlag.ToString();
		this.txtOperInfo.Text=model.OperInfo;
		this.txtOperatorID.Text=model.OperatorID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtOperID.Text))
			{
				strErr+="OperID格式错误！\\n";	
			}
			if(this.txtOperType.Text.Trim().Length==0)
			{
				strErr+="OperType不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="OperDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperFlag.Text))
			{
				strErr+="OperFlag格式错误！\\n";	
			}
			if(this.txtOperInfo.Text.Trim().Length==0)
			{
				strErr+="OperInfo不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int OperID=int.Parse(this.txtOperID.Text);
			string OperType=this.txtOperType.Text;
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			int OperFlag=int.Parse(this.txtOperFlag.Text);
			string OperInfo=this.txtOperInfo.Text;
			int OperatorID=int.Parse(this.txtOperatorID.Text);


			WebDemo.Model.WebDemo.FillOperLog model=new WebDemo.Model.WebDemo.FillOperLog();
			model.ID=ID;
			model.OperID=OperID;
			model.OperType=OperType;
			model.OperDate=OperDate;
			model.OperFlag=OperFlag;
			model.OperInfo=OperInfo;
			model.OperatorID=OperatorID;

			WebDemo.BLL.WebDemo.FillOperLog bll=new WebDemo.BLL.WebDemo.FillOperLog();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
