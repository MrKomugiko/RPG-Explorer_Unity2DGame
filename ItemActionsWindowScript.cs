using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActionsWindowScript : MonoBehaviour
{

    [SerializeField] private ItemObject _clickedItem;
    [SerializeField] private int _clickedItemSlotIntex;
    [SerializeField] private GameObject ItemDetailsWindow;
    [SerializeField] private ItemDataHolderScript itemScript;


    public ItemObject ClickedItem { get => _clickedItem; set => _clickedItem = value; }

    void Start()
    {

    }

    void Update()
    {
        
    }
    public void OpenAndPassItemDataToActionListWindow(ItemObject item, int itemSlotIndex) {
        this.gameObject.SetActive(true);
        itemScript = GameObject.Find("PlayerInventory").transform.GetChild(_clickedItemSlotIntex).GetComponentInChildren<ItemDataHolderScript>();
        ClickedItem = item;
        _clickedItemSlotIntex = itemSlotIndex;
        Debug.Log(item.name);

    }
    public void OnClickOpenItemDetailsWindow() {
        itemScript = GameObject.Find("PlayerInventory").transform.GetChild(_clickedItemSlotIntex).GetComponentInChildren<ItemDataHolderScript>();

        itemScript.DisplayTooltipWithItemInfo(ClickedItem);
        Debug.Log("Open Details");
    }
    public void OnClickUseItem() {
        itemScript = GameObject.Find("PlayerInventory").transform.GetChild(_clickedItemSlotIntex).GetComponentInChildren<ItemDataHolderScript>();
        // TODO: probably need doubble check requirment from this "use item" acces level
        Debug.Log("Item "+itemScript.itemData.item.name);
        itemScript.UseItem();
        this.gameObject.SetActive(false);
    }
    public void OnClickCompareItemWithAlreadyWearedOne() {
        // NOT IMPLEMENTED
    }
    public void OnClickDestroyItem() {
       
       this.gameObject.SetActive(false);
        Destroy(itemScript.gameObject);
        Debug.Log("Item destroyed");

    }

    public void OnClickCloseWindow() {
        this.gameObject.SetActive(false);
    }
}
