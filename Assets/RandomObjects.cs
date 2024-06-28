using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomObjects : MonoBehaviour
{
    public GameObject[] Food;
    int RandomIndex1;
    int RandomIndex2;
    public Text txtDinero;
    int Dinero;
    public GameObject btnAlcanzaYSobra;
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
        Dinero=Random.Range(0,2000);
       
    }

    // Update is called once per frame
    void Update()
    {
       txtDinero.text = Dinero.ToString();
    }
    private void Alcanza()
    {
     //Aparece el panel
        if(RandomIndex1 + RandomIndex2 > Dinero)
        {

        }
        else
        {

        }
    }
    private void AlcanzaJusto()
    {
        //Aparece el panel
        if(RandomIndex1 + RandomIndex2 == Dinero)
        {

        }
        else
        {

        }
    }
    private void NoAlcanza()
    {
        //Aparece el panel
        if(RandomIndex1 + RandomIndex2 < Dinero)
        {

        }
        else
        {
            
        }
    }

    
}
