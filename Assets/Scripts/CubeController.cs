using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]
    private float rollingSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(rollingSpeed * Time.deltaTime, 0, 0);
        //easy fix, add a rigidbody and viola even AFK player detects collision
        //transform.position.x > 30, better use rigidbody and destory whoever falling below the plane
        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
        
    }
}
