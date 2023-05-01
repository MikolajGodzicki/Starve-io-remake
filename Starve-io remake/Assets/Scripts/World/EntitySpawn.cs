using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EntitySpawn : MonoBehaviour
{
    [SerializeField] private GameObject rockPrefab;
    [SerializeField] private GameObject[] treePrefab;
    [SerializeField] private GameObject ironPrefab;
    [SerializeField] private GameObject goldPrefab;

    private void SpawnObject(Object obj, Vector2Int rotation, int rotationMultiplier = 1) {
        for (int x = -250; x < 250; x++) {
            for (int y = -250; y < 250; y++) {
                int num = Random.Range(0, 300);
                if (num == 1) {
                    GameObject gameObject = PrefabUtility.InstantiatePrefab(obj) as GameObject;

                    gameObject.transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(rotation.x, rotation.y) * rotationMultiplier);
                    gameObject.transform.position = new Vector3(x, y, 0);
                    gameObject.transform.parent = transform;
                }
            }
        }
    }

    [ContextMenu("Create Rocks")]
    public void SpawnRocks() => SpawnObject(rockPrefab, new Vector2Int(0, 360));

    [ContextMenu("Create Trees")]
    public void SpawnTrees() => SpawnObject(treePrefab[Random.Range(0, treePrefab.Length)], new Vector2Int(0, 4), 90);

    [ContextMenu("Create Irons")]
    public void SpawnIrons() => SpawnObject(ironPrefab, new Vector2Int(0, 360));

    [ContextMenu("Create Gold")]
    public void SpawnGolds() => SpawnObject(goldPrefab, new Vector2Int(0, 360));
}
