using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonLook : MonoBehaviour
{
    Vector2 currentMouseLook;
    Vector2 appliedMouseDelta;
    public float sensitivity = 1;
    public float smoothing = 2;

    GameObject character;

    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        appliedMouseDelta.x = Mathf.Lerp(appliedMouseDelta.x, md.x, 1f / smoothing);
        appliedMouseDelta.y = Mathf.Lerp(appliedMouseDelta.y, md.y, 1f / smoothing);
        currentMouseLook += appliedMouseDelta;

        transform.localRotation = Quaternion.AngleAxis(-currentMouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(currentMouseLook.x, character.transform.up);
    }
}
