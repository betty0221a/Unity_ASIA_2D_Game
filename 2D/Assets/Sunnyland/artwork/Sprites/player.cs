using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject final;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "傳送門")


        {
            print("碰到傳送門");
            final.SetActive(true);
        }
     }
}
   
