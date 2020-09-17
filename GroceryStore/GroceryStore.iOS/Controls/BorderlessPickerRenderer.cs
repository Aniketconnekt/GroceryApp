using GroceryStore.Controls;
using GroceryStore.Droid.Controls;
using System.Runtime.Remoting.Contexts;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderlessPicker), typeof(BorderlessPickerRenderer))]
namespace GroceryStore.Droid.Controls
{
    public class BorderlessPickerRenderer : PickerRenderer
    {
        //public BorderlessPickerRenderer(Context context) : base(context)
        //{
        //}
        public BorderlessPickerRenderer(Context context) 
        {
        }
        public static void Init() { }
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;

                //var layoutParams = new MarginLayoutParams(Control.LayoutParameters);
                //layoutParams.SetMargins(0, 0, 0, 0);
                //LayoutParameters = layoutParams;
                //Control.LayoutParameters = layoutParams;
                //Control.SetPadding(0, 0, 0, 0);
                //SetPadding(0, 0, 0, 0);
            }
        }
    }
}