using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryManager : MonoBehaviour
{
    public static inventoryManager isntance;
    public ScriptableItems[] weapons;
    public Text[] weaponsNames;
    public Image[] weaponsSprites;
   
    
    void Awake()
    {
        if(isntance != null && isntance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            isntance = this;
        }
    }
    public void AddItem(ScriptableItems item)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;
                weaponsNames[i].text = item.itemName;
                weaponsSprites[i].sprite = item.itemSprite;
                return;
            }
        }
    }

}

