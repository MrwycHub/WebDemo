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
namespace WebDemo.Web.WebDemo.PhoneMessage
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
		WebDemo.BLL.WebDemo.PhoneMessage bll=new WebDemo.BLL.WebDemo.PhoneMessage();
		WebDemo.Model.WebDemo.PhoneMessage model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtSoftName.Text=model.SoftName;
		this.txtBrands.Text=model.Brands;
		this.txtModel.Text=model.Model;
		this.txtVersion.Text=model.Version;
		this.txtBlueToothVer.Text=model.BlueToothVer;
		this.txtSDKVer.Text=model.SDKVer;
		this.txtIMEI.Text=model.IMEI;
		this.txtCPU.Text=model.CPU;
		this.txtMemory.Text=model.Memory;
		this.txtResolution.Text=model.Resolution;
		this.txtFirstLoginDate.Text=model.FirstLoginDate.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSoftName.Text.Trim().Length==0)
			{
				strErr+="SoftName不能为空！\\n";	
			}
			if(this.txtBrands.Text.Trim().Length==0)
			{
				strErr+="Brands不能为空！\\n";	
			}
			if(this.txtModel.Text.Trim().Length==0)
			{
				strErr+="Model不能为空！\\n";	
			}
			if(this.txtVersion.Text.Trim().Length==0)
			{
				strErr+="Version不能为空！\\n";	
			}
			if(this.txtBlueToothVer.Text.Trim().Length==0)
			{
				strErr+="BlueToothVer不能为空！\\n";	
			}
			if(this.txtSDKVer.Text.Trim().Length==0)
			{
				strErr+="SDKVer不能为空！\\n";	
			}
			if(this.txtIMEI.Text.Trim().Length==0)
			{
				strErr+="IMEI不能为空！\\n";	
			}
			if(this.txtCPU.Text.Trim().Length==0)
			{
				strErr+="CPU不能为空！\\n";	
			}
			if(this.txtMemory.Text.Trim().Length==0)
			{
				strErr+="Memory不能为空！\\n";	
			}
			if(this.txtResolution.Text.Trim().Length==0)
			{
				strErr+="Resolution不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFirstLoginDate.Text))
			{
				strErr+="FirstLoginDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string SoftName=this.txtSoftName.Text;
			string Brands=this.txtBrands.Text;
			string Model=this.txtModel.Text;
			string Version=this.txtVersion.Text;
			string BlueToothVer=this.txtBlueToothVer.Text;
			string SDKVer=this.txtSDKVer.Text;
			string IMEI=this.txtIMEI.Text;
			string CPU=this.txtCPU.Text;
			string Memory=this.txtMemory.Text;
			string Resolution=this.txtResolution.Text;
			DateTime FirstLoginDate=DateTime.Parse(this.txtFirstLoginDate.Text);


			WebDemo.Model.WebDemo.PhoneMessage model=new WebDemo.Model.WebDemo.PhoneMessage();
			model.ID=ID;
			model.SoftName=SoftName;
			model.Brands=Brands;
			model.Model=Model;
			model.Version=Version;
			model.BlueToothVer=BlueToothVer;
			model.SDKVer=SDKVer;
			model.IMEI=IMEI;
			model.CPU=CPU;
			model.Memory=Memory;
			model.Resolution=Resolution;
			model.FirstLoginDate=FirstLoginDate;

			WebDemo.BLL.WebDemo.PhoneMessage bll=new WebDemo.BLL.WebDemo.PhoneMessage();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
