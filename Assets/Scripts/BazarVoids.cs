using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BazarVoids : MonoBehaviour
{
    [SerializeField] private PlayerValues PlayerVal;
    void Start()
    {
        PlayerVal = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerValues>();
    }

    public void SellLemons()
    {
        if(PlayerVal.Lemon.FruitCount >= 1)
        {
            PlayerVal.Money += 100;
            PlayerVal.Lemon.FruitCount--;
        }
    }
    public void SellMangos()
    {
        if (PlayerVal.Mango.FruitCount >= 1)
        {
            PlayerVal.Money += 150;
            PlayerVal.Mango.FruitCount--;
        }
    }
    public void SellDragonFruits()
    {
        if (PlayerVal.DragonFruit.FruitCount >= 1)
        {
            PlayerVal.Money += 200;
            PlayerVal.DragonFruit.FruitCount--;
        }
    }
    public void SellPineapples()
    {
        if (PlayerVal.Pineapple.FruitCount >= 1)
        {
            PlayerVal.Money += 200;
            PlayerVal.Pineapple.FruitCount--;
        }
    }
    public void SellPurpleLemons()
    {
        if (PlayerVal.PurpleLemon.FruitCount >= 1)
        {
            PlayerVal.Money += 400;
            PlayerVal.PurpleLemon.FruitCount--;
        }
    }
    public void SellBlueTomatoes()
    {
        if (PlayerVal.BlueTomato.FruitCount >= 1)
        {
            PlayerVal.Money += 200;
            PlayerVal.BlueTomato.FruitCount--;
        }
    }
    public void SellTurqPeaches()
    {
        if (PlayerVal.TurqPeach.FruitCount >= 1)
        {
            PlayerVal.Money += 200;
            PlayerVal.TurqPeach.FruitCount--;
        }
    }
}
