namespace DI.RegisterMultipleImplementations.Interface
{
    public class Gmail : ISendEmailService
    {
        public string Send()
        {
            return "Send Mail With gamil!";
        }
    }
}
