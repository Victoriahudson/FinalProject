using FinalProject.AbstractFiles;

using FinalProject.DeviceFacade;

using System;

using System.Collections.Generic;



namespace FinalProject

{

    class Program

    {

        static void Main(string[] args)

        {

            MyOtherList();

        }



        public static void MyOtherList()

        {

            List<AbstractReaderBase> myReadList = new List<AbstractReaderBase>();

            myReadList.Add(new SevenInch());

            myReadList.Add(new NineInch());

            myReadList.Add(new TwelveInch());



            Manifest myManifest = new Manifest(myReadList);



        } // end method my other list

        public void MySecondList()

        {

            List<AbstractReaderBase> myReadList = new List<AbstractReaderBase>();

            myReadList.Add(new SevenOLED());

            myReadList.Add(new NineOLED());

            myReadList.Add(new TwelveOLED());



            foreach (AbstractReaderBase item in myReadList)

            {

                Console.WriteLine(item.AndroidOS, item.Charger, item.GPS, item.HeadPhoneJack, item.Headphones, item.Manual,

                    item.SDCardReader, item.Price, item.ColorDisplay, item.ColorType, item.PlayGames);

            } // end method for each

        } // end method my second list

    } // end class

} // end namespace