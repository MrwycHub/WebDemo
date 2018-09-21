<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="WebDemo.Web.WebDemo.Meters.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		表类型编号(同一表类型下表地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterTypeID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		表地址(12位数字
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterAddr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		集中器编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCollectorID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		楼宇主机编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHostID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUsersID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		卡类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCardType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		一卡通卡号(卡号+卡区号不能重
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCardID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		卡区号(一卡通卡区号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCardSector" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTotalMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTotalInt" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买字数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTotalBase" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后一次购买金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后一次购买量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastInt" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后一次购买字数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastBase" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		标志(1-建档；2-使用；3-
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		表底数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterBase" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		表修正值
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterVerify" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		价格编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtMeterDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		出厂编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		安装日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtInstallDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallAddr
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInstallAddr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电表常数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtConstant" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		互感变比
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMutual" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		倍率
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCoefficient" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后结算读数,默认等于表底数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastCalNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		最后结算月份(默认等于安装月份
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastCalMonth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastReadNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastReadNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		交费类型(1-预付费  2-后
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPayType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		型号编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtModalid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		限容功率
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtXPower" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注信息
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkerID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWorkerID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DayUseNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDayUseNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Mf1Sn
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMf1Sn" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AlarmDis
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAlarmDis" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AlarmShut
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAlarmShut" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		是否中继
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRelayed" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		中继深度
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRouteLen" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		中继路径
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRouteInfo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Floor
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFloor" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GroupID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtGroupID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastCur
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastCur" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发票类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInvoiceType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		比例
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPercent0" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeName1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeName1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeID1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Percent1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPercent1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeID2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeName2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeName2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Percent2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPercent2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeID3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeName3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeName3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Percent3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPercent3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeID4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeName4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeName4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Percent4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPercent4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterMC
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterMC" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		账号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuAccount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		0未发送 其他已发送
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsSend" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		所属采集器
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHostAddr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastReadDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastReadDate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OverUse
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOverUse" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DownloadFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDownloadFlag" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TotalGroup
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTotalGroup" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CurrentGroup
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCurrentGroup" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastRecordNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastRecordNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Balanced
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBalanced" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MaxFill
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMaxFill" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MinRem
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMinRem" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OverMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOverMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FreezeMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFreezeMode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FreezeDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFreezeDay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PlasticInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPlasticInfo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseMeterDosage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUseMeterDosage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShutValveStaffId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtShutValveStaffId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallStaffId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInstallStaffId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CheckDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtCheckDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TagID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTagID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BookID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBookID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LocationX
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLocationX" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LocationY
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLocationY" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BookNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBookNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpdateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtUpdateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ImagePath
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtImagePath" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BindTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtBindTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CardFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCardFlag" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceSetNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceSetNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CollectorReadDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtCollectorReadDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BuyGasNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBuyGasNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterPackageCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterPackageCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HighWarnMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHighWarnMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MiddleWarnMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMiddleWarnMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LowWarnMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLowWarnMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LowerReserve
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLowerReserve" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsInstall
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsInstall" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsOpen
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsOpen" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtCreateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OpenTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtOpenTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SyncFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSyncFlag" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CameraCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCameraCount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterPhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DevEUI
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDevEUI" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IMEI
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIMEI" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UploadOffsetTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUploadOffsetTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUseAlertClose
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsUseAlertClose" Text="IsUseAlertClose" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DiscountsNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDiscountsNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterKey
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterKey" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsBlack
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsBlack" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
