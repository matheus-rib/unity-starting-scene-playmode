using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

[InitializeOnLoad]
public class Autoplay
{
    static string CurrentScene;
    static readonly string PathOfFirstScene;

    static Autoplay()
    {
        // Load the first Scene's path on Build List
        PathOfFirstScene = EditorBuildSettings.scenes[0].path;

        // Run the update on Editor
        EditorApplication.update += Update;
    }

    static void Update()
    {
        // Get current opened scene's path
        string selectedScene = EditorSceneManager.GetActiveScene().path;

        if(selectedScene != CurrentScene)
        {
            CurrentScene = selectedScene;

            // Get scene's index in Build list, returns -1 if scene is not part of it
            int sceneIndex = SceneUtility.GetBuildIndexByScenePath(selectedScene);
            SceneAsset sceneAsset = sceneIndex >= 0 ?
                sceneAsset = AssetDatabase.LoadAssetAtPath<SceneAsset>(PathOfFirstScene) :
                sceneAsset = AssetDatabase.LoadAssetAtPath<SceneAsset>(selectedScene);
            EditorSceneManager.playModeStartScene = sceneAsset;
        }
    }
}
