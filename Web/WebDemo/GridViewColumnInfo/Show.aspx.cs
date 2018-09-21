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
namespace WebDemo.Web.WebDemo.GridViewColumnInfo
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
					int Id=(Convert.ToInt32(strid));
					ShowInfo(Id);
				}
			}
		}
		
	private void ShowInfo(int Id)
	{
		WebDemo.BLL.WebDemo.GridViewColumnInfo bll=new WebDemo.BLL.WebDemo.GridViewColumnInfo();
		WebDemo.Model.WebDemo.GridViewColumnInfo model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.lblGridViewTypeID.Text=model.GridViewTypeID.ToString();
		this.lblColumnID.Text=model.ColumnID.ToString();
		this.lblDataField.Text=model.DataField;
		this.lblHeaderText.Text=model.HeaderText;
		this.lblDataFormat.Text=model.DataFormat;
		this.lblSortExpression.Text=model.SortExpression;
		this.lblIsEdit.Text=model.IsEdit?"是":"否";
		this.lblIsShow.Text=model.IsShow?"是":"否";
		this.lblOrderNum.Text=model.OrderNum.ToString();
		this.lblOperatorID.Text=model.OperatorID.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}
