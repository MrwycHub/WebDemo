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
namespace WebDemo.Web.WebDemo.ClientSoftInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDanWeiName.Text.Trim().Length==0)
			{
				strErr+="DanWeiName不能为空！\\n";	
			}
			if(this.txtJiQiMa.Text.Trim().Length==0)
			{
				strErr+="JiQiMa不能为空！\\n";	
			}
			if(this.txtRenZhengMa.Text.Trim().Length==0)
			{
				strErr+="RenZhengMa不能为空！\\n";	
			}
			if(this.txtSoftName.Text.Trim().Length==0)
			{
				strErr+="SoftName不能为空！\\n";	
			}
			if(this.txtSoftHao.Text.Trim().Length==0)
			{
				strErr+="SoftHao不能为空！\\n";	
			}
			if(this.txtUsePassword.Text.Trim().Length==0)
			{
				strErr+="UsePassword不能为空！\\n";	
			}
			if(this.txtJieTiCalDate.Text.Trim().Length==0)
			{
				strErr+="JieTiCalDate不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSqlVersion.Text))
			{
				strErr+="SqlVersion格式错误！\\n";	
			}
			if(this.txtMeterTypes.Text.Trim().Length==0)
			{
				strErr+="MeterTypes不能为空！\\n";	
			}
			if(this.txtCardTypes.Text.Trim().Length==0)
			{
				strErr+="CardTypes不能为空！\\n";	
			}
			if(this.txtPayTypes.Text.Trim().Length==0)
			{
				strErr+="PayTypes不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateTime.Text))
			{
				strErr+="UpdateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string DanWeiName=this.txtDanWeiName.Text;
			string JiQiMa=this.txtJiQiMa.Text;
			string RenZhengMa=this.txtRenZhengMa.Text;
			string SoftName=this.txtSoftName.Text;
			string SoftHao=this.txtSoftHao.Text;
			string UsePassword=this.txtUsePassword.Text;
			string JieTiCalDate=this.txtJieTiCalDate.Text;
			int SqlVersion=int.Parse(this.txtSqlVersion.Text);
			string MeterTypes=this.txtMeterTypes.Text;
			string CardTypes=this.txtCardTypes.Text;
			string PayTypes=this.txtPayTypes.Text;
			DateTime UpdateTime=DateTime.Parse(this.txtUpdateTime.Text);

			WebDemo.Model.WebDemo.ClientSoftInfo model=new WebDemo.Model.WebDemo.ClientSoftInfo();
			model.DanWeiName=DanWeiName;
			model.JiQiMa=JiQiMa;
			model.RenZhengMa=RenZhengMa;
			model.SoftName=SoftName;
			model.SoftHao=SoftHao;
			model.UsePassword=UsePassword;
			model.JieTiCalDate=JieTiCalDate;
			model.SqlVersion=SqlVersion;
			model.MeterTypes=MeterTypes;
			model.CardTypes=CardTypes;
			model.PayTypes=PayTypes;
			model.UpdateTime=UpdateTime;

			WebDemo.BLL.WebDemo.ClientSoftInfo bll=new WebDemo.BLL.WebDemo.ClientSoftInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
