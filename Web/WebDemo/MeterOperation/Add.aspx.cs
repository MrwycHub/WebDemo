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
namespace WebDemo.Web.WebDemo.MeterOperation
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtOperType.Text.Trim().Length==0)
			{
				strErr+="业务类型不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperDate.Text))
			{
				strErr+="业务日期格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterIDOld.Text))
			{
				strErr+="老表ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterIDNew.Text))
			{
				strErr+="新表ID格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtUseNumberOld.Text))
			{
				strErr+="UseNumberOld格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtStatFlag.Text))
			{
				strErr+="StatFlag格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string OperType=this.txtOperType.Text;
			DateTime OperDate=DateTime.Parse(this.txtOperDate.Text);
			int MeterIDOld=int.Parse(this.txtMeterIDOld.Text);
			int MeterIDNew=int.Parse(this.txtMeterIDNew.Text);
			decimal UseNumberOld=decimal.Parse(this.txtUseNumberOld.Text);
			int StatFlag=int.Parse(this.txtStatFlag.Text);

			WebDemo.Model.WebDemo.MeterOperation model=new WebDemo.Model.WebDemo.MeterOperation();
			model.OperType=OperType;
			model.OperDate=OperDate;
			model.MeterIDOld=MeterIDOld;
			model.MeterIDNew=MeterIDNew;
			model.UseNumberOld=UseNumberOld;
			model.StatFlag=StatFlag;

			WebDemo.BLL.WebDemo.MeterOperation bll=new WebDemo.BLL.WebDemo.MeterOperation();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
