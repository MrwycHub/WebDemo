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
namespace WebDemo.Web.WebDemo.NoteBookGroup
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
					int GroupID=(Convert.ToInt32(strid));
					ShowInfo(GroupID);
				}
			}
		}
		
	private void ShowInfo(int GroupID)
	{
		WebDemo.BLL.WebDemo.NoteBookGroup bll=new WebDemo.BLL.WebDemo.NoteBookGroup();
		WebDemo.Model.WebDemo.NoteBookGroup model=bll.GetModel(GroupID);
		this.lblGroupID.Text=model.GroupID.ToString();
		this.lblNoteBookID.Text=model.NoteBookID;
		this.lblGroupName.Text=model.GroupName;
		this.lblLimitNum.Text=model.LimitNum.ToString();
		this.lblReMark.Text=model.ReMark;

	}


    }
}
