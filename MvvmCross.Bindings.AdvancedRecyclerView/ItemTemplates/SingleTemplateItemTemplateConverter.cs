namespace MvvmCross.Bindings.AdvancedRecyclerView.ItemTemplates
{
    public class SingleTemplateItemTemplateConverter<TItem> : IItemTemplateConverter<TItem>
    {
        private readonly int _itemLayoutResourceId;

        public SingleTemplateItemTemplateConverter(int itemLayoutResourceId)
        {
            _itemLayoutResourceId = itemLayoutResourceId;
        }

        public int GetItemLayoutResourceId(TItem itemToGetViewIdFrom)
        {
            return _itemLayoutResourceId;
        }
    }
}