using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waepoon : MonoBehaviour
{
    static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        Destroy(gameObject);
        score = score + 10000;
        print(score);
    }
}
