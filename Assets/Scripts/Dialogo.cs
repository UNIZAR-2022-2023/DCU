using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
	[SerializeField] private GameObject instruccion_dialogo;
	[SerializeField] private GameObject panel_dialogo;
	[SerializeField] private TMP_Text texto_dialogo;
	[SerializeField, TextArea(4, 6)] private string[] lineas_mostrar;

	private bool estaCerca;
	private bool dialogoEmpezado;
	private int lineaIndex;

    // Update is called once per frame
    void Update()
    {
        if (estaCerca && Input.GetButtonDown("Fire1")) {
		    instruccion_dialogo.SetActive(false);
        	if (!dialogoEmpezado) {
	        	EmpiezaDialogo();        	
        	} else if (texto_dialogo.text == lineas_mostrar[lineaIndex]) {
    			SiguienteLineaDialogo();
    		}
    	}
    }
    
    private void EmpiezaDialogo() {
    	dialogoEmpezado = true;
    	panel_dialogo.SetActive(true);
    	
    	lineaIndex = 0;
    	Time.timeScale = 0f;
    	
    	StartCoroutine(MostrarLinea());
    }
    
    private IEnumerator MostrarLinea() {
    	texto_dialogo.text = string.Empty;
    	
    	foreach (char ch in lineas_mostrar[lineaIndex]) {
    		texto_dialogo.text += ch;
    		yield return new WaitForSecondsRealtime(0.05f);
    	}
    }
    
    private void SiguienteLineaDialogo() {
	    lineaIndex++;
    	if (lineaIndex < lineas_mostrar.Length) {    	
    	   	StartCoroutine(MostrarLinea());
    	} else {
   	    	lineaIndex = 0;
    		dialogoEmpezado = false;
		    panel_dialogo.SetActive(false);
        	Time.timeScale = 1f;
    	}
    }

    private void OnTriggerEnter2D(Collider2D collision) {
	    if (collision.gameObject.CompareTag("Player")) {
		    instruccion_dialogo.SetActive(true);
	    	estaCerca = true;
	    }
    }
    
	private void OnTriggerExit2D(Collider2D collision) {
		if (collision.gameObject.CompareTag("Player")) {
		    instruccion_dialogo.SetActive(false);
	    	estaCerca = false;
	    }
    }
}

