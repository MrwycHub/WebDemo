<%@ Page Title="Collectors" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.Collectors.List" %>
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
                    BorderWidth="1px" DataKeyNames="CollectorID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="CollectorID" HeaderText="集中器编号" SortExpression="CollectorID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollectorName" HeaderText="集中器名称" SortExpression="CollectorName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollectorAddr" HeaderText="集中器地址" SortExpression="CollectorAddr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollectorType" HeaderText="集中器类型(1-电话线方式；2" SortExpression="CollectorType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DeptID" HeaderText="部门编号" SortExpression="DeptID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PhoneNumber" HeaderText="电话号码(电话线方式时使用)" SortExpression="PhoneNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollOverTime" HeaderText="超时时间" SortExpression="CollOverTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IPNumber" HeaderText="IP地址(以太网方式时使用)" SortExpression="IPNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PortNumber" HeaderText="端口号(以太网方式时使用)" SortExpression="PortNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GprsCycle" HeaderText="Gprs心跳周期" SortExpression="GprsCycle" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FreezeDay" HeaderText="冻结日" SortExpression="FreezeDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FreezeHour" HeaderText="冻结时" SortExpression="FreezeHour" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ReadDay" HeaderText="抄表日" SortExpression="ReadDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LoginDate" HeaderText="登录时间" SortExpression="LoginDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UpdateDate" HeaderText="更新时间" SortExpression="UpdateDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LoginIP" HeaderText="登录IP" SortExpression="LoginIP" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LoginPort" HeaderText="登录端口" SortExpression="LoginPort" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mark" HeaderText="终端状态(0-离线；1-在线)" SortExpression="Mark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="备注信息" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollectorVer" HeaderText="集中器版本" SortExpression="CollectorVer" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollectorModel" HeaderText="集中器型号" SortExpression="CollectorModel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollectorAPN" HeaderText="CollectorAPN" SortExpression="CollectorAPN" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsServerMode" HeaderText="IsServerMode" SortExpression="IsServerMode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WorkTime" HeaderText="WorkTime" SortExpression="WorkTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="NetWorkTime" HeaderText="NetWorkTime" SortExpression="NetWorkTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FactoryCode" HeaderText="FactoryCode" SortExpression="FactoryCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FramesType" HeaderText="FramesType" SortExpression="FramesType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterAddrFormat" HeaderText="MeterAddrFormat" SortExpression="MeterAddrFormat" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GprsPhone" HeaderText="GprsPhone" SortExpression="GprsPhone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExpireTime" HeaderText="ExpireTime" SortExpression="ExpireTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WorkMode" HeaderText="WorkMode" SortExpression="WorkMode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Lng" HeaderText="Lng" SortExpression="Lng" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Lat" HeaderText="Lat" SortExpression="Lat" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="CollectorID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="CollectorID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
