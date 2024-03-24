using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopVoids : MonoBehaviour
{
    [SerializeField] private PlayerValues PlayerVal;
    void Start()
    {
        PlayerVal = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerValues>();
    }

    public void BuyLemonSeeds()
    {
        PlayerVal.Money -= 100;
        PlayerVal.Lemon.SeedCount += 1;
    }
    public void BuyMangoSeeds()
    {
        PlayerVal.Money -= 100;
        PlayerVal.Mango.SeedCount += 1;
    }
    public void BuyDragonFruitSeeds()
    {
        PlayerVal.Money -= 100;
        PlayerVal.DragonFruit.SeedCount += 1;
    }
    public void BuyPineappleSeeds()
    {
        PlayerVal.Money -= 100;
        PlayerVal.Pineapple.SeedCount += 1;
    }
    public void BuyPurpleLemonSeeds()
    {
        PlayerVal.Money -= 100;
        PlayerVal.PurpleLemon.SeedCount += 1;
    }
    public void BuyBlueTomatoSeeds()
    {
        PlayerVal.Money -= 100;
        PlayerVal.BlueTomato.SeedCount += 1;
    }
    public void BuyTurqPeachSeeds()
    {
        PlayerVal.Money -= 100;
        PlayerVal.TurqPeach.SeedCount += 1;
    }
}
