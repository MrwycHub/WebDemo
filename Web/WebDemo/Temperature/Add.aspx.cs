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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtCentigrade.Text))
			{
				strErr+="Centigrade格式错误！\\n";	
			}
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
			decimal Centigrade=decimal.Parse(this.txtCentigrade.Text);
			decimal Density=decimal.Parse(this.txtDensity.Text);
			decimal Enthalpy=decimal.Parse(this.txtEnthalpy.Text);

			WebDemo.Model.WebDemo.Temperature model=new WebDemo.Model.WebDemo.Temperature();
			model.Centigrade=Centigrade;
			model.Density=Density;
			model.Enthalpy=Enthalpy;

			WebDemo.BLL.WebDemo.Temperature bll=new WebDemo.BLL.WebDemo.Temperature();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
