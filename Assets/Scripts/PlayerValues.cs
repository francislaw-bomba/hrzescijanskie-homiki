using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerValues : MonoBehaviour
{
    [SerializeField] public int LemonCount;
    [SerializeField] public int LemonSeedCount = 99;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HarvestLemons()
    {
        LemonCount += 5;
    }
}