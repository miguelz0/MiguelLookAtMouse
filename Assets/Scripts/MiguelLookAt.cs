using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiguelLookAt : MonoBehaviour
{
    // Update is called once per frame
    public SpriteRenderer foto1, foto2, foto3, foto4, foto5, foto6, foto7, foto8;
    private float grados2;
    private void Start()
    {
        foto1.enabled = false;
        foto2.enabled = false;
        foto3.enabled = false;
        foto4.enabled = false;
        foto5.enabled = false;
        foto6.enabled = false;
        foto7.enabled = false;
        foto8.enabled = false;

    }
    void Update()
    {
        
        Vector3 worldMousePosition = GetWorldMousePosition();
        LookAt(worldMousePosition);
        
    }

    private Vector3 GetWorldMousePosition()
    {
        Camera camera = Camera.main;
        Vector3 screenPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, camera.nearClipPlane);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);        
        return worldPos;
    }
   
    private void LookAt(Vector3 position)
    {
        Vector4 resta = position - transform.position;
        float radians = Mathf.Atan2(resta.y, resta.x);
        float grados = radians * 180 / Mathf.PI;
        CambiarFoto(grados);
        
        //Vector4 posicion = new Vector4(transform.position.x, transform.position.y,0,0);
        //Vector4 temp =  posicion;
        //temp.Draw(Color.blue);

    }
    private void CambiarFoto(float grados)
    {
        if (grados < 45 && grados > 0)
        {
            foto1.enabled = true;
            foto2.enabled = false;
            foto3.enabled = false;
            foto4.enabled = false;
            foto5.enabled = false;
            foto6.enabled = false;
            foto7.enabled = false;
            foto8.enabled = false;
        }
        if(grados<90&& grados > 45)
        {
            foto1.enabled = false;
            foto2.enabled = true;
            foto3.enabled = false;
            foto4.enabled = false;
            foto5.enabled = false;
            foto6.enabled = false;
            foto7.enabled = false;
            foto8.enabled = false;
        }
        if (grados < 135 && grados > 90)
        {
            foto1.enabled = false;
            foto2.enabled = false;
            foto3.enabled = true;
            foto4.enabled = false;
            foto5.enabled = false;
            foto6.enabled = false;
            foto7.enabled = false;
            foto8.enabled = false;
        }
        if (grados < 180 && grados > 135)
        {
            foto1.enabled = false;
            foto2.enabled = false;
            foto3.enabled = false;
            foto4.enabled = true;
            foto5.enabled = false;
            foto6.enabled = false;
            foto7.enabled = false;
            foto8.enabled = false;
        }
        if (grados < 0 && grados > -45)
        {
            foto1.enabled = false;
            foto2.enabled = false;
            foto3.enabled = false;
            foto4.enabled = false;
            foto5.enabled = false;
            foto6.enabled = false;
            foto7.enabled = false;
            foto8.enabled = true;
        }
        if (grados < -45 && grados > -90)
        {
            foto1.enabled = false;
            foto2.enabled = false;
            foto3.enabled = false;
            foto4.enabled = false;
            foto5.enabled = false;
            foto6.enabled = false;
            foto7.enabled = true;
            foto8.enabled = false;
        }
        if (grados < -90 && grados > -135)
        {
            foto1.enabled = false;
            foto2.enabled = false;
            foto3.enabled = false;
            foto4.enabled = false;
            foto5.enabled = false;
            foto6.enabled = true;
            foto7.enabled = false;
            foto8.enabled = false;
        }
        if (grados < -135 && grados > -180)
        {
            foto1.enabled = false;
            foto2.enabled = false;
            foto3.enabled = false;
            foto4.enabled = false;
            foto5.enabled = true;
            foto6.enabled = false;
            foto7.enabled = false;
            foto8.enabled = false;
        }

    }
}