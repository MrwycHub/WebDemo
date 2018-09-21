<%@ Page Title="AdjustPriceLog" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.AdjustPriceLog.List" %>
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
                            
		<asp:BoundField DataField="PriceTypeID" HeaderText="PriceTypeID" SortExpression="PriceTypeID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExeDate" HeaderText="ExeDate" SortExpression="ExeDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mark" HeaderText="Mark" SortExpression="Mark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid1" HeaderText="Divid1" SortExpression="Divid1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid2" HeaderText="Divid2" SortExpression="Divid2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid3" HeaderText="Divid3" SortExpression="Divid3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid4" HeaderText="Divid4" SortExpression="Divid4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid5" HeaderText="Divid5" SortExpression="Divid5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FareID" HeaderText="FareID" SortExpression="FareID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FareTypeName" HeaderText="FareTypeName" SortExpression="FareTypeName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price2" HeaderText="Price2" SortExpression="Price2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price3" HeaderText="Price3" SortExpression="Price3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price4" HeaderText="Price4" SortExpression="Price4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price5" HeaderText="Price5" SortExpression="Price5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price6" HeaderText="Price6" SortExpression="Price6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FareNo" HeaderText="FareNo" SortExpression="FareNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="Remark" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PreFareTypeName" HeaderText="PreFareTypeName" SortExpression="PreFareTypeName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PrePrice" HeaderText="PrePrice" SortExpression="PrePrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PrePrice2" HeaderText="PrePrice2" SortExpression="PrePrice2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PrePrice3" HeaderText="PrePrice3" SortExpression="PrePrice3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PrePrice4" HeaderText="PrePrice4" SortExpression="PrePrice4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PrePrice5" HeaderText="PrePrice5" SortExpression="PrePrice5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PrePrice6" HeaderText="PrePrice6" SortExpression="PrePrice6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PreFareNo" HeaderText="PreFareNo" SortExpression="PreFareNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PreRemark" HeaderText="PreRemark" SortExpression="PreRemark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SetNo" HeaderText="SetNo" SortExpression="SetNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FreezeDay" HeaderText="FreezeDay" SortExpression="FreezeDay" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
