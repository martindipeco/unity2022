using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desafio5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La posición del GameObject es: " + transform.position);
        Debug.Log("La rotación del GameObject es: " + transform.rotation);
        Debug.Log("La escala local del GameObject es: " + transform.localScale);

    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento en el eje X positivo de 0.05f.
        //transform.position = new Vector3(0.05f, 0.0f, 0.0f);

        //Movimiento en el eje X negativo de 0.05f.
        //transform.position = new Vector3(-0.05f, 0.0f, 0.0f);

        //Movimiento en el eje Y positivo de 0.1f.
        //transform.position = new Vector3(0.0f, 0.1f, 0.0f);

        //Movimiento en el eje Y negativo de 0.1f.
        //transform.position = new Vector3(0.0f, -0.1f, 0.0f);

        //Movimiento en el eje Z positivo de 0.25f.
        //transform.position = new Vector3(0.0f, 0.0f, 0.25f);

        //Movimiento en el eje Z negativo de 0.25f.
        //transform.position = new Vector3(0.0f, 0.0f, -0.25f);

        //Rotación sin detenerse en el eje X de 15°. (opcion 1)
        //transform.eulerAngles = new Vector3(15, 0, 0) * Time.deltaTime;

        //Rotación sin detenerse en el eje X de 15°. (opcion 2)
        //transform.rotation = Quaternion.Euler(new Vector3(15, 0, 0) * Time.deltaTime);


        //Rotación sin detenerse en el eje Y de 30°. (opción 1)
        //transform.eulerAngles = new Vector3(0, 30, 0) * Time.deltaTime;

        //Rotación sin detenerse en el eje Y de 30°. (opción 2)
        //transform.rotation = Quaternion.Euler(new Vector3(0, 30, 0) * Time.deltaTime);

        //Rotación sin detenerse en el eje Z de 60°. (opción 1)
        //transform.eulerAngles = new Vector3(0, 0, 60) * Time.deltaTime;

        //Rotación sin detenerse en el eje Z de 60°. (opción 2)
        //transform.rotation = Quaternion.Euler(new Vector3(0, 0, 60) * Time.deltaTime);

        //Cambio de escala en el eje X de 1.
        //transform.localScale = new Vector3(1, 0, 0);

        //Cambio de escala en el eje Y de 2.
        //transform.localScale = new Vector3(0, 2, 0);

        //Cambio de escala en el eje Z de 4.
        //transform.localScale = new Vector3(0, 0, 4);
    }
}
