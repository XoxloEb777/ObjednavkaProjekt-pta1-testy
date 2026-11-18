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
        [Fact]
        public void TestT3()
        {
            var objednavka = new Objednavka(1500m, 0);

            Assert.Equal(0m, objednavka.VypocitejSlevu());
            Assert.Equal(0m, objednavka.VypocitejDopravu());
            Assert.Equal(1500m, objednavka.VypocitejCelkem());
        }
        [Fact]
        public void TestT4()
        {
            var objednavka = new Objednavka(1999m, 0);

            Assert.Equal(0m, objednavka.VypocitejSlevu());
            Assert.Equal(0m, objednavka.VypocitejDopravu());
            Assert.Equal(1999m, objednavka.VypocitejCelkem());
        }
        [Fact]
        public void TestT5()
        {
            var objednavka = new Objednavka(2000m, 0);

            Assert.Equal(100m, objednavka.VypocitejSlevu());
            Assert.Equal(0m, objednavka.VypocitejDopravu());
            Assert.Equal(1900m, objednavka.VypocitejCelkem());
        }
        [Fact]
        public void TestT6()
        {
            var objednavka = new Objednavka(4999m, 0);

            Assert.Equal(249.95m, objednavka.VypocitejSlevu());
            Assert.Equal(0m, objednavka.VypocitejDopravu());
            Assert.Equal(4749.05m, objednavka.VypocitejCelkem());
        }
    }
}
