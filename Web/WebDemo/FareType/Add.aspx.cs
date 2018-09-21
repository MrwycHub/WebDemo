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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtFareTypeName.Text.Trim().Length==0)
			{
				strErr+="费用名称不能为空！\\n";	
			}
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
			string FareTypeName=this.txtFareTypeName.Text;
			string Remark=this.txtRemark.Text;
			int MeterTypeID=int.Parse(this.txtMeterTypeID.Text);

			WebDemo.Model.WebDemo.FareType model=new WebDemo.Model.WebDemo.FareType();
			model.FareTypeName=FareTypeName;
			model.Remark=Remark;
			model.MeterTypeID=MeterTypeID;

			WebDemo.BLL.WebDemo.FareType bll=new WebDemo.BLL.WebDemo.FareType();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
