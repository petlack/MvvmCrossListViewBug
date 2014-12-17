using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using Android.Widget;
using System.Threading.Tasks;
using ListViewBug.Core.ViewModels;

namespace ListViewBug.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class TestListView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
			SetContentView(Resource.Layout.TestListView);
        }

    }
}