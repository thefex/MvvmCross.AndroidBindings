using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MvvmCross.Bindings.AdvancedRecyclerView.Validators.ExpandCollapse
{
    class DefaultEnabledExpandCollapseAvailabilityValidator<TGroup> : GroupExpandCollapseAvailabilityValidator<TGroup>
    {
        protected override bool ValidateCanGroupBeExpanded(TGroup groupItem, Point clickedPoint)
        {
            throw new NotImplementedException();
        }

        protected override bool ValidateCanGroupBeCollapsed(TGroup groupItem, Point clickedPoint)
        {
            throw new NotImplementedException();
        }
    }
}