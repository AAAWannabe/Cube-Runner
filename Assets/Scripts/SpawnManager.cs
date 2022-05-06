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
        //well.. sharedMaterial changes them all
        //goCube.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", cubeColours[Random.Range(0, cubeColours.Length)]);
        var instPrefab = Instantiate(goCube, new Vector3(goCube.transform.position.x, goCube.transform.position.y, Random.Range(-6f, 6f)), Quaternion.identity);
        instPrefab.GetComponent<Renderer>().material.color = cubeColours[Random.Range(0, cubeColours.Length)];
    }
}
