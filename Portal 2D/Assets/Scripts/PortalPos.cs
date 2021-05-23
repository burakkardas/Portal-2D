using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPos : MonoBehaviour
{
    private Vector2 target;
    public GameObject bluePortal;
    public GameObject orangePortal;
    void Start()
    {
        bluePortal.SetActive(false);
        orangePortal.SetActive(false);
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            bluePortal.SetActive(true);
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            bluePortal.transform.position = new Vector2(target.x, target.y);
        }
        else if(Input.GetMouseButtonDown(1)) {
            orangePortal.SetActive(true);
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            orangePortal.transform.position = new Vector2(target.x, target.y);
        }
    }
}
