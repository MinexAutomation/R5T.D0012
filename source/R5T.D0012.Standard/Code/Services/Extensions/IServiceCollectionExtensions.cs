using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0008;
using R5T.D0008.Standard;
using R5T.D0011;
using R5T.D0011.Standard;
using R5T.D0012.D0011;


namespace R5T.D0012.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IProcessStartTimeUtcDirectoryNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddProcessStartTimeUtcDirectoryNameProvider(this IServiceCollection services,
            IServiceAction<IProcessStartTimeUtcProvider> processStartTimeUtcProvider,
            IServiceAction<ITimestampUtcDirectoryNameProvider> timestampUtcDirectoryNameProvider)
        {
            services.AddD0011ProcessStartTimeUtcDirectoryNameProvider(
                processStartTimeUtcProvider,
                timestampUtcDirectoryNameProvider);

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IProcessStartTimeUtcDirectoryNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddProcessStartTimeUtcDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddProcessStartTimeUtcDirectoryNameProvider(
                services.AddProcessStartTimeUtcProviderAction(),
                services.AddTimestampUtcDirectoryNameProviderAction());

            return services;
        }

        public static IServiceAction<IProcessStartTimeUtcDirectoryNameProvider> AddProcessStartTimeUtcDirectoryNameProviderAction(this IServiceCollection services,
            IServiceAction<IProcessStartTimeUtcProvider> processStartTimeUtcProvider,
            IServiceAction<ITimestampUtcDirectoryNameProvider> timestampUtcDirectoryNameProvider)
        {
            var serviceAction = ServiceAction<IProcessStartTimeUtcDirectoryNameProvider>.New(() => services.AddProcessStartTimeUtcDirectoryNameProvider(
                processStartTimeUtcProvider,
                timestampUtcDirectoryNameProvider));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="IProcessStartTimeUtcDirectoryNameProvider"/> service.
        /// </summary>
        public static (
            IServiceAction<IProcessStartTimeUtcDirectoryNameProvider> processStartTimeUtcDirectoryNameProviderAction,
            IServiceAction<IProcessStartTimeUtcProvider> processStartTimeUtcProviderAction,
            IServiceAction<ITimestampUtcDirectoryNameProvider> timestampUtcDirectoryNameProviderAction) AddProcessStartTimeUtcDirectoryNameProviderAction(this IServiceCollection services)
        {
            var output = (
                processStartTimeUtcDirectoryNameProviderAction: ServiceAction<IProcessStartTimeUtcDirectoryNameProvider>.New(() => services.AddProcessStartTimeUtcDirectoryNameProvider()),
                processStartTimeUtcProviderAction: ServiceAction<IProcessStartTimeUtcProvider>.AlreadyAdded,
                timestampUtcDirectoryNameProviderAction: ServiceAction<ITimestampUtcDirectoryNameProvider>.AlreadyAdded);
            return output;
        }
    }
}
