using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
	public GameObject objeto;
	
	public Transform puntoPartida;
	public Transform puntoLlegada;
	
	public float velocidad;
	
	private Vector3 direccion;
	
    // Start is called before the first frame update
    void Start()
    {
        direccion = puntoLlegada.position;
    }

    // Update is called once per frame
    void Update()
    {
		objeto.transform.position = Vector3.MoveTowards(objeto.transform.position, direccion, velocidad * Time.deltaTime);
		
		if (objeto.transform.position == puntoLlegada.position)
		{
			direccion = puntoPartida.position;
		}
		if (objeto.transform.position == puntoPartida.position)
		{
			direccion = puntoLlegada.position;
		}
    }
}
