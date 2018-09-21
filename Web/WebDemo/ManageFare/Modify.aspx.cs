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
namespace WebDemo.Web.WebDemo.ManageFare
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ManageFareID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ManageFareID);
				}
			}
		}
			
	private void ShowInfo(int ManageFareID)
	{
		WebDemo.BLL.WebDemo.ManageFare bll=new WebDemo.BLL.WebDemo.ManageFare();
		WebDemo.Model.WebDemo.ManageFare model=bll.GetModel(ManageFareID);
		this.lblManageFareID.Text=model.ManageFareID.ToString();
		this.txtManageFareName.Text=model.ManageFareName;
		this.txtManageFarePrice.Text=model.ManageFarePrice.ToString();
		this.txtManageFareTypeID.Text=model.ManageFareTypeID.ToString();
		this.txtReMark.Text=model.ReMark;
		this.txtSystemNum.Text=model.SystemNum.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtManageFareName.Text.Trim().Length==0)
			{
				strErr+="ManageFareName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtManageFarePrice.Text))
			{
				strErr+="ManageFarePrice格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtManageFareTypeID.Text))
			{
				strErr+="ManageFareTypeID格式错误！\\n";	
			}
			if(this.txtReMark.Text.Trim().Length==0)
			{
				strErr+="ReMark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSystemNum.Text))
			{
				strErr+="SystemNum格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ManageFareID=int.Parse(this.lblManageFareID.Text);
			string ManageFareName=this.txtManageFareName.Text;
			decimal ManageFarePrice=decimal.Parse(this.txtManageFarePrice.Text);
			int ManageFareTypeID=int.Parse(this.txtManageFareTypeID.Text);
			string ReMark=this.txtReMark.Text;
			int SystemNum=int.Parse(this.txtSystemNum.Text);


			WebDemo.Model.WebDemo.ManageFare model=new WebDemo.Model.WebDemo.ManageFare();
			model.ManageFareID=ManageFareID;
			model.ManageFareName=ManageFareName;
			model.ManageFarePrice=ManageFarePrice;
			model.ManageFareTypeID=ManageFareTypeID;
			model.ReMark=ReMark;
			model.SystemNum=SystemNum;

			WebDemo.BLL.WebDemo.ManageFare bll=new WebDemo.BLL.WebDemo.ManageFare();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
