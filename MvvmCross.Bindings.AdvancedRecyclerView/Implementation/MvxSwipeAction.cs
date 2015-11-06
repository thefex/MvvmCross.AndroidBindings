using Cirrious.MvvmCross.ViewModels;
using Com.H6ah4i.Android.Widget.Advrecyclerview.Swipeable.Action;

namespace MvvmCross.Bindings.AdvancedRecyclerView.Implementation
{
    internal class MvxSwipeAction<TItem> : SwipeResultActionMoveToSwipedDirection
    {
        private MvxCommand<TItem> _command;
        private TItem _commandParameter;

        public MvxSwipeAction(MvxCommand<TItem> command, TItem commandParameter)
        {
            _command = command;
            _commandParameter = commandParameter;
        }

        protected override void OnSlideAnimationEnd()
        {
            base.OnSlideAnimationEnd();

            if (_commandParameter != null)
                _command?.Execute(_commandParameter);
        }

        protected override void OnCleanUp()
        {
            base.OnCleanUp();
            _command = null;
            _commandParameter = default(TItem);
        }
    }
}