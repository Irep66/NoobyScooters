using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildUnit : MonoBehaviour
{




    [SerializeField] private GameObject unit;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject buildZone;
    private bool firstClick = true;
    private GameObject selected;
    private Ray mouseWorldPos;



    // Start is called before the first frame update

    void Start()
    {
        buildZone = gameObject.transform.parent.gameObject.GetComponent<AssignedBuildPos>().getBuildPlace();
        gameObject.transform.Find("Text").GetComponent<Text>().text = unit.name;
    }

    // Update is called once per frame
    void Update()
    {

        mouseWorldPos = mainCamera.ScreenPointToRay(Input.mousePosition);
       

        if (selected != null)
        {
           buildZone.transform.GetInstanceID(); 
            if (Physics.Raycast(mouseWorldPos, out RaycastHit raycastHit))
            {

                selected.transform.localPosition = raycastHit.point;
               
            }
        }


        if (Input.GetMouseButton(0) && !firstClick)
        {
            if (Physics.Raycast(mouseWorldPos, out RaycastHit raycastHit) && (raycastHit.transform.GetInstanceID() == buildZone.transform.GetInstanceID())){

            selected.transform.SetParent(buildZone.transform);
            selected = null;
            firstClick = true;
            return;
            }

        }


    }


    public void buildUnit()

    {


        if (firstClick)
        {
           
            if (Physics.Raycast(mouseWorldPos, out RaycastHit raycastHit))
            {
                selected = GameObject.Instantiate(unit, raycastHit.point, buildZone.transform.rotation);
            }

        }



        firstClick = false;

    }



}
