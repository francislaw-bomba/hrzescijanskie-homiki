using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit
{
    public int FruitCount;
    public int SeedCount;
}
public class PlayerValues : MonoBehaviour
{
    [SerializeField] public int Money;
    [SerializeField] public Text MoneyText;

    [SerializeField] public Text LemonCountText;
    [SerializeField] public Text LemonSeedCountText;
    [SerializeField] public Text MangoCountText;
    [SerializeField] public Text MangoSeedCountText;   
    [SerializeField] public Text DragonFruitCountText;
    [SerializeField] public Text DragonFruitSeedCountText;  
    [SerializeField] public Text PineappleCountText;
    [SerializeField] public Text PineappleSeedCountText; 
    [SerializeField] public Text PurpleLemonCountText;
    [SerializeField] public Text PurpleLemonSeedCountText;
    [SerializeField] public Text BlueTomatoCountText;
    [SerializeField] public Text BlueTomatoSeedCountText; 
    [SerializeField] public Text TurqPeachesCountText;
    [SerializeField] public Text TurqPeachesSeedCountText;

    public Fruit Lemon = new Fruit();
    public Fruit Mango = new Fruit();
    public Fruit DragonFruit = new Fruit();
    public Fruit Pineapple = new Fruit();
    public Fruit PurpleLemon = new Fruit();
    public Fruit BlueTomato = new Fruit();
    public Fruit TurqPeach = new Fruit();
    void Start()
    {
        Money = 400;
    }

    // Update is called once per frame
    void Update()
    { 
        LemonCountText.text = Lemon.FruitCount.ToString();
        LemonSeedCountText.text = Lemon.SeedCount.ToString();

        MangoCountText.text = Mango.FruitCount.ToString();
        MangoSeedCountText.text = Mango.SeedCount.ToString();

        DragonFruitCountText.text = DragonFruit.FruitCount.ToString();
        DragonFruitSeedCountText.text = DragonFruit.SeedCount.ToString();

        PineappleCountText.text = Pineapple.FruitCount.ToString();
        PineappleSeedCountText.text = Pineapple.SeedCount.ToString();

        PurpleLemonCountText.text = PurpleLemon.FruitCount.ToString();
        PurpleLemonSeedCountText.text = PurpleLemon.SeedCount.ToString();

        BlueTomatoCountText.text = BlueTomato.FruitCount.ToString();
        BlueTomatoSeedCountText.text = BlueTomato.SeedCount.ToString();

        TurqPeachesCountText.text = TurqPeach.FruitCount.ToString();
        TurqPeachesSeedCountText.text = TurqPeach.SeedCount.ToString();

        MoneyText.text = Money.ToString();
    }

    public void EditMoney(int x)
    {
        Money += x;
    }
    public void AddLemons(int x)
    {
        Lemon.FruitCount += x;
    }
    public void AddMangos(int x)
    {
        Mango.FruitCount += x;
    }
    public void AddDragonFruits(int x)
    {
        DragonFruit.FruitCount += x;
    }
    public void AddPineapples(int x)
    {
        Pineapple.FruitCount += x;
    }
    public void AddPurpleLemons(int x)
    {
        PurpleLemon.FruitCount += x;
    }
    public void AddBlueTomatoes(int x)
    {
        BlueTomato.FruitCount += x;
    }
    public void AddTurqPeaches(int x)
    {
        TurqPeach.FruitCount += x;
    }
}
