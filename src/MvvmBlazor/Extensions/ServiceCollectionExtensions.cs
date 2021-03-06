﻿using Microsoft.Extensions.DependencyInjection;
using MvvmBlazor.Internal.Bindings;
using MvvmBlazor.Internal.Parameters;
using MvvmBlazor.Internal.WeakEventListener;

namespace MvvmBlazor.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMvvm(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IWeakEventManagerFactory, WeakEventManagerFactory>();
            serviceCollection.AddSingleton<IBindingFactory, BindingFactory>();
            serviceCollection.AddSingleton<IParameterResolver, ParameterResolver>();
            serviceCollection.AddSingleton<IParameterCache, ParameterCache>();
            serviceCollection.AddSingleton<IViewModelParameterSetter, ViewModelParameterSetter>();
            serviceCollection.AddHttpContextAccessor();

            return serviceCollection;
        }
    }
}