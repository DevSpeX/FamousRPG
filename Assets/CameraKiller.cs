using System;
using UnityEngine;

public class CameraKiller : MonoBehaviour
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        {
            RaycastHit2D hit = Physics2D.Raycast(camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.CompareTag("Destroyable"))
            {
                Destroy(hit.collider.gameObject);
            }
        }

        if (Input.GetMouseButtonDown(1));
        {
            RaycastHit2D hit = Physics2D.Raycast(camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                Instantiate(hit.collider.gameObject, hit.point, Quaternion.identity);
            }
        }
    }
}
