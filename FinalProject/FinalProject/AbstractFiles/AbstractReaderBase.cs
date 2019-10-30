using FinalProject.BaseFiles;





namespace FinalProject.AbstractFiles

{

    public abstract class AbstractReaderBase : IReader

    {

        // Add the base objects the child class EInk7, 9  and 12 also OLED7, 9 and 12 will call from

        public string AndroidOS { get; set; } = "Android 9.0 Included";

        public string GPS { get; set; } = "GPS Included";

        public string WiFi { get; set; } = "WiFi Included";

        public string HeadPhoneJack { get; set; } = "HeadPhoneJack Included";

        public string SDCardReader { get; set; } = "SDCardReader Included";

        public string Charger { get; set; } = "Charger Included";

        public string Manual { get; set; } = "Manual Included";

        public string Headphones { get; set; } = "Headphones Included";

        public bool PlayGames { get; set; }

        public abstract string EReaderDescript { get; }





        public string ColorDisplay { get; set; }



        public ReaderColor ColorType { get; private set; }

        public abstract decimal Price { get; }



        public AbstractReaderBase(ReaderColor color, bool playGames)

        {

            ColorType = color;

            PlayGames = playGames;

        } // end method abstract reader



        public override string ToString()

        {

            return this.GetType().Name + " EReader Color is " + ColorType + " and costs $"

                + Price;

        } // end method override



    } // end class

} // end namespace