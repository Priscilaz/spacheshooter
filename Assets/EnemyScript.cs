using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        // Mover la hamburguesa hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que colisionó es una bala
        if (other.CompareTag("Bala"))
        {
            Destroy(other.gameObject); // Destruye la bala
            Destroy(gameObject);       // Destruye la hamburguesa
        }
    }
}
