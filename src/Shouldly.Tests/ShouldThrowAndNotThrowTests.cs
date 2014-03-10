using System;
using NUnit.Framework;

namespace Shouldly.Tests
{
    [TestFixture]
    public class ShouldThrowAndNotThrowTests
    {
        [Test]
        public void ShouldThrow_WhenItThrowsCorrectException()
        {
            Action shouldThrowAction =
                () => Should.Throw<NotImplementedException>(new Action(() =>
                {
                    throw new NotImplementedException();
                }));

            TestHelpers.Should.NotError(shouldThrowAction);
        }

        [Test]
        public void ShouldNotThrow_IfCallDoesNotThrow_ShouldDoNothing()
        {
            TestHelpers.Should.NotError(
                () => Should.NotThrow(() => {})
                );
            
        }

        [Test]
        public void ShouldNotThrow_IfCallDoesNotThrow_ShouldDoNothingAndReturnValue()
        {
            TestHelpers.Should.NotError(
                () => Should.NotThrow(() => 1).ShouldBe(1));
        }
    }
}