using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomObjects : MonoBehaviour
{
    public GameObject[] Food;
    int RandomIndex1;
    int RandomIndex2;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject fod in Food)
        {
            fod.SetActive(false);
        }
        RandomIndex1 = Random.Range(0, Food.Length);
        RandomIndex2 = Random.Range(0, Food.Length);
        if(RandomIndex2 == RandomIndex1)
        {
            RandomIndex2 = Random.Range(0, Food.Length);
        }
        Food[RandomIndex1].SetActive(true);
        Food[RandomIndex2].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
