using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScreen : MonoBehaviour
{
    [SerializeField] PlantillaTextos plantilla;
    [SerializeField] PlantillaTextos[] arrayPlantillas;
    [SerializeField] TextMeshProUGUI textoNarracion;
    [SerializeField] TextMeshProUGUI textoRespuestaUno;
    [SerializeField] TextMeshProUGUI textoRespuestaDos;
    [SerializeField] GameObject[] arrayBotones;

    private void Start()
    {
        plantilla = arrayPlantillas[0];
        muestraTexto();
    }

    public void muestraTexto()
    {
        textoNarracion.text = plantilla.textoNarrativo;
        textoRespuestaUno.text = plantilla.respuestaUno;
        textoRespuestaDos.text = plantilla.respuestaDos;
    }

    public void controlBotones (int i)
    {
        plantilla = arrayPlantillas[plantilla.arrayReferencias[i]];
        if(plantilla.quitarBotones == true)
        {
            DesactivaBotones();
        }
        muestraTexto();
    }

    void DesactivaBotones(){
        foreach (var boton in arrayBotones)
        {
            boton.SetActive(false);
        }
    }
}
