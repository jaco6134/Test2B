using System;

namespace WebShopV05
{
    public class InsertCodeHere
    {
        private double netPriceshipping;

        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            double netPriceShipping = 49;
            double netPriceTax = 1.1;
            double netPriceFee = 1.02;


            int noOfBooksInOrder = 0;
            int noOfDVDsInOrder = 12;
            int noOfGamesInOrder = 4;
            int totalNumberOfOrders = (noOfGamesInOrder + noOfDVDsInOrder + noOfBooksInOrder);

            double totalPrice = (((netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder) * netPriceTax + netPriceShipping) * netPriceFee);

            if ((totalNumberOfOrders >= 15) && (totalNumberOfOrders <= 29))
            {
                double netPriceDiscountOne = 0.95;
                totalPrice = ((((netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder) * netPriceTax + netPriceShipping) * netPriceFee) * netPriceDiscountOne);
            }
            if (totalNumberOfOrders >= 30)
            {
                double netPriceDiscountTwo = 0.90;
                totalPrice = ((((netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder) * netPriceTax + netPriceShipping) * netPriceFee)* netPriceDiscountTwo);
            }
            

            //Begge metoder kan bruges.

            if (totalNumberOfOrders >= 30)
            {
                double netPriceDiscountTwo = 0.90;
                totalPrice = ((((netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder) * netPriceTax + netPriceShipping) * netPriceFee) * netPriceDiscountTwo);
            }                           
               else if (totalNumberOfOrders >= 15)
            {
                double netPriceDiscountOne = 0.95;
                totalPrice = ((((netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder) * netPriceTax + netPriceShipping) * netPriceFee) * netPriceDiscountOne);
            }


            // This variable should contain the total price for the order

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");

            // The LAST line of code should be ABOVE this line
        }
    }
}