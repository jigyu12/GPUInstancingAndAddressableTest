using System;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class AddressableManager : MonoBehaviour
{
    public AssetLabelReference label;
    
    void Start()
    {
        LoadAssetAsync().Forget();
    }

    private async UniTask LoadAssetAsync()
    { 
        /*
        var handle = Addressables.LoadAssetAsync<GameObject>("CubePrefab");
        var prefab = await handle.Task;

        var go = Instantiate(prefab);

        await UniTask.Delay(TimeSpan.FromSeconds(5));

        Destroy(go);
        Addressables.Release(handle);
        */
        var cube = await Addressables.InstantiateAsync("CubePrefab");
        await UniTask.Delay(TimeSpan.FromSeconds(5)); 
        Addressables.ReleaseInstance(cube);

        await SceneManager.LoadSceneAsync("SampleScene 2", LoadSceneMode.Single);
    }
}