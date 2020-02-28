using UnityEngine.Events;

public class CustomTrackableEventHandler : DefaultTrackableEventHandler
{
    public UnityEvent OnTrackingAction;
    public UnityEvent OffTrackingAction;

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        OnTrackingAction.Invoke();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        OffTrackingAction.Invoke();
    }
}