/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class getWayItem01 : GComponent
    {
        public GButton _btnGoTo;
        public GTextField _title;
        public const string URL = "ui://ymnzz3hqpx1c1ygcg3n";

        public static getWayItem01 CreateInstance()
        {
            return (getWayItem01)UIPackage.CreateObject("DialogTip", "getWayItem01");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _btnGoTo = (GButton)GetChild("btnGoTo");
            _title = (GTextField)GetChild("title");
        }
    }
}