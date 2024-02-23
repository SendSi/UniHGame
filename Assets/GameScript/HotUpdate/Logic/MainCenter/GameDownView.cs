using CodiceApp.EventTracking.Plastic;
using FairyGUI;
using UnityEngine;
using YooAsset;

namespace MainCenter
{
    public partial class GameDownView : GComponent
    {
        private long timeIndex = 0;

        public override void OnInit()
        {
            base.OnInit();

            this._againBtn.onClick.Set(OnClickAgain);
            this._quitBtn.onClick.Set(OnClickQuit);

            timeIndex = 0;
            FairyGUI.Timers.inst.Add(1, -1, OnTimerMethod);

            EventCenter.Instance.Bind(EventEnum.EE_Down_die, OnEventDie);
        }

        private void OnEventDie()
        {
            Time.timeScale = 0;
            this._gameCtrl.selectedIndex = 1;
        }

        private void OnTimerMethod(object param)
        {
            timeIndex++;
            this._timeScoreTxt.text = timeIndex.ToString("00");
        }

        private void OnClickAgain()
        {
            timeIndex = 0;
            Time.timeScale = 1;
            this._gameCtrl.selectedIndex =0;
            DownMgr.Instance.ResetGameStart();
        }

        private void OnClickQuit()
        {
            Time.timeScale = 1;
            ProxyMainCenterModule.Instance.CloseGameDownView();
            ProxyMainCenterModule.Instance.OpenMainCenterView();
        }

        public override void Dispose()
        {
            base.Dispose();
            EventCenter.Instance.UnBind(EventEnum.EE_Down_die, OnEventDie);
            DownMgr.Instance.Dispose();
            FairyGUI.Timers.inst.Remove(OnTimerMethod);
        }
    }
}