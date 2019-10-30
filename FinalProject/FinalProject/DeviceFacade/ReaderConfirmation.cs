using FinalProject.AbstractFiles;

using System;

using System.Collections.Generic;

using System.Text;



namespace FinalProject.DeviceFacade

{

    public class ReaderConfirmation

    {

        private List<AbstractReaderBase> readerList;

        private string _incorrectResponse = "You have made an invalid selection. Please try your selection again.";

        private string _ReaderSize, _ReaderType;



        public void StartOrder()

        {

            readerList = new List<AbstractReaderBase>();

            Console.WriteLine("Welcome to the ACME Umbrella Company");

            Console.WriteLine("We sell state of the art EReaders");

            ReaderType();

        } // end method begin order



        private void ReaderType()

        {

            //Inquire what type of EReader the customer would like to purchase

            Console.WriteLine("We offer two types of readers: EInk and OLED in three different sizes: 7'', 9'' and 12''. " +

                "Please make your selection from the following below: ");

            Console.WriteLine("0 for EInk7, 1 for EInk9, 2 for EInk12, 3 for OLED7, 4 for OLED9, 5 for OLED12");

            _ReaderType = Console.ReadLine();



            if (ValidateType(_ReaderType))

            {



            }

            else

            {

                Console.WriteLine(_incorrectResponse);

                ReaderType();

            }

            ReaderType();

        } // end method add type



        private bool ValidateType(string readerType)

        {

            switch (readerType.ToLower())

            {

                case "0":

                case "1":

                case "2":

                case "3":

                case "4":

                case "5":

                    return true;

                default:

                    return false;

            } // end switch

        } // end method bool

    } // end class

} // end namespace 