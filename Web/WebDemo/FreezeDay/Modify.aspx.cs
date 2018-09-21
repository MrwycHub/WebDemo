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
namespace WebDemo.Web.WebDemo.FreezeDay
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
		WebDemo.BLL.WebDemo.FreezeDay bll=new WebDemo.BLL.WebDemo.FreezeDay();
		WebDemo.Model.WebDemo.FreezeDay model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblFreezeDate.Text=model.FreezeDate;
		this.txtFreezeNumber.Text=model.FreezeNumber.ToString();
		this.lblReadDate.Text=model.ReadDate.ToString();
		this.txtInstantNumber.Text=model.InstantNumber.ToString();
		this.txtPileNumber.Text=model.PileNumber.ToString();
		this.txtWatertemp.Text=model.Watertemp.ToString();
		this.txtBackWatertemp.Text=model.BackWatertemp.ToString();
		this.txtWorkDate.Text=model.WorkDate.ToString();
		this.txtFactDate.Text=model.FactDate;
		this.txtBatteryState.Text=model.BatteryState.ToString();
		this.txtWarning.Text=model.Warning.ToString();
		this.txtValveState.Text=model.ValveState.ToString();
		this.txtUploadFlag.Text=model.UploadFlag.ToString();
		this.txtOldFreezeNumber.Text=model.OldFreezeNumber.ToString();
		this.txtMegabit.Text=model.Megabit.ToString();
		this.txtPriceSetNo.Text=model.PriceSetNo.ToString();
		this.txtCollectorReadDate.Text=model.CollectorReadDate.ToString();
		this.txtMeterStatusString.Text=model.MeterStatusString;
		this.txtSyncFlag.Text=model.SyncFlag.ToString();
		this.txtVerifyValue.Text=model.VerifyValue.ToString();
		this.txtRemnant.Text=model.Remnant.ToString();
		this.txtReadMode.Text=model.ReadMode.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtFreezeNumber.Text))
			{
				strErr+="日冻结读数格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtReadDate.Text))
			{
				strErr+="抄表时间格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtInstantNumber.Text))
			{
				strErr+="InstantNumber格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPileNumber.Text))
			{
				strErr+="PileNumber格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtWatertemp.Text))
			{
				strErr+="Watertemp格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBackWatertemp.Text))
			{
				strErr+="BackWatertemp格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtWorkDate.Text))
			{
				strErr+="WorkDate格式错误！\\n";	
			}
			if(this.txtFactDate.Text.Trim().Length==0)
			{
				strErr+="FactDate不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtBatteryState.Text))
			{
				strErr+="BatteryState格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtWarning.Text))
			{
				strErr+="Warning格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtValveState.Text))
			{
				strErr+="ValveState格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUploadFlag.Text))
			{
				strErr+="UploadFlag格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOldFreezeNumber.Text))
			{
				strErr+="OldFreezeNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMegabit.Text))
			{
				strErr+="Megabit格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceSetNo.Text))
			{
				strErr+="PriceSetNo格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCollectorReadDate.Text))
			{
				strErr+="CollectorReadDate格式错误！\\n";	
			}
			if(this.txtMeterStatusString.Text.Trim().Length==0)
			{
				strErr+="MeterStatusString不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSyncFlag.Text))
			{
				strErr+="SyncFlag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtVerifyValue.Text))
			{
				strErr+="VerifyValue格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtRemnant.Text))
			{
				strErr+="Remnant格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtReadMode.Text))
			{
				strErr+="ReadMode格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int MeterID=int.Parse(this.lblMeterID.Text);
			string FreezeDate=this.lblFreezeDate.Text;
			decimal FreezeNumber=decimal.Parse(this.txtFreezeNumber.Text);
			DateTime ReadDate=DateTime.Parse(this.txtReadDate.Text);
			decimal InstantNumber=decimal.Parse(this.txtInstantNumber.Text);
			decimal PileNumber=decimal.Parse(this.txtPileNumber.Text);
			decimal Watertemp=decimal.Parse(this.txtWatertemp.Text);
			decimal BackWatertemp=decimal.Parse(this.txtBackWatertemp.Text);
			int WorkDate=int.Parse(this.txtWorkDate.Text);
			string FactDate=this.txtFactDate.Text;
			int BatteryState=int.Parse(this.txtBatteryState.Text);
			int Warning=int.Parse(this.txtWarning.Text);
			int ValveState=int.Parse(this.txtValveState.Text);
			int UploadFlag=int.Parse(this.txtUploadFlag.Text);
			decimal OldFreezeNumber=decimal.Parse(this.txtOldFreezeNumber.Text);
			int Megabit=int.Parse(this.txtMegabit.Text);
			int PriceSetNo=int.Parse(this.txtPriceSetNo.Text);
			DateTime CollectorReadDate=DateTime.Parse(this.txtCollectorReadDate.Text);
			string MeterStatusString=this.txtMeterStatusString.Text;
			int SyncFlag=int.Parse(this.txtSyncFlag.Text);
			int VerifyValue=int.Parse(this.txtVerifyValue.Text);
			decimal Remnant=decimal.Parse(this.txtRemnant.Text);
			int ReadMode=int.Parse(this.txtReadMode.Text);


			WebDemo.Model.WebDemo.FreezeDay model=new WebDemo.Model.WebDemo.FreezeDay();
			model.ID=ID;
			model.MeterID=MeterID;
			model.FreezeDate=FreezeDate;
			model.FreezeNumber=FreezeNumber;
			model.ReadDate=ReadDate;
			model.InstantNumber=InstantNumber;
			model.PileNumber=PileNumber;
			model.Watertemp=Watertemp;
			model.BackWatertemp=BackWatertemp;
			model.WorkDate=WorkDate;
			model.FactDate=FactDate;
			model.BatteryState=BatteryState;
			model.Warning=Warning;
			model.ValveState=ValveState;
			model.UploadFlag=UploadFlag;
			model.OldFreezeNumber=OldFreezeNumber;
			model.Megabit=Megabit;
			model.PriceSetNo=PriceSetNo;
			model.CollectorReadDate=CollectorReadDate;
			model.MeterStatusString=MeterStatusString;
			model.SyncFlag=SyncFlag;
			model.VerifyValue=VerifyValue;
			model.Remnant=Remnant;
			model.ReadMode=ReadMode;

			WebDemo.BLL.WebDemo.FreezeDay bll=new WebDemo.BLL.WebDemo.FreezeDay();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
