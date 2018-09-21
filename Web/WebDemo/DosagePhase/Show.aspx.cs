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
namespace WebDemo.Web.WebDemo.DosagePhase
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		WebDemo.BLL.WebDemo.DosagePhase bll=new WebDemo.BLL.WebDemo.DosagePhase();
		WebDemo.Model.WebDemo.DosagePhase model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblPhaseTitle.Text=model.PhaseTitle;
		this.lblPhaseBNum.Text=model.PhaseBNum.ToString();
		this.lblPhaseENum.Text=model.PhaseENum.ToString();

	}


    }
}
