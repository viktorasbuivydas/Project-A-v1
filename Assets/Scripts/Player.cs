﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int auksiniai;
    public List<GameObject> zaidejoKariuomene = new List<GameObject>();
    public List<GameObject> priesininkoKariuomene = new List<GameObject>();
    [HideInInspector]
    public Unit unit;
    public Unit rankojeUnit;

    public int TuriVienosRusiesKariu(string pavadinimas)
    {
        int viso = 0;
        foreach (var item in zaidejoKariuomene)
        {
            var temp = item.GetComponent<Unit>();
            if (temp.pavadinimas.Equals(pavadinimas))
            {
                viso++;
            }
        }
        return viso;
    }


}
