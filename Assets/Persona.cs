using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stats
{
    [Range(0.0f, 1.0f)]
    public float body;
    [Range(0.0f, 1.0f)]
    public float smart;
    [Range(0.0f, 1.0f)]
    public float genki;
    [Range(0.0f, 1.0f)]
    public float cute;
}

[CreateAssetMenu(fileName = "Data", menuName = "Enum/Persona", order = 1)]
public class Persona : ScriptableObject 
{
    public string firstName;
    public string secondName;
    public Stats stats;
    public Stats exigence;
}
