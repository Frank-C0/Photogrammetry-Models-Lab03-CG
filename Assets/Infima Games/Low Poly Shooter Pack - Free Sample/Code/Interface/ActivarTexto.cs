using UnityEngine;
using TMPro;

public class ActivarTexto : MonoBehaviour
{
    // Referencia al TextMeshProUGUI que se activar�
    public TextMeshProUGUI textoContador;

    // Variable para verificar si el texto ya ha sido activado
    private bool textoActivado = false;

    void Start()
    {
        // Comprobamos si se ha asignado el TextMeshProUGUI
        if (textoContador == null)
        {
            Debug.LogError("El TextMeshProUGUI no est� asignado en el script ActivarTextoCuandoContador15.");
            return;
        }
    }

    void Update()
    {
        // Verificamos si el contador alcanz� 15 y si el texto no ha sido activado
        if (PlayerPosition.Instance.getContadorDrones() >= 15 && !textoActivado)
        {
            // Activamos el TextMeshProUGUI
            textoContador.gameObject.SetActive(true);
            textoActivado = true;

            // Desactivamos el TextMeshProUGUI despu�s de 4 segundos
            Invoke("DesactivarTexto", 4f);
        }
    }

    // M�todo para desactivar el TextMeshProUGUI
    void DesactivarTexto()
    {
        textoContador.gameObject.SetActive(false);
    }
}
