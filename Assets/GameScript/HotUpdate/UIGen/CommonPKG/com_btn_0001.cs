/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonPKG
{
    public partial class com_btn_0001 : GButton
    {
        public Controller _red;
        public red_dot _red_2;
        public const string URL = "ui://2r331opvdfgw1ygcfmg";

        public static com_btn_0001 CreateInstance()
        {
            return (com_btn_0001)UIPackage.CreateObject("CommonPKG", "com_btn_0001");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _red = GetController("red");
            _red_2 = (red_dot)GetChild("red");
        }
    }
}