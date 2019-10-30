using FinalProject.BaseFiles;


using System;

using System.Collections.Generic;

using System.Text;



namespace FinalProject.DeviceFacade

{

    public class ReaderRegistration

    {

        private IReader reader;



        public ReaderRegistration(IReader reader)

        {

            this.reader = reader;

        }

    } // end class

} // end namespace