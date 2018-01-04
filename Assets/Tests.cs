using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Não sei se vai ter uso isso.

public enum Girls { Tomoko, Mayuri, Minori, Asuka, Saya, Aoba, Karen, Misato };
public enum Boys { Araragi, Hachiman, Armin, Kitamura, Okabe, Nagito, Byakuya, Kaiki };

public class Tests : MonoBehaviour 
{
    public Persona p;

    void Start()
    {
        Debug.Log(p.ToString());
    }
}
