namespace Shipbot.Controller.Core.Models
{
    public abstract class ImageUpdatePolicy
    {
        public abstract bool IsMatch(string value);
    }
}