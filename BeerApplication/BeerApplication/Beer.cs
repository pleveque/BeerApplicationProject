

using System;
using System.Collections.Generic;

namespace BeerApplication
{
    public class Beer
    {

        public TypeBeer typeBeer;
        public string name;
        public double price;
        public string origin;
        public double percentAlcohol;
        public string description;
        public int id;


        /*
         * This method allow to display on the screen all the beer searched by the user. She may be in correlation with searchForBeers.
         * return all the beer corresponding to search criteria.
        */
        public List<Beer> listAllBeers()
        {
            //This is an example of a Fake implementation to run the unit test

            Beer guiness = new Beer();
            Beer heineken = new Beer();
            List<Beer> listBeer = new List<Beer>();
            listBeer.Add(guiness);
            listBeer.Add(heineken);

            return listBeer;
        }


        /* 
         * This method allow user to search beers, all attributes is not necessary they will be choosen by the user. 
         * return a list of beers corresponding criterias searched by the user. 
        */
        public List<Beer> searchForBeers(int id, string name, double price, double percentAlcohol, string originCountry, string description, TypeBeer typeBeer)
        {
            throw new NotImplementedException();
        }


        /*
         * This method allow user to see a particular beer after this research.
         * return all information of the beer choosen
        */ 
        public Beer seeDescriptionBeer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
 