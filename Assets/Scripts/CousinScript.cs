using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CousinScript : MonoBehaviour
{
    [SerializeField] private PlayerValues PlayerVal;
    [SerializeField] public int Debt;

    void Start()
    {
        PlayerVal = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerValues>();
        Debt = 50000;
    }

    void Update()
    {
        
    }

    public void Pay()
    {
        PlayerVal.Money -= 1000;
        Debt -= 1000;
    }
}
