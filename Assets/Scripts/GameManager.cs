using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    int planetCount = 5;
    [SerializeField]
    GameObject planetPrefab;
    [SerializeField]
    float renderDistance = 100;
    [SerializeField]
    List<Color> colors = new List<Color>();
    [SerializeField]
    float height = 2f;
    // Start is called before the first frame update
    void Start()
    {
        colors.Add(Color.blue);
        colors.Add(Color.green);
        colors.Add(Color.red);
        colors.Add(Color.yellow);
        colors.Add(Color.cyan);

        for(int i = 0; i < planetCount; i++){
            float x = Random.Range(-renderDistance, renderDistance);
            float z = Random.Range(-renderDistance, renderDistance);

            float y = Random.Range(-height, height); // Gives a little bit of up and down so it doesn't look like it sits on 1 plane

            Vector3 pos = new Vector3(x,y,z);

            GameObject planet = Instantiate(planetPrefab, pos, Quaternion.identity, this.transform);
            int randColor = Random.Range(0,colors.Count);
            planet.GetComponent<MeshRenderer>().material.color = colors[randColor];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
