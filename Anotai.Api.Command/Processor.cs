using Anotai.Api.Command.Util;
using Anotai.Api.Core.Configuration;
using Anotai.Api.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anotai.Api.Command
{
    public class Processor
    {
        protected DatabaseControl DbControl;
        protected RestExecutor restExecutor;
        protected MyOptions myOptions;

        public Processor(string connection, MyOptions _myOptions)
        {
            DbControl = new DatabaseControl(connection);
            restExecutor = new RestExecutor();
            myOptions = _myOptions;
        }
    }
}
