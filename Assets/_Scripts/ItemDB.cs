using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Item DataBase")]
public class ItemDB : ScriptableObject
{
    [SerializeField] Item[] items;
    public Item[] Items => items;
}
