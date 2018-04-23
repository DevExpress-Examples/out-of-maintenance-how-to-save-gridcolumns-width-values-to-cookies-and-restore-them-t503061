<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function objToString(obj) {
            var str = "";
            for (var p in obj) {
                str += p + "=" + obj[p] + "|";
            }
            return str;
        }
        function ColumnResized(s, e) {
            var cookies = "";
            var helper = s.GetResizingHelper();
            var obj = helper.GetColumnWidths();
            cookies = objToString(obj);
            ASPxClientUtils.SetCookie('ASPxGridViewColumnWidths', cookies);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <dx:ASPxGridView ID="ASPxGridView1" runat="server" AutoGenerateColumns="False" KeyFieldName="CategoryID" OnClientLayout="ASPxGridView1_ClientLayout" OnDataBinding="ASPxGridView1_DataBinding">
                <ClientSideEvents ColumnResized="ColumnResized" />
                <SettingsCookies StoreColumnsWidth="False" />
                <SettingsResizing ColumnResizeMode="NextColumn" />
                <Columns>
                    <dx:GridViewDataTextColumn FieldName="CategoryID" ReadOnly="True" VisibleIndex="0">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="1">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                </Columns>
            </dx:ASPxGridView>

        </div>
    </form>
</body>
</html>
