using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject hedef;
    bool mouseDrag;
    Vector3 offsetValue;
    Vector3 ekranKonumu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            hedef = tiklananObje(out hitInfo);
            if(hedef!= null && hitInfo.transform.gameObject.tag !=("Player"))
            {
                mouseDrag = true;
                ekranKonumu = Camera.main.WorldToScreenPoint(hedef.transform.position);    
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            mouseDrag =false;
        }
        if(mouseDrag)
        {
            Vector3 currentScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ekranKonumu.z);
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenSpace)+offsetValue;
            hedef.transform.position = currentPosition;
        }
    }
    GameObject tiklananObje(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray.origin,ray.direction*10,out hit))
        {
            target = hit.collider.gameObject;
        }
        return target;
    }
}
