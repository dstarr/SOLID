using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OCP._2;

public class JsonFileProcessor
{
    public class CsvFileProcessor : IFileProcessor
    {
        public void ProcessFile(string filePath)
        {
            // process JSON file
        }
    }
}