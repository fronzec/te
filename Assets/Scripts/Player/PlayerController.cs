using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float rotationAngle = 150f;

    [SerializeField] private float deltaTraslation = 3f;

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotationAngle;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * deltaTraslation;
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}