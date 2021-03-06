﻿using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TT.Abp.OssManagement;
using TT.Abp.ShopManagement;
using TT.Abp.VisitorManagement;
using TT.SoMall.Controllers;
using Volo.Abp.Account;
using Volo.Abp.AspNetCore.Mvc.Conventions;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.TenantManagement;

namespace TT.SoMall
{
    [DependsOn(
        typeof(SoMallApplicationContractsModule),
        typeof(AbpAccountHttpApiModule),
        typeof(AbpIdentityHttpApiModule),
        typeof(AbpPermissionManagementHttpApiModule),
        typeof(AbpTenantManagementHttpApiModule),
        typeof(ShopManagementModule),
        typeof(OssManagementModule),
        typeof(VisitorManagementModule),
        typeof(AbpFeatureManagementHttpApiModule)
    )]
    public class SoMallHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Replace(ServiceDescriptor.Transient<IAbpServiceConvention, TtServiceConvention>());
        }
    }
}