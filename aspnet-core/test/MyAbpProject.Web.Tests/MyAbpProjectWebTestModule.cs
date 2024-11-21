using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbpProject.EntityFrameworkCore;
using MyAbpProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyAbpProject.Web.Tests
{
    [DependsOn(
        typeof(MyAbpProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyAbpProjectWebTestModule : AbpModule
    {
        public MyAbpProjectWebTestModule(MyAbpProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyAbpProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyAbpProjectWebMvcModule).Assembly);
        }
    }
}