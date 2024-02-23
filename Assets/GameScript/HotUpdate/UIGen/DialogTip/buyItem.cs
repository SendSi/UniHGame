/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class buyItem : GButton
    {
        public GLoader _itemQulityImg;
        public GTextField _itemNumTxt;
        public const string URL = "ui://ymnzz3hqmi7h1ygcfuo";

        public static buyItem CreateInstance()
        {
            return (buyItem)UIPackage.CreateObject("DialogTip", "buyItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _itemQulityImg = (GLoader)GetChild("itemQulityImg");
            _itemNumTxt = (GTextField)GetChild("itemNumTxt");
        }
    }
}