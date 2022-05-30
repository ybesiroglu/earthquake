using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    private float velocity = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        x *= Time.deltaTime * velocity;
        float y = Time.deltaTime * velocity;
        transform.Translate(x, 0f, y);
    }
}
