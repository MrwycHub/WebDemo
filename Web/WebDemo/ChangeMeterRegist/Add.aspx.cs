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
namespace WebDemo.Web.WebDemo.ChangeMeterRegist
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUsersID.Text))
			{
				strErr+="UsersID格式错误！\\n";	
			}
			if(this.txtUserCode.Text.Trim().Length==0)
			{
				strErr+="UserCode不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOldNumber.Text))
			{
				strErr+="OldNumber格式错误！\\n";	
			}
			if(this.txtNewMeterAddr.Text.Trim().Length==0)
			{
				strErr+="NewMeterAddr不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtStatus.Text))
			{
				strErr+="Status格式错误！\\n";	
			}
			if(this.txtImagePath.Text.Trim().Length==0)
			{
				strErr+="ImagePath不能为空！\\n";	
			}
			if(this.txtOperatorCode.Text.Trim().Length==0)
			{
				strErr+="OperatorCode不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtNewNumber.Text))
			{
				strErr+="NewNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtNewMeterId.Text))
			{
				strErr+="NewMeterId格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtInsertDate.Text))
			{
				strErr+="InsertDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtChangeMeterDate.Text))
			{
				strErr+="ChangeMeterDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterID.Text))
			{
				strErr+="MeterID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int UsersID=int.Parse(this.txtUsersID.Text);
			string UserCode=this.txtUserCode.Text;
			decimal OldNumber=decimal.Parse(this.txtOldNumber.Text);
			string NewMeterAddr=this.txtNewMeterAddr.Text;
			string Remark=this.txtRemark.Text;
			int Status=int.Parse(this.txtStatus.Text);
			string ImagePath=this.txtImagePath.Text;
			string OperatorCode=this.txtOperatorCode.Text;
			decimal NewNumber=decimal.Parse(this.txtNewNumber.Text);
			int NewMeterId=int.Parse(this.txtNewMeterId.Text);
			DateTime InsertDate=DateTime.Parse(this.txtInsertDate.Text);
			DateTime ChangeMeterDate=DateTime.Parse(this.txtChangeMeterDate.Text);
			int MeterID=int.Parse(this.txtMeterID.Text);

			WebDemo.Model.WebDemo.ChangeMeterRegist model=new WebDemo.Model.WebDemo.ChangeMeterRegist();
			model.UsersID=UsersID;
			model.UserCode=UserCode;
			model.OldNumber=OldNumber;
			model.NewMeterAddr=NewMeterAddr;
			model.Remark=Remark;
			model.Status=Status;
			model.ImagePath=ImagePath;
			model.OperatorCode=OperatorCode;
			model.NewNumber=NewNumber;
			model.NewMeterId=NewMeterId;
			model.InsertDate=InsertDate;
			model.ChangeMeterDate=ChangeMeterDate;
			model.MeterID=MeterID;

			WebDemo.BLL.WebDemo.ChangeMeterRegist bll=new WebDemo.BLL.WebDemo.ChangeMeterRegist();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
