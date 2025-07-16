using UnityEngine;
using Vuforia;

public class MarkerEventHandler : MonoBehaviour
{
    public RotateObject rotateObject; // Skrip RotateObject untuk dihubungkan

    private ObserverBehaviour observerBehaviour;

    private void Awake()
    {
        observerBehaviour = GetComponent<ObserverBehaviour>();

        if (observerBehaviour)
        {
            observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnDestroy()
    {
        if (observerBehaviour)
        {
            observerBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            // Marker dikenali, reset rotasi
            rotateObject.ResetRotation();
        }
    }
}
