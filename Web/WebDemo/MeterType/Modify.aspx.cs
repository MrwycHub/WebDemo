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
namespace WebDemo.Web.WebDemo.MeterType
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int MeterTypeID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(MeterTypeID);
				}
			}
		}
			
	private void ShowInfo(int MeterTypeID)
	{
		WebDemo.BLL.WebDemo.MeterType bll=new WebDemo.BLL.WebDemo.MeterType();
		WebDemo.Model.WebDemo.MeterType model=bll.GetModel(MeterTypeID);
		this.lblMeterTypeID.Text=model.MeterTypeID.ToString();
		this.txtMeterTypeName.Text=model.MeterTypeName;
		this.txtRemark.Text=model.Remark;
		this.txtFlag.Text=model.Flag.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMeterTypeName.Text.Trim().Length==0)
			{
				strErr+="表类型名称不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注信息不能为空！\\n";	
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
			int MeterTypeID=int.Parse(this.lblMeterTypeID.Text);
			string MeterTypeName=this.txtMeterTypeName.Text;
			string Remark=this.txtRemark.Text;
			int Flag=int.Parse(this.txtFlag.Text);


			WebDemo.Model.WebDemo.MeterType model=new WebDemo.Model.WebDemo.MeterType();
			model.MeterTypeID=MeterTypeID;
			model.MeterTypeName=MeterTypeName;
			model.Remark=Remark;
			model.Flag=Flag;

			WebDemo.BLL.WebDemo.MeterType bll=new WebDemo.BLL.WebDemo.MeterType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
