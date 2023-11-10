using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class TextMeshProFollowObject : MonoBehaviour
{
    public Transform target; 
    public TextMeshProUGUI textElement; 
    public Vector3 offset = new Vector3(0f, 1f, 0f); 

    private void Update()
    {
        if (target != null)
        {
            
            Vector3 targetPosition = target.position;

            
            targetPosition += offset;

          
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(targetPosition);

            textElement.rectTransform.position = screenPosition;
            //textElement.text = "Number: " + GameManager.countScene.ToString();
            textElement.text = playermanager.A ;




        }
    }
}
