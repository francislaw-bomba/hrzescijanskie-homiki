using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterLevelScript : MonoBehaviour
{
    [SerializeField] private Slider Slider;

    public void UpdateWaterBar(float x, float y)
    {
        Slider.value = x / y;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
