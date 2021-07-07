using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaAPICore.Models
{
    public class ResultEntityMessage<T>
    {
        public T entity { get; set; }
        public string message { get; set; }
        public bool status { get; set; }
    }
}
