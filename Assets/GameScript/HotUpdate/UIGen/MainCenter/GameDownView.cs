/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainCenter
{
    public partial class GameDownView : GComponent
    {
        public Controller _gameCtrl;
        public GTextField _timeScoreTxt;
        public GButton _againBtn;
        public GButton _quitBtn;
        public Transition _quit;
        public Transition _approach;
        public Transition _a_personalboss;
        public Transition _a_worldboss;
        public const string URL = "ui://4ni413lajn1l1ygcg9o";

        public static GameDownView CreateInstance()
        {
            return (GameDownView)UIPackage.CreateObject("MainCenter", "GameDownView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            _gameCtrl = GetController("gameCtrl");
            _timeScoreTxt = (GTextField)GetChild("timeScoreTxt");
            _againBtn = (GButton)GetChild("againBtn");
            _quitBtn = (GButton)GetChild("quitBtn");
            _quit = GetTransition("quit");
            _approach = GetTransition("approach");
            _a_personalboss = GetTransition("a_personalboss");
            _a_worldboss = GetTransition("a_worldboss");
        }
    }
}