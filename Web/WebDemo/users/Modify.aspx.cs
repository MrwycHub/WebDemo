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
namespace WebDemo.Web.WebDemo.users
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int UsersID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(UsersID);
				}
			}
		}
			
	private void ShowInfo(int UsersID)
	{
		WebDemo.BLL.WebDemo.users bll=new WebDemo.BLL.WebDemo.users();
		WebDemo.Model.WebDemo.users model=bll.GetModel(UsersID);
		this.lblUsersID.Text=model.UsersID.ToString();
		this.txtUserCode.Text=model.UserCode;
		this.txtUserName.Text=model.UserName;
		this.txtDoorplate.Text=model.Doorplate;
		this.txtPaperType.Text=model.PaperType;
		this.txtPaperNo.Text=model.PaperNo;
		this.txtAddress.Text=model.Address;
		this.txtPhone.Text=model.Phone;
		this.txtTel.Text=model.Tel;
		this.txtAcreage.Text=model.Acreage.ToString();
		this.txtChargeAcreage.Text=model.ChargeAcreage.ToString();
		this.txtReserve.Text=model.Reserve.ToString();
		this.txtSex.Text=model.Sex;
		this.txtPopulace.Text=model.Populace.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtMark.Text=model.Mark.ToString();
		this.txtDeptID.Text=model.DeptID;
		this.txtUserFloor.Text=model.UserFloor;
		this.txtHouseDir.Text=model.HouseDir;
		this.txtUserType.Text=model.UserType;
		this.txtClientId.Text=model.ClientId;
		this.txtRemnant.Text=model.Remnant.ToString();
		this.txtRemnant2.Text=model.Remnant2.ToString();
		this.txtRemnant3.Text=model.Remnant3.ToString();
		this.txtUpdateTime.Text=model.UpdateTime.ToString();
		this.txtRegistPhone.Text=model.RegistPhone;
		this.txtEInvoiceType.Text=model.EInvoiceType.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserCode.Text.Trim().Length==0)
			{
				strErr+="用户编号,不能重复不能为空！\\n";	
			}
			if(this.txtUserName.Text.Trim().Length==0)
			{
				strErr+="UserName不能为空！\\n";	
			}
			if(this.txtDoorplate.Text.Trim().Length==0)
			{
				strErr+="Doorplate不能为空！\\n";	
			}
			if(this.txtPaperType.Text.Trim().Length==0)
			{
				strErr+="PaperType不能为空！\\n";	
			}
			if(this.txtPaperNo.Text.Trim().Length==0)
			{
				strErr+="PaperNo不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="Phone不能为空！\\n";	
			}
			if(this.txtTel.Text.Trim().Length==0)
			{
				strErr+="Tel不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAcreage.Text))
			{
				strErr+="住房面积格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtChargeAcreage.Text))
			{
				strErr+="收费面积格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtReserve.Text))
			{
				strErr+="余额格式错误！\\n";	
			}
			if(this.txtSex.Text.Trim().Length==0)
			{
				strErr+="性别不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPopulace.Text))
			{
				strErr+="人口格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMark.Text))
			{
				strErr+="状态 1正常 2销户格式错误！\\n";	
			}
			if(this.txtDeptID.Text.Trim().Length==0)
			{
				strErr+="DeptID不能为空！\\n";	
			}
			if(this.txtUserFloor.Text.Trim().Length==0)
			{
				strErr+="UserFloor不能为空！\\n";	
			}
			if(this.txtHouseDir.Text.Trim().Length==0)
			{
				strErr+="HouseDir不能为空！\\n";	
			}
			if(this.txtUserType.Text.Trim().Length==0)
			{
				strErr+="UserType不能为空！\\n";	
			}
			if(this.txtClientId.Text.Trim().Length==0)
			{
				strErr+="ClientId不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtRemnant.Text))
			{
				strErr+="Remnant格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtRemnant2.Text))
			{
				strErr+="Remnant2格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtRemnant3.Text))
			{
				strErr+="Remnant3格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="UpdateTime格式错误！\\n";	
			}
			if(this.txtRegistPhone.Text.Trim().Length==0)
			{
				strErr+="RegistPhone不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtEInvoiceType.Text))
			{
				strErr+="EInvoiceType格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UsersID=int.Parse(this.lblUsersID.Text);
			string UserCode=this.txtUserCode.Text;
			string UserName=this.txtUserName.Text;
			string Doorplate=this.txtDoorplate.Text;
			string PaperType=this.txtPaperType.Text;
			string PaperNo=this.txtPaperNo.Text;
			string Address=this.txtAddress.Text;
			string Phone=this.txtPhone.Text;
			string Tel=this.txtTel.Text;
			decimal Acreage=decimal.Parse(this.txtAcreage.Text);
			decimal ChargeAcreage=decimal.Parse(this.txtChargeAcreage.Text);
			decimal Reserve=decimal.Parse(this.txtReserve.Text);
			string Sex=this.txtSex.Text;
			int Populace=int.Parse(this.txtPopulace.Text);
			string Remark=this.txtRemark.Text;
			int Mark=int.Parse(this.txtMark.Text);
			string DeptID=this.txtDeptID.Text;
			string UserFloor=this.txtUserFloor.Text;
			string HouseDir=this.txtHouseDir.Text;
			string UserType=this.txtUserType.Text;
			string ClientId=this.txtClientId.Text;
			decimal Remnant=decimal.Parse(this.txtRemnant.Text);
			decimal Remnant2=decimal.Parse(this.txtRemnant2.Text);
			decimal Remnant3=decimal.Parse(this.txtRemnant3.Text);
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);
			string RegistPhone=this.txtRegistPhone.Text;
			int EInvoiceType=int.Parse(this.txtEInvoiceType.Text);


			WebDemo.Model.WebDemo.users model=new WebDemo.Model.WebDemo.users();
			model.UsersID=UsersID;
			model.UserCode=UserCode;
			model.UserName=UserName;
			model.Doorplate=Doorplate;
			model.PaperType=PaperType;
			model.PaperNo=PaperNo;
			model.Address=Address;
			model.Phone=Phone;
			model.Tel=Tel;
			model.Acreage=Acreage;
			model.ChargeAcreage=ChargeAcreage;
			model.Reserve=Reserve;
			model.Sex=Sex;
			model.Populace=Populace;
			model.Remark=Remark;
			model.Mark=Mark;
			model.DeptID=DeptID;
			model.UserFloor=UserFloor;
			model.HouseDir=HouseDir;
			model.UserType=UserType;
			model.ClientId=ClientId;
			model.Remnant=Remnant;
			model.Remnant2=Remnant2;
			model.Remnant3=Remnant3;
			model.UpdateTime=UpdateTime;
			model.RegistPhone=RegistPhone;
			model.EInvoiceType=EInvoiceType;

			WebDemo.BLL.WebDemo.users bll=new WebDemo.BLL.WebDemo.users();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
