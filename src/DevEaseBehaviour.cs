public class DevEaseBehaviour : ModBehaviour
{
    private DesignAutoPromote _designAutoPromote;

    public override void OnActivate()
    {
        _designAutoPromote = new DesignAutoPromote();
    }

    public override void OnDeactivate()
    {
        _designAutoPromote = null;
    }

    private void Update()
    {
        if (_designAutoPromote != null)
            _designAutoPromote.Check();
    }
}
