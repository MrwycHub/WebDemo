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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtMeterTypeID.Text))
			{
				strErr+="表类型编号格式错误！\\n";	
			}
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
			int MeterTypeID=int.Parse(this.txtMeterTypeID.Text);
			string MeterTypeName=this.txtMeterTypeName.Text;
			string Remark=this.txtRemark.Text;
			int Flag=int.Parse(this.txtFlag.Text);

			WebDemo.Model.WebDemo.MeterType model=new WebDemo.Model.WebDemo.MeterType();
			model.MeterTypeID=MeterTypeID;
			model.MeterTypeName=MeterTypeName;
			model.Remark=Remark;
			model.Flag=Flag;

			WebDemo.BLL.WebDemo.MeterType bll=new WebDemo.BLL.WebDemo.MeterType();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
