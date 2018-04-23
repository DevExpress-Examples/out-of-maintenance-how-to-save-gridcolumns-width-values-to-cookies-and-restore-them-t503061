# How to save GridColumns' width values to cookies and restore them


<p>ASPxGridView control doesn't send a callback to the server when a GridColumn width is changed. GridColumns' width value will be passed to the server with the next ASPxGridView callback. If a callback is not sent, page reloading will cause losing columns' new widths. The sample illustrates how to save ASPxGridView columns' widths to a cookie at the client side and apply them at the server side. </p>
<p>Note that the SettingsCookies.StoreColumnsWidth property should be assigned to False to disable overwriting our GridColumns' width by default GridColumns' width saved with the help of SaveClientLayout.</p>

<br/>


