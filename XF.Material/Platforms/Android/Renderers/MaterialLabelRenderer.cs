using System.ComponentModel;

using Android.Content;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using XF.Material.Droid.Renderers;
using XF.Material.Forms.UI;

[assembly: ExportRenderer(typeof(MaterialLabel), typeof(MaterialLabelRenderer))]
namespace XF.Material.Droid.Renderers
{
    public class MaterialLabelRenderer : LabelRenderer
    {
        private new MaterialLabel Element => base.Element as MaterialLabel;

        public MaterialLabelRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e?.NewElement == null)
            {
                return;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}
