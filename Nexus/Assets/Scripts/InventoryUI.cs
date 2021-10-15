
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    public GameObject inventoryUI;

    Inventory inventory;

    InventorySlot[] slots;

    public GameObject _player;
    //private FPSControllerrScript _canMove;

    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();

        inventoryUI.SetActive(false);

        //  FPSControllerrScript _canMove = _player.GetComponent<FPSControllerrScript>().canMove;
       // FPSControllerrScript _canMove = GameObject.Find("Player").GetComponent<FPSControllerrScript>().canMove;

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);

            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }

            if (Cursor.visible == true)
            {
                Cursor.visible = false;
            }
            else
            {
                Cursor.visible = true;
            }

            /*(_canMove.MethodName(canMove) == true);
            if (_canMove == true)
            {
                _canMove = false;
            }
            else
            {
                _canMove = true;
            }*/
        }



    }

    void UpdateUI()
    {


        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);

            }
            else
            {
                slots[i].ClearSlot();
            }
        }

    }
}

