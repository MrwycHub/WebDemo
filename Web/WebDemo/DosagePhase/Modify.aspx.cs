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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		WebDemo.BLL.WebDemo.DosagePhase bll=new WebDemo.BLL.WebDemo.DosagePhase();
		WebDemo.Model.WebDemo.DosagePhase model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtPhaseTitle.Text=model.PhaseTitle;
		this.txtPhaseBNum.Text=model.PhaseBNum.ToString();
		this.txtPhaseENum.Text=model.PhaseENum.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int id=int.Parse(this.lblid.Text);
			string PhaseTitle=this.txtPhaseTitle.Text;
			decimal PhaseBNum=decimal.Parse(this.txtPhaseBNum.Text);
			decimal PhaseENum=decimal.Parse(this.txtPhaseENum.Text);


			WebDemo.Model.WebDemo.DosagePhase model=new WebDemo.Model.WebDemo.DosagePhase();
			model.id=id;
			model.PhaseTitle=PhaseTitle;
			model.PhaseBNum=PhaseBNum;
			model.PhaseENum=PhaseENum;

			WebDemo.BLL.WebDemo.DosagePhase bll=new WebDemo.BLL.WebDemo.DosagePhase();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
