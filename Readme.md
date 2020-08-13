<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxComboBox - How to implement cascaded combo boxes when using a large data source
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3942/)**
<!-- run online end -->


<p>This example demonstrates how to implement cascaded combo boxes scenario when a child ASPxComboBox operates in a <a href="http://documentation.devexpress.com/#AspNet/CustomDocument8196"><u>Dynamic List Population</u></a> mode</p><p>1) Enable a "child" ASPxComboBox "Dynamic List Population" mode by setting the EnableCallbackMode property to "true"<br />
2) Implement both the <strong>ASPxComboBox.OnItemRequestedByValue</strong> event and the <strong>ASPxComboBox.OnItemsRequestedByFilterCondition</strong> events of the "child" ASPxComboBox;<br />
3) Handle the client-side <strong>ASPxClientComboBox.SelectedIndexChanged</strong> event of the "parent" ASPxComboBox;<br />
4) Perform a custom callback of the "child" ASPxComboBox via the client-side <strong>ASPxClientComboBox.PerformCallback</strong> method to update the underlying "child" data.</p>

<br/>


