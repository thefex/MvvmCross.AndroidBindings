using System.Collections.Generic;

namespace MvvmCross.Bindings.AdvancedRecyclerView.Item
{
    public class GroupedItem<TGroupItem, TChildItem> 
        where TGroupItem : IUniqueItem
        where TChildItem : IUniqueItem
    {

        public TGroupItem GroupItem { get; set; }

        public IEnumerable<TChildItem> Childs { get; set; }
    }
}