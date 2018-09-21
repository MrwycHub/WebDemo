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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			int MeterID=int.Parse(this.txtMeterID.Text);
			int FareID=int.Parse(this.txtFareID.Text);
			int FareNum=int.Parse(this.txtFareNum.Text);
			string Remark=this.txtRemark.Text;
			int Flag=int.Parse(this.txtFlag.Text);

			WebDemo.Model.WebDemo.Otherfare model=new WebDemo.Model.WebDemo.Otherfare();
			model.MeterID=MeterID;
			model.FareID=FareID;
			model.FareNum=FareNum;
			model.Remark=Remark;
			model.Flag=Flag;

			WebDemo.BLL.WebDemo.Otherfare bll=new WebDemo.BLL.WebDemo.Otherfare();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
