using Autofac;
using AutoMapper;
using MovieReview.Application.Interfaces;
using MovieReview.Application.Mappers;
using MovieReview.Application.Services;
using MovieReview.Core.Data;
using MovieReview.Domain.Interfaces.Repositories;
using MovieReview.Domain.Interfaces.Services;
using MovieReview.Domain.Services;
using MovieReview.Infra.Data;
using MovieReview.Infra.Data.Repositories;

namespace MovieReview.Infra.CrossCutting.IoC
{
    public class ConfigurationIoc
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IoC

            builder.RegisterType<MovieAppService>().As<IMovieAppService>();
            builder.RegisterType<MovieService>().As<IMovieService>();
            builder.RegisterType<MovieRepository>().As<IMovieRepository>();

            builder.RegisterType<UserAppService>().As<IUserAppService>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();

            builder.RegisterType<AccountAppService>().As<IAccountAppService>();
            builder.RegisterType<AccountService>().As<IAccountService>();
            builder.RegisterType<AccountRepository>().As<IAccountRepository>();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ActorDtoMap());
                cfg.AddProfile(new DirectorDtoMap());
                cfg.AddProfile(new GenreDtoMap());

                cfg.AddProfile(new CreateMovieActorModelMap());
                cfg.AddProfile(new CreateMovieDirectorModelMap());
                cfg.AddProfile(new CreateMovieGenreModelMap());
                cfg.AddProfile(new CreateMovieVoteModelMap());

                cfg.AddProfile(new CreateMovieModelMap());
                cfg.AddProfile(new MovieDtoMap());

                cfg.AddProfile(new CreateUserModelMap());
                cfg.AddProfile(new UpdateUserModelMap());
                cfg.AddProfile(new DeleteUserModelMap());
                cfg.AddProfile(new UserDtoMap());

                cfg.AddProfile(new AccountDtoMap());
                cfg.AddProfile(new AccountModelMap());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();

            #endregion IOC
        }

    }
}
