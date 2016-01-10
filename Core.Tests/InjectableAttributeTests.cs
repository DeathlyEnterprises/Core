using Core.Attributes;
using FluentAssertions;
using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    public class InjectableAttributeTests
    {
        [Test]
        public void TestInjectableAttributeSingletonLifestyle()
        {
            //Given that the following instance of the InjectableAttribute class is initialized
            var injectableAttribute = new InjectableAttribute(InjectableLifestyle.Singleton);

            //When we get the value returned by the Lifestyle propery
            var lifestyle = injectableAttribute.Lifestyle;

            //Then the value returned should match the Singleton lifestyle
            lifestyle.Should().Be(InjectableLifestyle.Singleton);
        }
    }
}