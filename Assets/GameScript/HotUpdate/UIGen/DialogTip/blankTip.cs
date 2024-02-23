/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class blankTip : GComponent
    {
        public GTextField _blankTxt;
        public const string URL = "ui://ymnzz3hqinnx1ygcfum";

        public static blankTip CreateInstance()
        {
            return (blankTip)UIPackage.CreateObject("DialogTip", "blankTip");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _blankTxt = (GTextField)GetChild("blankTxt");
        }
    }
}