using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField]
    private float rollingSpeed = 1f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(rollingSpeed * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
