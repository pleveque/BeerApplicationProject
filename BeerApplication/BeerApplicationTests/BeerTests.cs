using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BeerApplication;

namespace BeerApplicationTests
{
    [TestClass]
    public class BeerTests
    {
        
        [TestMethod]
        public void testPrintAllBeers()
        {
            Beer myBeer = new Beer();
            List<Beer> listBeer = myBeer.listAllBeers();

            Assert.IsNotNull(listBeer);
        }


        [TestMethod]
        public void searchBeer()
        {
            int id = 1;
            string name = "Budweiser";
            double price = 4.6;
            double percentAlcohol = 12.6;
            string originCountry = "USA";
            string description = "Budweiser Bier or Budweiser Bürgerbräu was the name for the beer and the administration of the Bürgerliches Brauhaus Budweis";
            TypeBeer typeBeer = TypeBeer.BLONDE;

            Beer myBeer = new Beer();
            List<Beer> listBeer = myBeer.searchForBeers(id, name, price, percentAlcohol, originCountry, description, typeBeer);

            Assert.IsNotNull(listBeer);
        }


        [TestMethod]
        public void seeDescriptionBeer()
        {
            int id = 1;
            Beer myBeer = new Beer();
            Beer foundBeer = myBeer.seeDescriptionBeer(id);

            Assert.Equals(foundBeer.id, id);
        }
    }
}
