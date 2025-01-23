using UnityEngine;

public class Collision : MonoBehaviour
{
void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Hello issy! im bumping my car onto things!");
    }  
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Lap Complete!");    
    }
    void OnTriggerExit2D(Collider2D other) {
        Debug.Log("Checking");    
    }
}
