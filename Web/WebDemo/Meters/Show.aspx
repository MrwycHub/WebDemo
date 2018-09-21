<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.Meters.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		表编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		表类型编号(同一表类型下表地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterTypeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		表地址(12位数字
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterAddr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		楼宇主机编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUsersID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		卡类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCardType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		一卡通卡号(卡号+卡区号不能重
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCardID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		卡区号(一卡通卡区号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCardSector" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTotalMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTotalInt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买字数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTotalBase" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后一次购买金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后一次购买量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastInt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后一次购买字数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastBase" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		标志(1-建档；2-使用；3-
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		表底数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterBase" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		表修正值
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterVerify" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		价格编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		出厂编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		安装日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInstallDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallAddr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInstallAddr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电表常数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblConstant" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		互感变比
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMutual" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		倍率
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCoefficient" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后结算读数,默认等于表底数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastCalNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后结算月份(默认等于安装月份
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastCalMonth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastReadNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastReadNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		交费类型(1-预付费  2-后
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		型号编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModalid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		限容功率
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblXPower" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注信息
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkerID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWorkerID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DayUseNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDayUseNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Mf1Sn
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMf1Sn" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AlarmDis
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAlarmDis" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AlarmShut
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAlarmShut" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否中继
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRelayed" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		中继深度
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRouteLen" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		中继路径
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRouteInfo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Floor
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFloor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GroupID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGroupID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastCur
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastCur" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发票类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoiceType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		比例
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPercent0" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeName1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeName1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeID1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Percent1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPercent1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeID2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeName2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeName2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Percent2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPercent2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeID3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeName3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeName3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Percent3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPercent3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeID4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeName4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeName4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Percent4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPercent4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterMC
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterMC" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		账号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluAccount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		0未发送 其他已发送
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsSend" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属采集器
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostAddr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastReadDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastReadDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OverUse
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOverUse" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DownloadFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDownloadFlag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TotalGroup
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTotalGroup" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CurrentGroup
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCurrentGroup" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastRecordNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastRecordNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Balanced
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBalanced" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MaxFill
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMaxFill" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MinRem
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMinRem" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OverMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOverMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FreezeMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFreezeMode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FreezeDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFreezeDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PlasticInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPlasticInfo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseMeterDosage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUseMeterDosage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShutValveStaffId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblShutValveStaffId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallStaffId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInstallStaffId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CheckDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCheckDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TagID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTagID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BookID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBookID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LocationX
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLocationX" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LocationY
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLocationY" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BookNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBookNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpdateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpdateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ImagePath
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblImagePath" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BindTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBindTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CardFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCardFlag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceSetNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceSetNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CollectorReadDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorReadDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BuyGasNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBuyGasNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterPackageCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterPackageCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HighWarnMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHighWarnMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MiddleWarnMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMiddleWarnMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LowWarnMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLowWarnMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LowerReserve
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLowerReserve" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsInstall
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsInstall" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsOpen
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsOpen" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCreateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OpenTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOpenTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SyncFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSyncFlag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CameraCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCameraCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DevEUI
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDevEUI" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IMEI
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIMEI" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UploadOffsetTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUploadOffsetTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUseAlertClose
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsUseAlertClose" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DiscountsNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDiscountsNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterKey
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterKey" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsBlack
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsBlack" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




