using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity.Specification.TestData;
using System;

namespace Unity.Specification.Diagnostic.Constructor.Injection
{
    public abstract partial class SpecificationTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NoReuse()
        {
            // Arrange
            var ctor = Invoke.Constructor();

            // Act
            Container.RegisterType<TypeWithAmbiguousCtors>("1", ctor)
                     .RegisterType<TypeWithAmbiguousCtors>("2", ctor);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NoConstructor()
        {
            // Act
            Container.RegisterType<TypeWithAmbiguousCtors>(
                Invoke.Constructor(Resolve.Parameter()));
        }

        [TestMethod]
        [ExpectedException(typeof(ResolutionFailedException))]
        public void MultipleConstructor()
        {
            // Arrange
            Container.RegisterType<TypeWithAmbiguousCtors>(
                Invoke.Constructor(),
                Invoke.Constructor());

            // Act
            Container.Resolve<TypeWithAmbiguousCtors>();
        }

    }
}
