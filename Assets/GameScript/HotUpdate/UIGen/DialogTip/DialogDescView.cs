/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class DialogDescView : GLabel
    {
        public GButton _closeButton;
        public GLabel _bg;
        public GList _descList;
        public blankTip _blank;
        public GGroup _window;
        public const string URL = "ui://ymnzz3hqj3551ygcfuj";

        public static DialogDescView CreateInstance()
        {
            return (DialogDescView)UIPackage.CreateObject("DialogTip", "DialogDescView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _closeButton = (GButton)GetChild("closeButton");
            _bg = (GLabel)GetChild("bg");
            _descList = (GList)GetChild("descList");
            _blank = (blankTip)GetChild("blank");
            _window = (GGroup)GetChild("window");
        }
    }
}