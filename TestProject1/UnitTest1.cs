using ObjednavkaProjekt.Třídy;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
        
            var objednavka = new Objednavka(1000m, 0);

            Assert.Equal(0m, objednavka.VypocitejSlevu());
            Assert.Equal(99m, objednavka.VypocitejDopravu());
            Assert.Equal(1099m, objednavka.VypocitejCelkem());
        
        }

        [Fact]
        public void TestT2()
        {
            var objednavka = new Objednavka(1499m, 0);

            Assert.Equal(0m, objednavka.VypocitejSlevu());
            Assert.Equal(99m, objednavka.VypocitejDopravu());
            Assert.Equal(1598m, objednavka.VypocitejCelkem());
        }
    }
}
