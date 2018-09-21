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
namespace WebDemo.Web.WebDemo.DosagePhase
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtPhaseTitle.Text.Trim().Length==0)
			{
				strErr+="PhaseTitle不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPhaseBNum.Text))
			{
				strErr+="PhaseBNum格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPhaseENum.Text))
			{
				strErr+="PhaseENum格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string PhaseTitle=this.txtPhaseTitle.Text;
			decimal PhaseBNum=decimal.Parse(this.txtPhaseBNum.Text);
			decimal PhaseENum=decimal.Parse(this.txtPhaseENum.Text);

			WebDemo.Model.WebDemo.DosagePhase model=new WebDemo.Model.WebDemo.DosagePhase();
			model.PhaseTitle=PhaseTitle;
			model.PhaseBNum=PhaseBNum;
			model.PhaseENum=PhaseENum;

			WebDemo.BLL.WebDemo.DosagePhase bll=new WebDemo.BLL.WebDemo.DosagePhase();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
