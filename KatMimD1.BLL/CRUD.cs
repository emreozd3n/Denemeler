using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatMimD1.DAL;

namespace KatMimD1.BLL
{
    public class CRUD
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        public List<Categories> SelectAll()
        {
            return db.Categories.ToList();
        }

        public void Insert (Categories eleman)
        {
            db.Categories.Add(eleman);
            db.SaveChanges();
        }

        public void Update (Categories eleman)
        {
            Categories guncellenen = db.Categories.Find(eleman.CategoryID);
            db.Entry(guncellenen).CurrentValues.SetValues(eleman);
            db.SaveChanges();
        }

        public void Delete (Categories eleman)
        {
            Categories silinen = db.Categories.Find(eleman.CategoryID);
            db.Categories.Remove(silinen);
            db.SaveChanges();
        }

        public void SelectId (Categories eleman)
        {
            Categories bul = db.Categories.Find(eleman.CategoryID);
        }

    }
}
