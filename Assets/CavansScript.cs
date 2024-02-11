using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavansScript : MonoBehaviour
{

    [SerializeField] public GameObject WaterButton;
    // Start is called before the first frame update
    void Awake()
    {
        WaterButton = transform.Find("WaterPlantButton").gameObject;
    }
}
