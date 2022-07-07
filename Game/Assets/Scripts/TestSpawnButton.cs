using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSpawnButton : MonoBehaviour
{





    [SerializeField] private GameObject spawnZone;
    [SerializeField] private GameObject buildZone;

    // Start is called before the first frame update
    void Start()
    {
        spawnZone = gameObject.transform.parent.gameObject.GetComponent<AssignedBuildPos>().getSpawnPlace();
        buildZone = gameObject.transform.parent.gameObject.GetComponent<AssignedBuildPos>().getBuildPlace();
        gameObject.transform.Find("Text").GetComponent<Text>().text = "Spawn  Wave";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnWave()
    {
        foreach (Transform child in buildZone.transform)
        {
            
         
            Debug.Log(child.transform.localPosition);
            GameObject myClone = GameObject.Instantiate(child.gameObject, (child.position + spawnZone.transform.position), gameObject.transform.rotation).gameObject;
            myClone.transform.localScale = Vector3.one;
            myClone.transform.parent = spawnZone.transform;
            myClone.transform.localPosition = (child.localPosition);
            myClone.transform.parent = null;
            myClone.gameObject.AddComponent <UnitMovement> ();
        }
    }




}
