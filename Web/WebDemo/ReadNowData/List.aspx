﻿<%@ Page Title="ReadNowData" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.ReadNowData.List" %>
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
                    BorderWidth="1px" DataKeyNames="ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="MeterID" HeaderText="MeterID" SortExpression="MeterID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ReadNumber" HeaderText="ReadNumber" SortExpression="ReadNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ValveState" HeaderText="ValveState" SortExpression="ValveState" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AttackState" HeaderText="AttackState" SortExpression="AttackState" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Voltage" HeaderText="Voltage" SortExpression="Voltage" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ReadDate" HeaderText="ReadDate" SortExpression="ReadDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InstantNumber" HeaderText="InstantNumber" SortExpression="InstantNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PileNumber" HeaderText="PileNumber" SortExpression="PileNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Watertemp" HeaderText="Watertemp" SortExpression="Watertemp" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BackWatertemp" HeaderText="BackWatertemp" SortExpression="BackWatertemp" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WorkDate" HeaderText="WorkDate" SortExpression="WorkDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FactDate" HeaderText="FactDate" SortExpression="FactDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BatteryState" HeaderText="BatteryState" SortExpression="BatteryState" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Warning" HeaderText="Warning" SortExpression="Warning" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OldFreezeNumber" HeaderText="OldFreezeNumber" SortExpression="OldFreezeNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Megabit" HeaderText="Megabit" SortExpression="Megabit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UseState" HeaderText="UseState" SortExpression="UseState" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ControlValveDate" HeaderText="ControlValveDate" SortExpression="ControlValveDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SyncFlag" HeaderText="SyncFlag" SortExpression="SyncFlag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceSetNo" HeaderText="PriceSetNo" SortExpression="PriceSetNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollectorReadDate" HeaderText="CollectorReadDate" SortExpression="CollectorReadDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterStatusString" HeaderText="MeterStatusString" SortExpression="MeterStatusString" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remnant" HeaderText="Remnant" SortExpression="Remnant" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
