using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace L5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Относительный путь на директорию с файлом "Program.cs"
            var workDir = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));

            List<byte> inputMass = new List<byte>();
            
            while (true)
            {
                Console.WriteLine("Введите следующее число в диапазоне 0..255 или нажмите Enter для завершения:");
                var inputNumb = Console.ReadLine();
                if (String.IsNullOrEmpty(inputNumb)) break;
                
                inputMass.Add(Byte.Parse(inputNumb));
            }

            int massLength = inputMass.Count;

            BinarySerialize binarySerialize = new BinarySerialize(massLength);

            for (int i = 0; i < massLength; i++)
            {
                binarySerialize.matrix[i] = inputMass[i];
            }

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(workDir + "binarySerialize.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, binarySerialize);
            }

            /* Проверка десериализации (не требуется по заданию)
            BinarySerialize bin = new BinarySerialize(massLength);
            using (FileStream fs = new FileStream(workDir + "binarySerialize.bin", FileMode.OpenOrCreate))
            {
                bin = (BinarySerialize)formatter.Deserialize(fs);
            }
            */

        }
    }

    [Serializable]
    public class BinarySerialize
    {
        public byte[] matrix;
        public BinarySerialize(int length)
        {
            matrix = new byte[length];
        }
    }
}