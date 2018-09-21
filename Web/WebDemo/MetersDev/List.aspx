<%@ Page Title="MetersDev" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.MetersDev.List" %>
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
                            
		<asp:BoundField DataField="MeterID" HeaderText="MeterID" SortExpression="MeterID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DisenableDate" HeaderText="DisenableDate" SortExpression="DisenableDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SiteDir" HeaderText="SiteDir" SortExpression="SiteDir" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InsureCode" HeaderText="InsureCode" SortExpression="InsureCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InsureDate" HeaderText="InsureDate" SortExpression="InsureDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InsureEndDate" HeaderText="InsureEndDate" SortExpression="InsureEndDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GasDir" HeaderText="GasDir" SortExpression="GasDir" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InstallPos" HeaderText="InstallPos" SortExpression="InstallPos" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InstallWorkerID" HeaderText="InstallWorkerID" SortExpression="InstallWorkerID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InstallDate" HeaderText="InstallDate" SortExpression="InstallDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FireWorkerID" HeaderText="FireWorkerID" SortExpression="FireWorkerID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FireDate" HeaderText="FireDate" SortExpression="FireDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FirstCheckDate" HeaderText="FirstCheckDate" SortExpression="FirstCheckDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FirstCheckMark" HeaderText="FirstCheckMark" SortExpression="FirstCheckMark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CheckCyc" HeaderText="CheckCyc" SortExpression="CheckCyc" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BoilerFlag" HeaderText="BoilerFlag" SortExpression="BoilerFlag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SelfFlag" HeaderText="SelfFlag" SortExpression="SelfFlag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BookID" HeaderText="BookID" SortExpression="BookID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InstallID" HeaderText="InstallID" SortExpression="InstallID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FirstCheckInfo" HeaderText="FirstCheckInfo" SortExpression="FirstCheckInfo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FirstCheckWorkerID" HeaderText="FirstCheckWorkerID" SortExpression="FirstCheckWorkerID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CurrValveState" HeaderText="CurrValveState" SortExpression="CurrValveState" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
