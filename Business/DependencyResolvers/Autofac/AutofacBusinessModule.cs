using Autofac;
using Autofac.Extras.DynamicProxy;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Castle.DynamicProxy;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CustomerAcccountManager>().As<ICustomerAccountService>().SingleInstance();
			builder.RegisterType<EfCustomerAccountDal>().As<ICustomerAccountDal>().SingleInstance();

			builder.RegisterType<EfCustomerAccountProcessDal>().As<ICustomerAccountProcessDal>().SingleInstance();


			//var assembly = System.Reflection.Assembly.GetExecutingAssembly();

			//builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
			//   .EnableInterfaceInterceptors(new ProxyGenerationOptions()
			//   {
			//	   Selector = new AspectInterceptorSelector()
			//   }).SingleInstance();

		}
	}
}
