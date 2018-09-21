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
namespace WebDemo.Web.WebDemo.Otherfare
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int OtherID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(OtherID);
				}
			}
		}
			
	private void ShowInfo(int OtherID)
	{
		WebDemo.BLL.WebDemo.Otherfare bll=new WebDemo.BLL.WebDemo.Otherfare();
		WebDemo.Model.WebDemo.Otherfare model=bll.GetModel(OtherID);
		this.lblOtherID.Text=model.OtherID.ToString();
		this.txtMeterID.Text=model.MeterID.ToString();
		this.txtFareID.Text=model.FareID.ToString();
		this.txtFareNum.Text=model.FareNum.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtFlag.Text=model.Flag.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFareID.Text))
			{
				strErr+="FareID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFareNum.Text))
			{
				strErr+="FareNum格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFlag.Text))
			{
				strErr+="Flag格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OtherID=int.Parse(this.lblOtherID.Text);
			int MeterID=int.Parse(this.txtMeterID.Text);
			int FareID=int.Parse(this.txtFareID.Text);
			int FareNum=int.Parse(this.txtFareNum.Text);
			string Remark=this.txtRemark.Text;
			int Flag=int.Parse(this.txtFlag.Text);


			WebDemo.Model.WebDemo.Otherfare model=new WebDemo.Model.WebDemo.Otherfare();
			model.OtherID=OtherID;
			model.MeterID=MeterID;
			model.FareID=FareID;
			model.FareNum=FareNum;
			model.Remark=Remark;
			model.Flag=Flag;

			WebDemo.BLL.WebDemo.Otherfare bll=new WebDemo.BLL.WebDemo.Otherfare();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
