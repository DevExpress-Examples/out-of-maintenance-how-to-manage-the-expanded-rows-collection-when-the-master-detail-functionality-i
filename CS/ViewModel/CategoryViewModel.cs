using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace DxExample
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            ExpandedEntitiesCollection = new ObservableCollection<object>();
        }


        private BindingList<Category> categories;
        public ObservableCollection<object> ExpandedEntitiesCollection { get; set; }
        public int ExpandedEntitiesCount { get { return ExpandedEntitiesCollection.Count; } }


        public BindingList<Category> Categories
        {
            get
            {
                if (categories == null)
                    categories = DataHelper.GetData();
                return categories;
            }
            set
            {
                categories = value;
            }
        }

        public void Update(object entityID)
        {
            UpdateDataBindings();
            UpdateCommands(entityID);
        }

        public void UpdateDataBindings()
        {
            this.RaisePropertyChanged(x => x.ExpandedEntitiesCount);
        }

        public void UpdateCommands(object categoryID)
        {
            this.RaiseCanExecuteChanged(x => x.CollapseEntity(categoryID));
            this.RaiseCanExecuteChanged(x => x.DeleteEntity(categoryID));
            this.RaiseCanExecuteChanged(x => x.ExpandEntity(categoryID));
        }

        public void DeleteEntity(object categoryID)
        {
            CollapseEntity(categoryID);
            Categories.Remove(FindEntity(categoryID));
            Update(categoryID);
        }

        public void ExpandEntity(object categoryID)
        {
            ExpandedEntitiesCollection.Add(categoryID);
            Update(categoryID);
        }

        public void CollapseEntity(object categoryID)
        {
            ExpandedEntitiesCollection.Remove(categoryID);
            Update(categoryID);
        }

        public bool CanDeleteEntity(object categoryID)
        {
            return EntityExists(categoryID);
        }

        public bool CanCollapseEntity(object categoryID)
        {
            return EntityExists(categoryID) && ExpandedEntitiesCollection.Contains(categoryID);
        }

        public bool CanExpandEntity(object categoryID)
        {
            return EntityExists(categoryID) && !ExpandedEntitiesCollection.Contains(categoryID);
        }

        private bool EntityExists(object categoryID)
        {
            return FindEntity(categoryID) != null;
        }

        private Category FindEntity(object categoryID)
        {
            return Categories.FirstOrDefault(entity => entity.ID == Convert.ToInt32(categoryID));
        }
    }
}
