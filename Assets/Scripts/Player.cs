using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;
    [SerializeField] GameObject laser;

    Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;
    }

    void Update()
    {
        // Récupérer position souris
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = mainCam.ScreenToWorldPoint(new Vector3(mousePos.x, mainCam.nearClipPlane + 10f));

        // Seulement l’axe Y
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Lerp(transform.position.x, worldPos.x, moveSpeed * Time.deltaTime);
        transform.position = newPosition;

        // Tir laser
        if (Input.GetButtonDown("FireLaser"))
        {
            Instantiate(laser, transform.position, Quaternion.identity);
        }
    }
}
