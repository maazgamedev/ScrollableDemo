using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[System.Serializable]
public class Item
{
    public Sprite icon;
    public string name = "Item name";
    public string description = "Lorem ipsum dolor sit amet";
    public float cost = 0;

    public Item(Sprite icon, string name, float cost, string description)
    {
        this.icon = icon;
        this.name = name;
        this.description = description;
        this.cost = cost;
    }
}

public class ShopSystem : MonoBehaviour
{
    [SerializeField] ItemDB itemDB;

    //testing, do not populate from inspector
    [SerializeField] List<Item> shopEntries;

    [SerializeField] GameObject shopEntryPrefab;
    [SerializeField] Transform shopEntryParent;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in itemDB.Items)
        {
            shopEntries.Add(item);

            var newEntry = Instantiate(shopEntryPrefab, shopEntryParent);
            var entryIcon = newEntry.transform.Find("icon-holder").Find("icon").GetComponent<Image>();
            var entryName = newEntry.transform.Find("flavor-text").Find("name").GetComponent<TMP_Text>();
            var entryDescription = newEntry.transform.Find("flavor-text").Find("description").GetComponent<TMP_Text>();
            var entryCost = newEntry.transform.Find("buy-btn").Find("cost").GetComponent<TMP_Text>();

            entryIcon.sprite = item.icon;
            entryName.SetText(item.name);
            entryDescription.SetText(item.description);
            entryCost.SetText("$" + item.cost);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
