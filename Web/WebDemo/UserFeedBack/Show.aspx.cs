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
namespace WebDemo.Web.WebDemo.UserFeedBack
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
		WebDemo.BLL.WebDemo.UserFeedBack bll=new WebDemo.BLL.WebDemo.UserFeedBack();
		WebDemo.Model.WebDemo.UserFeedBack model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblUserCode.Text=model.UserCode;
		this.lblContactWay.Text=model.ContactWay;
		this.lblPhone.Text=model.Phone;
		this.lblContent.Text=model.Content;
		this.lblPublishDate.Text=model.PublishDate.ToString();
		this.lblReplyMan.Text=model.ReplyMan;
		this.lblReplyContent.Text=model.ReplyContent;
		this.lblReplyDate.Text=model.ReplyDate.ToString();
		this.lblFlag.Text=model.Flag.ToString();
		this.lblTypeId.Text=model.TypeId.ToString();
		this.lblContact.Text=model.Contact;
		this.lblReplyFlag.Text=model.ReplyFlag.ToString();

	}


    }
}
