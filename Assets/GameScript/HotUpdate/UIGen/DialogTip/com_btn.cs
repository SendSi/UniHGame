/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class com_btn : GButton
    {
        public Controller _state;
        public GLoader _icon01;
        public GRichTextField _descTxt;
        public GComponent _redPoint;
        public const string URL = "ui://ymnzz3hqmi7h1ygcg3h";

        public static com_btn CreateInstance()
        {
            return (com_btn)UIPackage.CreateObject("DialogTip", "com_btn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _state = GetController("state");
            _icon01 = (GLoader)GetChild("icon01");
            _descTxt = (GRichTextField)GetChild("descTxt");
            _redPoint = (GComponent)GetChild("redPoint");
        }
    }
}