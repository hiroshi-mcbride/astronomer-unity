using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Utility
{
    public static readonly Vector3 InvalidEndpoint = new(float.MaxValue, float.MaxValue, float.MaxValue);
    
    public static void LoadScene(string _name) {
        SceneManager.LoadScene(_name);
    }


#if UNITY_EDITOR
    public static void RefreshSceneView() {
        SceneView.RepaintAll();
        EditorApplication.QueuePlayerLoopUpdate();
    }
#endif
}
