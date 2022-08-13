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


    [TestMethod]
    [DataRow(4, "d4")]
    [DataRow(6, "d6")]
    [DataRow(8, "d8")] 
    [DataRow(10, "d10")]
    [DataRow(12, "d12")]
    [DataRow(20, "d20")]
    public void DieWithCustomSides(int sides, string name)
    {
        d.Name().Should().Be(name);
        d.Numsides().Should().Be(sides);
        
    }


    [TestMethod]
    [DataRow(6)]
    [DataRow(8)]
    public void CorrectCustomSides(int sides)
    {
        
        for (int i = 0; i < 1000; i++)
        {
            d.Roll();
            d.CurrentSide().Should().BeInRange(1, sides);
        }

    }


    [TestMethod]
    [DataRow(4, "d4", 2)]
    [DataRow(6, "d6", 3)]
    [DataRow(8, "8", 4)]
    public void CorrectNewside(int sides, string name, int currentSide)
    {
        
        die.NumberSides().Should().Be(sides);
        die.Name().Should().Be(name);
        die.CurrentSide().Should().Be(currentSide);
    }




}

