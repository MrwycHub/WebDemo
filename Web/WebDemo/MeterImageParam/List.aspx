<%@ Page Title="MeterImageParam" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.MeterImageParam.List" %>
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
                    BorderWidth="1px" DataKeyNames="Id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="MeterId" HeaderText="MeterId" SortExpression="MeterId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CameraNo" HeaderText="CameraNo" SortExpression="CameraNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="NumberCount" HeaderText="NumberCount" SortExpression="NumberCount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CaptureStartPixs" HeaderText="CaptureStartPixs" SortExpression="CaptureStartPixs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UpClipPixs" HeaderText="UpClipPixs" SortExpression="UpClipPixs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DownClipPixs" HeaderText="DownClipPixs" SortExpression="DownClipPixs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LeftClipPixs" HeaderText="LeftClipPixs" SortExpression="LeftClipPixs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RightClipPixs" HeaderText="RightClipPixs" SortExpression="RightClipPixs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CircumgyrateDegree" HeaderText="CircumgyrateDegree" SortExpression="CircumgyrateDegree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InclineDegree" HeaderText="InclineDegree" SortExpression="InclineDegree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ModelHeight" HeaderText="ModelHeight" SortExpression="ModelHeight" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ModelWidth" HeaderText="ModelWidth" SortExpression="ModelWidth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ModelOneWidth" HeaderText="ModelOneWidth" SortExpression="ModelOneWidth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="NumberSpace" HeaderText="NumberSpace" SortExpression="NumberSpace" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BitValueLimen" HeaderText="BitValueLimen" SortExpression="BitValueLimen" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BitValueRadius" HeaderText="BitValueRadius" SortExpression="BitValueRadius" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BitValueBlackProportion" HeaderText="BitValueBlackProportion" SortExpression="BitValueBlackProportion" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MorphologicFilterParam" HeaderText="MorphologicFilterParam" SortExpression="MorphologicFilterParam" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SearchlimitParam" HeaderText="SearchlimitParam" SortExpression="SearchlimitParam" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WindowHeight" HeaderText="WindowHeight" SortExpression="WindowHeight" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastOperDate" HeaderText="LastOperDate" SortExpression="LastOperDate" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
