using DevExpress.Themes.ColorKeys;
using DevExpress.Themes.Generic;
using Windows.UI;

namespace ColosSchemesDemo1.Themes
{
    public class CustomColorScheme : GenericColorScheme
    {
        public CustomColorScheme(string name) : base(name){}
        protected override void Initialize()
        {
            base.Initialize();
            AllScopes.RibbonControlColors[RibbonControlColorKeys.HeaderBackground]
                = new DevExpress.Themes.ColorSet(Color.FromArgb(0xFF, 0x41, 0x83, 0x66), Color.FromArgb(0xFF, 0x16, 0x4B, 0x2F));
            AllScopes.RibbonControlColors[RibbonControlColorKeys.TitleForeground]
                = new DevExpress.Themes.ColorSet(Colors.Yellow, Colors.Orange);
        }
    }
}
