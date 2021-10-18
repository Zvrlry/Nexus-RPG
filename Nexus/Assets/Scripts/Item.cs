
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]

public class Item : ScriptableObject
{
	new public string name = "new item"; //name of the item
	public Sprite icon = null;			//Item Icon
	public bool isDefaultItem = false;	//Is the item default wear? 

	//called when the item i pressed in the inventory
	public virtual void Use()
	{
		
		Debug.Log("Using " + name);
	}

	public void RemoveFromInventory()
	{
		Inventory.instance.Remove(this);
	}
}
