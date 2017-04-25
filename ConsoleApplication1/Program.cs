using Autofac;
using ClassLibrary1;
using System;
using Autofac.Configuration;

namespace ConsoleApplication1
{
    class Program
    {

        public enum DBType { Sql, Redis }

        static void Main(string[] args)
        {
            //ContainerBuilder builder = new ContainerBuilder();

            //（1）builder.RegisterType<Object>().As<Iobject>()：注册类型及其实例。

            //builder.RegisterType<DBBase>();

            //builder.RegisterType<SqlRepository>().As<IRepository>();


            //using (var container = builder.Build())
            //{
            //    //（2）IContainer.Resolve<IDAL>()：解析某个接口的实例。
            //    var manager = container.Resolve<DBBase>();
            //    manager.Search("select * form aabbccdd");
            //}


            //（3）builder.RegisterType<Object>().Named<Iobject>(string name)：
            //为一个接口注册不同的实例。有时候难免会碰到多个类映射同一个接口
            //为了准确获取想要的类型，就必须在注册时起名字。

            //var builder2 = new ContainerBuilder();
            //builder2.RegisterType<DBBase>();
            //builder2.RegisterType<SqlRepository>().Named<IRepository>("sql");
            //builder2.RegisterType<RedisRepository>().Named<IRepository>("redis");

            //using (var contaier2 = builder2.Build())
            //{
            //    //（4）IContainer.ResolveNamed<IDAL>(string name):解析某个接口的“命名实例”。

            //    var manager1 = contaier2.ResolveNamed<IRepository>("sql") as SqlRepository;
            //    var manager2 = contaier2.ResolveNamed<IRepository>("redis") as RedisRepository;

            //    manager1.Get("aaaa");
            //    manager2.Get("aaaa");
            //}

            ////（5）builder.RegisterType<Object>().Keyed<Iobject>(Enum enum)：以枚举的方式为一个接口注册不同的实例。有时候我们会将某一个接口的不同实现用枚举来区分，而不是字符串，例如：

            //var builder3 = new ContainerBuilder();

            //builder3.RegisterType<DBBase>();
            //builder3.RegisterType<SqlRepository>().Keyed<IRepository>(DBType.Sql);
            //builder3.RegisterType<RedisRepository>().Keyed<IRepository>(DBType.Redis);
            //builder3.RegisterType<SqlRepository>().As<IRepository>();
            //builder3.RegisterType<RedisRepository>().As<IRepository>();

            //using (var container = builder3.Build())
            //{
            //    //（6）IContainer.ResolveKeyed<IDAL>(Enum enum):根据枚举值解析某个接口的特定实例。例如上面的最后一行代码就是解析IDAL的特定实例OracleDAL
            //    //var m = container.ResolveKeyed<IRepository>(DBType.Sql);
            //    //var n = container.ResolveKeyed<IRepository>(DBType.Redis);

            //    //m.Get("aaaaaa");
            //    //n.Get("aaaaaccccc");

            //    DBBase db = container.Resolve<DBBase>(new NamedParameter("name", "SQL"));

            //    db.Search("ksdflaksjdf ");
            //}

            //（7）builder.RegisterType<Worker>().InstancePerDependency()：用于控制对象的生命周期，每次加载实例时都是新建一个实例，默认就是这种方式
            //（8）builder.RegisterType<Worker>().SingleInstance()：用于控制对象的生命周期，每次加载实例时都是返回同一个实例
            //（9）IContainer.Resolve<T>(NamedParameter namedParameter):在解析实例T时给其赋值


            //ContainerBuilder builder = new ContainerBuilder();

            //builder.RegisterType<DBBase>();
            ////builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            //using (var container = builder.Build())
            //{
            //    var manager = container.Resolve<DBBase>();
            //    manager.Search("aaaaaa");
            //}

            Console.ReadKey();

        }
    }
}
