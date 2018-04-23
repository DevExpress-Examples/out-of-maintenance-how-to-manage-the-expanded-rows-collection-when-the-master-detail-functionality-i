using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DxExample
{
    public partial class CategoryView : UserControl
    {
        public CategoryView()
        {
            InitializeComponent();

            mvvmContext1.ViewModelType = typeof(CategoryViewModel);
            var fluentAPI = mvvmContext1.OfType<CategoryViewModel>();

            ExpandedMasterRowsManager expandedMasterRowsManager = new ExpandedMasterRowsManager(categoryGridView);

            fluentAPI.SetBinding(gridControl1, grid => grid.DataSource, x => x.Categories);

            fluentAPI.SetBinding(expandedMasterRowsManager, x => x.ExpandedMasterRowsCollection, y => y.ExpandedEntitiesCollection);
            fluentAPI.SetBinding(countLabelControl, x => x.Text, y => y.ExpandedEntitiesCount);

            fluentAPI.WithEvent<CustomMasterRowEventArgs>(categoryGridView, "MasterRowExpanded").EventToCommand(x => x.Update(null), ea => { return expandedMasterRowsManager.GetCategoryID(ea.RowHandle); });
            fluentAPI.WithEvent<CustomMasterRowEventArgs>(categoryGridView, "MasterRowCollapsed").EventToCommand(x => x.Update(null), ea => { return expandedMasterRowsManager.GetCategoryID(ea.RowHandle); });
            fluentAPI.WithEvent(categoryGridView, "DataSourceChanged").EventToCommand(x => x.UpdateDataBindings());

            fluentAPI.WithEvent(categoryIdEdit, "EditValueChanged").EventToCommand(x => x.UpdateCommands(GetCategoryIDFromEditor()));

            fluentAPI.BindCommand(buttonExpand, x => x.ExpandEntity(null), x => GetCategoryIDFromEditor());
            fluentAPI.BindCommand(buttonCollapse, x => x.CollapseEntity(null), x => GetCategoryIDFromEditor());
            fluentAPI.BindCommand(buttonDelete, x => x.DeleteEntity(null), x => GetCategoryIDFromEditor());
        }

        private int GetCategoryIDFromEditor()
        {
            return Convert.ToInt32(categoryIdEdit.EditValue);
        }

        class ExpandedMasterRowsManager : IDisposable
        {
            public ExpandedMasterRowsManager(GridView _view)
            {
                view = _view;
                SubscribeViewEvents(true);
            }

            GridView view;
            ObservableCollection<object> expandedMasterRowsCollection;
            bool viewIsNull { get { return view == null; } }
            bool lockExpandedMasterRowsCollectionChanged { get; set; }
            bool lockMasterRowExpanded = false;

            public ObservableCollection<object> ExpandedMasterRowsCollection
            {
                get
                {
                    return expandedMasterRowsCollection;
                }
                set
                {
                    if (expandedMasterRowsCollection == value) return;
                    SubscribeCollectionChangedEvent(false);
                    expandedMasterRowsCollection = value;
                    SubscribeCollectionChangedEvent(true);
                }
            }

            private void SubscribeCollectionChangedEvent(bool subscribe)
            {
                if (expandedMasterRowsCollection == null) return;
                if (subscribe)
                    expandedMasterRowsCollection.CollectionChanged += ExpandedMasterRowsCollectionChanged;
                else
                    expandedMasterRowsCollection.CollectionChanged -= ExpandedMasterRowsCollectionChanged;
            }

            private void SubscribeViewEvents(bool subscribe)
            {
                if (viewIsNull) return;
                if(subscribe)
                {
                    view.Disposed += view_Disposed;
                    view.MasterRowExpanded += view_MasterRowExpanded;
                    view.MasterRowCollapsed += view_MasterRowCollapsed;
                    view.DataSourceChanged += view_DataSourceChanged;
                }
                else
                {
                    view.Disposed -= view_Disposed;
                    view.MasterRowExpanded -= view_MasterRowExpanded;
                    view.MasterRowCollapsed -= view_MasterRowCollapsed;
                    view.DataSourceChanged -= view_DataSourceChanged;
                    view = null;
                }
            }

            private void view_DataSourceChanged(object sender, EventArgs e)
            {
                lockExpandedMasterRowsCollectionChanged = true;
                expandedMasterRowsCollection.Clear();
                lockExpandedMasterRowsCollectionChanged = false;
            }

            private void view_Disposed(object sender, EventArgs e)
            {
                SubscribeViewEvents(false);
            }

            private void view_MasterRowCollapsed(object sender, CustomMasterRowEventArgs e)
            {
                MasterRowExpanded(false, GetCategoryID(e.RowHandle));
            }

            private void view_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
            {
                MasterRowExpanded(true, GetCategoryID(e.RowHandle));
            }

            public int GetCategoryID(int rowHandle)
            {
                return (view.GetRow(rowHandle) as Category).ID;
            }

            private void MasterRowExpanded(bool expanded, int categoryID)
            {
                if (lockMasterRowExpanded) return;
                lockExpandedMasterRowsCollectionChanged = true;
                if (expanded)
                    expandedMasterRowsCollection.Add(categoryID);
                else
                    expandedMasterRowsCollection.Remove(categoryID);
                lockExpandedMasterRowsCollectionChanged = false;
            }

            private void ExpandedMasterRowsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                if (lockExpandedMasterRowsCollectionChanged || viewIsNull) return;
                lockMasterRowExpanded = true;
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        foreach (int categoryID in e.NewItems)
                            ExpandMasterRow(categoryID);
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        foreach (int categoryID in e.OldItems)
                            CollapseMasterRow(categoryID);
                        break;
                    case NotifyCollectionChangedAction.Reset:
                        CollapseAllMasterRows();
                        break;
                }
                lockMasterRowExpanded = false;
            }

            private void ExpandMasterRow(int categoryID)
            {
                view.ExpandMasterRow(GetRowHandle(categoryID));
            }

            private void CollapseMasterRow(int categoryID)
            {
                view.CollapseMasterRow(GetRowHandle(categoryID));
            }

            private void CollapseAllMasterRows()
            {
                view.CollapseAllDetails();
            }

            private int GetRowHandle(int categoryID)
            {
                return view.LocateByValue("ID", categoryID, null); 
            }

            public void Dispose()
            {
                SubscribeViewEvents(false);
                SubscribeCollectionChangedEvent(false);
            }
        }
    }
}
