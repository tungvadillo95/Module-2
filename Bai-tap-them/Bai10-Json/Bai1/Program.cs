using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bai1
{
    class Program
    {
        const int MULTIPLY_VALUE = 2;
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ASUS\Desktop\BT-CODEGYM\Module-2\Bai-tap-them\Bai10-Json\Bai1\data";
            string fileInput = "input.json";
            string fileOutput1 = "output1.json";
            string fileOutput2 = "output2.json";
            // Doc va console file input.json
            var result = new Root();
            using (StreamReader sr = File.OpenText($@"{filePath}\{fileInput}"))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Root>(data);
            }
            int number = 1;
            foreach (var item in result.data)
            {
                Console.Write($"Object {number}: a = {item.a}, b = {item.b}, c = {item.c}");
                Console.WriteLine();
                number++;
            }
            // Tao va viet output1.jason
            var reponse_output1 = new ResponseSum()
            {
                responses = new List<ResponseSumData>()
            };
            foreach(var item in result.data)
            {
                reponse_output1.responses.Add(new ResponseSumData()
                {
                    sum = item.Sum()
                });
            }
            using (StreamWriter sw = File.CreateText(@$"{filePath}\{fileOutput1}"))
            {
                var data = JsonConvert.SerializeObject(reponse_output1);
                sw.Write(data);
            }
            // Tao va viet output2.jason
            var reponse_output2 = new Root()
            {
                data = new List<Datum>()
            };
            foreach(var item in result.data)
            {
                reponse_output2.data.Add(new Datum()
                {
                    a = item.a* MULTIPLY_VALUE,
                    b = item.b* MULTIPLY_VALUE,
                    c = item.c* MULTIPLY_VALUE
                });
            }
            using (StreamWriter sw = File.CreateText(@$"{filePath}\{fileOutput2}"))
            {
                var data = JsonConvert.SerializeObject(reponse_output2);
                sw.Write(data);
            }
        }
    }
    public class ResponseSum
    {
        public List<ResponseSumData> responses { get; set; }
    }
    public class ResponseSumData
    {
        public int sum { get; set; }
    }
    public class Datum
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int Sum()
        {
            return a + b + c;
        }
    }
    public class Root
    {
        public List<Datum> data { get; set; }
    }

}
