using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    public Vector3 playerPosition;
    public Vector3 playerVelocity;
    public Vector3 playerAcceleration;
    private Vector3 dir;
    public float speed = 7f;


    // Start is called before the first frame update
    void Start()
    {
        playerPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        dir += new Vector3(0, -0.1f, 0);

        
        transform.position += dir * Time.deltaTime;
        
        print(dir);
    }
    private void OnCollisionEnter2D(Collision2D target)
    {
        if (dir.y > 0){
            dir = new Vector3(-target.transform.rotation.z * speed, -target.transform.rotation.w * dir.y, 0);
        }
        else{
            dir = new Vector3(-target.transform.rotation.z * speed, target.transform.rotation.w * speed, 0);

        }
        
    }
}
