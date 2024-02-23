/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ItemPKG
{
    public partial class UI_red_dot : GComponent
    {
        public GImage m_red_dot;
        public const string URL = "ui://m9pqa398bcay1ygcfxo";

        public static UI_red_dot CreateInstance()
        {
            return (UI_red_dot)UIPackage.CreateObject("ItemPKG", "red_dot");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_red_dot = (GImage)GetChild("red_dot");
        }
    }
}