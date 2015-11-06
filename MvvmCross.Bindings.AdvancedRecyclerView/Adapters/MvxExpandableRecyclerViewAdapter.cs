using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Android.Views;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Exceptions;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.ViewModels;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Draggable;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Expandable;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable.Action;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Utils;
using MvvmCross.Bindings.AdvancedRecyclerView.Item;
using MvvmCross.Bindings.AdvancedRecyclerView.ItemSources;
using MvvmCross.Bindings.AdvancedRecyclerView.ItemTemplates;
using Object = Java.Lang.Object;

namespace MvvmCross.Bindings.AdvancedRecyclerView.Adapters
{
    public class MvxExpandableRecyclerViewAdapter<TGroup, TChildItem> : AbstractExpandableItemAdapter, IExpandableSwipeableItemAdapter
    {
        private readonly IMvxAndroidBindingContext _bindingContext;
        private readonly GroupedItemSource _groupedItemSource;

        public MvxExpandableRecyclerViewAdapter() : this(MvxAndroidBindingContextHelpers.Current())
        {
        }

        public MvxExpandableRecyclerViewAdapter(IMvxAndroidBindingContext bindingContext) 
        {
            _bindingContext = bindingContext;
            _groupedItemSource = new GroupedItemSource();
        }

        public IItemTemplateConverter<TGroup> GroupItemTemplateProvider { get; set; }
        public IItemTemplateConverter<TChildItem> ChildItemTemplateProvider { get; set; }

        public int? EmptyViewLayoutId { get; set; }

        public IEnumerable<GroupedItem<TGroup, TChildItem>> GroupedItems { get; set; }

        public override int GroupCount
        {
            get
            {
                var groupCount = _groupedItemSource.GroupCount;

                if (IsEmptyViewSupported)
                    groupCount = (groupCount == 0) ? 1 : groupCount; // hack to achieve empty view layout support

                return groupCount;
            }
        }
        public int OnGetChildItemSwipeReactionType(Object p0, int p1, int p2, int p3, int p4)
        {
            throw new NotImplementedException();
        }

        public int OnGetGroupItemSwipeReactionType(Object p0, int p1, int p2, int p3)
        {
            throw new NotImplementedException();
        }

        public void OnSetChildItemSwipeBackground(Object p0, int p1, int p2,
            [IntDef(Flag = true, Type = "Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable.ISwipeableItemConstants",
                Fields =
                    new[]
                    {
                        "DrawableSwipeNeutralBackground", "DrawableSwipeLeftBackground", "DrawableSwipeUpBackground",
                        "DrawableSwipeRightBackground", "DrawableSwipeDownBackground"
                    })] int p3)
        {
            throw new NotImplementedException();
        }

        public void OnSetGroupItemSwipeBackground(Object p0, int p1,
            [IntDef(Flag = true, Type = "Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable.ISwipeableItemConstants",
                Fields =
                    new[]
                    {
                        "DrawableSwipeNeutralBackground", "DrawableSwipeLeftBackground", "DrawableSwipeUpBackground",
                        "DrawableSwipeRightBackground", "DrawableSwipeDownBackground"
                    })] int p2)
        {
            throw new NotImplementedException();
        }

        public SwipeResultAction OnSwipeChildItem(Object p0, int p1, int p2, int p3)
        {
            throw new NotImplementedException();
        }

        public SwipeResultAction OnSwipeGroupItem(Object p0, int p1, int p2)
        {
            throw new NotImplementedException();
        }

        public override int GetChildCount(int groupIndex)
        {
            return _groupedItemSource.GetChildCount(groupIndex);
        }


        public override long GetChildId(int groupIndex, int childIndex)
        {
            return _groupedItemSource.GetChildId(groupIndex, childIndex);
        }


        public override int GetChildItemViewType(int groupIndex, int childIndex)
        {
            var childItem = _groupedItemSource[groupIndex, childIndex];
            return ChildItemTemplateProvider.GetItemLayoutResourceId(childItem);
        }


        public override long GetGroupId(int p0)
        {
            return _groupedItemSource.GetGroupId(p0);
        }


        public override int GetGroupItemViewType(int p0)
        {
            var groupItem = _groupedItemSource[p0];
            return GroupItemTemplateProvider.GetItemLayoutResourceId(groupItem);
        }

        public override void OnBindChildViewHolder(Object viewHolder, int groupPosition, int childPosition, int viewType)
        {
            throw new NotImplementedException();
        }

        public override void OnBindGroupViewHolder(Object viewHolder, int groupPosition, int viewType)
        {
            throw new NotImplementedException();
        }

