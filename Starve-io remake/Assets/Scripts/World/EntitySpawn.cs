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

    [ContextMenu("Create Rocks")]
    public void SpawnRocks() {
        for (int x = -250; x < 250; x++) {
            for (int y = -250; y < 250; y++) {
                int num = Random.Range(0, 300);
                if (num == 1) {
                    GameObject gameObject = PrefabUtility.InstantiatePrefab(rockPrefab) as GameObject;

                    gameObject.transform.position = new Vector3(x, y, 0);
                    gameObject.transform.parent = transform;
                }
            }
        }
    }

    [ContextMenu("Create Trees")]
    public void SpawnTrees() {
        for (int x = -250; x < 250; x++) {
            for (int y = -250; y < 250; y++) {
                int num = Random.Range(0, 200);
                if (num == 1) {
                    GameObject gameObject = PrefabUtility.InstantiatePrefab(treePrefab[Random.Range(0, treePrefab.Length)]) as GameObject;

                    gameObject.transform.position = new Vector3(x, y, 0);
                    gameObject.transform.parent = transform;
                }
            }
        }
    }

    [ContextMenu("Create Irons")]
    public void SpawnIrons() {
        for (int x = -250; x < 250; x++) {
            for (int y = -250; y < 250; y++) {
                int num = Random.Range(0, 700);
                if (num == 1) {
                    GameObject gameObject = PrefabUtility.InstantiatePrefab(ironPrefab) as GameObject;

                    gameObject.transform.position = new Vector3(x, y, 0);
                    gameObject.transform.parent = transform;
                }
            }
        }
    }

    [ContextMenu("Create Gold")]
    public void SpawnGolds() {
        for (int x = -250; x < 250; x++) {
            for (int y = -250; y < 250; y++) {
                int num = Random.Range(0, 1000);
                if (num == 1) {
                    GameObject gameObject = PrefabUtility.InstantiatePrefab(goldPrefab) as GameObject;

                    gameObject.transform.position = new Vector3(x, y, 0);
                    gameObject.transform.parent = transform;
                }
            }
        }
    }
}
