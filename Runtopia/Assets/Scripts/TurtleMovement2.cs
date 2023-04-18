using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMovement2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    private Transform tf;
    public bool isRight;

    private void Start() {
        tf = gameObject.GetComponent<Transform>();
        isRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, 1, -1).normalized * speed * Time.deltaTime;

        if(isRight)
            tf.position += move;
        else 
            tf.position -= move;
    }
}
