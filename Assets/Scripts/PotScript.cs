using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotScript : MonoBehaviour
{
    [SerializeField] private GameObject LemonTreePrefab;
    [SerializeField] private GameObject MangoTreePrefab;
    [SerializeField] private GameObject PurpleLemonTreePrefab;
    [SerializeField] private GameObject PineappleTreePrefab;

    [SerializeField] private PlayerValues PlayerVal;
    [SerializeField] private GameObject Canvas;
    [SerializeField] public bool IsOccupied = false;

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
        if (PlayerVal.Lemon.SeedCount > 0)
        {
            IsOccupied = true;
            PlayerVal.Lemon.SeedCount--;
            Canvas.SetActive(false);
            var c = Instantiate(LemonTreePrefab, new Vector3(transform.position.x, transform.position.y + 3.462f, transform.position.z), Quaternion.identity);
            c.transform.SetParent(gameObject.transform);
        }
    }
    public void PlantMango()
    {
        if (PlayerVal.Mango.SeedCount > 0)
        {
            IsOccupied = true;
            PlayerVal.Mango.SeedCount--;
            Canvas.SetActive(false);
            var c = Instantiate(MangoTreePrefab, new Vector3(transform.position.x, transform.position.y + 3.462f, transform.position.z), Quaternion.identity);
            c.transform.SetParent(gameObject.transform);
        }
    }
    public void PlantPurpleLemon()
    {
        if (PlayerVal.PurpleLemon.SeedCount > 0)
        {
            IsOccupied = true;
            PlayerVal.PurpleLemon.SeedCount--;
            Canvas.SetActive(false);
            var c = Instantiate(PurpleLemonTreePrefab, new Vector3(transform.position.x, transform.position.y + 3.462f, transform.position.z), Quaternion.identity);
            c.transform.SetParent(gameObject.transform);
        }

    }
    public void PlantPineapple()
    {
        if (PlayerVal.Pineapple.SeedCount > 0)
        {
            IsOccupied = true;
            PlayerVal.Pineapple.SeedCount--;
            Canvas.SetActive(false);
            var c = Instantiate(PineappleTreePrefab, new Vector3(transform.position.x, transform.position.y + 3.462f, transform.position.z), Quaternion.identity);
            c.transform.SetParent(gameObject.transform);
        }
    }
}
