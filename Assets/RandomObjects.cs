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
    public GameObject btnAlcanzaJusto;
    public GameObject btnNoAlcanza;
    public GameObject btnJugarDeNuevo;
    public int PrecioTotal;
    public GameObject panel;
    public Precio PrecioComida;
    public Precio PrecioComida2;
    public Text textopanel;
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
      
        PrecioComida = Food[RandomIndex1].GetComponent<Precio>();
        PrecioComida2 = Food[RandomIndex2].GetComponent<Precio>();
        PrecioTotal = PrecioComida.PrecioAlimento + PrecioComida2.PrecioAlimento;
        Dinero =Random.Range(300,1500);
        
    }

    // Update is called once per frame
    void Update()
    {
       txtDinero.text = Dinero.ToString();
    }
    public   void Alcanza()
    {
        panel.SetActive(true);
        if(PrecioTotal < Dinero)
        {
            textopanel.text = "¡Acertaste!";
        }
        else
        {
            textopanel.text = "No acertaste";
        }
    }
    public void AlcanzaJusto()
    {
        panel.SetActive(true);
        if (PrecioTotal == Dinero)
        {
            textopanel.text = "¡Acertaste!";
        }
        else
        {
            textopanel.text = "No acertaste";
        }
    }
    public void NoAlcanza()
    {
        panel.SetActive(true);
        if (PrecioTotal > Dinero)
        {
            textopanel.text = "¡Acertaste!";
        }
        else
        {
            textopanel.text = "No acertaste";
        }
    }
    public void JugarDeNuevo()
    {
        panel.SetActive(false);
        foreach (GameObject fod in Food)
        {
            fod.SetActive(false);
        }
        RandomIndex1 = Random.Range(0, Food.Length);
        RandomIndex2 = Random.Range(0, Food.Length);
        Food[RandomIndex1].SetActive(true);
        Food[RandomIndex2].SetActive(true);
        Dinero = Random.Range(300, 1500);
        PrecioComida = Food[RandomIndex1].GetComponent<Precio>();
        PrecioComida2 = Food[RandomIndex2].GetComponent<Precio>();
        PrecioTotal = PrecioComida.PrecioAlimento + PrecioComida2.PrecioAlimento;
    }


}
