using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavansScript : MonoBehaviour
{

    [SerializeField] public GameObject WaterButton;
    [SerializeField] public GameObject WaterLevel;
    [SerializeField] public GameObject HarvestButton;
    // Start is called before the first frame update
    void Awake()
    {
        WaterButton = transform.Find("WaterPlantButton").gameObject;
        WaterLevel = transform.Find("WaterLevel").gameObject;
        HarvestButton = transform.Find("Harvest").gameObject;
    }
}
