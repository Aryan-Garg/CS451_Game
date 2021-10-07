using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveshapes : MonoBehaviour
{
    private bool isheld;
    public GameObject dupli;
    public void OnMouseDown()
    {
        isheld = true;
    }

    public void OnMouseUp()
    {
        isheld = false;
    }
    void Update()
    {
        if (dupli != null)
        {
            return;
        }
        else
        {
            dupli = Instantiate(GameObject.Find("triangle"));
            Debug.Log(dupli);
        }
            
   
        //triangle = GameObject.Find("triangle");
        //GameObject dupli = Instantiate(triangle);
        //Debug.Log(dupli);
        if (isheld)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
            Debug.Log("checking!");
            
        }
    }
}
