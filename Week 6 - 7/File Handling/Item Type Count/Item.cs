using System;

public class Item
{
    private string _name;
    private ItemType _itemTypeInstance;
    private string _vendorName;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public ItemType ItemTypeInsance
    {
        get { return this._itemTypeInstance; }
        set { this._itemTypeInstance = value; }
    }

    public string VendorName
    {
        get { return this._vendorName; }
        set { this._vendorName = value; }
    }

    public Item() { }

    public Item(string _name, ItemType _itemTypeInstance, string _vendorName)
    {
        this._name = _name;
        this._itemTypeInstance = _itemTypeInstance;
        this._vendorName = _vendorName;
    }
}