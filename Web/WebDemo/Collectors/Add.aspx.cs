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
namespace WebDemo.Web.WebDemo.Collectors
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtCollectorID.Text))
			{
				strErr+="集中器编号格式错误！\\n";	
			}
			if(this.txtCollectorName.Text.Trim().Length==0)
			{
				strErr+="集中器名称不能为空！\\n";	
			}
			if(this.txtCollectorAddr.Text.Trim().Length==0)
			{
				strErr+="集中器地址不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCollectorType.Text))
			{
				strErr+="集中器类型(1-电话线方式；2格式错误！\\n";	
			}
			if(this.txtDeptID.Text.Trim().Length==0)
			{
				strErr+="部门编号不能为空！\\n";	
			}
			if(this.txtPhoneNumber.Text.Trim().Length==0)
			{
				strErr+="电话号码(电话线方式时使用)不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtCollOverTime.Text))
			{
				strErr+="超时时间格式错误！\\n";	
			}
			if(this.txtIPNumber.Text.Trim().Length==0)
			{
				strErr+="IP地址(以太网方式时使用)不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPortNumber.Text))
			{
				strErr+="端口号(以太网方式时使用)格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtGprsCycle.Text))
			{
				strErr+="Gprs心跳周期格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFreezeDay.Text))
			{
				strErr+="冻结日格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFreezeHour.Text))
			{
				strErr+="冻结时格式错误！\\n";	
			}
			if(this.txtReadDay.Text.Trim().Length==0)
			{
				strErr+="抄表日不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLoginDate.Text))
			{
				strErr+="登录时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUpdateDate.Text))
			{
				strErr+="更新时间格式错误！\\n";	
			}
			if(this.txtLoginIP.Text.Trim().Length==0)
			{
				strErr+="登录IP不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtLoginPort.Text))
			{
				strErr+="登录端口格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMark.Text))
			{
				strErr+="终端状态(0-离线；1-在线)格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注信息不能为空！\\n";	
			}
			if(this.txtCollectorVer.Text.Trim().Length==0)
			{
				strErr+="集中器版本不能为空！\\n";	
			}
			if(this.txtCollectorModel.Text.Trim().Length==0)
			{
				strErr+="集中器型号不能为空！\\n";	
			}
			if(this.txtCollectorAPN.Text.Trim().Length==0)
			{
				strErr+="CollectorAPN不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtIsServerMode.Text))
			{
				strErr+="IsServerMode格式错误！\\n";	
			}
			if(this.txtWorkTime.Text.Trim().Length==0)
			{
				strErr+="WorkTime不能为空！\\n";	
			}
			if(this.txtNetWorkTime.Text.Trim().Length==0)
			{
				strErr+="NetWorkTime不能为空！\\n";	
			}
			if(this.txtFactoryCode.Text.Trim().Length==0)
			{
				strErr+="FactoryCode不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtFramesType.Text))
			{
				strErr+="FramesType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMeterAddrFormat.Text))
			{
				strErr+="MeterAddrFormat格式错误！\\n";	
			}
			if(this.txtGprsPhone.Text.Trim().Length==0)
			{
				strErr+="GprsPhone不能为空！\\n";	
			}
			if(this.txtExpireTime.Text.Trim().Length==0)
			{
				strErr+="ExpireTime不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtWorkMode.Text))
			{
				strErr+="WorkMode格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLng.Text))
			{
				strErr+="Lng格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLat.Text))
			{
				strErr+="Lat格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int CollectorID=int.Parse(this.txtCollectorID.Text);
			string CollectorName=this.txtCollectorName.Text;
			string CollectorAddr=this.txtCollectorAddr.Text;
			int CollectorType=int.Parse(this.txtCollectorType.Text);
			string DeptID=this.txtDeptID.Text;
			string PhoneNumber=this.txtPhoneNumber.Text;
			int CollOverTime=int.Parse(this.txtCollOverTime.Text);
			string IPNumber=this.txtIPNumber.Text;
			int PortNumber=int.Parse(this.txtPortNumber.Text);
			int GprsCycle=int.Parse(this.txtGprsCycle.Text);
			int FreezeDay=int.Parse(this.txtFreezeDay.Text);
			int FreezeHour=int.Parse(this.txtFreezeHour.Text);
			string ReadDay=this.txtReadDay.Text;
			DateTime LoginDate=DateTime.Parse(this.txtLoginDate.Text);
			DateTime UpdateDate=DateTime.Parse(this.txtUpdateDate.Text);
			string LoginIP=this.txtLoginIP.Text;
			int LoginPort=int.Parse(this.txtLoginPort.Text);
			int Mark=int.Parse(this.txtMark.Text);
			string Remark=this.txtRemark.Text;
			string CollectorVer=this.txtCollectorVer.Text;
			string CollectorModel=this.txtCollectorModel.Text;
			string CollectorAPN=this.txtCollectorAPN.Text;
			int IsServerMode=int.Parse(this.txtIsServerMode.Text);
			string WorkTime=this.txtWorkTime.Text;
			string NetWorkTime=this.txtNetWorkTime.Text;
			string FactoryCode=this.txtFactoryCode.Text;
			int FramesType=int.Parse(this.txtFramesType.Text);
			int MeterAddrFormat=int.Parse(this.txtMeterAddrFormat.Text);
			string GprsPhone=this.txtGprsPhone.Text;
			string ExpireTime=this.txtExpireTime.Text;
			int WorkMode=int.Parse(this.txtWorkMode.Text);
			decimal Lng=decimal.Parse(this.txtLng.Text);
			decimal Lat=decimal.Parse(this.txtLat.Text);

			WebDemo.Model.WebDemo.Collectors model=new WebDemo.Model.WebDemo.Collectors();
			model.CollectorID=CollectorID;
			model.CollectorName=CollectorName;
			model.CollectorAddr=CollectorAddr;
			model.CollectorType=CollectorType;
			model.DeptID=DeptID;
			model.PhoneNumber=PhoneNumber;
			model.CollOverTime=CollOverTime;
			model.IPNumber=IPNumber;
			model.PortNumber=PortNumber;
			model.GprsCycle=GprsCycle;
			model.FreezeDay=FreezeDay;
			model.FreezeHour=FreezeHour;
			model.ReadDay=ReadDay;
			model.LoginDate=LoginDate;
			model.UpdateDate=UpdateDate;
			model.LoginIP=LoginIP;
			model.LoginPort=LoginPort;
			model.Mark=Mark;
			model.Remark=Remark;
			model.CollectorVer=CollectorVer;
			model.CollectorModel=CollectorModel;
			model.CollectorAPN=CollectorAPN;
			model.IsServerMode=IsServerMode;
			model.WorkTime=WorkTime;
			model.NetWorkTime=NetWorkTime;
			model.FactoryCode=FactoryCode;
			model.FramesType=FramesType;
			model.MeterAddrFormat=MeterAddrFormat;
			model.GprsPhone=GprsPhone;
			model.ExpireTime=ExpireTime;
			model.WorkMode=WorkMode;
			model.Lng=Lng;
			model.Lat=Lat;

			WebDemo.BLL.WebDemo.Collectors bll=new WebDemo.BLL.WebDemo.Collectors();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
