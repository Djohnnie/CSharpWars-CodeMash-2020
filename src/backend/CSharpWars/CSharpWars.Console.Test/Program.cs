using System;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using CSharpWars.Common.DependencyInjection;
using CSharpWars.Common.Extensions;
using CSharpWars.DtoModel;
using CSharpWars.Logic.DependencyInjection;
using CSharpWars.Logic.Interfaces;
using static System.Convert;
using static System.Environment;

namespace CSharpWars.Console.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();

            services.ConfigurationHelper(c =>
            {
                c.ConnectionString = GetEnvironmentVariable("CONNECTION_STRING");
                c.ArenaSize = ToInt32(GetEnvironmentVariable("ARENA_SIZE"));
                c.ValidationHost = GetEnvironmentVariable("VALIDATION_HOST");
                c.BotDeploymentLimit = ToInt32(GetEnvironmentVariable("BOT_DEPLOYMENT_LIMIT"));
            });
            services.ConfigureCommon();
            services.ConfigureLogic();

            var provider = services.BuildServiceProvider();

            var playerLogic = provider.GetService<IPlayerLogic>();
            var player = await playerLogic.CreatePlayer($"{Guid.NewGuid()}");

            var botToCreate = new BotToCreateDto
            {
                PlayerId = player.Id,
                Name = $"{Guid.NewGuid()}",
                MaximumHealth = 10000,
                MaximumStamina = 10000,
                Script = BotScripts.HuntDown.Base64Encode()
            };

            var botLogic = provider.GetService<IBotLogic>();
            await botLogic.CreateBot(botToCreate);
        }
    }
}