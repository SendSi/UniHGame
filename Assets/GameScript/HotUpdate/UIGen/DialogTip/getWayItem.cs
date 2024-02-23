/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class getWayItem : GComponent
    {
        public GComponent _iconT;
        public GButton _btnGoTo;
        public GTextField _title;
        public const string URL = "ui://ymnzz3hqj3551ygcfui";

        public static getWayItem CreateInstance()
        {
            return (getWayItem)UIPackage.CreateObject("DialogTip", "getWayItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _iconT = (GComponent)GetChild("iconT");
            _btnGoTo = (GButton)GetChild("btnGoTo");
            _title = (GTextField)GetChild("title");
        }
    }
}