namespace IAmMap.CommandResults.Implementation
{
    internal class LoginCommandResult : ILoginCommandResult
    {
        public LoginCommandResult(bool successed)
        {
            Successed = successed;
        }

        #region ILoginCommandResult Members

        public bool Successed { get; set; }

        #endregion
    }
}