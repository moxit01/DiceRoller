namespace DiceRollerTests;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RollerDice.Models;


[TestClass]
public class DieUnitTest
{
    Die d = new Die();


    [TestMethod]
    public void DieClassNotNull()
    {

        d.Should().NotBeNull();

    }

    [TestMethod]
    public void DieHasAllDefaultValue()
    {

        d.Name.Should().Be("d6");

        d.NumberSides.Should().Be(6);

        d.CurrentSide.Should().BeInRange(1, 6);

    }

    [TestMethod]
    public void DefaultRollSetsSideCorrectly()
    {
        for (int i = 0; i < 200; i++)
        {

            d.Roll();

            d.CurrentSide.Should().BeInRange(1, 6);


        }
    }


   


}

