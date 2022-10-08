using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFolw : MonoBehaviour
{
    [SerializeField] Transform player;

    public float smoothing = 0.1f;
    private Vector3 offset;

    private void Awake()
    {
        offset = transform.position-player.position;
    }
    void FixedUpdate()
    {
        Vector3 newCampos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, newCampos, smoothing * Time.deltaTime);
    }
}
