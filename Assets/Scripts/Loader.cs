using UnityEngine;
using UnityEngine.UIElements;
using Stopwatch = System.Diagnostics.Stopwatch;

public sealed class Loader : MonoBehaviour
{
    async Awaitable Start()
    {
        var label = GetComponent<UIDocument>().rootVisualElement.Q<Label>();

        label.text = "Loading...";
        await Awaitable.NextFrameAsync();

        var bundlePath = Application.streamingAssetsPath + "/test";
        var sum = 0.0f;

        var sw = new Stopwatch();
        sw.Start();
        for (var i = 0; i < 1000; i++) sum += RunTest(bundlePath);
        sw.Stop();

        label.text = $"Elapsed: {sw.ElapsedMilliseconds}\n" +
                     $"Checksum: {sum}";
    }

    float RunTest(string path)
    {
        var bundle = AssetBundle.LoadFromFile(path);
        var sum = 0.0f;
        foreach (var obj in bundle.LoadAllAssets<TestContainer>())
            sum += obj.v127.x;
        bundle.Unload(true);
        Destroy(bundle);
        return sum;
    }
}
