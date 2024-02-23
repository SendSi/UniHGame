/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DialogTip
{
    public partial class resultItem : GButton
    {
        public Controller _quaBottomCtrl;
        public Controller _isArtifact;
        public GLoader _itemQulityImg;
        public GTextField _itemNumTxt;
        public GTextField _itemNameTxt;
        public GTextField _numTxt;
        public const string URL = "ui://ymnzz3hq7j8t1ehxf1a";

        public static resultItem CreateInstance()
        {
            return (resultItem)UIPackage.CreateObject("DialogTip", "resultItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _quaBottomCtrl = GetController("quaBottomCtrl");
            _isArtifact = GetController("isArtifact");
            _itemQulityImg = (GLoader)GetChild("itemQulityImg");
            _itemNumTxt = (GTextField)GetChild("itemNumTxt");
            _itemNameTxt = (GTextField)GetChild("itemNameTxt");
            _numTxt = (GTextField)GetChild("numTxt");
        }
    }
}