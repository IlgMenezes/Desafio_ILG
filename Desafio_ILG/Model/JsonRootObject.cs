using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_ILG.Model
{
    public class JsonRootObject
    {
        public List<Data> data { get; set; }
    }

    public class Data
    {
        public int id { get; set; }

        public string name { get; set; }

    }
}
