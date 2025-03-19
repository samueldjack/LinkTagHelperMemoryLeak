namespace LinkTagHelperMemoryLeak
{
    public class MemoryHogService
    {
        private readonly byte[] _memoryHog;

        public MemoryHogService()
        {
            // Allocate and hold on to 10MB of memory to make the leak more obvious
            _memoryHog = new byte[1024 * 1024 * 10];
        }
    }
}
