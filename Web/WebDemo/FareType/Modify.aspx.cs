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
namespace WebDemo.Web.WebDemo.FareType
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int FareTypeID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(FareTypeID);
				}
			}
		}
			
	private void ShowInfo(int FareTypeID)
	{
		WebDemo.BLL.WebDemo.FareType bll=new WebDemo.BLL.WebDemo.FareType();
		WebDemo.Model.WebDemo.FareType model=bll.GetModel(FareTypeID);
		this.lblFareTypeID.Text=model.FareTypeID.ToString();
		this.lblFareTypeName.Text=model.FareTypeName;
		this.txtRemark.Text=model.Remark;
		this.txtMeterTypeID.Text=model.MeterTypeID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注信息不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterTypeID.Text))
			{
				strErr+="MeterTypeID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int FareTypeID=int.Parse(this.lblFareTypeID.Text);
			string FareTypeName=this.lblFareTypeName.Text;
			string Remark=this.txtRemark.Text;
			int MeterTypeID=int.Parse(this.txtMeterTypeID.Text);


			WebDemo.Model.WebDemo.FareType model=new WebDemo.Model.WebDemo.FareType();
			model.FareTypeID=FareTypeID;
			model.FareTypeName=FareTypeName;
			model.Remark=Remark;
			model.MeterTypeID=MeterTypeID;

			WebDemo.BLL.WebDemo.FareType bll=new WebDemo.BLL.WebDemo.FareType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
