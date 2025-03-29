using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    private float speed = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed); // ã•ûŒü‚ÉˆÚ“®
        }
        else if (Input.GetKey(KeyCode.A)||Input.GetKeyDown(KeyCode.Q))
        {
            transform.Translate(Vector3.left * speed);
        }
        
    }
}
