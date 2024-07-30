using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Baby
    {
        // Private alanlar (fields)
        private string _ad;
        private string _soyad;
        private DateTime _dogumTarihi;

        // Public özellikler (properties)
        public string Name
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string Surname
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public DateTime BirthDay
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }

        // Parametresiz kurucu metot (constructor)
        public Baby()
        {
            Default(); // Varsayılan değerleri ayarla
        }

        // Parametreli kurucu metot (constructor)
        public Baby(string name, string surname)
        {
            Default(); // Varsayılan değerleri ayarla
            _ad = name; // İsim değerini ata
            _soyad = surname; // Soyisim değerini ata
        }

        // Varsayılan değerleri ayarlayan özel metot (method)
        private void Default()
        {
            System.Console.WriteLine("Ingaaaa"); // Konsola bir mesaj yazdır
            _dogumTarihi = DateTime.Now; // Doğum tarihini şimdiki zaman olarak ayarla
        }
    }
}
