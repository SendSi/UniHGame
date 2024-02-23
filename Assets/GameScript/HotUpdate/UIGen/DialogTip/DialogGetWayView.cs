/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class DialogGetWayView : GLabel
    {
        public GButton _closeButton;
        public GLabel _bg;
        public GTextField _titleDescTxt;
        public GList _getWayList;
        public GButton _btnNext;
        public GGroup _window;
        public const string URL = "ui://ymnzz3hqj3551ygcfuh";

        public static DialogGetWayView CreateInstance()
        {
            return (DialogGetWayView)UIPackage.CreateObject("DialogTip", "DialogGetWayView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _closeButton = (GButton)GetChild("closeButton");
            _bg = (GLabel)GetChild("bg");
            _titleDescTxt = (GTextField)GetChild("titleDescTxt");
            _getWayList = (GList)GetChild("getWayList");
            _btnNext = (GButton)GetChild("btnNext");
            _window = (GGroup)GetChild("window");
        }
    }
}