using UnityEngine;
using UnityEditor;

static class SetupTool
{
    const int FileCount = 100;

    static string GetFilePath(int index)
      =>$"Assets/Temp/Test{index:000}.jpg";

    [MenuItem("Benchmark/Populate Files")]
    static void PopulateFiles()
    {
        for (var i = 0; i < FileCount; i++)
            FileUtil.CopyFileOrDirectory("Assets/Editor/Test.jpg", GetFilePath(i));
    }


    [MenuItem("Benchmark/Build Asset Bundles")]
    static void BuildAssetBundles()
    {
        var map = new AssetBundleBuild[FileCount];

        for (var i = 0; i < FileCount; i++)
        {
            map[i].assetBundleName = $"Test{i:000}";
            map[i].assetNames = new string [] { GetFilePath(i) };
        }

        var timer = new System.Diagnostics.Stopwatch();
        timer.Start();

        BuildPipeline.BuildAssetBundles
          ("AssetBundles", map, BuildAssetBundleOptions.None, BuildTarget.iOS);

        timer.Stop();

        Debug.Log($"Build Time: {timer.ElapsedMilliseconds / 1000.0f} sec");
    }
}
