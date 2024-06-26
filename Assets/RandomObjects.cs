using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomObjects : MonoBehaviour
{
    public GameObject[] Food; 

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true); 
      Random.Range(0, Food.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
