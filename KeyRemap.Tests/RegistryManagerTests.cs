using KeyRemap.Interface;
using Moq;
using Xunit;

namespace KeyRemap.Tests
{
    public class RegistryManagerTests
    {
        private Mock<IRegistryManager> _mockRegistryManager;

        public RegistryManagerTests()
        {
            _mockRegistryManager = new Mock<IRegistryManager>();
        }

        [Fact]
        public void RemapKeyInRegistry_ShouldInvokeRegistryMethod()
        {
            var mockScancodeMap = new byte[] { 0x00, 0x00, 0x00, 0x00 };
            _mockRegistryManager.Object.RemapKeyInRegistry(mockScancodeMap);
            _mockRegistryManager.Verify(rm => rm.RemapKeyInRegistry(It.IsAny<byte[]>()), Times.Once);
        }

        [Fact]
        public void ResetKeyMappings_ShouldInvokeResetRegistryMethod()
        {
            _mockRegistryManager.Object.ResetKeyMappings();
            _mockRegistryManager.Verify(rm => rm.ResetKeyMappings(), Times.Once);
        }
    }
}
