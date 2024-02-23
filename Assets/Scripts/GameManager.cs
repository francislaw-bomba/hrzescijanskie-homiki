using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public bool IsIllegalPlantPlanted;
    [SerializeField] private GameObject IllegalPlant;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IllegalPlant = GameObject.FindGameObjectWithTag("IllegalPlant");

        if (IllegalPlant == null)
        {
            IsIllegalPlantPlanted = false;
        }
        else if (IllegalPlant != null)
        {
            IsIllegalPlantPlanted = true;
        }
    }
}
