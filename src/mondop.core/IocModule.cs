using Mondop.Abstractions.IoC;
using System;
using System.Collections.Generic;

namespace Mondop.Core
{
    public class IocModule : IIoCModule
    {
        public List<Type> DependsOn => new List<Type>();

        public void Register(IIoCContainer container)
        {
            container.Register<IDirectory, MondopDirectory>();
            container.Register<IFile, MondopFile>();
        }
    }
}
