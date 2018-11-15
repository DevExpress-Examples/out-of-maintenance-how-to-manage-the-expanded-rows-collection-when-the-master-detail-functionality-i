<!-- default file list -->
*Files to look at*:

* [Category.cs](./CS/Models/Category.cs) (VB: [Category.vb](./VB/Models/Category.vb))
* [DataHelper.cs](./CS/Models/DataHelper.cs) (VB: [DataHelper.vb](./VB/Models/DataHelper.vb))
* [Product.cs](./CS/Models/Product.cs) (VB: [Product.vb](./VB/Models/Product.vb))
* **[CategoryView.cs](./CS/View/CategoryView.cs) (VB: [CategoryView.vb](./VB/View/CategoryView.vb))**
* [CategoryViewModel.cs](./CS/ViewModel/CategoryViewModel.cs) (VB: [CategoryViewModel.vb](./VB/ViewModel/CategoryViewModel.vb))
<!-- default file list end -->
# How to manage the expanded rows collection when the Master-Detail functionality is used


<p>This example demonstrates a possible way of managing a collection of expanded rows when the Master-Detail functionality is used.</p>
<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-manage-the-expanded-rows-collection-when-the-master-detail-functionality-is-used-t470064/16.2.3+/media/83de3514-d6a5-11e6-80bf-00155d62480c.png"><br><br><br>
<p><strong>Implementation details.<br></strong><br>Since <strong>GridView</strong> is implemented in the most optimal way, it is necessary to manage the state of its rows using methods provided by the <strong>GridView</strong>. Thus, to implement the <strong>GridView's</strong> rows state management, a bridge between the <strong>GridView</strong> object and <strong>ViewModel </strong>is required. Additionally, it is necessary to update the <strong>ViewModel's</strong> collection of expanded rows once a row is expanded \ collapsed on the <strong>GridView's</strong> side. To accomplish both of these tasks, the <strong>ExpandedMasterRowsManager </strong>helper class is implemented in the example.  <br><br>On the other hand, nothing special needs to be introduced on the <strong>ViewModel's</strong> side to implement the <strong>GridView's</strong> rows state management.<br><br><br>Below, you can find references to documentation, which provides descriptions of methods, events and features that are used in the example:</p>
<strong><a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument117019">Fluent API</a><br><a href="https://documentation.devexpress.com/WindowsForms/CustomDocument113965.aspx">Commands</a> </strong><br><strong><a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument113975">Event-To-Command Behaviors</a></strong><br><strong><a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CollapseAllDetailstopic">GridView.CollapseAllDetails</a><br><a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_ExpandMasterRowtopic">GridView.ExpandMasterRow</a><br><a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_CollapseMasterRowtopic">GridView.CollapseMasterRow</a><br> <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_MasterRowExpandedtopic">GridView.MasterRowExpanded</a><br><a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsGridGridView_MasterRowCollapsedtopic">GridView.MasterRowCollapsed</a> </strong>

<br/>


