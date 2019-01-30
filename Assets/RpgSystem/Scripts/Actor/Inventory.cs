using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    /*public List<Weapon> Weapons;
    private int currentWeapon;
    private int previousCurrentWeapon;

    void Start()
    {
        Weapons = new List<Weapon>();
        currentWeapon = 0;
        previousCurrentWeapon = 0;

        Weapon ascia = new Weapon();
        ascia.AddBuff(new StatModifier("Attack", StatModifierType.Additive, 5, 0));
        ascia.AddBuff(new StatModifier("Strength", StatModifierType.Additive, 4, 0));
        ascia.AddBuff(new StatModifier("Vitality", StatModifierType.Additive, 5, 0));
        Weapons.Add(ascia);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(265.0f, 25.0f, 300.0f, 30.0f), "Weapon:");

        string[] weaponStrings = new string[Weapons.Count + 1];
        weaponStrings[0] = "None";
        int stringIndex = 1;
        foreach (Weapon itemInfo in Weapons)
        {
            weaponStrings[stringIndex] = itemInfo.Name;
            stringIndex++;
        }

        currentWeapon = GUI.Toolbar(new Rect(250.0f, 50.0f, 300.0f, 30.0f), currentWeapon, weaponStrings);

        if (GUI.changed && currentWeapon != previousCurrentWeapon)
        {
            UnequipWeapon(previousCurrentWeapon);
            EquipWeapon(currentWeapon);
            previousCurrentWeapon = currentWeapon;
        }
    }

    void EquipWeapon(int weaponIndex)
    {
        BaseCharacter character = BaseCharacter.instance;
        if (weaponIndex == 0)
        {
            return;
        }

        Weapon itemInfo = Weapons[weaponIndex - 1];
        foreach (StatModifier statModifier in itemInfo.GetBuffs())
        {
            //character.AddModifier((StatModifier)statModifier.Clone());
        }
    }

    void UnequipWeapon(int weaponIndex)
    {
        BaseCharacter character = BaseCharacter.instance;
        if (weaponIndex == 0)
        {
            return;
        }

        Weapon itemInfo = Weapons[weaponIndex - 1];
        foreach (StatModifier statModifier in itemInfo.GetBuffs())
        {
            //character.RemoveModifier((StatModifier)statModifier.Clone());
        }
    }*/
}

