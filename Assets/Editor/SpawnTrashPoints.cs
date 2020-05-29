using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(SpawnTrash), true)]
public class SpawnTrashPoints :Editor
{
    [SerializeField]
    private AudioSource _previewer;
    private void OnEnable()
    {
        _previewer = EditorUtility.CreateGameObjectWithHideFlags(
          "Audio preview",
          HideFlags.HideAndDontSave,
          typeof(AudioSource)).GetComponent<AudioSource>();
    }

    public void OnDisable()
    {
        DestroyImmediate(_previewer.gameObject);
    }
    public override void OnInspectorGUI()
    {

        EditorGUI.BeginDisabledGroup(serializedObject.isEditingMultipleObjects);
        if (GUILayout.Button("CYKA BLYAT"))
        {

        }
        DrawDefaultInspector();
        EditorGUI.EndDisabledGroup();
    }
}

