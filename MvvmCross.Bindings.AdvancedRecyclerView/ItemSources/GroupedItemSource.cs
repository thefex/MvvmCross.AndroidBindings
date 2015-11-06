namespace MvvmCross.Bindings.AdvancedRecyclerView.ItemSources
{
    public class GroupedItemSource<TGroupItem, TChildItem>
    {

        public int GroupCount { get; private set; }


        internal long GetGroupId(int atPosition)
        {
            return long.MinValue;
        }

        internal long GetChildId(int groupPosition, int childPosition)
        {
            return long.MinValue;
        }

        internal int GetChildCount(int forGroupId)
        {
            return 0;
        }

        public TGroupItem this[int groupIndex]
        {
            get {  /* return the specified groupIndex here */ }
            set
            {
                /* set the specified groupIndex to value here */
            }
        }

        public TChildItem this[int groupIndex, int childIndex]
        {
            get { }
            set
            {
                
            }
        }
    }
}