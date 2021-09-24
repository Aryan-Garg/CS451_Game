using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShapes : MonoBehaviour
{
    GameObject[] planks;
    // Start is called before the first frame update
    void Start()
    {
        planks = GameObject.FindGameObjectsWithTag("plank");
        float y = 100.0f;
        for (int i = 0; i < planks.Length; i++)
        {
            Debug.Log(planks[i]);
            Instantiate(planks[i], new Vector3(100.0f, y, 0.0f), Quaternion.identity);
            y += 10.0f;
        }
        // Load 3 figures in slot-machine 
    }
    // Implement Drag and Drop
    private void OnMouseDown()
    {
        // Mouse pressed
        // Highlight plank -> Free translation
        // Rotation -> Give 4 points(rot-points) on plank for rotation (360 deg)
        // if rot-point selected:
        //    Only rotate (preserve state)
    }

    private void OnMouseUp()
    {
        // Mouse released
        // When released on floor -> stay (border&lighting effect)
        // go back to initial slot position if not placed on floor. 
    }

    // Update is called once per frame
    void Update()
    {
        // if planks[i] on floor -> create new
        // How to create only one object?
    }
}
