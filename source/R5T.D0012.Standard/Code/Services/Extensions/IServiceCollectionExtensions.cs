using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0012.D0011;


namespace R5T.D0012.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IProcessStartTimeUtcDirectoryNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddProcessStartTimeUtcDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddD0011ProcessStartTimeUtcDirectoryNameProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IProcessStartTimeUtcDirectoryNameProvider"/> service.
        /// </summary>
        public static ServiceAction<IProcessStartTimeUtcDirectoryNameProvider> AddProcessStartTimeUtcDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IProcessStartTimeUtcDirectoryNameProvider>.New(() => services.AddProcessStartTimeUtcDirectoryNameProvider());
            return serviceAction;
        }
    }
}
