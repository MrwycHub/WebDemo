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
namespace WebDemo.Web.WebDemo.NoticeList
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
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.NoticeList bll=new WebDemo.BLL.WebDemo.NoticeList();
		WebDemo.Model.WebDemo.NoticeList model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblNoticeTitle.Text=model.NoticeTitle;
		this.lblNoticeInfo.Text=model.NoticeInfo;
		this.lblNoticeDate.Text=model.NoticeDate.ToString();
		this.lblAuthor.Text=model.Author;
		this.lblShowType.Text=model.ShowType.ToString();

	}


    }
}
