using UnityEngine;
using UnityEngine.InputSystem;

public class GyroCameraUnity6 : MonoBehaviour
{
    private AttitudeSensor attitudeSensor;
    private Quaternion rotationFix;

    void Start()
    {
        InputSystem.EnableDevice(AttitudeSensor.current);
        attitudeSensor = AttitudeSensor.current;

        // Koreksi rotasi default HP → Unity
        rotationFix = Quaternion.Euler(90, 0, 0);
    }

    void Update()
    {
        if (attitudeSensor == null)
            return;

        // Ambil rotasi sensor
        Quaternion q = attitudeSensor.attitude.ReadValue();

        // Konversi orientasi Android → Unity
        Quaternion converted = new Quaternion(
            q.x,
            q.y,
            -q.z,
            -q.w
        );

        // Tambah offset agar tidak miring
        transform.localRotation = rotationFix * converted;
    }
}