        public override bool OnCheckCanExpandOrCollapseGroup(Object holder, int groupPosition, int x, int y, bool expand)
        {
            throw new NotImplementedException();
        }

        public override Object OnCreateChildViewHolder(ViewGroup p0, int viewTypeWhichInFactIsResourceId)
        {
            var itemBindingContext = new MvxAndroidBindingContext(p0.Context, _bindingContext.LayoutInflaterHolder);

            var inflatedView = _bindingContext.BindingInflate(viewTypeWhichInFactIsResourceId, p0, false);
            //var taskChildViewHolder = new TaskGroupChildViewHolder(inflatedView, itemBindingContext, IsRightSwipeOnItemEnabled, IsLeftSwipeOnItemEnabled);
            //ItemTemplateBindings.SetupChildTaskListItem(taskChildViewHolder, inflatedView);
            return null;
        }

        public override Object OnCreateGroupViewHolder(ViewGroup p0, int viewTypeWhichInFactIsResourceId)
        {
            var itemBindingContext = new MvxAndroidBindingContext(p0.Context, _bindingContext.LayoutInflaterHolder);
            var inflatedView = _bindingContext.BindingInflate(viewTypeWhichInFactIsResourceId, p0, false);
        }

        #region Exposed Commands

        private MvxCommand<TChildItem> swipeLeftCommand;
        private MvxCommand<TChildItem> swipeRightCommand;
        private MvxCommand<TChildItem> itemTappedcommand;

        public MvxCommand<TChildItem> SwipeLeftCommand
        {
            get { return swipeLeftCommand; }
            set { SetCommand(ref swipeLeftCommand, value); }
        }

        public MvxCommand<TChildItem> SwipeRightCommand
        {
            get { return swipeRightCommand; }
            set { SetCommand(ref swipeRightCommand, value); }
        }

        public MvxCommand<TChildItem> ItemTappedCommand
        {
            get { return itemTappedcommand; }
            set { SetCommand(ref itemTappedcommand, value); }
        }


        private void SetCommand(ref MvxCommand<TChildItem> commandHolder, MvxCommand<TChildItem> valueToSet,
            [CallerMemberName] string caller = null)
        {
            if (ReferenceEquals(commandHolder, valueToSet))
                return;

            if (commandHolder != null)
                MvxTrace.Warning(
                    $"Changing {caller} may cause inconsistencies where some items still call the old command.");

            commandHolder = valueToSet;
        }

        #endregion


        void OnDataCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            try
            {
                switch (e.Action)
                {
                    // important note about calls to NotifyDataSetChanged in data source was previously empty
                    // it is needed to raise empty view holder recreation
                    // cause recyclerview/adapter is "tricked" - it always has at least one item inside (empty item holder in case of empty data source) 
                    // if call to NotifyDataSetChanged is not made RecyclerView will have old ViewHolder - which is Invalid
                    // therefore recyclerview holder incosistency exception will be thrown

                    //case NotifyCollectionChangedAction.Add:
                    //    if (_taskWorksetGroupsDataProvider.DataSource.Count <= 1 )
                    //        NotifyDataSetChanged();
                    //    else
                    //        this.NotifyItemRangeInserted(e.NewStartingIndex, e.NewItems.Count);
                    //    break;
                    //case NotifyCollectionChangedAction.Move:
                    //    for (int i = 0; i < e.NewItems.Count; i++)
                    //    {
                    //        var oldItem = e.OldItems[i];
                    //        var newItem = e.NewItems[i];

                    //        var itemsSource = _taskWorksetGroupsDataProvider.DataSource;
                    //        this.NotifyItemMoved(itemsSource.GetPosition(oldItem), itemsSource.GetPosition(newItem));
                    //    }
                    //    break;
                    //case NotifyCollectionChangedAction.Replace:
                    //    NotifyItemRangeChanged(e.NewStartingIndex, e.NewItems.Count);
                    //    break;
                    //case NotifyCollectionChangedAction.Remove:
                    //    if (!_taskWorksetGroupsDataProvider.DataSource.Any())
                    //        NotifyDataSetChanged();
                    //    else
                    //        NotifyItemRangeRemoved(e.OldStartingIndex, e.OldItems.Count);
                    //    break;
                    //case NotifyCollectionChangedAction.Reset:
                    //    NotifyDataSetChanged();
                    //    break;
                }
            }
            catch (Exception exception)
            {
                Mvx.Warning("Exception masked during Adapter RealNotifyDataSetChanged {0}", exception.ToLongString());
            }
        }

        private bool IsEmptyViewSupported => EmptyViewLayoutId.HasValue;
    }
}