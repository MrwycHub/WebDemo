<%@ Page Title="FreezeMonth" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.FreezeMonth.List" %>
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
                            
		<asp:BoundField DataField="MeterID" HeaderText="表编号" SortExpression="MeterID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FreezeMonth" HeaderText="冻结月" SortExpression="FreezeMonth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FreezeNumber" HeaderText="日冻结读数" SortExpression="FreezeNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ReadDate" HeaderText="ReadDate" SortExpression="ReadDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CalMark" HeaderText="结算标志" SortExpression="CalMark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InstantNumber" HeaderText="InstantNumber" SortExpression="InstantNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PileNumber" HeaderText="PileNumber" SortExpression="PileNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Watertemp" HeaderText="Watertemp" SortExpression="Watertemp" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BackWatertemp" HeaderText="BackWatertemp" SortExpression="BackWatertemp" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WorkDate" HeaderText="WorkDate" SortExpression="WorkDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FactDate" HeaderText="FactDate" SortExpression="FactDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BatteryState" HeaderText="BatteryState" SortExpression="BatteryState" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Warning" HeaderText="Warning" SortExpression="Warning" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ReadType" HeaderText="抄表方式 1 自动抄表 2 手" SortExpression="ReadType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OldFreezeNumber" HeaderText="OldFreezeNumber" SortExpression="OldFreezeNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Megabit" HeaderText="Megabit" SortExpression="Megabit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AdditionNum" HeaderText="AdditionNum" SortExpression="AdditionNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SmallImagePath" HeaderText="SmallImagePath" SortExpression="SmallImagePath" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BigImagePath" HeaderText="BigImagePath" SortExpression="BigImagePath" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LocationX" HeaderText="LocationX" SortExpression="LocationX" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LocationY" HeaderText="LocationY" SortExpression="LocationY" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="Remark" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TakePhotoDate" HeaderText="TakePhotoDate" SortExpression="TakePhotoDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SyncFlag" HeaderText="SyncFlag" SortExpression="SyncFlag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceSetNo" HeaderText="PriceSetNo" SortExpression="PriceSetNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollectorReadDate" HeaderText="CollectorReadDate" SortExpression="CollectorReadDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ActiveSharp" HeaderText="ActiveSharp" SortExpression="ActiveSharp" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ActivePeak" HeaderText="ActivePeak" SortExpression="ActivePeak" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ActiveShoulder" HeaderText="ActiveShoulder" SortExpression="ActiveShoulder" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ActiveOffPeak" HeaderText="ActiveOffPeak" SortExpression="ActiveOffPeak" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterStatusString" HeaderText="MeterStatusString" SortExpression="MeterStatusString" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="VerifyValue" HeaderText="VerifyValue" SortExpression="VerifyValue" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remnant" HeaderText="Remnant" SortExpression="Remnant" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ValveState" HeaderText="ValveState" SortExpression="ValveState" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
