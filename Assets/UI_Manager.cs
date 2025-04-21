using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI txtSaludo;
    public TMP_InputField inputNombre;
    string nombreIngresado;
    string saludo;
    // Start is called before the first frame update
    void Start()
    {
        txtSaludo.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saludar()
    {
        // obtener nombre input
        nombreIngresado = inputNombre.text;
        //concatenar el nombre on el saludo
        saludo = "Hola " + nombreIngresado + "!";
        //mostrar saludo en txtSaludo
        txtSaludo.text = saludo;
    }
}
