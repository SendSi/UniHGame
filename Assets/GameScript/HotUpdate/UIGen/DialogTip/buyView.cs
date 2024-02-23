/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class buyView : GLabel
    {
        public GButton _closeBtn;
        public GLabel _bg;
        public GRichTextField _contentTxt;
        public GComponent _item;
        public GRichTextField _name;
        public GButton _subBtn;
        public GButton _addBtn;
        public GButton _maxBtn;
        public GSlider _progress;
        public GButton _buyBtn;
        public GGroup _window;
        public const string URL = "ui://ymnzz3hqmi7h1ygcfun";

        public static buyView CreateInstance()
        {
            return (buyView)UIPackage.CreateObject("DialogTip", "buyView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _closeBtn = (GButton)GetChild("closeBtn");
            _bg = (GLabel)GetChild("bg");
            _contentTxt = (GRichTextField)GetChild("contentTxt");
            _item = (GComponent)GetChild("item");
            _name = (GRichTextField)GetChild("name");
            _subBtn = (GButton)GetChild("subBtn");
            _addBtn = (GButton)GetChild("addBtn");
            _maxBtn = (GButton)GetChild("maxBtn");
            _progress = (GSlider)GetChild("progress");
            _buyBtn = (GButton)GetChild("buyBtn");
            _window = (GGroup)GetChild("window");
        }
    }
}