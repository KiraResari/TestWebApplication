namespace TestWebApplication.Backend
{
    public static class TestDevices
    {
        public static readonly List<Device> list = new List<Device>() {
            new Device("Test Device 1", "Test Description 1"),
            new Device("Test Device 2", "Test Description 2"),
            new Device("Test Device 3", "Test Description 3")
        };
    }
}
