using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFirstDb db = new CodeFirstDb();
            db.Database.Create();

            //Database için (LocalDB)\MSSQLLocalDB buraya bağlanıyoruz//

            Kisiler k = new Kisiler();
            k.Ad = "Ali";
            k.Soyad = "Veli";
            k.TelNo = "4650";
            k.DogumTarihi = DateTime.UtcNow;
            k.TcKimlik = "484668686";
            k.Email = "dssad@ds.com";
            k.Cinsiyet = 1;
            dc.Kisiler.Add(k);
            dc.SaveChanges();
        }
    }
}
