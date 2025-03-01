using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timmy : MonoBehaviour
{
    [SerializeField]
    private float tocDoChay = 100f;
    [SerializeField]
    private float lucRe = 100f;
    [SerializeField]
    private float lucPhanh = 50f;
    [SerializeField]
    private GameObject hieuUngPhanh;
    private float dauVaoDiChuyen;
    private float dauVaoRe;
    private Rigidbody rb;


    private void Start()
    {
        rb= GetComponent<Rigidbody> ();
    }
    private void FixedUpdate()
{
    dauVaoDiChuyen = Input.GetAxis("Vertical");
    dauVaoRe = Input.GetAxis("Horizontal");
    DiChuyenTimmy();
    ReXe();
    if(dauVaoDiChuyen>0&& Input.GetKey(KeyCode.LeftShift))
    {
        Phanh();
    }
}
    public void DiChuyenTimmy()
    {
        rb.AddRelativeForce(Vector3.forward*dauVaoDiChuyen*tocDoChay);
        hieuUngPhanh.SetActive(false);
    }
    public void ReXe()
        {
            Quaternion re = Quaternion.Euler(Vector3.up*dauVaoRe*lucRe*Time.deltaTime);
            rb.MoveRotation(rb.rotation*re);
        }
    public void Phanh()
    {
        if(rb.velocity.z!=0)
        {
            rb.AddRelativeForce(-Vector3.forward*lucPhanh);
            hieuUngPhanh.SetActive(true);
        }
    }
}
