using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Pot;
    [SerializeField] private PlayerValues PlayerVal;
    [SerializeField] private GameObject Button1, Button2;
    void Start()
    {
        PlayerVal = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerValues>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyPot1()
    {
        if (PlayerVal.Money >= 2000) 
        {
            Instantiate(Pot, new Vector3(0, -2.8f, -1), Quaternion.identity);
            Destroy(Button1);
        }
    }
    public void BuyPot2()
    {
        if (PlayerVal.Money >= 3000)
        {
            Instantiate(Pot, new Vector3(7.5f, -2.8f, -1), Quaternion.identity);
            Destroy(Button2);
        }
    }
}
