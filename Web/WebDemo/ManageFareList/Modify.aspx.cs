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
namespace WebDemo.Web.WebDemo.ManageFareList
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
			
	private void ShowInfo()
	{
		WebDemo.BLL.WebDemo.ManageFareList bll=new WebDemo.BLL.WebDemo.ManageFareList();
		WebDemo.Model.WebDemo.ManageFareList model=bll.GetModel();
		this.txtUsersID.Text=model.UsersID.ToString();
		this.txtManageFareID.Text=model.ManageFareID.ToString();
		this.txtLastMonth.Text=model.LastMonth;
		this.txtThisMonth.Text=model.ThisMonth;
		this.txtManageFarePrice.Text=model.ManageFarePrice.ToString();
		this.txtOperMoney.Text=model.OperMoney.ToString();
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtOperDate.Text=model.OperDate.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtOperID.Text=model.OperID.ToString();
		this.txtOperType.Text=model.OperType.ToString();
		this.txtRcvFareNum.Text=model.RcvFareNum.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUsersID.Text))
			{
				strErr+="UsersID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtManageFareID.Text))
			{
				strErr+="ManageFareID格式错误！\\n";	
			}
			if(this.txtLastMonth.Text.Trim().Length==0)
			{
				strErr+="LastMonth不能为空！\\n";	
			}
			if(this.txtThisMonth.Text.Trim().Length==0)
			{
				strErr+="ThisMonth不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtManageFarePrice.Text))
			{
				strErr+="ManageFarePrice格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOperMoney.Text))
			{
				strErr+="OperMoney格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="OperDate格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperID.Text))
			{
				strErr+="OperID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtOperType.Text))
			{
				strErr+="OperType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRcvFareNum.Text))
			{
				strErr+="RcvFareNum格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UsersID=int.Parse(this.txtUsersID.Text);
			int ManageFareID=int.Parse(this.txtManageFareID.Text);
			string LastMonth=this.txtLastMonth.Text;
			string ThisMonth=this.txtThisMonth.Text;
			decimal ManageFarePrice=decimal.Parse(this.txtManageFarePrice.Text);
			decimal OperMoney=decimal.Parse(this.txtOperMoney.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			string Remark=this.txtRemark.Text;
			int OperID=int.Parse(this.txtOperID.Text);
			int OperType=int.Parse(this.txtOperType.Text);
			int RcvFareNum=int.Parse(this.txtRcvFareNum.Text);


			WebDemo.Model.WebDemo.ManageFareList model=new WebDemo.Model.WebDemo.ManageFareList();
			model.UsersID=UsersID;
			model.ManageFareID=ManageFareID;
			model.LastMonth=LastMonth;
			model.ThisMonth=ThisMonth;
			model.ManageFarePrice=ManageFarePrice;
			model.OperMoney=OperMoney;
			model.OperatorID=OperatorID;
			model.OperDate=OperDate;
			model.Remark=Remark;
			model.OperID=OperID;
			model.OperType=OperType;
			model.RcvFareNum=RcvFareNum;

			WebDemo.BLL.WebDemo.ManageFareList bll=new WebDemo.BLL.WebDemo.ManageFareList();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
