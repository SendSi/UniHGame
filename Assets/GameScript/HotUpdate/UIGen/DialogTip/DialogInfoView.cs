/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class DialogInfoView : GLabel
    {
        public GButton _closeButton;
        public GLabel _bg;
        public GRichTextField _des;
        public GGroup _group;
        public const string URL = "ui://ymnzz3hqk8da1ygcg3m";

        public static DialogInfoView CreateInstance()
        {
            return (DialogInfoView)UIPackage.CreateObject("DialogTip", "DialogInfoView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _closeButton = (GButton)GetChild("closeButton");
            _bg = (GLabel)GetChild("bg");
            _des = (GRichTextField)GetChild("des");
            _group = (GGroup)GetChild("group");
        }
    }
}