using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0012.D0011
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProcessStartTimeUtcDirectoryNameProvider"/> implementation of <see cref="IProcessStartTimeUtcDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddD0011ProcessStartTimeUtcDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IProcessStartTimeUtcDirectoryNameProvider, ProcessStartTimeUtcDirectoryNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ProcessStartTimeUtcDirectoryNameProvider"/> implementation of <see cref="IProcessStartTimeUtcDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IProcessStartTimeUtcDirectoryNameProvider> AddD0011ProcessStartTimeUtcDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IProcessStartTimeUtcDirectoryNameProvider>.New(() => services.AddD0011ProcessStartTimeUtcDirectoryNameProvider());
            return serviceAction;
        }
    }
}
