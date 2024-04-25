using UnityEngine;

public class SateliteController : MonoBehaviour
{
    private Vector3 sunDirection;
    private Quaternion rotationToSun;
    [SerializeField] private SunController sun;
    private void Update()
    {
        sunDirection = (sun.transform.position - transform.position).normalized;
    }
    private void FixedUpdate()
    {
        rotationToSun = Quaternion.LookRotation(sunDirection);
        transform.rotation =  rotationToSun;
    }
}
