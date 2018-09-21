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
namespace WebDemo.Web.WebDemo.Hosts
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int HostID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(HostID);
				}
			}
		}
			
	private void ShowInfo(int HostID)
	{
		WebDemo.BLL.WebDemo.Hosts bll=new WebDemo.BLL.WebDemo.Hosts();
		WebDemo.Model.WebDemo.Hosts model=bll.GetModel(HostID);
		this.txtCollectorID.Text=model.CollectorID.ToString();
		this.lblHostID.Text=model.HostID.ToString();
		this.txtHostName.Text=model.HostName;
		this.txtHostAddr.Text=model.HostAddr;
		this.txtRemark.Text=model.Remark;
		this.txtflag.Text=model.flag.ToString();
		this.txtLimitNum.Text=model.LimitNum.ToString();
		this.txtHostComType.Text=model.HostComType.ToString();
		this.txtHostType.Text=model.HostType.ToString();
		this.txtHostRDate.Text=model.HostRDate;
		this.txtDownloadFlag.Text=model.DownloadFlag.ToString();
		this.txtPowerType.Text=model.PowerType.ToString();
		this.txtHostNo.Text=model.HostNo.ToString();
		this.txtHostLimitNum.Text=model.HostLimitNum.ToString();
		this.txtIsRelay.Text=model.IsRelay.ToString();
		this.txtIsDownMeterType.Text=model.IsDownMeterType.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtCollectorID.Text))
			{
				strErr+="集中器编号格式错误！\\n";	
			}
			if(this.txtHostName.Text.Trim().Length==0)
			{
				strErr+="楼宇主机名称不能为空！\\n";	
			}
			if(this.txtHostAddr.Text.Trim().Length==0)
			{
				strErr+="地址不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注信息不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtflag.Text))
			{
				strErr+="flag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtLimitNum.Text))
			{
				strErr+="LimitNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtHostComType.Text))
			{
				strErr+="HostComType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtHostType.Text))
			{
				strErr+="HostType格式错误！\\n";	
			}
			if(this.txtHostRDate.Text.Trim().Length==0)
			{
				strErr+="HostRDate不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDownloadFlag.Text))
			{
				strErr+="DownloadFlag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPowerType.Text))
			{
				strErr+="PowerType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtHostNo.Text))
			{
				strErr+="HostNo格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtHostLimitNum.Text))
			{
				strErr+="HostLimitNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtIsRelay.Text))
			{
				strErr+="IsRelay格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtIsDownMeterType.Text))
			{
				strErr+="IsDownMeterType格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int CollectorID=int.Parse(this.txtCollectorID.Text);
			int HostID=int.Parse(this.lblHostID.Text);
			string HostName=this.txtHostName.Text;
			string HostAddr=this.txtHostAddr.Text;
			string Remark=this.txtRemark.Text;
			int flag=int.Parse(this.txtflag.Text);
			int LimitNum=int.Parse(this.txtLimitNum.Text);
			int HostComType=int.Parse(this.txtHostComType.Text);
			int HostType=int.Parse(this.txtHostType.Text);
			string HostRDate=this.txtHostRDate.Text;
			int DownloadFlag=int.Parse(this.txtDownloadFlag.Text);
			int PowerType=int.Parse(this.txtPowerType.Text);
			int HostNo=int.Parse(this.txtHostNo.Text);
			int HostLimitNum=int.Parse(this.txtHostLimitNum.Text);
			int IsRelay=int.Parse(this.txtIsRelay.Text);
			int IsDownMeterType=int.Parse(this.txtIsDownMeterType.Text);


			WebDemo.Model.WebDemo.Hosts model=new WebDemo.Model.WebDemo.Hosts();
			model.CollectorID=CollectorID;
			model.HostID=HostID;
			model.HostName=HostName;
			model.HostAddr=HostAddr;
			model.Remark=Remark;
			model.flag=flag;
			model.LimitNum=LimitNum;
			model.HostComType=HostComType;
			model.HostType=HostType;
			model.HostRDate=HostRDate;
			model.DownloadFlag=DownloadFlag;
			model.PowerType=PowerType;
			model.HostNo=HostNo;
			model.HostLimitNum=HostLimitNum;
			model.IsRelay=IsRelay;
			model.IsDownMeterType=IsDownMeterType;

			WebDemo.BLL.WebDemo.Hosts bll=new WebDemo.BLL.WebDemo.Hosts();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
