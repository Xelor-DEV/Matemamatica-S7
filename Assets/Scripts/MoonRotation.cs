using UnityEngine;

public class MoonRotation : MonoBehaviour
{
    [Header("Rotation Elements")]
    [SerializeField] private float rotationSpeed;
    private Vector3 angulos;
    private Quaternion qy = Quaternion.identity;
    private Quaternion r = Quaternion.identity;
    private float anguloSen;
    private float anguloCos;

    private void FixedUpdate()
    {
        angulos.y = angulos.y - (rotationSpeed * Time.deltaTime);
        angulos.y = angulos.y - 360 * Mathf.Floor(angulos.y / 360);

        anguloSen = Mathf.Sin((Mathf.PI / 180) * angulos.y * 1 / 2);
        anguloCos = Mathf.Cos((Mathf.PI / 180) * angulos.y * 1 / 2);
        qy.Set(0, anguloSen, 0, anguloCos);

        r = qy * Quaternion.identity * Quaternion.identity;
        transform.localRotation = r;
    }
}
