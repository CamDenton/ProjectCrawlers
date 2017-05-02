using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(InventoryScript))]
public class InventoryScriptEditor : Editor {
    private SerializedProperty itemsImagesProperty;
    private SerializedProperty itemsProperty;
    private bool[] showItemSlots = new bool[InventoryScript.slots];

    private const string inventoryPropItemimagesName = "itemImage";
    private const string inventoryPropItemName = "items";

    private void OnEnable()
    {
        itemsImagesProperty = serializedObject.FindProperty(inventoryPropItemimagesName);
        itemsProperty = serializedObject.FindProperty(inventoryPropItemName);
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        for (int i = 0; i < InventoryScript.slots; i++)
        {
            ItemSlotGui(i);
        }

        serializedObject.ApplyModifiedProperties();
    }

    private void ItemSlotGui (int index)
    {
        EditorGUILayout.BeginVertical(GUI.skin.box);
        EditorGUI.indentLevel++;
        showItemSlots[index] = EditorGUILayout.Foldout(showItemSlots[index], "item slot" + index);
        if(showItemSlots[index])
        {
            EditorGUILayout.PropertyField(itemsImagesProperty.GetArrayElementAtIndex(index));
            EditorGUILayout.PropertyField(itemsProperty.GetArrayElementAtIndex(index));
        }
        EditorGUI.indentLevel--;
        EditorGUILayout.EndVertical();
    }

}
