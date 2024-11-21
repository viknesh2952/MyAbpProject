﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbpProject.Configuration;

namespace MyAbpProject.Web.Host.Startup
{
    [DependsOn(
       typeof(MyAbpProjectWebCoreModule))]
    public class MyAbpProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyAbpProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyAbpProjectWebHostModule).GetAssembly());
        }
    }
}
