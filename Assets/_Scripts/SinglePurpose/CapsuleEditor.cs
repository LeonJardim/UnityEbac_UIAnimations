using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Capsule))]
public class CapsuleEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        Capsule myTarget = (Capsule)target;

        myTarget.capsulePreFab = (GameObject)EditorGUILayout.ObjectField(myTarget.capsulePreFab, typeof(GameObject), true);

        if (GUILayout.Button("Create Capsule"))
        {
            myTarget.CreateCapsule();
        }
    }
}
