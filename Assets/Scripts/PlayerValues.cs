using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerValues : MonoBehaviour
{
    [SerializeField] public int LemonCount;
    [SerializeField] public int LemonSeedCount = 99;
    [SerializeField] public Text LemonCountText;
    [SerializeField] public Text LemonSeedCountText;

    [SerializeField] public int MangoCount;
    [SerializeField] public int MangoSeedCount = 99;
    [SerializeField] public Text MangoCountText;
    [SerializeField] public Text MangoSeedCountText;

    [SerializeField] public int DragonFruitCount;
    [SerializeField] public int DragonFruitSeedCount = 99;
    [SerializeField] public Text DragonFruitCountText;
    [SerializeField] public Text DragonFruitSeedCountText;

    [SerializeField] public int PineappleCount;
    [SerializeField] public int PineappleSeedCount = 99;
    [SerializeField] public Text PineappleCountText;
    [SerializeField] public Text PineappleSeedCountText;

    [SerializeField] public int PurpleLemonCount;
    [SerializeField] public int PurpleLemonSeedCount = 99;
    [SerializeField] public Text PurpleLemonCountText;
    [SerializeField] public Text PurpleLemonSeedCountText;

    [SerializeField] public int BlueTomatoCount;
    [SerializeField] public int BlueTomatoSeedCount = 99;
    [SerializeField] public Text BlueTomatoCountText;
    [SerializeField] public Text BlueTomatoSeedCountText;

    [SerializeField] public int TurqPeachesCount;
    [SerializeField] public int TurqPeachesSeedCount = 99;
    [SerializeField] public Text TurqPeachesCountText;
    [SerializeField] public Text TurqPeachesSeedCountText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        LemonCountText.text = LemonCount.ToString();
        LemonSeedCountText.text = LemonSeedCount.ToString();

        MangoCountText.text = MangoCount.ToString();
        MangoSeedCountText.text = MangoSeedCount.ToString();

        DragonFruitCountText.text = DragonFruitCount.ToString();
        DragonFruitSeedCountText.text = DragonFruitSeedCount.ToString();

        PineappleCountText.text = PineappleCount.ToString();
        PineappleSeedCountText.text = PineappleSeedCount.ToString();

        PurpleLemonCountText.text = PurpleLemonCount.ToString();
        PurpleLemonSeedCountText.text = PurpleLemonSeedCount.ToString();

        BlueTomatoCountText.text = BlueTomatoCount.ToString();
        BlueTomatoSeedCountText.text = BlueTomatoSeedCount.ToString();

        TurqPeachesCountText.text = TurqPeachesCount.ToString();
        TurqPeachesSeedCountText.text = TurqPeachesSeedCount.ToString();
    }

    public void HarvestLemons()
    {
        LemonCount += 5;
    }
    public void HarvestMangos()
    {
        MangoCount += 5;
    }
    public void HarvestPurpleLemons()
    {
        PurpleLemonCount += 3;
    }   
}
