using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotScript : MonoBehaviour
{
    [SerializeField] public bool IsOccupied = false;
    [SerializeField] private GameObject LemonTreePrefab;
    [SerializeField] private GameObject MangoTreePrefab;
    [SerializeField] private PlayerValues PlayerVal;
    [SerializeField] private GameObject Canvas;

    private void Awake()
    {
        Canvas = transform.Find("Canvas").gameObject;
    }
    void Start()
    {
        PlayerVal = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PlayerValues>();
    }

    void Update()
    {
        if (IsOccupied == false)
        {
            Canvas.SetActive(true);
        }
    }

    [ContextMenu("PlantLemon")]
    public void PlantLemon()
    {
        if (PlayerVal.LemonSeedCount > 0)
        {
            IsOccupied = true;
            PlayerVal.LemonSeedCount--;
            Canvas.SetActive(false);
            var c = Instantiate(LemonTreePrefab, new Vector3(transform.position.x, transform.position.y + 3.462f, transform.position.z), Quaternion.identity);
            c.transform.SetParent(gameObject.transform);
        }
    }
    public void PlantMango()
    {
        if (PlayerVal.MangoSeedCount > 0)
        {
            IsOccupied = true;
            PlayerVal.MangoSeedCount--;
            Canvas.SetActive(false);
            var c = Instantiate(MangoTreePrefab, new Vector3(transform.position.x, transform.position.y + 3.462f, transform.position.z), Quaternion.identity);
            c.transform.SetParent(gameObject.transform);
        }
    }
}
