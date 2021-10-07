using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShapes : MonoBehaviour
{
    GameObject[] planks;
	private bool isHeld;
	
	void Awake()
	{
		planks = GameObject.FindGameObjectsWithTag("Plank");
        for (int i = 0; i < planks.Length; i++)
        {
            Debug.Log(planks[i]);
        }
		// TODO: 
		// 1. Create slot machine graphics and sprite container. 
		// 2. Load 3 randomized(shape and area) figures in slot-machine. 
	}
	
    // Start is called before the first frame update
    void Start()
    {
		isHeld = false;
    }
	
	private void onMouseUp()
	{
		isHeld = false;
	}
	
	private void onMouseDown()
	{
		isHeld = true;
	}
	
    // Update is called once per frame
    void Update()
    {
		if(isHeld)
		{	
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
			
			// TODO: Rotation buggy!!! -> Flies off to infinity
			
			//float targetAngle = Vector2.SignedAngle(Vector2.right, direction);
			//angle = Mathf.SmoothDampAngle(angle, targetAngle, ref currentVelocity, smoothTime, maxTurnSpeed);
			//transform.eulerAngles = new Vector3(0, 0, angle);
		}
    }

}
