using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    public float speed = 1.0f;
    void Update()
    {
        Vector2 position = transform.position;
        position.x += speed * Input.GetAxis("Horizontal") * Time.deltaTime; 
        position.y += speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position = position;
    }
}
