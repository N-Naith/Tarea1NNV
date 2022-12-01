using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "A", menuName = "ScriptableObject")]
public class PlantillaTextos : ScriptableObject
{
    public string textoNarrativo;
    public string respuestaUno;
    public string respuestaDos;
    public int[] arrayReferencias = new int[2];
    public bool quitarBotones;
    
}
