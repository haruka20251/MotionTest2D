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
            transform.Translate(Vector3.down * speed); // 上方向に移動
        }
        else if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * speed);
        }
        
    }
}
