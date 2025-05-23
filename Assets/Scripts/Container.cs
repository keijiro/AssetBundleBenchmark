#if UNITY_EDITOR
using UnityEditor;
using System.IO;
#endif
using UnityEngine;

public sealed class TestContainer : ScriptableObject
{
#if UNITY_EDITOR

    [MenuItem("Assets/Create/Test Container (Randomized)")]
    static void CreateAsset()
    {
        var asset = ScriptableObject.CreateInstance<TestContainer>();

        foreach (var field in typeof(TestContainer).GetFields())
            if (field.FieldType == typeof(Vector3))
                field.SetValue(asset, Random.insideUnitSphere);

        var path = AssetDatabase.GenerateUniqueAssetPath("Assets/TestContainer.asset");
        AssetDatabase.CreateAsset(asset, path);
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }

    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
        var dirPath = "AssetBundles";
        if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);
        BuildPipeline.BuildAssetBundles
          (dirPath,
           BuildAssetBundleOptions.None,
           //BuildAssetBundleOptions.DisableWriteTypeTree,
           EditorUserBuildSettings.activeBuildTarget);
        File.Copy(dirPath + "/test", "Assets/StreamingAssets/test", true);
    }

#endif

    public Vector3 v000;
    public Vector3 v001;
    public Vector3 v002;
    public Vector3 v003;
    public Vector3 v004;
    public Vector3 v005;
    public Vector3 v006;
    public Vector3 v007;
    public Vector3 v008;
    public Vector3 v009;
    public Vector3 v010;
    public Vector3 v011;
    public Vector3 v012;
    public Vector3 v013;
    public Vector3 v014;
    public Vector3 v015;
    public Vector3 v016;
    public Vector3 v017;
    public Vector3 v018;
    public Vector3 v019;
    public Vector3 v020;
    public Vector3 v021;
    public Vector3 v022;
    public Vector3 v023;
    public Vector3 v024;
    public Vector3 v025;
    public Vector3 v026;
    public Vector3 v027;
    public Vector3 v028;
    public Vector3 v029;
    public Vector3 v030;
    public Vector3 v031;
    public Vector3 v032;
    public Vector3 v033;
    public Vector3 v034;
    public Vector3 v035;
    public Vector3 v036;
    public Vector3 v037;
    public Vector3 v038;
    public Vector3 v039;
    public Vector3 v040;
    public Vector3 v041;
    public Vector3 v042;
    public Vector3 v043;
    public Vector3 v044;
    public Vector3 v045;
    public Vector3 v046;
    public Vector3 v047;
    public Vector3 v048;
    public Vector3 v049;
    public Vector3 v050;
    public Vector3 v051;
    public Vector3 v052;
    public Vector3 v053;
    public Vector3 v054;
    public Vector3 v055;
    public Vector3 v056;
    public Vector3 v057;
    public Vector3 v058;
    public Vector3 v059;
    public Vector3 v060;
    public Vector3 v061;
    public Vector3 v062;
    public Vector3 v063;
    public Vector3 v064;
    public Vector3 v065;
    public Vector3 v066;
    public Vector3 v067;
    public Vector3 v068;
    public Vector3 v069;
    public Vector3 v070;
    public Vector3 v071;
    public Vector3 v072;
    public Vector3 v073;
    public Vector3 v074;
    public Vector3 v075;
    public Vector3 v076;
    public Vector3 v077;
    public Vector3 v078;
    public Vector3 v079;
    public Vector3 v080;
    public Vector3 v081;
    public Vector3 v082;
    public Vector3 v083;
    public Vector3 v084;
    public Vector3 v085;
    public Vector3 v086;
    public Vector3 v087;
    public Vector3 v088;
    public Vector3 v089;
    public Vector3 v090;
    public Vector3 v091;
    public Vector3 v092;
    public Vector3 v093;
    public Vector3 v094;
    public Vector3 v095;
    public Vector3 v096;
    public Vector3 v097;
    public Vector3 v098;
    public Vector3 v099;
    public Vector3 v100;
    public Vector3 v101;
    public Vector3 v102;
    public Vector3 v103;
    public Vector3 v104;
    public Vector3 v105;
    public Vector3 v106;
    public Vector3 v107;
    public Vector3 v108;
    public Vector3 v109;
    public Vector3 v110;
    public Vector3 v111;
    public Vector3 v112;
    public Vector3 v113;
    public Vector3 v114;
    public Vector3 v115;
    public Vector3 v116;
    public Vector3 v117;
    public Vector3 v118;
    public Vector3 v119;
    public Vector3 v120;
    public Vector3 v121;
    public Vector3 v122;
    public Vector3 v123;
    public Vector3 v124;
    public Vector3 v125;
    public Vector3 v126;
    public Vector3 v127;
}
