/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class tips02 : GLabel
    {
        public Controller _quality;
        public GButton _closeButton;
        public GImage _bg;
        public GTextField _name;
        public GTextField _w;
        public const string URL = "ui://ymnzz3hqpx1c1ygcg3p";

        public static tips02 CreateInstance()
        {
            return (tips02)UIPackage.CreateObject("DialogTip", "tips02");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _quality = GetController("quality");
            _closeButton = (GButton)GetChild("closeButton");
            _bg = (GImage)GetChild("bg");
            _name = (GTextField)GetChild("name");
            _w = (GTextField)GetChild("w");
        }
    }
}