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
namespace WebDemo.Web.WebDemo.HostsCH
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtHostID.Text))
			{
				strErr+="HostID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtChNo.Text))
			{
				strErr+="ChNo格式错误！\\n";	
			}
			if(this.txtFactCode.Text.Trim().Length==0)
			{
				strErr+="FactCode不能为空！\\n";	
			}
			if(this.txtDataID.Text.Trim().Length==0)
			{
				strErr+="DataID不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtChBand.Text))
			{
				strErr+="ChBand格式错误！\\n";	
			}
			if(this.txtChBtyeType.Text.Trim().Length==0)
			{
				strErr+="ChBtyeType不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int HostID=int.Parse(this.txtHostID.Text);
			int ChNo=int.Parse(this.txtChNo.Text);
			string FactCode=this.txtFactCode.Text;
			string DataID=this.txtDataID.Text;
			int ChBand=int.Parse(this.txtChBand.Text);
			string ChBtyeType=this.txtChBtyeType.Text;

			WebDemo.Model.WebDemo.HostsCH model=new WebDemo.Model.WebDemo.HostsCH();
			model.HostID=HostID;
			model.ChNo=ChNo;
			model.FactCode=FactCode;
			model.DataID=DataID;
			model.ChBand=ChBand;
			model.ChBtyeType=ChBtyeType;

			WebDemo.BLL.WebDemo.HostsCH bll=new WebDemo.BLL.WebDemo.HostsCH();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
