using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    private static ItemDatabase instance;
    public static ItemDatabase Instance {
        get {
            if (instance == null) {
                instance = new ItemDatabase();
            }

            return instance;
        } 
    }

    public Item[] items;
}
