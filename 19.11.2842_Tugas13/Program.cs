using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._11._2842_Tugas13
{
	public class Program
	{
		static void Main(string[] args)
		{
			// membuat objek mhs1
			Mahasiswa mhs1 = new Mahasiswa();
			mhs1.Nim = "1527";
			mhs1.NamaMahasiswa = "Bayu";

			// membuat objek mhs2
			Mahasiswa mhs2 = new Mahasiswa();
			mhs2.Nim = "5486";
			mhs2.NamaMahasiswa = "Siti";

			// membuat objek dosen
			Dosen dosen = new Dosen();
			dosen.Nik = "0043";
			dosen.NamaDosen = "Purnomo";

			// membuat objek list
			List<Mahasiswa> list = new List<Mahasiswa>();

			// memambahkan elemen list
			list.Add(mhs1);
			list.Add(mhs2);

			// mengakses elemen list
			// mahasiswa mhs = list[1];

			Console.WriteLine(" ______________");
			Console.WriteLine("|Nim   |   Nama|");
			Console.WriteLine("|______|_______|");

			foreach (Mahasiswa mhs in list)
			{
				Console.WriteLine(" {0}    {1}", mhs.Nim, mhs.NamaMahasiswa);
			}

			Console.ReadKey();
		}
	}
}
