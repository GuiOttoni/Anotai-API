﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Anotai.Api.Database
{
    public class DatabaseControl
    {
        private String connectionString = "";

        public DatabaseControl(string connection)
        {
            this.connectionString = connection;
        }
    }
}
