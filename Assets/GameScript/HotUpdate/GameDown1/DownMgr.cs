using System;
using System.Collections.Generic;
using UnityEngine;
using YooAsset;
using Random = UnityEngine.Random;

public class DownMgr : Singleton<DownMgr>
{
    private Vector3 bottomGoPos;
    private GameObject bottomGo;
    private List<string> baseTrans = new List<string>() { "base1", "base2", "base3" };
    private AssetHandle _bgHandle;
    private GameObject _bgGameObj;
    private GameObject _playerGameObj;
    private AssetHandle _playerAH;
    private Vector3 _playerObjPos = new Vector3(-0.3f, 4.45f, -0.9f);

    public void StartDown()
    {
        CreateDownBg(delegate
        {
            FairyGUI.Timers.inst.Add(0.7f, -1, OnTimerRepeat);
            bottomGo = GameObject.Find("bottomLine");
            bottomGoPos = bottomGo.transform.position;

            GeneratePlatformPlayer();
        });
    }
    void CreateDownBg(Action act)
    {
        _bgHandle = YooAssets.LoadAssetAsync<GameObject>("GameDown");
        _bgHandle.Completed += (AssetHandle actGO) =>
        {
            var pos = new Vector3(0, 0.4f, -0.8f);
            _bgGameObj = actGO.InstantiateSync(pos, Quaternion.identity, null);

            act?.Invoke();
        };
    }

    public void ResetGameStart()
    {
        ClearPrefabs();

        GeneratePlatformPlayer();
    }


    void GeneratePlatformPlayer()
    {
        var handle = YooAssets.LoadAssetAsync<GameObject>(baseTrans[0]);
        handle.Completed += (AssetHandle actGO) =>
        {
            var instGO = actGO.InstantiateSync(new Vector3(-0.2f, -3.7f, bottomGoPos.z), Quaternion.identity, bottomGo.transform);
            _fanListGo.Add(instGO);
        };
        _fanListAH.Add(handle);

        _playerAH = YooAssets.LoadAssetAsync<GameObject>("player");
        _playerAH.Completed += (AssetHandle actGO) =>
        {
            _playerGameObj = actGO.InstantiateSync(_playerObjPos, Quaternion.identity, _bgGameObj.transform);
        };
    }


    private List<AssetHandle> _fanListAH = new List<AssetHandle>();
    private List<GameObject> _fanListGo = new List<GameObject>();
    private float offsetTime = 2;
    private int tmpIndex = 0;

    private void OnTimerRepeat(object param)
    {
        tmpIndex++;
        if (tmpIndex >= offsetTime)
        {
            tmpIndex = 0;
            int tIndex = Random.Range(0, baseTrans.Count);

            var handle = YooAssets.LoadAssetAsync<GameObject>(baseTrans[tIndex]);
            handle.Completed += (AssetHandle actGO) =>
            {
                var instGO = actGO.InstantiateSync(new Vector3(Random.Range(-2.5f, 2.5f), bottomGoPos.y, bottomGoPos.z), Quaternion.identity, bottomGo.transform);
                _fanListGo.Add(instGO);
            };
            _fanListAH.Add(handle);
        }
    }


    protected override void OnDispose()
    {
        base.OnDispose();
        ClearPrefabs();

        if (_bgGameObj != null)
        {
            GameObject.Destroy(_bgGameObj);
            _bgHandle.Release();
        }

        FairyGUI.Timers.inst.Remove(OnTimerRepeat);
    }


    void ClearPrefabs()
    {
        foreach (var item in _fanListAH)
        {
            item.Release();
        }

        foreach (var item in _fanListGo)
        {
            GameObject.Destroy(item);
        }

        _fanListAH.Clear();
        _fanListGo.Clear();

        if (_playerGameObj != null)
        {
            GameObject.Destroy(_playerGameObj);
            _playerAH.Release();
        }
    }
}