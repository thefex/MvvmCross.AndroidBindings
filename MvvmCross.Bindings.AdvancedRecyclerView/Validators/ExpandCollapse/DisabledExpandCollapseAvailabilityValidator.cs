using System.Drawing;

namespace MvvmCross.Bindings.AdvancedRecyclerView.Validators.ExpandCollapse
{
    public class DisabledExpandCollapseAvailabilityValidator<TGroupItem> : GroupExpandCollapseAvailabilityValidator<TGroupItem>
    {
        protected override bool ValidateCanGroupBeExpanded(TGroupItem groupItem, Point clickedPoint)
        {
            return false;
        }

        protected override bool ValidateCanGroupBeCollapsed(TGroupItem groupItem, Point clickedPoint)
        {
            return false;
        }
    }
}