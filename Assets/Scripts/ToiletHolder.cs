using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletHolder : MonoBehaviour
{
    [SerializeField] private List<GameObject> toiletList;

    // Start is called before the first frame update
    void Start()
    {
        //toiletList = new List<GameObject>();
        int randomRange = Random.RandomRange(0, 6);
        RandomSpawn(randomRange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RandomSpawn(int index)
    {
        toiletList[index].SetActive(true);  
    }
}
