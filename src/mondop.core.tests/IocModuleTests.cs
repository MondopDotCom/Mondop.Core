using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mondop.Abstractions.IoC;
using NSubstitute;

namespace Mondop.Core.Tests
{
    [TestClass]
    public class IocModuleTests
    {
        private IocModule module;
        private readonly IIoCContainer mockContainer = Substitute.For<IIoCContainer>();

        [TestInitialize]
        public void TestInitialize()
        {
            module = new IocModule();
        }

        [TestMethod]
        public void CallRegister_ExpectRegistrations()
        {
            module.Register(mockContainer);

            mockContainer.Received(1).Register<IFile, MondopFile>();
            mockContainer.Received(1).Register<IDirectory, MondopDirectory>();
        }
    }
}
