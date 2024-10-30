using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float tilt = 5f;
    public GameObject Bala1;       // Prefab de la bala
    public Transform Cannon1; // Punto de disparo
    public Transform Cannon2; // Punto de disparo
    public Transform Cannon3; // Punto de disparo
    public float fireRate = 0.5f;  // Frecuencia de disparo

    private Rigidbody rb;
    private float nextFire = 0f;   // Tiempo para el siguiente disparo

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Evita rotación indeseada
    }

    void Update()
    {
        // Control de disparo
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            
            Shoot();
            nextFire = Time.time + fireRate;
        }
    }

    void FixedUpdate()
    {
        // Control de movimiento de la nave
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed;
        rb.velocity = movement;

        // Aplicar inclinación en base al movimiento horizontal
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }

    void Shoot()
    {
        // Verificar que Bala1 y shooterPoint no sean nulos
        if (Bala1 != null && Cannon1 != null && Cannon2 != null && Cannon3 != null)
        {
            Instantiate(Bala1, Cannon1.position, Cannon1.rotation);
            Instantiate(Bala1, Cannon2.position, Cannon2.rotation);
            Instantiate(Bala1, Cannon3.position, Cannon3.rotation);
        }
        else
        {
            Debug.LogWarning("Bala1 o shooterPoint no están asignados en el inspector.");
        }
    }
}
