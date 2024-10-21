using UnityEngine;
using DG.Tweening;

public class ScaleUpObject : MonoBehaviour
{
    public GameObject targetObject; // Drag the 3D GameObject here
    public float scaleMultiplier = 1.5f; // How much to increase the size
    public float duration = 2f; // Duration of the scaling animation

    // Call this function when the button is pressed
    public void IncreaseSize()
    {
        // Use the Transform component to scale the 3D GameObject smoothly
        targetObject.transform.DOScale(targetObject.transform.localScale * scaleMultiplier, duration)
            .SetEase(Ease.InOutQuad); // Smooth scaling with easing
    }
}







