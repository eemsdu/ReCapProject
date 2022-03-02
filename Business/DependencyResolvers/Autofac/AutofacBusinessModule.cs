using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        //load:uygulama ayağa kaltığında kısaca uygulama çalıştırıldığında 
        protected override void Load(ContainerBuilder builder)
        {
            //birisi ıcarservice isterse ona carmanager instance(örneği) ver.
            //singleinstance:datanın kendisini tutmaz , tek bir instance oluşacak herkes ona versin 1 kere oluşturuyor ve onu herkese veriyor.
            //bizim yerimize newleme işlemini yapar 
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance(); 
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();

            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>().SingleInstance();

        }
    }
}
