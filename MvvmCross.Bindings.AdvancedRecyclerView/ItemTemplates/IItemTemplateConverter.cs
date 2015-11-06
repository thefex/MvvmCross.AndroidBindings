namespace MvvmCross.Bindings.AdvancedRecyclerView.ItemTemplates
{
    public interface IItemTemplateConverter<in TItem>
    {
        int GetItemLayoutResourceId(TItem itemToGetViewIdFrom);

    }
}