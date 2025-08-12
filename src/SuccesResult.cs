namespace MyResults
{
    public class SuccesResult : Result
    {
        //succes true dir.
        public SuccesResult(string message) : base(true, message)
        {

        }

        public SuccesResult(bool success) : base(true)
        {

        }
    }
}
