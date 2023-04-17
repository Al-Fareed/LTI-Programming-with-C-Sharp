using System;
using System.Collections.Generic;

class ItemBO
{
    public Item CreateItem(string data)
    {
        //fill code here
        string itemName = data.Substring(0, 10).Trim();
        string itemTypeName = data.Substring(10, 12).Trim();
        string vendorName = data.Substring(22, 10).Trim();
        List<ItemType> itemTypeList = ItemType.GetItemType();
        ItemType itemType = null;

    foreach (ItemType item in itemTypeList)
    {
        if (item.Name == itemTypeName)
        {
            itemType = item;
            break;
        }
    }

    return new Item(itemName, itemType, vendorName);
    }

    public Dictionary<string, int> ItemtypeCount(List<Item> list) {
        
        Dictionary<string, int> itemTypeCountDict = new Dictionary<string, int>();

    foreach (Item item in list)
    {
        string itemType = item.ItemTypeInsance.Name;
        if (itemTypeCountDict.ContainsKey(itemType))
        {
            itemTypeCountDict[itemType]++;
        }
        else
        {
            itemTypeCountDict.Add(itemType, 1);
        }
    }
    return itemTypeCountDict;
}
}