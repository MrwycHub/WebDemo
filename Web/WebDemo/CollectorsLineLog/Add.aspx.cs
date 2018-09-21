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
namespace WebDemo.Web.WebDemo.CollectorsLineLog
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtCollectorID.Text))
			{
				strErr+="CollectorID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtLineType.Text))
			{
				strErr+="LineType格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtOperTime.Text))
			{
				strErr+="OperTime格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int CollectorID=int.Parse(this.txtCollectorID.Text);
			int LineType=int.Parse(this.txtLineType.Text);
			DateTime OperTime=DateTime.Parse(this.txtOperTime.Text);
			string Remark=this.txtRemark.Text;

			WebDemo.Model.WebDemo.CollectorsLineLog model=new WebDemo.Model.WebDemo.CollectorsLineLog();
			model.CollectorID=CollectorID;
			model.LineType=LineType;
			model.OperTime=OperTime;
			model.Remark=Remark;

			WebDemo.BLL.WebDemo.CollectorsLineLog bll=new WebDemo.BLL.WebDemo.CollectorsLineLog();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
