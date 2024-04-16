using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SettingHeight : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Height"))
        {
            transform.localScale += new Vector3(1f, 1f, 1f);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Obstacles"))
        {
            transform.localScale += new Vector3(-1f, -1f, -1f);
        }
    }

}
