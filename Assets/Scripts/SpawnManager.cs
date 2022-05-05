using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject goCube;
    private readonly Color[] cubeColours = { Color.green, Color.cyan, Color.red };

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnCubes), 1.0f, 1f);
    }


    void SpawnCubes()
    {
        Instantiate(goCube, new Vector3(goCube.transform.position.x, goCube.transform.position.y, goCube.transform.position.z), Quaternion.identity);
        goCube.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", cubeColours[Random.Range(0, cubeColours.Length)]);
    }
}
