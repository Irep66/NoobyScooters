using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignedBuildPos : MonoBehaviour
{


     [SerializeField] private GameObject buildPlace;
     [SerializeField] private GameObject spawnPlace;
    // Start is called before the first frame update




    public GameObject getBuildPlace()
    {
        return buildPlace;
    }

    public GameObject getSpawnPlace()
    {
        return spawnPlace;
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
