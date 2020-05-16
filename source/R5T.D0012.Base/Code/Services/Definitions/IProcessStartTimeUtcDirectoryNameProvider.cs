using System;
using System.Threading.Tasks;


namespace R5T.D0012
{
    public interface IProcessStartTimeUtcDirectoryNameProvider
    {
        Task<string> GetProcessStartTimeUtcDirectoryName();
    }
}
