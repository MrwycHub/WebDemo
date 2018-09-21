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
namespace WebDemo.Web.WebDemo.Notebookpc
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
					string NoteBookID= strid;
					ShowInfo(NoteBookID);
				}
			}
		}
		
	private void ShowInfo(string NoteBookID)
	{
		WebDemo.BLL.WebDemo.Notebookpc bll=new WebDemo.BLL.WebDemo.Notebookpc();
		WebDemo.Model.WebDemo.Notebookpc model=bll.GetModel(NoteBookID);
		this.lblNoteBookID.Text=model.NoteBookID;
		this.lblNoteBookName.Text=model.NoteBookName;
		this.lblReMark.Text=model.ReMark;

	}


    }
}
