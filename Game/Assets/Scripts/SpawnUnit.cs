using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnUnit : MonoBehaviour
{


    [SerializeField] private GameObject unit;
    [SerializeField] private GameObject spawnZone;




    public void spawnUnit()
    {
       GameObject.Instantiate(unit, spawnZone.transform.position, spawnZone.transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Find("Text").GetComponent<Text>().text = unit.name;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
