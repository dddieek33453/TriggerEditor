using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Triggers;
[CustomEditor(typeof(AcEnabledMonoBehaviour), true), CanEditMultipleObjects]
public class AcEnabledMonoBehaviourEditor : TriggerActionEditor {
    SerializedProperty mono;
    SerializedProperty enabled;

    public override void DrawGUI(SerializedObject serializedObject, Rect position) {
        position.y += 18;
        EditorGUI.PropertyField(position, mono, new GUIContent("Mono"));
        position.y += 18;
        EditorGUI.PropertyField(position, enabled, new GUIContent("Enabled"));
    }

    public override void OnTriggerEnable(SerializedObject serializedObject) {
        mono = serializedObject.FindProperty("mono");
        enabled = serializedObject.FindProperty("enabled");
    }
}
