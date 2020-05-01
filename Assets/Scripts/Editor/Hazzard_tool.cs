using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class MyTool : EditorWindow
{

    GameObject hazzardToSpawn;
    float objectRotation;
    float speedRotation;
    int spawnDistance;
    bool groupEnabled = true;
    float orientation;

    Transform pathA, pathB;

    [MenuItem("Tools/Hazzard_Tool")]
    static void Init() {
        MyTool MyTool = GetWindow<MyTool>();
        MyTool.Show();
    }

    void OnGUI() {
        GUILayout.Label("Spawn Hazzard", EditorStyles.boldLabel);

        hazzardToSpawn = EditorGUILayout.ObjectField("Hazzard to Spawn", hazzardToSpawn, typeof(GameObject), false) as GameObject;

        if (GUILayout.Button("Clean")) {
            hazzardToSpawn = null;
        }

        pathA = EditorGUILayout.ObjectField("Initial Point A", pathA, typeof(Transform), false) as Transform;
        pathB = EditorGUILayout.ObjectField("Initial Point B", pathB, typeof(Transform), false) as Transform;
        objectRotation = EditorGUILayout.Slider("Hazzard Rotation", objectRotation,0f,360f);
        spawnDistance = EditorGUILayout.IntField("Distance to Spawn", spawnDistance);
        speedRotation = EditorGUILayout.FloatField("Rotation Speed", speedRotation);
        groupEnabled = EditorGUILayout.BeginToggleGroup("It has blades?", groupEnabled);
        orientation = EditorGUILayout.Slider("Blades Orientation", orientation, -1f, 1f);
        EditorGUILayout.EndToggleGroup();




        if (GUILayout.Button("Spawn Hazzard")) {
            SpawnObject();
        }
    }


    void SpawnObject() {


        Vector3 spawnDistance = new Vector3(0, 0, 0);

        GameObject newObject = Instantiate(hazzardToSpawn, spawnDistance, Quaternion.identity);
    }

}
