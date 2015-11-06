using System.Drawing;

namespace MvvmCross.Bindings.AdvancedRecyclerView.Validators
{
    public abstract class GroupExpandCollapseAvailabilityValidator<TGroupItem>
    {
        public bool ValidateIsActionAvailable(TGroupItem groupItem, Point clickedPoint, bool isExpandedAtCallingTime)
        {
            if (isExpandedAtCallingTime)
                return ValidateCanGroupBeCollapsed(groupItem, clickedPoint);

            return ValidateCanGroupBeExpanded(groupItem, clickedPoint);
        }



        protected abstract bool ValidateCanGroupBeExpanded(TGroupItem groupItem, Point clickedPoint);

        protected abstract bool ValidateCanGroupBeCollapsed(TGroupItem groupItem, Point clickedPoint);
    }

}