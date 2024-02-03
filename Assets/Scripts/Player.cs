using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 direccion = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(direccion * _speed * Time.deltaTime);
    }

    public void getView(Vector3 angle)
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, angle.y, transform.eulerAngles.z);
    }


}
