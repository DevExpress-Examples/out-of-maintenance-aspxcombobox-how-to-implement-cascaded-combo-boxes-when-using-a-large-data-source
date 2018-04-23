'INSTANT VB NOTE: This code snippet uses implicit typing. You will need to set 'Option Infer On' in the VB file or set 'Option Infer' at the project level:

<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>

	<script type="text/javascript">
		function OnLocationChanged() {
			cbCars.PerformCallback(cbLocation.GetText());
		}
	</script>

</head>
<body>
	<form id="form1" runat="server">
	<dx:ASPxComboBox ID="cbLocation" runat="server" SelectedIndex="0">
		<Items>
			<dx:ListEditItem Text="Location1" Value="1" />
			<dx:ListEditItem Text="Location2" Value="2" />
		</Items>
		<ClientSideEvents SelectedIndexChanged="OnLocationChanged" />
	</dx:ASPxComboBox>
	<dx:ASPxComboBox ID="cbCars" runat="server" ClientInstanceName="cbCars" ValueField="Value"
		TextField="Text" ValueType="System.Int32" EnableCallbackMode="true" CallbackPageSize="10"
		IncrementalFilteringMode="StartsWith" OnItemRequestedByValue="cbCars_ItemRequestedByValue"
		OnItemsRequestedByFilterCondition="cbCars_ItemsRequestedByFilterCondition">
	</dx:ASPxComboBox>
	</form>
</body>
</html>