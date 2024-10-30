using UnityEngine;

public class BalaScript : MonoBehaviour
{
    public float speed = 20f;        // Velocidad de la bala
    public float lifeTime = 2f;      // Tiempo de vida de la bala

    private Rigidbody rb;

    void Start()
    {
        // Obtener el componente Rigidbody y aplicar la velocidad
        rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = transform.forward * speed;
        }
        else
        {
            Debug.LogWarning("El objeto Bala1 no tiene un componente Rigidbody.");
        }

        // Destruir la bala después de un tiempo
        Destroy(gameObject, lifeTime);
    }
}
