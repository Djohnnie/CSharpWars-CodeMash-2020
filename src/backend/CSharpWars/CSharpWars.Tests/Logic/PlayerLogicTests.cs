using System;
using System.Threading.Tasks;
using CSharpWars.DataAccess.Repositories.Interfaces;
using CSharpWars.Logic;
using CSharpWars.Logic.Interfaces;
using CSharpWars.Mapping;
using CSharpWars.Model;
using FluentAssertions;
using Moq;
using Xunit;

namespace CSharpWars.Tests.Logic
{
    public class PlayerLogicTests
    {
        [Fact]
        public async Task PlayerLogic_GetAllPlayers_Should_Return_All_Players()
        {
            // Arrange
            var playerRepository = new Mock<IRepository<Player>>();
            IPlayerLogic playerLogic = new PlayerLogic(playerRepository.Object, new PlayerMapper());
            Player player1 = new Player
            {
                Id = Guid.NewGuid(),
                Name = "Player1Name"
            };
            Player player2 = new Player
            {
                Id = Guid.NewGuid(),
                Name = "Player2Name"
            };

            // Mock
            playerRepository.Setup(x => x.GetAll()).ReturnsAsync(new[] { player1, player2 });

            // Act
            var result = await playerLogic.GetAllPlayers();

            // Assert
            result.Should().HaveCount(2);
            result.Should().ContainEquivalentOf(player1, properties => properties
                .Including(p => p.Id)
                .Including(p => p.Name));
            result.Should().ContainEquivalentOf(player2, properties => properties
                .Including(p => p.Id)
                .Including(p => p.Name));
        }
    }
}