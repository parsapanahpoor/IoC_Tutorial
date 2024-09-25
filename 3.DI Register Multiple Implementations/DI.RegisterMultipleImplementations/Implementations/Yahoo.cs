namespace DI.RegisterMultipleImplementations.Interface
{
    public class Yahoo : ISendEmailService
    {
        public string Send()
        {
            
            return "Send Mail With Yahoo Company!";
        }
    }
}
