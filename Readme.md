<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128542288/16.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T503061)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Category.cs](./CS/App_Code/Category.cs) (VB: [Category.vb](./VB/App_Code/Category.vb))
* [Source.cs](./CS/App_Code/Source.cs) (VB: [Source.vb](./VB/App_Code/Source.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to save GridColumns' width values to cookies and restore them
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t503061/)**
<!-- run online end -->


<p>ASPxGridView control doesn't send a callback to the server when a GridColumn width is changed. GridColumns' width value will be passed to the server with the next ASPxGridView callback. If a callback is not sent, page reloading will cause losing columns' new widths. The sample illustrates how to save ASPxGridView columns' widths to a cookie at the client side and apply them at the server side. </p>
<p>Note that the SettingsCookies.StoreColumnsWidth property should be assigned to False to disable overwriting our GridColumns' width by default GridColumns' width saved with the help of SaveClientLayout.</p>

<br/>


