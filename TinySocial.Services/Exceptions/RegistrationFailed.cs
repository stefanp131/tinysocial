using System;

namespace TinySocial.Services.Exceptions
{
    public class RegistrationFailed : Exception
    {
        public RegistrationFailed()
        {

        }

        public RegistrationFailed(string message) : base(message)
        {

        }
    }
}
