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
namespace WebDemo.Web.WebDemo.BalanceNodeInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtOperatorId.Text))
			{
				strErr+="OperatorId格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBeginDate.Text))
			{
				strErr+="BeginDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEndDate.Text))
			{
				strErr+="EndDate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtFactMoney.Text))
			{
				strErr+="FactMoney格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPayCount.Text))
			{
				strErr+="PayCount格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int OperatorId=int.Parse(this.txtOperatorId.Text);
			DateTime BeginDate=DateTime.Parse(this.txtBeginDate.Text);
			DateTime EndDate=DateTime.Parse(this.txtEndDate.Text);
			decimal FactMoney=decimal.Parse(this.txtFactMoney.Text);
			int PayCount=int.Parse(this.txtPayCount.Text);

			WebDemo.Model.WebDemo.BalanceNodeInfo model=new WebDemo.Model.WebDemo.BalanceNodeInfo();
			model.OperatorId=OperatorId;
			model.BeginDate=BeginDate;
			model.EndDate=EndDate;
			model.FactMoney=FactMoney;
			model.PayCount=PayCount;

			WebDemo.BLL.WebDemo.BalanceNodeInfo bll=new WebDemo.BLL.WebDemo.BalanceNodeInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
