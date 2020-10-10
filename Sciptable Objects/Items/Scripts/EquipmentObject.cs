using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Equipment")]
public class EquipmentObject : ItemObject
{
    public int level;
    public int attackDamage;
    public float attackSpeed;
    public int defenceBonus;
    public equipmentType equipmentGenre;

    // REQUIRMENT SECTION
    public int reqLevel;
    public int reqStr;
    public int reqInt;
    public int reqDex;
    
    public enum equipmentType
    {
        Armor,
        Helmet,
        Boots,
        Pants,
        Shield,
        Weapon,
        Necklase,
        Ring
    }

    private void Awake() {
        type = itemType.Equipment;
        stackableSize = 1;
    }
}
