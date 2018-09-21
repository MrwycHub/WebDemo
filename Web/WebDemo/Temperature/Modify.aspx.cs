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
namespace WebDemo.Web.WebDemo.Temperature
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					decimal Centigrade=(Convert.ToDecimal(Request.Params["id"]));
					ShowInfo(Centigrade);
				}
			}
		}
			
	private void ShowInfo(decimal Centigrade)
	{
		WebDemo.BLL.WebDemo.Temperature bll=new WebDemo.BLL.WebDemo.Temperature();
		WebDemo.Model.WebDemo.Temperature model=bll.GetModel(Centigrade);
		this.lblCentigrade.Text=model.Centigrade.ToString();
		this.txtDensity.Text=model.Density.ToString();
		this.txtEnthalpy.Text=model.Enthalpy.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtDensity.Text))
			{
				strErr+="Density格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtEnthalpy.Text))
			{
				strErr+="Enthalpy格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			decimal Centigrade=decimal.Parse(this.lblCentigrade.Text);
			decimal Density=decimal.Parse(this.txtDensity.Text);
			decimal Enthalpy=decimal.Parse(this.txtEnthalpy.Text);


			WebDemo.Model.WebDemo.Temperature model=new WebDemo.Model.WebDemo.Temperature();
			model.Centigrade=Centigrade;
			model.Density=Density;
			model.Enthalpy=Enthalpy;

			WebDemo.BLL.WebDemo.Temperature bll=new WebDemo.BLL.WebDemo.Temperature();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
