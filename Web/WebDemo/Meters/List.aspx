<%@ Page Title="Meters" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.Meters.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="MeterID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="MeterTypeID" HeaderText="表类型编号(同一表类型下表地址" SortExpression="MeterTypeID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterAddr" HeaderText="表地址(12位数字" SortExpression="MeterAddr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollectorID" HeaderText="集中器编号" SortExpression="CollectorID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="HostID" HeaderText="楼宇主机编号" SortExpression="HostID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UsersID" HeaderText="用户ID" SortExpression="UsersID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CardType" HeaderText="卡类型" SortExpression="CardType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CardID" HeaderText="一卡通卡号(卡号+卡区号不能重" SortExpression="CardID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CardSector" HeaderText="卡区号(一卡通卡区号" SortExpression="CardSector" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TotalMoney" HeaderText="总购买金额" SortExpression="TotalMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TotalInt" HeaderText="总购买量" SortExpression="TotalInt" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TotalBase" HeaderText="总购买字数" SortExpression="TotalBase" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastMoney" HeaderText="最后一次购买金额" SortExpression="LastMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastInt" HeaderText="最后一次购买量" SortExpression="LastInt" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastBase" HeaderText="最后一次购买字数" SortExpression="LastBase" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mark" HeaderText="标志(1-建档；2-使用；3-" SortExpression="Mark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterBase" HeaderText="表底数" SortExpression="MeterBase" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterVerify" HeaderText="表修正值" SortExpression="MeterVerify" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeID" HeaderText="价格编号" SortExpression="PriceTypeID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterDate" HeaderText="MeterDate" SortExpression="MeterDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterNumber" HeaderText="出厂编号" SortExpression="MeterNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InstallDate" HeaderText="安装日期" SortExpression="InstallDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InstallAddr" HeaderText="InstallAddr" SortExpression="InstallAddr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Constant" HeaderText="电表常数" SortExpression="Constant" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mutual" HeaderText="互感变比" SortExpression="Mutual" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Coefficient" HeaderText="倍率" SortExpression="Coefficient" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastCalNumber" HeaderText="最后结算读数,默认等于表底数" SortExpression="LastCalNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastCalMonth" HeaderText="最后结算月份(默认等于安装月份" SortExpression="LastCalMonth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastReadNumber" HeaderText="LastReadNumber" SortExpression="LastReadNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayType" HeaderText="交费类型(1-预付费  2-后" SortExpression="PayType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Modalid" HeaderText="型号编号" SortExpression="Modalid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="XPower" HeaderText="限容功率" SortExpression="XPower" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="备注信息" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WorkerID" HeaderText="WorkerID" SortExpression="WorkerID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DayUseNum" HeaderText="DayUseNum" SortExpression="DayUseNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mf1Sn" HeaderText="Mf1Sn" SortExpression="Mf1Sn" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AlarmDis" HeaderText="AlarmDis" SortExpression="AlarmDis" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AlarmShut" HeaderText="AlarmShut" SortExpression="AlarmShut" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterNo" HeaderText="MeterNo" SortExpression="MeterNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Relayed" HeaderText="是否中继" SortExpression="Relayed" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RouteLen" HeaderText="中继深度" SortExpression="RouteLen" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RouteInfo" HeaderText="中继路径" SortExpression="RouteInfo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Floor" HeaderText="Floor" SortExpression="Floor" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GroupID" HeaderText="GroupID" SortExpression="GroupID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastCur" HeaderText="LastCur" SortExpression="LastCur" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvoiceType" HeaderText="发票类型" SortExpression="InvoiceType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Percent0" HeaderText="比例" SortExpression="Percent0" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeName1" HeaderText="PriceTypeName1" SortExpression="PriceTypeName1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeID1" HeaderText="PriceTypeID1" SortExpression="PriceTypeID1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Percent1" HeaderText="Percent1" SortExpression="Percent1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeID2" HeaderText="PriceTypeID2" SortExpression="PriceTypeID2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeName2" HeaderText="PriceTypeName2" SortExpression="PriceTypeName2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Percent2" HeaderText="Percent2" SortExpression="Percent2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeID3" HeaderText="PriceTypeID3" SortExpression="PriceTypeID3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeName3" HeaderText="PriceTypeName3" SortExpression="PriceTypeName3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Percent3" HeaderText="Percent3" SortExpression="Percent3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeID4" HeaderText="PriceTypeID4" SortExpression="PriceTypeID4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeName4" HeaderText="PriceTypeName4" SortExpression="PriceTypeName4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Percent4" HeaderText="Percent4" SortExpression="Percent4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterMC" HeaderText="MeterMC" SortExpression="MeterMC" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uAccount" HeaderText="账号" SortExpression="uAccount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsSend" HeaderText="0未发送 其他已发送" SortExpression="IsSend" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="HostAddr" HeaderText="所属采集器" SortExpression="HostAddr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastReadDate" HeaderText="LastReadDate" SortExpression="LastReadDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OverUse" HeaderText="OverUse" SortExpression="OverUse" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DownloadFlag" HeaderText="DownloadFlag" SortExpression="DownloadFlag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TotalGroup" HeaderText="TotalGroup" SortExpression="TotalGroup" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CurrentGroup" HeaderText="CurrentGroup" SortExpression="CurrentGroup" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastRecordNo" HeaderText="LastRecordNo" SortExpression="LastRecordNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Balanced" HeaderText="Balanced" SortExpression="Balanced" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MaxFill" HeaderText="MaxFill" SortExpression="MaxFill" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MinRem" HeaderText="MinRem" SortExpression="MinRem" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OverMoney" HeaderText="OverMoney" SortExpression="OverMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FreezeMode" HeaderText="FreezeMode" SortExpression="FreezeMode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FreezeDay" HeaderText="FreezeDay" SortExpression="FreezeDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PlasticInfo" HeaderText="PlasticInfo" SortExpression="PlasticInfo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UseMeterDosage" HeaderText="UseMeterDosage" SortExpression="UseMeterDosage" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ShutValveStaffId" HeaderText="ShutValveStaffId" SortExpression="ShutValveStaffId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InstallStaffId" HeaderText="InstallStaffId" SortExpression="InstallStaffId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CheckDate" HeaderText="CheckDate" SortExpression="CheckDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TagID" HeaderText="TagID" SortExpression="TagID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BookID" HeaderText="BookID" SortExpression="BookID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LocationX" HeaderText="LocationX" SortExpression="LocationX" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LocationY" HeaderText="LocationY" SortExpression="LocationY" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BookNum" HeaderText="BookNum" SortExpression="BookNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UpdateTime" HeaderText="UpdateTime" SortExpression="UpdateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ImagePath" HeaderText="ImagePath" SortExpression="ImagePath" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BindTime" HeaderText="BindTime" SortExpression="BindTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CardFlag" HeaderText="CardFlag" SortExpression="CardFlag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceSetNo" HeaderText="PriceSetNo" SortExpression="PriceSetNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollectorReadDate" HeaderText="CollectorReadDate" SortExpression="CollectorReadDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BuyGasNum" HeaderText="BuyGasNum" SortExpression="BuyGasNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterPackageCode" HeaderText="MeterPackageCode" SortExpression="MeterPackageCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="HighWarnMoney" HeaderText="HighWarnMoney" SortExpression="HighWarnMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MiddleWarnMoney" HeaderText="MiddleWarnMoney" SortExpression="MiddleWarnMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LowWarnMoney" HeaderText="LowWarnMoney" SortExpression="LowWarnMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LowerReserve" HeaderText="LowerReserve" SortExpression="LowerReserve" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsInstall" HeaderText="IsInstall" SortExpression="IsInstall" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsOpen" HeaderText="IsOpen" SortExpression="IsOpen" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CreateTime" HeaderText="CreateTime" SortExpression="CreateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OpenTime" HeaderText="OpenTime" SortExpression="OpenTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SyncFlag" HeaderText="SyncFlag" SortExpression="SyncFlag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CameraCount" HeaderText="CameraCount" SortExpression="CameraCount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterPhone" HeaderText="MeterPhone" SortExpression="MeterPhone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DevEUI" HeaderText="DevEUI" SortExpression="DevEUI" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IMEI" HeaderText="IMEI" SortExpression="IMEI" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UploadOffsetTime" HeaderText="UploadOffsetTime" SortExpression="UploadOffsetTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsUseAlertClose" HeaderText="IsUseAlertClose" SortExpression="IsUseAlertClose" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DiscountsNum" HeaderText="DiscountsNum" SortExpression="DiscountsNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterKey" HeaderText="MeterKey" SortExpression="MeterKey" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsBlack" HeaderText="IsBlack" SortExpression="IsBlack" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="MeterID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="MeterID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
