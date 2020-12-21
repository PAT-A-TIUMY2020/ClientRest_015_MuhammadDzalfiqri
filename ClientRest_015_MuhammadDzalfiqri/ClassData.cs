using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ClientRest_015_MuhammadDzalfiqri
{
    class ClassData
    {
        public void getData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            foreach(var mhs in data)
            {
                Console.WriteLine("NIM: " + mhs.nim);
                Console.WriteLine("Nama: " + mhs.nama);
                Console.WriteLine("Prodi: " + mhs.prodi);
                Console.WriteLine("Angkatan: " + mhs.angkatan);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
