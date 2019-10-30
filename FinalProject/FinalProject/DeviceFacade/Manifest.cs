using FinalProject.AbstractFiles;

using System;

using System.Collections.Generic;

using System.Text;



namespace FinalProject.DeviceFacade

{

    public class Manifest

    {

        private List<AbstractReaderBase> _readers;

        private int _formWidth = 100;

        private decimal _total;



        public Manifest(List<AbstractReaderBase> readers)

        {

            this._readers = readers;



            string manifestTitle = "MANIFEST";

            string titleFormat = String.Format("{0,9}", manifestTitle);

            Console.WriteLine(titleFormat);

            Console.WriteLine();



            Title();

        } // end method public manifest



        private void Title()

        {

            Console.WriteLine();

            string title = "ACME Umbrella Company";

            string address = "5552 Regal Spec Drive";

            string city = "Amityville, CO, 65397";

            string titleFormat = String.Format("{0,25}", title);

            string addressFormat = String.Format("{0,25}", address);

            string cityFormat = String.Format("{0,25 }", city);

            Console.WriteLine(titleFormat);

            Console.WriteLine(addressFormat);

            Console.WriteLine(cityFormat);

            Console.WriteLine();

            DataHeaders();



        } // end method private void title



        private void DataHeaders()

        {

            Underline();

            Console.WriteLine();

            String data = String.Format("{0,5} {1,25} {2,35}", "QTY", "DESCRIPTION", "AMOUNT");

            Console.WriteLine(data);

            Underline();

            Console.WriteLine();

            Console.WriteLine();

            Display();

        } // end method private void dataheaders



        private void Underline()

        {

            for (int i = 0; i < _formWidth; i++)

            {

                Console.Write("-");

            } // end method for

        } // end method void underline



        private void Display()

        {

            string Desc = " ";

            foreach (AbstractReaderBase item in _readers)

            {

                if (item.PlayGames)

                {

                    Desc = item.EReaderDescript + " " + item.AndroidOS;



                }

                else

                {

                    Desc = item.EReaderDescript;



                }

                _total += item.Price;

                string Cart = string.Format("{0,5} {1,25}{2,35}", 1, Desc, item.Price);

                Console.WriteLine(Cart);

            }

            ShowTotal();

        }

        private void ShowTotal()

        {

            string myCart = string.Format("{0,100}", " Cart Total $" + _total);

            Console.WriteLine(myCart);

        }





    } // end class
} // end namespace