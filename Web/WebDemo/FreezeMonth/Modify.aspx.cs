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
namespace WebDemo.Web.WebDemo.FreezeMonth
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
		WebDemo.BLL.WebDemo.FreezeMonth bll=new WebDemo.BLL.WebDemo.FreezeMonth();
		WebDemo.Model.WebDemo.FreezeMonth model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblMeterID.Text=model.MeterID.ToString();
		this.lblFreezeMonth.Text=model.FreezeMonth;
		this.txtFreezeNumber.Text=model.FreezeNumber.ToString();
		this.lblReadDate.Text=model.ReadDate.ToString();
		this.chkCalMark.Checked=model.CalMark;
		this.txtInstantNumber.Text=model.InstantNumber.ToString();
		this.txtPileNumber.Text=model.PileNumber.ToString();
		this.txtWatertemp.Text=model.Watertemp.ToString();
		this.txtBackWatertemp.Text=model.BackWatertemp.ToString();
		this.txtWorkDate.Text=model.WorkDate.ToString();
		this.txtFactDate.Text=model.FactDate;
		this.txtBatteryState.Text=model.BatteryState.ToString();
		this.txtWarning.Text=model.Warning.ToString();
		this.txtReadType.Text=model.ReadType.ToString();
		this.txtOldFreezeNumber.Text=model.OldFreezeNumber.ToString();
		this.txtMegabit.Text=model.Megabit.ToString();
		this.txtAdditionNum.Text=model.AdditionNum.ToString();
		this.txtSmallImagePath.Text=model.SmallImagePath;
		this.txtBigImagePath.Text=model.BigImagePath;
		this.txtLocationX.Text=model.LocationX.ToString();
		this.txtLocationY.Text=model.LocationY.ToString();
		this.txtRemark.Text=model.Remark;
		this.txtTakePhotoDate.Text=model.TakePhotoDate.ToString();
		this.txtSyncFlag.Text=model.SyncFlag.ToString();
		this.txtPriceSetNo.Text=model.PriceSetNo.ToString();
		this.txtCollectorReadDate.Text=model.CollectorReadDate.ToString();
		this.txtActiveSharp.Text=model.ActiveSharp.ToString();
		this.txtActivePeak.Text=model.ActivePeak.ToString();
		this.txtActiveShoulder.Text=model.ActiveShoulder.ToString();
		this.txtActiveOffPeak.Text=model.ActiveOffPeak.ToString();
		this.txtMeterStatusString.Text=model.MeterStatusString;
		this.txtVerifyValue.Text=model.VerifyValue.ToString();
		this.txtRemnant.Text=model.Remnant.ToString();
		this.txtValveState.Text=model.ValveState.ToString();

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
				strErr+="ReadDate格式错误！\\n";	
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
			if(!PageValidate.IsNumber(txtReadType.Text))
			{
				strErr+="抄表方式 1 自动抄表 2 手格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOldFreezeNumber.Text))
			{
				strErr+="OldFreezeNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMegabit.Text))
			{
				strErr+="Megabit格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAdditionNum.Text))
			{
				strErr+="AdditionNum格式错误！\\n";	
			}
			if(this.txtSmallImagePath.Text.Trim().Length==0)
			{
				strErr+="SmallImagePath不能为空！\\n";	
			}
			if(this.txtBigImagePath.Text.Trim().Length==0)
			{
				strErr+="BigImagePath不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLocationX.Text))
			{
				strErr+="LocationX格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLocationY.Text))
			{
				strErr+="LocationY格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtTakePhotoDate.Text))
			{
				strErr+="TakePhotoDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSyncFlag.Text))
			{
				strErr+="SyncFlag格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPriceSetNo.Text))
			{
				strErr+="PriceSetNo格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCollectorReadDate.Text))
			{
				strErr+="CollectorReadDate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtActiveSharp.Text))
			{
				strErr+="ActiveSharp格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtActivePeak.Text))
			{
				strErr+="ActivePeak格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtActiveShoulder.Text))
			{
				strErr+="ActiveShoulder格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtActiveOffPeak.Text))
			{
				strErr+="ActiveOffPeak格式错误！\\n";	
			}
			if(this.txtMeterStatusString.Text.Trim().Length==0)
			{
				strErr+="MeterStatusString不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtVerifyValue.Text))
			{
				strErr+="VerifyValue格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtRemnant.Text))
			{
				strErr+="Remnant格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtValveState.Text))
			{
				strErr+="ValveState格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			int MeterID=int.Parse(this.lblMeterID.Text);
			string FreezeMonth=this.lblFreezeMonth.Text;
			decimal FreezeNumber=decimal.Parse(this.txtFreezeNumber.Text);
			DateTime ReadDate=DateTime.Parse(this.txtReadDate.Text);
			bool CalMark=this.chkCalMark.Checked;
			decimal InstantNumber=decimal.Parse(this.txtInstantNumber.Text);
			decimal PileNumber=decimal.Parse(this.txtPileNumber.Text);
			decimal Watertemp=decimal.Parse(this.txtWatertemp.Text);
			decimal BackWatertemp=decimal.Parse(this.txtBackWatertemp.Text);
			int WorkDate=int.Parse(this.txtWorkDate.Text);
			string FactDate=this.txtFactDate.Text;
			int BatteryState=int.Parse(this.txtBatteryState.Text);
			int Warning=int.Parse(this.txtWarning.Text);
			int ReadType=int.Parse(this.txtReadType.Text);
			decimal OldFreezeNumber=decimal.Parse(this.txtOldFreezeNumber.Text);
			int Megabit=int.Parse(this.txtMegabit.Text);
			decimal AdditionNum=decimal.Parse(this.txtAdditionNum.Text);
			string SmallImagePath=this.txtSmallImagePath.Text;
			string BigImagePath=this.txtBigImagePath.Text;
			decimal LocationX=decimal.Parse(this.txtLocationX.Text);
			decimal LocationY=decimal.Parse(this.txtLocationY.Text);
			string Remark=this.txtRemark.Text;
			DateTime TakePhotoDate=DateTime.Parse(this.txtTakePhotoDate.Text);
			int SyncFlag=int.Parse(this.txtSyncFlag.Text);
			int PriceSetNo=int.Parse(this.txtPriceSetNo.Text);
			DateTime CollectorReadDate=DateTime.Parse(this.txtCollectorReadDate.Text);
			decimal ActiveSharp=decimal.Parse(this.txtActiveSharp.Text);
			decimal ActivePeak=decimal.Parse(this.txtActivePeak.Text);
			decimal ActiveShoulder=decimal.Parse(this.txtActiveShoulder.Text);
			decimal ActiveOffPeak=decimal.Parse(this.txtActiveOffPeak.Text);
			string MeterStatusString=this.txtMeterStatusString.Text;
			int VerifyValue=int.Parse(this.txtVerifyValue.Text);
			decimal Remnant=decimal.Parse(this.txtRemnant.Text);
			int ValveState=int.Parse(this.txtValveState.Text);


			WebDemo.Model.WebDemo.FreezeMonth model=new WebDemo.Model.WebDemo.FreezeMonth();
			model.ID=ID;
			model.MeterID=MeterID;
			model.FreezeMonth=FreezeMonth;
			model.FreezeNumber=FreezeNumber;
			model.ReadDate=ReadDate;
			model.CalMark=CalMark;
			model.InstantNumber=InstantNumber;
			model.PileNumber=PileNumber;
			model.Watertemp=Watertemp;
			model.BackWatertemp=BackWatertemp;
			model.WorkDate=WorkDate;
			model.FactDate=FactDate;
			model.BatteryState=BatteryState;
			model.Warning=Warning;
			model.ReadType=ReadType;
			model.OldFreezeNumber=OldFreezeNumber;
			model.Megabit=Megabit;
			model.AdditionNum=AdditionNum;
			model.SmallImagePath=SmallImagePath;
			model.BigImagePath=BigImagePath;
			model.LocationX=LocationX;
			model.LocationY=LocationY;
			model.Remark=Remark;
			model.TakePhotoDate=TakePhotoDate;
			model.SyncFlag=SyncFlag;
			model.PriceSetNo=PriceSetNo;
			model.CollectorReadDate=CollectorReadDate;
			model.ActiveSharp=ActiveSharp;
			model.ActivePeak=ActivePeak;
			model.ActiveShoulder=ActiveShoulder;
			model.ActiveOffPeak=ActiveOffPeak;
			model.MeterStatusString=MeterStatusString;
			model.VerifyValue=VerifyValue;
			model.Remnant=Remnant;
			model.ValveState=ValveState;

			WebDemo.BLL.WebDemo.FreezeMonth bll=new WebDemo.BLL.WebDemo.FreezeMonth();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
