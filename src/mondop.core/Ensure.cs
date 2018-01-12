using System;

namespace mondop.core
{
    public static class Ensure
    {
        public static TArg IsNotNull<TArg>(TArg argument,string name)
        {
            if (argument == null)
                throw new ArgumentNullException(name);

            return argument;
        }
    }
}
