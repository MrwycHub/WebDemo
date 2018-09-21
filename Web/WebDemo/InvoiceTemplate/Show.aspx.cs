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
namespace WebDemo.Web.WebDemo.InvoiceTemplate
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		WebDemo.BLL.WebDemo.InvoiceTemplate bll=new WebDemo.BLL.WebDemo.InvoiceTemplate();
		WebDemo.Model.WebDemo.InvoiceTemplate model=bll.GetModel();
		this.lblTemplateID.Text=model.TemplateID.ToString();
		this.lblTemplateName.Text=model.TemplateName;
		this.lblTemplatePath.Text=model.TemplatePath;
		this.lblFlag.Text=model.Flag.ToString();
		this.lblTemplateFile.Text=model.TemplateFile.ToString();
		this.lblLastOperTime.Text=model.LastOperTime.ToString();
		this.lblLastOperatorId.Text=model.LastOperatorId.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}
