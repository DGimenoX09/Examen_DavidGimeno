using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")]

public class ScriptableItems : ScriptableObject

{
    public string itemName;

    public string itemDescription; 

    public int Price;

    public Sprite itemSprite; 
}

