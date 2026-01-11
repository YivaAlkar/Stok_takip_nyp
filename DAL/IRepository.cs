using System.Collections.Generic;

namespace StokSatisTakipSistemi.DAL
{
    public interface IRepository<T>
    {
        List<T> Listele();
        void Ekle(T entity);
        void Guncelle(T entity);
        void Sil(int id);
    }
}
