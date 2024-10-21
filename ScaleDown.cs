using UnityEngine;
using DG.Tweening;

public class ScaleDownObject : MonoBehaviour
{
    public GameObject targetObject; // Drag the 3D GameObject here
    public float scaleMultiplier = 0.5f; // How much to decrease the size
    public float duration = 2f; // Duration of the scaling animation

    // Call this function when the button is pressed
    public void DecreaseSize()
    {
        // Use the Transform component to scale the 3D GameObject smoothly
        targetObject.transform.DOScale(targetObject.transform.localScale * scaleMultiplier, duration)
            .SetEase(Ease.InOutQuad); // Smooth scaling with easing
    }
}









