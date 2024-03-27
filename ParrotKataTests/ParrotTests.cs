using ParrotRefactoringKata;
using Xunit;

namespace ParrotKataTests
{
    public class ParrotTest
    {
        [Fact]
        public void GetSpeedNorwegianBlueParrot_nailed()
        {
            var parrot = new Norwegian(true, 0);
            Assert.Equal(0.0, parrot.NewGetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed()
        {
            var parrot = new Norwegian(false, 1.5);
            Assert.Equal(18.0, parrot.NewGetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed_high_voltage()
        {
            var parrot = new Norwegian(false, 4);
            Assert.Equal(24.0, parrot.NewGetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_No_Coconuts()
        {
            var parrot = new African(0);
            Assert.Equal(12.0, parrot.NewGetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_One_Coconut()
        {
            var parrot = new African(1);
            Assert.Equal(3.0, parrot.NewGetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_Two_Coconuts()
        {
            var parrot = new African(2);
            Assert.Equal(0.0, parrot.NewGetSpeed());
        }

        [Fact]
        public void GetSpeedOfEuropeanParrot()
        {
            var parrot = new European();
            Assert.Equal(12.0, parrot.NewGetSpeed());
        }

        [Fact]
        public void GetCryOfEuropeanParrot()
        {
            var parrot = new European();
            Assert.Equal("Sqoork!", parrot.NewGetCry());
        }

        [Fact]
        public void GetCryOfAfricanParrot()
        {
            var parrot = new African(2);
            Assert.Equal("Sqaark!", parrot.NewGetCry());
        }

        [Fact]
        public void GetCryNorwegianBlueParrot_high_voltage()
        {
            var parrot = new Norwegian(false, 4);
            Assert.Equal("Bzzzzzz", parrot.NewGetCry());
        }

        [Fact]
        public void GetCryNorwegianBlueParrot_no_voltage()
        {
            var parrot = new Norwegian(false, 0);
            Assert.Equal("...", parrot.NewGetCry());
        }
    }
}


