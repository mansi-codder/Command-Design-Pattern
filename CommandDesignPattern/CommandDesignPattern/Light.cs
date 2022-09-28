namespace CommandDesignPattern
{
    internal class Light
    {
        private bool _SwitchOn;
     
        internal void SwitchLights() { 
        _SwitchOn = !_SwitchOn;
        }
    }
}