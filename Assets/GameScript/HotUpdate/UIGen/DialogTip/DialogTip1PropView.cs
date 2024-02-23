/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class DialogTip1PropView : GLabel
    {
        public GButton _closeButton;
        public GLabel _bg;
        public GButton _btnCenter;
        public GTextField _contentTxt;
        public GGroup _window;
        public const string URL = "ui://ymnzz3hqk2hl5";

        public static DialogTip1PropView CreateInstance()
        {
            return (DialogTip1PropView)UIPackage.CreateObject("DialogTip", "DialogTip1PropView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _closeButton = (GButton)GetChild("closeButton");
            _bg = (GLabel)GetChild("bg");
            _btnCenter = (GButton)GetChild("btnCenter");
            _contentTxt = (GTextField)GetChild("contentTxt");
            _window = (GGroup)GetChild("window");
        }
    }
}