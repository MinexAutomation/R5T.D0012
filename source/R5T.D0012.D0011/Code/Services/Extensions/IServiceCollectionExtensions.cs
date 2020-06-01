using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0008;
using R5T.D0011;


namespace R5T.D0012.D0011
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProcessStartTimeUtcDirectoryNameProvider"/> implementation of <see cref="IProcessStartTimeUtcDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddD0011ProcessStartTimeUtcDirectoryNameProvider(this IServiceCollection services,
            IServiceAction<IProcessStartTimeUtcProvider> processStartTimeUtcProvider,
            IServiceAction<ITimestampUtcDirectoryNameProvider> timestampUtcDirectoryNameProvider)
        {
            services
                .AddSingleton<IProcessStartTimeUtcDirectoryNameProvider, ProcessStartTimeUtcDirectoryNameProvider>()
                .Run(processStartTimeUtcProvider)
                .Run(timestampUtcDirectoryNameProvider)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ProcessStartTimeUtcDirectoryNameProvider"/> implementation of <see cref="IProcessStartTimeUtcDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IProcessStartTimeUtcDirectoryNameProvider> AddD0011ProcessStartTimeUtcDirectoryNameProviderAction(this IServiceCollection services,
            IServiceAction<IProcessStartTimeUtcProvider> processStartTimeUtcProvider,
            IServiceAction<ITimestampUtcDirectoryNameProvider> timestampUtcDirectoryNameProvider)
        {
            var serviceAction = ServiceAction<IProcessStartTimeUtcDirectoryNameProvider>.New(() => services.AddD0011ProcessStartTimeUtcDirectoryNameProvider(
                processStartTimeUtcProvider,
                timestampUtcDirectoryNameProvider));
            return serviceAction;
        }
    }
}
