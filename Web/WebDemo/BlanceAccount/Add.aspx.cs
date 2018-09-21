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
namespace WebDemo.Web.WebDemo.BlanceAccount
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBlanceDate.Text.Trim().Length==0)
			{
				strErr+="BlanceDate不能为空！\\n";	
			}
			if(this.txtFailUserCode.Text.Trim().Length==0)
			{
				strErr+="FailUserCode不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFail.Text))
			{
				strErr+="Fail格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtAllCount.Text))
			{
				strErr+="AllCount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAllMoney.Text))
			{
				strErr+="AllMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtRefundMoney.Text))
			{
				strErr+="RefundMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBlanceTime.Text))
			{
				strErr+="BlanceTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string BlanceDate=this.txtBlanceDate.Text;
			string FailUserCode=this.txtFailUserCode.Text;
			int Fail=int.Parse(this.txtFail.Text);
			int AllCount=int.Parse(this.txtAllCount.Text);
			decimal AllMoney=decimal.Parse(this.txtAllMoney.Text);
			decimal RefundMoney=decimal.Parse(this.txtRefundMoney.Text);
			DateTime BlanceTime=DateTime.Parse(this.txtBlanceTime.Text);

			WebDemo.Model.WebDemo.BlanceAccount model=new WebDemo.Model.WebDemo.BlanceAccount();
			model.BlanceDate=BlanceDate;
			model.FailUserCode=FailUserCode;
			model.Fail=Fail;
			model.AllCount=AllCount;
			model.AllMoney=AllMoney;
			model.RefundMoney=RefundMoney;
			model.BlanceTime=BlanceTime;

			WebDemo.BLL.WebDemo.BlanceAccount bll=new WebDemo.BLL.WebDemo.BlanceAccount();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
