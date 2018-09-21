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
namespace WebDemo.Web.WebDemo.LocationInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		WebDemo.BLL.WebDemo.LocationInfo bll=new WebDemo.BLL.WebDemo.LocationInfo();
		WebDemo.Model.WebDemo.LocationInfo model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtOperatorID.Text=model.OperatorID.ToString();
		this.txtDateTime.Text=model.DateTime.ToString();
		this.txtLocationX.Text=model.LocationX.ToString();
		this.txtLocationY.Text=model.LocationY.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtOperatorID.Text))
			{
				strErr+="OperatorID格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDateTime.Text))
			{
				strErr+="DateTime格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLocationX.Text))
			{
				strErr+="LocationX格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLocationY.Text))
			{
				strErr+="LocationY格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int OperatorID=int.Parse(this.txtOperatorID.Text);
			DateTime DateTime=DateTime.Parse(this.txtDateTime.Text);
			decimal LocationX=decimal.Parse(this.txtLocationX.Text);
			decimal LocationY=decimal.Parse(this.txtLocationY.Text);


			WebDemo.Model.WebDemo.LocationInfo model=new WebDemo.Model.WebDemo.LocationInfo();
			model.ID=ID;
			model.OperatorID=OperatorID;
			model.DateTime=DateTime;
			model.LocationX=LocationX;
			model.LocationY=LocationY;

			WebDemo.BLL.WebDemo.LocationInfo bll=new WebDemo.BLL.WebDemo.LocationInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
