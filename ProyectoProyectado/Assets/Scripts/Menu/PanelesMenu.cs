using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanelesMenu : MonoBehaviour
{
    public GameObject PNiveles;
    public GameObject PSeguro;
    public GameObject POpciones;
    public Button BMovimiento;
    public GameObject PMovimiento;

    public ManagOpciones managOpciones;
    public Button Teclado1;
    public Button Teclado2;

    public TMP_Dropdown dropdown;
    public int Calidad;

    private void Start()
    {
        PNiveles.SetActive(false);
        PSeguro.SetActive(false);
        POpciones.SetActive(false);
        BMovimiento.interactable = false;
        PMovimiento.SetActive(true);

        Calidad = PlayerPrefs.GetInt("numDeCalidad", 3);
        dropdown.value = Calidad;
        AjustarCalidad();

        
    }
    private void Update()
    {
        if (managOpciones.TipoTeclado == 0)
        {
            Teclado1.interactable = false;
            Teclado2.interactable = true;
        }
        else
        {
            Teclado1.interactable = true;
            Teclado2.interactable = false;
        }
    }

    public void SiInteract(Button Boton)
    { Boton.interactable = true; }
    public void NoInteract(Button Boton)
    { Boton.interactable = false; }
    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numDeCalidad", dropdown.value);
        Calidad = dropdown.value;
    }
}
